using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace commonLibraries
{
    public class mediaTools
    {
        List<Media> content = new List<Media>(); //Alle Einträge der CSV, gleiche Reihenfolge wie die CSV
        List<Media> filteredList = new List<Media>(); //Liste mit gefilterten Einträgen
        List<Media> currentList = new List<Media>(); //aktuelle Liste (wird nur intern zum arbeiten genutzt)
        List<Media> randomList = new List<Media>(); //Liste in zufälliger Reihenfolge
        readonly FileHandling fh;
        string[] lastFilters = new string[3];
        bool lastWischlistState;
        bool alreadyFiltered = false;
        int currentpos = 0;
        int freeid;
        bool containsdummys;
        public mediaTools(string filePath,string imagePath,string backup)
        {
            try
            {
                fh = new FileHandling(filePath, imagePath, backup);
                content = fh.parseFile();
                content = content.OrderBy(x => x.id).ToList();
                freeid = fh.getLastID() + 1;

                createDefaultView();
            }
            catch (Exception ex)
            {
                throw ex;
            }
      
        }

        public List<Media> createDefaultView()
        {
            removeDummyEntrys(content);
            filteredList = content.FindAll(x => x.wishList == false);
            addDummyEntrys(filteredList);
            //shuffleList();
            currentList.Clear();
            currentList.AddRange(filteredList);
            return filteredList;
            
        }
        public List<Media> getFilteredList()
        {
            currentList.Clear();
            currentList.AddRange(filteredList);
            return filteredList;

        }
        public void filterList(string[] types, bool wischList, List<string> genres =null)
        {
            List<Media> workList = new List<Media>();
            removeDummyEntrys(filteredList);
            lastWischlistState = wischList;
            workList= content.FindAll(x => x.wishList == wischList);
            //List<string> allGenres = getGenreList();
            if(genres!=null)
            {
                List<Media> tempList = new List<Media>();
                foreach(Media m in workList)
                {
                    List<string> entryGenres = m.genre.Split('|').ToList();
                    /*if (entryGenres.Any(x => genres.Any(y => y == x)))
                    {
                        tempList.Add(m);
                    }*/
                    foreach(string entry in genres)
                    {
                        string trimmed = entry.Trim();
                        if(entryGenres.Contains(trimmed))
                        {
                            tempList.Add(m);
                            break;
                        }
                    }

                }
                workList.Clear();
                workList.AddRange(tempList);
                //workList = workList.FindAll(x => x.genre.Contains(genres));
            }
            
            List<Media> loopList = new List<Media>();
            loopList.AddRange(workList);
            filteredList.Clear();
            lastFilters = types;
            for (int i=0;i<types.Count();i++)
            {
                if(types[i]!=null&&types[i]!="")
                {
                    filteredList.AddRange(loopList.FindAll(x => x.type == types[i]));
                }
                
            }
            if(filteredList.Count==0)
            {
                filteredList.AddRange(workList);
            }

            addDummyEntrys(filteredList);
            filteredList.OrderBy(x => x.id);
            /*if (type != "")
            {
                filteredList.Clear();
                filteredList.AddRange(workList.FindAll(x => x.type == type));
            }*/
            //shuffleList();
        }
        private void shuffleList()
        {
            List<Media> workList = new List<Media>();
            Random rnd = new Random();
            if(!alreadyFiltered)
            {
                filterList(lastFilters, lastWischlistState);
                alreadyFiltered = true;
            }
            alreadyFiltered = false;
            removeDummyEntrys(filteredList);
            workList.AddRange(filteredList);
            randomList = workList.OrderBy(x => rnd.Next()).ToList();
            addDummyEntrys(randomList);
        }
        public List<Media> getRandomList()
        {
            shuffleList();
            Random rnd = new Random();
            if (currentList.Count > 0)
            {
                List<Media> suggestions = new List<Media>();
                if (currentpos + 4 >= randomList.Count - 1)
                {
                    currentpos = 0;
                    shuffleList();
                    currentList.Clear();
                    removeDummyEntrys(randomList);
                    currentList.AddRange(randomList);

                }

                for (int i = currentpos; i < currentpos + 3; i++)
                {
                    suggestions.Add(randomList[i]);
                }
                currentpos += 4;
                //currentList.Clear();
                //currentList.AddRange(suggestions);
                return suggestions;
            }
            else
            {
                return null;
            }
        }
        public Media getItem(int position)
        {
            return currentList[position];
        }
        public void resetFilter()
        {
            currentList.Clear();
            currentList.AddRange(content.FindAll(x => x.wishList == false));
            filteredList.Clear();
            filteredList.AddRange(currentList);
        }
        public List<Media> findEntrys(string text)
        {
            List<Media> searchbase = content.FindAll(x => x.wishList == false);
            List<Media> results;
            results = searchbase.FindAll(x => x.name.ToLower().Contains(text.ToLower()));
            results.OrderBy(x => x.name);
            return results;
        }
        public bool createNewEntry(string[]args,string source,int id =-1)
        {
            try
            {
                string entry;
                if (id>-1)
                {
                   entry  = id + ";" + String.Join(";", args);
                }
                else
                {
                    entry = freeid + ";" + String.Join(";", args);
                }
                Media m = fh.parseString(entry);
                removeDummyEntrys(content);
                content.Add(m);
                fh.copyImage(source, m.pictureName);
                filterList(lastFilters, lastWischlistState);
                fh.addEntry(entry);
                addDummyEntrys(content);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void removeEntry(Media m,bool editMode)
        {
            content.Remove(m);
            removeDummyEntrys(filteredList);
            filterList(lastFilters, lastWischlistState);
            shuffleList();
            
            fh.removeEntry(m.pictureName,editMode,content);
        }
        private void addDummyEntrys(List<Media> myList)
        {
            if (!Environment.OSVersion.ToString().Contains("Windows"))
            {
                for (int i = 0; i < 3; i++)
                {
                    Media dummy = new Media(9997 + i, "DummieEintrag" + i + 1);
                    dummy.setPicture("DummyFile1");
                    myList.Add(dummy);
                }
            }
        }
        private void removeDummyEntrys(List<Media> myList)
        {
            myList.RemoveAll(x => x.name.StartsWith("DummieEintrag"));
        }
        public List<string> getGenreList()
        {
            return fh.getGenreList();
        }
        public List<Media> getAllEntrys()
        {
            return content;
        }
        public List<Genre> createGenreClass()
        {
            GenreList gr = new GenreList(getGenreList());
            return gr.getGenreList();

        }
        public bool convertEmtry(string[] args, int id)
        {
            try
            {
                string entry;
                entry = id + ";" + String.Join(";", args);
                fh.addEntry(entry);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void clearFileList()
        {
            fh.clearEntrys();
        }
        public int getlastID()
        {
            return content.Max(x => x.id);
        }
    }
}

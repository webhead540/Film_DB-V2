using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Diagnostics;
namespace commonLibraries
{
    internal class FileHandling
    {
        
        List<string> entrys = new List<string>();
        List<string> genres = new List<string>();
        int lastID;
        string csvPath;
        string backupFileName;
        string picturePath;
        string userName = Environment.UserName;
        internal FileHandling(string fileName, string imagePath, string backup)
        {
            csvPath = fileName;
            backupFileName = backup;
            picturePath = imagePath;
        }
        internal string createNewEntryString(Media m)
        {
            string entry = String.Join(";", new string[] { m.id.ToString(), m.name, m.link, m.dateAdded.ToShortDateString(), m.rating.ToString(), m.type, m.parts.ToString() });
            if (m.pictureName != "")
            {
                entry +=";"+ m.pictureName;
            }
            entry += ";" + m.wishList.ToString();
            if(m.genre!="")
            {
                entry += ";" + m.genre;
            }
            
            if(m.lastWatchDate>DateTime.MinValue)
            {
                entry+=";"+ m.lastWatchDate.ToShortDateString();
            }
            return entry;
        }
        internal void addEntry(string entry)
        {
            entrys.Add(entry);
            saveFile();
        }
        internal void removeEntry(string imageName,bool editMode,List<Media> content)
        {
            try
            {
                entrys.Clear();
                entrys = null;
                entrys = createEntryList(content);
                if(userName!="Patrick")
                {
                    if(!editMode)
                    {
                        File.Delete(Path.Combine(picturePath, imageName));
                    }
                    
                }
                saveFile();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        internal bool saveFile()
        {
            try
            {
                File.WriteAllLines(csvPath, entrys);
                if(backupFileName!="")
                {
                    File.WriteAllLines(backupFileName, entrys);
                }
                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        internal List<Media> parseFile()
        {
            List<Media> content = new List<Media>();
            try
            {
                entrys = File.ReadAllLines(csvPath).ToList();
                //int freeId = 0;
                int curIndex = 0;
                foreach (string entry in entrys)
                {
                    Debug.Print(curIndex.ToString());
                    Media m = parseString(entry);
                    parseGenreString(m.genre);
                    content.Add(m);
                    curIndex++;
                }
                genres = genres.Distinct().ToList();
                return content;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        internal Media parseString(string stringToParse)
        {
            try
            {
                String[] parts = stringToParse.Split(';');
                Media m = new Media(Convert.ToInt32(parts[0]));
                lastID = m.id;
                m.setName(parts[1]);
                m.setLink(parts[2]);
                m.setWatchDate(Convert.ToDateTime(parts[3]));
                if (parts[3] != "")
                {
                    m.setRating(Convert.ToInt32(parts[4]));
                }
                else
                {
                    m.setRating(0);
                }
                if (parts[5] == "Film")
                {
                    m.setType("Film");
                    m.setParts(0);
                }
                else if ((parts[5] == "Serie"))
                {
                    m.setType("Serie");
                    m.setParts(Convert.ToInt32(parts[6]));
                }
                else
                {
                    m.setType("Anime");
                    m.setParts(Convert.ToInt32(parts[6]));
                }

                if (parts[7] != "")
                {
                    m.setPicture(parts[7].Replace("\\", ""));
                }
                if (parts.Count() > 8) //kompatibilität zur alten Liste ohne die Wunschliste
                {
                    if (parts[8] != "")
                    {
                        m.setWishlist(Convert.ToBoolean(parts[8]));
                    }
                    if (parts.Count() > 9) //Kompatibilität zur alten Liste ohne Genre
                    {
                        m.setGenre(parts[9]);
                        if (parts.Count()>10) //Kompatibilität zur alten Liste ohne zuletzt geschaut
                        {
                            m.setLastWatchDate(DateTime.Parse(parts[10]));
                        }
                        else
                        {
                            m.setLastWatchDate(DateTime.MinValue);
                        }
                    }
                    else 
                    {
                        m.setGenre(""); 
                    }
                }
                return m;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        internal int getLastID()
        {
            return lastID;
        }
        private void checkFolder()
        {
            if (!Directory.Exists(picturePath))
            {
                Directory.CreateDirectory(picturePath);
            }
        }
        internal void copyImage(string source, string destFileName)
        {
            try
            {
                checkFolder();
                if (!File.Exists(picturePath + "\\" + destFileName))
                {
                    File.Copy(source, picturePath + "\\" + destFileName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        internal void parseGenreString(string genreString)
        {
            if(genreString!=null&&genreString!="")
            {
                genres.AddRange(genreString.Split('|'));
            }

        }
        public List<string> getGenreList()
        {
            return genres;
        }
        public List<string> createEntryList(List<Media> allContent)
        {
            List<string> allEntrys = new List<string>();
            foreach(Media m in allContent)
            {
                allEntrys.Add(createNewEntryString(m));
            }
            return allEntrys;
        }
    }
}

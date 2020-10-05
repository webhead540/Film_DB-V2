using System;
using System.Collections.Generic;
using System.Linq;


namespace commonLibraries
{
    public class Media
    {
        #region globale Variablen
        #region Strings
        public string name { get; private set; }
        public string link { get; private set; }
        public string genre { get; private set; }
        public string type { get; private set; }
        public string pictureName { get; private set; }
        #endregion
        #region integer
        public int rating { get; private set; }
        public int parts { get; private set; }
        public int id { get; private set; }
        #endregion
        #region Boolean
        public bool wishList { get; private set; }
        public bool finished { get; private set; }
        public bool started { get; private set; }
        #endregion
        #region DateTime
        public DateTime lastWatchDate { get; private set; }
        public DateTime dateAdded { get; private set; }
        #endregion
        #endregion
        #region Konstruktoren
        internal Media(int m_id)
        {
            id = m_id;
        }
        internal Media(int m_id, string movieName)
        {
            name = movieName;
            id = m_id;
        }
        internal Media(int m_id, string movieName, DateTime date)
        {
            name = movieName;
            dateAdded = date;
            id = m_id;
        }
        internal Media(int m_id, string movieName, DateTime date, string mType)
        {
            dateAdded = date;
            name = movieName;
            type = mType;
            id = m_id;
        }
        internal Media(int m_id, string movieName, DateTime date, string mType, string url)
        {
            dateAdded = date;
            name = movieName;
            type = mType;
            link = url;
            id = m_id;

        }
        internal Media(int m_id, string movieName, DateTime date, string mType, string url, int stars)
        {
            dateAdded = date;
            name = movieName;
            type = mType;
            link = url;
            rating = stars;
            id = m_id;
        }
        #endregion
        #region Methoden
        internal void setRating(int value)
        {
            rating = value;
        }
        internal void setLink(string url)
        {
            link = url;
        }
        internal void setType(string mType)
        {
            type = mType;
        }
        internal void setName(string movieName)
        {
            name = movieName;
        }
        internal void setWatchDate(DateTime date)
        {
            dateAdded = date;
        }
        internal void setPicture(string picture)
        {
            pictureName = picture;
        }
        internal void setParts(int seriesParts)
        {
            parts = seriesParts;
        }
        internal void setWishlist(bool wantToSee)
        {
            wishList = wantToSee;
        }
        internal void setID(int newID)
        {
            id = newID;
        }
        internal void setLastWatchDate(DateTime date)
        {
            lastWatchDate = date;
        }
        internal void setGenre(string cat)
        {
            if (cat == null)
            {
                genre = "";
            }
            genre = cat;
        }
        internal void setState(bool started, bool finisched)
        {

            this.finished = finisched;
            this.started = started;
            if(started==true||finisched==true)
            {
                this.wishList = false;
            }

        }
        #endregion
    }
    public class Genre
    {
        int id;
        string name;
        public Genre(int id, string name)
        {
            this.name = name;
            this.id = id;
        }
    }
    public class GenreList
    {
        List<Genre> allgenres = new List<Genre>();
        public GenreList(List<string> genreStrings)
        {
            int i = 0;
            foreach (string genre in genreStrings)
            {

                allgenres.Add(new Genre(i, genre));
                i++;
            }
        }
        public List<Genre> getGenreList()
        {
            return allgenres;
        }
    }
}

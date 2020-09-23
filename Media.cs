using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_DB_V2
{
    public class Media
    {
        public string name { get; private set; }
        public string link { get; private set; }
        public int rating { get; private set; }
        public DateTime dateAdded { get; private set; }
        public string type { get; private set; } 
        public int parts { get; private set; }
        public string pictureName { get; private set; }
        public int id { get; private set; }
        public bool wishList { get; private set; }
        public DateTime lastWatchDate { get; private set; }
        public string category { get; private set; }
        public Media(int m_id)
        {
            id = m_id;
        }
        public Media(int m_id,string movieName)
        {
            name = movieName;
            id = m_id;
        }
        public Media(int m_id,string movieName,DateTime date)
        {
            name = movieName;
            dateAdded = date;
            id = m_id;
        }
        public Media(int m_id,string movieName,DateTime date, string mType)
        {
            dateAdded = date;
            name = movieName;
            type = mType;
            id = m_id;
        }
        public Media(int m_id,string movieName, DateTime date, string mType,string url)
        {
            dateAdded = date;
            name = movieName;
            type = mType;
            link = url;
            id = m_id;

        }
        public Media(int m_id,string movieName, DateTime date, string mType, string url,int stars)
        {
            dateAdded = date;
            name = movieName;
            type = mType;
            link = url;
            rating = stars;
            id = m_id;

        }
        public void setRating(int value)
        {
            rating = value;
        }
        public void setLink(string url)
        {
            link = url;
        }
        public void setType(string mType)
        {
            type = mType;
        }
        public void setName(string movieName)
        {
            name = movieName;
        }
        public void setWatchDate(DateTime date)
        {
            dateAdded = date;
        }
        public void setPicture(string picture)
        {
            pictureName = picture;
        }
        public void setParts(int seriesParts)
        {
            parts = seriesParts;
        }
        public void setWishlist(bool wantToSee)
        {
            wishList = wantToSee;
        }
        public void setID(int newID)
        {
            id = newID;
        }
        public void setLastWatchDate(DateTime date)
        {
            lastWatchDate = date;
        }
        public void setCategory(string cat)
        {
            category = cat;
        }
       
    }
}

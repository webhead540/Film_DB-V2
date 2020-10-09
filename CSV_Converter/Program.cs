using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using commonLibraries;

namespace CSV_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+"\\filme.csv";
            mediaTools mt = new mediaTools(csvPath,"","");
            List<Media> allEntrys= mt.getAllEntrys();
            List<Media> convertedEntrys = new List<Media>();
            mt.clearFileList();
            foreach (Media m in allEntrys)
            {
                List<string> data = new List<string>();
                data.AddRange(new string[] { m.name, m.link, m.dateAdded.ToShortDateString(), m.rating.ToString(), m.type, m.parts.ToString(), m.pictureName, m.wishList.ToString(), m.genre, m.lastWatchDate.ToShortDateString() }); ;
                if(m.wishList)
                {
                    data.Add("false;false");
                }
                else
                {
                    data.Add("false;true");
                }
                mt.convertEmtry(data.ToArray(), m.id);
            }
        }
    }
}

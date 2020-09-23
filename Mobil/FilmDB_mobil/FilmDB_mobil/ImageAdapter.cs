using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using commonLibraries;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Drawing;
using System.IO;


namespace FilmDB_mobil
{
    public class ImageAdapter : BaseAdapter
    {
        Context context;
        List<Media> mediaList;
        string imageDir;
        int width = 342;
        int height = 560;
        public ImageAdapter(Context c,List<Media> m, string directory)
        {
            context = c;
            mediaList = m;
            imageDir = directory;
        }

        public override int Count
        {
            get { return mediaList.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            try
            {

                ImageView imageView;

                if (convertView == null)
                {  // if it's not recycled, initialize some attributes
                    imageView = new ImageView(context);
                    imageView.LayoutParameters = new GridView.LayoutParams(width, height);
                    imageView.SetScaleType(ImageView.ScaleType.FitCenter);
                    imageView.SetPadding(20, 20, 20, 20);
                }
                else
                {
                    imageView = (ImageView)convertView;
                }
                if (mediaList[position].pictureName != null)
                {
                    Android.Graphics.Bitmap b = Android.Graphics.BitmapFactory.DecodeFile(Path.Combine(imageDir, mediaList[position].pictureName));
                    Android.Graphics.Bitmap scaled = null;
                    if (b != null)
                    {
                        float factor = 500 / (float)b.Height;
                        //scaled = Android.Graphics.Bitmap.CreateScaledBitmap(b, (int)(b.Width * factor), 500, true);
                        scaled = Android.Graphics.Bitmap.CreateScaledBitmap(b, width, height, true);
                    }
                    imageView.SetImageBitmap(scaled);
                }
                return imageView;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
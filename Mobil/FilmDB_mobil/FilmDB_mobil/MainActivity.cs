using System;
using Android.App;
using pie = Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using commonLibraries;
using Xamarin.Essentials;
using System.Timers;

namespace FilmDB_mobil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btnFilter;
        private Button btnSuggest;
        private Button btnSearch;
        private CheckBox cbxMovie;
        private CheckBox cbxSeries;
        private CheckBox cbxAnime;
        private CheckBox cbxWischlist;
        private TextView tbxSearch;
        private GridView grvContent;
        private CoordinatorLayout mainLayout;
        mediaTools mt;
        List<Media> current;
        //List<Media> randomList;

        string fileName = "";
        string picturePath;
        bool wischListState = false;
        bool isSuggest = false;
        bool isSearch = false;
        int clickCount = 0;
        bool timerRunning = false;
        AdapterView.ItemClickEventArgs a;
//        const int clickDelay = 300;
        Timer tmrClickDelay = new Timer(300);
        Android.Content.Context c;
        //      int currentpos;


        //Color colBack = Color.FromArgb(54, 57, 63);
        //Color colFont = Color.FromArgb(224, 224, 224);
        protected override void OnCreate(pie.Bundle savedInstanceState)
        {
            fileName = Path.Combine(pie.Environment.ExternalStorageDirectory.AbsolutePath, pie.Environment.DirectoryDocuments, "filme.csv");
            picturePath = Path.Combine(pie.Environment.ExternalStorageDirectory.AbsolutePath, pie.Environment.DirectoryPictures, "FilmDB");

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            btnFilter = FindViewById<Button>(Resource.Id.btn_Filter);
            btnSuggest = FindViewById<Button>(Resource.Id.btn_suggest);
            btnSearch = FindViewById<Button>(Resource.Id.btnSearch);
            cbxAnime = FindViewById<CheckBox>(Resource.Id.cbxAnime);
            cbxMovie = FindViewById<CheckBox>(Resource.Id.cbxMovie);
            cbxSeries = FindViewById<CheckBox>(Resource.Id.cbxSeries);
            cbxWischlist = FindViewById<CheckBox>(Resource.Id.cbxWishlist);
            grvContent = FindViewById<GridView>(Resource.Id.grvContent);
            mainLayout = FindViewById<CoordinatorLayout>(Resource.Id.mainLayout);
            tbxSearch = FindViewById<EditText>(Resource.Id.tbxSearch);
            grvContent.ItemLongClick += itemLongClick;
            grvContent.ItemClick += itemClick;
            //fab.Click += FabOnClick;
            btnFilter.Click += btnFilter_Click;
            btnSearch.Click += btnSearch_Click;
            btnSuggest.Click += btnSuggest_Click;
            cbxAnime.Click += cbxClicked;
            cbxMovie.Click += cbxClicked;
            cbxSeries.Click += cbxClicked;
            cbxWischlist.Click += cbxClicked;
            fab.Visibility = ViewStates.Invisible;
            try
            {
                mt = new mediaTools(fileName, picturePath, "");
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "beim Einlesen der CSV trat ein Fehler auf:"+Environment.NewLine + ex.Message, ToastLength.Short).Show();
            }
            
            tmrClickDelay.Enabled = true;
            tmrClickDelay.Elapsed += OnTimedEvent;
            //randomList = mt.getRandomList();
            fillGui(true);
            /*ViewGroup.LayoutParams layoutParams = (ViewGroup.LayoutParams)grvContent.LayoutParameters;
            layoutParams.Height = this.Resources.DisplayMetrics.HeightPixels - 130;
            layoutParams.Width = this.Resources.DisplayMetrics.WidthPixels;
            grvContent.LayoutParameters = layoutParams;*/

        }
        protected void OnAppearing()
        {
            fillGui(true);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        //private void btnFilter_click
        private void btnFilter_Click(object sender, EventArgs eventArgs)
        {
            fillGui(false);
        }
        private void btnSuggest_Click(object sender, EventArgs eventArgs)
        {

            //Random rnd = new Random();
            //if (current.Count > 0)
            //{
            //    List<Media> suggestions = new List<Media>();
            //    if (currentpos + 4 >= mt.getRandomList().Count - 1)
            //    {
            //        currentpos = 0;
            //        randomList = mt.getRandomList();
            //        current.Clear();
            //        current.AddRange(randomList);

            //    }

            //    for (int i = currentpos; i < currentpos + 3; i++)
            //    {
            //        suggestions.Add(randomList[i]);
            //    }
            //    currentpos += 4;
            //    current.Clear();
            //    current.AddRange(suggestions);
            current = mt.getRandomList();
            if (current.Count > 0)
            {
                fillGui(false,true);
            }
            else
            {
                Toast.MakeText(this, "Es gibt nix zum Vorschlagen", ToastLength.Short).Show();
            }
        }
        private void cbxClicked(object sender, EventArgs e)
        {
            if (cbxWischlist.Checked)
            {
                wischListState = true;
            }
            else
            {
                wischListState = false;
            }
            string[] selectedTypes = new string[3];
            if (cbxAnime.Checked)
            {
                selectedTypes[0] = "Anime";
            }
            if (cbxMovie.Checked)
            {
                selectedTypes[1] = "Film";
            }
            if (cbxSeries.Checked)
            {
                selectedTypes[2] = "Serie";
            }
            mt.filterList(selectedTypes, wischListState);
        }
        private void fillGui(bool firstRun,bool random = false)
        {
            try
            {
                int count = 0;
                if (random)
                {
                    List<Media> tempList = new List<Media>();
                    grvContent.Adapter = null;
                    grvContent.Adapter = new ImageAdapter(this, tempList, picturePath);
                    grvContent.Adapter = new ImageAdapter(this, current, picturePath);
                    count = current.Count();
                    isSuggest = true;
                }
                else if(isSearch)
                {
                    grvContent.Adapter = new ImageAdapter(this, current, picturePath);
                    count = current.Count();
                }

                else
                {
                    if (isSuggest)
                    {
                        mt.resetFilter();
                        isSuggest = false;
                    }
                    if(firstRun)
                    {
                        current = mt.createDefaultView();
                    }
                    else
                    {
                        current = mt.getFilteredList();
                    }
                    
                    grvContent.Adapter = new ImageAdapter(this, current, picturePath);
                    count = current.Count();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Lass den Mist!", ToastLength.Short).Show();
                Toast.MakeText(this, "Fehler: " + ex.Message, ToastLength.Short).Show();
            }
        }
        private void itemLongClick(object sender, AdapterView.ItemLongClickEventArgs args)
        {
            if (current[args.Position].link != "")
            {
                Browser.OpenAsync(current[args.Position].link);
            }
            else
            {
                Toast.MakeText(this, "Um einen Link zu öffnen, musst du ihn erstmal hinterlegen", ToastLength.Short).Show();
            }

        }
        private void itemClick(object sender, AdapterView.ItemClickEventArgs args)
        {
            if(current[args.Position].type=="Film")
            {
                Toast.MakeText(this, current[args.Position].name + Environment.NewLine+ Environment.NewLine + "Typ: " + current[args.Position].type + Environment.NewLine + "Bewertung: " + current[args.Position].rating + Environment.NewLine + "geschaut am: " + current[args.Position].dateAdded, ToastLength.Short).Show();
            }
            else
            {
                if(current[args.Position].parts==1)
                {
                    Toast.MakeText(this, current[args.Position].name + Environment.NewLine + Environment.NewLine + "Typ: " + current[args.Position].type + Environment.NewLine + current[args.Position].parts + " Staffel" + Environment.NewLine + "Bewertung: " + current[args.Position].rating + Environment.NewLine + "geschaut am: " + current[args.Position].dateAdded, ToastLength.Short).Show();
                }
                else if(current[args.Position].parts>1)
                {
                    Toast.MakeText(this, current[args.Position].name + Environment.NewLine + Environment.NewLine + "Typ: " + current[args.Position].type + Environment.NewLine + current[args.Position].parts + " Staffeln" + Environment.NewLine + "Bewertung: " + current[args.Position].rating + Environment.NewLine + "geschaut am: " + current[args.Position].dateAdded, ToastLength.Short).Show();
                }
            }
                

            /*if (!timerRunning)
            {
                tmrClickDelay.Start();
                a = args;
                c = this;
            }*/
            clickCount++;
            //Toast.MakeText(this, "Click: " + clickCount, ToastLength.Short).Show();

            /*if(DateTime.Now.Millisecond <=lastClickTime+clickDelay)
            {
                
                lastClickTime = 0;
            }
            else
            {
                lastClickTime = DateTime.Now.Millisecond;
                Toast.MakeText(this, current[args.Position].name, ToastLength.Short).Show();
            }*/
            
            
        }
        private void btnSearch_Click(object sender, EventArgs eventArgs)
        {
            if(tbxSearch.Text!="")
            {
                current = mt.findEntrys(tbxSearch.Text);
                isSearch = true;
            }
            else
            {
                isSearch = false;
            }
            fillGui(false,false);
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            tmrClickDelay.Stop();
            if (clickCount>=2)
            {
                Toast t = new Toast(this);
                t.SetText("");
                t.Duration = ToastLength.Short;
                t.Show();
            }
            else
            {
                
            }
            clickCount = 0;
            timerRunning = false;
            
        }
    }
}
//Bugs:
//letzte Reihe wird nur zu 1/3 angezeigt
//instabil beim schnellen Scrollen

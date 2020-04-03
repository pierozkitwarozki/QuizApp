using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace QuizApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false, NoHistory = true)]
    public class MainActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        LinearLayout historyLayout;
        LinearLayout geographyLayout;
        LinearLayout spaceLayout;
        LinearLayout engineeringLayout;
        LinearLayout programmingLayout;
        LinearLayout businessLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

            //Setup toolbar
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Topics";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            //View Setups
            historyLayout = FindViewById<LinearLayout>(Resource.Id.historyLayout);
            geographyLayout = FindViewById<LinearLayout>(Resource.Id.geographyLayout);
            spaceLayout = FindViewById<LinearLayout>(Resource.Id.spaceLayout);
            engineeringLayout = FindViewById<LinearLayout>(Resource.Id.engineeringLayout);
            programmingLayout = FindViewById<LinearLayout>(Resource.Id.programmingLayout);
            businessLayout = FindViewById<LinearLayout>(Resource.Id.businessLayout);

            //Click Event Handlers
            historyLayout.Click += HistoryLayout_Click;
            geographyLayout.Click += GeographyLayout_Click;
            spaceLayout.Click += SpaceLayout_Click;
            engineeringLayout.Click += EngineeringLayout_Click;
            programmingLayout.Click += ProgrammingLayout_Click;
            businessLayout.Click += BusinessLayout_Click;

        }

        private void BusinessLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Business");
            StartActivity(intent);
        }

        private void ProgrammingLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Programming");
            StartActivity(intent);
        }

        private void EngineeringLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Engineering");
            StartActivity(intent);
        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }

        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }

        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "History");
            StartActivity(intent);
        }
    }
}
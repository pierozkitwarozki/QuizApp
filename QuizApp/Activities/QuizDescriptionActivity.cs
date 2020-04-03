using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace QuizApp
{
    [Activity(Label = "QuizDescriptionActivity", Theme = "@style/AppTheme")]
    public class QuizDescriptionActivity : AppCompatActivity
    {
        TextView topicTextView;
        TextView topicDescriptionTextView;

        ImageView quizImage;

        Button startQuizButton;

        string quizTopic;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_selected_topic);

            //View Setups
            topicTextView = FindViewById<TextView>(Resource.Id.topicTextView);
            topicDescriptionTextView = FindViewById<TextView>(Resource.Id.topicDescriptionTextView);
            quizImage = FindViewById<ImageView>(Resource.Id.quizImage);
            startQuizButton = FindViewById<Button>(Resource.Id.startQuizButton);

            //Get string
            quizTopic = Intent.GetStringExtra("topic");
            topicTextView.Text = quizTopic;

            //Get Topic Image
            quizImage.SetImageResource(GetImage(quizTopic));
        }

        private int GetImage(string topic)
        {
            int imageInt = 0;
            if(topic == "History")
            {
                imageInt = Resource.Drawable.history;
            }
            else if(topic == "Geography")
            {
                imageInt = Resource.Drawable.geography;
            }
            else if (topic == "Space")
            {
                imageInt = Resource.Drawable.space;
            }
            else if (topic == "Engineering")
            {
                imageInt = Resource.Drawable.engineering;
            }
            else if (topic == "Programming")
            {
                imageInt = Resource.Drawable.programming;
            }
            else if (topic == "Business")
            {
                imageInt = Resource.Drawable.business;
            }
            return imageInt;
        }
    }
}
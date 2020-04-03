using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace QuizApp
{
    public class QuizHelper
    {
        public string GetTopicDescription(string topic)
        {
            string topicDescription = "";
            if (topic == "History")
            {
                topicDescription = "History is the past as it is described in written documents, and the study thereof. " +
                    "Events occurring before written records are considered prehistory.";
            }
            else if (topic == "Geography")
            {
                topicDescription = "Geography is often defined in terms of two branches: human geography and physical geography. ";
                    
            }
            else if (topic == "Space")
            {
                topicDescription = "Space is the boundless three-dimensional extent in which objects and events have relative position and direction. ";
                    
            }
            else if (topic == "Engineering")
            {
                topicDescription = "Engineering is the use of scientific principles to design and build machines, structures, and other items, including bridges, " +
                    "tunnels, roads, vehicles, and buildings.";
            }
            else if (topic == "Programming")
            {
                topicDescription = "Computer programming is the process of designing and building an executable computer program to accomplish a specific computing result.";
            }
            else if (topic == "Business")
            {
                topicDescription = "Business is the activity of making one's living or making money by producing or buying and selling products (such as goods and services).";
            }

            return topicDescription;
        }
    }
}
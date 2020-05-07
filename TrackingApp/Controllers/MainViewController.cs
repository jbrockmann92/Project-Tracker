using Foundation;
using RestSharp;
using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using TrackingApp.Models;
using UIKit;
using Newtonsoft.Json;
using System.Collections.Generic;
using CoreGraphics;

namespace TrackingApp
{
    public partial class MainViewController : UIViewController
    {

        List<Project> projects = new List<Project>();

        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            string stringJSON = "[{\"id\":1,\"title\":\"Roof\",\"mileage\":45.0,\"budget\":5000.0,\"budgetUsed\":1300.0,\"expense\":{\"id\":1,\"title\":\"Shingles\",\"cost\":25.0,\"projectId\":1},\"hoursSpent\":{\"id\":1,\"name\":\"Jacob\",\"hours\":5.0,\"projectId\":1},\"receipt\":{\"id\":1,\"store\":\"Menards\",\"total\":100.0,\"projectId\":1},\"note\":{\"id\":1,\"title\":\"New Note\",\"text\":\"This one is good\",\"projectId\":1}}, {\"id\":2,\"title\":\"Janesville House\",\"mileage\":45.0,\"budget\":5000.0,\"budgetUsed\":1300.0,\"expense\":{\"id\":1,\"title\":\"Shingles\",\"cost\":25.0,\"projectId\":1},\"hoursSpent\":{\"id\":1,\"name\":\"Jacob\",\"hours\":5.0,\"projectId\":1},\"receipt\":{\"id\":1,\"store\":\"Menards\",\"total\":100.0,\"projectId\":1},\"note\":{\"id\":1,\"title\":\"New Note\",\"text\":\"This one is good\",\"projectId\":1}}]";
            projects = JsonConvert.DeserializeObject<List<Project>>(stringJSON);


            //Project1Button.TouchUpInside += Project1Button_TouchUpInside;
            //Project1Button.SetTitle(projects[0].Title, UIControlState.Normal);

            for (int i = 0; i < projects.Count; i++)
            {
                UIButton newButton = UIButton.FromType(UIButtonType.System);
                newButton.Frame = new CGRect(35, (200 + (i * 35)), 325, 30);
                newButton.BackgroundColor = UIColor.Red;
                newButton.SetTitle(projects[i].Title, UIControlState.Normal);
                newButton.TouchUpInside += Project1Button_TouchUpInside;
                View.Add(newButton);
            }
        }

        public void Project1Button_TouchUpInside(object sender, EventArgs e)
        {
            ProjectViewController project = this.Storyboard.InstantiateViewController("ProjectViewController") as ProjectViewController;
            this.NavigationController.PushViewController(project, true);
        }

    }
}
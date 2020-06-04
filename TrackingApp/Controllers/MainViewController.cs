using System;
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

            string stringJSON = "[{\"id\":1,\"title\":\"Roof\",\"mileage\":45.0,\"budget\":5000.0,\"budgetUsed\":1300.0,\"expenses\":[{\"id\":1,\"title\":\"Shingles\",\"cost\":25.0,\"projectId\":1},{\"id\":2,\"title\":\"Nail Gun\",\"cost\":125.0,\"projectId\":1}],\"hoursSpent\":[{\"id\":1,\"name\":\"Jacob\",\"hours\":5.0,\"projectId\":1},{\"id\":2,\"name\":\"Joey\",\"hours\":15.0,\"projectId\":1}],\"receipts\":[{\"id\":1,\"store\":\"Menards\",\"total\":100.0,\"projectId\":1}],\"notes\":[{\"id\":1,\"title\":\"New Note\",\"text\":\"This one is good\",\"projectId\":1},{\"id\":2,\"title\":\"Receipt Note\",\"text\":\"This is good too\",\"projectId\":1}]},{\"id\":2,\"title\":\"Janesville House\",\"mileage\":134.0,\"budget\":3500.0,\"budgetUsed\":2200.0,\"expenses\":[{\"id\":3,\"title\":\"Underlayment\",\"cost\":25.0,\"projectId\":2}],\"hoursSpent\":[{\"id\":3,\"name\":\"Fleck\",\"hours\":5.0,\"projectId\":2},{\"id\":4,\"name\":\"Caleb\",\"hours\":15.0,\"projectId\":2}],\"receipts\":[{\"id\":2,\"store\":\"Menards\",\"total\":50.0,\"projectId\":2}],\"notes\":[]}]";
            projects = JsonConvert.DeserializeObject<List<Project>>(stringJSON);


            //Project1Button.TouchUpInside += Project1Button_TouchUpInside;
            //Project1Button.SetTitle(projects[0].Title, UIControlState.Normal);

            for (int i = 0; i < projects.Count; i++)
            {
                UIButton newButton = UIButton.FromType(UIButtonType.System);
                Project projectToLoad = projects[i];
                newButton.Frame = new CGRect(35, (200 + (i * 35)), 350, 30);
                newButton.BackgroundColor = UIColor.White;
                newButton.SetTitle(projects[i].Title, UIControlState.Normal);
                newButton.TouchUpInside += (sender, e) =>
                {
                    ProjectViewController project = this.Storyboard.InstantiateViewController("ProjectViewController") as ProjectViewController;
                    project.project = projectToLoad;
                    this.NavigationController.PushViewController(project, true);
                };
                View.Add(newButton);
            }
        }
    }
}
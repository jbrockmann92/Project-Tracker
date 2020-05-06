using Foundation;
using System;
using System.Net;
using System.Net.Http;
using UIKit;
using TrackingApp.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TrackingApp
{
    public partial class ProjectViewController : UIViewController
    {
        HttpClient client = new HttpClient();
        Project project = new Project();

        public ProjectViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            GetProjects();
            //var jsonResponse = JsonSerializer.Deserialize<Weather>(projectsJSON);

            Console.WriteLine(project);

            ProjectName.Text = "This Project"; //Can change to the right name here. When API call is working and JSON is formatted correctly
            ReceiptsButton.TouchUpInside += ReceiptsButton_TouchUpInside;
            ExpensesButton.TouchUpInside += ExpensesButton_TouchUpInside;
        }

        private void GetProjects()
        {
            project = JsonSerializer.Deserialize<Project>("{\"id\":1,\"title\":\"Roof\",\"mileage\":45.0,\"budget\":5000.0,\"budgetUsed\":1300.0,\"expense\":{\"id\":1,\"title\":\"Shingles\",\"cost\":25.0,\"projectId\":1},\"hoursSpent\":{\"id\":1,\"name\":\"Jacob\",\"hours\":5.0,\"projectId\":1},\"receipt\":{\"id\":1,\"store\":\"Menards\",\"total\":100.0,\"projectId\":1},\"note\":{\"id\":1,\"title\":\"New Note\",\"text\":\"This one is good\",\"projectId\":1}}"); //Need to deserialize that JSON to a project. Might be able to get away with just instantiating a project or two. How?
        }

        public void ReceiptsButton_TouchUpInside(object sender, EventArgs e)
        {
            ReceiptsViewController receipts = this.Storyboard.InstantiateViewController("ReceiptsViewController") as ReceiptsViewController;
            this.NavigationController.PushViewController(receipts, true);
        }

        public void ExpensesButton_TouchUpInside(object sender, EventArgs e)
        {
            ExpensesViewController expenses = this.Storyboard.InstantiateViewController("ExpensesViewController") as ExpensesViewController;
            this.NavigationController.PushViewController(expenses, true);
        }
    }
}
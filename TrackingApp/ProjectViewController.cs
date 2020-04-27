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
        string projectsJSON = "";

        public ProjectViewController (IntPtr handle) : base (handle)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            await GetProjects();
            //var jsonResponse = JsonSerializer.Deserialize<Weather>(projectsJSON);

            Console.WriteLine(projectsJSON);

            ProjectName.Text = "This Project"; //Can change to the right name here. When API call is working and JSON is formatted correctly
            ReceiptsButton.TouchUpInside += ReceiptsButton_TouchUpInside;
            ExpensesButton.TouchUpInside += ExpensesButton_TouchUpInside;
        }

        private async Task GetProjects()
        {
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
            projectsJSON = await response.Content.ReadAsStringAsync();
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
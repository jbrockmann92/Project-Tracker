using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using TrackingApp.Models;
using ProjectAPI.Models;

namespace TrackingApp.Models
{
    public class Project
    {
        //[Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public float Mileage { get; set; }
        public float Budget { get; set; }
        public float BudgetUsed { get; set; }
        public Expense Expense { get; set; }
        public HoursSpent HoursSpent { get; set; }
        public Receipt Receipt { get; set; }
        public Note Note { get; set; }
    }
}
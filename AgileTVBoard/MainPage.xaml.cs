using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AgileTVBoard.Views;
using AgileTVBoard.Models;

namespace AgileTVBoard
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            GenerateMenu();
        }

        public void GenerateMenu()
        {
            MenuList.ItemsSource = new List<MenuListItem>
            {
                new MenuListItem { Title = "Dashboard", IconSource="home.png", Target = typeof(DashboardPage)},
                new MenuListItem { Title = "Board", IconSource="notifications.png", Target = typeof(DashboardPage)},
                new MenuListItem { Title = "Stand Up", IconSource="activity.png", Target = typeof(DashboardPage)},
                new MenuListItem { Title = "Jira", IconSource="manager.png", Target = typeof(DashboardPage)},
                new MenuListItem { Title = "Retrospective", IconSource="championship.png", Target = typeof(DashboardPage)},
                new MenuListItem { Title = "Review", IconSource="teams.png", Target = typeof(DashboardPage)},
                new MenuListItem { Title = "Grafana", IconSource="about.png", Target = typeof(DashboardPage)},
                new MenuListItem { Title = "Prototype", IconSource="about.png", Target = typeof(DashboardPage)}
            };

        }

        private void MenuList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}

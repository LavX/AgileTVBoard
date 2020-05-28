using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgileTVBoard.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgileTVBoard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            kanbanWebView.Source = "https://miro.com/app/board/o9J_krsnFs8=/?moveToWidget=3074457348187203999&cot=13";
            grafanaWebView.Source = "https://play.grafana.org/d/000000045/big-dashboard?viewPanel=2&orgId=1&kiosk";

        }

    }
}
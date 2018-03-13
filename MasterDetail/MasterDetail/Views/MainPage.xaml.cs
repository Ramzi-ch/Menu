using MasterDetail.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail
{
	public partial class MainPage : MasterDetailPage
    {
		public MainPage()
		{
			InitializeComponent();
            Detail = new NavigationPage(new MyAccount())
            {
                BarBackgroundColor = Color.FromHex("F4C304")
            };
            IsPresented = false;


            List<ListMenu> ListMenu = new List<ListMenu>
            {
                new ListMenu {Title="MY ACCOUNT"},
                new ListMenu {Title="SHOP"},
                new ListMenu {Title="FAQ"},
                new ListMenu {Title="NOTIFICATIONS", Notification="2"},
            };

            List1.ItemsSource = ListMenu;
        }

        private void List_OnItemTapped(object sender, ItemTappedEventArgs e) //when click on an item in the listview

        {

            var T = e.Item as ListMenu; //get the item which raise the itemclicked event
            
                if (T.Title== "MY ACCOUNT")
                {
                    Detail = new NavigationPage (new MyAccount())
                    {
                    BarBackgroundColor = Color.FromHex("F4C304")
                     };
                    IsPresented = false;
                }
                    
                if (T.Title == "SHOP")
                {
                    Detail = new NavigationPage(new Shop())
                    {
                        BarBackgroundColor = Color.FromHex("F4C304")
                    };
                    IsPresented = false;
                }
                if (T.Title == "FAQ")
                {
                    Detail = new NavigationPage(new Faq())
                    {
                        BarBackgroundColor = Color.FromHex("F4C304")
                    };
                    IsPresented = false;
                }
                if (T.Title == "NOTIFICATIONS")
                {
                    Detail = new NavigationPage(new Notification())
                    {
                        BarBackgroundColor = Color.FromHex("F4C304")
                    };
                    IsPresented = false;
                }

        }
               

        }

    }


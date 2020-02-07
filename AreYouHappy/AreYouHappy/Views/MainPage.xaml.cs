using AreYouHappy.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AreYouHappy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

//            MenuPages.Add((int)MenuItemType.QuestionsList, (NavigationPage)Detail);
            MenuPages.Add((int)MenuItemType.Introduction, (NavigationPage)Detail);
//            MenuPages.Add((int)MenuItemType.Congrats, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Introduction:
                        MenuPages.Add(id, new NavigationPage(new IntroductionPage()));
                        break;
                    case (int)MenuItemType.QuestionsList:
                        MenuPages.Add(id, new NavigationPage(new QuestionsListPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Information:
                        MenuPages.Add(id, new NavigationPage(new InformationPage()));
                        break;
                    case (int)MenuItemType.Congrats:
                        MenuPages.Add(id, new NavigationPage(new CongratsPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}
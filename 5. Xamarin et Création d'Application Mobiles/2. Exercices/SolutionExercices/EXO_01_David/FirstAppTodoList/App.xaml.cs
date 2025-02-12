﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using FirstAppTodoList.Pages;

namespace FirstAppTodoList
{
    public partial class App : Application
    {
        public static string DatabaseLocation;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            DatabaseLocation = databaseLocation;

        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

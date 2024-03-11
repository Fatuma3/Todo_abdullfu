using System;
using Todo_abdullfu.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Todo_abdullfu.Views;

namespace Todo_abdullfu
{
    public partial class App : Application
    {
        private static TodoItemDatabase database;
        internal static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase(Path.Combine(Environment.GetFolderPath
                    (Environment.SpecialFolder.LocalApplicationData), "TodoListItems.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TodoListPage());
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

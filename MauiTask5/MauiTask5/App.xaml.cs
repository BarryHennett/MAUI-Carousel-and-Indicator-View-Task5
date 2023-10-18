namespace MauiTask5;
    using MauiTask5.Pages;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CollectionViewDemo();
        }
    }

using MauiTask5.Models;
namespace MauiTask5.Pages;

public partial class ListViewDemo : ContentPage
{
	public ListViewDemo()
	{
		InitializeComponent();
        var items = new List<CollectionItem>
        {
            new CollectionItem{Title = "Harry Bennett", Description = "Hello My name is Harry"},
            new CollectionItem{Title = "Title 2", Description = "Desc 2"},
            new CollectionItem{Title = "Title 3", Description = "Desc 3"},
            new CollectionItem{Title = "Title 4", Description = "Desc 4"},
            new CollectionItem{Title = "Title 5", Description = "Desc 5"},
            new CollectionItem{Title = "Title 6", Description = "Desc 6"}
        };
        ListView.ItemsSource = items;
    }
}
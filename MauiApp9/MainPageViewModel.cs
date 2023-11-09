using System.Collections.ObjectModel;

namespace MauiApp9;
public class MainPageViewModel
{
    public MainPageViewModel()
    {
        for (int i = 0; i < 100000; i++)
        {
            Items.Add(i.ToString());
        }
    }

    public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();
}
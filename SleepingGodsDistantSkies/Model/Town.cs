using System.Text.Json.Serialization;

namespace SleepingGodsDistantSkies.Model;

public partial class Town(string name, int startPage, int endPage) : ObservableObject
{
    [ObservableProperty]
    private string _name = name;

    //[property: JsonIgnore]
    //[ObservableProperty]
    //private ImageSource _image = ImageSource.FromFile(imageName);

    [ObservableProperty]
    private int _startPage = startPage;

    [ObservableProperty]
    private int _endPage = endPage;

    [ObservableProperty]
    private ObservableCollection<Story> _locations = [];
}


using CommunityToolkit.Mvvm.ComponentModel;

namespace Github20883;

public partial class NoteModel : ObservableObject
{
    [ObservableProperty]
    private Guid _id;
}

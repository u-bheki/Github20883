using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace Github20883;

public partial class MainPageViewModel
{
    private ObservableCollection<NoteModel> _notes = [new NoteModel(), new NoteModel(), new NoteModel()];
    public ObservableCollection<NoteModel> Notes => _notes;

    [RelayCommand]
    private void DeleteNote(NoteModel note)
    {
        Notes.Remove(note);
    }
}

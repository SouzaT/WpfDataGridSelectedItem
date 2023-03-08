using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace DataGrid.SelectedItem;

public class SelectedItemViewModel : INotifyPropertyChanged
{
    private PersonList _personList;

    public PersonList PersonList
    {
        get => _personList;
        set => _personList = value;
    }

    private Person _selectedRow;

    public Person SelectedRow
    {
        get => _selectedRow;
        set
        {
            _selectedRow = value;
            OnPropertyChanged(nameof(SelectedRow));
            BindOnLabel();
        }
    }

    private void BindOnLabel()
    {
        
    }

    public SelectedItemViewModel()
    {
        PersonList = new PersonList();
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
        }
    }

    private DateTime _selectedDate;

    public DateTime SelectedDate
    {
        get => _selectedDate;
        set
        {
            if (_selectedDate != value)
            {
                _selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
            }
        }
    }

    private ICommand _selectedDateChangedCommand;

    public ICommand SelectedDateChangedCommand
    {
        get => _selectedDateChangedCommand;
        set => _selectedDateChangedCommand = value;
    }
    
    public SelectedItemViewModel()
    {
        PersonList = new PersonList();
        SelectedDateChangedCommand = new RelayCommand<Person>(SelectedDateChanged);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
    {
        MessageBox.Show($"a data é: {_selectedDate}");
    }

    private void SelectedDateChanged(object param)
    {
        MessageBox.Show("Entrou no check");
    }
}
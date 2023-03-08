using System.Collections.ObjectModel;

namespace DataGrid.SelectedItem;

public class PersonList
{
    private ObservableCollection<Person> _persons;

    public ObservableCollection<Person> Persons
    {
        get => _persons;
        set => _persons = value;

    }
    public PersonList()
    {
        _persons = new ObservableCollection<Person>();
        _persons.Add(new Person("Thiago", "Souza"));
        _persons.Add(new Person("Jose", "Cruz"));
        _persons.Add(new Person("Alexandre", "Arruda"));
        _persons.Add(new Person("Holger", "Sags"));
        _persons.Add(new Person("Christine", "Amorzinho"));
    }
}
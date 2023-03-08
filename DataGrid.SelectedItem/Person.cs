﻿namespace DataGrid.SelectedItem;

public class Person
{
    private string _firstName;
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }
    
    private string _lastname;

    public string LastName
    {
        get => _lastname;
        set => _lastname = value;
    }

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastname = lastName;
    }
}
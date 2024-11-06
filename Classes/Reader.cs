﻿using System.Collections.Generic;

namespace TaskLibrary.Classes;

public class Reader
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Book> Books { get; set; }
    public Reader(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Books = new List<Book>();
    }
}
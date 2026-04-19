using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

/// <summary>
/// Represents author of a book
/// </summary>
public class Author
{
    /// <summary>
    /// Stores the first name of the author
    /// </summary>
    private string _firstName;

    /// <summary>
    /// Stores the last name of the author//
    /// </summary>
    private string _lastName;

    /// <summary>
    /// Constructor to initialize author
    /// </summary>
    public Author(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
}

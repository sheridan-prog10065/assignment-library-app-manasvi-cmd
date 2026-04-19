using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

/// <summary>
/// Represents one copy of a book that can be borrowed frm the library 
/// </summary>
public class LibraryAsset
{
    /// <summary>
    /// Stores the id of the book
    /// </summary>
    private int _id;

    /// <summary>
    /// Stores weather the book is borrowed or not
    /// </summary>
    private bool _isBorrowed;

    /// <summary>
    /// Stores the return date for the book 
    /// </summary>
    private string _returndate;
}

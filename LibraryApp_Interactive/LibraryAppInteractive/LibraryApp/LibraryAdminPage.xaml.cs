using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppInteractive;

public partial class LibraryAdminPage : ContentPage
{
    public LibraryAdminPage()
    {
        InitializeComponent();
        GenrePicker.ItemsSource = Enum.GetNames(typeof(Genre)).ToList();
    }

    private void AddBookButton_Clicked(object sender, EventArgs e)
    {
        AdminMessageLabel.Text = "Book registration button clicked.";
    }
}
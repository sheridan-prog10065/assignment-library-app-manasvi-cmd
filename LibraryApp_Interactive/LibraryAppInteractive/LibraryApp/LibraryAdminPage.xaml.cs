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
        string title = TitleEntry.Text;
        string isbn = IsbnEntry.Text;
        string authorFirstName = AuthorFirstNameEntry.Text;
        string authorLastName = AuthorLastNameEntry.Text;
        string assetIdText = AssetIdEntry.Text;

        if (title == "")
        {
            AdminMessageLabel.Text = "Enter title";
            return;
        }

        if (isbn == "")
        {
            AdminMessageLabel.Text = "Enter ISBN";
            return;
        }

        if (authorFirstName == "")
        {
            AdminMessageLabel.Text = "Enter Author First Name";
            return;
        }

        if (authorLastName == "")
        {
            AdminMessageLabel.Text = "Enter Author Last Name";
            return;
        }

        if (assetIdText == "")
        {
            AdminMessageLabel.Text = "Enter Asset ID";
            return;
        }

        if (GenrePicker.SelectedItem == null)
        {
            AdminMessageLabel.Text = "Select Genre";
            return;
        }

        int assetId = int.Parse(assetIdText);
        Genre selectedGenre = Enum.Parse<Genre>(GenrePicker.SelectedItem.ToString());

        Book newBook = new Book(title, isbn, selectedGenre);
        Author newAuthor = new Author(authorFirstName, authorLastName);
        LibraryAsset newAsset = new LibraryAsset(assetId);

        newBook.AddAuthor(newAuthor);
        newBook.AddAsset(newAsset);

        AdminMessageLabel.Text = "Book added";
    }
}
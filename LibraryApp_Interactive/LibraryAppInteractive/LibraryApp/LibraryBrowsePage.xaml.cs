using System;

namespace LibraryAppInteractive;

public partial class LibraryBrowsePage : ContentPage
{
    public LibraryBrowsePage()
    {
        InitializeComponent();
    }

    private void SelectBookButton_Clicked(object sender, EventArgs e)
    {
        BrowseMessageLabel.Text = "Book selected.";
        AssetsLayout.Children.Clear();
    }

    private void CheckStatusButton_Clicked(object sender, EventArgs e)
    {
        BrowseMessageLabel.Text = "Book status checked.";
    }

    private void BorrowBookButton_Clicked(object sender, EventArgs e)
    {
        BrowseMessageLabel.Text = "Book borrowed.";
    }

    private void ReturnBookButton_Clicked(object sender, EventArgs e)
    {
        BrowseMessageLabel.Text = "Book returned.";
    }

    private void DisplayAssetsButton_Clicked(object sender, EventArgs e)
    {
        BrowseMessageLabel.Text = "Displaying book assets.";
        AssetsLayout.Children.Clear();

        Label asset1 = new Label();
        asset1.Text = "105: available";

        Label asset2 = new Label();
        asset2.Text = "106: available";

        Label asset3 = new Label();
        asset3.Text = "107: borrowed";

        AssetsLayout.Children.Add(asset1);
        AssetsLayout.Children.Add(asset2);
        AssetsLayout.Children.Add(asset3);
    }
}
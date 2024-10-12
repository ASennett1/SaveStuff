namespace SaveStuff;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }


    private void Save_OnClicked(object sender, EventArgs e)
    {
        Preferences.Set("Username", txtUsername.Text);
    }

    private void Read_OnClicked(object sender, EventArgs e)
    {
        txtUsername.Text = Preferences.Get("Username", "");
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtUsername.Text = String.Empty;
    }
}
namespace SignUpPage;
[QueryProperty(nameof(User_Name), "username")]
[QueryProperty(nameof(Age), "age")]
public partial class ProfilePage : ContentPage
{
    public string User_Name { get; set;}
	public string Age { get; set; }
    public ProfilePage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LblUsername.Text = $"Username: {User_Name}";
        LblAge.Text = $"Age: {Age}";
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
       // Shell.Current.GoToAsync("../AnotherPage");
    }
}
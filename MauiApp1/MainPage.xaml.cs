namespace SignUpPage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSignUpClicked (object? sender, EventArgs e)
        {
            var myData = new Dictionary<string, object>
            {
                {"username",$"{Username.Text}" },
                {"password", $"{Password.Text}" },
                {"confirmPassword", $"{ConfirmPassword.Text}" }
            };

            Shell.Current.GoToAsync(nameof(ProfilePage), myData);
        }
    }
}

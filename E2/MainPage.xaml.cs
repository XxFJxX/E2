namespace E2;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int A1 = Convert.ToInt32(A.Text);
        int B1 = Convert.ToInt32(B.Text);
        int r = A1 + B1;
        int y = (r * r) / 2;

        la.Text = "(" + A1 + "+" + B1 + ")" + "^2/2" + " = " + y;
    }
}


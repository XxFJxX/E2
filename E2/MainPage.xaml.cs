namespace E2;

public partial class MainPage : ContentPage
{
	
///<Summary>
///<Createddate>27/6/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>27/6/2023</lastmodificationdate>
///<lastmodificationdescription>
///Se reciben valores luego se ejcuta la operacion requerida y se muestran resultados
///</lastmodificationdescription>
//////<lastmodifierautor>Fernando</lastmodifierautor>
///</Summary>
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


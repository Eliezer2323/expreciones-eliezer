namespace expreciones_eliezer;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    private void BtnOperate_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(EntryA.Text)
         && !string.IsNullOrEmpty(EntryB.Text))
        {
            double Dato1, Dato2, Resultado;

            Dato1 = Convert.ToDouble(EntryA.Text);
            Dato2 = Convert.ToDouble(EntryB.Text);

            Resultado = Math.Pow((Dato1 + Dato2), 2) / 2;

            Respuesta.Text = Convert.ToString(Resultado);

        }
        else
        {
            DisplayAlert("Error", "Intrduce todos los numeros", "OK");
        }
    }

}
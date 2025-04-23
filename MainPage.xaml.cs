namespace TAREA_01;
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		UpdateColor(); // inicializar al cargar
	}

	private void OnSliderChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateColor();
    }
	private void OnRandomColorClicked(object sender, EventArgs e)
    {
        var rand = new Random();
        RedSlider.Value = rand.Next(0, 256);
        GreenSlider.Value = rand.Next(0, 256);
        BlueSlider.Value = rand.Next(0, 256);
    }

	private void UpdateColor()
    {
        int r = (int)RedSlider.Value;
        int g = (int)GreenSlider.Value;
        int b = (int)BlueSlider.Value;

        Color newColor = Color.FromRgb(r, g, b);
        ClipBoardButton.Text = newColor.ToArgbHex(false);
		BackgroundColor = newColor;
    }
    private async void ClipBoardSetter(object sender, EventArgs e){
        await Clipboard.Default.SetTextAsync(ClipBoardButton.Text); // Copia del Hex en el portapapeles
        await DisplayAlert("Alert", "Hex Value Has been copied to your clipboard", "OK"); //mensaje de Alerta de copia en portapapeles
    }
}


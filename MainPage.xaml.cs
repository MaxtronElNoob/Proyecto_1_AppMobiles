namespace TAREA_01;

public partial class MainPage : ContentPage
{
	// int count = 0;

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
        ColorPreview.Color = newColor;
        HexLabel.Text = $"#{r:X2}{g:X2}{b:X2}";
		this.BackgroundColor = newColor;
    }
}


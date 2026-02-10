namespace Naidis_TARpv24;

public partial class TextPage : ContentPage
{
	Label lbl;
	Editor editor;
	HorizontalStackLayout hsl;
	VerticalStackLayout vsl;
	List<string> nupud = new List<string>() { "Tagasi", "Avaleht", "Edasi" };
	public TextPage()
	{
		lbl = new Label
		{
			Text = "Pealkiri",
			FontSize = 36,
			FontFamily = "Minufont",
			TextColor = Colors.Aquamarine,
			HorizontalOptions = LayoutOptions.Center,
			FontAttributes = FontAttributes.Bold,
		};
		editor = new Editor
		{
			Placeholder = "Sisesta tekst...",
			PlaceholderColor = Colors.Aqua,
			FontSize = 10,
			FontAttributes = FontAttributes.Italic,
			HorizontalOptions = LayoutOptions.Center
		};
		editor.TextChanged += (sender, e) =>
		{
			lbl.Text = editor.Text;
		};
		hsl = new HorizontalStackLayout { Spacing = 20, HorizontalOptions = LayoutOptions.Center };
		for (int j = 0; j < nupud.Count; j++)
		{
			Button nupp = new Button
			{
				Text = nupud[j],
				FontSize = 19,
				FontFamily = "Minufont",
				TextColor = Colors.MediumAquamarine,
				BackgroundColor = Colors.Blue,
				CornerRadius = 10,
				HeightRequest = 40,
				ZIndex = j
			};
			hsl.Add(nupp);
			nupp.Clicked += Liikumine;
		}
		vsl = new VerticalStackLayout
		{
			Padding = 20,
			Spacing = 15,
			Children = { lbl, editor, hsl },
			HorizontalOptions = LayoutOptions.Center
		};
		Content = vsl;
	}

    private void Liikumine(object? sender, EventArgs e)
    {
		Button nupp = sender as Button;
		if (nupp.ZIndex == 0)
		{
			Navigation.PopAsync();
		}
		else if(nupp.ZIndex == 1)
		{
			Navigation.PopToRootAsync();
		}
		else if(nupp.ZIndex == 2)
		{
			Navigation.PushAsync(new FigurePage());
		}
    }
}
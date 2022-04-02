using GettingShitDone.Database;

namespace GettingShitDone;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}

	private async void OnReadDatabaseClicked(object sencer, EventArgs e)
    {
		SQLiteRepository sqLiteRepository = new SQLiteRepository();

		var sqlite = await sqLiteRepository.InitializeDb();

    }
}
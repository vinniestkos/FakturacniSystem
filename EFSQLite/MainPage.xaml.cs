using EFSQLite.Data;
using EFSQLite.Models;

namespace EFSQLite;

public partial class MainPage : ContentPage
{
	MyContext _context;

	public MainPage()
	{
		_context = new();
		InitializeComponent();
		lst.ItemsSource = _context.Students.ToList(); // připojení zdroje dat k ListView
	}

	private void UlozObjednavku(object sender, EventArgs e)
	{
		Student newStudent = new() 
		{
			Name = forName.Text,
			//Surname = forSurname.Text 
		};

        _context.Add(newStudent); // přidá záznam do Data Setu
		_context.SaveChanges(); // uloží změny do databáze !!!!!!
        refresh();
	}

	private void Smazat(object sender, EventArgs e)
	{
		Student keSmazani = lst.SelectedItem as Student;
		if(keSmazani != null )
		{
			_context.Students.Remove(keSmazani); // odebrání studenta z data setu
			_context.SaveChanges(); // uloží změny do databáze
            refresh();
        }	
	}

	private async void Detajly(object sender, EventArgs e)
	{
		int id = (lst.SelectedItem as Student).Id;
		DetailPage dp = new(id, _context);
		await Navigation.PushAsync(dp);
	}

    void refresh()
	{
		lst.ItemsSource = null;
		lst.ItemsSource = _context.Students.ToList();
	}
}


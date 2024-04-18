using EFSQLite.Data;
using EFSQLite.Models;

namespace EFSQLite;

public partial class DetailPage : ContentPage
{
	public string Vystup { get; set; }
	MyContext _context;
	public DetailPage(int id, MyContext context)
	{
		_context = context;
        //Student s = _context.Students.FirstOrDefault(x => x.Id == id); // lambda varianta

        Student s = (from student in context.Students
                     where student.Id == id
                     select student).FirstOrDefault();

        if (s != null)
        {
            Vystup = $"id: {s.Id} jméno: {s.Name} adresa: {s.Surname} ";
        }
        InitializeComponent();
		BindingContext = this;

	
	}
}
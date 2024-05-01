using EFSQLite.Data;
using EFSQLite.Models;

namespace EFSQLite;

public partial class CustomerRecords : ContentPage
{
    new public string Id { get; set; }
    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string PSC { get; set; }

    public string ICO { get; set; }

    public string DIC { get; set; }

    MyContext _context;

    public CustomerRecords (int id, MyContext context)
    {
        _context = context;

        Customer c = (from customer in context.Customers
                      where customer.Id == id
                      select customer).FirstOrDefault();

        if (c != null)
        {
            Id = $"odbìratel s id:{c.Id}";
            Name = $"jméno odbìratele: {c.Name}";
            Address = $"adresa odbìratele: {c.Address}, {c.PSC} {c.City}";
            ICO = $"IÈO odbìratele s: {c.ICO}";
            DIC = $"DIÈ odbìratele s: {c.DIC}";
        }
    }



    public CustomerRecords()
	{
		InitializeComponent();
        BindingContext = this;
    }
}
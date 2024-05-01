using EFSQLite.Data;
using EFSQLite.Models;

namespace EFSQLite.Records;

public partial class SupplierRecords : ContentPage
{
    new public string Id { get; set; }
    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string PSC { get; set; }

    public string ICO { get; set; }

    public string DIC { get; set; }

    MyContext2 context_;

    public SupplierRecords(int id, MyContext2 context)
    {

        context_ = context;

        Supplier s = (from supplier in context.Suppliers
                      where supplier.Id == id
                      select supplier).FirstOrDefault();



        if (s != null)
        {
            Id = $"dodavatel s id:{s.Id}";
            Name = $"jm�no dodavatele:{s.Name}";
            Address = $"adresa dodavatele: {s.Address},{s.PSC} {s.City} ";
            PSC = $"PS� dodavatele: {s.PSC}";
            ICO = $"I�O dodavatele s: {s.ICO}";
            DIC = $"DI� dodavatele s: {s.DIC}";
        }
       
    }

    public SupplierRecords()
    {
        InitializeComponent();
        BindingContext = this;
    }
}

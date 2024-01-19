/**
// Three way to create an object
Sale sale1 = new Sale();
var sale2 = new Sale();
Sale sale3 = new();
*/

var sale =  new Sale(15);
var message = sale.GetInfo();

Console.WriteLine(message);

class Sale
{
    public decimal Total { get; set; }
    private decimal _some;

    public Sale(decimal total){
        Total = total;
    }

    public string GetInfo() {
        return "Total is " + Total;
    }
}
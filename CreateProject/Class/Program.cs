Sale sale = new Sale(15);
var message = sale.getInfo();

Console.WriteLine(message);

class Sale
{
    public decimal Total {get; set;}

    public Sale(decimal total)
    {
        this.Total = total;
    }

    public String getInfo()
    {
        return "El total es " + Total;
    }
}
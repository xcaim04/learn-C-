/* Inheritance */

var sale = new SaleWithTax(15);
var message = sale.getInfo();

Console.WriteLine(message);

/*Clase que hereda : Clase con herencia*/
class SaleWithTax : Sale {
    
    public decimal Tax {get; set;}

    /* Constructor : base(valor_que_hereda) */
    public SaleWithTax(decimal total) : base(total) {}

    public override String getInfo() {
        /* Total ha sido heredado */
        return "El total es " + Total + " el impuesto es " + Tax;
    }
}

class Sale {
    public decimal Total {get; set;}

    public Sale(decimal total) {
        this.Total = total;
    }

    /* private | protected | public */
    public virtual String getInfo() {
        return "El total es " + Total;
    }
}
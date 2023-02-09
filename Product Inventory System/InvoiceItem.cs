using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    //getters and setters for Prod and Qty, return subTotal
    internal class InvoiceItem : IEquatable<InvoiceItem>
    {
        public Product product { get; set; }
        public int Qty { get; set; }

    internal InvoiceItem(Product product, int qty)
    {
        this.product = product;
        this.Qty = qty;     
    }

    public override int GetHashCode()
    { return product.GetHashCode(); }
    
    //return subTotal
    internal double GetSubtotal()
    { return Qty * product.Price; }

    public bool Equals(InvoiceItem other)
    { return product.Equals(other.product); }
    }
}

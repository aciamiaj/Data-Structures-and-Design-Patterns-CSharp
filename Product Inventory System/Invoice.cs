using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Invoice
    {
    //hashset for invoiceitem
    public HashSet<InvoiceItem> invoice = new HashSet<InvoiceItem>();

    internal void addToInvoice(InvoiceItem invoiceItem)
    { 
         invoice.Add(invoiceItem); 
    }
    //display all products sold with overall total
    internal  void displayProductSold()
    {
        double total = 0;
        Console.WriteLine("");
        Console.WriteLine("Product Code\tName\t\tQty\tPrice\tTotal");
        Console.WriteLine("=====================================================");
        foreach (var invoiceItem in invoice)
        {
        Console.WriteLine(invoiceItem.product.Code + "\t\t" + invoiceItem.product.Name + "\t\t" +
            invoiceItem.Qty + "\t" + invoiceItem.product.Price + "\t" + invoiceItem.GetSubtotal() );
            total += invoiceItem.GetSubtotal();
        }
        Console.WriteLine("=====================================================");
        Console.WriteLine("Total: " + total);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
  internal class Program
    {
      internal static void Main(string[] args)
      {
      //create inventory
      Inventory inventory = new Inventory();

      Product p1 = new Product("P001", "Dove", 8.50, 10);
      Product p2 = new Product("P002", "Loreal", 12.0, 20);
      Product p3 = new Product("P003", "Garnier", 9.75, 15);
      Product p4 = new Product("P004", "Revlon", 10.95, 25);
      Product p5 = new Product("P005", "Dior", 25.00, 30);

      //add products to invoice
      inventory.AddProduct(p1);
      inventory.AddProduct(p2);
      inventory.AddProduct(p3);
      inventory.AddProduct(p4);
      inventory.AddProduct(p5);

      inventory.displayAllProduct();

      //create Invoice
      Invoice invoice = new Invoice();
      InvoiceItem invoiceitem1 = new InvoiceItem(inventory.FindProduct("P001"), 7);
      InvoiceItem invoiceitem2 = new InvoiceItem(inventory.FindProduct("P002"), 4);
      InvoiceItem invoiceitem3 = new InvoiceItem(inventory.FindProduct("P002"), 5);
      InvoiceItem invoiceitem5 = new InvoiceItem(inventory.FindProduct("P005"), 8);

      //add items to Invoice
      invoice.addToInvoice(invoiceitem1);
      invoice.addToInvoice(invoiceitem2);
      invoice.addToInvoice(invoiceitem3);
      invoice.addToInvoice(invoiceitem5);

      //display products sold
      invoice.displayProductSold();
      }
    }
}

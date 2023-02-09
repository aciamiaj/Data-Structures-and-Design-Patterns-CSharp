using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Inventory
    {
    public Dictionary<string, Product> products = new Dictionary<string, Product>();

    internal void AddProduct(Product product)
    {
        //add products to Dictionary
        products.Add(product.Code, product);
    }

    //find product by code
    internal Product FindProduct(string pcode)
    {
    if (products.ContainsKey(pcode))
        return products[pcode];
    else
        return new Product();             
    }
    //update price and qty
    internal void UpdateQtyPrice(Product p, int newQty)
    {
        this.products[p.Code].QtyInStock -= newQty;
    }

    //display all products
    internal void displayAllProduct()
    {
    Console.WriteLine("Student Name: Jaimaica Daisy Eugenio");
    Console.WriteLine("Humber ID: N01516797");
    Console.WriteLine();
    Console.WriteLine("Product List");
    Console.WriteLine("=====================================================================");

    foreach (var iteam in products)
    {
    Console.WriteLine("Product Code : " + iteam.Value.Code + "\tName : " + iteam.Value.Name +
         "\tQtyInStock : " +iteam.Value.QtyInStock + "\tPrice : " + iteam.Value.Price);
    }
    Console.WriteLine("");
    }    
    }
}

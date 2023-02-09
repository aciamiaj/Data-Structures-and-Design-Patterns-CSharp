using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    //getters and setters for product code, name, price, qtyinstock
    internal class Product
    {
    public string Code { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int QtyInStock { get; set; }

    internal Product(string code, string name, double price, int qtyInStock)
    {
        this.Code = code;
        this.Name = name;
        this.Price = price;
        this.QtyInStock = qtyInStock;
    }
    internal Product()
    {
       Code = "";
       Name = "";
       Price = 0;
       QtyInStock = 0;
    }   
    }
}

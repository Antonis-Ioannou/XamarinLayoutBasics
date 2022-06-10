using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinFirstProject.Views;

namespace XamarinFirstProject
{
    public class ProductInfoViewModel
    {
        public ObservableCollection<ProductInfo>ItemList { get; set; }
        public ProductInfoViewModel()
        {
            ItemList = new ObservableCollection<ProductInfo>();
            ItemList.Add(new ProductInfo() { ProductId = "1", ProductName = "Computer", Price = 1300, ImageUrl = "rogDesktop.jpg" });
            ItemList.Add(new ProductInfo() { ProductId = "2", ProductName = "Mouse", Price = 20, ImageUrl = "rogMouse.jpg" });
            ItemList.Add(new ProductInfo() { ProductId = "3", ProductName = "Keyboard", Price = 50, ImageUrl = "rogKeyboard.jpg" });
            ItemList.Add(new ProductInfo() { ProductId = "4", ProductName = "Laptop", Price = 1600, ImageUrl = "rogLaptop.jpg" });
            ItemList.Add(new ProductInfo() { ProductId = "5", ProductName = "Pendrive", Price = 400, ImageUrl = "rogUSB.jpg" });
        }
    }
}

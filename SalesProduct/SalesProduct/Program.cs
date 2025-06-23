// See https://aka.ms/new-console-template for more information
using SalesProduct;

Sales obj = new Sales();
obj.productName = "Easy_Shoes";
obj.productId= "ES123";
obj.date=DateTime.Now;
obj.SetPrice(100);
obj.SetQuantity(8);
Console.WriteLine("Total Price: " + obj.GetTotalPrice());
Console.WriteLine("Brand Name : "+ obj.productName+ "\n"+"Brand Id: "+ obj.productId + "\n" +"Purchase Date: "+ obj.date + "\n");

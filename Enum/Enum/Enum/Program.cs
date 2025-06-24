namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //general Process with out enum
            int productType = 1;
            if (productType == 1)
            {
                Console.WriteLine($"this is a product type of : {productType} ");
            }
            else
            {
                Console.WriteLine($"this is a product type of : {productType}");
            }


            // using the enum item from external 
            if (productType ==(int) EnumExample.regular)
            {
                Console.WriteLine($"this is a regular item type of : {productType}");
            }

           else if (productType == (int)EnumExample.premium)
            {
                Console.WriteLine($"this is a regular item type of : {productType}");
            }
          else   if (productType == (int)EnumExample.propremium)
            {
                Console.WriteLine($"this is a regular item type of : {productType}");
            }

        }
    }
}

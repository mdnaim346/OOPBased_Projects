using System.Net.Sockets;
using System.Runtime.Intrinsics.Arm;

namespace Sales
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sales obj = new Sales("Naim reza", "Nachole", DateTime.Now, 234, 7);


            Console.WriteLine("\t\t\t\t\t\t\tThis is a Sales Details\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("CustomerName\t\tAddress\t\tDatetime\t\t tprice\t\tquantity\t\ttotalPrice");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(obj.GetIvoice());
        }
    }
}

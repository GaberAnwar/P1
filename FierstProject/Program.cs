namespace FierstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // In the name of God, the most gracious, the most merciful.
            //Define (Var) the charges and tax 
            decimal smallRoom = 25.00m;
            decimal largeRoom = 35.00m;
            decimal salesTax = 0.06m;
            //مطالبة المستخدم بعدد الغرف الصغيرة والكبيرة 
            Console.Write("Enter the number of small rooms : ");
            int smallRooms7 = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of large rooms : ");
            int largeRooms7 = int.Parse(Console.ReadLine());
            // Calculate the Cost 
            decimal cost7 =( smallRoom * smallRooms7) + (largeRoom * largeRooms7);
            // calculate the tax 
            decimal tax = salesTax * cost7;
            // calculate total 
            decimal total = tax + cost7;
            //DisPlay All 
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of small carpets:" + smallRooms7);
            Console.WriteLine("Number of large carpets:" + largeRooms7);
            Console.WriteLine("Price per small room: $" + smallRoom);
            Console.WriteLine("Price per small room: $" + largeRoom);
            Console.WriteLine("Price per small room: $" + largeRoom);
            Console.WriteLine("Cost: $" + cost7);
            Console.WriteLine("Tax: $" + tax);

            Console.WriteLine("===============================");

            Console.WriteLine("Total estimate: $" + total);
            Console.WriteLine("This estimate is valid for 30 days");

            // May God’s peace, mercy, and blessings be upon you.......











        }
    }
}

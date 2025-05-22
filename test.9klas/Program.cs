namespace test._9klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car("Toyota", 2015, 7.5);

            Console.WriteLine("Brand" +mycar.Brand);
            Console.WriteLine("age" + mycar.GetCarAge() + "years");
            Console.WriteLine("fuel cost for 200km at 2.60/|:" + mycar.CalculatefuelCost(200, 2.60) + "BGN");
                
                
                
                }
    }
}

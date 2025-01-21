namespace Entity_Framework
{

    public class Program
    {
        public static void Main()
        {
            var connectionString = "Server=LAPTOP-97QETT33\\WINTER2022;Database=EfDemo;Trusted_Connection=True;TrustServerCertificate=True;";
            using (var context = new EfDemoDbContext(connectionString))
            {
                Console.WriteLine($"Adding new Product");
                var productToADD = new Product
                {
                    Name = "New Product",
                    Description = "New Product Description"
                };
                context.Products.Add(productToADD);
            }




        }

    }
}
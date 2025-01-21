namespace Entity_Framework
{
    public class Program
    {
        public static void Main()
        {
            var connectionString = "Server=LAPTOP-97QETT33\\WINTER2022;Database=EfDemo;Trusted_Connection=True;TrustServerCertificate=True;";
            using (var context = new EfDemoDbContext(connectionString))
            {
                try
                {
                    Console.WriteLine("Adding new Product");
                    var productToAdd = new Product
                    {
                        Name = "New Product",
                        Description = "New Product Description"
                    };
                    context.Products.Add(productToAdd);
                    context.SaveChanges();
                    Console.WriteLine("New product added successfully.");

                    var productToUpdate = context.Products.SingleOrDefault(p => p.Id == 1);
                    if (productToUpdate != null)
                    {
                        productToUpdate.Name = "Updated Product Name";
                        productToUpdate.Description = "Updated Product Description";
                        context.SaveChanges();
                        Console.WriteLine("Product with ID 1 updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Product with ID 1 not found.");
                    }

                    var productToRemove = context.Products.SingleOrDefault(p => p.Id == 7);
                    if (productToRemove != null)
                    {
                        context.Products.Remove(productToRemove);
                        context.SaveChanges();
                        Console.WriteLine("Product with ID 7 removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Product with ID 7 not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}

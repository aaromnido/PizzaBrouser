namespace PizzaBrouser.Models
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            // Simulate fetching data from a database or API
            var pizzas = new[]
            {
                new Pizza { PizzaId = 1, Name = "Margherita", Description = "Classic cheese and tomato", Price = 8.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 2, Name = "Pepperoni", Description = "Spicy pepperoni with cheese", Price = 9.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 3, Name = "Hawaiian", Description = "Ham and pineapple", Price = 10.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 4, Name = "BBQ Chicken", Description = "BBQ sauce, chicken, and cheese", Price = 11.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 5, Name = "Veggie Supreme", Description = "Loaded with fresh vegetables", Price = 10.49m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 6, Name = "Meat Lovers", Description = "Pepperoni, sausage, and bacon", Price = 12.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 7, Name = "Four Cheese", Description = "Mozzarella, cheddar, parmesan, and gorgonzola", Price = 11.49m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 8, Name = "Buffalo Chicken", Description = "Spicy buffalo sauce and chicken", Price = 12.49m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 9, Name = "Pesto Veggie", Description = "Pesto sauce with assorted veggies", Price = 10.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 10, Name = "Seafood Delight", Description = "Shrimp and crab with a creamy sauce", Price = 13.99m, Vegetarian = false, Vegan = false }
            };

            return Task.FromResult(pizzas); // Return the simulated data
        }

        // New method to sort pizzas
        public async Task<Pizza[]> GetPizzasSortedAsync(string sortBy) // Marked as async
        {
            var pizzas = await GetPizzasAsync(); // Fetch the pizzas

            // Sort based on the sortBy parameter
            switch (sortBy)
            {
                case "Vegetarian":
                    return pizzas.OrderBy(p => p.Vegetarian).ToArray(); // Removed Task.FromResult
                case "Vegan":
                    return pizzas.OrderBy(p => p.Vegan).ToArray(); // Removed Task.FromResult
                case "Price":
                    return pizzas.OrderBy(p => p.Price).ToArray(); // Removed Task.FromResult
                default:
                    return pizzas; // Return unsorted if no valid sortBy
            }
        }
    }
}
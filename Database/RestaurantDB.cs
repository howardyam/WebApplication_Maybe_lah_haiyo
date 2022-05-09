using WebApplication_Maybe_lah_haiyo.Models;

namespace WebApplication_Maybe_lah_haiyo.Database
{
    public class ChooseRestaurantModel : RestaurantModel
    {
        public List<ChooseRestaurantModel> Restaurants = new List<ChooseRestaurantModel>();

        public void AddRestaurants(int r_ID, string restaurantName, string restaurantAddress)
        {
            try
            {
                Restaurants.Add(new ChooseRestaurantModel
                {
                    R_ID = r_ID,
                    RestaurantName = restaurantName,
                    RestaurantAddress = restaurantAddress
                });
            }
            catch (Exception)
            {
                Console.WriteLine("Error during values assignment!");
            }
        }
    }

    public class FakeRestaurantDB : ChooseRestaurantModel
    {
        public ChooseRestaurantModel RestaurantExample { get; set; } = new ChooseRestaurantModel();
        public FakeRestaurantDB()//This is to get the values from database.
        {
            RestaurantExample.AddRestaurants(0, "KFC", "KFC address");
            RestaurantExample.AddRestaurants(1, "MCD", "MCD address");
            RestaurantExample.AddRestaurants(2, "Nica", "Nica address");
        }
    }
}
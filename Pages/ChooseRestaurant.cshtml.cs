using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_Maybe_lah_haiyo.Models;

namespace WebApplication_Maybe_lah_haiyo.Pages
{
    public class ChooseRestaurantModel : RestaurantModel
    {
        public List<ChooseRestaurantModel>Restaurants=new List<ChooseRestaurantModel>();
        public List<ChooseRestaurantModel> RestaurantExample { get; set; }

        public ChooseRestaurantModel()//Constructor.
        {
            ChooseRestaurantModel Example = new ChooseRestaurantModel();
            RestaurantExample = Example.RestaurantSample();
        }

        public void AddRestaurants(int r_ID,string restaurantName,string restaurantAddress)
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

        public List<ChooseRestaurantModel> RestaurantSample()//This is to get the values from database.
        {
            ChooseRestaurantModel sample = new ChooseRestaurantModel();
            sample.AddRestaurants(0, "KFC", "KFC address");
            sample.AddRestaurants(1, "MCD", "MCD address");
            sample.AddRestaurants(2, "Nica", "Nica address");

            return sample.Restaurants;
        }

        public void OnGet()
        {
        }
    }
}

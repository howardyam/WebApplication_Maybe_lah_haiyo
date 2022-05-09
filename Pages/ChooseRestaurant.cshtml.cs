using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_Maybe_lah_haiyo.Models;
using WebApplication_Maybe_lah_haiyo.Database;

namespace WebApplication_Maybe_lah_haiyo.Pages
{
    public class ChooseRestaurant : PageModel
    {
        public List<ChooseRestaurantModel> RestaurantsDB { get; set; } = new List<ChooseRestaurantModel>();
        public ChooseRestaurant()
        {
            FakeRestaurantDB Sample = new FakeRestaurantDB();
            RestaurantsDB = Sample.RestaurantExample.Restaurants;
        }

        public void OnGet()
        {
        }
    }
}

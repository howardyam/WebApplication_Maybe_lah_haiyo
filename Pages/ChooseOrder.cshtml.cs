using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_Maybe_lah_haiyo.Models;
using WebApplication_Maybe_lah_haiyo.Database;

namespace WebApplication_Maybe_lah_haiyo.Pages
{
    
    public class ChooseMenu : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int R_ID { get; set; }//This should be get from page ChooseRestaurant.
        [BindProperty(SupportsGet = true)]
        public string RestaurantName { get; set; }//This should be get from page ChooseRestaurant.
        public List<ChooseOrderModel> MenuDB { get; set; } = new List<ChooseOrderModel>();
        public ChooseMenu()
        {
            FakeMenuDB Sample = new FakeMenuDB(R_ID);
            MenuDB = Sample.MenuExample.Menus;
        }
        public void OnGet()
        {
        }
    }
}

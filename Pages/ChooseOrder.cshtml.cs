using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_Maybe_lah_haiyo.Models;

namespace WebApplication_Maybe_lah_haiyo.Pages
{
    public class ChooseOrderModel : MenuModel
    {
        [BindProperty]
        public int R_ID { get; set; }//This should be get from page ChooseRestaurant.
        [BindProperty]
        public string RestaurantName { get; set; }//This should be get from page ChooseRestaurant.

        public List<ChooseOrderModel> Menus = new List<ChooseOrderModel>();
        public List<ChooseOrderModel> MenuExample { get; set; }

        public ChooseOrderModel()//Constructor.
        {
            ChooseOrderModel Example = new ChooseOrderModel();
            MenuExample = Example.MenuSample(R_ID);
        }

        public void AddMenus(int m_ID, string menuName, double menuPrice, int r_ID)
        {
            try
            {
                Menus.Add(new ChooseOrderModel
                {
                    M_ID = m_ID,
                    MenuName = menuName,
                    MenuPrice = menuPrice,
                    R_ID = r_ID
                });
            }
            catch (Exception)
            {
                Console.WriteLine("Error during values assignment!");
            }
        }

        public List<ChooseOrderModel> MenuSample(int R_ID)//This is to get the values from database.
        {
            ChooseOrderModel sample = new ChooseOrderModel();

            if (R_ID == 0)
            {
                sample.AddMenus(0, "KFC Fried Chicken", 5.50, R_ID);
                sample.AddMenus(1, "KFC Widges", 4.00, R_ID);
                sample.AddMenus(2, "KFC Burger", 6.00, R_ID);
            }

            else if(R_ID == 1)
            {
                sample.AddMenus(0, "MCD Ice-Cream", 4.50, R_ID);
                sample.AddMenus(1, "MCD Fries", 3.00, R_ID);
            }

            else if (R_ID == 2)
            {
                sample.AddMenus(0, "Nica Cheese Cake", 5.50, R_ID);
                sample.AddMenus(1, "Nica Puding", 3.00, R_ID);
                sample.AddMenus(2, "Nica Macarron", 3.50, R_ID);
                sample.AddMenus(3, "Nica Cake", 4.00, R_ID);
            }

            return sample.Menus;
        }

        public void OnGet()
        {
        }
    }
}

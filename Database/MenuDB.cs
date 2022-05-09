using WebApplication_Maybe_lah_haiyo.Models;

namespace WebApplication_Maybe_lah_haiyo.Database
{
    public class ChooseOrderModel : MenuModel
    {
        public List<ChooseOrderModel> Menus = new List<ChooseOrderModel>();

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
    }

    public class FakeMenuDB : ChooseOrderModel
    {
        public ChooseOrderModel MenuExample { get; set; } = new ChooseOrderModel();

        public FakeMenuDB(int R_ID)//This is to get the values from database.
        {
            try
            {
                if (R_ID == 0)
                {
                    MenuExample.AddMenus(0, "KFC Fried Chicken", 5.50, R_ID);
                    MenuExample.AddMenus(1, "KFC Widges", 4.00, R_ID);
                    MenuExample.AddMenus(2, "KFC Burger", 6.00, R_ID);
                }

                else if (R_ID == 1)
                {
                    MenuExample.AddMenus(0, "MCD Ice-Cream", 4.50, R_ID);
                    MenuExample.AddMenus(1, "MCD Fries", 3.00, R_ID);
                }

                else if (R_ID == 2)
                {
                    MenuExample.AddMenus(0, "Nica Cheese Cake", 5.50, R_ID);
                    MenuExample.AddMenus(1, "Nica Puding", 3.00, R_ID);
                    MenuExample.AddMenus(2, "Nica Macarron", 3.50, R_ID);
                    MenuExample.AddMenus(3, "Nica Cake", 4.00, R_ID);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error during value assignation!");
            }
        }
    }
}
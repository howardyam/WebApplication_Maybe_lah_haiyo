namespace WebApplication_Maybe_lah_haiyo.Models
{
    public class MenuModel//All values get from database.
    {
        public int M_ID { get; set; }
        public string MenuName { get; set; }
        public double MenuPrice { get; set; }
        public int Amount { get; set; }
        public double OrderTotalPrice { get; set; }
        public int R_ID { get; set; }//This is foreign key to match with RestaurantModel.
    }
}

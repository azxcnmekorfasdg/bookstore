namespace BookStore.Models
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public string Description;
        public int CategoryId;
        public string CategoryName;
        public int ManufacturerId;
        public string ManufacturerName;
        public int SupplierId;
        public string SupplierName;
        public int UnitId;
        public string UnitName;
        public decimal Price;
        public int Quantity;
        public int Discount;
        public string ImagePath;
        public string Article;  

        public decimal FinalPrice
        {
            get
            {
                if (Discount > 0)
                {
                    return Price * (100 - Discount) / 100;
                }
                return Price;
            }
        }
    }
}
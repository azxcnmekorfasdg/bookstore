using System;

namespace BookStore.Models
{
    public class OrderInfo
    {
        public int OrderId;
        public string OrderCode;
        public int StatusId;
        public string StatusName;
        public int PickupPointId;
        public string PickupAddress;
        public DateTime OrderDate;
        public DateTime? DeliveryDate;
        public string PickupCode;
    }
}
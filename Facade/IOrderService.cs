﻿namespace Facade
{
    public interface IOrderService
    {
        void PlaceOrder(string productId, int quantity, string email);
    }
}

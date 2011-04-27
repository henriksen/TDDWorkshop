using System;

namespace OrderProcessorSample
{
    public class OrderProcessor
    {
        public void Ship(Order order)
        {
        }
    }
}

/*
    Given an order where the customer wants notification of shipment
    When shipping that order
    The Notification service should be called
    and given that order

    Given an order where the customer does not  want notification of shipment
    When shipping that order
    The Notification service should not be called
*/


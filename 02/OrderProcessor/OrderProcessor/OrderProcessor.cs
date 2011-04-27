using System;

namespace OrderProcessorSample
{
    public class OrderProcessor
    {
        private readonly INotify _notify;

        public OrderProcessor(INotify notify)
        {
            _notify = notify;
        }

        public void Ship(Order order)
        {
          if (order.NotifyCustomerOfShipment)   _notify.Notify(order);

        }
    }
}

/*
    Given an order where the customer wants notification of shipment
    When shipping that order
    Then the Notification service should be called
    and given that order

    Given an order where the customer does not  want notification of shipment
    When shipping that order
    Then the Notification service should not be called
*/


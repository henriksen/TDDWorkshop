using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace OrderProcessorSample
{
    [TestFixture]
    class OrderProcessorTests
    {
        [Test]
        public void CustomerWantsNotification_NotificationShouldBeCalled()
        {
            var order = new Order();
            order.NotifyCustomerOfShipment = true;
            var mockNotifier = new Moq.Mock<INotify>();
            var orderProcessor =
                new OrderProcessor(mockNotifier.Object);

            orderProcessor.Ship(order);

            mockNotifier.Verify(notifier => 
                notifier.Notify(order));
        }
    }
}

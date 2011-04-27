using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;

namespace OrderProcessorSample
{
    [TestFixture]
    class OrderProcessorTests
    {
        private Order _order;
        private OrderProcessor _orderProcessor;
        Moq.Mock<INotify> _mockNotifier;

        [SetUp]
        public void Setup()
        {
            _order = new Order();
            _mockNotifier = new Moq.Mock<INotify>();
            _orderProcessor =
                new OrderProcessor(_mockNotifier.Object);
        }

        [Test]
        public void CustomerWantsNotification_NotificationShouldBeCalled()
        {
            _order.NotifyCustomerOfShipment = true;
            _orderProcessor.Ship(_order);
            _mockNotifier.Verify(notifier => 
                notifier.Notify(_order));
        }

        [Test]
        public void CustomerDoesNotWantNotification_NotificationShouldNotBeCalled()
        {
            _order.NotifyCustomerOfShipment = false;
            _orderProcessor.Ship(_order);
            _mockNotifier.Verify(notifier =>
                notifier.Notify(It.IsAny<Order>()), Times.Never() );
        }
    }
}

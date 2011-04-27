using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProcessorSample
{
    public interface INotify
    {
        object Notify(Order order);
    }
}

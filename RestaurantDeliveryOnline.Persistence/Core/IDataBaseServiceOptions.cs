using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDeliveryOnline.Persistance.Core
{
  public interface IDataBaseServiceOptions
  {
    string ConnectionString { set; get; }
    IServiceProvider Provider { set; get; }
  }
}

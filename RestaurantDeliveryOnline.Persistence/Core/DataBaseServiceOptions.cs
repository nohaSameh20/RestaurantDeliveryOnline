using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDeliveryOnline.Persistance.Core
{
  public class DataBaseServiceOptions:IDataBaseServiceOptions
  {
    public string ConnectionString { get; set; }
    public IServiceProvider Provider { get; set; }
  }
}

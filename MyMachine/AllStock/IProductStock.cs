using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine.AllStock
{
    public interface IProductStock<out T> {
        public List<T> MyProperty { get; set; }
    }
  
}

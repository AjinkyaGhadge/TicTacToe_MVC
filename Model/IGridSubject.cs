using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
    public interface IGridSubject
    {
        public void Attach(IGridObserver observer);
        public void Detach(IGridObserver observer);
        public void Notify();
    }
}

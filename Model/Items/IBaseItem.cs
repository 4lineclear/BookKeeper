using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Model.Items
{
    public interface IBaseItem
    {
        string Name { get; set; }
        int ID { get; set; }
        bool Equals(IBaseItem other);
    }
}

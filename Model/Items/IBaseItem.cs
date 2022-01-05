using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Model.Items
{
    public interface IBaseItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Equals(IBaseItem other);
    }
}

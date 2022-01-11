using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Model.Items
{
    public abstract class BaseItem : IBaseItem
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value.Trim();
        }
        public int ID { get; set; }
        public BaseItem()
        {
            Name = "";
        }
        private BaseItem(string name)
        {
            this.Name = name;
        }
        public BaseItem(string name, int id)
            : this(name)
        {
            this.ID = id;
        }
        public virtual bool Equals(IBaseItem other) 
            =>  other != null && 
                this.GetType() == other.GetType() && 
                this.ID == other.ID && 
                this.Name == other.Name;

        public override string ToString()
        {
            return $"[{ID}]{Name} ";
        }
    }
}

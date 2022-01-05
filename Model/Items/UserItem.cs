using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Model.Items
{
    public class UserItem : IBaseItem
    {
        private string _name;
        public string Name {
            get => _name;
            set => _name = value.Trim();
        }
        public int ID{ get; set; }
        private UserItem()
        {
            Name = "";
        }
        private UserItem(string name)
        {
            this.Name = name;
        }
        public UserItem(string name,int id)
            :this(name)
        {
            this.ID = id;
        }
        public bool Equals(IBaseItem other)
        {
            if (other == null) 
                return false;

            return this.ID == other.ID && this.Name == other.Name;
        }

        public override string ToString()
        {
            return $"[{ID}]{Name} ";
        }
    }
}

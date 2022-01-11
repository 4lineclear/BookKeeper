using BookKeeper.Model.Items;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookKeeper.Model.Repositories
{
    public abstract class DerivedRepository<T> : BaseRepository<T> where T : BaseItem
    {
        protected DerivedRepository(string fullPath, string fileName)
            : base(fullPath ,fileName)
        {

        }
        public abstract override void AddItem(T item);
        public abstract override void CreateBaseItem();
        public abstract override T CreateNextItem(T item);
    }
}

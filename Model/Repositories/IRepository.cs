using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookKeeper.Model.Repositories
{
    interface IRepository<IBaseItem>
    {
        void SaveRepoToFile();
        void RemakeRepo();
        IEnumerable<IBaseItem> GetAllItems();
        IBaseItem GetItem(int id);
        void CreateBaseItem();
        void SaveToFile(List<IBaseItem> users);
        void SaveItem(int id, IBaseItem item);
        void AddItem(IBaseItem item);
        void EditItem(IBaseItem item, int index);
        void EditItemName(string name, int index);
        void RemoveItem(int id);
        void RemoveItem(IBaseItem item);
        void UpdateIDs();
        int IndexOf(IBaseItem item);
        int LastID();
        int Count { get; }
    }
}

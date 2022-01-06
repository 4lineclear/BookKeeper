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
        List<IBaseItem> GetAllItems();
        IBaseItem GetItem(int id);
        void CreateBaseItem();
        void SaveToFile(List<IBaseItem> users);
        void EditItem(IBaseItem item, int index);
        void EditItemName(string name, int index);
        void RemoveItem(int id);
        void UpdateIDs();
        int NextID();
        int Count { get; }
    }
}

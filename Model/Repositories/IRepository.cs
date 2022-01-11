using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookKeeper.Model.Repositories
{
    interface IRepository<T> where T : Model.Items.IBaseItem
    {
        void AddItem(T item);
        void SaveRepoToFile();
        void RemakeRepo();
        void DeleteFile(string fileName);
        void DeleteFolder(string folderName);
        List<T> GetAllItems();
        T GetItem(int id);
        void CreateBaseItem();
        void SaveToFile(List<T> items);
        void EditItem(T item, int index);
        void EditItemName(string name, int index);
        void RemoveItem(int id);
        void UpdateIDs();
        T CreateNextItem(T item);
        int NextID();
        int Count { get; }
    }
}

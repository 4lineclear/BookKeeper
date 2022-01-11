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
    public class BaseRepository<T> : IRepository<T> where T : BaseItem
    {
        protected readonly string _xmlFilePath;
        protected readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<T>));
        protected readonly Lazy<List<T>> _items;
        protected BaseRepository(string fullPath, string fileName)
        {
            _xmlFilePath = fullPath;
            Directory.CreateDirectory(_xmlFilePath);

            _xmlFilePath += fileName;

            if (!File.Exists(_xmlFilePath))
                CreateBaseItem();

            _items = new Lazy<List<T>>(() =>
            {
                using (StreamReader reader = new StreamReader(_xmlFilePath))
                {
                    return (List<T>)_serializer.Deserialize(reader);
                }
            });
        }
        public void SaveRepoToFile()
        {
            SaveToFile(_items.Value);
        }
        public void RemakeRepo()
        {
            _items.Value.Clear();
            Lazy<List<T>> temp = new Lazy<List<T>>(() =>
            {
                using (StreamReader reader = new StreamReader(_xmlFilePath))
                {
                    return (List<T>)_serializer.Deserialize(reader);
                }
            });
            _items.Value.AddRange(temp.Value);
        }
        public void DeleteFile(string filePath)
        {
            if (File.Exists(_xmlFilePath))
                File.Delete(_xmlFilePath);
        }
        public void DeleteFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
                Directory.Delete(folderPath);
        }
        public List<T> GetAllItems()
        {
            return _items.Value;
        }
        public T GetItem(int id)
        {
            return _items.Value[id];
        }
        public virtual void CreateBaseItem()
        {
            List<T> items = new List<T>();
            SaveToFile(items);
        }
        public void SaveToFile(List<T> items)
        {
            using (StreamWriter writer = new StreamWriter(_xmlFilePath, false))
            {
                _serializer.Serialize(writer, items);
            }
        }
        public virtual void AddItem(T item)
        {
            _items.Value.Add(item);
        }
        public virtual void AddItem(string name)
        {

        }
        public void EditItem(T item, int index)
        {
            if (index < _items.Value.Count && index >= 0)
            {
                _items.Value[index] = item;
            }
        }
        public void EditItemName(string name, int index)
        {
            if (index < _items.Value.Count && index >= 0)
            {
                _items.Value[index].Name = name;
            }
        }
        public void RemoveItem(int id)
        {
            if (id < _items.Value.Count && id >= 0)
            {
                _items.Value.RemoveAt(id);
                UpdateIDs();
            }
        }
        public void UpdateIDs()
        {
            for (int i = 0; i < _items.Value.Count; i++)
            {
                _items.Value[i].ID = i;
            }
        }
        public virtual T CreateNextItem(T item)
        {
            return item;
        }
        public int NextID()
        {
            if (_items.Value.Count != 0)
                return _items.Value.Last().ID;

            return 0;
        }
        public int Count { get => _items.Value.Count; }
    }
}

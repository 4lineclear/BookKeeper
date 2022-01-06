using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BookKeeper.Model.Items;

namespace BookKeeper.Model.Repositories
{
    public class UserRepository : IRepository<UserItem>
    {
        private readonly string _xmlFilePath;
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<UserItem>));
        private readonly Lazy<List<UserItem>> _users;

        public UserRepository(string fullPath)
        {
            _xmlFilePath = fullPath + @"\DataFolder";
            Directory.CreateDirectory(_xmlFilePath);

            _xmlFilePath += @"\Users.xml";

            if (!File.Exists(_xmlFilePath))
                CreateBaseItem();

            _users = new Lazy<List<UserItem>>(() =>
            {
                using (StreamReader reader = new StreamReader(_xmlFilePath))
                {
                    return (List<UserItem>)_serializer.Deserialize(reader);
                }
            });
        }
        public void SaveRepoToFile()
        {
            SaveToFile(_users.Value);
        }
        public void RemakeRepo()
        {
            _users.Value.Clear();
            Lazy<List<UserItem>> temp = new Lazy<List<UserItem>>(() =>
            {
                using (StreamReader reader = new StreamReader(_xmlFilePath))
                {
                    return (List<UserItem>)_serializer.Deserialize(reader);
                }
            });
            _users.Value.AddRange(temp.Value);
        }
        public List<UserItem> GetAllItems()
        {
            return _users.Value;
        }
        public UserItem GetItem(int id)
        {
            return _users.Value[id];
        }
        public void CreateBaseItem()
        {
            List<UserItem> users = new List<UserItem> {
                new UserItem("Default User",0)
            };
            SaveToFile(users);
        }
        public void SaveToFile(List<UserItem> users)
        {
            using (StreamWriter writer = new StreamWriter(_xmlFilePath, false))
            {
                _serializer.Serialize(writer, users);
            }
        }
        public void AddItem(string name)
        {
            UserItem user = new UserItem(name, NextID() + 1);
            _users.Value.Add(user);
        }
        public void EditItem(UserItem item, int index)
        {
            if (index < _users.Value.Count && index >= 0)
            {
                _users.Value[index] = item;
            }
        }
        public void EditItemName(string name, int index)
        {
            if (index < _users.Value.Count && index >= 0)
            {
                _users.Value[index].Name = name;
            }
        }
        public void RemoveItem(int id)
        {
            if (id < _users.Value.Count && id >= 0)
            {
                _users.Value.RemoveAt(id);
                UpdateIDs();
            }
        }
        public void UpdateIDs()
        {
            for (int i = 0; i < _users.Value.Count;i++)
            {
                _users.Value[i].ID = i;
            }
        }
        public int NextID()
        {
            if (_users.Value.Count != 0)
                return _users.Value.Last().ID;

            return 0;
        }
        public int Count { get => _users.Value.Count; }
    }
}

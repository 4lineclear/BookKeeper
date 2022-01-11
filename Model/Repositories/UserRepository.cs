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
    public class UserRepository : DerivedRepository<UserItem>
    {
        public UserRepository(string fullPath)
            : base(fullPath+ @"\DataFolder", @"\Users.xml")
        {

        }

        public override void AddItem(UserItem user)
        {
            _items.Value.Add(CreateNextItem(user));
        }
        public override void AddItem(String name)
        {
            _items.Value.Add(CreateNextItem(name));
        }

        public override void CreateBaseItem()
        {
            List<UserItem> users = new List<UserItem> {
                new UserItem("Default User", 0)
            };
            SaveToFile(users);
        }
        public override UserItem CreateNextItem(UserItem item)
        {
            return new UserItem(item.Name,NextID());
        }
        public UserItem CreateNextItem(string name)
        {
            return new UserItem(name, NextID());
        }

        public new List<UserItem> GetAllItems()
            => base.GetAllItems();

        public new UserItem GetItem(int id)
            => (UserItem)base.GetItem(id);
    }
}

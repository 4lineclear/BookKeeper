using BookKeeper.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Model.Repositories
{
    class BookListRepository : DerivedRepository<BookListItem>
    {
        public BookListRepository(string fullPath)
            : base(fullPath, @"\BookLists.xml")
        {

        }
        public override void AddItem(BookListItem bookList)
        {
            _items.Value.Add(CreateNextItem(bookList));
        }
        public override void CreateBaseItem()
        {
            List<BookListItem> users = new List<BookListItem> {
                new BookListItem("All Books", 0, GenreType.All)
            };
            SaveToFile(users);
        }
        public override BookListItem CreateNextItem(BookListItem item)
        { 
            return new BookListItem(item.Name, NextID(), item.Genre);
        }
    }
}

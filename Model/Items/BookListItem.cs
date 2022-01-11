using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Model.Items
{
    public class BookListItem : BaseItem
    {
        public GenreType Genre { get; set; }
        public BookListItem()
            : base()
        {

        }
        public BookListItem(string name, int id, GenreType genre)
            : base(name, id)
        {
            this.Genre = genre;
        }
        public bool Equals(BookListItem other)
            => base.Equals(other) && this.Genre == other.Genre;
    }
}

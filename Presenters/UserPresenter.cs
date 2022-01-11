using BookKeeper.Model.Items;
using BookKeeper.Model.Repositories;
using BookKeeper.View;
using System.Linq;

namespace BookKeeper.Presenters
{
    public class UserPresenter : BasePresenter<UserItem,UserItem,BookListItem>
    {
        public UserPresenter(UserRepository repository, UserPanel mainPanel)
            :base(repository,mainPanel)
        {

        }
    }
}

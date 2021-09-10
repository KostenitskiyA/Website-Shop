using System.Collections.Generic;
using Website_Shop.Models.Entities;

namespace Website_Shop.Models.ViewModels
{
    public class UsersViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}

using Website_Shop.Models.Entities;

namespace Website_Shop.Models.ViewModels
{
    public class EditUserViewModel
    {
        public User User { get; set; }

        public Authorization Authorization { get; set; }

        public Profile Profile { get; set; }
    }
}

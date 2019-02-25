using DHospital.Models;

namespace DHospital.ViewModel
{
    public class RoleViewModel
    {


        public RoleViewModel()
        {

        }
        public RoleViewModel(ApplicationRole role)
        {
            Id = role.Id;
            Name = role.Name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}

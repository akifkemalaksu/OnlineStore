using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data.Entities
{
    public class User : EntitiyBase<int>
    {
        public User()
        {
            AllowedCategories = new List<Category>();
        }

        [StringLength(15)]
        public string Username { get; set; }
        [MinLength(10)]
        [MaxLength(20)]
        public string Password { get; set; }
        [MaxLength(250)]
        public string Fullname { get; set; }
        [MaxLength(250)]
        public string Mail { get; set; }
        public virtual ICollection<Category> AllowedCategories { get; set; }
    }
}

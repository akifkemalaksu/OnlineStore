using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data.Entities
{
    public abstract class EntitiyBase<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}

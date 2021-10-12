using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Common.Contracts.RequestMessages
{
    public class CategoryCreateRequest
    {
        public string Name { get; set; }
        public int Rank { get; set; }
    }
}

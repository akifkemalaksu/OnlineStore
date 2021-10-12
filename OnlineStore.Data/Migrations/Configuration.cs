using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<OnlineStoreContext>
    {
        public Configuration()
        {
            base.AutomaticMigrationsEnabled = true;
            base.ContextKey = "OnlineStore.Data.OnlineStoreContext";
        }
    }
}

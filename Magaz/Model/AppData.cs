using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magaz.Model
{
    public class AppData : DbContext
    {
        public static AvtozaptEntities db = new AvtozaptEntities();
    }
}

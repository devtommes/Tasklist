using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasklist.DBModel
{
    class Category
    {
        public int ID { get; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime CreationDate { get; }

        public virtual ICollection<Task> Tasks { get; set; }
       
    }
}

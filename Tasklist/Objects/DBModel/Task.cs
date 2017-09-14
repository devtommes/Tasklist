using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasklist.DBModel
{
    public enum EPriority
    {
        low,
        medium,
        high,
        now
    }

    public class Task
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Priority { get; set; }
        public DateTime CreationDate { get; }
        public DateTime EndDate { get; set; }
        public DateTime PriorityIncreaseInterval { get; set; }
        public int CategoryID { get; set; }
        public int Sortnumber { get; set; }


    }
}

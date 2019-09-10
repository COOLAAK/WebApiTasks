using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTasks.DataBase.Model
{
    public class TagJob
    {
        public int JobId { get; set; }
        public Job Job { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}

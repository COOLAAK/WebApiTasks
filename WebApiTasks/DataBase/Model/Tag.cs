using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTasks.DataBase.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TagJob> TagJobs{ get; set; }

        public Tag()
        {
            TagJobs = new List<TagJob>();
        }

    }
}

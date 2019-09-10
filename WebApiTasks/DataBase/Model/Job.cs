using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTasks.DataBase.Model
{
    public enum StatusJob { Active, Done, Failed };
    public enum Priority { High, AboveHigh, Medium, AboveLow, Low };
    public class Job
    {
        public int Id { get; set; }
        public StatusJob StatusJob { get; set; }
        public Priority Priority { get; set; }
        public DateTime DeadLine { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<Category> Categories { get; set; }


        public List<TagJob> TagJobs { get; set; }

        public Job()
        {
            TagJobs = new List<TagJob>();
        }


    }
}

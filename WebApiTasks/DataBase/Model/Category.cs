using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTasks.DataBase.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Job")]
        public int Jobid { get; set; }
        public  Job Job { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        [Display(Name = "List Title")]
        public string ListTitle { get; set; }
        [Display(Name = "Create Date")]
        public DateTime ListCreateDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
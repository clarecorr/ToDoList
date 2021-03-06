﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }
        [Display(Name = "Done")]
        public bool IsDone { get; set; }
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        [ForeignKey("List")]
        public int ListID { get; set; }
        public virtual List List { get; set; }
    }
}
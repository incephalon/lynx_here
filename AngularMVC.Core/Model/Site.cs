using Abp.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngularMVC.Model
{
    public class Site : Entity
    {
        public  string Url { get; set; }

        public  string Note { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}

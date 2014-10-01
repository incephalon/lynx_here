using Abp.Domain.Entities;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AngularMVC.Model
{
    public class Tag : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Site> Sites { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}

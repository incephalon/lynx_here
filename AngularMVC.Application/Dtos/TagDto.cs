using Abp.Application.Services.Dto;
using AngularMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC.Dtos
{
    public class TagDto : EntityDto
    {
        public string Name { get; set; }

        public ICollection<SiteDto> Sites { get; set; }

        public DateTime Date { get; set; }
    }
}

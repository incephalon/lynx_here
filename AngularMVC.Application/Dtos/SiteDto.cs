using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC.Dtos
{
    public class SiteDto : EntityDto
    {
        public virtual string Url { get; set; }

        public virtual string Note { get; set; }

        public virtual ICollection<TagDto> Tags { get; set; }

        public virtual DateTime Date { get; set; }
    }
}

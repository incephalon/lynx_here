using Abp.Application.Services;
using AngularMVC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC
{
    public interface IService : IApplicationService
    {
        void InsertTag(TagDto Tag);
        void InsertSite(SiteDto Tag);

        void TagSite(List<TagDto> Tags);
    }
}

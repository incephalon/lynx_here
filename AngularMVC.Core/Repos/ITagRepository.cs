using Abp.Domain.Repositories;
using AngularMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC.Repos
{
    public interface ITagRepository : IRepository<Tag, int>
    {
    }
}

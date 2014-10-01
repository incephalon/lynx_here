using AngularMVC.Model;
using AngularMVC.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC.EntityFramework.Repositories
{
    public class SiteRepository : AngularMVCRepositoryBase<Site, int>, ISiteRepository
    {
        public List<Site> GetAllSitesByTag(int TagId)
        {
            var query = GetAll();

            var tag = new Tag() { Id = TagId };

            query = query.Where(site => site.Tags.Contains(tag));

            return query.ToList();
        }


        public void TagSite(string Tag)
        {
            throw new NotImplementedException();
        }
    }
}

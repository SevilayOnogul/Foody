using foody.DataAccessLayer.Abstract;
using foody.DataAccessLayer.Context;
using foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foody.DataAccessLayer.EntityFramework
{
	public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
	{
		public EfFeatureDal(FoodyContext context) : base(context)
		{
		}

        public List<Feature> FeatureListByStatusTrue()
        {
            var context=new FoodyContext();
            var values=context.Features.Where(x=>x.Status==true).ToList();  
            return values;
        }
    }
}

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
	public class EfSliderDal : GenericRepository<Slider>, ISliderDal
	{
		public EfSliderDal(FoodyContext context) : base(context)
		{
		}
	}
}

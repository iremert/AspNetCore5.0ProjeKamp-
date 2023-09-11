using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T:class //class a ait tüm değerleri kullanabilecek entity,buradaki <T> kısmı bir değer alıcağı için kullanmışız bu da bir kullanış biçimi
	{
		void Insert(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetListAll();
		T GetByID(int id);
		List<T> GetListAll(Expression<Func<T,bool>>filter);
	}
}

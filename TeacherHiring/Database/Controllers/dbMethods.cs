using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TeacherHiring
{
	public interface dbMethods<T> where T:class
	{
		Task<List<T>> GetAll();
		Task<T> GetById(int Id);
		Task<int> Update(T obj);
		Task<int> Insert(T obj);
		Task<int> Delete(T obj);
	}
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeacherHiring.Database.Model;

namespace TeacherHiring
{
	public class PersonController : dbMethods<Person>
	{
		public PersonController()
		{
		}

		public Task<int> Delete(Person obj)
		{
			return App.dbSQLite.DeleteAsync(obj);
		}

		public Task<List<Person>> GetAll()
		{
			return App.dbSQLite.Table<Person>().ToListAsync();
		}

		public Task<Person> GetById(int Id)
		{
			return App.dbSQLite.Table<Person>().Where(i => i.Id == Id).FirstOrDefaultAsync();
		}

		public Task<int> Insert(Person person)
		{
            var user = GetById(person.Id);

			return App.dbSQLite.InsertAsync(person);
		}

		public Task<int> Update(Person obj)
		{
			return App.dbSQLite.UpdateAsync(obj);
		}
	}
}

using System;
using System.Threading.Tasks;
using SQLite;
using System.Collections.Generic;
using TeacherHiring.Database.Model;

namespace TeacherHiring
{
	public class TeacherHiringDatabase
	{
		SQLiteAsyncConnection database;
		public TeacherHiringDatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Person>().Wait();
			database.CreateTableAsync<AlumnoMateria>().Wait();
			database.CreateTableAsync<Materia>().Wait();
			database.CreateTableAsync<ProfesorMateria>().Wait();
		}
		public Task<List<Person>> GetPersonAsync()
		{
			return database.Table<Person>().ToListAsync();
		}

		//public Task<List<Person>> GetPersonsNotDoneAsync()
		//{
		//	return database.QueryAsync<Person>("SELECT * FROM [Person] WHERE [Done] = 0");
		//}

		public Task<Person> GetPersonAsync(int id)
		{
			return database.Table<Person>().Where(i => i.Id == id).FirstOrDefaultAsync();
		}

		public Task<int> SavePersonAsync(Person item)
		{
			if (item.Id != 0)
			{
				return database.UpdateAsync(item);
			}
			else
			{
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeletePersonAsync(Person item)
		{
			return database.DeleteAsync(item);
		}
	}
}

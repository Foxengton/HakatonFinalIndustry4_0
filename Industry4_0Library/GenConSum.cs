using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Industry4_0Library
{
	[Table("GenConSum")]
	public class GenConSum
	{
		public int Id { get; set; }
		public int Year { get; set; }
		public string Data { get; set; }
		public string Use { get; set; }
		public string Gen { get; set; }

		public static GenConSum[] Load()
		{
			using (SQLiteConnection database = new SQLiteConnection("GenConsum.db"))
			{
				return database.Table<GenConSum>().OrderBy(item => item.Id).ToArray();
			}
		}
		public void Save()
		{
			using (SQLiteConnection database = new SQLiteConnection("GenConsum.db"))
			{
				//TODO: create replace function
				//if (GetItem(Id) != null)
				//{
				//	database.Update(this);
				//	return;
				//}
				//else
				database.Insert(this);
			}
		}
		public void Delete()
		{
			using (SQLiteConnection database = new SQLiteConnection("GenConsum.db"))
			{
				database.Delete(this);
			}
		}

		[Ignore]
		public static GenConSum[] Items => Load();
		public static GenConSum GetItem(int id) => Items.Count(item => item.Id == id) != 0 ? Items.First(item => item.Id == id) : null;
		public static GenConSum[] GetAllItem(int id) => Items.Count(item => item.Id == id) != 0 ? Items.Where(item => item.Id == id).ToArray() : null;

		public override string ToString()
		{
			return $"";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnScreen.Core.Model
{
	public class Account : IDBEntity
	{
		public int Id { get; set; }
		public DateTime Created { get; set; }
		public int UserCreated { get; set; }
		public DateTime LastModified { get; set; }
		public int UserModified { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		//TODO: FB, G+ account validation
		public List<PhotoBooth> PhotoBoots { get; set; }
		public int PhotoBoothPurchased { get; set; }
		public int PhotoBoothUsed { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnScreen.Core.Model
{
	public class PhotoBooth : IDBEntity
	{
		public int Id { get; set; }
		public DateTime Created { get; set; }
		public int UserCreated { get; set; }
		public DateTime LastModified { get; set; }
		public int UserModified { get; set; }
		public DateTime SetDateBegin { get; set; }
		public DateTime SetDateEnd { get; set; }

	}
}

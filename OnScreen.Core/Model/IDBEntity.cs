using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnScreen.Core.Model
{
	public interface IDBEntity
	{
		int Id { get; set; }
		DateTime Created { get; set; }
		int UserCreated { get; set; }
		DateTime LastModified { get; set; }
		int UserModified { get; set; }
	}
}

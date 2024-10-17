using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs.Entity.Entities
{
	public class Question : BaseEntity
	{
        public int Category { get; set; }
		public string? Content { get; set; }
    }
}

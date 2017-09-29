using System;
using System.Collections.Generic;

namespace Nooptime.Domain.Models
{
	public class UptimeCheckData
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public TimeSpan Interval { get; set; }
		public Dictionary<string, string> Properties { get; set; }
	}
}
﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Nooptime.Domain.Models;

namespace Nooptime.Domain.Repositories
{
	public interface IUptimeCheckRepository
	{
		Task<IEnumerable<UptimeCheckData>> List();

		Task<UptimeCheckData> Load(Guid id);

		void Save(UptimeCheckData uptimeCheckData);

		Task Delete(Guid id);
	}
}
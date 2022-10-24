using Microsoft.EntityFrameworkCore;
using MqTroco.Data;
using System.Collections.Generic;

namespace MqTroco.Logic
{
	public class MoedaLogic
	{
		private SystemContext _systemContext;

		public MoedaLogic()
		{
			_systemContext = new SystemContext();
		}

		public async Task<List<Moeda>> List()
		{
			return await _systemContext.Moeda.ToListAsync();
		}

        public async Task Create(Moeda moeda)
		{
            await _systemContext.Moeda.AddAsync(moeda);
			await _systemContext.SaveChangesAsync();
		}

        public async Task Edit(Moeda moeda)
		{
			_systemContext.Entry(moeda).State = EntityState.Modified;
			await _systemContext.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			var moeda = await _systemContext.Moeda.FirstOrDefaultAsync(x => x.Id == id);

			if (moeda != null)
			{
				_systemContext.Moeda.Remove(moeda);
				await _systemContext.SaveChangesAsync();
			}
		}

        public async Task<Moeda> Get(int id)
		{
			var moeda = await _systemContext.Moeda.FirstOrDefaultAsync(x => x.Id == id);
			return moeda;
		}

	}

}

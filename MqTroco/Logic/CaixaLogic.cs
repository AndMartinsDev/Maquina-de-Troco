using Microsoft.EntityFrameworkCore;
using MqTroco.Data;
using System;

namespace MqTroco.Logic
{
	public class CaixaLogics
	{
		private SystemContext _systemContext;

		public CaixaLogics()
		{
			_systemContext = new SystemContext();
		}

		public async Task<List<Caixa>> List()
		{
			return await _systemContext.Caixa.ToListAsync();
		}

		public async Task Create(Caixa caixa)
		{
			await _systemContext.Caixa.AddAsync(caixa);
			await _systemContext.SaveChangesAsync();
		}

		public async Task Edit(Caixa caixa)
		{
			_systemContext.Entry(caixa).State = EntityState.Modified;
			await _systemContext.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			var caixa = await _systemContext.Caixa.FirstOrDefaultAsync(x=> x.Id == id);
			
			if(caixa != null)
			{
				_systemContext.Caixa.Remove(caixa);
				await _systemContext.SaveChangesAsync();
			}
		}

	}
	
}

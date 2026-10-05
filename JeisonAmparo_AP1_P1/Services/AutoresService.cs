using Microsoft.EntityFrameworkCore;
using JeisonAmparo_AP1_P1.Context;
using JeisonAmparo_AP1_P1.Models;
using System.Linq.Expressions;

namespace JeisonAmparo_AP1_P1.Services;

public class AutoresService(
IDbContextFactory<Contexto> contextFactory
) : Aplicada1.Core.IService<Autores, int>
{
    public async Task<bool> Guardar(Autores Autores)
    {
        if (!await Existe(Autores.AutoresId))
        {
            return await Insertar(Autores);
        }
        else
        {
            return await Modificar(Autores);
        }
    }

    private async Task<bool> Existe(int AutoresId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .AnyAsync(a => a.AutoresId == AutoresId);
    }

    private async Task<bool> Insertar(Autores Autores)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Autores.Add(Autores);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Autores Autores)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Update(Autores);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<Autores?> Buscar(int AutoresId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .FirstOrDefaultAsync(a => a.AutoresId == AutoresId);
    }

    public async Task<List<Autores>> GetList(Expression<Func<Autores, bool>> criterio)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<bool> Eliminar(int AutoresId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .Where(a => a.AutoresId == AutoresId)
            .ExecuteDeleteAsync() > 0;
    }
}

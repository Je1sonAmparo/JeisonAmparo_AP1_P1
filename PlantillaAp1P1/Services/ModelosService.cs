using Microsoft.EntityFrameworkCore;
using PlantillaAP1P1.Context;
using PlantillaAP1P1.Models;
using System.Linq.Expressions;

namespace PlantillaAP1P1.Services;

public class ModelosService(
IDbContextFactory<Contexto> contextFactory
) : Aplicada1.Core.IService<Modelo1, int>
{
    public Task<Modelo1?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Modelo1>> GetList(Expression<Func<Modelo1, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Modelo1 entidad)
    {
        throw new NotImplementedException();
    }
}

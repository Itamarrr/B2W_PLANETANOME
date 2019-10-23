using PlanetarioAPI.Models;

namespace PlanetarioAPI
{
    public interface IServico
    {
        Planeta GetPlaneta(int id);
    }
}
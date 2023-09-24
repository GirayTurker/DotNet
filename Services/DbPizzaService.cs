using ContosoPizza.Models;

namespace ContosoPizza.Services;

//Same as PizzaService.cs - Difference is; this class correspond to Database. 
public class DbPizzaService
{
    public DbPizzaService()
    {

    }

    public IEnumerable<Pizza> GetAll()
    {
        throw new NotImplementedException();
    }

    public Pizza? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Pizza? Create(Pizza newPizza)
    {
        throw new NotImplementedException();
    }

    public void AddTopping(int PizzaId, int ToppingId)
    {
        throw new NotImplementedException();
    }

    public void UpdateSauce(int PizzaId, int SauceId)
    {
        throw new NotImplementedException();
    }

    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }

}
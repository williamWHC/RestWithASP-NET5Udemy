using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Service.Interface
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByiD(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}

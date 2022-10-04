using rest_api_tests.Model;

namespace rest_api_tests.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        Person FindById(long id);
        void DeleteById(long id);
        List<Person> FindAll();
    }
}

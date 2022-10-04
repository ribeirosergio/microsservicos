using rest_api_tests.Model;

namespace rest_api_tests.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void DeleteById(long id)
        {
            
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                Name = "Sérgio",
                LastName = "Júnior",
                Address = "Volta Redonda/RJ",
                Gender = "Male"
            };
        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();

            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }

            return people;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Name = "Person Name" + i,
                LastName = "Person LastName " + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}

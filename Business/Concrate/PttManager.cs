using Entities.Concrete;

namespace Business.Concrate
{
    public class PttManager
    {
        PersonManager personManager = new PersonManager();
        public void GiveMask(Person person)
        {
            if (personManager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }

        }
    }
}

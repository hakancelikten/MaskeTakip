using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2013.Word;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class PttManager
    {
        public void GiveMask(Person person);
        {
        PersonManager personManager= new PersonManager();

        if(personManager.CheckPerson(person))
            {
            Console.WriteLine(person.FirstName + "için maske verildi" );
            }
        }
    }
}

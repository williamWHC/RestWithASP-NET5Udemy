﻿using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Service.Interface;

namespace RestWithASPNETUdemy.Service
{
    public class PersonServiceImplementation : IPersonService
    {
        //utilizado para mockar um id
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        public Person FindByiD(long id)
        {
            return new Person
            {
                Id = id,
                FirtName = "William",
                LastName = "Henrique Cirino",
                Address = "Itaquera - São Paulo - SP",
                Gender = "Masculino"
            };

        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirtName = "Lorenzo" + i,
                LastName = "dos Anjos Moreira Cirino" + i,
                Address = "Rua Piacatu" + i,
                Gender = "Masculino" + i
            };
        }

        private long IncrementAndGet()
        {
            // Interlocker => Intertravado
            return Interlocked.Increment(ref count);
        }
    }
}
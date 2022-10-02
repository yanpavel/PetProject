using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace JollyHeisenberg
{
    public class PersonalData //help to generate data
    {
        static Faker fake = new Faker();


        private static string[] surname = new string[] { "Grey", "Васильев", "Rømer" };
        private static string[] address = new string[] { "11201, New York, Green str, 5", "670000, г Улан-Удэ, ул Егорова, д 1" };
        private static string[] phone = new string[] { "+7 (995) 855-22-22", "+7 (000) 000-00-00" };
        private static string[] name = new string[] { "TEST", "Павел", "Björk" };


        string _surname = fake.Random.ArrayElement<string>(surname);
        string _name = fake.Random.ArrayElement<string>(name);
        string _address = fake.Random.ArrayElement<string>(address);
        string _phone = fake.Random.ArrayElement<string>(phone);

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                this._surname = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                this._address = value;
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                this._phone = value;
            }
        }
    }
}

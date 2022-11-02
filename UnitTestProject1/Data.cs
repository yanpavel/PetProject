using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using LinqToDB.Mapping;

namespace JollyHeisenberg
{
    [Table(Name ="pay_info")]
    public class Data //help to generate data
    {
        static Faker fake=new Faker();

        
        private static string[] surname = new string[] { "Grey", "Васильев", "Rømer" };
        private static string[] address = new string[] { "11201, New York, Green str, 5", "670000, г Улан-Удэ, ул Егорова, д 1" };
        private static string[] phone = new string[] { "+7 (995) 855-22-22", "+7 (000) 000-00-00" };
        private static string[] number = new string[] { "3700 0000 0000 002", "6011000000000012", "4111111111111111" };
        private static string[] name = new string[] { "TEST", "Павел", "Björk" };
        private static string[] date = new string[] { "00/00", "01/22", "99/99" };
        private static string[] cvv = new string[] { "344", "000", "9999" };

        string _surname = fake.Random.ArrayElement<string>(surname);
        string _name = fake.Random.ArrayElement<string>(name);
        string _address = fake.Random.ArrayElement<string>(address);
        string _phone = fake.Random.ArrayElement<string>(phone);
        string _number = fake.Random.ArrayElement<string>(number);
        string _date = fake.Random.ArrayElement<string>(date);
        string _cvv = fake.Random.ArrayElement<string>(cvv);
                
        public string Surname { 
            get  
            {
                return _surname;
            }
            set {
                this._surname = value;
            }
        }

        [Column(Name = "fio")]
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
        
        [Column(Name = "card_number")]
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                this._number = value;
            }
        }
        
        [Column(Name = "expiration_date")]
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                this._date = value;
            }
        }

        [Column(Name = "cvv")]
        public string CVV
        {
            get
            {
                return _cvv;
            }
            set
            {
                this._cvv = value;
            }
        }
    }
}

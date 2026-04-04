using ConsoleApp46.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46.Models
{
    public class Person
    {
        private int _maxHP = 100;
        private int _hp = 100;
        private int _strength = 0;
        private int _coin = 0;
        private string _namePerson;

        public int MaxHP
        {
            get => _maxHP;
            set => _maxHP = value;
        }

        public int HP
        {
            get => _hp;
            set => _hp = value;
        }

        public int Strength
        {
            get => _strength;
            set => _strength = value;
        }

        public int Coin
        {
            get => _coin;
            set => _coin = value;
        }

        public string NamePerson
        {
            get => _namePerson;
            set => _namePerson = value;
        }

        public Person(int hp = 100, string name = "Враг")
        {
            _namePerson = name;
            _hp = hp;
            _maxHP = hp;
        }
    }
}

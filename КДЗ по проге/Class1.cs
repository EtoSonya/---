using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo
{
    class Достом
    {

        private string _название;

        public string Название
        {
            get { return _название; }
            set { _название = value; }
        }

        // 0 - 10
        private int _адрес;
        private static string адрес;

        public int Адрес
        {
            get { return _адрес; }
            set { _адрес = value; }
        }

        public Достом(string name, string adres)
        {
            _название = Название;
            _адрес = Адрес;
        }

        public Достом(string name)
            : this(name, адрес)
        {
        }
    }
}

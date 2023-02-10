using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 'Eng.Rasheed Adnan Al-Wahbany ^_^'
namespace H_Travels
{
    class Parent
    {
        public string Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Phone { get; set; }
        public string Desc { get; set; }
        public Parent(string i, string fn, string ln, int ph, string des)
        {
            Id = i;
            Fname = fn;
            Lname = ln;
            Phone = ph;
            Desc = des;
        }
    }
}

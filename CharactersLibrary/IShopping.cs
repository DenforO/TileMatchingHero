using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public interface IShopping
{
    string Id { get; set; }
    string Name { get; set; }
    string IconPath { get; set; }
    string Element { get; set; }
    int Price { get; set; }
    bool Bought { get; set; }
    string Tip { get; set; }
}
}

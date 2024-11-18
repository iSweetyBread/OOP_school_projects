using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public interface IOsoba
    {
        String Imie { get; set; }
        String Nazwisko { get; set; }

        void ZwrocPelnaNazwe() { }
    }
}

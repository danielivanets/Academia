using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Model
{
    class Matricula : BaseModel
    {
        int id;
        Curset curset;
        Alumne alumne;
        Data data;
    }
}

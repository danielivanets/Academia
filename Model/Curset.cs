using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Model
{
    class Curset : BaseModel
    {
        private int id;
        public int Id { get { return id; } set { SetProperty(ref id, value); } }
        private String nom;
        public String Nom { get { return nom; } set { SetProperty(ref nom, value); } }

        public Curset()
        {

        }

        public Curset(int id, String nom)
        {
            this.Id = id;
            this.Nom = nom;
        }


    }
}

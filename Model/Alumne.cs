using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Model
{
    class Alumne : BaseModel
    {
        private int id;
        public String Id { get { return id; } set { SetProperty(ref id, value); } }
        private String nom;
        public String Nom { get { return nom; } set { SetProperty(ref nom, value); } }
        private String cognoms;
        public String Cognom { get { return cognoms; } set { SetProperty(ref cognoms, value); } }
        private String dni;
        public String DNI { get { return dni; } set { SetProperty(ref dni, value); } }


        public Alumne()
        {

        }

        public Alumne(int id, String dni, String nom, String cognoms)
        {
            this.Id = id;
            this.Nom = nom;
            this.Cognoms = cognoms;
            this.Dni = dni;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class GljivaClass
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public bool jestiva { get; set; }
        public string opis { get; set; }
        public bool pronadena { get; set; }
        public enum Boja { zuta, zelena, crna, bijela, crvena, narancasta, smeda, siva, krem, maslinasta };
        public enum Vrijeme_branja { jesen, ljeto, proljece, zima, cijela_godina }; 
        public enum Mjesto_branja { crnogoricna_suma, bjelogoricna_suma, livada, sve_sume };
        public enum Klobuk { konveksan, ravan, odmaknut, stozast, pupcast, polukuglast, ljevkast, zvonolik, ulegnut, jajast, ispupcen };
        public enum Strucak { gol, koprena, obojak, prstenak, prstenak_i_obojak, bez_strucka };



        public void pretraga(Boja boja, Vrijeme_branja vrijeme, Mjesto_branja mjesto) {

                       
        }


    }
}

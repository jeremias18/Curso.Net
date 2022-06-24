using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13.Models {
    internal class Billetera {

        //Propiedades
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        //Constructor
        public Billetera() { }

        public Billetera(int billete10, int billete20, int billete50, int billete100, int billete500, int billete1000) {
            BilletesDe10 = billete10;
            BilletesDe20 = billete20;
            BilletesDe50 = billete50;
            BilletesDe100 = billete100;
            BilletesDe500 = billete500;
            BilletesDe1000 = billete1000;
        }

        //Métodos
        public decimal Total() {
            decimal total = 0;
            total += 10 * BilletesDe10;
            total += 20 * BilletesDe20;
            total += 50 * BilletesDe50;
            total += 100 * BilletesDe100;
            total += 500 * BilletesDe500;
            total += 1000 * BilletesDe1000;
            return total;
        }

        public Billetera Combinar(Billetera billetera) {
            var NuevaBilletera = new Billetera();
            NuevaBilletera.BilletesDe10 = (billetera.BilletesDe10 + BilletesDe10);
            NuevaBilletera.BilletesDe20 = (billetera.BilletesDe10 + BilletesDe20);
            NuevaBilletera.BilletesDe50 = (billetera.BilletesDe10 + BilletesDe50);
            NuevaBilletera.BilletesDe100 = (billetera.BilletesDe10 + BilletesDe100);
            NuevaBilletera.BilletesDe500 = (billetera.BilletesDe10 + BilletesDe500);
            NuevaBilletera.BilletesDe1000 = (billetera.BilletesDe10 + BilletesDe1000);
            return NuevaBilletera;
        }

        public void Vaciar() {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }

    }
}

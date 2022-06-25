using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_14.Models{
    internal class Baraja : Carta{
        public list<Carta> Cartas { get; set; }

    }

    //Constructor
    public Baraja(){
        string Palo = "";
        for(int i = 0; i < 4; i ++){
            Palo = crearPalo(i, Palo);
        }
    }
    //Metodos
    public barajar(){
        
    }



    private string crearPalo(int i, string palo){
        switch(i){
            case 0: {
                palo = "espadas";
            }
            case 1: {
                palo = "bastos";
            }
            case 2: {
                palo = "oros";
            }
            case 3: {
                palo = "copas";
            }
        }
        return palo;
    }
}
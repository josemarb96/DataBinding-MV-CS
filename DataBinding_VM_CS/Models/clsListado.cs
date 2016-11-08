using System;
using System.Collections.Generic;
using System.Linq;
using DataBinding_VM_CS.Models;
using System.Collections.ObjectModel;

namespace DataBinding_VM_CS.Models
{
    public class clsListado
    {
        public ObservableCollection<clsPersona> getListadoPersonas()
        {
            ObservableCollection<clsPersona> lista = new ObservableCollection<clsPersona>();
            
            lista.Add(new clsPersona(1,"David", "Benítez Rasero", new DateTime(2012,12,12), "Montequinto", "123456789"));
            lista.Add(new clsPersona(2,"Makoto", "Naegi", new DateTime(1996, 12, 8), "Japon Street", "123789456"));
            lista.Add(new clsPersona(3,"Sayaka", "Maizono", new DateTime(1999, 4, 25), "Quinto Pino, Pinar 12", "147258369"));
            lista.Add(new clsPersona(4,"Kyouko", "Kirigiri", new DateTime(2015, 7, 7), "Av. de la Constitucion Nº12", "963852147"));

            return lista;
        }
    }
}
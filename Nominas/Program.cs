﻿using System;

namespace Nominas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejecutar Menu Principal
            byte opcion = 0;
            bool salir = false;
            
            do
            {
                opcion = Interfaz.MenuPrincipal();

                switch (opcion)
                {
                    // Ver trabajadores
                    case 1:
                        Ficheros.ExistOrEmpty();
                        Interfaz.OperacionesEmpleado();
                        break;
                    case 2:
                        Ficheros.setConfig();
                        break;
                    case 3:
                        salir = true;
                        break;
                }
            } while (!salir);
            #endregion Fin Ejecutar
        }
    }
}

﻿using Compilador.Transversal;

namespace Compilador.TablaSimbolos
{
    public static class TablaMaestra
    {
        public static void SincronizarSimbolo(ComponenteLexico componente)
        {
            if (componente != null)
            {
                switch (componente.Tipo)
                {
                    case TipoComponente.DUMMY:
                        TablaSimbolos.Agregar(componente);
                        break;
                    case TipoComponente.SIMBOLO:
                        TablaDummys.Agregar(componente);
                        break;
                }
            }
        }
    }
}

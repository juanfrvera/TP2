using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Cliente
    {
        public enum TipoDocumento { DNI, CUIT, CUIL, LE, LC };
        //Atributos

        String iNroDocumento;
        String iNombre;
        TipoDocumento iTipoDocumento;

        //Propiedades

        public string NroDocumento
        {
            get { return this.iNroDocumento; }
            private set { this.iNroDocumento = value; }
        }
        public string Nombre
        {
            get { return this.iNombre; }
            private set { this.iNombre = value; }
        }

        public TipoDocumento TipoDoc
        {
            get { return this.iTipoDocumento; }
            private set { this.iTipoDocumento = value; }
        }

        //Constructores
        public Cliente(TipoDocumento pTipoDoc, String pNroDocumento, String pNombre)
        {
            this.NroDocumento = pNroDocumento;
            this.Nombre = pNombre;
            this.TipoDoc = pTipoDoc;
        }


    }
}

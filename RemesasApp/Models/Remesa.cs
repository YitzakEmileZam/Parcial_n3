using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemesasApp.Models
{
    public class Remesa
    {
        public int Id { get; set; }
        public string? NombreRemitente { get; set; }
        public string? NombreDestinatario { get; set; }
        public string? PaisOrigen { get; set; }
        public string? PaisDestino  { get; set; }
        public decimal? MontoEnviado  { get; set; }

        //USD O BTC
        public string? MonedaEnviada  { get; set; }
        public decimal? TasaCambio { get; set; }
        public decimal? MontoFinal { get; set; }
        
        //Pendiente o completado
        public string? EstadoTransaccion { get; set; } 
    }
}
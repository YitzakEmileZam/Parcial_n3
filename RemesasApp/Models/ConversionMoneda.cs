using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemesasApp.Models
{
    public class ConversionMoneda
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? TasaUsdBtc { get; set; }
        public decimal? TasaBtcUsd { get; set; }
    }
}
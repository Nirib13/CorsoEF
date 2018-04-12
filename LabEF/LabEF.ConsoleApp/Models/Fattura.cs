using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.ConsoleApp.Models
{
    [Table("Fatture")]
    

    public class Fattura
    {
        public int FatturaId { get; set; }

        [Column("Data")]
        public DateTime DataFattura { get; set; }

        [Column("Num")]
        public string NumeroFattura { get; set; }


        //altri dati

        public List<VoceFattura> VociFattura { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatanseverlerAnaliz
{
    class Oyuncular
    {
        [Key]
        public int ID { get; set; }
        public string FormaNu { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Pozisyon { get; set; }
        public string TelefonNu { get; set; }
        public string Boy { get; set; }
        public string Kilo { get; set; }
        public int Yas { get; set; }
        public string KatilmaTarihi { get; set; }
        public string Devamsizlik { get; set; }
        public string DisiplinCezasi { get; set; }
        public string Zimmet { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class CauHinh
    {
        [Key]
        public int IdCauHinh { get; set; }
        public string ThuongHieu { get; set; }
        public string BoNho { get; set; }
        public string Mang { get; set; }
        public string Sim { get; set; }
        public string ChongThamNuoc { get; set; }
        public string KTManHinh { get; set; }
        public string HeDieuHanh { get; set; }
        public string Ram { get; set; }
        public string CMRTruoc { get; set; }
        public string CMRSau { get; set; }
        public string GPS { get; set; }
        public string Bluetooth { get; set; }
        public string Pin { get; set; }
    }
}

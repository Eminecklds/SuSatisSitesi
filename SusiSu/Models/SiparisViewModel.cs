﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SusiSu.Enums.Enums;

namespace SusiSu.Models
{
    public class SiparisViewModel
    {
        
        public int Adet { get; set; }
        public int SiparisID { get; set; }
        public string UserID { get; set; }
        public Boy Boy { get; set; }
        public Tur Tur { get; set; }

    }
}
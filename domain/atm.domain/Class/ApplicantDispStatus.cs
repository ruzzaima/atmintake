﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantDispStatus : DomainObject
    {

        public virtual Applicant Parent { get; set; }
        

    }
}
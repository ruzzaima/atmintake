﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class AcqQuestionnaireScale : DomainObject
    {

        public virtual AcqQuestionnaire Parent { get; set; }

    

    }
}

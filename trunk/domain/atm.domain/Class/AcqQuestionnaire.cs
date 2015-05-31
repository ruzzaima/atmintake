using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class AcqQuestionnaire : DomainObject
    {

        public virtual Acquisition Parent { get; set; }

        public virtual ICollection<AcqQuestion> AcqQuestions { get; set; }
        public virtual ICollection<AcqQuestionnaireScale> AcqQuestionnaireScales { get; set; }

    }
}

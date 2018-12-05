using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H2C.Student.Common.DomainModels
{
    public class Studnt : BasePerson
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Code { get; set; }
    }
}

using Cross.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cross.Models
{
    public class Play
    {

        public int id { get; set; }

        public string suggest { get; set; }

        public virtual ICollection<Cell> cell { get; set; }

        //[DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public Play()
        {
            StartDate = DateTime.Now;
        }

    }
}
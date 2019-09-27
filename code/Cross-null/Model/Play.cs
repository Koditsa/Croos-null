using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Model_Cross
{
   public class Play
    {
      
        public int id { get; set; }
        
        public WhoWin Winner { get; set; }

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

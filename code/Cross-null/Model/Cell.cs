
//using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Model_Cross
{
  public  class Cell
    {
        //[Key]
        public int id { get; set; }
        public int I { get; set; }
        public int J { get; set; }
        public string Url { get; set; }
        public Status status { get; set; }
        public bool IfWin { get; set; }

        //[Required]
        public virtual Play play { get; set; }

        public Cell()
        {

        }

        public static bool operator ==(Cell c1, Cell c2)
        {
            if (c1.status == c2.status)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Cell c1, Cell c2)
        {
            if (c1.status == c2.status)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

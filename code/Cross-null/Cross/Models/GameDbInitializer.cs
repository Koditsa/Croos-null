using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cross.Models
{
    public class GameDbInitializer : DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext db)
        {
            db.Games.Add(new Play { StartDate = DateTime.Now, FinishDate = DateTime.Now});
            db.Games.Add(new Play { StartDate = DateTime.Now, FinishDate = DateTime.Now});
            db.Games.Add(new Play { StartDate = DateTime.Now, FinishDate = DateTime.Now});

            base.Seed(db);
        }
    }

}
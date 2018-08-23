using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;

namespace ClassLibrary.BLL
{
   public class ClubService
    {
        private igroup36_prodEntities db;

        public ClubService(igroup36_prodEntities _db)
        {
            db = _db;
        }

        public Club GetClub(int _clubId)
        {
            return db.Clubs.SingleOrDefault(x => x.ClubId == _clubId);
        }
    }
}

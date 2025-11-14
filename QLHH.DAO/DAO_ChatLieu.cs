using QLHH.DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class DAO_ChatLieu
    {
        QLSanPhamEntities1 db = new QLSanPhamEntities1();
        public List<DMChatLieu> LayTatCaChatLieu()
        {
            return db.DMChatLieux.ToList();
        }
    }
}
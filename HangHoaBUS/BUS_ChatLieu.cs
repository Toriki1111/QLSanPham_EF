using DAO;
using DTO;
using QLHH.DAO;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class BUS_ChatLieu
    {
        DAO_ChatLieu daoChatLieu = new DAO_ChatLieu();
        public List<ChatLieu_DTO> LayDanhSachChatLieu()
        {
            List<DMChatLieu> listModelEF = daoChatLieu.LayTatCaChatLieu();
            List<ChatLieu_DTO> listDTO = listModelEF.Select(ef => new ChatLieu_DTO
            {
                MaChatLieu = ef.MaChatLieu,
                TenChatLieu = ef.TenChatLieu
            }).ToList();

            return listDTO;
        }
    }
}
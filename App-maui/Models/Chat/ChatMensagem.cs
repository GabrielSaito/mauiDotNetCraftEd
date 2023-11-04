using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftEd.Models.Chat
{
    public class Friend
    {
        public string FriendName { get; set; }
    }

    public class ChatMensagem
    {

        public string Text { get; set; }
        public Color BackgroundColor { get; set; }
        public Color TextColor { get; set; }


        public string UserImage { get; set; }
        public string FriendName { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageTime { get; set; }
    }

}


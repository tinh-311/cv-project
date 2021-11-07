using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public class cons
    {
        public static int CHESS_WIDTH = 30;
        public static int CHESS_HEIGHT = 30;

        public static int CHESS_BOARD_WIDTH = 21;
        public static int CHESS_BOARD_HEIGHT = 19;

        public static int COUNTDOWN_STEP = 100;
        public static int COUNTDOWN_TIME = 60000;
        public static int COUNTDOWN_INTERVAL = 100;

        public static Button btnWin;
        public static bool isClickLan = false;

        public static bool isConnect = false;
        public static bool isAccept = false;

        public static Button oldBtn = new Button();
    }
}

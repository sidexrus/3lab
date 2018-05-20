using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class game
    {
        public bool x_o = true;
        public int checkresult(List<int> result)
        {
            if ((result[0] == result[1]) && (result[0] == result[2]))  return 1;
            return 0;
        }
    }
}

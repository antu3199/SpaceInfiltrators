using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Space_Infiltrators
{
    static class Program
    {
        /// <summary>
        /// Space Infiltrators game. Similar to Space Invaders in a way, but only because of the genre.
        /// Space Infiltrators is an entirely new game. Fight against waves of  enemies to stop the evil aliens from 
        /// destroying the WORLD!!! Your capital ship, the Battlecruiser, has bullets to shoot at invading enemy aliens.
        /// Also, it has a blast attack, a laser, and a bomb. Defeat the bosses of each enemy stage and defend your
        /// home planet!
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}

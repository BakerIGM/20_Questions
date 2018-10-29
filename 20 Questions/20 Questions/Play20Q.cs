/* Play20Q class - Plays a single game.
 * Handles situations where tree is null and where tree is a single (leaf) node.
 * These situations are not required for the student projects, but I left them in.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Questions
{
    class Play20Q
    {
        // Play a complete round of the game, starting at the root of the tree
        // and working down to a leaf node.  If the program correctly guessed
        // the name, it wins.  If it didn't get the name correct, it learns
        // the name the player had in mind and grows the tree to include the
        // new name, the old name, and a new phrase that delineates them.
        public static void PlayOneRound(BinTree tree)
        {
        }
    }
}

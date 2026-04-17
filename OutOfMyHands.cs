/** This is a game about Trust. 
https://github.com/dorktoast/52Fragments 

LINES ENDING IN AN OCTOTHORPE (#) may ONLY be modified by the Maintainer.
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Sirenix.Serialization;

// Only the Maintainer may modify anything above this line. (If necessary, add additional dependencies below) #

using TMPro; // put dependencies here

namespace GIB.Fragments
{
	public class OutOfMyHands : MonoBehaviour
	{
        public bool AchievementCondition; // The player will receive an achievement if this bool is true when WinFragment () is called. #

        public void BeginFragment() // This will be called 1 second after the fragment begins. #
        {
            WinFragment();
        }

        public void WinFragment() { } // The player only wins if this function is called. #
    }
}

// Only the Maintainer may modify anything below this line. #

/**
 * OutOfMyHands.cs
 * A Script for The 52 Fragments
 * 
 * Maintainer: Toast <sam@gib.games>
 * Created on: 4/17/2026
 * 
 * Steam: https://steamcommunity.com/app/2702660
 * itch: https://dorktoast.itch.io/52
 * Contributors:
*/
/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
    public static class ManagerController // TypeDefIndex: 10488
    {
        // Fields
        public static List<GlobalManager> _globalManagers; // 0x00
        public static List<InLevelManager> _inLevelManagers; // 0x08

        // Constructors
        static ManagerController() { } // 0x0000000189BFE0C0-0x0000000189BFE180

        // Methods
        public static void CreateGlobalManager<T>()
            where T : GlobalManager
        { }
        public static void CreateInLevelManager<T>()
            where T : InLevelManager
        {
            _inLevelManagers.Add(T);
        }
        public static void DestroytGlobalManager<T>()
            where T : GlobalManager
        { }
        public static void DestroyInLevelManager<T>()
            where T : InLevelManager
        { }
        // [XID] // 0x000000018991E170-0x000000018991E190
        public static void CheckGlobalManagersEmpty() { } // 0x0000000189BFD050-0x0000000189BFD170
                                                          // [XID] // 0x0000000189925A80-0x0000000189925AA0
        public static void CheckInLevelManagersEmpty() { } // 0x0000000189BFD170-0x0000000189BFD290
                                                           // [XID] // 0x0000000189774D20-0x0000000189774D40
        public static void ReloadGlobalManagers() { } // 0x0000000189BFDC60-0x0000000189BFDDD0
                                                      // [XID] // 0x0000000189934540-0x0000000189934560
        public static void InitGlobalManagersByLocalData() { } // 0x0000000189BFD830-0x0000000189BFD9A0
                                                               // [XID] // 0x000000018993C150-0x000000018993C170
        public static void TickGlobalManagers() { } // 0x0000000189BFDDD0-0x0000000189BFDF40
                                                    // [XID] // 0x00000001899434F0-0x0000000189943510
        public static void TickInLevelManagers() { } // 0x0000000189BFDF40-0x0000000189BFE0C0
                                                     // [XID] // 0x0000000189794F80-0x0000000189794FA0
        public static void InitInLevelManagersOnConnect() { } // 0x0000000189BFDB00-0x0000000189BFDC60
                                                              // [XID] // 0x0000000189952570-0x0000000189952590
        public static void ClearInLevelManagersOnDisconnect() { } // 0x0000000189BFD6D0-0x0000000189BFD830
                                                                  // [XID] // 0x0000000189959A90-0x0000000189959AB0
        public static void ClearGlobalManagersOnLevelDestroy() { } // 0x0000000189BFD570-0x0000000189BFD6D0
                                                                   // [XID] // 0x00000001899613D0-0x00000001899613F0
        public static void InitGlobalManagersOnConnect() { } // 0x0000000189BFD9A0-0x0000000189BFDB00
                                                             // [XID] // 0x00000001897E1180-0x00000001897E11A0
        public static void ClearGlobalManagersOnDisconnect() { } // 0x0000000189BFD410-0x0000000189BFD570
                                                                 // [XID] // 0x00000001897C3250-0x00000001897C3270
        public static void ClearGlobalManagersOnBackHome(bool forceClear = true /* Metadata: 0x00AE7650 */) { } // 0x0000000189BFD290-0x0000000189BFD410
    }
}

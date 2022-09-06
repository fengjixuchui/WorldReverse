/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Home : GameWorld // TypeDefIndex: 19919
{
    // Fields
    private static bool isFirstLoad = true; // 0x00
    private Coroutine curCoroutine; // 0x20

    // Constructors
    public Home() { } // 0x0000000183606A00-0x0000000183606A60

    // Methods
    // [XID] // 0x0000000189A7B7A0-0x0000000189A7B7C0
    public override void Init(uint token)
    {
        scenePath = "Home";
        InitHomeManager();
        LoadScene();
    } // 0x00000001836061C0-0x0000000183606290
      // [XID] // 0x0000000189A82FE0-0x0000000189A83000
    public void InitHomeManager()
    {
        Singleton<BundleDownloadWorld>.Create();
        ManagerController.CreateInLevelManager<LevelTimeManager>();
        ManagerController.CreateInLevelManager<EffectManager>();
        ManagerController.CreateInLevelManager<EnviroManager>();
    } // 0x0000000183606890-0x00000001836069A0
      // [XID] // 0x0000000189A8A820-0x0000000189A8A840
    public void DestroyHomeManager() { } // 0x00000001836065E0-0x00000001836066F0
                                         // [XID] // 0x0000000189A92100-0x0000000189A92120
    private void LoadScene() { } // 0x0000000183605FB0-0x00000001836061C0
    [DebuggerHidden] // 0x0000000189A99AC0-0x0000000189A99B00
                     // [XID] // 0x0000000189A99AC0-0x0000000189A99B00
    private IEnumerator OnSceneLoaded() => default; // 0x0000000183605CC0-0x0000000183605DC0
    [DebuggerHidden] // 0x0000000189AA3E40-0x0000000189AA3E80
                     // [XID] // 0x0000000189AA3E40-0x0000000189AA3E80
    private IEnumerator OnSceneLoadedAynsc() => default; // 0x0000000183606790-0x0000000183606890
                                                         // [XID] // 0x0000000189AAE530-0x0000000189AAE550
    public override void FixedTick() { } // 0x0000000183606540-0x00000001836065E0
                                         // [XID] // 0x0000000189AB5D80-0x0000000189AB5DA0
    public override void Tick() { } // 0x0000000183606290-0x0000000183606410
                                    // [XID] // 0x0000000189ABD8F0-0x0000000189ABD910
    public override void LateTick() { } // 0x00000001836066F0-0x0000000183606790
                                        // [XID] // 0x0000000189AC53B0-0x0000000189AC53D0
    public override void AfterLateUpdatePostSchedule() { } // 0x0000000183606410-0x0000000183606540
                                                           // [XID] // 0x0000000189ACC820-0x0000000189ACC840
    public override void Destroy() { } // 0x0000000183605E20-0x0000000183605FB0
}


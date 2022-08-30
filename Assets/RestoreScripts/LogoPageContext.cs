/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LogoPageContext : BasePageContext // TypeDefIndex: 30020
{
    // Fields
    private MonoLogoCanvas _pageMono; // 0x190
    private Action _closeCallback; // 0x198
    private uint _handle; // 0x1A0
    private uint _tipImgHandle; // 0x1A4
    private bool _showWarningView; // 0x1A8
    private bool _showKoranTips; // 0x1A9

    // Properties
    private static string TITLE_CONFIG_PATH { /* [XID] */ /* 0x00000001897475E0-0x0000000189747600 */ get => default; } // 0x0000000181EE6910-0x0000000181EE69B0 

    public LogoPageContext(Action closeCallBack = null) { } // 0x0000000181EE8140-0x0000000181EE8260

    // Methods
    // [XID] // 0x000000018974ED30-0x000000018974ED50
    public override void SetupView() { } // 0x0000000181EE7CD0-0x0000000181EE8140
                                         // [XID] // 0x0000000189756440-0x0000000189756460
    public override void ClearView() { } // 0x0000000181EE6C10-0x0000000181EE6D40
                                         // [XID] // 0x000000018975D860-0x000000018975D880
    public override void ClosePage()
    {
        if (_closeCallback != null) _closeCallback();
        base.ClosePage();
    } // 0x0000000181EE6B50-0x0000000181EE6C10
      // [XID] // 0x0000000189764E10-0x0000000189764E30
    private void SetLogoView() { } // 0x0000000181EE6D40-0x0000000181EE7910
                                   // [XID] // 0x000000018976C8B0-0x000000018976C8D0
    private void SetWarningView() { } // 0x0000000181EE69B0-0x0000000181EE6B50
                                      // [XID] // 0x0000000189773D50-0x0000000189773D70
    private void SetKoranTipsView() { } // 0x0000000181EE7B30-0x0000000181EE7CD0
                                        // [XID] // 0x000000018977B3C0-0x000000018977B3E0
    private string GetLogoPath(LanguageType langType) => default; // 0x0000000181EE7A30-0x0000000181EE7B30
    private void __iFixBaseProxy_SetupView() { } // 0x0000000181EE7970-0x0000000181EE79D0
    private void __iFixBaseProxy_ClearView() { } // 0x0000000181EE79D0-0x0000000181EE7A30
    private void __iFixBaseProxy_ClosePage() { } // 0x0000000181EE7910-0x0000000181EE7970
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AudioSettingData // TypeDefIndex: 19233
{
    // Fields
    private static readonly ConfigMetaConfig.PathHash _settingConfigPathHash; // 0x00

    // Properties
    public static ConfigAudioSetting setting { /* [XID] */ /* 0x0000000189B6CA80-0x0000000189B6CAC0 */ get => setting; /* [XID] */ /* 0x0000000189B77070-0x0000000189B770B0 */ private set { setting = value; } } // 0x0000000183590420-0x00000001835904B0 0x00000001835905C0-0x0000000183590650

    // Constructors
    static AudioSettingData()
    {
        _settingConfigPathHash = new ConfigMetaConfig.PathHash();
        _settingConfigPathHash.origin = CommonMiscs.GetAssetPathHash("Data/_JsonOutput/Audio/Setting/Loner");
        _settingConfigPathHash.bin = CommonMiscs.GetAssetPathHash("Data/_BinOutput/Audio/Setting/Loner");
    } // 0x0000000183590650-0x0000000183590720

    // Methods
    // [XID] // 0x00000001898400E0-0x0000000189840100
    public static void ReloadFromFile()
    {
        var audio = new AudioData.ConfigSettingAbstraction();
        setting = audio.DeserializeFromFile(_settingConfigPathHash);
    } // 0x00000001835904B0-0x00000001835905C0
}


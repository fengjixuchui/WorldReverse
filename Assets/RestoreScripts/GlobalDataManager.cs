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
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class GlobalDataManager // TypeDefIndex: 19560
{
    // Fields
    private static float _dataLoadingFrameBudget; // 0x00
    private static float _dataLoadingCurrentWindowBegin; // 0x04
    private static bool _inLoadingNonExcelData; // 0x08
    private static List<string> _dataListNonExcel; // 0x10
    private static float _refreshProgress; // 0x18
    private static Action<float> _progressCallBack; // 0x20
    public const string META_CONFIG_PATH = "Data/Common/MetaConfig"; // Metadata: 0x00AFCAD5
    public static ConfigMetaConfig metaConfig; // 0x28
    private static uint metaConfigHandle; // 0x30
    public static bool firstTime; // 0x34
    private static int _calculatedDataContentHash; // 0x38

    // Properties
    private static float RefreshProgress { /* [XID] */ /* 0x0000000189A68170-0x0000000189A68190 */ get; /* [XID] */ /* 0x0000000189A6F580-0x0000000189A6F5A0 */ set; } // 0x0000000181CC00D0-0x0000000181CC01A0 0x0000000181CBE350-0x0000000181CBE4B0
    public static int dataContentHash { /* [XID] */ /* 0x0000000189B045E0-0x0000000189B04600 */ get; } // 0x0000000181CBDBC0-0x0000000181CBDC90 

    // Constructors
    static GlobalDataManager() { } // 0x0000000181CC01A0-0x0000000181CC0270

    // Methods
    [DebuggerHidden] // 0x0000000189A76D10-0x0000000189A76D50
                     // [XID] // 0x0000000189A76D10-0x0000000189A76D50
    private static IEnumerator LoadDataReaderAsync(Action<float> progressCB = null) => default; // 0x0000000181CBE740-0x0000000181CBE810
    [DebuggerHidden] // 0x0000000189A81730-0x0000000189A81770
                     // [XID] // 0x0000000189A81730-0x0000000189A81770
    private static IEnumerator LoadNonExcelDataAsync(Action<float> progressCB = null) => default; // 0x0000000181CBDF80-0x0000000181CBE050
    [DebuggerHidden] // 0x0000000189A8C140-0x0000000189A8C180
                     // [XID] // 0x0000000189A8C140-0x0000000189A8C180
    private static IEnumerator LoadPreLuaAsync(Action<float> progressCB = null) => default; // 0x0000000181CBEB50-0x0000000181CBEC20
                                                                                            // [XID] // 0x0000000189A966E0-0x0000000189A96700
    private static void ProgressStep(float step) { } // 0x0000000181CBD8C0-0x0000000181CBD9A0
                                                     // [XID] // 0x0000000189A9DC50-0x0000000189A9DC70
    private static void OnLoadOneDataFinish(string dataName) { } // 0x0000000181CBEC20-0x0000000181CBEDE0
                                                                 // [XID] // 0x0000000189AA5680-0x0000000189AA56A0
    public static bool CheckStepLoadingFrame(float budgetCoefficient = 1f /* Metadata: 0x00AFCAD1 */) => default; // 0x0000000181CBD9A0-0x0000000181CBDAF0
    [DebuggerHidden] // 0x0000000189AACDA0-0x0000000189AACDE0
                     // [XID] // 0x0000000189AACDA0-0x0000000189AACDE0
    private static IEnumerator LoadSECTRAsync(Action<float> progressCB = null) => default; // 0x0000000181CBFF60-0x0000000181CC0030
                                                                                           // [XID] // 0x0000000189AB7570-0x0000000189AB7590
    public static void Init() { } // 0x0000000181CBE050-0x0000000181CBE110
                                  // [XID] // 0x0000000189ABF030-0x0000000189ABF050
    private static void SpecialRefresh() { } // 0x0000000181CBE8E0-0x0000000181CBE9E0
    [DebuggerHidden] // 0x0000000189AC6A90-0x0000000189AC6AE0
                     // [IDTag] // 0x0000000189AC6A90-0x0000000189AC6AE0
                     // [XID] // 0x0000000189AC6A90-0x0000000189AC6AE0
    public static IEnumerator Refresh(Action<float> progressCB = null) => default; // 0x0000000181CBCDE0-0x0000000181CBCEB0
                                                                                   // [IDTag] // 0x0000000189AD45F0-0x0000000189AD4630
                                                                                   // [XID] // 0x0000000189AD45F0-0x0000000189AD4630
    public static void Refresh() { } // 0x0000000181CBCEB0-0x0000000181CBD070
                                     // [XID] // 0x0000000189ADF0D0-0x0000000189ADF0F0
    public static void LoadDataReader() { } // 0x0000000181CBEDE0-0x0000000181CBFF60
                                            // [XID] // 0x0000000189823D20-0x0000000189823D40
    public static void UnloadMetaConfig() { } // 0x0000000181CBE110-0x0000000181CBE220
                                              // [XID] // 0x0000000189AEE3E0-0x0000000189AEE400
    public static void ReloadMetaConfig() { } // 0x0000000181CBDC90-0x0000000181CBDDE0
                                              // [XID] // 0x0000000189AF59B0-0x0000000189AF59D0
    public static void LoadNonExcelData() { } // 0x0000000181CBD070-0x0000000181CBD750
                                              // [XID] // 0x0000000189AFCE50-0x0000000189AFCE70
    private static void LoadPreLua() { } // 0x0000000181CBD750-0x0000000181CBD8C0
                                         // [XID] // 0x0000000189B0BE90-0x0000000189B0BEB0
    public static void CalculateAndStoreLoadedDataContentHash() { } // 0x0000000181CBDAF0-0x0000000181CBDBC0
                                                                    // [XID] // 0x0000000189B13500-0x0000000189B13520
    private static void HashOnto(ref int accHash, int curHash) { } // 0x0000000181CBE9E0-0x0000000181CBEB50
                                                                   // [XID] // 0x0000000189B1AC60-0x0000000189B1AC80
    public static int HashDataContent() => default; // 0x0000000181CC0030-0x0000000181CC00D0
                                                    // [XID] // 0x0000000189B22190-0x0000000189B221B0
    public static bool ValidateHash() => default; // 0x0000000181CBE810-0x0000000181CBE8E0
                                                  // [XID] // 0x0000000189B297A0-0x0000000189B297C0
    public static void SetLocalizedTextHandler() { } // 0x0000000181CBDDE0-0x0000000181CBDF80
                                                     // [XID] // 0x0000000189B30D10-0x0000000189B30D30
    public static void InitEmbeddedData()
    {
        EmbeddedTextMapConfigLoader.LoadData();
        Singleton<TextMapManager>.Instance.LoadEmbeddedTextMap();
        EmbeddedTextMapConfig.getLocalizedTextHandler = TextMap.GetEmbeddedTextMapById;
        UIConfigData.LoadEmbededConfig();
        AssetConfigUtils.LoadEmbededConfigs();
        GraphicsSettingData.ReloadFromFile();
        MusicData.LoadEmbeddedConfig();
        AudioSettingData.ReloadFromFile();
    } // 0x0000000181CBE4B0-0x0000000181CBE740
      // [XID] // 0x00000001899A3CE0-0x00000001899A3D00
    public static void RefreshData() { } // 0x0000000181CBE220-0x0000000181CBE350
}


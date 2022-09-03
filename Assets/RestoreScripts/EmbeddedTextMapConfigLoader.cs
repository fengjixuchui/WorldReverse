/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class EmbeddedTextMapConfigLoader // TypeDefIndex: 15566
{
    // Fields
    private static Dictionary<string, EmbeddedTextMapConfig> _dataDict; // 0x00
    public static Action<List<DataHotfixMeta>, List<EmbeddedTextMapConfig>> customApplyHotfixAction; // 0x08
    public static Action<EmbeddedTextMapConfig, EmbeddedTextMapConfig> onUpdateConfig; // 0x10
    public static Action onApplyHotfixFinish; // 0x18
    public static Func<List<DataHotfixMeta>, List<EmbeddedTextMapConfig>, Dictionary<string, EmbeddedTextMapConfig>, string, bool> customValidateFunc; // 0x20

    // Properties
    public static Dictionary<string, EmbeddedTextMapConfig> dataDict { /* [XID] */ /* 0x0000000189757000-0x0000000189757020 */ get; } // 0x0000000184D27F80-0x0000000184D28030 
    private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189765C50-0x0000000189765C70 */ get; } // 0x0000000184D26DE0-0x0000000184D26E80 

    // Methods
    // [XID] // 0x000000018974F9F0-0x000000018974FA10
    public static void Register() { } // 0x0000000184D28360-0x0000000184D28400
                                      // [XID] // 0x000000018975E590-0x000000018975E5B0
    public static EmbeddedTextMapConfig GetData(string textMapId) => default; // 0x0000000184D26CA0-0x0000000184D26DE0
                                                                              // [XID] // 0x000000018976D3A0-0x000000018976D3C0
    public static void LoadData()
    {
        FromBinary();
        var json = DataHotfixUtil.GetHotfixLazyLoadData("EmbeddedTextMapConfig");
        if (json != null)
        {
            ApplyHotfix(json);
        }
    } // 0x0000000184D27410-0x0000000184D27500
      // [XID] // 0x00000001897747F0-0x0000000189774810
    private static void RegisterHotfixGenerated() { } // 0x0000000184D27240-0x0000000184D27410
                                                      // [XID] // 0x000000018977C200-0x000000018977C220
    public static void ApplyHotfix(JSONNode node) { } // 0x0000000184D26E80-0x0000000184D27240
                                                      // [IDTag] // 0x0000000189783C30-0x0000000189783C70
                                                      // [XID] // 0x0000000189783C30-0x0000000189783C70
    public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184D278E0-0x0000000184D279E0
                                                                 // [XID] // 0x000000018978E0D0-0x000000018978E0F0
    private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<EmbeddedTextMapConfig> configList)
    {
        metaList = default;
        configList = default;
        return default;
    } // 0x0000000184D28030-0x0000000184D28360
      // [XID] // 0x0000000189795800-0x0000000189795820
    private static bool ParseConfigFromLine(string line, out EmbeddedTextMapConfig data)
    {
        data = default;
        return default;
    } // 0x0000000184D27500-0x0000000184D27640
      // [IDTag] // 0x000000018979DC50-0x000000018979DC90
      // [XID] // 0x000000018979DC50-0x000000018979DC90
    private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<EmbeddedTextMapConfig> configList) => default; // 0x0000000184D27640-0x0000000184D278E0
                                                                                                                          // [IDTag] // 0x00000001897A7BC0-0x00000001897A7C00
                                                                                                                          // [XID] // 0x00000001897A7BC0-0x00000001897A7C00
    public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF1F43 */, bool useObjectPool = false /* Metadata: 0x00AF1F47 */) => default; // 0x0000000184D27D30-0x0000000184D27F80
                                                                                                                                                    // [IDTag] // 0x00000001897B26F0-0x00000001897B2730
                                                                                                                                                    // [XID] // 0x00000001897B26F0-0x00000001897B2730
    public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F48 */, bool useObjectPool = false /* Metadata: 0x00AF1F4C */) => default; // 0x0000000184D279E0-0x0000000184D27D30
}


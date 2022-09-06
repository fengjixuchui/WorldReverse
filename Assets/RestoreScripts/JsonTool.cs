/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Linq;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class JsonTool // TypeDefIndex: 14784
{
    // Fields
    private static Dictionary<System.Type, object> _emptyDict; // 0x00
    private static string[] _enumElementStr; // 0x18
    private static string[] _enumReactStr; // 0x20

    // Properties
    public static bool StrictMode { /* [XID] */ /* 0x0000000189A6B8D0-0x0000000189A6B910 */ get; /* [XID] */ /* 0x0000000189A75EE0-0x0000000189A75F20 */ set; } // 0x0000000180D3B490-0x0000000180D3B520 0x0000000180D3CC70-0x0000000180D3CD00
    public static string CurFilePath { /* [XID] */ /* 0x0000000189A80600-0x0000000189A80640 */ get; /* [XID] */ /* 0x0000000189A8B2A0-0x0000000189A8B2E0 */ set; } // 0x0000000180D3BEA0-0x0000000180D3BF30 0x0000000180DCED30-0x0000000180DCEDC0

    // Constructors
    static JsonTool() { } // 0x0000000180DCF190-0x0000000180DD0020

    // Methods
    public static bool IsEmptyValue<T>(T t)
        where T : IEmptyInitable => default;
    public static bool IsReferenceEmptyValue<T>(T t)
        where T : class => default;
    // [IDTag] // 0x0000000189A957D0-0x0000000189A95810
    // [XID] // 0x0000000189A957D0-0x0000000189A95810
    public static bool IsEmptyValue(MoleMole.Config.Vector v) => default; // 0x0000000180D3B6C0-0x0000000180D3B8F0
                                                                          // [IDTag] // 0x0000000189A9FED0-0x0000000189A9FF10
                                                                          // [XID] // 0x0000000189A9FED0-0x0000000189A9FF10
    public static bool IsEmptyValue(Point2D p) => default; // 0x0000000180D3B8F0-0x0000000180D3BAC0
                                                           // [IDTag] // 0x0000000189AAA390-0x0000000189AAA3D0
                                                           // [XID] // 0x0000000189AAA390-0x0000000189AAA3D0
    public static bool IsEmptyValue(ColorVector p) => default; // 0x0000000180D3BAC0-0x0000000180D3BD00
                                                               // [IDTag] // 0x0000000189AB4EC0-0x0000000189AB4F00
                                                               // [XID] // 0x0000000189AB4EC0-0x0000000189AB4F00
    public static bool IsEmptyValue(string s) => default; // 0x0000000180D3BD00-0x0000000180D3BEA0
                                                          // [IDTag] // 0x0000000189ABF8C0-0x0000000189ABF900
                                                          // [XID] // 0x0000000189ABF8C0-0x0000000189ABF900
    public static bool IsEmptyValue(object o) => default; // 0x0000000180D3B520-0x0000000180D3B6C0
    public static bool IsEmptyValue<T>(T[] a) => default;
    public static bool IsEmptyValue<T>(List<T> l) => default;
    public static bool IsEmptyValue<K, V>(Dictionary<K, V> d) => default;
    public static bool IsEmptyValue<V>(HashSet<V> hs) => default;
    public static void GetEmptyValue<T>(out T t)
        where T : IEmptyInitable, new()
    {
        t = default;
    }
    // [IDTag] // 0x0000000189ACA1C0-0x0000000189ACA200
    // [XID] // 0x0000000189ACA1C0-0x0000000189ACA200
    public static void GetEmptyValue(out string s)
    {
        s = default;
    } // 0x0000000180D3CF70-0x0000000180D3D180
      // [IDTag] // 0x0000000189AD5080-0x0000000189AD50C0
      // [XID] // 0x0000000189AD5080-0x0000000189AD50C0
    public static void GetEmptyValue(out object o)
    {
        o = default;
    } // 0x0000000180D3D180-0x0000000180D3D350
    public static void GetEmptyValue<T>(out T[] a)
    {
        a = default;
    }
    public static void GetEmptyValue<T>(out List<T> l)
    {
        l = default;
    }
    public static void GetEmptyValue<K, V>(out Dictionary<K, V> d)
    {
        var type = System.Type.GetTypeFromHandle(typeof(K).TypeHandle);
        bool flag = _emptyDict.TryGetValue(type, out var value);
        if (flag)
        {
            d = new Dictionary<K, V>();
            _emptyDict.Add(type, d);
        }
        else
        {
            d = new Dictionary<K, V>();
        }
    }
    public static void GetEmptyValue<V>(out HashSet<V> hs)
    {
        hs = default;
    }
    // [IDTag] // 0x0000000189ADFBB0-0x0000000189ADFBF0
    // [XID] // 0x0000000189ADFBB0-0x0000000189ADFBF0
    public static JSONNode LoadJSONConfig(string filePath, bool overrideDefault = false /* Metadata: 0x00AEF59D */, bool noError = false /* Metadata: 0x00AEF59E */) => default; // 0x0000000180CE9100-0x0000000180CE9430
                                                                                                                                                                                 // [IDTag] // 0x0000000189AEA060-0x0000000189AEA0A0
                                                                                                                                                                                 // [XID] // 0x0000000189AEA060-0x0000000189AEA0A0
    public static JSONNode LoadJSONConfig(ulong filePathHash, bool overrideDefault = false /* Metadata: 0x00AEF59F */, bool noError = false /* Metadata: 0x00AEF5A0 */) => default; // 0x0000000180CE9430-0x0000000180CE9820
                                                                                                                                                                                    // [XID] // 0x0000000189AF49D0-0x0000000189AF49F0
    public static string[] GetOriginPathsFromHashes(ConfigMetaConfig.PathHash[] pathHashes) => default; // 0x0000000180D9E260-0x0000000180D9E3F0
    [DebuggerHidden] // 0x0000000189AFC030-0x0000000189AFC080
                     // [IDTag] // 0x0000000189AFC030-0x0000000189AFC080
                     // [XID] // 0x0000000189AFC030-0x0000000189AFC080
    public static IEnumerator LoadJSONConfig(string filePath, Action<JSONNode> finishCallback) => default; // 0x0000000180CE9020-0x0000000180CE9100
                                                                                                           // [XID] // 0x0000000189B09790-0x0000000189B097B0
    private static void LoadedJsonText(string filePath, string jsonText, Action<JSONNode> finishCallback) { } // 0x0000000180D9E3F0-0x0000000180D9E6B0
                                                                                                              // [IDTag] // 0x0000000189B112A0-0x0000000189B112E0
                                                                                                              // [XID] // 0x0000000189B112A0-0x0000000189B112E0
    public static bool FromJson(JSONNode node, out sbyte ival)
    {
        ival = default;
        return default;
    } // 0x0000000180D3CA20-0x0000000180D3CB40
      // [IDTag] // 0x0000000189B1B4D0-0x0000000189B1B510
      // [XID] // 0x0000000189B1B4D0-0x0000000189B1B510
    public static bool FromJson(JSONNode node, out byte ival)
    {
        ival = default;
        return default;
    } // 0x0000000180D3C6A0-0x0000000180D3C7C0
      // [IDTag] // 0x0000000189B25A60-0x0000000189B25AA0
      // [XID] // 0x0000000189B25A60-0x0000000189B25AA0
    public static bool FromJson(JSONNode node, out short ival)
    {
        ival = default;
        return default;
    } // 0x0000000180D3C7C0-0x0000000180D3C8F0
      // [IDTag] // 0x0000000189B2FC30-0x0000000189B2FC70
      // [XID] // 0x0000000189B2FC30-0x0000000189B2FC70
    public static bool FromJson(JSONNode node, out ushort ival)
    {
        ival = default;
        return default;
    } // 0x0000000180D3C8F0-0x0000000180D3CA20
      // [IDTag] // 0x0000000189B3A570-0x0000000189B3A5B0
      // [XID] // 0x0000000189B3A570-0x0000000189B3A5B0
    public static bool FromJson(JSONNode node, out int ival)
    {
        ival = default;
        return default;
    } // 0x0000000180D3C3E0-0x0000000180D3C510
      // [IDTag] // 0x0000000189B45080-0x0000000189B450C0
      // [XID] // 0x0000000189B45080-0x0000000189B450C0
    public static bool FromJson(JSONNode node, out uint ival)
    {
        ival = default;
        return default;
    } // 0x0000000180D3CB40-0x0000000180D3CC70
      // [IDTag] // 0x0000000189B4F730-0x0000000189B4F770
      // [XID] // 0x0000000189B4F730-0x0000000189B4F770
    public static bool FromJson(JSONNode node, out bool bval)
    {
        bval = default;
        return default;
    } // 0x0000000180D3C190-0x0000000180D3C2B0
      // [IDTag] // 0x0000000189B59F50-0x0000000189B59F90
      // [XID] // 0x0000000189B59F50-0x0000000189B59F90
    public static bool FromJson(JSONNode node, out float fval)
    {
        fval = default;
        return default;
    } // 0x0000000180D3C060-0x0000000180D3C190
      // [IDTag] // 0x0000000189B64780-0x0000000189B647C0
      // [XID] // 0x0000000189B64780-0x0000000189B647C0
    public static bool FromJson(JSONNode node, out double dval)
    {
        dval = default;
        return default;
    } // 0x0000000180D3C2B0-0x0000000180D3C3E0
      // [IDTag] // 0x0000000189B6EBD0-0x0000000189B6EC10
      // [XID] // 0x0000000189B6EBD0-0x0000000189B6EC10
    public static bool FromJson(JSONNode node, out ulong dval)
    {
        dval = default;
        return default;
    } // 0x0000000180D3BF30-0x0000000180D3C060
      // [IDTag] // 0x0000000189B792C0-0x0000000189B79300
      // [XID] // 0x0000000189B792C0-0x0000000189B79300
    public static bool FromJson(JSONNode node, out string val)
    {
        val = default;
        return default;
    } // 0x0000000180D3C510-0x0000000180D3C6A0
      // [XID] // 0x0000000189B83BF0-0x0000000189B83C10
    private static void Override(JSONNode toNode, JSONNode fromNode) { } // 0x0000000180DCEEE0-0x0000000180DCF190
                                                                         // [XID] // 0x00000001899C5030-0x00000001899C5050
    private static bool OverrideDefault(JSONNode node) => default; // 0x0000000180D3CD00-0x0000000180D3CF70
                                                                   // [XID] // 0x0000000189B92380-0x0000000189B923A0
    public static int GetStringHash(string s) => default; // 0x0000000180D9E6B0-0x0000000180D9E7B0
                                                          // [XID] // 0x0000000189B999B0-0x0000000189B999D0
    public static bool NeedNewInstance(DynamicFloat self, DynamicFloat other) => default; // 0x0000000180DCEDC0-0x0000000180DCEEE0
    [BlackList] // 0x0000000189BA0F10-0x0000000189BA0F60
                // [IDTag] // 0x0000000189BA0F10-0x0000000189BA0F60
                // [XID] // 0x0000000189BA0F10-0x0000000189BA0F60
    public static bool ArrayFromJson(JSONNode node, out AudioStateOp[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCBC30-0x0000000180DCBFB0
      // [IDTag] // 0x0000000189BAE0F0-0x0000000189BAE130
      // [XID] // 0x0000000189BAE0F0-0x0000000189BAE130
    private static bool InternalArrayFromJson(JSONNode node, out AudioStateOp[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D85520-0x0000000180D857D0
    [BlackList] // 0x0000000189BB8640-0x0000000189BB8690
                // [IDTag] // 0x0000000189BB8640-0x0000000189BB8690
                // [XID] // 0x0000000189BB8640-0x0000000189BB8690
    public static bool ArrayFromJson(JSONNode node, out ConfigAbility[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB37B0-0x0000000180DB3B30
      // [IDTag] // 0x0000000189BC6370-0x0000000189BC63B0
      // [XID] // 0x0000000189BC6370-0x0000000189BC63B0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAbility[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D793C0-0x0000000180D79670
    [BlackList] // 0x0000000189BD0C90-0x0000000189BD0CE0
                // [IDTag] // 0x0000000189BD0C90-0x0000000189BD0CE0
                // [XID] // 0x0000000189BD0C90-0x0000000189BD0CE0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAbility> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE6620-0x0000000180CE69A0
      // [IDTag] // 0x0000000189BDE7D0-0x0000000189BDE810
      // [XID] // 0x0000000189BDE7D0-0x0000000189BDE810
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAbility> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2E550-0x0000000180D2EA60
    [BlackList] // 0x00000001895EE190-0x00000001895EE1E0
                // [IDTag] // 0x00000001895EE190-0x00000001895EE1E0
                // [XID] // 0x00000001895EE190-0x00000001895EE1E0
    public static bool ArrayFromJson(JSONNode node, out Dictionary<string, ConfigAbility>[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB14B0-0x0000000180DB1830
      // [IDTag] // 0x00000001895FB7A0-0x00000001895FB7E0
      // [XID] // 0x00000001895FB7A0-0x00000001895FB7E0
    private static bool InternalArrayFromJson(JSONNode node, out Dictionary<string, ConfigAbility>[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8D8F0-0x0000000180D8DBA0
    [BlackList] // 0x0000000189606080-0x00000001896060D0
                // [IDTag] // 0x0000000189606080-0x00000001896060D0
                // [XID] // 0x0000000189606080-0x00000001896060D0
    public static bool ArrayFromJson(JSONNode node, out ConfigAbilityTask[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA7730-0x0000000180DA7AB0
      // [IDTag] // 0x0000000189613720-0x0000000189613760
      // [XID] // 0x0000000189613720-0x0000000189613760
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAbilityTask[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D82520-0x0000000180D827B0
    [BlackList] // 0x000000018961DFD0-0x000000018961E020
                // [IDTag] // 0x000000018961DFD0-0x000000018961E020
                // [XID] // 0x000000018961DFD0-0x000000018961E020
    public static bool ArrayFromJson(JSONNode node, out ConfigAbilitySystem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA1C30-0x0000000180DA1FB0
      // [IDTag] // 0x000000018962B530-0x000000018962B570
      // [XID] // 0x000000018962B530-0x000000018962B570
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAbilitySystem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D95A00-0x0000000180D95CB0
    [BlackList] // 0x00000001896361D0-0x0000000189636220
                // [IDTag] // 0x00000001896361D0-0x0000000189636220
                // [XID] // 0x00000001896361D0-0x0000000189636220
    public static bool ArrayFromJson(JSONNode node, out ConfigAbilityAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB5730-0x0000000180DB5AB0
      // [IDTag] // 0x0000000189643780-0x00000001896437C0
      // [XID] // 0x0000000189643780-0x00000001896437C0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAbilityAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D97230-0x0000000180D974C0
    [BlackList] // 0x000000018964DDD0-0x000000018964DE20
                // [IDTag] // 0x000000018964DDD0-0x000000018964DE20
                // [XID] // 0x000000018964DDD0-0x000000018964DE20
    public static bool ArrayFromJson(JSONNode node, out ConfigAbilityAction[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB99B0-0x0000000180DB9D30
      // [IDTag] // 0x000000018965B650-0x000000018965B690
      // [XID] // 0x000000018965B650-0x000000018965B690
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAbilityAction[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9A770-0x0000000180D9AA20
    [BlackList] // 0x0000000189665BB0-0x0000000189665C00
                // [IDTag] // 0x0000000189665BB0-0x0000000189665C00
                // [XID] // 0x0000000189665BB0-0x0000000189665C00
    public static bool EnumStrToVal(string str, out ActionTokenType e)
    {
        e = default;
        return default;
    } // 0x0000000180D532A0-0x0000000180D53430
    [BlackList] // 0x00000001896736D0-0x0000000189673720
                // [IDTag] // 0x00000001896736D0-0x0000000189673720
                // [XID] // 0x00000001896736D0-0x0000000189673720
    public static bool EnumStrToVal(string str, out ActionTokenSourceType e)
    {
        e = default;
        return default;
    } // 0x0000000180D782C0-0x0000000180D78490
    [BlackList] // 0x0000000189681170-0x00000001896811C0
                // [IDTag] // 0x0000000189681170-0x00000001896811C0
                // [XID] // 0x0000000189681170-0x00000001896811C0
    public static bool EnumStrToVal(string str, out EntityTokenActionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D72F20-0x0000000180D73420
    [BlackList] // 0x000000018968EEA0-0x000000018968EEF0
                // [IDTag] // 0x000000018968EEA0-0x000000018968EEF0
                // [XID] // 0x000000018968EEA0-0x000000018968EEF0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigActionTokenChannel> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE31A0-0x0000000180CE3520
      // [IDTag] // 0x000000018969C510-0x000000018969C550
      // [XID] // 0x000000018969C510-0x000000018969C550
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigActionTokenChannel> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1BE30-0x0000000180D1C400
    [BlackList] // 0x00000001896A6670-0x00000001896A66C0
                // [IDTag] // 0x00000001896A6670-0x00000001896A66C0
                // [XID] // 0x00000001896A6670-0x00000001896A66C0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigActionTokenChannel> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBC9A0-0x0000000180CBCD20
      // [IDTag] // 0x00000001896B3A70-0x00000001896B3AB0
      // [XID] // 0x00000001896B3A70-0x00000001896B3AB0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigActionTokenChannel> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D32070-0x0000000180D326A0
    [BlackList] // 0x00000001896BDBE0-0x00000001896BDC30
                // [IDTag] // 0x00000001896BDBE0-0x00000001896BDC30
                // [XID] // 0x00000001896BDBE0-0x00000001896BDC30
    public static bool DictFromJson(JSONNode node, out Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDDDA0-0x0000000180CDE120
      // [IDTag] // 0x00000001896CB090-0x00000001896CB0D0
      // [XID] // 0x00000001896CB090-0x00000001896CB0D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEFCB0-0x0000000180CF02B0
    [BlackList] // 0x00000001896D5860-0x00000001896D58B0
                // [IDTag] // 0x00000001896D5860-0x00000001896D58B0
                // [XID] // 0x00000001896D5860-0x00000001896D58B0
    public static bool DictFromJson(JSONNode node, out Dictionary<ActionTokenSourceType, Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD3920-0x0000000180CD3CA0
      // [IDTag] // 0x00000001896E2E00-0x00000001896E2E40
      // [XID] // 0x00000001896E2E00-0x00000001896E2E40
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ActionTokenSourceType, Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D27EE0-0x0000000180D284E0
    [BlackList] // 0x00000001896ED120-0x00000001896ED170
                // [IDTag] // 0x00000001896ED120-0x00000001896ED170
                // [XID] // 0x00000001896ED120-0x00000001896ED170
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigActionTokenChannelGroupInfo> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC39A0-0x0000000180CC3D20
      // [IDTag] // 0x00000001896FA890-0x00000001896FA8D0
      // [XID] // 0x00000001896FA890-0x00000001896FA8D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigActionTokenChannelGroupInfo> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D196B0-0x0000000180D19BB0
    [BlackList] // 0x0000000189704EB0-0x0000000189704F00
                // [IDTag] // 0x0000000189704EB0-0x0000000189704F00
                // [XID] // 0x0000000189704EB0-0x0000000189704F00
    public static bool EnumStrToVal(string str, out ParamLogicType e)
    {
        e = default;
        return default;
    } // 0x0000000180D69C30-0x0000000180D69D70
    [BlackList] // 0x0000000189712690-0x00000001897126E0
                // [IDTag] // 0x0000000189712690-0x00000001897126E0
                // [XID] // 0x0000000189712690-0x00000001897126E0
    public static bool EnumStrToVal(string str, out LevelBuffSpecial e)
    {
        e = default;
        return default;
    } // 0x0000000180D61C70-0x0000000180D61E00
    [BlackList] // 0x000000018971FDF0-0x000000018971FE40
                // [IDTag] // 0x000000018971FDF0-0x000000018971FE40
                // [XID] // 0x000000018971FDF0-0x000000018971FE40
    public static bool EnumStrToVal(string str, out SortModifierType e)
    {
        e = default;
        return default;
    } // 0x0000000180D53430-0x0000000180D53640
    [BlackList] // 0x000000018972D1B0-0x000000018972D200
                // [IDTag] // 0x000000018972D1B0-0x000000018972D200
                // [XID] // 0x000000018972D1B0-0x000000018972D200
    public static bool EnumStrToVal(string str, out TurnMode e)
    {
        e = default;
        return default;
    } // 0x0000000180D670F0-0x0000000180D67300
    [BlackList] // 0x000000018973A8A0-0x000000018973A8F0
                // [IDTag] // 0x000000018973A8A0-0x000000018973A8F0
                // [XID] // 0x000000018973A8A0-0x000000018973A8F0
    public static bool ArrayFromJson(JSONNode node, out GlobalValuePair[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA2DB0-0x0000000180DA3130
      // [IDTag] // 0x0000000189748410-0x0000000189748450
      // [XID] // 0x0000000189748410-0x0000000189748450
    private static bool InternalArrayFromJson(JSONNode node, out GlobalValuePair[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9D790-0x0000000180D9DA40
    [BlackList] // 0x0000000189752800-0x0000000189752850
                // [IDTag] // 0x0000000189752800-0x0000000189752850
                // [XID] // 0x0000000189752800-0x0000000189752850
    public static bool EnumStrToVal(string str, out SystemValuerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D71580-0x0000000180D71790
    [BlackList] // 0x0000000189760020-0x0000000189760070
                // [IDTag] // 0x0000000189760020-0x0000000189760070
                // [XID] // 0x0000000189760020-0x0000000189760070
    public static bool EnumStrToVal(string str, out GetPosType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6BD70-0x0000000180D6BE70
    [BlackList] // 0x000000018976D670-0x000000018976D6C0
                // [IDTag] // 0x000000018976D670-0x000000018976D6C0
                // [XID] // 0x000000018976D670-0x000000018976D6C0
    public static bool EnumStrToVal(string str, out DamageAttacker e)
    {
        e = default;
        return default;
    } // 0x0000000180D3EBF0-0x0000000180D3ED30
    [BlackList] // 0x000000018977ABC0-0x000000018977AC10
                // [IDTag] // 0x000000018977ABC0-0x000000018977AC10
                // [XID] // 0x000000018977ABC0-0x000000018977AC10
    public static bool EnumStrToVal(string str, out RocketJumpType e)
    {
        e = default;
        return default;
    } // 0x0000000180D3E280-0x0000000180D3E450
    [BlackList] // 0x0000000189788430-0x0000000189788480
                // [IDTag] // 0x0000000189788430-0x0000000189788480
                // [XID] // 0x0000000189788430-0x0000000189788480
    public static bool EnumStrToVal(string str, out KillSelfType e)
    {
        e = default;
        return default;
    } // 0x0000000180D44BF0-0x0000000180D44D80
    [BlackList] // 0x00000001897959C0-0x0000000189795A10
                // [IDTag] // 0x00000001897959C0-0x0000000189795A10
                // [XID] // 0x00000001897959C0-0x0000000189795A10
    public static bool EnumStrToVal(string str, out BlinkHitSceneTestType e)
    {
        e = default;
        return default;
    } // 0x0000000180D44AB0-0x0000000180D44BF0
    [BlackList] // 0x00000001897A37F0-0x00000001897A3840
                // [IDTag] // 0x00000001897A37F0-0x00000001897A3840
                // [XID] // 0x00000001897A37F0-0x00000001897A3840
    public static bool EnumStrToVal(string str, out DropElemBallType e)
    {
        e = default;
        return default;
    } // 0x0000000180D50430-0x0000000180D505C0
    [BlackList] // 0x00000001897B0F40-0x00000001897B0F90
                // [IDTag] // 0x00000001897B0F40-0x00000001897B0F90
                // [XID] // 0x00000001897B0F40-0x00000001897B0F90
    public static bool EnumStrToVal(string str, out EffectType e)
    {
        e = default;
        return default;
    } // 0x0000000180D580A0-0x0000000180D581A0
    [BlackList] // 0x00000001897BF5D0-0x00000001897BF620
                // [IDTag] // 0x00000001897BF5D0-0x00000001897BF620
                // [XID] // 0x00000001897BF5D0-0x00000001897BF620
    public static bool EnumStrToVal(string str, out ExtraAbilityState e)
    {
        e = default;
        return default;
    } // 0x0000000180D729F0-0x0000000180D72B80
    [BlackList] // 0x00000001897CC9D0-0x00000001897CCA20
                // [IDTag] // 0x00000001897CC9D0-0x00000001897CCA20
                // [XID] // 0x00000001897CC9D0-0x00000001897CCA20
    public static bool EnumStrToVal(string str, out UseSkillType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5A7F0-0x0000000180D5AA00
    [BlackList] // 0x00000001897DA610-0x00000001897DA660
                // [IDTag] // 0x00000001897DA610-0x00000001897DA660
                // [XID] // 0x00000001897DA610-0x00000001897DA660
    public static bool EnumStrToVal(string str, out LuaCallType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5C570-0x0000000180D5C8B0
    [BlackList] // 0x00000001897E7930-0x00000001897E7980
                // [IDTag] // 0x00000001897E7930-0x00000001897E7980
                // [XID] // 0x00000001897E7930-0x00000001897E7980
    public static bool EnumStrToVal(string str, out ActionPanelEffectSlot e)
    {
        e = default;
        return default;
    } // 0x0000000180D69820-0x0000000180D69960
    [BlackList] // 0x00000001897F5580-0x00000001897F55D0
                // [IDTag] // 0x00000001897F5580-0x00000001897F55D0
                // [XID] // 0x00000001897F5580-0x00000001897F55D0
    public static bool EnumStrToVal(string str, out AbilityTargetting e)
    {
        e = default;
        return default;
    } // 0x0000000180D63FE0-0x0000000180D64540
    [BlackList] // 0x0000000189802E40-0x0000000189802E90
                // [IDTag] // 0x0000000189802E40-0x0000000189802E90
                // [XID] // 0x0000000189802E40-0x0000000189802E90
    public static bool EnumStrToVal(string str, out RelationalOperator e)
    {
        e = default;
        return default;
    } // 0x0000000180D4C000-0x0000000180D4C210
    [BlackList] // 0x0000000189810430-0x0000000189810480
                // [IDTag] // 0x0000000189810430-0x0000000189810480
                // [XID] // 0x0000000189810430-0x0000000189810480
    public static bool EnumStrToVal(string str, out MixinTargetting e)
    {
        e = default;
        return default;
    } // 0x0000000180D55220-0x0000000180D553F0
    [BlackList] // 0x000000018981DBD0-0x000000018981DC20
                // [IDTag] // 0x000000018981DBD0-0x000000018981DC20
                // [XID] // 0x000000018981DBD0-0x000000018981DC20
    public static bool EnumStrToVal(string str, out PropertyType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4CBF0-0x0000000180D4CD30
    [BlackList] // 0x000000018982B180-0x000000018982B1D0
                // [IDTag] // 0x000000018982B180-0x000000018982B1D0
                // [XID] // 0x000000018982B180-0x000000018982B1D0
    public static bool EnumStrToVal(string str, out StackMethod e)
    {
        e = default;
        return default;
    } // 0x0000000180D59F80-0x0000000180D5A150
    [BlackList] // 0x00000001898386B0-0x0000000189838700
                // [IDTag] // 0x00000001898386B0-0x0000000189838700
                // [XID] // 0x00000001898386B0-0x0000000189838700
    public static bool ArrayFromJson(JSONNode node, out AbilityState[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB30B0-0x0000000180DB3430
      // [IDTag] // 0x0000000189845BD0-0x0000000189845C10
      // [XID] // 0x0000000189845BD0-0x0000000189845C10
    private static bool InternalArrayFromJson(JSONNode node, out AbilityState[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D80750-0x0000000180D80A10
    [BlackList] // 0x000000018984FF10-0x000000018984FF60
                // [IDTag] // 0x000000018984FF10-0x000000018984FF60
                // [XID] // 0x000000018984FF10-0x000000018984FF60
    public static bool DictFromJson(JSONNode node, out Dictionary<string, DynamicArgument> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC3620-0x0000000180CC39A0
      // [IDTag] // 0x000000018985CEB0-0x000000018985CEF0
      // [XID] // 0x000000018985CEB0-0x000000018985CEF0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, DynamicArgument> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CECDE0-0x0000000180CED2E0
    [BlackList] // 0x0000000189867660-0x00000001898676B0
                // [IDTag] // 0x0000000189867660-0x00000001898676B0
                // [XID] // 0x0000000189867660-0x00000001898676B0
    public static bool EnumStrToVal(string str, out SelectTargetsSortType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4C8A0-0x0000000180D4CAB0
    [BlackList] // 0x00000001898747F0-0x0000000189874840
                // [IDTag] // 0x00000001898747F0-0x0000000189874840
                // [XID] // 0x00000001898747F0-0x0000000189874840
    public static bool EnumStrToVal(string str, out BitwiseOperator e)
    {
        e = default;
        return default;
    } // 0x0000000180D448E0-0x0000000180D44AB0
    [BlackList] // 0x0000000189881E10-0x0000000189881E60
                // [IDTag] // 0x0000000189881E10-0x0000000189881E60
                // [XID] // 0x0000000189881E10-0x0000000189881E60
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAbilityPropertyEntry> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC5920-0x0000000180CC5CA0
      // [IDTag] // 0x000000018988F230-0x000000018988F270
      // [XID] // 0x000000018988F230-0x000000018988F270
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAbilityPropertyEntry> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D096A0-0x0000000180D09BA0
    [BlackList] // 0x0000000189899A10-0x0000000189899A60
                // [IDTag] // 0x0000000189899A10-0x0000000189899A60
                // [XID] // 0x0000000189899A10-0x0000000189899A60
    public static bool EnumStrToVal(string str, out AbilityCameraShotType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5E650-0x0000000180D5E790
    [BlackList] // 0x00000001898A6E10-0x00000001898A6E60
                // [IDTag] // 0x00000001898A6E10-0x00000001898A6E60
                // [XID] // 0x00000001898A6E10-0x00000001898A6E60
    public static bool EnumStrToVal(string str, out SwitchSkillPriority e)
    {
        e = default;
        return default;
    } // 0x0000000180D72B80-0x0000000180D72D90
    [BlackList] // 0x00000001898B4120-0x00000001898B4170
                // [IDTag] // 0x00000001898B4120-0x00000001898B4170
                // [XID] // 0x00000001898B4120-0x00000001898B4170
    public static bool EnumStrToVal(string str, out AbilityGroupSourceType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5CEC0-0x0000000180D5D230
    [BlackList] // 0x00000001898C1A90-0x00000001898C1AE0
                // [IDTag] // 0x00000001898C1A90-0x00000001898C1AE0
                // [XID] // 0x00000001898C1A90-0x00000001898C1AE0
    public static bool EnumStrToVal(string str, out AbilityGroupTargetType e)
    {
        e = default;
        return default;
    } // 0x0000000180D50C50-0x0000000180D50D90
    [BlackList] // 0x00000001898CF450-0x00000001898CF4A0
                // [IDTag] // 0x00000001898CF450-0x00000001898CF4A0
                // [XID] // 0x00000001898CF450-0x00000001898CF4A0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAbilityGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBE220-0x0000000180CBE5A0
      // [IDTag] // 0x00000001898DCD50-0x00000001898DCD90
      // [XID] // 0x00000001898DCD50-0x00000001898DCD90
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAbilityGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0D9C0-0x0000000180D0DEC0
    [BlackList] // 0x00000001898E7C70-0x00000001898E7CC0
                // [IDTag] // 0x00000001898E7C70-0x00000001898E7CC0
                // [XID] // 0x00000001898E7C70-0x00000001898E7CC0
    public static bool ArrayFromJson(JSONNode node, out ConfigEntityAbilityEntry[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB06B0-0x0000000180DB0A30
      // [IDTag] // 0x00000001898F53B0-0x00000001898F53F0
      // [XID] // 0x00000001898F53B0-0x00000001898F53F0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigEntityAbilityEntry[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D997A0-0x0000000180D99A50
    [BlackList] // 0x00000001898FFC40-0x00000001898FFC90
                // [IDTag] // 0x00000001898FFC40-0x00000001898FFC90
                // [XID] // 0x00000001898FFC40-0x00000001898FFC90
    public static bool EnumStrToVal(string str, out AvatarStageType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5F9A0-0x0000000180D5FB30
    [BlackList] // 0x000000018990D4C0-0x000000018990D510
                // [IDTag] // 0x000000018990D4C0-0x000000018990D510
                // [XID] // 0x000000018990D4C0-0x000000018990D510
    public static bool ArrayFromJson(JSONNode node, out ConfigAbilityStateToActions[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA3F30-0x0000000180DA42B0
      // [IDTag] // 0x000000018991AE00-0x000000018991AE40
      // [XID] // 0x000000018991AE00-0x000000018991AE40
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAbilityStateToActions[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D81220-0x0000000180D814D0
    [BlackList] // 0x00000001899255B0-0x0000000189925600
                // [IDTag] // 0x00000001899255B0-0x0000000189925600
                // [XID] // 0x00000001899255B0-0x0000000189925600
    public static bool ArrayFromJson(JSONNode node, out ConfigAbilityMixin[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB8BB0-0x0000000180DB8F30
      // [IDTag] // 0x0000000189932C80-0x0000000189932CC0
      // [XID] // 0x0000000189932C80-0x0000000189932CC0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAbilityMixin[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9A230-0x0000000180D9A4C0
    [BlackList] // 0x000000018993D500-0x000000018993D550
                // [IDTag] // 0x000000018993D500-0x000000018993D550
                // [XID] // 0x000000018993D500-0x000000018993D550
    public static bool EnumStrToVal(string str, out OnEventType e)
    {
        e = default;
        return default;
    } // 0x0000000180D42400-0x0000000180D42740
    [BlackList] // 0x000000018994A790-0x000000018994A7E0
                // [IDTag] // 0x000000018994A790-0x000000018994A7E0
                // [XID] // 0x000000018994A790-0x000000018994A7E0
    public static bool EnumStrToVal(string str, out ChargeStateType e)
    {
        e = default;
        return default;
    } // 0x0000000180D3DEE0-0x0000000180D3E070
    [BlackList] // 0x00000001899580B0-0x0000000189958100
                // [IDTag] // 0x00000001899580B0-0x0000000189958100
                // [XID] // 0x00000001899580B0-0x0000000189958100
    public static bool EnumStrToVal(string str, out AddActionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5A460-0x0000000180D5A5A0
    [BlackList] // 0x0000000189965830-0x0000000189965880
                // [IDTag] // 0x0000000189965830-0x0000000189965880
                // [XID] // 0x0000000189965830-0x0000000189965880
    public static bool ArrayFromJson(JSONNode node, out ConfigTornadoZone[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBF130-0x0000000180DBF4B0
      // [IDTag] // 0x0000000189973070-0x00000001899730B0
      // [XID] // 0x0000000189973070-0x00000001899730B0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigTornadoZone[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9B4D0-0x0000000180D9B780
    [BlackList] // 0x000000018997D0D0-0x000000018997D120
                // [IDTag] // 0x000000018997D0D0-0x000000018997D120
                // [XID] // 0x000000018997D0D0-0x000000018997D120
    public static bool EnumStrToVal(string str, out ChangeFieldType e)
    {
        e = default;
        return default;
    } // 0x0000000180D505C0-0x0000000180D50700
    [BlackList] // 0x000000018998B1E0-0x000000018998B230
                // [IDTag] // 0x000000018998B1E0-0x000000018998B230
                // [XID] // 0x000000018998B1E0-0x000000018998B230
    public static bool EnumStrToVal(string str, out TriggerWeatherType e)
    {
        e = default;
        return default;
    } // 0x0000000180D75810-0x0000000180D759A0
    [BlackList] // 0x0000000189998EB0-0x0000000189998F00
                // [IDTag] // 0x0000000189998EB0-0x0000000189998F00
                // [XID] // 0x0000000189998EB0-0x0000000189998F00
    public static bool EnumStrToVal(string str, out RejectEventType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5B5D0-0x0000000180D5B760
    [BlackList] // 0x00000001899A6810-0x00000001899A6860
                // [IDTag] // 0x00000001899A6810-0x00000001899A6860
                // [XID] // 0x00000001899A6810-0x00000001899A6860
    public static bool EnumStrToVal(string str, out AttackCostType e)
    {
        e = default;
        return default;
    } // 0x0000000180D40B30-0x0000000180D40CC0
    [BlackList] // 0x00000001899B4280-0x00000001899B42D0
                // [IDTag] // 0x00000001899B4280-0x00000001899B42D0
                // [XID] // 0x00000001899B4280-0x00000001899B42D0
    public static bool EnumStrToVal(string str, out CreateGadgetMixinType e)
    {
        e = default;
        return default;
    } // 0x0000000180D58920-0x0000000180D58AB0
    [BlackList] // 0x00000001899C1920-0x00000001899C1970
                // [IDTag] // 0x00000001899C1920-0x00000001899C1970
                // [XID] // 0x00000001899C1920-0x00000001899C1970
    public static bool ArrayFromJson(JSONNode node, out DvalinS01PathEffsInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAC7B0-0x0000000180DACB30
      // [IDTag] // 0x00000001899CF0A0-0x00000001899CF0E0
      // [XID] // 0x00000001899CF0A0-0x00000001899CF0E0
    private static bool InternalArrayFromJson(JSONNode node, out DvalinS01PathEffsInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7B3F0-0x0000000180D7B6A0
    [BlackList] // 0x00000001899D94E0-0x00000001899D9530
                // [IDTag] // 0x00000001899D94E0-0x00000001899D9530
                // [XID] // 0x00000001899D94E0-0x00000001899D9530
    public static bool DictFromJson(JSONNode node, out Dictionary<ElementType, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCF6A0-0x0000000180CCFA20
      // [IDTag] // 0x00000001899E6ED0-0x00000001899E6F10
      // [XID] // 0x00000001899E6ED0-0x00000001899E6F10
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ElementType, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0F470-0x0000000180D0FA70
    [BlackList] // 0x00000001899F12E0-0x00000001899F1330
                // [IDTag] // 0x00000001899F12E0-0x00000001899F1330
                // [XID] // 0x00000001899F12E0-0x00000001899F1330
    public static bool EnumStrToVal(string str, out WatcherSystemMixinType e)
    {
        e = default;
        return default;
    } // 0x0000000180D649E0-0x0000000180D64EC0
    [BlackList] // 0x00000001899FEC30-0x00000001899FEC80
                // [IDTag] // 0x00000001899FEC30-0x00000001899FEC80
                // [XID] // 0x00000001899FEC30-0x00000001899FEC80
    public static bool EnumStrToVal(string str, out WatcherSystemListenType e)
    {
        e = default;
        return default;
    } // 0x0000000180D71790-0x0000000180D71920
    [BlackList] // 0x0000000189A0BFD0-0x0000000189A0C020
                // [IDTag] // 0x0000000189A0BFD0-0x0000000189A0C020
                // [XID] // 0x0000000189A0BFD0-0x0000000189A0C020
    public static bool ArrayFromJson(JSONNode node, out ElementBatchPredicated[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA49B0-0x0000000180DA4D30
      // [IDTag] // 0x0000000189A19390-0x0000000189A193D0
      // [XID] // 0x0000000189A19390-0x0000000189A193D0
    private static bool InternalArrayFromJson(JSONNode node, out ElementBatchPredicated[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7B140-0x0000000180D7B3F0
    [BlackList] // 0x0000000189A23A20-0x0000000189A23A70
                // [IDTag] // 0x0000000189A23A20-0x0000000189A23A70
                // [XID] // 0x0000000189A23A20-0x0000000189A23A70
    public static bool EnumStrToVal(string str, out ClimateSourceType e)
    {
        e = default;
        return default;
    } // 0x0000000180D64680-0x0000000180D64850
    [BlackList] // 0x0000000189A30C50-0x0000000189A30CA0
                // [IDTag] // 0x0000000189A30C50-0x0000000189A30CA0
                // [XID] // 0x0000000189A30C50-0x0000000189A30CA0
    public static bool EnumStrToVal(string str, out ClimateTrendType e)
    {
        e = default;
        return default;
    } // 0x0000000180D59630-0x0000000180D59800
    [BlackList] // 0x0000000189A3E610-0x0000000189A3E660
                // [IDTag] // 0x0000000189A3E610-0x0000000189A3E660
                // [XID] // 0x0000000189A3E610-0x0000000189A3E660
    public static bool EnumStrToVal(string str, out MoveStateMixinType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6A570-0x0000000180D6A670
    [BlackList] // 0x0000000189A4BD60-0x0000000189A4BDB0
                // [IDTag] // 0x0000000189A4BD60-0x0000000189A4BDB0
                // [XID] // 0x0000000189A4BD60-0x0000000189A4BDB0
    public static bool EnumStrToVal(string str, out EntityMarkType e)
    {
        e = default;
        return default;
    } // 0x0000000180D54640-0x0000000180D54780
    [BlackList] // 0x0000000189A59530-0x0000000189A59580
                // [IDTag] // 0x0000000189A59530-0x0000000189A59580
                // [XID] // 0x0000000189A59530-0x0000000189A59580
    public static bool EnumStrToVal(string str, out AbilityEntityVisibleReason e)
    {
        e = default;
        return default;
    } // 0x0000000180D66790-0x0000000180D668D0
    [BlackList] // 0x0000000189A66FC0-0x0000000189A67010
                // [IDTag] // 0x0000000189A66FC0-0x0000000189A67010
                // [XID] // 0x0000000189A66FC0-0x0000000189A67010
    public static bool EnumStrToVal(string str, out ModifierTimeScale e)
    {
        e = default;
        return default;
    } // 0x0000000180D71E20-0x0000000180D71FB0
    [BlackList] // 0x0000000189A74570-0x0000000189A745C0
                // [IDTag] // 0x0000000189A74570-0x0000000189A745C0
                // [XID] // 0x0000000189A74570-0x0000000189A745C0
    public static bool EnumStrToVal(string str, out ModifierStacking e)
    {
        e = default;
        return default;
    } // 0x0000000180D51D10-0x0000000180D520E0
    [BlackList] // 0x0000000189A81FD0-0x0000000189A82020
                // [IDTag] // 0x0000000189A81FD0-0x0000000189A82020
                // [XID] // 0x0000000189A81FD0-0x0000000189A82020
    public static bool EnumStrToVal(string str, out UniqueModifierCond e)
    {
        e = default;
        return default;
    } // 0x0000000180D66340-0x0000000180D66480
    [BlackList] // 0x0000000189A8FB50-0x0000000189A8FBA0
                // [IDTag] // 0x0000000189A8FB50-0x0000000189A8FBA0
                // [XID] // 0x0000000189A8FB50-0x0000000189A8FBA0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAbilityModifier> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDB720-0x0000000180CDBAA0
      // [IDTag] // 0x0000000189A9D0C0-0x0000000189A9D100
      // [XID] // 0x0000000189A9D0C0-0x0000000189A9D100
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAbilityModifier> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D02650-0x0000000180D02B80
    [BlackList] // 0x0000000189AA7640-0x0000000189AA7690
                // [IDTag] // 0x0000000189AA7640-0x0000000189AA7690
                // [XID] // 0x0000000189AA7640-0x0000000189AA7690
    public static bool ArrayFromJson(JSONNode node, out ConfigAbilityPredicate[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA5B30-0x0000000180DA5EB0
      // [IDTag] // 0x0000000189AB4E80-0x0000000189AB4EC0
      // [XID] // 0x0000000189AB4E80-0x0000000189AB4EC0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAbilityPredicate[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7A3F0-0x0000000180D7A680
    [BlackList] // 0x0000000189ABF870-0x0000000189ABF8C0
                // [IDTag] // 0x0000000189ABF870-0x0000000189ABF8C0
                // [XID] // 0x0000000189ABF870-0x0000000189ABF8C0
    public static bool EnumStrToVal(string str, out RelationType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5E790-0x0000000180D5E9E0
    [BlackList] // 0x0000000189ACD2F0-0x0000000189ACD340
                // [IDTag] // 0x0000000189ACD2F0-0x0000000189ACD340
                // [XID] // 0x0000000189ACD2F0-0x0000000189ACD340
    public static bool EnumStrToVal(string str, out SceneObjState e)
    {
        e = default;
        return default;
    } // 0x0000000180D627A0-0x0000000180D629F0
    [BlackList] // 0x0000000189ADAF40-0x0000000189ADAF90
                // [IDTag] // 0x0000000189ADAF40-0x0000000189ADAF90
                // [XID] // 0x0000000189ADAF40-0x0000000189ADAF90
    public static bool EnumStrToVal(string str, out SceneSurfaceType e)
    {
        e = default;
        return default;
    } // 0x0000000180D41040-0x0000000180D41540
    [BlackList] // 0x0000000189AE8760-0x0000000189AE87B0
                // [IDTag] // 0x0000000189AE8760-0x0000000189AE87B0
                // [XID] // 0x0000000189AE8760-0x0000000189AE87B0
    public static bool ArrayFromJson(JSONNode node, out SceneSurfaceType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC6F30-0x0000000180DC72B0
      // [IDTag] // 0x0000000189AF6310-0x0000000189AF6350
      // [XID] // 0x0000000189AF6310-0x0000000189AF6350
    private static bool InternalArrayFromJson(JSONNode node, out SceneSurfaceType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D84270-0x0000000180D84530
    [BlackList] // 0x0000000189B008E0-0x0000000189B00930
                // [IDTag] // 0x0000000189B008E0-0x0000000189B00930
                // [XID] // 0x0000000189B008E0-0x0000000189B00930
    public static bool EnumStrToVal(string str, out TargetPosToSelfPosType e)
    {
        e = default;
        return default;
    } // 0x0000000180D68970-0x0000000180D68B00
    [BlackList] // 0x0000000189B0E090-0x0000000189B0E0E0
                // [IDTag] // 0x0000000189B0E090-0x0000000189B0E0E0
                // [XID] // 0x0000000189B0E090-0x0000000189B0E0E0
    public static bool EnumStrToVal(string str, out CompareProperty e)
    {
        e = default;
        return default;
    } // 0x0000000180D73630-0x0000000180D73730
    [BlackList] // 0x0000000189B1B480-0x0000000189B1B4D0
                // [IDTag] // 0x0000000189B1B480-0x0000000189B1B4D0
                // [XID] // 0x0000000189B1B480-0x0000000189B1B4D0
    public static bool EnumStrToVal(string str, out HasShieldType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6BE70-0x0000000180D6C040
    [BlackList] // 0x0000000189B28900-0x0000000189B28950
                // [IDTag] // 0x0000000189B28900-0x0000000189B28950
                // [XID] // 0x0000000189B28900-0x0000000189B28950
    public static bool ArrayFromJson(JSONNode node, out SceneType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAC430-0x0000000180DAC7B0
      // [IDTag] // 0x0000000189B35A70-0x0000000189B35AB0
      // [XID] // 0x0000000189B35A70-0x0000000189B35AB0
    private static bool InternalArrayFromJson(JSONNode node, out SceneType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9C750-0x0000000180D9CA10
    [BlackList] // 0x0000000189B40610-0x0000000189B40660
                // [IDTag] // 0x0000000189B40610-0x0000000189B40660
                // [XID] // 0x0000000189B40610-0x0000000189B40660
    public static bool ArrayFromJson(JSONNode node, out ConfigMassiveEntityElement[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA7E30-0x0000000180DA81B0
      // [IDTag] // 0x0000000189B4DEE0-0x0000000189B4DF20
      // [XID] // 0x0000000189B4DEE0-0x0000000189B4DF20
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMassiveEntityElement[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D857D0-0x0000000180D85A80
    [BlackList] // 0x0000000189B588C0-0x0000000189B58910
                // [IDTag] // 0x0000000189B588C0-0x0000000189B58910
                // [XID] // 0x0000000189B588C0-0x0000000189B58910
    public static bool EnumStrToVal(string str, out MassiveElementTriggerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D3E850-0x0000000180D3EBF0
    [BlackList] // 0x0000000189B65FC0-0x0000000189B66010
                // [IDTag] // 0x0000000189B65FC0-0x0000000189B66010
                // [XID] // 0x0000000189B65FC0-0x0000000189B66010
    public static bool ArrayFromJson(JSONNode node, out ConfigMassiveElementTriggerAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC9930-0x0000000180DC9CB0
      // [IDTag] // 0x0000000189B73480-0x0000000189B734C0
      // [XID] // 0x0000000189B73480-0x0000000189B734C0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMassiveElementTriggerAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D88800-0x0000000180D88AB0
    [BlackList] // 0x0000000189B7D8A0-0x0000000189B7D8F0
                // [IDTag] // 0x0000000189B7D8A0-0x0000000189B7D8F0
                // [XID] // 0x0000000189B7D8A0-0x0000000189B7D8F0
    public static bool ArrayFromJson(JSONNode node, out AIPoint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB4CB0-0x0000000180DB5030
      // [IDTag] // 0x0000000189B8ACF0-0x0000000189B8AD30
      // [XID] // 0x0000000189B8ACF0-0x0000000189B8AD30
    private static bool InternalArrayFromJson(JSONNode node, out AIPoint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8D640-0x0000000180D8D8F0
    [BlackList] // 0x0000000189B95270-0x0000000189B952C0
                // [IDTag] // 0x0000000189B95270-0x0000000189B952C0
                // [XID] // 0x0000000189B95270-0x0000000189B952C0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAISensingSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCA620-0x0000000180CCA9A0
      // [IDTag] // 0x0000000189BA2A10-0x0000000189BA2A50
      // [XID] // 0x0000000189BA2A10-0x0000000189BA2A50
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAISensingSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF3860-0x0000000180CF3D60
    [BlackList] // 0x0000000189BACB70-0x0000000189BACBC0
                // [IDTag] // 0x0000000189BACB70-0x0000000189BACBC0
                // [XID] // 0x0000000189BACB70-0x0000000189BACBC0
    public static bool EnumStrToVal(string str, out NeuronName e)
    {
        e = default;
        return default;
    } // 0x0000000180D58EB0-0x0000000180D59360
    [BlackList] // 0x0000000189BB9F00-0x0000000189BB9F50
                // [IDTag] // 0x0000000189BB9F00-0x0000000189BB9F50
                // [XID] // 0x0000000189BB9F00-0x0000000189BB9F50
    public static bool ArrayFromJson(JSONNode node, out NeuronName[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBD8B0-0x0000000180DBDC30
      // [IDTag] // 0x0000000189BC7B40-0x0000000189BC7B80
      // [XID] // 0x0000000189BC7B40-0x0000000189BC7B80
    private static bool InternalArrayFromJson(JSONNode node, out NeuronName[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D89D90-0x0000000180D8A050
    [BlackList] // 0x0000000189BD2680-0x0000000189BD26D0
                // [IDTag] // 0x0000000189BD2680-0x0000000189BD26D0
                // [XID] // 0x0000000189BD2680-0x0000000189BD26D0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, NeuronName[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCB420-0x0000000180CCB7A0
      // [IDTag] // 0x0000000189BDFD40-0x0000000189BDFD80
      // [XID] // 0x0000000189BDFD40-0x0000000189BDFD80
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, NeuronName[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D36510-0x0000000180D36A10
    [BlackList] // 0x00000001895EF990-0x00000001895EF9E0
                // [IDTag] // 0x00000001895EF990-0x00000001895EF9E0
                // [XID] // 0x00000001895EF990-0x00000001895EF9E0
    public static bool DictFromJson(JSONNode node, out Dictionary<ConfigWeatherType, NeuronName[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC8A20-0x0000000180CC8DA0
      // [IDTag] // 0x00000001895FCE60-0x00000001895FCEA0
      // [XID] // 0x00000001895FCE60-0x00000001895FCEA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ConfigWeatherType, NeuronName[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEEB10-0x0000000180CEF110
    [BlackList] // 0x00000001896075E0-0x0000000189607630
                // [IDTag] // 0x00000001896075E0-0x0000000189607630
                // [XID] // 0x00000001896075E0-0x0000000189607630
    public static bool ArrayFromJson(JSONNode node, out ConfigAIPoseControlItem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAEAB0-0x0000000180DAEE30
      // [IDTag] // 0x0000000189615060-0x00000001896150A0
      // [XID] // 0x0000000189615060-0x00000001896150A0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAIPoseControlItem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D872B0-0x0000000180D87560
    [BlackList] // 0x000000018961F880-0x000000018961F8D0
                // [IDTag] // 0x000000018961F880-0x000000018961F8D0
                // [XID] // 0x000000018961F880-0x000000018961F8D0
    public static bool EnumStrToVal(string str, out MoveCategoryAI e)
    {
        e = default;
        return default;
    } // 0x0000000180D6B390-0x0000000180D6B520
    [BlackList] // 0x000000018962CBB0-0x000000018962CC00
                // [IDTag] // 0x000000018962CBB0-0x000000018962CC00
                // [XID] // 0x000000018962CBB0-0x000000018962CC00
    public static bool EnumStrToVal(string str, out AIBasicMoveType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5D230-0x0000000180D5D370
    [BlackList] // 0x000000018963A6D0-0x000000018963A720
                // [IDTag] // 0x000000018963A6D0-0x000000018963A720
                // [XID] // 0x000000018963A6D0-0x000000018963A720
    public static bool EnumStrToVal(string str, out DecisionArchetype e)
    {
        e = default;
        return default;
    } // 0x0000000180D6C180-0x0000000180D6C3D0
    [BlackList] // 0x0000000189647CC0-0x0000000189647D10
                // [IDTag] // 0x0000000189647CC0-0x0000000189647D10
                // [XID] // 0x0000000189647CC0-0x0000000189647D10
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIReturnToBornPosData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB8020-0x0000000180CB83A0
      // [IDTag] // 0x0000000189655630-0x0000000189655670
      // [XID] // 0x0000000189655630-0x0000000189655670
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIReturnToBornPosData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2EA60-0x0000000180D2F030
    [BlackList] // 0x000000018965FB40-0x000000018965FB90
                // [IDTag] // 0x000000018965FB40-0x000000018965FB90
                // [XID] // 0x000000018965FB40-0x000000018965FB90
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIReturnToBornPosData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD2B20-0x0000000180CD2EA0
      // [IDTag] // 0x000000018966D270-0x000000018966D2B0
      // [XID] // 0x000000018966D270-0x000000018966D2B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIReturnToBornPosData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF55C0-0x0000000180CF5BF0
    [BlackList] // 0x00000001896780F0-0x0000000189678140
                // [IDTag] // 0x00000001896780F0-0x0000000189678140
                // [XID] // 0x00000001896780F0-0x0000000189678140
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIWanderData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE0420-0x0000000180CE07A0
      // [IDTag] // 0x00000001896857A0-0x00000001896857E0
      // [XID] // 0x00000001896857A0-0x00000001896857E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIWanderData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFEE50-0x0000000180CFF420
    [BlackList] // 0x0000000189690700-0x0000000189690750
                // [IDTag] // 0x0000000189690700-0x0000000189690750
                // [XID] // 0x0000000189690700-0x0000000189690750
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIWanderData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC7C20-0x0000000180CC7FA0
      // [IDTag] // 0x000000018969DEB0-0x000000018969DEF0
      // [XID] // 0x000000018969DEB0-0x000000018969DEF0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIWanderData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D33DD0-0x0000000180D34400
    [BlackList] // 0x00000001896A7FA0-0x00000001896A7FF0
                // [IDTag] // 0x00000001896A7FA0-0x00000001896A7FF0
                // [XID] // 0x00000001896A7FA0-0x00000001896A7FF0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIFollowScriptedPathData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD7120-0x0000000180CD74A0
      // [IDTag] // 0x00000001896B5390-0x00000001896B53D0
      // [XID] // 0x00000001896B5390-0x00000001896B53D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIFollowScriptedPathData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2A170-0x0000000180D2A740
    [BlackList] // 0x00000001896BF350-0x00000001896BF3A0
                // [IDTag] // 0x00000001896BF350-0x00000001896BF3A0
                // [XID] // 0x00000001896BF350-0x00000001896BF3A0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFollowScriptedPathData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE0EA0-0x0000000180CE1220
      // [IDTag] // 0x00000001896CCA50-0x00000001896CCA90
      // [XID] // 0x00000001896CCA50-0x00000001896CCA90
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFollowScriptedPathData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D37EB0-0x0000000180D384E0
    [BlackList] // 0x00000001896D6F80-0x00000001896D6FD0
                // [IDTag] // 0x00000001896D6F80-0x00000001896D6FD0
                // [XID] // 0x00000001896D6F80-0x00000001896D6FD0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIFollowServerRouteData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC55A0-0x0000000180CC5920
      // [IDTag] // 0x00000001896E46E0-0x00000001896E4720
      // [XID] // 0x00000001896E46E0-0x00000001896E4720
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIFollowServerRouteData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D37410-0x0000000180D379E0
    [BlackList] // 0x00000001896EE910-0x00000001896EE960
                // [IDTag] // 0x00000001896EE910-0x00000001896EE960
                // [XID] // 0x00000001896EE910-0x00000001896EE960
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFollowServerRouteData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC6020-0x0000000180CC63A0
      // [IDTag] // 0x00000001896FC1F0-0x00000001896FC230
      // [XID] // 0x00000001896FC1F0-0x00000001896FC230
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFollowServerRouteData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D02020-0x0000000180D02650
    [BlackList] // 0x00000001897065F0-0x0000000189706640
                // [IDTag] // 0x00000001897065F0-0x0000000189706640
                // [XID] // 0x00000001897065F0-0x0000000189706640
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIInvestigateData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE46A0-0x0000000180CE4A20
      // [IDTag] // 0x0000000189713F30-0x0000000189713F70
      // [XID] // 0x0000000189713F30-0x0000000189713F70
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIInvestigateData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFAE30-0x0000000180CFB400
    [BlackList] // 0x000000018971E560-0x000000018971E5B0
                // [IDTag] // 0x000000018971E560-0x000000018971E5B0
                // [XID] // 0x000000018971E560-0x000000018971E5B0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIInvestigateData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE4320-0x0000000180CE46A0
      // [IDTag] // 0x000000018972B930-0x000000018972B970
      // [XID] // 0x000000018972B930-0x000000018972B970
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIInvestigateData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEDEE0-0x0000000180CEE510
    [BlackList] // 0x0000000189736160-0x00000001897361B0
                // [IDTag] // 0x0000000189736160-0x00000001897361B0
                // [XID] // 0x0000000189736160-0x00000001897361B0
    public static bool ArrayFromJson(JSONNode node, out ConfigAIPickActionPointCriteria[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA0730-0x0000000180DA0AB0
      // [IDTag] // 0x0000000189743A30-0x0000000189743A70
      // [XID] // 0x0000000189743A30-0x0000000189743A70
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAIPickActionPointCriteria[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D906B0-0x0000000180D90960
    [BlackList] // 0x000000018974E4B0-0x000000018974E500
                // [IDTag] // 0x000000018974E4B0-0x000000018974E500
                // [XID] // 0x000000018974E4B0-0x000000018974E500
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIReactActionPointData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC1A20-0x0000000180CC1DA0
      // [IDTag] // 0x000000018975B560-0x000000018975B5A0
      // [XID] // 0x000000018975B560-0x000000018975B5A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIReactActionPointData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D134C0-0x0000000180D13A90
    [BlackList] // 0x0000000189765DD0-0x0000000189765E20
                // [IDTag] // 0x0000000189765DD0-0x0000000189765E20
                // [XID] // 0x0000000189765DD0-0x0000000189765E20
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIReactActionPointData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD6A20-0x0000000180CD6DA0
      // [IDTag] // 0x0000000189773420-0x0000000189773460
      // [XID] // 0x0000000189773420-0x0000000189773460
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIReactActionPointData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE9DF0-0x0000000180CEA420
    [BlackList] // 0x000000018977DC60-0x000000018977DCB0
                // [IDTag] // 0x000000018977DC60-0x000000018977DCB0
                // [XID] // 0x000000018977DC60-0x000000018977DCB0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIPatrolFollowData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCD720-0x0000000180CCDAA0
      // [IDTag] // 0x000000018978B5A0-0x000000018978B5E0
      // [XID] // 0x000000018978B5A0-0x000000018978B5E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIPatrolFollowData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D25400-0x0000000180D259D0
    [BlackList] // 0x0000000189795970-0x00000001897959C0
                // [IDTag] // 0x0000000189795970-0x00000001897959C0
                // [XID] // 0x0000000189795970-0x00000001897959C0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIPatrolFollowData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCE1A0-0x0000000180CCE520
      // [IDTag] // 0x00000001897A37B0-0x00000001897A37F0
      // [XID] // 0x00000001897A37B0-0x00000001897A37F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIPatrolFollowData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D28FE0-0x0000000180D29610
    [BlackList] // 0x00000001897ADEF0-0x00000001897ADF40
                // [IDTag] // 0x00000001897ADEF0-0x00000001897ADF40
                // [XID] // 0x00000001897ADEF0-0x00000001897ADF40
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAICombatFollowMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCE8A0-0x0000000180CCEC20
      // [IDTag] // 0x00000001897BC460-0x00000001897BC4A0
      // [XID] // 0x00000001897BC460-0x00000001897BC4A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAICombatFollowMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF6730-0x0000000180CF6D00
    [BlackList] // 0x00000001897C6CE0-0x00000001897C6D30
                // [IDTag] // 0x00000001897C6CE0-0x00000001897C6D30
                // [XID] // 0x00000001897C6CE0-0x00000001897C6D30
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAICombatFollowMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD8620-0x0000000180CD89A0
      // [IDTag] // 0x00000001897D4180-0x00000001897D41C0
      // [XID] // 0x00000001897D4180-0x00000001897D41C0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAICombatFollowMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1A1E0-0x0000000180D1A810
    [BlackList] // 0x00000001897DE8B0-0x00000001897DE900
                // [IDTag] // 0x00000001897DE8B0-0x00000001897DE900
                // [XID] // 0x00000001897DE8B0-0x00000001897DE900
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIMeleeChargeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB98A0-0x0000000180CB9C20
      // [IDTag] // 0x00000001897EC620-0x00000001897EC660
      // [XID] // 0x00000001897EC620-0x00000001897EC660
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIMeleeChargeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D04C80-0x0000000180D05250
    [BlackList] // 0x00000001897F6B90-0x00000001897F6BE0
                // [IDTag] // 0x00000001897F6B90-0x00000001897F6BE0
                // [XID] // 0x00000001897F6B90-0x00000001897F6BE0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIMeleeChargeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD27A0-0x0000000180CD2B20
      // [IDTag] // 0x0000000189804490-0x00000001898044D0
      // [XID] // 0x0000000189804490-0x00000001898044D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIMeleeChargeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFB400-0x0000000180CFBA30
    [BlackList] // 0x000000018980EAA0-0x000000018980EAF0
                // [IDTag] // 0x000000018980EAA0-0x000000018980EAF0
                // [XID] // 0x000000018980EAA0-0x000000018980EAF0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIFacingMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE7EA0-0x0000000180CE8220
      // [IDTag] // 0x000000018981C320-0x000000018981C360
      // [XID] // 0x000000018981C320-0x000000018981C360
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIFacingMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D100A0-0x0000000180D10670
    [BlackList] // 0x0000000189826960-0x00000001898269B0
                // [IDTag] // 0x0000000189826960-0x00000001898269B0
                // [XID] // 0x0000000189826960-0x00000001898269B0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFacingMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDE120-0x0000000180CDE4A0
      // [IDTag] // 0x0000000189833F90-0x0000000189833FD0
      // [XID] // 0x0000000189833F90-0x0000000189833FD0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFacingMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2B110-0x0000000180D2B740
    [BlackList] // 0x000000018983E410-0x000000018983E460
                // [IDTag] // 0x000000018983E410-0x000000018983E460
                // [XID] // 0x000000018983E410-0x000000018983E460
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAISurroundData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDD320-0x0000000180CDD6A0
      // [IDTag] // 0x000000018984B9C0-0x000000018984BA00
      // [XID] // 0x000000018984B9C0-0x000000018984BA00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAISurroundData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D26F40-0x0000000180D27510
    [BlackList] // 0x0000000189855A30-0x0000000189855A80
                // [IDTag] // 0x0000000189855A30-0x0000000189855A80
                // [XID] // 0x0000000189855A30-0x0000000189855A80
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAISurroundData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB6B20-0x0000000180CB6EA0
      // [IDTag] // 0x00000001898631C0-0x0000000189863200
      // [XID] // 0x00000001898631C0-0x0000000189863200
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAISurroundData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1C400-0x0000000180D1CA30
    [BlackList] // 0x000000018986D290-0x000000018986D2E0
                // [IDTag] // 0x000000018986D290-0x000000018986D2E0
                // [XID] // 0x000000018986D290-0x000000018986D2E0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIFindBackData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC3D20-0x0000000180CC40A0
      // [IDTag] // 0x000000018987AE80-0x000000018987AEC0
      // [XID] // 0x000000018987AE80-0x000000018987AEC0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIFindBackData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFA290-0x0000000180CFA860
    [BlackList] // 0x0000000189884D70-0x0000000189884DC0
                // [IDTag] // 0x0000000189884D70-0x0000000189884DC0
                // [XID] // 0x0000000189884D70-0x0000000189884DC0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFindBackData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCC220-0x0000000180CCC5A0
      // [IDTag] // 0x0000000189892050-0x0000000189892090
      // [XID] // 0x0000000189892050-0x0000000189892090
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFindBackData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D39130-0x0000000180D39760
    [BlackList] // 0x000000018989C6E0-0x000000018989C730
                // [IDTag] // 0x000000018989C6E0-0x000000018989C730
                // [XID] // 0x000000018989C6E0-0x000000018989C730
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAICombatFixedMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDC8A0-0x0000000180CDCC20
      // [IDTag] // 0x00000001898A9A60-0x00000001898A9AA0
      // [XID] // 0x00000001898A9A60-0x00000001898A9AA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAICombatFixedMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE9820-0x0000000180CE9DF0
    [BlackList] // 0x00000001898B40D0-0x00000001898B4120
                // [IDTag] // 0x00000001898B40D0-0x00000001898B4120
                // [XID] // 0x00000001898B40D0-0x00000001898B4120
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAICombatFixedMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC08A0-0x0000000180CC0C20
      // [IDTag] // 0x00000001898C1A50-0x00000001898C1A90
      // [XID] // 0x00000001898C1A50-0x00000001898C1A90
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAICombatFixedMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D175C0-0x0000000180D17BF0
    [BlackList] // 0x00000001898CC1B0-0x00000001898CC200
                // [IDTag] // 0x00000001898CC1B0-0x00000001898CC200
                // [XID] // 0x00000001898CC1B0-0x00000001898CC200
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAICrabMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE8CA0-0x0000000180CE9020
      // [IDTag] // 0x00000001898D9CF0-0x00000001898D9D30
      // [XID] // 0x00000001898D9CF0-0x00000001898D9D30
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAICrabMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1AD10-0x0000000180D1B2E0
    [BlackList] // 0x00000001898E47D0-0x00000001898E4820
                // [IDTag] // 0x00000001898E47D0-0x00000001898E4820
                // [XID] // 0x00000001898E47D0-0x00000001898E4820
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAICrabMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD0F20-0x0000000180CD12A0
      // [IDTag] // 0x00000001898F2310-0x00000001898F2350
      // [XID] // 0x00000001898F2310-0x00000001898F2350
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAICrabMoveData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFFEF0-0x0000000180D00520
    [BlackList] // 0x00000001898FCA20-0x00000001898FCA70
                // [IDTag] // 0x00000001898FCA20-0x00000001898FCA70
                // [XID] // 0x00000001898FCA20-0x00000001898FCA70
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIFleeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE62A0-0x0000000180CE6620
      // [IDTag] // 0x000000018990A260-0x000000018990A2A0
      // [XID] // 0x000000018990A260-0x000000018990A2A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIFleeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D05DD0-0x0000000180D063A0
    [BlackList] // 0x0000000189914BB0-0x0000000189914C00
                // [IDTag] // 0x0000000189914BB0-0x0000000189914C00
                // [XID] // 0x0000000189914BB0-0x0000000189914C00
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFleeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC16A0-0x0000000180CC1A20
      // [IDTag] // 0x0000000189922580-0x00000001899225C0
      // [XID] // 0x0000000189922580-0x00000001899225C0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIFleeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D19BB0-0x0000000180D1A1E0
    [BlackList] // 0x000000018992CAB0-0x000000018992CB00
                // [IDTag] // 0x000000018992CAB0-0x000000018992CB00
                // [XID] // 0x000000018992CAB0-0x000000018992CB00
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAISpacialChaseData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCBEA0-0x0000000180CCC220
      // [IDTag] // 0x000000018993A5C0-0x000000018993A600
      // [XID] // 0x000000018993A5C0-0x000000018993A600
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAISpacialChaseData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF12F0-0x0000000180CF18C0
    [BlackList] // 0x0000000189944AC0-0x0000000189944B10
                // [IDTag] // 0x0000000189944AC0-0x0000000189944B10
                // [XID] // 0x0000000189944AC0-0x0000000189944B10
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAISpacialChaseData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDD6A0-0x0000000180CDDA20
      // [IDTag] // 0x00000001899521C0-0x0000000189952200
      // [XID] // 0x00000001899521C0-0x0000000189952200
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAISpacialChaseData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D24DD0-0x0000000180D25400
    [BlackList] // 0x000000018995C6C0-0x000000018995C710
                // [IDTag] // 0x000000018995C6C0-0x000000018995C710
                // [XID] // 0x000000018995C6C0-0x000000018995C710
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAISpacialProbeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDCFA0-0x0000000180CDD320
      // [IDTag] // 0x0000000189969EB0-0x0000000189969EF0
      // [XID] // 0x0000000189969EB0-0x0000000189969EF0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAISpacialProbeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D074E0-0x0000000180D07AB0
    [BlackList] // 0x00000001899748A0-0x00000001899748F0
                // [IDTag] // 0x00000001899748A0-0x00000001899748F0
                // [XID] // 0x00000001899748A0-0x00000001899748F0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAISpacialProbeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC1320-0x0000000180CC16A0
      // [IDTag] // 0x00000001899823C0-0x0000000189982400
      // [XID] // 0x00000001899823C0-0x0000000189982400
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAISpacialProbeData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D02B80-0x0000000180D031B0
    [BlackList] // 0x000000018998C930-0x000000018998C980
                // [IDTag] // 0x000000018998C930-0x000000018998C980
                // [XID] // 0x000000018998C930-0x000000018998C980
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAISpacialAdjustData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE77A0-0x0000000180CE7B20
      // [IDTag] // 0x000000018999A970-0x000000018999A9B0
      // [XID] // 0x000000018999A970-0x000000018999A9B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAISpacialAdjustData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D140C0-0x0000000180D14690
    [BlackList] // 0x00000001899A50C0-0x00000001899A5110
                // [IDTag] // 0x00000001899A50C0-0x00000001899A5110
                // [XID] // 0x00000001899A50C0-0x00000001899A5110
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAISpacialAdjustData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD97A0-0x0000000180CD9B20
      // [IDTag] // 0x00000001899B2CD0-0x00000001899B2D10
      // [XID] // 0x00000001899B2CD0-0x00000001899B2D10
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAISpacialAdjustData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D10670-0x0000000180D10CA0
    [BlackList] // 0x00000001899BD080-0x00000001899BD0D0
                // [IDTag] // 0x00000001899BD080-0x00000001899BD0D0
                // [XID] // 0x00000001899BD080-0x00000001899BD0D0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIBirdCirclingData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC47A0-0x0000000180CC4B20
      // [IDTag] // 0x00000001899CA850-0x00000001899CA890
      // [XID] // 0x00000001899CA850-0x00000001899CA890
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIBirdCirclingData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D23630-0x0000000180D23C00
    [BlackList] // 0x00000001899D4DE0-0x00000001899D4E30
                // [IDTag] // 0x00000001899D4DE0-0x00000001899D4E30
                // [XID] // 0x00000001899D4DE0-0x00000001899D4E30
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIBirdCirclingData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD1620-0x0000000180CD19A0
      // [IDTag] // 0x00000001899E2560-0x00000001899E25A0
      // [XID] // 0x00000001899E2560-0x00000001899E25A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIBirdCirclingData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D13A90-0x0000000180D140C0
    [BlackList] // 0x00000001899ECA20-0x00000001899ECA70
                // [IDTag] // 0x00000001899ECA20-0x00000001899ECA70
                // [XID] // 0x00000001899ECA20-0x00000001899ECA70
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIScriptedMoveToData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD35A0-0x0000000180CD3920
      // [IDTag] // 0x00000001899FA3B0-0x00000001899FA3F0
      // [XID] // 0x00000001899FA3B0-0x00000001899FA3F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIScriptedMoveToData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D14690-0x0000000180D14C60
    [BlackList] // 0x0000000189A048A0-0x0000000189A048F0
                // [IDTag] // 0x0000000189A048A0-0x0000000189A048F0
                // [XID] // 0x0000000189A048A0-0x0000000189A048F0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIScriptedMoveToData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD9420-0x0000000180CD97A0
      // [IDTag] // 0x0000000189A11FA0-0x0000000189A11FE0
      // [XID] // 0x0000000189A11FA0-0x0000000189A11FE0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIScriptedMoveToData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0FA70-0x0000000180D100A0
    [BlackList] // 0x0000000189A1C160-0x0000000189A1C1B0
                // [IDTag] // 0x0000000189A1C160-0x0000000189A1C1B0
                // [XID] // 0x0000000189A1C160-0x0000000189A1C1B0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAILandingData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB9520-0x0000000180CB98A0
      // [IDTag] // 0x0000000189A297A0-0x0000000189A297E0
      // [XID] // 0x0000000189A297A0-0x0000000189A297E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAILandingData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0B310-0x0000000180D0B8E0
    [BlackList] // 0x0000000189A33CF0-0x0000000189A33D40
                // [IDTag] // 0x0000000189A33CF0-0x0000000189A33D40
                // [XID] // 0x0000000189A33CF0-0x0000000189A33D40
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAILandingData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD2420-0x0000000180CD27A0
      // [IDTag] // 0x0000000189A41730-0x0000000189A41770
      // [XID] // 0x0000000189A41730-0x0000000189A41770
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAILandingData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2C920-0x0000000180D2CF50
    [BlackList] // 0x0000000189A4BD10-0x0000000189A4BD60
                // [IDTag] // 0x0000000189A4BD10-0x0000000189A4BD60
                // [XID] // 0x0000000189A4BD10-0x0000000189A4BD60
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIExtractionData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDBE20-0x0000000180CDC1A0
      // [IDTag] // 0x0000000189A594F0-0x0000000189A59530
      // [XID] // 0x0000000189A594F0-0x0000000189A59530
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIExtractionData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1E550-0x0000000180D1EB20
    [BlackList] // 0x0000000189A63F90-0x0000000189A63FE0
                // [IDTag] // 0x0000000189A63F90-0x0000000189A63FE0
                // [XID] // 0x0000000189A63F90-0x0000000189A63FE0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIExtractionData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDE820-0x0000000180CDEBA0
      // [IDTag] // 0x0000000189A71510-0x0000000189A71550
      // [XID] // 0x0000000189A71510-0x0000000189A71550
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIExtractionData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF9C60-0x0000000180CFA290
    [BlackList] // 0x0000000189A7C000-0x0000000189A7C050
                // [IDTag] // 0x0000000189A7C000-0x0000000189A7C050
                // [XID] // 0x0000000189A7C000-0x0000000189A7C050
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigAIBrownianMotionData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE8220-0x0000000180CE85A0
      // [IDTag] // 0x0000000189A89A80-0x0000000189A89AC0
      // [XID] // 0x0000000189A89A80-0x0000000189A89AC0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigAIBrownianMotionData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEF110-0x0000000180CEF6E0
    [BlackList] // 0x0000000189A93E90-0x0000000189A93EE0
                // [IDTag] // 0x0000000189A93E90-0x0000000189A93EE0
                // [XID] // 0x0000000189A93E90-0x0000000189A93EE0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIBrownianMotionData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD7820-0x0000000180CD7BA0
      // [IDTag] // 0x0000000189AA1450-0x0000000189AA1490
      // [XID] // 0x0000000189AA1450-0x0000000189AA1490
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigAIBrownianMotionData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D32C70-0x0000000180D332A0
    [BlackList] // 0x0000000189AABD90-0x0000000189AABDE0
                // [IDTag] // 0x0000000189AABD90-0x0000000189AABDE0
                // [XID] // 0x0000000189AABD90-0x0000000189AABDE0
    public static bool EnumStrToVal(string str, out ConfigAICombatPhase e)
    {
        e = default;
        return default;
    } // 0x0000000180D61850-0x0000000180D61AA0
    [BlackList] // 0x0000000189AB9400-0x0000000189AB9450
                // [IDTag] // 0x0000000189AB9400-0x0000000189AB9450
                // [XID] // 0x0000000189AB9400-0x0000000189AB9450
    public static bool DictFromJson(JSONNode node, out Dictionary<ConfigAICombatPhase, int[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD6DA0-0x0000000180CD7120
      // [IDTag] // 0x0000000189AC72A0-0x0000000189AC72E0
      // [XID] // 0x0000000189AC72A0-0x0000000189AC72E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ConfigAICombatPhase, int[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF4FC0-0x0000000180CF55C0
    [BlackList] // 0x0000000189AD1AA0-0x0000000189AD1AF0
                // [IDTag] // 0x0000000189AD1AA0-0x0000000189AD1AF0
                // [XID] // 0x0000000189AD1AA0-0x0000000189AD1AF0
    public static bool DictFromJson(JSONNode node, out Dictionary<ConfigAICombatPhase, SimpleSafeInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC7FA0-0x0000000180CC8320
      // [IDTag] // 0x0000000189ADFB70-0x0000000189ADFBB0
      // [XID] // 0x0000000189ADFB70-0x0000000189ADFBB0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ConfigAICombatPhase, SimpleSafeInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D34900-0x0000000180D34F00
    [BlackList] // 0x0000000189AEA010-0x0000000189AEA060
                // [IDTag] // 0x0000000189AEA010-0x0000000189AEA060
                // [XID] // 0x0000000189AEA010-0x0000000189AEA060
    public static bool EnumStrToVal(string str, out ConfigAICombatRole e)
    {
        e = default;
        return default;
    } // 0x0000000180D5CCB0-0x0000000180D5CEC0
    [BlackList] // 0x0000000189AF7B90-0x0000000189AF7BE0
                // [IDTag] // 0x0000000189AF7B90-0x0000000189AF7BE0
                // [XID] // 0x0000000189AF7B90-0x0000000189AF7BE0
    public static bool EnumStrToVal(string str, out ConfigAISkillType e)
    {
        e = default;
        return default;
    } // 0x0000000180D3ED30-0x0000000180D3F040
    [BlackList] // 0x0000000189B05170-0x0000000189B051C0
                // [IDTag] // 0x0000000189B05170-0x0000000189B051C0
                // [XID] // 0x0000000189B05170-0x0000000189B051C0
    public static bool EnumStrToVal(string str, out ConfigAICombatSkillType e)
    {
        e = default;
        return default;
    } // 0x0000000180D72D90-0x0000000180D72F20
    [BlackList] // 0x0000000189B12820-0x0000000189B12870
                // [IDTag] // 0x0000000189B12820-0x0000000189B12870
                // [XID] // 0x0000000189B12820-0x0000000189B12870
    public static bool DictFromJson(JSONNode node, out Dictionary<byte, uint[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE4DA0-0x0000000180CE5120
      // [IDTag] // 0x0000000189B1FB20-0x0000000189B1FB60
      // [XID] // 0x0000000189B1FB20-0x0000000189B1FB60
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<byte, uint[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF8B90-0x0000000180CF9160
    [BlackList] // 0x0000000189B2A140-0x0000000189B2A190
                // [IDTag] // 0x0000000189B2A140-0x0000000189B2A190
                // [XID] // 0x0000000189B2A140-0x0000000189B2A190
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt8, SimpleSafeUInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD5FA0-0x0000000180CD6320
      // [IDTag] // 0x0000000189B375F0-0x0000000189B37630
      // [XID] // 0x0000000189B375F0-0x0000000189B37630
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt8, SimpleSafeUInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D14C60-0x0000000180D15290
    [BlackList] // 0x0000000189B41FD0-0x0000000189B42020
                // [IDTag] // 0x0000000189B41FD0-0x0000000189B42020
                // [XID] // 0x0000000189B41FD0-0x0000000189B42020
    public static bool ArrayFromJson(JSONNode node, out ConfigAISkillGroupCD[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCBFB0-0x0000000180DCC330
      // [IDTag] // 0x0000000189B4F6F0-0x0000000189B4F730
      // [XID] // 0x0000000189B4F6F0-0x0000000189B4F730
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAISkillGroupCD[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8F910-0x0000000180D8FBC0
    [BlackList] // 0x0000000189B59F00-0x0000000189B59F50
                // [IDTag] // 0x0000000189B59F00-0x0000000189B59F50
                // [XID] // 0x0000000189B59F00-0x0000000189B59F50
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAISkill> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBD420-0x0000000180CBD7A0
      // [IDTag] // 0x0000000189B67900-0x0000000189B67940
      // [XID] // 0x0000000189B67900-0x0000000189B67940
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAISkill> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D36F10-0x0000000180D37410
    [BlackList] // 0x0000000189B71F00-0x0000000189B71F50
                // [IDTag] // 0x0000000189B71F00-0x0000000189B71F50
                // [XID] // 0x0000000189B71F00-0x0000000189B71F50
    public static bool EnumStrToVal(string str, out AILodStrategyType e)
    {
        e = default;
        return default;
    } // 0x0000000180D48EA0-0x0000000180D490F0
    [BlackList] // 0x0000000189B7F020-0x0000000189B7F070
                // [IDTag] // 0x0000000189B7F020-0x0000000189B7F070
                // [XID] // 0x0000000189B7F020-0x0000000189B7F070
    public static bool ArrayFromJson(JSONNode node, out ConfigAIMixinSetBool[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCC330-0x0000000180DCC6B0
      // [IDTag] // 0x0000000189B8C3B0-0x0000000189B8C3F0
      // [XID] // 0x0000000189B8C3B0-0x0000000189B8C3F0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAIMixinSetBool[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D95CB0-0x0000000180D95F60
    [BlackList] // 0x0000000189B969E0-0x0000000189B96A30
                // [IDTag] // 0x0000000189B969E0-0x0000000189B96A30
                // [XID] // 0x0000000189B969E0-0x0000000189B96A30
    public static bool ArrayFromJson(JSONNode node, out ConfigAIMixinSetInt[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC5330-0x0000000180DC56B0
      // [IDTag] // 0x0000000189BA4020-0x0000000189BA4060
      // [XID] // 0x0000000189BA4020-0x0000000189BA4060
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAIMixinSetInt[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D837B0-0x0000000180D83A60
    [BlackList] // 0x0000000189BAE0A0-0x0000000189BAE0F0
                // [IDTag] // 0x0000000189BAE0A0-0x0000000189BAE0F0
                // [XID] // 0x0000000189BAE0A0-0x0000000189BAE0F0
    public static bool ArrayFromJson(JSONNode node, out ConfigAIMixinSetFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAF530-0x0000000180DAF8B0
      // [IDTag] // 0x0000000189BBB950-0x0000000189BBB990
      // [XID] // 0x0000000189BBB950-0x0000000189BBB990
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAIMixinSetFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8E650-0x0000000180D8E900
    [BlackList] // 0x0000000189BC6320-0x0000000189BC6370
                // [IDTag] // 0x0000000189BC6320-0x0000000189BC6370
                // [XID] // 0x0000000189BC6320-0x0000000189BC6370
    public static bool ArrayFromJson(JSONNode node, out ConfigAIMixinSetAnimatorTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBA0B0-0x0000000180DBA430
      // [IDTag] // 0x0000000189BD3D90-0x0000000189BD3DD0
      // [XID] // 0x0000000189BD3D90-0x0000000189BD3DD0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAIMixinSetAnimatorTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8D0D0-0x0000000180D8D380
    [BlackList] // 0x0000000189BDE780-0x0000000189BDE7D0
                // [IDTag] // 0x0000000189BDE780-0x0000000189BDE7D0
                // [XID] // 0x0000000189BDE780-0x0000000189BDE7D0
    public static bool ArrayFromJson(JSONNode node, out ConfigAIMixinSetControllerParameter[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB1BB0-0x0000000180DB1F30
      // [IDTag] // 0x00000001895F0FA0-0x00000001895F0FE0
      // [XID] // 0x00000001895F0FA0-0x00000001895F0FE0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAIMixinSetControllerParameter[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8B070-0x0000000180D8B320
    [BlackList] // 0x00000001895FB750-0x00000001895FB7A0
                // [IDTag] // 0x00000001895FB750-0x00000001895FB7A0
                // [XID] // 0x00000001895FB750-0x00000001895FB7A0
    public static bool ArrayFromJson(JSONNode node, out ConfigAIMixinSetControllerCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAD230-0x0000000180DAD5B0
      // [IDTag] // 0x00000001896090F0-0x0000000189609130
      // [XID] // 0x00000001896090F0-0x0000000189609130
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAIMixinSetControllerCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D99240-0x0000000180D994F0
    [BlackList] // 0x00000001896136D0-0x0000000189613720
                // [IDTag] // 0x00000001896136D0-0x0000000189613720
                // [XID] // 0x00000001896136D0-0x0000000189613720
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAnimationRecurrentSpeech> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC32A0-0x0000000180CC3620
      // [IDTag] // 0x0000000189620E10-0x0000000189620E50
      // [XID] // 0x0000000189620E10-0x0000000189620E50
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAnimationRecurrentSpeech> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFE380-0x0000000180CFE880
    [BlackList] // 0x000000018962B4E0-0x000000018962B530
                // [IDTag] // 0x000000018962B4E0-0x000000018962B530
                // [XID] // 0x000000018962B4E0-0x000000018962B530
    public static bool EnumStrToVal(string str, out ReferenceType e)
    {
        e = default;
        return default;
    } // 0x0000000180D53950-0x0000000180D53AE0
    [BlackList] // 0x0000000189639050-0x00000001896390A0
                // [IDTag] // 0x0000000189639050-0x00000001896390A0
                // [XID] // 0x0000000189639050-0x00000001896390A0
    public static bool EnumStrToVal(string str, out CheckHitLayerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D687E0-0x0000000180D68970
    [BlackList] // 0x0000000189646520-0x0000000189646570
                // [IDTag] // 0x0000000189646520-0x0000000189646570
                // [XID] // 0x0000000189646520-0x0000000189646570
    public static bool EnumStrToVal(string str, out CircleDetectDirection e)
    {
        e = default;
        return default;
    } // 0x0000000180D71FB0-0x0000000180D72140
    [BlackList] // 0x0000000189653CE0-0x0000000189653D30
                // [IDTag] // 0x0000000189653CE0-0x0000000189653D30
                // [XID] // 0x0000000189653CE0-0x0000000189653D30
    public static bool EnumStrToVal(string str, out EntityAttackFilter e)
    {
        e = default;
        return default;
    } // 0x0000000180D3E070-0x0000000180D3E280
    [BlackList] // 0x0000000189661390-0x00000001896613E0
                // [IDTag] // 0x0000000189661390-0x00000001896613E0
                // [XID] // 0x0000000189661390-0x00000001896613E0
    public static bool ArrayFromJson(JSONNode node, out ConfigBaseAttackPattern[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAD5B0-0x0000000180DAD930
      // [IDTag] // 0x000000018966EDF0-0x000000018966EE30
      // [XID] // 0x000000018966EDF0-0x000000018966EE30
    private static bool InternalArrayFromJson(JSONNode node, out ConfigBaseAttackPattern[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7C410-0x0000000180D7C6A0
    [BlackList] // 0x0000000189679AE0-0x0000000189679B30
                // [IDTag] // 0x0000000189679AE0-0x0000000189679B30
                // [XID] // 0x0000000189679AE0-0x0000000189679B30
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigBaseAttackPattern> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE8920-0x0000000180CE8CA0
      // [IDTag] // 0x00000001896870B0-0x00000001896870F0
      // [XID] // 0x00000001896870B0-0x00000001896870F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigBaseAttackPattern> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1FA50-0x0000000180D1FF20
    [BlackList] // 0x0000000189692130-0x0000000189692180
                // [IDTag] // 0x0000000189692130-0x0000000189692180
                // [XID] // 0x0000000189692130-0x0000000189692180
    public static bool ArrayFromJson(JSONNode node, out AudioAmbiencePositionedEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC09B0-0x0000000180DC0D30
      // [IDTag] // 0x000000018969F2C0-0x000000018969F300
      // [XID] // 0x000000018969F2C0-0x000000018969F300
    private static bool InternalArrayFromJson(JSONNode node, out AudioAmbiencePositionedEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D88550-0x0000000180D88800
    [BlackList] // 0x00000001896A97E0-0x00000001896A9830
                // [IDTag] // 0x00000001896A97E0-0x00000001896A9830
                // [XID] // 0x00000001896A97E0-0x00000001896A9830
    public static bool EnumStrToVal(string str, out MultiPositionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D681F0-0x0000000180D68380
    [BlackList] // 0x00000001896B6950-0x00000001896B69A0
                // [IDTag] // 0x00000001896B6950-0x00000001896B69A0
                // [XID] // 0x00000001896B6950-0x00000001896B69A0
    public static bool ArrayFromJson(JSONNode node, out AudioTreeDataAssetNamePattern[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9F930-0x0000000180D9FCB0
      // [IDTag] // 0x00000001896C3C80-0x00000001896C3CC0
      // [XID] // 0x00000001896C3C80-0x00000001896C3CC0
    private static bool InternalArrayFromJson(JSONNode node, out AudioTreeDataAssetNamePattern[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D97770-0x0000000180D97A20
    [BlackList] // 0x00000001896CE300-0x00000001896CE350
                // [IDTag] // 0x00000001896CE300-0x00000001896CE350
                // [XID] // 0x00000001896CE300-0x00000001896CE350
    public static bool ArrayFromJson(JSONNode node, out ConfigAudioArea2DAmbience[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA5430-0x0000000180DA57B0
      // [IDTag] // 0x00000001896DB6B0-0x00000001896DB6F0
      // [XID] // 0x00000001896DB6B0-0x00000001896DB6F0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAudioArea2DAmbience[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7AE90-0x0000000180D7B140
    [BlackList] // 0x00000001896E5AE0-0x00000001896E5B30
                // [IDTag] // 0x00000001896E5AE0-0x00000001896E5B30
                // [XID] // 0x00000001896E5AE0-0x00000001896E5B30
    public static bool EnumStrToVal(string str, out AudioPlatformMoveType e)
    {
        e = default;
        return default;
    } // 0x0000000180D73FB0-0x0000000180D74180
    [BlackList] // 0x00000001896F3160-0x00000001896F31B0
                // [IDTag] // 0x00000001896F3160-0x00000001896F31B0
                // [XID] // 0x00000001896F3160-0x00000001896F31B0
    public static bool ArrayFromJson(JSONNode node, out AudioPlatformMoveSettings[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBD530-0x0000000180DBD8B0
      // [IDTag] // 0x00000001897005C0-0x0000000189700600
      // [XID] // 0x00000001897005C0-0x0000000189700600
    private static bool InternalArrayFromJson(JSONNode node, out AudioPlatformMoveSettings[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D903D0-0x0000000180D906B0
    [BlackList] // 0x000000018970AE50-0x000000018970AEA0
                // [IDTag] // 0x000000018970AE50-0x000000018970AEA0
                // [XID] // 0x000000018970AE50-0x000000018970AEA0
    public static bool ArrayFromJson(JSONNode node, out AudioPlatformMoveSettingsUsagePair[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC41B0-0x0000000180DC4530
      // [IDTag] // 0x0000000189718510-0x0000000189718550
      // [XID] // 0x0000000189718510-0x0000000189718550
    private static bool InternalArrayFromJson(JSONNode node, out AudioPlatformMoveSettingsUsagePair[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D92C60-0x0000000180D92EF0
    [BlackList] // 0x0000000189722B50-0x0000000189722BA0
                // [IDTag] // 0x0000000189722B50-0x0000000189722BA0
                // [XID] // 0x0000000189722B50-0x0000000189722BA0
    public static bool ArrayFromJson(JSONNode node, out AudioImpactOverrideEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC02B0-0x0000000180DC0630
      // [IDTag] // 0x0000000189730290-0x00000001897302D0
      // [XID] // 0x0000000189730290-0x00000001897302D0
    private static bool InternalArrayFromJson(JSONNode node, out AudioImpactOverrideEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D93450-0x0000000180D93700
    [BlackList] // 0x000000018973A850-0x000000018973A8A0
                // [IDTag] // 0x000000018973A850-0x000000018973A8A0
                // [XID] // 0x000000018973A850-0x000000018973A8A0
    public static bool DictFromJson(JSONNode node, out Dictionary<StrikeType, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBE920-0x0000000180CBECA0
      // [IDTag] // 0x00000001897483D0-0x0000000189748410
      // [XID] // 0x00000001897483D0-0x0000000189748410
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<StrikeType, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0AD10-0x0000000180D0B310
    [BlackList] // 0x00000001897527B0-0x0000000189752800
                // [IDTag] // 0x00000001897527B0-0x0000000189752800
                // [XID] // 0x00000001897527B0-0x0000000189752800
    public static bool DictFromJson(JSONNode node, out Dictionary<ElementType, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB91A0-0x0000000180CB9520
      // [IDTag] // 0x000000018975FFE0-0x0000000189760020
      // [XID] // 0x000000018975FFE0-0x0000000189760020
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ElementType, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEA920-0x0000000180CEAF20
    [BlackList] // 0x000000018976A670-0x000000018976A6C0
                // [IDTag] // 0x000000018976A670-0x000000018976A6C0
                // [XID] // 0x000000018976A670-0x000000018976A6C0
    public static bool ArrayFromJson(JSONNode node, out AudioDialogReaction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA1530-0x0000000180DA18B0
      // [IDTag] // 0x0000000189777BD0-0x0000000189777C10
      // [XID] // 0x0000000189777BD0-0x0000000189777C10
    private static bool InternalArrayFromJson(JSONNode node, out AudioDialogReaction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D93700-0x0000000180D939B0
    [BlackList] // 0x0000000189782750-0x00000001897827A0
                // [IDTag] // 0x0000000189782750-0x00000001897827A0
                // [XID] // 0x0000000189782750-0x00000001897827A0
    public static bool EnumStrToVal(string str, out AudioEmitterMultiPositionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5C2A0-0x0000000180D5C3E0
    [BlackList] // 0x000000018978F9C0-0x000000018978FA10
                // [IDTag] // 0x000000018978F9C0-0x000000018978FA10
                // [XID] // 0x000000018978F9C0-0x000000018978FA10
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAudioEmitter> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC4EA0-0x0000000180CC5220
      // [IDTag] // 0x000000018979DCF0-0x000000018979DD30
      // [XID] // 0x000000018979DCF0-0x000000018979DD30
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAudioEmitter> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D07AB0-0x0000000180D07FB0
    [BlackList] // 0x00000001897A7DE0-0x00000001897A7E30
                // [IDTag] // 0x00000001897A7DE0-0x00000001897A7E30
                // [XID] // 0x00000001897A7DE0-0x00000001897A7E30
    public static bool ArrayFromJson(JSONNode node, out ConfigAudioEventCullingRuleBase[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAE030-0x0000000180DAE3B0
      // [IDTag] // 0x00000001897B5FD0-0x00000001897B6010
      // [XID] // 0x00000001897B5FD0-0x00000001897B6010
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAudioEventCullingRuleBase[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D80210-0x0000000180D804A0
    [BlackList] // 0x00000001897C0BA0-0x00000001897C0BF0
                // [IDTag] // 0x00000001897C0BA0-0x00000001897C0BF0
                // [XID] // 0x00000001897C0BA0-0x00000001897C0BF0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAudioEventCullingRuleBase[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD82A0-0x0000000180CD8620
      // [IDTag] // 0x00000001897CE420-0x00000001897CE460
      // [XID] // 0x00000001897CE420-0x00000001897CE460
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAudioEventCullingRuleBase[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D332A0-0x0000000180D337A0
    [BlackList] // 0x00000001897D9050-0x00000001897D90A0
                // [IDTag] // 0x00000001897D9050-0x00000001897D90A0
                // [XID] // 0x00000001897D9050-0x00000001897D90A0
    public static bool ArrayFromJson(JSONNode node, out ConfigAudioMapArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA3130-0x0000000180DA34B0
      // [IDTag] // 0x00000001897E6330-0x00000001897E6370
      // [XID] // 0x00000001897E6330-0x00000001897E6370
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAudioMapArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D877F0-0x0000000180D87AA0
    [BlackList] // 0x00000001897F0F00-0x00000001897F0F50
                // [IDTag] // 0x00000001897F0F00-0x00000001897F0F50
                // [XID] // 0x00000001897F0F00-0x00000001897F0F50
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE3520-0x0000000180CE38A0
      // [IDTag] // 0x00000001897FE200-0x00000001897FE240
      // [XID] // 0x00000001897FE200-0x00000001897FE240
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEF6E0-0x0000000180CEFCB0
    [BlackList] // 0x0000000189808AF0-0x0000000189808B40
                // [IDTag] // 0x0000000189808AF0-0x0000000189808B40
                // [XID] // 0x0000000189808AF0-0x0000000189808B40
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDF2A0-0x0000000180CDF620
      // [IDTag] // 0x00000001898161A0-0x00000001898161E0
      // [XID] // 0x00000001898161A0-0x00000001898161E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D23C00-0x0000000180D24230
    [BlackList] // 0x0000000189820DD0-0x0000000189820E20
                // [IDTag] // 0x0000000189820DD0-0x0000000189820E20
                // [XID] // 0x0000000189820DD0-0x0000000189820E20
    public static bool DictFromJson(JSONNode node, out Dictionary<int, Dictionary<int, ConfigWwiseString>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB9FA0-0x0000000180CBA320
      // [IDTag] // 0x000000018982E020-0x000000018982E060
      // [XID] // 0x000000018982E020-0x000000018982E060
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, Dictionary<int, ConfigWwiseString>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D03CE0-0x0000000180D042B0
    [BlackList] // 0x0000000189838660-0x00000001898386B0
                // [IDTag] // 0x0000000189838660-0x00000001898386B0
                // [XID] // 0x0000000189838660-0x00000001898386B0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigWwiseString>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE2020-0x0000000180CE23A0
      // [IDTag] // 0x0000000189845B90-0x0000000189845BD0
      // [XID] // 0x0000000189845B90-0x0000000189845BD0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigWwiseString>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D38B00-0x0000000180D39130
    [BlackList] // 0x000000018984FEC0-0x000000018984FF10
                // [IDTag] // 0x000000018984FEC0-0x000000018984FF10
                // [XID] // 0x000000018984FEC0-0x000000018984FF10
    public static bool DictFromJson(JSONNode node, out Dictionary<int, int> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD3CA0-0x0000000180CD4020
      // [IDTag] // 0x000000018985CE70-0x000000018985CEB0
      // [XID] // 0x000000018985CE70-0x000000018985CEB0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, int> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFD280-0x0000000180CFD850
    [BlackList] // 0x0000000189867610-0x0000000189867660
                // [IDTag] // 0x0000000189867610-0x0000000189867660
                // [XID] // 0x0000000189867610-0x0000000189867660
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, SimpleSafeInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCB0A0-0x0000000180CCB420
      // [IDTag] // 0x00000001898747B0-0x00000001898747F0
      // [XID] // 0x00000001898747B0-0x00000001898747F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, SimpleSafeInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D05790-0x0000000180D05DD0
    [BlackList] // 0x000000018987F200-0x000000018987F250
                // [IDTag] // 0x000000018987F200-0x000000018987F250
                // [XID] // 0x000000018987F200-0x000000018987F250
    public static bool ArrayFromJson(JSONNode node, out MusicEnemyCombatPhaseState[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA9DB0-0x0000000180DAA130
      // [IDTag] // 0x000000018988C3F0-0x000000018988C430
      // [XID] // 0x000000018988C3F0-0x000000018988C430
    private static bool InternalArrayFromJson(JSONNode node, out MusicEnemyCombatPhaseState[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D92700-0x0000000180D929B0
    [BlackList] // 0x00000001898967F0-0x0000000189896840
                // [IDTag] // 0x00000001898967F0-0x0000000189896840
                // [XID] // 0x00000001898967F0-0x0000000189896840
    public static bool ArrayFromJson(JSONNode node, out MusicEnemySettings[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBC730-0x0000000180DBCAB0
      // [IDTag] // 0x00000001898A3ED0-0x00000001898A3F10
      // [XID] // 0x00000001898A3ED0-0x00000001898A3F10
    private static bool InternalArrayFromJson(JSONNode node, out MusicEnemySettings[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D90BF0-0x0000000180D90EA0
    [BlackList] // 0x00000001898AE6A0-0x00000001898AE6F0
                // [IDTag] // 0x00000001898AE6A0-0x00000001898AE6F0
                // [XID] // 0x00000001898AE6A0-0x00000001898AE6F0
    public static bool EnumStrToVal(string str, out AudioScope e)
    {
        e = default;
        return default;
    } // 0x0000000180D594F0-0x0000000180D59630
    [BlackList] // 0x00000001898BBDA0-0x00000001898BBDF0
                // [IDTag] // 0x00000001898BBDA0-0x00000001898BBDF0
                // [XID] // 0x00000001898BBDA0-0x00000001898BBDF0
    public static bool ArrayFromJson(JSONNode node, out AudioMutualExclusion[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DACB30-0x0000000180DACEB0
      // [IDTag] // 0x00000001898C9350-0x00000001898C9390
      // [XID] // 0x00000001898C9350-0x00000001898C9390
    private static bool InternalArrayFromJson(JSONNode node, out AudioMutualExclusion[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D82A40-0x0000000180D82CF0
    [BlackList] // 0x00000001898D3950-0x00000001898D39A0
                // [IDTag] // 0x00000001898D3950-0x00000001898D39A0
                // [XID] // 0x00000001898D3950-0x00000001898D39A0
    public static bool EnumStrToVal(string str, out OpResponder e)
    {
        e = default;
        return default;
    } // 0x0000000180D64850-0x0000000180D649E0
    [BlackList] // 0x00000001898E1820-0x00000001898E1870
                // [IDTag] // 0x00000001898E1820-0x00000001898E1870
                // [XID] // 0x00000001898E1820-0x00000001898E1870
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAudioOperation> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC1DA0-0x0000000180CC2120
      // [IDTag] // 0x00000001898EF320-0x00000001898EF360
      // [XID] // 0x00000001898EF320-0x00000001898EF360
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAudioOperation> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D28B10-0x0000000180D28FE0
    [BlackList] // 0x00000001898F9AE0-0x00000001898F9B30
                // [IDTag] // 0x00000001898F9AE0-0x00000001898F9B30
                // [XID] // 0x00000001898F9AE0-0x00000001898F9B30
    public static bool ArrayFromJson(JSONNode node, out ConfigAudioQuestOps[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA3830-0x0000000180DA3BB0
      // [IDTag] // 0x0000000189907430-0x0000000189907470
      // [XID] // 0x0000000189907430-0x0000000189907470
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAudioQuestOps[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D86D50-0x0000000180D87000
    [BlackList] // 0x0000000189911C90-0x0000000189911CE0
                // [IDTag] // 0x0000000189911C90-0x0000000189911CE0
                // [XID] // 0x0000000189911C90-0x0000000189911CE0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAudioIncrementalResources> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBFE20-0x0000000180CC01A0
      // [IDTag] // 0x000000018991F360-0x000000018991F3A0
      // [XID] // 0x000000018991F360-0x000000018991F3A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAudioIncrementalResources> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D23130-0x0000000180D23630
    [BlackList] // 0x0000000189929CF0-0x0000000189929D40
                // [IDTag] // 0x0000000189929CF0-0x0000000189929D40
                // [XID] // 0x0000000189929CF0-0x0000000189929D40
    public static bool ArrayFromJson(JSONNode node, out AudioSettingSlider_PostVoiceItem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBA430-0x0000000180DBA7B0
      // [IDTag] // 0x0000000189937050-0x0000000189937090
      // [XID] // 0x0000000189937050-0x0000000189937090
    private static bool InternalArrayFromJson(JSONNode node, out AudioSettingSlider_PostVoiceItem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9BCD0-0x0000000180D9BF80
    [BlackList] // 0x0000000189941650-0x00000001899416A0
                // [IDTag] // 0x0000000189941650-0x00000001899416A0
                // [XID] // 0x0000000189941650-0x00000001899416A0
    public static bool ArrayFromJson(JSONNode node, out ConfigAudioStageProgressEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA7030-0x0000000180DA73B0
      // [IDTag] // 0x000000018994F030-0x000000018994F070
      // [XID] // 0x000000018994F030-0x000000018994F070
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAudioStageProgressEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7D6C0-0x0000000180D7D970
    [BlackList] // 0x0000000189959720-0x0000000189959770
                // [IDTag] // 0x0000000189959720-0x0000000189959770
                // [XID] // 0x0000000189959720-0x0000000189959770
    public static bool DictFromJson(JSONNode node, out Dictionary<string, AudioWeatherProperties> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDC520-0x0000000180CDC8A0
      // [IDTag] // 0x00000001899671B0-0x00000001899671F0
      // [XID] // 0x00000001899671B0-0x00000001899671F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, AudioWeatherProperties> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFDE80-0x0000000180CFE380
    [BlackList] // 0x0000000189971C60-0x0000000189971CB0
                // [IDTag] // 0x0000000189971C60-0x0000000189971CB0
                // [XID] // 0x0000000189971C60-0x0000000189971CB0
    public static bool ArrayFromJson(JSONNode node, out ConfigWeatherType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCE2B0-0x0000000180DCE630
      // [IDTag] // 0x000000018997ECB0-0x000000018997ECF0
      // [XID] // 0x000000018997ECB0-0x000000018997ECF0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigWeatherType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D847C0-0x0000000180D84A80
    [BlackList] // 0x0000000189989B20-0x0000000189989B70
                // [IDTag] // 0x0000000189989B20-0x0000000189989B70
                // [XID] // 0x0000000189989B20-0x0000000189989B70
    public static bool ArrayFromJson(JSONNode node, out AudioWeatherVoTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB6FB0-0x0000000180DB7330
      // [IDTag] // 0x00000001899973B0-0x00000001899973F0
      // [XID] // 0x00000001899973B0-0x00000001899973F0
    private static bool InternalArrayFromJson(JSONNode node, out AudioWeatherVoTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8BB60-0x0000000180D8BE10
    [BlackList] // 0x00000001899A2010-0x00000001899A2060
                // [IDTag] // 0x00000001899A2010-0x00000001899A2060
                // [XID] // 0x00000001899A2010-0x00000001899A2060
    public static bool ArrayFromJson(JSONNode node, out AvatarSpeechEquipObtain[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCD130-0x0000000180DCD4B0
      // [IDTag] // 0x00000001899AF9D0-0x00000001899AFA10
      // [XID] // 0x00000001899AF9D0-0x00000001899AFA10
    private static bool InternalArrayFromJson(JSONNode node, out AvatarSpeechEquipObtain[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D98210-0x0000000180D984C0
    [BlackList] // 0x00000001899B9E10-0x00000001899B9E60
                // [IDTag] // 0x00000001899B9E10-0x00000001899B9E60
                // [XID] // 0x00000001899B9E10-0x00000001899B9E60
    public static bool EnumStrToVal(string str, out VoicePersonality e)
    {
        e = default;
        return default;
    } // 0x0000000180D653A0-0x0000000180D65530
    [BlackList] // 0x00000001899C7870-0x00000001899C78C0
                // [IDTag] // 0x00000001899C7870-0x00000001899C78C0
                // [XID] // 0x00000001899C7870-0x00000001899C78C0
    public static bool EnumStrToVal(string str, out VoicePositioning e)
    {
        e = default;
        return default;
    } // 0x0000000180D48630-0x0000000180D48840
    [BlackList] // 0x00000001899D4D90-0x00000001899D4DE0
                // [IDTag] // 0x00000001899D4D90-0x00000001899D4DE0
                // [XID] // 0x00000001899D4D90-0x00000001899D4DE0
    public static bool ArrayFromJson(JSONNode node, out VoiceSound[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA6CB0-0x0000000180DA7030
      // [IDTag] // 0x00000001899E2520-0x00000001899E2560
      // [XID] // 0x00000001899E2520-0x00000001899E2560
    private static bool InternalArrayFromJson(JSONNode node, out VoiceSound[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8C8C0-0x0000000180D8CB70
    [BlackList] // 0x00000001899EC9D0-0x00000001899ECA20
                // [IDTag] // 0x00000001899EC9D0-0x00000001899ECA20
                // [XID] // 0x00000001899EC9D0-0x00000001899ECA20
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, VoiceTriggerIdentity> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDA5A0-0x0000000180CDA920
      // [IDTag] // 0x00000001899FA370-0x00000001899FA3B0
      // [XID] // 0x00000001899FA370-0x00000001899FA3B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, VoiceTriggerIdentity> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0DEC0-0x0000000180D0E490
    [BlackList] // 0x0000000189A04850-0x0000000189A048A0
                // [IDTag] // 0x0000000189A04850-0x0000000189A048A0
                // [XID] // 0x0000000189A04850-0x0000000189A048A0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, VoiceTriggerIdentity> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE54A0-0x0000000180CE5820
      // [IDTag] // 0x0000000189A11F60-0x0000000189A11FA0
      // [XID] // 0x0000000189A11F60-0x0000000189A11FA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, VoiceTriggerIdentity> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D112A0-0x0000000180D118D0
    [BlackList] // 0x0000000189A1C110-0x0000000189A1C160
                // [IDTag] // 0x0000000189A1C110-0x0000000189A1C160
                // [XID] // 0x0000000189A1C110-0x0000000189A1C160
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigBoundary> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE7420-0x0000000180CE77A0
      // [IDTag] // 0x0000000189A29760-0x0000000189A297A0
      // [XID] // 0x0000000189A29760-0x0000000189A297A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigBoundary> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D26A40-0x0000000180D26F40
    [BlackList] // 0x0000000189A33CA0-0x0000000189A33CF0
                // [IDTag] // 0x0000000189A33CA0-0x0000000189A33CF0
                // [XID] // 0x0000000189A33CA0-0x0000000189A33CF0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigCameraMove> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD0820-0x0000000180CD0BA0
      // [IDTag] // 0x0000000189A416F0-0x0000000189A41730
      // [XID] // 0x0000000189A416F0-0x0000000189A41730
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigCameraMove> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2DA80-0x0000000180D2DF80
    [BlackList] // 0x0000000189A4BCC0-0x0000000189A4BD10
                // [IDTag] // 0x0000000189A4BCC0-0x0000000189A4BD10
                // [XID] // 0x0000000189A4BCC0-0x0000000189A4BD10
    public static bool EnumStrToVal(string str, out JsonClimateType e)
    {
        e = default;
        return default;
    } // 0x0000000180D77CE0-0x0000000180D77E70
    [BlackList] // 0x0000000189A594A0-0x0000000189A594F0
                // [IDTag] // 0x0000000189A594A0-0x0000000189A594F0
                // [XID] // 0x0000000189A594A0-0x0000000189A594F0
    public static bool ArrayFromJson(JSONNode node, out JsonClimateType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB4930-0x0000000180DB4CB0
      // [IDTag] // 0x0000000189A66F80-0x0000000189A66FC0
      // [XID] // 0x0000000189A66F80-0x0000000189A66FC0
    private static bool InternalArrayFromJson(JSONNode node, out JsonClimateType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D79BD0-0x0000000180D79E90
    [BlackList] // 0x0000000189A714C0-0x0000000189A71510
                // [IDTag] // 0x0000000189A714C0-0x0000000189A71510
                // [XID] // 0x0000000189A714C0-0x0000000189A71510
    public static bool DictFromJson(JSONNode node, out Dictionary<JsonClimateType, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD89A0-0x0000000180CD8D20
      // [IDTag] // 0x0000000189A7EE40-0x0000000189A7EE80
      // [XID] // 0x0000000189A7EE40-0x0000000189A7EE80
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<JsonClimateType, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D084B0-0x0000000180D08AB0
    [BlackList] // 0x0000000189A89A30-0x0000000189A89A80
                // [IDTag] // 0x0000000189A89A30-0x0000000189A89A80
                // [XID] // 0x0000000189A89A30-0x0000000189A89A80
    public static bool DictFromJson(JSONNode node, out Dictionary<JsonClimateType, uint[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCA2A0-0x0000000180CCA620
      // [IDTag] // 0x0000000189A97140-0x0000000189A97180
      // [XID] // 0x0000000189A97140-0x0000000189A97180
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<JsonClimateType, uint[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEC7E0-0x0000000180CECDE0
    [BlackList] // 0x0000000189AA1400-0x0000000189AA1450
                // [IDTag] // 0x0000000189AA1400-0x0000000189AA1450
                // [XID] // 0x0000000189AA1400-0x0000000189AA1450
    public static bool DictFromJson(JSONNode node, out Dictionary<JsonClimateType, SimpleSafeUInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC24A0-0x0000000180CC2820
      // [IDTag] // 0x0000000189AAED00-0x0000000189AAED40
      // [XID] // 0x0000000189AAED00-0x0000000189AAED40
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<JsonClimateType, SimpleSafeUInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D158C0-0x0000000180D15EC0
    [BlackList] // 0x0000000189AB93B0-0x0000000189AB9400
                // [IDTag] // 0x0000000189AB93B0-0x0000000189AB9400
                // [XID] // 0x0000000189AB93B0-0x0000000189AB9400
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigClimateInfoBase> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC4B20-0x0000000180CC4EA0
      // [IDTag] // 0x0000000189AC7260-0x0000000189AC72A0
      // [XID] // 0x0000000189AC7260-0x0000000189AC72A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigClimateInfoBase> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1E080-0x0000000180D1E550
    [BlackList] // 0x0000000189AD1A50-0x0000000189AD1AA0
                // [IDTag] // 0x0000000189AD1A50-0x0000000189AD1AA0
                // [XID] // 0x0000000189AD1A50-0x0000000189AD1AA0
    public static bool ArrayFromJson(JSONNode node, out ConfigClimateArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCAAB0-0x0000000180DCAE30
      // [IDTag] // 0x0000000189ADFB30-0x0000000189ADFB70
      // [XID] // 0x0000000189ADFB30-0x0000000189ADFB70
    private static bool InternalArrayFromJson(JSONNode node, out ConfigClimateArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D98CE0-0x0000000180D98F90
    [BlackList] // 0x0000000189AE9FC0-0x0000000189AEA010
                // [IDTag] // 0x0000000189AE9FC0-0x0000000189AEA010
                // [XID] // 0x0000000189AE9FC0-0x0000000189AEA010
    public static bool EnumStrToVal(string str, out CodexQuestItemType e)
    {
        e = default;
        return default;
    } // 0x0000000180D61540-0x0000000180D61850
    [BlackList] // 0x0000000189AF7B40-0x0000000189AF7B90
                // [IDTag] // 0x0000000189AF7B40-0x0000000189AF7B90
                // [XID] // 0x0000000189AF7B40-0x0000000189AF7B90
    public static bool EnumStrToVal(string str, out CodexQuestTextType e)
    {
        e = default;
        return default;
    } // 0x0000000180D418A0-0x0000000180D41D00
    [BlackList] // 0x0000000189B05120-0x0000000189B05170
                // [IDTag] // 0x0000000189B05120-0x0000000189B05170
                // [XID] // 0x0000000189B05120-0x0000000189B05170
    public static bool ArrayFromJson(JSONNode node, out ConfigCodexQuestText[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAEE30-0x0000000180DAF1B0
      // [IDTag] // 0x0000000189B127E0-0x0000000189B12820
      // [XID] // 0x0000000189B127E0-0x0000000189B12820
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCodexQuestText[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D94450-0x0000000180D94700
    [BlackList] // 0x0000000189B1CE10-0x0000000189B1CE60
                // [IDTag] // 0x0000000189B1CE10-0x0000000189B1CE60
                // [XID] // 0x0000000189B1CE10-0x0000000189B1CE60
    public static bool ArrayFromJson(JSONNode node, out ConfigCodexQuestDialogSingle[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAF1B0-0x0000000180DAF530
      // [IDTag] // 0x0000000189B2A100-0x0000000189B2A140
      // [XID] // 0x0000000189B2A100-0x0000000189B2A140
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCodexQuestDialogSingle[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7C6A0-0x0000000180D7C950
    [BlackList] // 0x0000000189B34320-0x0000000189B34370
                // [IDTag] // 0x0000000189B34320-0x0000000189B34370
                // [XID] // 0x0000000189B34320-0x0000000189B34370
    public static bool ArrayFromJson(JSONNode node, out ConfigCodexQuestItem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9EB30-0x0000000180D9EEB0
      // [IDTag] // 0x0000000189B41F90-0x0000000189B41FD0
      // [XID] // 0x0000000189B41F90-0x0000000189B41FD0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCodexQuestItem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7A140-0x0000000180D7A3F0
    [BlackList] // 0x0000000189B4C840-0x0000000189B4C890
                // [IDTag] // 0x0000000189B4C840-0x0000000189B4C890
                // [XID] // 0x0000000189B4C840-0x0000000189B4C890
    public static bool ArrayFromJson(JSONNode node, out ConfigCodexQuestSubQuest[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB0A30-0x0000000180DB0DB0
      // [IDTag] // 0x0000000189B59EC0-0x0000000189B59F00
      // [XID] // 0x0000000189B59EC0-0x0000000189B59F00
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCodexQuestSubQuest[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D83D10-0x0000000180D83FC0
    [BlackList] // 0x0000000189B64730-0x0000000189B64780
                // [IDTag] // 0x0000000189B64730-0x0000000189B64780
                // [XID] // 0x0000000189B64730-0x0000000189B64780
    public static bool EnumStrToVal(string str, out StrikeType e)
    {
        e = default;
        return default;
    } // 0x0000000180D68380-0x0000000180D685D0
    [BlackList] // 0x0000000189B71EB0-0x0000000189B71F00
                // [IDTag] // 0x0000000189B71EB0-0x0000000189B71F00
                // [XID] // 0x0000000189B71EB0-0x0000000189B71F00
    public static bool ArrayFromJson(JSONNode node, out StrikeType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC3730-0x0000000180DC3AB0
      // [IDTag] // 0x0000000189B7EFE0-0x0000000189B7F020
      // [XID] // 0x0000000189B7EFE0-0x0000000189B7F020
    private static bool InternalArrayFromJson(JSONNode node, out StrikeType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9BA10-0x0000000180D9BCD0
    [BlackList] // 0x0000000189B89970-0x0000000189B899C0
                // [IDTag] // 0x0000000189B89970-0x0000000189B899C0
                // [XID] // 0x0000000189B89970-0x0000000189B899C0
    public static bool EnumStrToVal(string str, out AttackType e)
    {
        e = default;
        return default;
    } // 0x0000000180D41D00-0x0000000180D41ED0
    [BlackList] // 0x0000000189B96990-0x0000000189B969E0
                // [IDTag] // 0x0000000189B96990-0x0000000189B969E0
                // [XID] // 0x0000000189B96990-0x0000000189B969E0
    public static bool EnumStrToVal(string str, out HitLevel e)
    {
        e = default;
        return default;
    } // 0x0000000180D44190-0x0000000180D443A0
    [BlackList] // 0x0000000189BA3FD0-0x0000000189BA4020
                // [IDTag] // 0x0000000189BA3FD0-0x0000000189BA4020
                // [XID] // 0x0000000189BA3FD0-0x0000000189BA4020
    public static bool EnumStrToVal(string str, out RetreatType e)
    {
        e = default;
        return default;
    } // 0x0000000180D685D0-0x0000000180D687E0
    [BlackList] // 0x0000000189BB16B0-0x0000000189BB1700
                // [IDTag] // 0x0000000189BB16B0-0x0000000189BB1700
                // [XID] // 0x0000000189BB16B0-0x0000000189BB1700
    public static bool EnumStrToVal(string str, out CanBeModifiedBy e)
    {
        e = default;
        return default;
    } // 0x0000000180D544B0-0x0000000180D54640
    [BlackList] // 0x0000000189BBE610-0x0000000189BBE660
                // [IDTag] // 0x0000000189BBE610-0x0000000189BBE660
                // [XID] // 0x0000000189BBE610-0x0000000189BBE660
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAttackEvent> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCC920-0x0000000180CCCCA0
      // [IDTag] // 0x0000000189BCC7A0-0x0000000189BCC7E0
      // [XID] // 0x0000000189BCC7A0-0x0000000189BCC7E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAttackEvent> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D34400-0x0000000180D34900
    [BlackList] // 0x0000000189BD6960-0x0000000189BD69B0
                // [IDTag] // 0x0000000189BD6960-0x0000000189BD69B0
                // [XID] // 0x0000000189BD6960-0x0000000189BD69B0
    public static bool DictFromJson(JSONNode node, out Dictionary<TargetType, ConfigAttackInfo> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBBBA0-0x0000000180CBBF20
      // [IDTag] // 0x00000001895E9870-0x00000001895E98B0
      // [XID] // 0x00000001895E9870-0x00000001895E98B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<TargetType, ConfigAttackInfo> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF9660-0x0000000180CF9C60
    [BlackList] // 0x00000001895F3ED0-0x00000001895F3F20
                // [IDTag] // 0x00000001895F3ED0-0x00000001895F3F20
                // [XID] // 0x00000001895F3ED0-0x00000001895F3F20
    public static bool EnumStrToVal(string str, out CombatPropertyIndex e)
    {
        e = default;
        return default;
    } // 0x0000000180D50700-0x0000000180D50A40
    [BlackList] // 0x0000000189601860-0x00000001896018B0
                // [IDTag] // 0x0000000189601860-0x00000001896018B0
                // [XID] // 0x0000000189601860-0x00000001896018B0
    public static bool ArrayFromJson(JSONNode node, out CombatPropertyIndex[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA88B0-0x0000000180DA8C30
      // [IDTag] // 0x000000018960F100-0x000000018960F140
      // [XID] // 0x000000018960F100-0x000000018960F140
    private static bool InternalArrayFromJson(JSONNode node, out CombatPropertyIndex[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D81CF0-0x0000000180D81FB0
    [BlackList] // 0x0000000189619800-0x0000000189619850
                // [IDTag] // 0x0000000189619800-0x0000000189619850
                // [XID] // 0x0000000189619800-0x0000000189619850
    public static bool ArrayFromJson(JSONNode node, out ShakeByAinmator[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA9A30-0x0000000180DA9DB0
      // [IDTag] // 0x0000000189626BC0-0x0000000189626C00
      // [XID] // 0x0000000189626BC0-0x0000000189626C00
    private static bool InternalArrayFromJson(JSONNode node, out ShakeByAinmator[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7E180-0x0000000180D7E430
    [BlackList] // 0x00000001896315C0-0x0000000189631610
                // [IDTag] // 0x00000001896315C0-0x0000000189631610
                // [XID] // 0x00000001896315C0-0x0000000189631610
    public static bool ArrayFromJson(JSONNode node, out ConfigSummonTag[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB9D30-0x0000000180DBA0B0
      // [IDTag] // 0x000000018963ED20-0x000000018963ED60
      // [XID] // 0x000000018963ED20-0x000000018963ED60
    private static bool InternalArrayFromJson(JSONNode node, out ConfigSummonTag[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D82CF0-0x0000000180D82FA0
    [BlackList] // 0x0000000189649710-0x0000000189649760
                // [IDTag] // 0x0000000189649710-0x0000000189649760
                // [XID] // 0x0000000189649710-0x0000000189649760
    public static bool EnumStrToVal(string str, out ParticleShapeType e)
    {
        e = default;
        return default;
    } // 0x0000000180D75680-0x0000000180D75810
    [BlackList] // 0x0000000189656E40-0x0000000189656E90
                // [IDTag] // 0x0000000189656E40-0x0000000189656E90
                // [XID] // 0x0000000189656E40-0x0000000189656E90
    public static bool EnumStrToVal(string str, out BillboardOffsetType e)
    {
        e = default;
        return default;
    } // 0x0000000180D49C30-0x0000000180D49D70
    [BlackList] // 0x0000000189664310-0x0000000189664360
                // [IDTag] // 0x0000000189664310-0x0000000189664360
                // [XID] // 0x0000000189664310-0x0000000189664360
    public static bool EnumStrToVal(string str, out CombatBillboardSize e)
    {
        e = default;
        return default;
    } // 0x0000000180D69650-0x0000000180D69820
    [BlackList] // 0x0000000189672220-0x0000000189672270
                // [IDTag] // 0x0000000189672220-0x0000000189672270
                // [XID] // 0x0000000189672220-0x0000000189672270
    public static bool EnumStrToVal(string str, out ComponentTag e)
    {
        e = default;
        return default;
    } // 0x0000000180D4D340-0x0000000180D4DAF0
    [BlackList] // 0x000000018967F960-0x000000018967F9B0
                // [IDTag] // 0x000000018967F960-0x000000018967F9B0
                // [XID] // 0x000000018967F960-0x000000018967F9B0
    public static bool ArrayFromJson(JSONNode node, out ComponentTag[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB29B0-0x0000000180DB2D30
      // [IDTag] // 0x000000018968D0E0-0x000000018968D120
      // [XID] // 0x000000018968D0E0-0x000000018968D120
    private static bool InternalArrayFromJson(JSONNode node, out ComponentTag[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D949B0-0x0000000180D94C70
    [BlackList] // 0x0000000189697F90-0x0000000189697FE0
                // [IDTag] // 0x0000000189697F90-0x0000000189697FE0
                // [XID] // 0x0000000189697F90-0x0000000189697FE0
    public static bool EnumStrToVal(string str, out PlayMode e)
    {
        e = default;
        return default;
    } // 0x0000000180D61330-0x0000000180D61540
    [BlackList] // 0x00000001896A4ED0-0x00000001896A4F20
                // [IDTag] // 0x00000001896A4ED0-0x00000001896A4F20
                // [XID] // 0x00000001896A4ED0-0x00000001896A4F20
    public static bool EnumStrToVal(string str, out LogicType e)
    {
        e = default;
        return default;
    } // 0x0000000180D65FD0-0x0000000180D66340
    [BlackList] // 0x00000001896B1E80-0x00000001896B1ED0
                // [IDTag] // 0x00000001896B1E80-0x00000001896B1ED0
                // [XID] // 0x00000001896B1E80-0x00000001896B1ED0
    public static bool EnumStrToVal(string str, out BanGroupType e)
    {
        e = default;
        return default;
    } // 0x0000000180D51B00-0x0000000180D51D10
    [BlackList] // 0x00000001896BF300-0x00000001896BF350
                // [IDTag] // 0x00000001896BF300-0x00000001896BF350
                // [XID] // 0x00000001896BF300-0x00000001896BF350
    public static bool EnumStrToVal(string str, out BanType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4D130-0x0000000180D4D340
    [BlackList] // 0x00000001896CCA00-0x00000001896CCA50
                // [IDTag] // 0x00000001896CCA00-0x00000001896CCA50
                // [XID] // 0x00000001896CCA00-0x00000001896CCA50
    public static bool EnumStrToVal(string str, out OrderingType e)
    {
        e = default;
        return default;
    } // 0x0000000180D49810-0x0000000180D49A20
    [BlackList] // 0x00000001896DA190-0x00000001896DA1E0
                // [IDTag] // 0x00000001896DA190-0x00000001896DA1E0
                // [XID] // 0x00000001896DA190-0x00000001896DA1E0
    public static bool EnumStrToVal(string str, out NPCBodyType e)
    {
        e = default;
        return default;
    } // 0x0000000180D460E0-0x0000000180D465C0
    [BlackList] // 0x00000001896E7360-0x00000001896E73B0
                // [IDTag] // 0x00000001896E7360-0x00000001896E73B0
                // [XID] // 0x00000001896E7360-0x00000001896E73B0
    public static bool EnumStrToVal(string str, out CoopCondType e)
    {
        e = default;
        return default;
    } // 0x0000000180D44570-0x0000000180D448E0
    [BlackList] // 0x00000001896F4A10-0x00000001896F4A60
                // [IDTag] // 0x00000001896F4A10-0x00000001896F4A60
                // [XID] // 0x00000001896F4A10-0x00000001896F4A60
    public static bool EnumStrToVal(string str, out CoopTemperamentType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5E480-0x0000000180D5E650
    [BlackList] // 0x0000000189701FA0-0x0000000189701FF0
                // [IDTag] // 0x0000000189701FA0-0x0000000189701FF0
                // [XID] // 0x0000000189701FA0-0x0000000189701FF0
    public static bool EnumStrToVal(string str, out CoopActionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D71920-0x0000000180D71C90
    [BlackList] // 0x000000018970F8E0-0x000000018970F930
                // [IDTag] // 0x000000018970F8E0-0x000000018970F930
                // [XID] // 0x000000018970F8E0-0x000000018970F930
    public static bool EnumStrToVal(string str, out CoopNodeType e)
    {
        e = default;
        return default;
    } // 0x0000000180D49480-0x0000000180D496D0
    [BlackList] // 0x000000018971CE40-0x000000018971CE90
                // [IDTag] // 0x000000018971CE40-0x000000018971CE90
                // [XID] // 0x000000018971CE40-0x000000018971CE90
    public static bool ArrayFromJson(JSONNode node, out CoopCond[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA96B0-0x0000000180DA9A30
      // [IDTag] // 0x000000018972A220-0x000000018972A260
      // [XID] // 0x000000018972A220-0x000000018972A260
    private static bool InternalArrayFromJson(JSONNode node, out CoopCond[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7CC00-0x0000000180D7CEB0
    [BlackList] // 0x0000000189734930-0x0000000189734980
                // [IDTag] // 0x0000000189734930-0x0000000189734980
                // [XID] // 0x0000000189734930-0x0000000189734980
    public static bool ArrayFromJson(JSONNode node, out ConfigCoopAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBAB30-0x0000000180DBAEB0
      // [IDTag] // 0x0000000189742140-0x0000000189742180
      // [XID] // 0x0000000189742140-0x0000000189742180
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCoopAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7A680-0x0000000180D7A930
    [BlackList] // 0x000000018974CE00-0x000000018974CE50
                // [IDTag] // 0x000000018974CE00-0x000000018974CE50
                // [XID] // 0x000000018974CE00-0x000000018974CE50
    public static bool ArrayFromJson(JSONNode node, out CoopSelectNodeContent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC8430-0x0000000180DC87B0
      // [IDTag] // 0x0000000189759DA0-0x0000000189759DE0
      // [XID] // 0x0000000189759DA0-0x0000000189759DE0
    private static bool InternalArrayFromJson(JSONNode node, out CoopSelectNodeContent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7EF20-0x0000000180D7F1D0
    [BlackList] // 0x0000000189764680-0x00000001897646D0
                // [IDTag] // 0x0000000189764680-0x00000001897646D0
                // [XID] // 0x0000000189764680-0x00000001897646D0
    public static bool DictFromJson(JSONNode node, out Dictionary<CoopTemperamentType, CoopTemperament> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDEF20-0x0000000180CDF2A0
      // [IDTag] // 0x0000000189771DD0-0x0000000189771E10
      // [XID] // 0x0000000189771DD0-0x0000000189771E10
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<CoopTemperamentType, CoopTemperament> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D10CA0-0x0000000180D112A0
    [BlackList] // 0x000000018977C3A0-0x000000018977C3F0
                // [IDTag] // 0x000000018977C3A0-0x000000018977C3F0
                // [XID] // 0x000000018977C3A0-0x000000018977C3F0
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ConfigCoopBaseNode> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD04A0-0x0000000180CD0820
      // [IDTag] // 0x0000000189789A00-0x0000000189789A40
      // [XID] // 0x0000000189789A00-0x0000000189789A40
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ConfigCoopBaseNode> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2B740-0x0000000180D2BCE0
    [BlackList] // 0x0000000189793E60-0x0000000189793EB0
                // [IDTag] // 0x0000000189793E60-0x0000000189793EB0
                // [XID] // 0x0000000189793E60-0x0000000189793EB0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigCoopBaseNode> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDEBA0-0x0000000180CDEF20
      // [IDTag] // 0x00000001897A1EC0-0x00000001897A1F00
      // [XID] // 0x00000001897A1EC0-0x00000001897A1F00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigCoopBaseNode> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D063A0-0x0000000180D069B0
    [BlackList] // 0x00000001897AC690-0x00000001897AC6E0
                // [IDTag] // 0x00000001897AC690-0x00000001897AC6E0
                // [XID] // 0x00000001897AC690-0x00000001897AC6E0
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ConfigCoopInteractionGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD4020-0x0000000180CD43A0
      // [IDTag] // 0x00000001897BA0B0-0x00000001897BA0F0
      // [XID] // 0x00000001897BA0B0-0x00000001897BA0F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ConfigCoopInteractionGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFA860-0x0000000180CFAE30
    [BlackList] // 0x00000001897C5200-0x00000001897C5250
                // [IDTag] // 0x00000001897C5200-0x00000001897C5250
                // [XID] // 0x00000001897C5200-0x00000001897C5250
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigCoopInteractionGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD7F20-0x0000000180CD82A0
      // [IDTag] // 0x00000001897D2940-0x00000001897D2980
      // [XID] // 0x00000001897D2940-0x00000001897D2980
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigCoopInteractionGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1FF20-0x0000000180D20550
    [BlackList] // 0x00000001897DD130-0x00000001897DD180
                // [IDTag] // 0x00000001897DD130-0x00000001897DD180
                // [XID] // 0x00000001897DD130-0x00000001897DD180
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, CoopSubStartPoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDF9A0-0x0000000180CDFD20
      // [IDTag] // 0x00000001897EAB20-0x00000001897EAB60
      // [XID] // 0x00000001897EAB20-0x00000001897EAB60
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, CoopSubStartPoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF2D90-0x0000000180CF3360
    [BlackList] // 0x00000001897F5530-0x00000001897F5580
                // [IDTag] // 0x00000001897F5530-0x00000001897F5580
                // [XID] // 0x00000001897F5530-0x00000001897F5580
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, CoopSubStartPoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC8DA0-0x0000000180CC9120
      // [IDTag] // 0x0000000189802E00-0x0000000189802E40
      // [XID] // 0x0000000189802E00-0x0000000189802E40
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, CoopSubStartPoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF4390-0x0000000180CF49C0
    [BlackList] // 0x000000018980D160-0x000000018980D1B0
                // [IDTag] // 0x000000018980D160-0x000000018980D1B0
                // [XID] // 0x000000018980D160-0x000000018980D1B0
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, CoopSavePoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE6D20-0x0000000180CE70A0
      // [IDTag] // 0x000000018981AC70-0x000000018981ACB0
      // [XID] // 0x000000018981AC70-0x000000018981ACB0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, CoopSavePoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D16FF0-0x0000000180D175C0
    [BlackList] // 0x0000000189824FC0-0x0000000189825010
                // [IDTag] // 0x0000000189824FC0-0x0000000189825010
                // [XID] // 0x0000000189824FC0-0x0000000189825010
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, CoopSavePoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC5CA0-0x0000000180CC6020
      // [IDTag] // 0x0000000189832670-0x00000001898326B0
      // [XID] // 0x0000000189832670-0x00000001898326B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, CoopSavePoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFD850-0x0000000180CFDE80
    [BlackList] // 0x000000018983CE50-0x000000018983CEA0
                // [IDTag] // 0x000000018983CE50-0x000000018983CEA0
                // [XID] // 0x000000018983CE50-0x000000018983CEA0
    public static bool ArrayFromJson(JSONNode node, out QuestState[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAD930-0x0000000180DADCB0
      // [IDTag] // 0x000000018984A0F0-0x000000018984A130
      // [XID] // 0x000000018984A0F0-0x000000018984A130
    private static bool InternalArrayFromJson(JSONNode node, out QuestState[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D88D60-0x0000000180D89020
    [BlackList] // 0x0000000189854220-0x0000000189854270
                // [IDTag] // 0x0000000189854220-0x0000000189854270
                // [XID] // 0x0000000189854220-0x0000000189854270
    public static bool ArrayFromJson(JSONNode node, out ConfigCrowdQuestRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB61B0-0x0000000180DB6530
      // [IDTag] // 0x0000000189861630-0x0000000189861670
      // [XID] // 0x0000000189861630-0x0000000189861670
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCrowdQuestRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D87D60-0x0000000180D88010
    [BlackList] // 0x000000018986BD80-0x000000018986BDD0
                // [IDTag] // 0x000000018986BD80-0x000000018986BDD0
                // [XID] // 0x000000018986BD80-0x000000018986BDD0
    public static bool ArrayFromJson(JSONNode node, out ConfigCrowdActivityRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC4530-0x0000000180DC48B0
      // [IDTag] // 0x0000000189879330-0x0000000189879370
      // [XID] // 0x0000000189879330-0x0000000189879370
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCrowdActivityRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7ABE0-0x0000000180D7AE90
    [BlackList] // 0x0000000189883450-0x00000001898834A0
                // [IDTag] // 0x0000000189883450-0x00000001898834A0
                // [XID] // 0x0000000189883450-0x00000001898834A0
    public static bool ArrayFromJson(JSONNode node, out ConfigCrowdTimeRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB92B0-0x0000000180DB9630
      // [IDTag] // 0x0000000189890920-0x0000000189890960
      // [XID] // 0x0000000189890920-0x0000000189890960
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCrowdTimeRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9DCF0-0x0000000180D9DFA0
    [BlackList] // 0x000000018989B0B0-0x000000018989B100
                // [IDTag] // 0x000000018989B0B0-0x000000018989B100
                // [XID] // 0x000000018989B0B0-0x000000018989B100
    public static bool ArrayFromJson(JSONNode node, out ConfigCrowdSceneTagRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB1130-0x0000000180DB14B0
      // [IDTag] // 0x00000001898A81F0-0x00000001898A8230
      // [XID] // 0x00000001898A81F0-0x00000001898A8230
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCrowdSceneTagRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D82FA0-0x0000000180D83250
    [BlackList] // 0x00000001898B2990-0x00000001898B29E0
                // [IDTag] // 0x00000001898B2990-0x00000001898B29E0
                // [XID] // 0x00000001898B2990-0x00000001898B29E0
    public static bool EnumStrToVal(string str, out CrowdSpawnConditionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D70F60-0x0000000180D710A0
    [BlackList] // 0x00000001898C0380-0x00000001898C03D0
                // [IDTag] // 0x00000001898C0380-0x00000001898C03D0
                // [XID] // 0x00000001898C0380-0x00000001898C03D0
    public static bool ArrayFromJson(JSONNode node, out ConfigCrowdRestrictionGroup[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCB530-0x0000000180DCB8B0
      // [IDTag] // 0x00000001898CD940-0x00000001898CD980
      // [XID] // 0x00000001898CD940-0x00000001898CD980
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCrowdRestrictionGroup[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D79110-0x0000000180D793C0
    [BlackList] // 0x00000001898D8280-0x00000001898D82D0
                // [IDTag] // 0x00000001898D8280-0x00000001898D82D0
                // [XID] // 0x00000001898D8280-0x00000001898D82D0
    public static bool ArrayFromJson(JSONNode node, out ConfigCrowdGroupInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB84B0-0x0000000180DB8830
      // [IDTag] // 0x00000001898E60C0-0x00000001898E6100
      // [XID] // 0x00000001898E60C0-0x00000001898E6100
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCrowdGroupInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D90120-0x0000000180D903D0
    [BlackList] // 0x00000001898F0B20-0x00000001898F0B70
                // [IDTag] // 0x00000001898F0B20-0x00000001898F0B70
                // [XID] // 0x00000001898F0B20-0x00000001898F0B70
    public static bool ArrayFromJson(JSONNode node, out ColorVector[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DADCB0-0x0000000180DAE030
      // [IDTag] // 0x00000001898FE280-0x00000001898FE2C0
      // [XID] // 0x00000001898FE280-0x00000001898FE2C0
    private static bool InternalArrayFromJson(JSONNode node, out ColorVector[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7DED0-0x0000000180D7E180
    [BlackList] // 0x0000000189908B90-0x0000000189908BE0
                // [IDTag] // 0x0000000189908B90-0x0000000189908BE0
                // [XID] // 0x0000000189908B90-0x0000000189908BE0
    public static bool ArrayFromJson(JSONNode node, out ConfigCrowdSpawnInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC6BB0-0x0000000180DC6F30
      // [IDTag] // 0x0000000189916440-0x0000000189916480
      // [XID] // 0x0000000189916440-0x0000000189916480
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCrowdSpawnInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9B220-0x0000000180D9B4D0
    [BlackList] // 0x0000000189920B90-0x0000000189920BE0
                // [IDTag] // 0x0000000189920B90-0x0000000189920BE0
                // [XID] // 0x0000000189920B90-0x0000000189920BE0
    public static bool ArrayFromJson(JSONNode node, out ConfigCrowdGroupColliderInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA0AB0-0x0000000180DA0E30
      // [IDTag] // 0x000000018992E570-0x000000018992E5B0
      // [XID] // 0x000000018992E570-0x000000018992E5B0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCrowdGroupColliderInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D916D0-0x0000000180D91980
    [BlackList] // 0x0000000189938910-0x0000000189938960
                // [IDTag] // 0x0000000189938910-0x0000000189938960
                // [XID] // 0x0000000189938910-0x0000000189938960
    public static bool EnumStrToVal(string str, out CutsceneType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5FB30-0x0000000180D5FD40
    [BlackList] // 0x0000000189946240-0x0000000189946290
                // [IDTag] // 0x0000000189946240-0x0000000189946290
                // [XID] // 0x0000000189946240-0x0000000189946290
    public static bool EnumStrToVal(string str, out CutsceneInitPosType e)
    {
        e = default;
        return default;
    } // 0x0000000180D49A20-0x0000000180D49C30
    [BlackList] // 0x0000000189953710-0x0000000189953760
                // [IDTag] // 0x0000000189953710-0x0000000189953760
                // [XID] // 0x0000000189953710-0x0000000189953760
    public static bool EnumStrToVal(string str, out CutsceneIndexType e)
    {
        e = default;
        return default;
    } // 0x0000000180D69EB0-0x0000000180D6A040
    [BlackList] // 0x0000000189960FC0-0x0000000189961010
                // [IDTag] // 0x0000000189960FC0-0x0000000189961010
                // [XID] // 0x0000000189960FC0-0x0000000189961010
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigCutsceneContext> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE85A0-0x0000000180CE8920
      // [IDTag] // 0x000000018996E400-0x000000018996E440
      // [XID] // 0x000000018996E400-0x000000018996E440
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigCutsceneContext> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFF920-0x0000000180CFFEF0
    [BlackList] // 0x0000000189979510-0x0000000189979560
                // [IDTag] // 0x0000000189979510-0x0000000189979560
                // [XID] // 0x0000000189979510-0x0000000189979560
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigCutsceneContext> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDA920-0x0000000180CDACA0
      // [IDTag] // 0x0000000189986570-0x00000001899865B0
      // [XID] // 0x0000000189986570-0x00000001899865B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigCutsceneContext> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D20B70-0x0000000180D211A0
    [BlackList] // 0x0000000189991370-0x00000001899913C0
                // [IDTag] // 0x0000000189991370-0x00000001899913C0
                // [XID] // 0x0000000189991370-0x00000001899913C0
    public static bool ArrayFromJson(JSONNode node, out DebugBoardInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC4C30-0x0000000180DC4FB0
      // [IDTag] // 0x000000018999EF30-0x000000018999EF70
      // [XID] // 0x000000018999EF30-0x000000018999EF70
    private static bool InternalArrayFromJson(JSONNode node, out DebugBoardInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7E430-0x0000000180D7E6F0
    [BlackList] // 0x00000001899A98A0-0x00000001899A98F0
                // [IDTag] // 0x00000001899A98A0-0x00000001899A98F0
                // [XID] // 0x00000001899A98A0-0x00000001899A98F0
    public static bool ArrayFromJson(JSONNode node, out DebugBlletinInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA4D30-0x0000000180DA50B0
      // [IDTag] // 0x00000001899B6E30-0x00000001899B6E70
      // [XID] // 0x00000001899B6E30-0x00000001899B6E70
    private static bool InternalArrayFromJson(JSONNode node, out DebugBlletinInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D99FA0-0x0000000180D9A230
    [BlackList] // 0x00000001899C18D0-0x00000001899C1920
                // [IDTag] // 0x00000001899C18D0-0x00000001899C1920
                // [XID] // 0x00000001899C18D0-0x00000001899C1920
    public static bool ArrayFromJson(JSONNode node, out bool[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC56B0-0x0000000180DC5A30
      // [IDTag] // 0x00000001899CF060-0x00000001899CF0A0
      // [XID] // 0x00000001899CF060-0x00000001899CF0A0
    private static bool InternalArrayFromJson(JSONNode node, out bool[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D89580-0x0000000180D89830
    [BlackList] // 0x00000001899D9490-0x00000001899D94E0
                // [IDTag] // 0x00000001899D9490-0x00000001899D94E0
                // [XID] // 0x00000001899D9490-0x00000001899D94E0
    public static bool ArrayFromJson(JSONNode node, out double[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC5DB0-0x0000000180DC6130
      // [IDTag] // 0x00000001899E6E90-0x00000001899E6ED0
      // [XID] // 0x00000001899E6E90-0x00000001899E6ED0
    private static bool InternalArrayFromJson(JSONNode node, out double[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9CCC0-0x0000000180D9CF80
    [BlackList] // 0x00000001899F1290-0x00000001899F12E0
                // [IDTag] // 0x00000001899F1290-0x00000001899F12E0
                // [XID] // 0x00000001899F1290-0x00000001899F12E0
    public static bool ArrayFromJson(JSONNode node, out int[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCD4B0-0x0000000180DCD830
      // [IDTag] // 0x00000001899FEBF0-0x00000001899FEC30
      // [XID] // 0x00000001899FEBF0-0x00000001899FEC30
    private static bool InternalArrayFromJson(JSONNode node, out int[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7F1D0-0x0000000180D7F470
    [BlackList] // 0x0000000189A091F0-0x0000000189A09240
                // [IDTag] // 0x0000000189A091F0-0x0000000189A09240
                // [XID] // 0x0000000189A091F0-0x0000000189A09240
    public static bool ArrayFromJson(JSONNode node, out SimpleSafeInt32[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBE330-0x0000000180DBE6B0
      // [IDTag] // 0x0000000189A16560-0x0000000189A165A0
      // [XID] // 0x0000000189A16560-0x0000000189A165A0
    private static bool InternalArrayFromJson(JSONNode node, out SimpleSafeInt32[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D91400-0x0000000180D916D0
    [BlackList] // 0x0000000189A20AE0-0x0000000189A20B30
                // [IDTag] // 0x0000000189A20AE0-0x0000000189A20B30
                // [XID] // 0x0000000189A20AE0-0x0000000189A20B30
    public static bool ArrayFromJson(JSONNode node, out uint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBDFB0-0x0000000180DBE330
      // [IDTag] // 0x0000000189A2DBF0-0x0000000189A2DC30
      // [XID] // 0x0000000189A2DBF0-0x0000000189A2DC30
    private static bool InternalArrayFromJson(JSONNode node, out uint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8E3B0-0x0000000180D8E650
    [BlackList] // 0x0000000189A38710-0x0000000189A38760
                // [IDTag] // 0x0000000189A38710-0x0000000189A38760
                // [XID] // 0x0000000189A38710-0x0000000189A38760
    public static bool ArrayFromJson(JSONNode node, out SimpleSafeUInt32[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB22B0-0x0000000180DB2630
      // [IDTag] // 0x0000000189A45D70-0x0000000189A45DB0
      // [XID] // 0x0000000189A45D70-0x0000000189A45DB0
    private static bool InternalArrayFromJson(JSONNode node, out SimpleSafeUInt32[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D96750-0x0000000180D96A20
    [BlackList] // 0x0000000189A50570-0x0000000189A505C0
                // [IDTag] // 0x0000000189A50570-0x0000000189A505C0
                // [XID] // 0x0000000189A50570-0x0000000189A505C0
    public static bool ArrayFromJson(JSONNode node, out float[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA2A30-0x0000000180DA2DB0
      // [IDTag] // 0x0000000189A5DED0-0x0000000189A5DF10
      // [XID] // 0x0000000189A5DED0-0x0000000189A5DF10
    private static bool InternalArrayFromJson(JSONNode node, out float[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7F730-0x0000000180D7F9F0
    [BlackList] // 0x0000000189A68B00-0x0000000189A68B50
                // [IDTag] // 0x0000000189A68B00-0x0000000189A68B50
                // [XID] // 0x0000000189A68B00-0x0000000189A68B50
    public static bool ArrayFromJson(JSONNode node, out SimpleSafeFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DABD30-0x0000000180DAC0B0
      // [IDTag] // 0x0000000189A75EA0-0x0000000189A75EE0
      // [XID] // 0x0000000189A75EA0-0x0000000189A75EE0
    private static bool InternalArrayFromJson(JSONNode node, out SimpleSafeFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8B5D0-0x0000000180D8B8B0
    [BlackList] // 0x0000000189A805B0-0x0000000189A80600
                // [IDTag] // 0x0000000189A805B0-0x0000000189A80600
                // [XID] // 0x0000000189A805B0-0x0000000189A80600
    public static bool ArrayFromJson(JSONNode node, out string[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBB230-0x0000000180DBB5B0
      // [IDTag] // 0x0000000189A8E3A0-0x0000000189A8E3E0
      // [XID] // 0x0000000189A8E3A0-0x0000000189A8E3E0
    private static bool InternalArrayFromJson(JSONNode node, out string[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9CA10-0x0000000180D9CCC0
    [BlackList] // 0x0000000189A98C70-0x0000000189A98CC0
                // [IDTag] // 0x0000000189A98C70-0x0000000189A98CC0
                // [XID] // 0x0000000189A98C70-0x0000000189A98CC0
    public static bool ArrayFromJson(JSONNode node, out ulong[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAA130-0x0000000180DAA4B0
      // [IDTag] // 0x0000000189AA5F50-0x0000000189AA5F90
      // [XID] // 0x0000000189AA5F50-0x0000000189AA5F90
    private static bool InternalArrayFromJson(JSONNode node, out ulong[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8F130-0x0000000180D8F3D0
    [BlackList] // 0x0000000189AB0770-0x0000000189AB07C0
                // [IDTag] // 0x0000000189AB0770-0x0000000189AB07C0
                // [XID] // 0x0000000189AB0770-0x0000000189AB07C0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, int> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD66A0-0x0000000180CD6A20
      // [IDTag] // 0x0000000189ABE260-0x0000000189ABE2A0
      // [XID] // 0x0000000189ABE260-0x0000000189ABE2A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, int> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF18C0-0x0000000180CF1DC0
    [BlackList] // 0x0000000189AC8A00-0x0000000189AC8A50
                // [IDTag] // 0x0000000189AC8A00-0x0000000189AC8A50
                // [XID] // 0x0000000189AC8A00-0x0000000189AC8A50
    public static bool DictFromJson(JSONNode node, out Dictionary<string, SimpleSafeInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBAA20-0x0000000180CBADA0
      // [IDTag] // 0x0000000189AD6890-0x0000000189AD68D0
      // [XID] // 0x0000000189AD6890-0x0000000189AD68D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, SimpleSafeInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1B900-0x0000000180D1BE30
    [BlackList] // 0x0000000189AE11F0-0x0000000189AE1240
                // [IDTag] // 0x0000000189AE11F0-0x0000000189AE1240
                // [XID] // 0x0000000189AE11F0-0x0000000189AE1240
    public static bool DictFromJson(JSONNode node, out Dictionary<string, float> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB67A0-0x0000000180CB6B20
      // [IDTag] // 0x0000000189AEEE80-0x0000000189AEEEC0
      // [XID] // 0x0000000189AEEE80-0x0000000189AEEEC0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, float> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D259D0-0x0000000180D25ED0
    [BlackList] // 0x0000000189AF9470-0x0000000189AF94C0
                // [IDTag] // 0x0000000189AF9470-0x0000000189AF94C0
                // [XID] // 0x0000000189AF9470-0x0000000189AF94C0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, SimpleSafeFloat> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC9F20-0x0000000180CCA2A0
      // [IDTag] // 0x0000000189B06960-0x0000000189B069A0
      // [XID] // 0x0000000189B06960-0x0000000189B069A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, SimpleSafeFloat> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D05250-0x0000000180D05790
    [BlackList] // 0x0000000189B11250-0x0000000189B112A0
                // [IDTag] // 0x0000000189B11250-0x0000000189B112A0
                // [XID] // 0x0000000189B11250-0x0000000189B112A0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE5120-0x0000000180CE54A0
      // [IDTag] // 0x0000000189B1E250-0x0000000189B1E290
      // [XID] // 0x0000000189B1E250-0x0000000189B1E290
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D35400-0x0000000180D35900
    [BlackList] // 0x0000000189B288B0-0x0000000189B28900
                // [IDTag] // 0x0000000189B288B0-0x0000000189B28900
                // [XID] // 0x0000000189B288B0-0x0000000189B28900
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, uint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCEC20-0x0000000180CCEFA0
      // [IDTag] // 0x0000000189B35A30-0x0000000189B35A70
      // [XID] // 0x0000000189B35A30-0x0000000189B35A70
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, uint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2DF80-0x0000000180D2E550
    [BlackList] // 0x0000000189B405C0-0x0000000189B40610
                // [IDTag] // 0x0000000189B405C0-0x0000000189B40610
                // [XID] // 0x0000000189B405C0-0x0000000189B40610
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBB4A0-0x0000000180CBB820
      // [IDTag] // 0x0000000189B4DEA0-0x0000000189B4DEE0
      // [XID] // 0x0000000189B4DEA0-0x0000000189B4DEE0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF02B0-0x0000000180CF08F0
    [BlackList] // 0x0000000189B58870-0x0000000189B588C0
                // [IDTag] // 0x0000000189B58870-0x0000000189B588C0
                // [XID] // 0x0000000189B58870-0x0000000189B588C0
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, int[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCBB20-0x0000000180CCBEA0
      // [IDTag] // 0x0000000189B65F80-0x0000000189B65FC0
      // [XID] // 0x0000000189B65F80-0x0000000189B65FC0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, int[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0A140-0x0000000180D0A710
    [BlackList] // 0x0000000189B70540-0x0000000189B70590
                // [IDTag] // 0x0000000189B70540-0x0000000189B70590
                // [XID] // 0x0000000189B70540-0x0000000189B70590
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, SimpleSafeInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDC1A0-0x0000000180CDC520
      // [IDTag] // 0x0000000189B7D860-0x0000000189B7D8A0
      // [XID] // 0x0000000189B7D860-0x0000000189B7D8A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, SimpleSafeInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D3A360-0x0000000180D3A990
    [BlackList] // 0x0000000189B88240-0x0000000189B88290
                // [IDTag] // 0x0000000189B88240-0x0000000189B88290
                // [XID] // 0x0000000189B88240-0x0000000189B88290
    public static bool DictFromJson(JSONNode node, out Dictionary<int, string[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD51A0-0x0000000180CD5520
      // [IDTag] // 0x0000000189B95230-0x0000000189B95270
      // [XID] // 0x0000000189B95230-0x0000000189B95270
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, string[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEBC00-0x0000000180CEC1D0
    [BlackList] // 0x0000000189B9F6F0-0x0000000189B9F740
                // [IDTag] // 0x0000000189B9F6F0-0x0000000189B9F740
                // [XID] // 0x0000000189B9F6F0-0x0000000189B9F740
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, string[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBF720-0x0000000180CBFAA0
      // [IDTag] // 0x0000000189BACB30-0x0000000189BACB70
      // [XID] // 0x0000000189BACB30-0x0000000189BACB70
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, string[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D163C0-0x0000000180D169F0
    [BlackList] // 0x0000000189BB70B0-0x0000000189BB7100
                // [IDTag] // 0x0000000189BB70B0-0x0000000189BB7100
                // [XID] // 0x0000000189BB70B0-0x0000000189BB7100
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, Dictionary<int, string[]>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC6720-0x0000000180CC6AA0
      // [IDTag] // 0x0000000189BC4CC0-0x0000000189BC4D00
      // [XID] // 0x0000000189BC4CC0-0x0000000189BC4D00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, Dictionary<int, string[]>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D24800-0x0000000180D24DD0
    [BlackList] // 0x0000000189BCF620-0x0000000189BCF670
                // [IDTag] // 0x0000000189BCF620-0x0000000189BCF670
                // [XID] // 0x0000000189BCF620-0x0000000189BCF670
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, Dictionary<SimpleSafeInt32, string[]>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBF020-0x0000000180CBF3A0
      // [IDTag] // 0x0000000189BDD010-0x0000000189BDD050
      // [XID] // 0x0000000189BDD010-0x0000000189BDD050
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, Dictionary<SimpleSafeInt32, string[]>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1CA30-0x0000000180D1D060
    [BlackList] // 0x00000001895EC970-0x00000001895EC9C0
                // [IDTag] // 0x00000001895EC970-0x00000001895EC9C0
                // [XID] // 0x00000001895EC970-0x00000001895EC9C0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, string[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC71A0-0x0000000180CC7520
      // [IDTag] // 0x00000001895FA0C0-0x00000001895FA100
      // [XID] // 0x00000001895FA0C0-0x00000001895FA100
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, string[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1D670-0x0000000180D1DB70
    [BlackList] // 0x00000001896048F0-0x0000000189604940
                // [IDTag] // 0x00000001896048F0-0x0000000189604940
                // [XID] // 0x00000001896048F0-0x0000000189604940
    public static bool DictFromJson(JSONNode node, out Dictionary<string, uint[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB9C20-0x0000000180CB9FA0
      // [IDTag] // 0x0000000189611F20-0x0000000189611F60
      // [XID] // 0x0000000189611F20-0x0000000189611F60
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, uint[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF2890-0x0000000180CF2D90
    [BlackList] // 0x000000018961C7C0-0x000000018961C810
                // [IDTag] // 0x000000018961C7C0-0x000000018961C810
                // [XID] // 0x000000018961C7C0-0x000000018961C810
    public static bool DictFromJson(JSONNode node, out Dictionary<string, SimpleSafeUInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB8AA0-0x0000000180CB8E20
      // [IDTag] // 0x0000000189629E30-0x0000000189629E70
      // [XID] // 0x0000000189629E30-0x0000000189629E70
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, SimpleSafeUInt32[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D29C70-0x0000000180D2A170
    [BlackList] // 0x0000000189634890-0x00000001896348E0
                // [IDTag] // 0x0000000189634890-0x00000001896348E0
                // [XID] // 0x0000000189634890-0x00000001896348E0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, Dictionary<string, string>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBD7A0-0x0000000180CBDB20
      // [IDTag] // 0x0000000189641E20-0x0000000189641E60
      // [XID] // 0x0000000189641E20-0x0000000189641E60
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, Dictionary<string, string>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D34F00-0x0000000180D35400
    [BlackList] // 0x000000018964C830-0x000000018964C880
                // [IDTag] // 0x000000018964C830-0x000000018964C880
                // [XID] // 0x000000018964C830-0x000000018964C880
    public static bool DictFromJson(JSONNode node, out Dictionary<string, Dictionary<string, float>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE4A20-0x0000000180CE4DA0
      // [IDTag] // 0x0000000189659B90-0x0000000189659BD0
      // [XID] // 0x0000000189659B90-0x0000000189659BD0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, Dictionary<string, float>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF3360-0x0000000180CF3860
    [BlackList] // 0x00000001896642C0-0x0000000189664310
                // [IDTag] // 0x00000001896642C0-0x0000000189664310
                // [XID] // 0x00000001896642C0-0x0000000189664310
    public static bool DictFromJson(JSONNode node, out Dictionary<string, Dictionary<string, SimpleSafeFloat>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD0120-0x0000000180CD04A0
      // [IDTag] // 0x00000001896721E0-0x0000000189672220
      // [XID] // 0x00000001896721E0-0x0000000189672220
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, Dictionary<string, SimpleSafeFloat>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF0DF0-0x0000000180CF12F0
    [BlackList] // 0x000000018967C990-0x000000018967C9E0
                // [IDTag] // 0x000000018967C990-0x000000018967C9E0
                // [XID] // 0x000000018967C990-0x000000018967C9E0
    public static bool ArrayFromJson(JSONNode node, out string[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBB5B0-0x0000000180DBB930
      // [IDTag] // 0x000000018968A3A0-0x000000018968A3E0
      // [XID] // 0x000000018968A3A0-0x000000018968A3E0
    private static bool InternalArrayFromJson(JSONNode node, out string[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D91EF0-0x0000000180D921A0
    [BlackList] // 0x0000000189694D80-0x0000000189694DD0
                // [IDTag] // 0x0000000189694D80-0x0000000189694DD0
                // [XID] // 0x0000000189694D80-0x0000000189694DD0
    public static bool ArrayFromJson(JSONNode node, out DynamicFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB1F30-0x0000000180DB22B0
      // [IDTag] // 0x00000001896A2560-0x00000001896A25A0
      // [XID] // 0x00000001896A2560-0x00000001896A25A0
    private static bool InternalArrayFromJson(JSONNode node, out DynamicFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7A930-0x0000000180D7ABE0
    [BlackList] // 0x00000001896AC7A0-0x00000001896AC7F0
                // [IDTag] // 0x00000001896AC7A0-0x00000001896AC7F0
                // [XID] // 0x00000001896AC7A0-0x00000001896AC7F0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, DynamicFloat> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCB7A0-0x0000000180CCBB20
      // [IDTag] // 0x00000001896B9920-0x00000001896B9960
      // [XID] // 0x00000001896B9920-0x00000001896B9960
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, DynamicFloat> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF08F0-0x0000000180CF0DF0
    [BlackList] // 0x00000001896C3C30-0x00000001896C3C80
                // [IDTag] // 0x00000001896C3C30-0x00000001896C3C80
                // [XID] // 0x00000001896C3C30-0x00000001896C3C80
    public static bool ArrayFromJson(JSONNode node, out DynamicInt[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBEDB0-0x0000000180DBF130
      // [IDTag] // 0x00000001896D1070-0x00000001896D10B0
      // [XID] // 0x00000001896D1070-0x00000001896D10B0
    private static bool InternalArrayFromJson(JSONNode node, out DynamicInt[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D96A20-0x0000000180D96CD0
    [BlackList] // 0x00000001896DB660-0x00000001896DB6B0
                // [IDTag] // 0x00000001896DB660-0x00000001896DB6B0
                // [XID] // 0x00000001896DB660-0x00000001896DB6B0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, DynamicInt> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC63A0-0x0000000180CC6720
      // [IDTag] // 0x00000001896E8B20-0x00000001896E8B60
      // [XID] // 0x00000001896E8B20-0x00000001896E8B60
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, DynamicInt> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D00520-0x0000000180D00A20
    [BlackList] // 0x00000001896F3110-0x00000001896F3160
                // [IDTag] // 0x00000001896F3110-0x00000001896F3160
                // [XID] // 0x00000001896F3110-0x00000001896F3160
    public static bool ArrayFromJson(JSONNode node, out DynamicString[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCC6B0-0x0000000180DCCA30
      // [IDTag] // 0x0000000189700580-0x00000001897005C0
      // [XID] // 0x0000000189700580-0x00000001897005C0
    private static bool InternalArrayFromJson(JSONNode node, out DynamicString[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7C950-0x0000000180D7CC00
    [BlackList] // 0x000000018970AE00-0x000000018970AE50
                // [IDTag] // 0x000000018970AE00-0x000000018970AE50
                // [XID] // 0x000000018970AE00-0x000000018970AE50
    public static bool DictFromJson(JSONNode node, out Dictionary<string, DynamicString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDFD20-0x0000000180CE00A0
      // [IDTag] // 0x00000001897184D0-0x0000000189718510
      // [XID] // 0x00000001897184D0-0x0000000189718510
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, DynamicString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D12FC0-0x0000000180D134C0
    [BlackList] // 0x0000000189722B00-0x0000000189722B50
                // [IDTag] // 0x0000000189722B00-0x0000000189722B50
                // [XID] // 0x0000000189722B00-0x0000000189722B50
    public static bool EnumStrToVal(string str, out TriggerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D66F60-0x0000000180D670F0
    [BlackList] // 0x0000000189730240-0x0000000189730290
                // [IDTag] // 0x0000000189730240-0x0000000189730290
                // [XID] // 0x0000000189730240-0x0000000189730290
    public static bool ArrayFromJson(JSONNode node, out Point2D[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA42B0-0x0000000180DA4630
      // [IDTag] // 0x000000018973DF20-0x000000018973DF60
      // [XID] // 0x000000018973DF20-0x000000018973DF60
    private static bool InternalArrayFromJson(JSONNode node, out Point2D[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8BE10-0x0000000180D8C0A0
    [BlackList] // 0x0000000189748380-0x00000001897483D0
                // [IDTag] // 0x0000000189748380-0x00000001897483D0
                // [XID] // 0x0000000189748380-0x00000001897483D0
    public static bool ArrayFromJson(JSONNode node, out MoleMole.Config.Vector[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCCDB0-0x0000000180DCD130
      // [IDTag] // 0x0000000189755B80-0x0000000189755BC0
      // [XID] // 0x0000000189755B80-0x0000000189755BC0
    private static bool InternalArrayFromJson(JSONNode node, out MoleMole.Config.Vector[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7D970-0x0000000180D7DC20
    [BlackList] // 0x000000018975FF90-0x000000018975FFE0
                // [IDTag] // 0x000000018975FF90-0x000000018975FFE0
                // [XID] // 0x000000018975FF90-0x000000018975FFE0
    public static bool EnumStrToVal(string str, out CameraShakeType e)
    {
        e = default;
        return default;
    } // 0x0000000180D74C80-0x0000000180D74E10
    [BlackList] // 0x000000018976D620-0x000000018976D670
                // [IDTag] // 0x000000018976D620-0x000000018976D670
                // [XID] // 0x000000018976D620-0x000000018976D670
    public static bool EnumStrToVal(string str, out TargetType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5B2C0-0x0000000180D5B5D0
    [BlackList] // 0x000000018977AB70-0x000000018977ABC0
                // [IDTag] // 0x000000018977AB70-0x000000018977ABC0
                // [XID] // 0x000000018977AB70-0x000000018977ABC0
    public static bool EnumStrToVal(string str, out TimerLimitType e)
    {
        e = default;
        return default;
    } // 0x0000000180D45B40-0x0000000180D45C80
    [BlackList] // 0x00000001897883E0-0x0000000189788430
                // [IDTag] // 0x00000001897883E0-0x0000000189788430
                // [XID] // 0x00000001897883E0-0x0000000189788430
    public static bool EnumStrToVal(string str, out AbilityFormula e)
    {
        e = default;
        return default;
    } // 0x0000000180D45FA0-0x0000000180D460E0
    [BlackList] // 0x0000000189795920-0x0000000189795970
                // [IDTag] // 0x0000000189795920-0x0000000189795970
                // [XID] // 0x0000000189795920-0x0000000189795970
    public static bool EnumStrToVal(string str, out ActionPointType e)
    {
        e = default;
        return default;
    } // 0x0000000180D61E00-0x0000000180D627A0
    [BlackList] // 0x00000001897A3760-0x00000001897A37B0
                // [IDTag] // 0x00000001897A3760-0x00000001897A37B0
                // [XID] // 0x00000001897A3760-0x00000001897A37B0
    public static bool ArrayFromJson(JSONNode node, out EntityType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAA830-0x0000000180DAABB0
      // [IDTag] // 0x00000001897B0F00-0x00000001897B0F40
      // [XID] // 0x00000001897B0F00-0x00000001897B0F40
    private static bool InternalArrayFromJson(JSONNode node, out EntityType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7F470-0x0000000180D7F730
    [BlackList] // 0x00000001897BC410-0x00000001897BC460
                // [IDTag] // 0x00000001897BC410-0x00000001897BC460
                // [XID] // 0x00000001897BC410-0x00000001897BC460
    public static bool EnumStrToVal(string str, out E_ShaderData e)
    {
        e = default;
        return default;
    } // 0x0000000180D44D80-0x0000000180D45180
    [BlackList] // 0x00000001897C99C0-0x00000001897C9A10
                // [IDTag] // 0x00000001897C99C0-0x00000001897C9A10
                // [XID] // 0x00000001897C99C0-0x00000001897C9A10
    public static bool EnumStrToVal(string str, out E_ShaderPlus e)
    {
        e = default;
        return default;
    } // 0x0000000180D6A210-0x0000000180D6A3E0
    [BlackList] // 0x00000001897D7300-0x00000001897D7350
                // [IDTag] // 0x00000001897D7300-0x00000001897D7350
                // [XID] // 0x00000001897D7300-0x00000001897D7350
    public static bool EnumStrToVal(string str, out ShaderUseType e)
    {
        e = default;
        return default;
    } // 0x0000000180D711E0-0x0000000180D71370
    [BlackList] // 0x00000001897E49B0-0x00000001897E4A00
                // [IDTag] // 0x00000001897E49B0-0x00000001897E4A00
                // [XID] // 0x00000001897E49B0-0x00000001897E4A00
    public static bool EnumStrToVal(string str, out DieFlag e)
    {
        e = default;
        return default;
    } // 0x0000000180D45180-0x0000000180D453D0
    [BlackList] // 0x00000001897F2830-0x00000001897F2880
                // [IDTag] // 0x00000001897F2830-0x00000001897F2880
                // [XID] // 0x00000001897F2830-0x00000001897F2880
    public static bool EnumStrToVal(string str, out DieStateFlag e)
    {
        e = default;
        return default;
    } // 0x0000000180D40660-0x0000000180D409A0
    [BlackList] // 0x00000001897FFDD0-0x00000001897FFE20
                // [IDTag] // 0x00000001897FFDD0-0x00000001897FFE20
                // [XID] // 0x00000001897FFDD0-0x00000001897FFE20
    public static bool EnumStrToVal(string str, out BodyMaterialType e)
    {
        e = default;
        return default;
    } // 0x0000000180D74650-0x0000000180D74960
    [BlackList] // 0x000000018980D110-0x000000018980D160
                // [IDTag] // 0x000000018980D110-0x000000018980D160
                // [XID] // 0x000000018980D110-0x000000018980D160
    public static bool EnumStrToVal(string str, out LevelDayTimeType e)
    {
        e = default;
        return default;
    } // 0x0000000180D553F0-0x0000000180D55530
    [BlackList] // 0x000000018981AC20-0x000000018981AC70
                // [IDTag] // 0x000000018981AC20-0x000000018981AC70
                // [XID] // 0x000000018981AC20-0x000000018981AC70
    public static bool EnumStrToVal(string str, out AttachPointTargetType e)
    {
        e = default;
        return default;
    } // 0x0000000180D67C50-0x0000000180D67E20
    [BlackList] // 0x0000000189828440-0x0000000189828490
                // [IDTag] // 0x0000000189828440-0x0000000189828490
                // [XID] // 0x0000000189828440-0x0000000189828490
    public static bool EnumStrToVal(string str, out DirectionAngleType e)
    {
        e = default;
        return default;
    } // 0x0000000180D769F0-0x0000000180D76B80
    [BlackList] // 0x0000000189835750-0x00000001898357A0
                // [IDTag] // 0x0000000189835750-0x00000001898357A0
                // [XID] // 0x0000000189835750-0x00000001898357A0
    public static bool EnumStrToVal(string str, out TargetIndicatorType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6A040-0x0000000180D6A210
    [BlackList] // 0x0000000189842DB0-0x0000000189842E00
                // [IDTag] // 0x0000000189842DB0-0x0000000189842E00
                // [XID] // 0x0000000189842DB0-0x0000000189842E00
    public static bool EnumStrToVal(string str, out TweenEaseType e)
    {
        e = default;
        return default;
    } // 0x0000000180D656C0-0x0000000180D65E40
    [BlackList] // 0x000000018984FE70-0x000000018984FEC0
                // [IDTag] // 0x000000018984FE70-0x000000018984FEC0
                // [XID] // 0x000000018984FE70-0x000000018984FEC0
    public static bool EnumStrToVal(string str, out EntityAppearVisionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5AB90-0x0000000180D5AF60
    [BlackList] // 0x000000018985CE20-0x000000018985CE70
                // [IDTag] // 0x000000018985CE20-0x000000018985CE70
                // [XID] // 0x000000018985CE20-0x000000018985CE70
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ulong> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD20A0-0x0000000180CD2420
      // [IDTag] // 0x000000018986A730-0x000000018986A770
      // [XID] // 0x000000018986A730-0x000000018986A770
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ulong> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D129F0-0x0000000180D12FC0
    [BlackList] // 0x0000000189874760-0x00000001898747B0
                // [IDTag] // 0x0000000189874760-0x00000001898747B0
                // [XID] // 0x0000000189874760-0x00000001898747B0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ulong> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC78A0-0x0000000180CC7C20
      // [IDTag] // 0x0000000189881DD0-0x0000000189881E10
      // [XID] // 0x0000000189881DD0-0x0000000189881E10
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ulong> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D284E0-0x0000000180D28B10
    [BlackList] // 0x000000018988C3A0-0x000000018988C3F0
                // [IDTag] // 0x000000018988C3A0-0x000000018988C3F0
                // [XID] // 0x000000018988C3A0-0x000000018988C3F0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ulong> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD5520-0x0000000180CD58A0
      // [IDTag] // 0x00000001898999D0-0x0000000189899A10
      // [XID] // 0x00000001898999D0-0x0000000189899A10
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ulong> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEA420-0x0000000180CEA920
    [BlackList] // 0x00000001898A3E80-0x00000001898A3ED0
                // [IDTag] // 0x00000001898A3E80-0x00000001898A3ED0
                // [XID] // 0x00000001898A3E80-0x00000001898A3ED0
    public static bool EnumStrToVal(string str, out HpBarStyle e)
    {
        e = default;
        return default;
    } // 0x0000000180D4C690-0x0000000180D4C8A0
    [BlackList] // 0x00000001898B1400-0x00000001898B1450
                // [IDTag] // 0x00000001898B1400-0x00000001898B1450
                // [XID] // 0x00000001898B1400-0x00000001898B1450
    public static bool EnumStrToVal(string str, out EquipInSlotType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6A3E0-0x0000000180D6A570
    [BlackList] // 0x00000001898BE980-0x00000001898BE9D0
                // [IDTag] // 0x00000001898BE980-0x00000001898BE9D0
                // [XID] // 0x00000001898BE980-0x00000001898BE9D0
    public static bool EnumStrToVal(string str, out EquipEntityType e)
    {
        e = default;
        return default;
    } // 0x0000000180D520E0-0x0000000180D52450
    [BlackList] // 0x00000001898CC160-0x00000001898CC1B0
                // [IDTag] // 0x00000001898CC160-0x00000001898CC1B0
                // [XID] // 0x00000001898CC160-0x00000001898CC1B0
    public static bool EnumStrToVal(string str, out HitBoxType e)
    {
        e = default;
        return default;
    } // 0x0000000180D48D60-0x0000000180D48EA0
    [BlackList] // 0x00000001898D9CA0-0x00000001898D9CF0
                // [IDTag] // 0x00000001898D9CA0-0x00000001898D9CF0
                // [XID] // 0x00000001898D9CA0-0x00000001898D9CF0
    public static bool EnumStrToVal(string str, out TDPlayTowerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D75020-0x0000000180D753F0
    [BlackList] // 0x00000001898E7C20-0x00000001898E7C70
                // [IDTag] // 0x00000001898E7C20-0x00000001898E7C70
                // [XID] // 0x00000001898E7C20-0x00000001898E7C70
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigDynamicAbilityPreload> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC7520-0x0000000180CC78A0
      // [IDTag] // 0x00000001898F5370-0x00000001898F53B0
      // [XID] // 0x00000001898F5370-0x00000001898F53B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigDynamicAbilityPreload> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D07FB0-0x0000000180D084B0
    [BlackList] // 0x00000001898FFBF0-0x00000001898FFC40
                // [IDTag] // 0x00000001898FFBF0-0x00000001898FFC40
                // [XID] // 0x00000001898FFBF0-0x00000001898FFC40
    public static bool ArrayFromJson(JSONNode node, out ConfigDynamicTalent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB5030-0x0000000180DB53B0
      // [IDTag] // 0x000000018990D480-0x000000018990D4C0
      // [XID] // 0x000000018990D480-0x000000018990D4C0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigDynamicTalent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D85A80-0x0000000180D85D30
    [BlackList] // 0x0000000189917DA0-0x0000000189917DF0
                // [IDTag] // 0x0000000189917DA0-0x0000000189917DF0
                // [XID] // 0x0000000189917DA0-0x0000000189917DF0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigEffectPoolItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC40A0-0x0000000180CC4420
      // [IDTag] // 0x0000000189925570-0x00000001899255B0
      // [XID] // 0x0000000189925570-0x00000001899255B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigEffectPoolItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF1DC0-0x0000000180CF22C0
    [BlackList] // 0x000000018992FAC0-0x000000018992FB10
                // [IDTag] // 0x000000018992FAC0-0x000000018992FB10
                // [XID] // 0x000000018992FAC0-0x000000018992FB10
    public static bool ArrayFromJson(JSONNode node, out ConfigEffectWithThreshold[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA03B0-0x0000000180DA0730
      // [IDTag] // 0x000000018993D4C0-0x000000018993D500
      // [XID] // 0x000000018993D4C0-0x000000018993D500
    private static bool InternalArrayFromJson(JSONNode node, out ConfigEffectWithThreshold[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D82270-0x0000000180D82520
    [BlackList] // 0x00000001899477C0-0x0000000189947810
                // [IDTag] // 0x00000001899477C0-0x0000000189947810
                // [XID] // 0x00000001899477C0-0x0000000189947810
    public static bool ArrayFromJson(JSONNode node, out ConfigRecoverEnergyEffect[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB68B0-0x0000000180DB6C30
      // [IDTag] // 0x0000000189954E20-0x0000000189954E60
      // [XID] // 0x0000000189954E20-0x0000000189954E60
    private static bool InternalArrayFromJson(JSONNode node, out ConfigRecoverEnergyEffect[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9AF70-0x0000000180D9B220
    [BlackList] // 0x000000018995F890-0x000000018995F8E0
                // [IDTag] // 0x000000018995F890-0x000000018995F8E0
                // [XID] // 0x000000018995F890-0x000000018995F8E0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigSkipUnindexedEffectCreation> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE5BA0-0x0000000180CE5F20
      // [IDTag] // 0x000000018996CF90-0x000000018996CFD0
      // [XID] // 0x000000018996CF90-0x000000018996CFD0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigSkipUnindexedEffectCreation> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1F550-0x0000000180D1FA50
    [BlackList] // 0x0000000189977B00-0x0000000189977B50
                // [IDTag] // 0x0000000189977B00-0x0000000189977B50
                // [XID] // 0x0000000189977B00-0x0000000189977B50
    public static bool EnumStrToVal(string str, out TokenForceEnqueueReason e)
    {
        e = default;
        return default;
    } // 0x0000000180D40E00-0x0000000180D40F00
    [BlackList] // 0x0000000189984D10-0x0000000189984D60
                // [IDTag] // 0x0000000189984D10-0x0000000189984D60
                // [XID] // 0x0000000189984D10-0x0000000189984D60
    public static bool DictFromJson(JSONNode node, out Dictionary<string, TokenForceEnqueueReason> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBC620-0x0000000180CBC9A0
      // [IDTag] // 0x0000000189992DE0-0x0000000189992E20
      // [XID] // 0x0000000189992DE0-0x0000000189992E20
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, TokenForceEnqueueReason> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D18CA0-0x0000000180D191B0
    [BlackList] // 0x000000018999D7D0-0x000000018999D820
                // [IDTag] // 0x000000018999D7D0-0x000000018999D820
                // [XID] // 0x000000018999D7D0-0x000000018999D820
    public static bool EnumStrToVal(string str, out ElementReactionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D581A0-0x0000000180D58920
    [BlackList] // 0x00000001899AB260-0x00000001899AB2B0
                // [IDTag] // 0x00000001899AB260-0x00000001899AB2B0
                // [XID] // 0x00000001899AB260-0x00000001899AB2B0
    public static bool EnumStrToVal(string str, out ElementReactionSourceType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5F690-0x0000000180D5F860
    [BlackList] // 0x00000001899B86E0-0x00000001899B8730
                // [IDTag] // 0x00000001899B86E0-0x00000001899B8730
                // [XID] // 0x00000001899B86E0-0x00000001899B8730
    public static bool EnumStrToVal(string str, out ElementType e)
    {
        e = default;
        return default;
    } // 0x0000000180D72620-0x0000000180D729F0
    [BlackList] // 0x00000001899C6270-0x00000001899C62C0
                // [IDTag] // 0x00000001899C6270-0x00000001899C62C0
                // [XID] // 0x00000001899C6270-0x00000001899C62C0
    public static bool EnumStrToVal(string str, out AbilityState e)
    {
        e = default;
        return default;
    } // 0x0000000180D42B40-0x0000000180D43290
    [BlackList] // 0x00000001899D37A0-0x00000001899D37F0
                // [IDTag] // 0x00000001899D37A0-0x00000001899D37F0
                // [XID] // 0x00000001899D37A0-0x00000001899D37F0
    public static bool ArrayFromJson(JSONNode node, out ElementType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBAEB0-0x0000000180DBB230
      // [IDTag] // 0x00000001899E0B90-0x00000001899E0BD0
      // [XID] // 0x00000001899E0B90-0x00000001899E0BD0
    private static bool InternalArrayFromJson(JSONNode node, out ElementType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8EBC0-0x0000000180D8EE80
    [BlackList] // 0x00000001899EB170-0x00000001899EB1C0
                // [IDTag] // 0x00000001899EB170-0x00000001899EB1C0
                // [XID] // 0x00000001899EB170-0x00000001899EB1C0
    public static bool DictFromJson(JSONNode node, out Dictionary<AbilityState, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBADA0-0x0000000180CBB120
      // [IDTag] // 0x00000001899F8BD0-0x00000001899F8C10
      // [XID] // 0x00000001899F8BD0-0x00000001899F8C10
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<AbilityState, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D35900-0x0000000180D35F10
    [BlackList] // 0x0000000189A03200-0x0000000189A03250
                // [IDTag] // 0x0000000189A03200-0x0000000189A03250
                // [XID] // 0x0000000189A03200-0x0000000189A03250
    public static bool ArrayFromJson(JSONNode node, out ConfigEmojiBubbleData[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB0DB0-0x0000000180DB1130
      // [IDTag] // 0x0000000189A106A0-0x0000000189A106E0
      // [XID] // 0x0000000189A106A0-0x0000000189A106E0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigEmojiBubbleData[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7B950-0x0000000180D7BC00
    [BlackList] // 0x0000000189A1AAB0-0x0000000189A1AB00
                // [IDTag] // 0x0000000189A1AAB0-0x0000000189A1AB00
                // [XID] // 0x0000000189A1AAB0-0x0000000189A1AB00
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigEmojiBubbleData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBA320-0x0000000180CBA6A0
      // [IDTag] // 0x0000000189A27E30-0x0000000189A27E70
      // [XID] // 0x0000000189A27E30-0x0000000189A27E70
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigEmojiBubbleData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0D4C0-0x0000000180D0D9C0
    [BlackList] // 0x0000000189A32410-0x0000000189A32460
                // [IDTag] // 0x0000000189A32410-0x0000000189A32460
                // [XID] // 0x0000000189A32410-0x0000000189A32460
    public static bool ArrayFromJson(JSONNode node, out ConfigMatLinearChangedByDistance[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC10B0-0x0000000180DC1430
      // [IDTag] // 0x0000000189A3FE70-0x0000000189A3FEB0
      // [XID] // 0x0000000189A3FE70-0x0000000189A3FEB0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMatLinearChangedByDistance[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D939B0-0x0000000180D93C60
    [BlackList] // 0x0000000189A4A390-0x0000000189A4A3E0
                // [IDTag] // 0x0000000189A4A390-0x0000000189A4A3E0
                // [XID] // 0x0000000189A4A390-0x0000000189A4A3E0
    public static bool EnumStrToVal(string str, out TouchInteractType e)
    {
        e = default;
        return default;
    } // 0x0000000180D770E0-0x0000000180D77330
    [BlackList] // 0x0000000189A57A40-0x0000000189A57A90
                // [IDTag] // 0x0000000189A57A40-0x0000000189A57A90
                // [XID] // 0x0000000189A57A40-0x0000000189A57A90
    public static bool EnumStrToVal(string str, out GadgetState e)
    {
        e = default;
        return default;
    } // 0x0000000180D676E0-0x0000000180D67C50
    [BlackList] // 0x0000000189A65740-0x0000000189A65790
                // [IDTag] // 0x0000000189A65740-0x0000000189A65790
                // [XID] // 0x0000000189A65740-0x0000000189A65790
    public static bool EnumStrToVal(string str, out AnimatorParamType e)
    {
        e = default;
        return default;
    } // 0x0000000180D41ED0-0x0000000180D42060
    [BlackList] // 0x0000000189A72F80-0x0000000189A72FD0
                // [IDTag] // 0x0000000189A72F80-0x0000000189A72FD0
                // [XID] // 0x0000000189A72F80-0x0000000189A72FD0
    public static bool ArrayFromJson(JSONNode node, out ConfigGadgetStateAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA8530-0x0000000180DA88B0
      // [IDTag] // 0x0000000189A80570-0x0000000189A805B0
      // [XID] // 0x0000000189A80570-0x0000000189A805B0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigGadgetStateAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D90960-0x0000000180D90BF0
    [BlackList] // 0x0000000189A8B250-0x0000000189A8B2A0
                // [IDTag] // 0x0000000189A8B250-0x0000000189A8B2A0
                // [XID] // 0x0000000189A8B250-0x0000000189A8B2A0
    public static bool EnumStrToVal(string str, out GearType e)
    {
        e = default;
        return default;
    } // 0x0000000180D75D40-0x0000000180D75F10
    [BlackList] // 0x0000000189A98C20-0x0000000189A98C70
                // [IDTag] // 0x0000000189A98C20-0x0000000189A98C70
                // [XID] // 0x0000000189A98C20-0x0000000189A98C70
    public static bool EnumStrToVal(string str, out SealProgressType e)
    {
        e = default;
        return default;
    } // 0x0000000180D47B30-0x0000000180D47C70
    [BlackList] // 0x0000000189AA5F00-0x0000000189AA5F50
                // [IDTag] // 0x0000000189AA5F00-0x0000000189AA5F50
                // [XID] // 0x0000000189AA5F00-0x0000000189AA5F50
    public static bool EnumStrToVal(string str, out PickType e)
    {
        e = default;
        return default;
    } // 0x0000000180D76B80-0x0000000180D76E90
    [BlackList] // 0x0000000189AB3730-0x0000000189AB3780
                // [IDTag] // 0x0000000189AB3730-0x0000000189AB3780
                // [XID] // 0x0000000189AB3730-0x0000000189AB3780
    public static bool EnumStrToVal(string str, out ControlPartForwardBy e)
    {
        e = default;
        return default;
    } // 0x0000000180D77800-0x0000000180D77990
    [BlackList] // 0x0000000189AC1070-0x0000000189AC10C0
                // [IDTag] // 0x0000000189AC1070-0x0000000189AC10C0
                // [XID] // 0x0000000189AC1070-0x0000000189AC10C0
    public static bool EnumStrToVal(string str, out ControlPartRotateBy e)
    {
        e = default;
        return default;
    } // 0x0000000180D6CA80-0x0000000180D6CBC0
    [BlackList] // 0x0000000189ACE990-0x0000000189ACE9E0
                // [IDTag] // 0x0000000189ACE990-0x0000000189ACE9E0
                // [XID] // 0x0000000189ACE990-0x0000000189ACE9E0
    public static bool EnumStrToVal(string str, out ControlPartDoOnUnEnabled e)
    {
        e = default;
        return default;
    } // 0x0000000180D52F80-0x0000000180D53110
    [BlackList] // 0x0000000189ADC8A0-0x0000000189ADC8F0
                // [IDTag] // 0x0000000189ADC8A0-0x0000000189ADC8F0
                // [XID] // 0x0000000189ADC8A0-0x0000000189ADC8F0
    public static bool EnumStrToVal(string str, out ControlPartTargetType e)
    {
        e = default;
        return default;
    } // 0x0000000180D47C70-0x0000000180D47DB0
    [BlackList] // 0x0000000189AE9F70-0x0000000189AE9FC0
                // [IDTag] // 0x0000000189AE9F70-0x0000000189AE9FC0
                // [XID] // 0x0000000189AE9F70-0x0000000189AE9FC0
    public static bool ArrayFromJson(JSONNode node, out ConfigControlPart[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBFBB0-0x0000000180DBFF30
      // [IDTag] // 0x0000000189AF7B00-0x0000000189AF7B40
      // [XID] // 0x0000000189AF7B00-0x0000000189AF7B40
    private static bool InternalArrayFromJson(JSONNode node, out ConfigControlPart[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D84530-0x0000000180D847C0
    [BlackList] // 0x0000000189B02270-0x0000000189B022C0
                // [IDTag] // 0x0000000189B02270-0x0000000189B022C0
                // [XID] // 0x0000000189B02270-0x0000000189B022C0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigGadget> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDCC20-0x0000000180CDCFA0
      // [IDTag] // 0x0000000189B0F8B0-0x0000000189B0F8F0
      // [XID] // 0x0000000189B0F8B0-0x0000000189B0F8F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigGadget> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0E9A0-0x0000000180D0EE70
    [BlackList] // 0x0000000189B19B50-0x0000000189B19BA0
                // [IDTag] // 0x0000000189B19B50-0x0000000189B19BA0
                // [XID] // 0x0000000189B19B50-0x0000000189B19BA0
    public static bool ArrayFromJson(JSONNode node, out ConfigKeyInput[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC6830-0x0000000180DC6BB0
      // [IDTag] // 0x0000000189B273A0-0x0000000189B273E0
      // [XID] // 0x0000000189B273A0-0x0000000189B273E0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigKeyInput[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8F660-0x0000000180D8F910
    [BlackList] // 0x0000000189B31810-0x0000000189B31860
                // [IDTag] // 0x0000000189B31810-0x0000000189B31860
                // [XID] // 0x0000000189B31810-0x0000000189B31860
    public static bool EnumStrToVal(string str, out EFootprintPlatform e)
    {
        e = default;
        return default;
    } // 0x0000000180D787A0-0x0000000180D78AE0
    [BlackList] // 0x0000000189B3EEE0-0x0000000189B3EF30
                // [IDTag] // 0x0000000189B3EEE0-0x0000000189B3EF30
                // [XID] // 0x0000000189B3EEE0-0x0000000189B3EF30
    public static bool DictFromJson(JSONNode node, out Dictionary<EFootprintPlatform, ConfigFootprintEffect> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD2EA0-0x0000000180CD3220
      // [IDTag] // 0x0000000189B4C800-0x0000000189B4C840
      // [XID] // 0x0000000189B4C800-0x0000000189B4C840
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<EFootprintPlatform, ConfigFootprintEffect> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D21B70-0x0000000180D22170
    [BlackList] // 0x0000000189B56F90-0x0000000189B56FE0
                // [IDTag] // 0x0000000189B56F90-0x0000000189B56FE0
                // [XID] // 0x0000000189B56F90-0x0000000189B56FE0
    public static bool DictFromJson(JSONNode node, out Dictionary<SceneSurfaceType, Dictionary<EFootprintPlatform, ConfigFootprintEffect>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD58A0-0x0000000180CD5C20
      // [IDTag] // 0x0000000189B646F0-0x0000000189B64730
      // [XID] // 0x0000000189B646F0-0x0000000189B64730
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SceneSurfaceType, Dictionary<EFootprintPlatform, ConfigFootprintEffect>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D3A990-0x0000000180D3AF90
    [BlackList] // 0x0000000189B6EB80-0x0000000189B6EBD0
                // [IDTag] // 0x0000000189B6EB80-0x0000000189B6EBD0
                // [XID] // 0x0000000189B6EB80-0x0000000189B6EBD0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigMonsterInitialPose> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDDA20-0x0000000180CDDDA0
      // [IDTag] // 0x0000000189B7C170-0x0000000189B7C1B0
      // [XID] // 0x0000000189B7C170-0x0000000189B7C1B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigMonsterInitialPose> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D22C30-0x0000000180D23130
    [BlackList] // 0x0000000189B86C40-0x0000000189B86C90
                // [IDTag] // 0x0000000189B86C40-0x0000000189B86C90
                // [XID] // 0x0000000189B86C40-0x0000000189B86C90
    public static bool EnumStrToVal(string str, out DropElemControlType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6C040-0x0000000180D6C180
    [BlackList] // 0x0000000189B93C70-0x0000000189B93CC0
                // [IDTag] // 0x0000000189B93C70-0x0000000189B93CC0
                // [XID] // 0x0000000189B93C70-0x0000000189B93CC0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigLevelEntity> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCEFA0-0x0000000180CCF320
      // [IDTag] // 0x0000000189BA0ED0-0x0000000189BA0F10
      // [XID] // 0x0000000189BA0ED0-0x0000000189BA0F10
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigLevelEntity> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1DB70-0x0000000180D1E080
    [BlackList] // 0x0000000189BAB520-0x0000000189BAB570
                // [IDTag] // 0x0000000189BAB520-0x0000000189BAB570
                // [XID] // 0x0000000189BAB520-0x0000000189BAB570
    public static bool ArrayFromJson(JSONNode node, out TransPointUpdateMaterial[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB8830-0x0000000180DB8BB0
      // [IDTag] // 0x0000000189BB8600-0x0000000189BB8640
      // [XID] // 0x0000000189BB8600-0x0000000189BB8640
    private static bool InternalArrayFromJson(JSONNode node, out TransPointUpdateMaterial[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D90EA0-0x0000000180D91150
    [BlackList] // 0x0000000189BC3830-0x0000000189BC3880
                // [IDTag] // 0x0000000189BC3830-0x0000000189BC3880
                // [XID] // 0x0000000189BC3830-0x0000000189BC3880
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAttachment> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC2F20-0x0000000180CC32A0
      // [IDTag] // 0x0000000189BD0C50-0x0000000189BD0C90
      // [XID] // 0x0000000189BD0C50-0x0000000189BD0C90
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAttachment> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D15EC0-0x0000000180D163C0
    [BlackList] // 0x0000000189BDB6A0-0x0000000189BDB6F0
                // [IDTag] // 0x0000000189BDB6A0-0x0000000189BDB6F0
                // [XID] // 0x0000000189BDB6A0-0x0000000189BDB6F0
    public static bool ArrayFromJson(JSONNode node, out ConfigEntityBlackGrp[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC2CB0-0x0000000180DC3030
      // [IDTag] // 0x00000001895EE150-0x00000001895EE190
      // [XID] // 0x00000001895EE150-0x00000001895EE190
    private static bool InternalArrayFromJson(JSONNode node, out ConfigEntityBlackGrp[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D931A0-0x0000000180D93450
    [BlackList] // 0x00000001895F8B40-0x00000001895F8B90
                // [IDTag] // 0x00000001895F8B40-0x00000001895F8B90
                // [XID] // 0x00000001895F8B40-0x00000001895F8B90
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigEntityBlackGrp[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC5220-0x0000000180CC55A0
      // [IDTag] // 0x0000000189606040-0x0000000189606080
      // [XID] // 0x0000000189606040-0x0000000189606080
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigEntityBlackGrp[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2AC10-0x0000000180D2B110
    [BlackList] // 0x0000000189610930-0x0000000189610980
                // [IDTag] // 0x0000000189610930-0x0000000189610980
                // [XID] // 0x0000000189610930-0x0000000189610980
    public static bool ArrayFromJson(JSONNode node, out ConfigEntityReuse[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC1B30-0x0000000180DC1EB0
      // [IDTag] // 0x000000018961DF90-0x000000018961DFD0
      // [XID] // 0x000000018961DF90-0x000000018961DFD0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigEntityReuse[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D85270-0x0000000180D85520
    [BlackList] // 0x0000000189628480-0x00000001896284D0
                // [IDTag] // 0x0000000189628480-0x00000001896284D0
                // [XID] // 0x0000000189628480-0x00000001896284D0
    public static bool EnumStrToVal(string str, out EntityType e)
    {
        e = default;
        return default;
    } // 0x0000000180D3D350-0x0000000180D3DEE0
    [BlackList] // 0x0000000189636180-0x00000001896361D0
                // [IDTag] // 0x0000000189636180-0x00000001896361D0
                // [XID] // 0x0000000189636180-0x00000001896361D0
    public static bool EnumStrToVal(string str, out EndureType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6B520-0x0000000180D6B9D0
    [BlackList] // 0x0000000189643730-0x0000000189643780
                // [IDTag] // 0x0000000189643730-0x0000000189643780
                // [XID] // 0x0000000189643730-0x0000000189643780
    public static bool EnumStrToVal(string str, out TauntLevel e)
    {
        e = default;
        return default;
    } // 0x0000000180D55530-0x0000000180D55960
    [BlackList] // 0x0000000189650D30-0x0000000189650D80
                // [IDTag] // 0x0000000189650D30-0x0000000189650D80
                // [XID] // 0x0000000189650D30-0x0000000189650D80
    public static bool EnumStrToVal(string str, out EnvironmentType e)
    {
        e = default;
        return default;
    } // 0x0000000180D77330-0x0000000180D77700
    [BlackList] // 0x000000018965E4D0-0x000000018965E520
                // [IDTag] // 0x000000018965E4D0-0x000000018965E520
                // [XID] // 0x000000018965E4D0-0x000000018965E520
    public static bool EnumStrToVal(string str, out RandTaskContentType e)
    {
        e = default;
        return default;
    } // 0x0000000180D68B00-0x0000000180D68E70
    [BlackList] // 0x000000018966B9A0-0x000000018966B9F0
                // [IDTag] // 0x000000018966B9A0-0x000000018966B9F0
                // [XID] // 0x000000018966B9A0-0x000000018966B9F0
    public static bool EnumStrToVal(string str, out SceneType e)
    {
        e = default;
        return default;
    } // 0x0000000180D760A0-0x0000000180D762F0
    [BlackList] // 0x0000000189679A90-0x0000000189679AE0
                // [IDTag] // 0x0000000189679A90-0x0000000189679AE0
                // [XID] // 0x0000000189679A90-0x0000000189679AE0
    public static bool ArrayFromJson(JSONNode node, out BowDrawTime[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB5E30-0x0000000180DB61B0
      // [IDTag] // 0x0000000189687070-0x00000001896870B0
      // [XID] // 0x0000000189687070-0x00000001896870B0
    private static bool InternalArrayFromJson(JSONNode node, out BowDrawTime[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D929B0-0x0000000180D92C60
    [BlackList] // 0x00000001896920E0-0x0000000189692130
                // [IDTag] // 0x00000001896920E0-0x0000000189692130
                // [XID] // 0x00000001896920E0-0x0000000189692130
    public static bool ArrayFromJson(JSONNode node, out TriggerToStates[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA0E30-0x0000000180DA11B0
      // [IDTag] // 0x000000018969F280-0x000000018969F2C0
      // [XID] // 0x000000018969F280-0x000000018969F2C0
    private static bool InternalArrayFromJson(JSONNode node, out TriggerToStates[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8B8B0-0x0000000180D8BB60
    [BlackList] // 0x00000001896A9790-0x00000001896A97E0
                // [IDTag] // 0x00000001896A9790-0x00000001896A97E0
                // [XID] // 0x00000001896A9790-0x00000001896A97E0
    public static bool ArrayFromJson(JSONNode node, out WeaponAwayFromHandState[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC8EB0-0x0000000180DC9230
      // [IDTag] // 0x00000001896B6910-0x00000001896B6950
      // [XID] // 0x00000001896B6910-0x00000001896B6950
    private static bool InternalArrayFromJson(JSONNode node, out WeaponAwayFromHandState[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D79E90-0x0000000180D7A140
    [BlackList] // 0x00000001896C0C40-0x00000001896C0C90
                // [IDTag] // 0x00000001896C0C40-0x00000001896C0C90
                // [XID] // 0x00000001896C0C40-0x00000001896C0C90
    public static bool EnumStrToVal(string str, out AudioVoiceTrigger e)
    {
        e = default;
        return default;
    } // 0x0000000180D4C210-0x0000000180D4C550
    [BlackList] // 0x00000001896CE2B0-0x00000001896CE300
                // [IDTag] // 0x00000001896CE2B0-0x00000001896CE300
                // [XID] // 0x00000001896CE2B0-0x00000001896CE300
    public static bool ArrayFromJson(JSONNode node, out ConfigExternalVoiceSound[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DACEB0-0x0000000180DAD230
      // [IDTag] // 0x00000001896DB620-0x00000001896DB660
      // [XID] // 0x00000001896DB620-0x00000001896DB660
    private static bool InternalArrayFromJson(JSONNode node, out ConfigExternalVoiceSound[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D91980-0x0000000180D91C30
    [BlackList] // 0x00000001896E5A90-0x00000001896E5AE0
                // [IDTag] // 0x00000001896E5A90-0x00000001896E5AE0
                // [XID] // 0x00000001896E5A90-0x00000001896E5AE0
    public static bool ArrayFromJson(JSONNode node, out ConfigExternalVoiceInferiorItem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB7330-0x0000000180DB76B0
      // [IDTag] // 0x00000001896F30D0-0x00000001896F3110
      // [XID] // 0x00000001896F30D0-0x00000001896F3110
    private static bool InternalArrayFromJson(JSONNode node, out ConfigExternalVoiceInferiorItem[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D921A0-0x0000000180D92450
    [BlackList] // 0x00000001896FDA30-0x00000001896FDA80
                // [IDTag] // 0x00000001896FDA30-0x00000001896FDA80
                // [XID] // 0x00000001896FDA30-0x00000001896FDA80
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigExternalVoiceItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE15A0-0x0000000180CE1920
      // [IDTag] // 0x000000018970ADC0-0x000000018970AE00
      // [XID] // 0x000000018970ADC0-0x000000018970AE00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigExternalVoiceItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D04780-0x0000000180D04C80
    [BlackList] // 0x0000000189715330-0x0000000189715380
                // [IDTag] // 0x0000000189715330-0x0000000189715380
                // [XID] // 0x0000000189715330-0x0000000189715380
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ConfigExternalVoiceLookupItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC2BA0-0x0000000180CC2F20
      // [IDTag] // 0x0000000189722AC0-0x0000000189722B00
      // [XID] // 0x0000000189722AC0-0x0000000189722B00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ConfigExternalVoiceLookupItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF22C0-0x0000000180CF2890
    [BlackList] // 0x000000018972D160-0x000000018972D1B0
                // [IDTag] // 0x000000018972D160-0x000000018972D1B0
                // [XID] // 0x000000018972D160-0x000000018972D1B0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigExternalVoiceLookupItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE1CA0-0x0000000180CE2020
      // [IDTag] // 0x000000018973A810-0x000000018973A850
      // [XID] // 0x000000018973A810-0x000000018973A850
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigExternalVoiceLookupItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D30A20-0x0000000180D31050
    [BlackList] // 0x0000000189745310-0x0000000189745360
                // [IDTag] // 0x0000000189745310-0x0000000189745360
                // [XID] // 0x0000000189745310-0x0000000189745360
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigFlycloakFashion> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC9BA0-0x0000000180CC9F20
      // [IDTag] // 0x0000000189752770-0x00000001897527B0
      // [XID] // 0x0000000189752770-0x00000001897527B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigFlycloakFashion> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D30020-0x0000000180D30520
    [BlackList] // 0x000000018975CE10-0x000000018975CE60
                // [IDTag] // 0x000000018975CE10-0x000000018975CE60
                // [XID] // 0x000000018975CE10-0x000000018975CE60
    public static bool ArrayFromJson(JSONNode node, out ConfigBaseGadgetTriggerAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCA730-0x0000000180DCAAB0
      // [IDTag] // 0x000000018976A630-0x000000018976A670
      // [XID] // 0x000000018976A630-0x000000018976A670
    private static bool InternalArrayFromJson(JSONNode node, out ConfigBaseGadgetTriggerAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D96210-0x0000000180D964A0
    [BlackList] // 0x00000001897749B0-0x0000000189774A00
                // [IDTag] // 0x00000001897749B0-0x0000000189774A00
                // [XID] // 0x00000001897749B0-0x0000000189774A00
    public static bool EnumStrToVal(string str, out CCDType e)
    {
        e = default;
        return default;
    } // 0x0000000180D66DD0-0x0000000180D66F60
    [BlackList] // 0x0000000189782700-0x0000000189782750
                // [IDTag] // 0x0000000189782700-0x0000000189782750
                // [XID] // 0x0000000189782700-0x0000000189782750
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigPublicAISkillCD> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE70A0-0x0000000180CE7420
      // [IDTag] // 0x000000018978F980-0x000000018978F9C0
      // [XID] // 0x000000018978F980-0x000000018978F9C0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigPublicAISkillCD> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D36A10-0x0000000180D36F10
    [BlackList] // 0x000000018979A010-0x000000018979A060
                // [IDTag] // 0x000000018979A010-0x000000018979A060
                // [XID] // 0x000000018979A010-0x000000018979A060
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigBladeElementFx> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCE520-0x0000000180CCE8A0
      // [IDTag] // 0x00000001897A7DA0-0x00000001897A7DE0
      // [XID] // 0x00000001897A7DA0-0x00000001897A7DE0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigBladeElementFx> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D01B20-0x0000000180D02020
    [BlackList] // 0x00000001897B27B0-0x00000001897B2800
                // [IDTag] // 0x00000001897B27B0-0x00000001897B2800
                // [XID] // 0x00000001897B27B0-0x00000001897B2800
    public static bool ArrayFromJson(JSONNode node, out ElementReactionType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA81B0-0x0000000180DA8530
      // [IDTag] // 0x00000001897C0B60-0x00000001897C0BA0
      // [XID] // 0x00000001897C0B60-0x00000001897C0BA0
    private static bool InternalArrayFromJson(JSONNode node, out ElementReactionType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D91C30-0x0000000180D91EF0
    [BlackList] // 0x00000001897CB210-0x00000001897CB260
                // [IDTag] // 0x00000001897CB210-0x00000001897CB260
                // [XID] // 0x00000001897CB210-0x00000001897CB260
    public static bool DictFromJson(JSONNode node, out Dictionary<AbilityState, ElementReactionType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDB3A0-0x0000000180CDB720
      // [IDTag] // 0x00000001897D9010-0x00000001897D9050
      // [XID] // 0x00000001897D9010-0x00000001897D9050
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<AbilityState, ElementReactionType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1D060-0x0000000180D1D670
    [BlackList] // 0x00000001897E3340-0x00000001897E3390
                // [IDTag] // 0x00000001897E3340-0x00000001897E3390
                // [XID] // 0x00000001897E3340-0x00000001897E3390
    public static bool DictFromJson(JSONNode node, out Dictionary<ElementType, ConfigElementShieldResistance> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE1220-0x0000000180CE15A0
      // [IDTag] // 0x00000001897F0EC0-0x00000001897F0F00
      // [XID] // 0x00000001897F0EC0-0x00000001897F0F00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ElementType, ConfigElementShieldResistance> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFC640-0x0000000180CFCC40
    [BlackList] // 0x00000001897FB9A0-0x00000001897FB9F0
                // [IDTag] // 0x00000001897FB9A0-0x00000001897FB9F0
                // [XID] // 0x00000001897FB9A0-0x00000001897FB9F0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigEliteShieldResistance> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD7BA0-0x0000000180CD7F20
      // [IDTag] // 0x0000000189808AB0-0x0000000189808AF0
      // [XID] // 0x0000000189808AB0-0x0000000189808AF0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigEliteShieldResistance> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D27510-0x0000000180D27A10
    [BlackList] // 0x00000001898130A0-0x00000001898130F0
                // [IDTag] // 0x00000001898130A0-0x00000001898130F0
                // [XID] // 0x00000001898130A0-0x00000001898130F0
    public static bool DictFromJson(JSONNode node, out Dictionary<ElementReactionType, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBB120-0x0000000180CBB4A0
      // [IDTag] // 0x0000000189820D90-0x0000000189820DD0
      // [XID] // 0x0000000189820D90-0x0000000189820DD0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ElementReactionType, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEE510-0x0000000180CEEB10
    [BlackList] // 0x000000018982B130-0x000000018982B180
                // [IDTag] // 0x000000018982B130-0x000000018982B180
                // [XID] // 0x000000018982B130-0x000000018982B180
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigAttackAttenuation> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE1920-0x0000000180CE1CA0
      // [IDTag] // 0x0000000189838620-0x0000000189838660
      // [XID] // 0x0000000189838620-0x0000000189838660
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigAttackAttenuation> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D21670-0x0000000180D21B70
    [BlackList] // 0x0000000189842D60-0x0000000189842DB0
                // [IDTag] // 0x0000000189842D60-0x0000000189842DB0
                // [XID] // 0x0000000189842D60-0x0000000189842DB0
    public static bool ArrayFromJson(JSONNode node, out ConfigGadgetCreationLimit[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBFF30-0x0000000180DC02B0
      // [IDTag] // 0x000000018984FE30-0x000000018984FE70
      // [XID] // 0x000000018984FE30-0x000000018984FE70
    private static bool InternalArrayFromJson(JSONNode node, out ConfigGadgetCreationLimit[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D83500-0x0000000180D837B0
    [BlackList] // 0x000000018985A460-0x000000018985A4B0
                // [IDTag] // 0x000000018985A460-0x000000018985A4B0
                // [XID] // 0x000000018985A460-0x000000018985A4B0
    public static bool ArrayFromJson(JSONNode node, out ConfigElementDecrate[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC1430-0x0000000180DC17B0
      // [IDTag] // 0x00000001898675D0-0x0000000189867610
      // [XID] // 0x00000001898675D0-0x0000000189867610
    private static bool InternalArrayFromJson(JSONNode node, out ConfigElementDecrate[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D81A40-0x0000000180D81CF0
    [BlackList] // 0x0000000189871B20-0x0000000189871B70
                // [IDTag] // 0x0000000189871B20-0x0000000189871B70
                // [XID] // 0x0000000189871B20-0x0000000189871B70
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigElementDecrate[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE69A0-0x0000000180CE6D20
      // [IDTag] // 0x000000018987F1C0-0x000000018987F200
      // [XID] // 0x000000018987F1C0-0x000000018987F200
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigElementDecrate[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D031B0-0x0000000180D036B0
    [BlackList] // 0x0000000189889570-0x00000001898895C0
                // [IDTag] // 0x0000000189889570-0x00000001898895C0
                // [XID] // 0x0000000189889570-0x00000001898895C0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, float> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBF3A0-0x0000000180CBF720
      // [IDTag] // 0x00000001898967B0-0x00000001898967F0
      // [XID] // 0x00000001898967B0-0x00000001898967F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, float> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D17BF0-0x0000000180D181D0
    [BlackList] // 0x00000001898A0B10-0x00000001898A0B60
                // [IDTag] // 0x00000001898A0B10-0x00000001898A0B60
                // [XID] // 0x00000001898A0B10-0x00000001898A0B60
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, SimpleSafeFloat> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD9EA0-0x0000000180CDA220
      // [IDTag] // 0x00000001898AE660-0x00000001898AE6A0
      // [XID] // 0x00000001898AE660-0x00000001898AE6A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, SimpleSafeFloat> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D25ED0-0x0000000180D26540
    [BlackList] // 0x00000001898B8D80-0x00000001898B8DD0
                // [IDTag] // 0x00000001898B8D80-0x00000001898B8DD0
                // [XID] // 0x00000001898B8D80-0x00000001898B8DD0
    public static bool ArrayFromJson(JSONNode node, out EquipSizeData[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA65B0-0x0000000180DA6930
      // [IDTag] // 0x00000001898C6150-0x00000001898C6190
      // [XID] // 0x00000001898C6150-0x00000001898C6190
    private static bool InternalArrayFromJson(JSONNode node, out EquipSizeData[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8C360-0x0000000180D8C610
    [BlackList] // 0x00000001898D0B60-0x00000001898D0BB0
                // [IDTag] // 0x00000001898D0B60-0x00000001898D0BB0
                // [XID] // 0x00000001898D0B60-0x00000001898D0BB0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, EquipSizeData[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBFAA0-0x0000000180CBFE20
      // [IDTag] // 0x00000001898DE900-0x00000001898DE940
      // [XID] // 0x00000001898DE900-0x00000001898DE940
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, EquipSizeData[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D326A0-0x0000000180D32C70
    [BlackList] // 0x00000001898E9360-0x00000001898E93B0
                // [IDTag] // 0x00000001898E9360-0x00000001898E93B0
                // [XID] // 0x00000001898E9360-0x00000001898E93B0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, EquipSizeData[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE5820-0x0000000180CE5BA0
      // [IDTag] // 0x00000001898F6B60-0x00000001898F6BA0
      // [XID] // 0x00000001898F6B60-0x00000001898F6BA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, EquipSizeData[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CED2E0-0x0000000180CED910
    [BlackList] // 0x00000001899013F0-0x0000000189901440
                // [IDTag] // 0x00000001899013F0-0x0000000189901440
                // [XID] // 0x00000001899013F0-0x0000000189901440
    public static bool DictFromJson(JSONNode node, out Dictionary<TDPlayTowerType, ConfigTDPlayTowerData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD1D20-0x0000000180CD20A0
      // [IDTag] // 0x000000018990ED70-0x000000018990EDB0
      // [XID] // 0x000000018990ED70-0x000000018990EDB0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<TDPlayTowerType, ConfigTDPlayTowerData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D169F0-0x0000000180D16FF0
    [BlackList] // 0x0000000189919700-0x0000000189919750
                // [IDTag] // 0x0000000189919700-0x0000000189919750
                // [XID] // 0x0000000189919700-0x0000000189919750
    public static bool DictFromJson(JSONNode node, out Dictionary<NPCBodyType, FirstPersonCoopCamConfig> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB7220-0x0000000180CB75A0
      // [IDTag] // 0x0000000189926F60-0x0000000189926FA0
      // [XID] // 0x0000000189926F60-0x0000000189926FA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<NPCBodyType, FirstPersonCoopCamConfig> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D15290-0x0000000180D158C0
    [BlackList] // 0x0000000189931400-0x0000000189931450
                // [IDTag] // 0x0000000189931400-0x0000000189931450
                // [XID] // 0x0000000189931400-0x0000000189931450
    public static bool EnumStrToVal(string str, out ShadowQuality e)
    {
        e = default;
        return default;
    } // 0x0000000180D73420-0x0000000180D73630
    [BlackList] // 0x000000018993EBB0-0x000000018993EC00
                // [IDTag] // 0x000000018993EBB0-0x000000018993EC00
                // [XID] // 0x000000018993EBB0-0x000000018993EC00
    public static bool EnumStrToVal(string str, out GrassQualityLevel e)
    {
        e = default;
        return default;
    } // 0x0000000180D5A150-0x0000000180D5A460
    [BlackList] // 0x000000018994C060-0x000000018994C0B0
                // [IDTag] // 0x000000018994C060-0x000000018994C0B0
                // [XID] // 0x000000018994C060-0x000000018994C0B0
    public static bool EnumStrToVal(string str, out FadeTintQualityLevel e)
    {
        e = default;
        return default;
    } // 0x0000000180D5A5A0-0x0000000180D5A7F0
    [BlackList] // 0x00000001899596D0-0x0000000189959720
                // [IDTag] // 0x00000001899596D0-0x0000000189959720
                // [XID] // 0x00000001899596D0-0x0000000189959720
    public static bool EnumStrToVal(string str, out CheckboardType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5ECF0-0x0000000180D5EE80
    [BlackList] // 0x0000000189967160-0x00000001899671B0
                // [IDTag] // 0x0000000189967160-0x00000001899671B0
                // [XID] // 0x0000000189967160-0x00000001899671B0
    public static bool EnumStrToVal(string str, out MotionBlurQuality e)
    {
        e = default;
        return default;
    } // 0x0000000180D65E40-0x0000000180D65FD0
    [BlackList] // 0x0000000189974850-0x00000001899748A0
                // [IDTag] // 0x0000000189974850-0x00000001899748A0
                // [XID] // 0x0000000189974850-0x00000001899748A0
    public static bool EnumStrToVal(string str, out AntialiasingMethod e)
    {
        e = default;
        return default;
    } // 0x0000000180D4E280-0x0000000180D4E410
    [BlackList] // 0x0000000189982370-0x00000001899823C0
                // [IDTag] // 0x0000000189982370-0x00000001899823C0
                // [XID] // 0x0000000189982370-0x00000001899823C0
    public static bool EnumStrToVal(string str, out TAAQuality e)
    {
        e = default;
        return default;
    } // 0x0000000180D5F550-0x0000000180D5F690
    [BlackList] // 0x000000018998FA10-0x000000018998FA60
                // [IDTag] // 0x000000018998FA10-0x000000018998FA60
                // [XID] // 0x000000018998FA10-0x000000018998FA60
    public static bool EnumStrToVal(string str, out SMAAQuality e)
    {
        e = default;
        return default;
    } // 0x0000000180D59DB0-0x0000000180D59F80
    [BlackList] // 0x000000018999D780-0x000000018999D7D0
                // [IDTag] // 0x000000018999D780-0x000000018999D7D0
                // [XID] // 0x000000018999D780-0x000000018999D7D0
    public static bool EnumStrToVal(string str, out SSAOMode e)
    {
        e = default;
        return default;
    } // 0x0000000180D69380-0x0000000180D69510
    [BlackList] // 0x00000001899AB210-0x00000001899AB260
                // [IDTag] // 0x00000001899AB210-0x00000001899AB260
                // [XID] // 0x00000001899AB210-0x00000001899AB260
    public static bool EnumStrToVal(string str, out GraphicsSettingEntryType e)
    {
        e = default;
        return default;
    } // 0x0000000180D64EC0-0x0000000180D653A0
    [BlackList] // 0x00000001899B8690-0x00000001899B86E0
                // [IDTag] // 0x00000001899B8690-0x00000001899B86E0
                // [XID] // 0x00000001899B8690-0x00000001899B86E0
    public static bool EnumStrToVal(string str, out SettingEntryDisplayType e)
    {
        e = default;
        return default;
    } // 0x0000000180D63E50-0x0000000180D63FE0
    [BlackList] // 0x00000001899C6220-0x00000001899C6270
                // [IDTag] // 0x00000001899C6220-0x00000001899C6270
                // [XID] // 0x00000001899C6220-0x00000001899C6270
    public static bool EnumStrToVal(string str, out ConfigShadowResolution e)
    {
        e = default;
        return default;
    } // 0x0000000180D5FD40-0x0000000180D5FF10
    [BlackList] // 0x00000001899D3750-0x00000001899D37A0
                // [IDTag] // 0x00000001899D3750-0x00000001899D37A0
                // [XID] // 0x00000001899D3750-0x00000001899D37A0
    public static bool EnumStrToVal(string str, out ConfigGraphicSettingEntrySortType e)
    {
        e = default;
        return default;
    } // 0x0000000180D69960-0x0000000180D69AF0
    [BlackList] // 0x00000001899E0B40-0x00000001899E0B90
                // [IDTag] // 0x00000001899E0B40-0x00000001899E0B90
                // [XID] // 0x00000001899E0B40-0x00000001899E0B90
    public static bool ArrayFromJson(JSONNode node, out ConfigGraphicsSettingEntry[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC5A30-0x0000000180DC5DB0
      // [IDTag] // 0x00000001899EE2E0-0x00000001899EE320
      // [XID] // 0x00000001899EE2E0-0x00000001899EE320
    private static bool InternalArrayFromJson(JSONNode node, out ConfigGraphicsSettingEntry[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7DC20-0x0000000180D7DED0
    [BlackList] // 0x00000001899F8B80-0x00000001899F8BD0
                // [IDTag] // 0x00000001899F8B80-0x00000001899F8BD0
                // [XID] // 0x00000001899F8B80-0x00000001899F8BD0
    public static bool EnumStrToVal(string str, out VolatileType e)
    {
        e = default;
        return default;
    } // 0x0000000180D43CB0-0x0000000180D43FC0
    [BlackList] // 0x0000000189A06400-0x0000000189A06450
                // [IDTag] // 0x0000000189A06400-0x0000000189A06450
                // [XID] // 0x0000000189A06400-0x0000000189A06450
    public static bool EnumStrToVal(string str, out OptionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D76E90-0x0000000180D770E0
    [BlackList] // 0x0000000189A139D0-0x0000000189A13A20
                // [IDTag] // 0x0000000189A139D0-0x0000000189A13A20
                // [XID] // 0x0000000189A139D0-0x0000000189A13A20
    public static bool DictFromJson(JSONNode node, out Dictionary<OptionType, ConfigPostprocessEffectSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC94A0-0x0000000180CC9820
      // [IDTag] // 0x0000000189A20AA0-0x0000000189A20AE0
      // [XID] // 0x0000000189A20AA0-0x0000000189A20AE0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<OptionType, ConfigPostprocessEffectSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D384E0-0x0000000180D38B00
    [BlackList] // 0x0000000189A2AE40-0x0000000189A2AE90
                // [IDTag] // 0x0000000189A2AE40-0x0000000189A2AE90
                // [XID] // 0x0000000189A2AE40-0x0000000189A2AE90
    public static bool EnumStrToVal(string str, out ParticleEmitLevelType e)
    {
        e = default;
        return default;
    } // 0x0000000180D75B70-0x0000000180D75D40
    [BlackList] // 0x0000000189A386C0-0x0000000189A38710
                // [IDTag] // 0x0000000189A386C0-0x0000000189A38710
                // [XID] // 0x0000000189A386C0-0x0000000189A38710
    public static bool EnumStrToVal(string str, out LightLevel e)
    {
        e = default;
        return default;
    } // 0x0000000180D73DE0-0x0000000180D73FB0
    [BlackList] // 0x0000000189A45D20-0x0000000189A45D70
                // [IDTag] // 0x0000000189A45D20-0x0000000189A45D70
                // [XID] // 0x0000000189A45D20-0x0000000189A45D70
    public static bool DictFromJson(JSONNode node, out Dictionary<OptionType, ConfigParticleEffectSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD4AA0-0x0000000180CD4E20
      // [IDTag] // 0x0000000189A53340-0x0000000189A53380
      // [XID] // 0x0000000189A53340-0x0000000189A53380
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<OptionType, ConfigParticleEffectSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D11F00-0x0000000180D12520
    [BlackList] // 0x0000000189A5DE80-0x0000000189A5DED0
                // [IDTag] // 0x0000000189A5DE80-0x0000000189A5DED0
                // [XID] // 0x0000000189A5DE80-0x0000000189A5DED0
    public static bool DictFromJson(JSONNode node, out Dictionary<OptionType, ConfigComprehensiveQualitySetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC0C20-0x0000000180CC0FA0
      // [IDTag] // 0x0000000189A6B890-0x0000000189A6B8D0
      // [XID] // 0x0000000189A6B890-0x0000000189A6B8D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<OptionType, ConfigComprehensiveQualitySetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D20550-0x0000000180D20B70
    [BlackList] // 0x0000000189A75E50-0x0000000189A75EA0
                // [IDTag] // 0x0000000189A75E50-0x0000000189A75EA0
                // [XID] // 0x0000000189A75E50-0x0000000189A75EA0
    public static bool DictFromJson(JSONNode node, out Dictionary<VolatileType, ConfigGraphicsVolatileSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE2720-0x0000000180CE2AA0
      // [IDTag] // 0x0000000189A83A20-0x0000000189A83A60
      // [XID] // 0x0000000189A83A20-0x0000000189A83A60
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<VolatileType, ConfigGraphicsVolatileSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D08AB0-0x0000000180D090D0
    [BlackList] // 0x0000000189A8E350-0x0000000189A8E3A0
                // [IDTag] // 0x0000000189A8E350-0x0000000189A8E3A0
                // [XID] // 0x0000000189A8E350-0x0000000189A8E3A0
    public static bool ArrayFromJson(JSONNode node, out ConfigGraphicsRequirement[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBBCB0-0x0000000180DBC030
      // [IDTag] // 0x0000000189A9B880-0x0000000189A9B8C0
      // [XID] // 0x0000000189A9B880-0x0000000189A9B8C0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigGraphicsRequirement[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D964A0-0x0000000180D96750
    [BlackList] // 0x0000000189AA5EB0-0x0000000189AA5F00
                // [IDTag] // 0x0000000189AA5EB0-0x0000000189AA5F00
                // [XID] // 0x0000000189AA5EB0-0x0000000189AA5F00
    public static bool DictFromJson(JSONNode node, out Dictionary<ShadowQuality, ConfigShadowQualitySetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBCD20-0x0000000180CBD0A0
      // [IDTag] // 0x0000000189AB36F0-0x0000000189AB3730
      // [XID] // 0x0000000189AB36F0-0x0000000189AB3730
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ShadowQuality, ConfigShadowQualitySetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFC030-0x0000000180CFC640
    [BlackList] // 0x0000000189ABE210-0x0000000189ABE260
                // [IDTag] // 0x0000000189ABE210-0x0000000189ABE260
                // [XID] // 0x0000000189ABE210-0x0000000189ABE260
    public static bool ArrayFromJson(JSONNode node, out ConfigRenderResolution[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAE3B0-0x0000000180DAE730
      // [IDTag] // 0x0000000189ACB9A0-0x0000000189ACB9E0
      // [XID] // 0x0000000189ACB9A0-0x0000000189ACB9E0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigRenderResolution[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D95490-0x0000000180D95740
    [BlackList] // 0x0000000189AD6840-0x0000000189AD6890
                // [IDTag] // 0x0000000189AD6840-0x0000000189AD6890
                // [XID] // 0x0000000189AD6840-0x0000000189AD6890
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigGraphicsRecommendSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBC2A0-0x0000000180CBC620
      // [IDTag] // 0x0000000189AE42A0-0x0000000189AE42E0
      // [XID] // 0x0000000189AE42A0-0x0000000189AE42E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigGraphicsRecommendSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D015F0-0x0000000180D01B20
    [BlackList] // 0x0000000189AEEE30-0x0000000189AEEE80
                // [IDTag] // 0x0000000189AEEE30-0x0000000189AEEE80
                // [XID] // 0x0000000189AEEE30-0x0000000189AEEE80
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigPerformanceSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBDEA0-0x0000000180CBE220
      // [IDTag] // 0x0000000189AFBFF0-0x0000000189AFC030
      // [XID] // 0x0000000189AFBFF0-0x0000000189AFC030
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigPerformanceSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1F020-0x0000000180D1F550
    [BlackList] // 0x0000000189B06910-0x0000000189B06960
                // [IDTag] // 0x0000000189B06910-0x0000000189B06960
                // [XID] // 0x0000000189B06910-0x0000000189B06960
    public static bool ArrayFromJson(JSONNode node, out VolatileType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCE9B0-0x0000000180DCED30
      // [IDTag] // 0x0000000189B13D00-0x0000000189B13D40
      // [XID] // 0x0000000189B13D00-0x0000000189B13D40
    private static bool InternalArrayFromJson(JSONNode node, out VolatileType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8E900-0x0000000180D8EBC0
    [BlackList] // 0x0000000189B1E200-0x0000000189B1E250
                // [IDTag] // 0x0000000189B1E200-0x0000000189B1E250
                // [XID] // 0x0000000189B1E200-0x0000000189B1E250
    public static bool EnumStrToVal(string str, out PerfCostRatioGrade e)
    {
        e = default;
        return default;
    } // 0x0000000180D72410-0x0000000180D72620
    [BlackList] // 0x0000000189B2B7C0-0x0000000189B2B810
                // [IDTag] // 0x0000000189B2B7C0-0x0000000189B2B810
                // [XID] // 0x0000000189B2B7C0-0x0000000189B2B810
    public static bool DictFromJson(JSONNode node, out Dictionary<PerfCostRatioGrade, float> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD9B20-0x0000000180CD9EA0
      // [IDTag] // 0x0000000189B38C10-0x0000000189B38C50
      // [XID] // 0x0000000189B38C10-0x0000000189B38C50
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<PerfCostRatioGrade, float> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D337A0-0x0000000180D33DD0
    [BlackList] // 0x0000000189B43750-0x0000000189B437A0
                // [IDTag] // 0x0000000189B43750-0x0000000189B437A0
                // [XID] // 0x0000000189B43750-0x0000000189B437A0
    public static bool DictFromJson(JSONNode node, out Dictionary<PerfCostRatioGrade, SimpleSafeFloat> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD5C20-0x0000000180CD5FA0
      // [IDTag] // 0x0000000189B510A0-0x0000000189B510E0
      // [XID] // 0x0000000189B510A0-0x0000000189B510E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<PerfCostRatioGrade, SimpleSafeFloat> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D29610-0x0000000180D29C70
    [BlackList] // 0x0000000189B5B910-0x0000000189B5B960
                // [IDTag] // 0x0000000189B5B910-0x0000000189B5B960
                // [XID] // 0x0000000189B5B910-0x0000000189B5B960
    public static bool DictFromJson(JSONNode node, out Dictionary<FadeTintQualityLevel, ConfigTintFadeSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC6E20-0x0000000180CC71A0
      // [IDTag] // 0x0000000189B69040-0x0000000189B69080
      // [XID] // 0x0000000189B69040-0x0000000189B69080
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<FadeTintQualityLevel, ConfigTintFadeSetting> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D31050-0x0000000180D31670
    [BlackList] // 0x0000000189B73430-0x0000000189B73480
                // [IDTag] // 0x0000000189B73430-0x0000000189B73480
                // [XID] // 0x0000000189B73430-0x0000000189B73480
    public static bool EnumStrToVal(string str, out GroupEntityType e)
    {
        e = default;
        return default;
    } // 0x0000000180D73BD0-0x0000000180D73DE0
    [BlackList] // 0x0000000189B806F0-0x0000000189B80740
                // [IDTag] // 0x0000000189B806F0-0x0000000189B80740
                // [XID] // 0x0000000189B806F0-0x0000000189B80740
    public static bool EnumStrToVal(string str, out GuideOpenStateType e)
    {
        e = default;
        return default;
    } // 0x0000000180D3F040-0x0000000180D3FFB0
    [BlackList] // 0x0000000189B8DD80-0x0000000189B8DDD0
                // [IDTag] // 0x0000000189B8DD80-0x0000000189B8DDD0
                // [XID] // 0x0000000189B8DD80-0x0000000189B8DDD0
    public static bool EnumStrToVal(string str, out GuidePageType e)
    {
        e = default;
        return default;
    } // 0x0000000180D67E20-0x0000000180D681F0
    [BlackList] // 0x0000000189B9B390-0x0000000189B9B3E0
                // [IDTag] // 0x0000000189B9B390-0x0000000189B9B3E0
                // [XID] // 0x0000000189B9B390-0x0000000189B9B3E0
    public static bool EnumStrToVal(string str, out GuideOperator e)
    {
        e = default;
        return default;
    } // 0x0000000180D50D90-0x0000000180D50FA0
    [BlackList] // 0x0000000189BA85F0-0x0000000189BA8640
                // [IDTag] // 0x0000000189BA85F0-0x0000000189BA8640
                // [XID] // 0x0000000189BA85F0-0x0000000189BA8640
    public static bool EnumStrToVal(string str, out GuideMultiPlayerMode e)
    {
        e = default;
        return default;
    } // 0x0000000180D56320-0x0000000180D564B0
    [BlackList] // 0x0000000189BB5990-0x0000000189BB59E0
                // [IDTag] // 0x0000000189BB5990-0x0000000189BB59E0
                // [XID] // 0x0000000189BB5990-0x0000000189BB59E0
    public static bool ArrayFromJson(JSONNode node, out ConfigGuideAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA6930-0x0000000180DA6CB0
      // [IDTag] // 0x0000000189BC37F0-0x0000000189BC3830
      // [XID] // 0x0000000189BC37F0-0x0000000189BC3830
    private static bool InternalArrayFromJson(JSONNode node, out ConfigGuideAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D97A20-0x0000000180D97CB0
    [BlackList] // 0x0000000189BCDF80-0x0000000189BCDFD0
                // [IDTag] // 0x0000000189BCDF80-0x0000000189BCDFD0
                // [XID] // 0x0000000189BCDF80-0x0000000189BCDFD0
    public static bool ArrayFromJson(JSONNode node, out ConfigGuideCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB3B30-0x0000000180DB3EB0
      // [IDTag] // 0x0000000189BDB660-0x0000000189BDB6A0
      // [XID] // 0x0000000189BDB660-0x0000000189BDB6A0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigGuideCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D827B0-0x0000000180D82A40
    [BlackList] // 0x00000001895EB200-0x00000001895EB250
                // [IDTag] // 0x00000001895EB200-0x00000001895EB250
                // [XID] // 0x00000001895EB200-0x00000001895EB250
    public static bool ArrayFromJson(JSONNode node, out ConfigGuideCondition[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAB9B0-0x0000000180DABD30
      // [IDTag] // 0x00000001895F8B00-0x00000001895F8B40
      // [XID] // 0x00000001895F8B00-0x00000001895F8B40
    private static bool InternalArrayFromJson(JSONNode node, out ConfigGuideCondition[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8AB10-0x0000000180D8ADC0
    [BlackList] // 0x0000000189602F10-0x0000000189602F60
                // [IDTag] // 0x0000000189602F10-0x0000000189602F60
                // [XID] // 0x0000000189602F10-0x0000000189602F60
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigGuideTask> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCD020-0x0000000180CCD3A0
      // [IDTag] // 0x00000001896108F0-0x0000000189610930
      // [XID] // 0x00000001896108F0-0x0000000189610930
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigGuideTask> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0CFC0-0x0000000180D0D4C0
    [BlackList] // 0x000000018961AF00-0x000000018961AF50
                // [IDTag] // 0x000000018961AF00-0x000000018961AF50
                // [XID] // 0x000000018961AF00-0x000000018961AF50
    public static bool EnumStrToVal(string str, out GuideAvatarState e)
    {
        e = default;
        return default;
    } // 0x0000000180D5E9E0-0x0000000180D5ECF0
    [BlackList] // 0x0000000189628430-0x0000000189628480
                // [IDTag] // 0x0000000189628430-0x0000000189628480
                // [XID] // 0x0000000189628430-0x0000000189628480
    public static bool EnumStrToVal(string str, out GuideButtonClick e)
    {
        e = default;
        return default;
    } // 0x0000000180D61AA0-0x0000000180D61C70
    [BlackList] // 0x0000000189636130-0x0000000189636180
                // [IDTag] // 0x0000000189636130-0x0000000189636180
                // [XID] // 0x0000000189636130-0x0000000189636180
    public static bool EnumStrToVal(string str, out GuideItemType e)
    {
        e = default;
        return default;
    } // 0x0000000180D71370-0x0000000180D71580
    [BlackList] // 0x00000001896436E0-0x0000000189643730
                // [IDTag] // 0x00000001896436E0-0x0000000189643730
                // [XID] // 0x00000001896436E0-0x0000000189643730
    public static bool ArrayFromJson(JSONNode node, out uint[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCA030-0x0000000180DCA3B0
      // [IDTag] // 0x0000000189650CF0-0x0000000189650D30
      // [XID] // 0x0000000189650CF0-0x0000000189650D30
    private static bool InternalArrayFromJson(JSONNode node, out uint[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D97F60-0x0000000180D98210
    [BlackList] // 0x000000018965B600-0x000000018965B650
                // [IDTag] // 0x000000018965B600-0x000000018965B650
                // [XID] // 0x000000018965B600-0x000000018965B650
    public static bool ArrayFromJson(JSONNode node, out SimpleSafeUInt32[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9E7B0-0x0000000180D9EB30
      // [IDTag] // 0x0000000189668E30-0x0000000189668E70
      // [XID] // 0x0000000189668E30-0x0000000189668E70
    private static bool InternalArrayFromJson(JSONNode node, out SimpleSafeUInt32[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8E100-0x0000000180D8E3B0
    [BlackList] // 0x0000000189673680-0x00000001896736D0
                // [IDTag] // 0x0000000189673680-0x00000001896736D0
                // [XID] // 0x0000000189673680-0x00000001896736D0
    public static bool EnumStrToVal(string str, out GuideCameraAction e)
    {
        e = default;
        return default;
    } // 0x0000000180D69510-0x0000000180D69650
    [BlackList] // 0x0000000189681120-0x0000000189681170
                // [IDTag] // 0x0000000189681120-0x0000000189681170
                // [XID] // 0x0000000189681120-0x0000000189681170
    public static bool EnumStrToVal(string str, out GuideAvatarAction e)
    {
        e = default;
        return default;
    } // 0x0000000180D40180-0x0000000180D402C0
    [BlackList] // 0x000000018968EE50-0x000000018968EEA0
                // [IDTag] // 0x000000018968EE50-0x000000018968EEA0
                // [XID] // 0x000000018968EE50-0x000000018968EEA0
    public static bool EnumStrToVal(string str, out GuideHasAvatarType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4BBA0-0x0000000180D4BCE0
    [BlackList] // 0x000000018969C4C0-0x000000018969C510
                // [IDTag] // 0x000000018969C4C0-0x000000018969C510
                // [XID] // 0x000000018969C4C0-0x000000018969C510
    public static bool EnumStrToVal(string str, out GuideHasAvatarConType e)
    {
        e = default;
        return default;
    } // 0x0000000180D77E70-0x0000000180D77FB0
    [BlackList] // 0x00000001896A9740-0x00000001896A9790
                // [IDTag] // 0x00000001896A9740-0x00000001896A9790
                // [XID] // 0x00000001896A9740-0x00000001896A9790
    public static bool EnumStrToVal(string str, out GuideNavigationType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4BCE0-0x0000000180D4BE70
    [BlackList] // 0x00000001896B68C0-0x00000001896B6910
                // [IDTag] // 0x00000001896B68C0-0x00000001896B6910
                // [XID] // 0x00000001896B68C0-0x00000001896B6910
    public static bool EnumStrToVal(string str, out GuideNavigationCheckType e)
    {
        e = default;
        return default;
    } // 0x0000000180D53AE0-0x0000000180D53C70
    [BlackList] // 0x00000001896C3BE0-0x00000001896C3C30
                // [IDTag] // 0x00000001896C3BE0-0x00000001896C3C30
                // [XID] // 0x00000001896C3BE0-0x00000001896C3C30
    public static bool EnumStrToVal(string str, out GuideVirtualDialAction e)
    {
        e = default;
        return default;
    } // 0x0000000180D605F0-0x0000000180D60B80
    [BlackList] // 0x00000001896D1020-0x00000001896D1070
                // [IDTag] // 0x00000001896D1020-0x00000001896D1070
                // [XID] // 0x00000001896D1020-0x00000001896D1070
    public static bool EnumStrToVal(string str, out GuidePlatform e)
    {
        e = default;
        return default;
    } // 0x0000000180D49230-0x0000000180D49480
    [BlackList] // 0x00000001896DE730-0x00000001896DE780
                // [IDTag] // 0x00000001896DE730-0x00000001896DE780
                // [XID] // 0x00000001896DE730-0x00000001896DE780
    public static bool EnumStrToVal(string str, out GuideLevelType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5AA00-0x0000000180D5AB90
    [BlackList] // 0x00000001896EBB40-0x00000001896EBB90
                // [IDTag] // 0x00000001896EBB40-0x00000001896EBB90
                // [XID] // 0x00000001896EBB40-0x00000001896EBB90
    public static bool EnumStrToVal(string str, out GuideKeyClick e)
    {
        e = default;
        return default;
    } // 0x0000000180D43420-0x0000000180D435B0
    [BlackList] // 0x00000001896F8D40-0x00000001896F8D90
                // [IDTag] // 0x00000001896F8D40-0x00000001896F8D90
                // [XID] // 0x00000001896F8D40-0x00000001896F8D90
    public static bool EnumStrToVal(string str, out ButtonGuideType e)
    {
        e = default;
        return default;
    } // 0x0000000180D435B0-0x0000000180D43740
    [BlackList] // 0x00000001897065A0-0x00000001897065F0
                // [IDTag] // 0x00000001897065A0-0x00000001897065F0
                // [XID] // 0x00000001897065A0-0x00000001897065F0
    public static bool EnumStrToVal(string str, out MaskGuideType e)
    {
        e = default;
        return default;
    } // 0x0000000180D73730-0x0000000180D738C0
    [BlackList] // 0x0000000189713EE0-0x0000000189713F30
                // [IDTag] // 0x0000000189713EE0-0x0000000189713F30
                // [XID] // 0x0000000189713EE0-0x0000000189713F30
    public static bool EnumStrToVal(string str, out WidgetInfoPos e)
    {
        e = default;
        return default;
    } // 0x0000000180D55960-0x0000000180D55CA0
    [BlackList] // 0x0000000189721410-0x0000000189721460
                // [IDTag] // 0x0000000189721410-0x0000000189721460
                // [XID] // 0x0000000189721410-0x0000000189721460
    public static bool EnumStrToVal(string str, out GuideWidgetSpecialType e)
    {
        e = default;
        return default;
    } // 0x0000000180D42740-0x0000000180D42B40
    [BlackList] // 0x000000018972EA40-0x000000018972EA90
                // [IDTag] // 0x000000018972EA40-0x000000018972EA90
                // [XID] // 0x000000018972EA40-0x000000018972EA90
    public static bool ArrayFromJson(JSONNode node, out InputActionType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB7DB0-0x0000000180DB8130
      // [IDTag] // 0x000000018973C350-0x000000018973C390
      // [XID] // 0x000000018973C350-0x000000018973C390
    private static bool InternalArrayFromJson(JSONNode node, out InputActionType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8D380-0x0000000180D8D640
    [BlackList] // 0x0000000189746B50-0x0000000189746BA0
                // [IDTag] // 0x0000000189746B50-0x0000000189746BA0
                // [XID] // 0x0000000189746B50-0x0000000189746BA0
    public static bool ArrayFromJson(JSONNode node, out ConfigInputHint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC80B0-0x0000000180DC8430
      // [IDTag] // 0x00000001897541E0-0x0000000189754220
      // [XID] // 0x00000001897541E0-0x0000000189754220
    private static bool InternalArrayFromJson(JSONNode node, out ConfigInputHint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8A860-0x0000000180D8AB10
    [BlackList] // 0x000000018975E840-0x000000018975E890
                // [IDTag] // 0x000000018975E840-0x000000018975E890
                // [XID] // 0x000000018975E840-0x000000018975E890
    public static bool ArrayFromJson(JSONNode node, out ConfigGuideWidgetContent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC8B30-0x0000000180DC8EB0
      // [IDTag] // 0x000000018976BFA0-0x000000018976BFE0
      // [XID] // 0x000000018976BFA0-0x000000018976BFE0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigGuideWidgetContent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7D160-0x0000000180D7D410
    [BlackList] // 0x00000001897766B0-0x0000000189776700
                // [IDTag] // 0x00000001897766B0-0x0000000189776700
                // [XID] // 0x00000001897766B0-0x0000000189776700
    public static bool EnumStrToVal(string str, out PersistentFurnitureType e)
    {
        e = default;
        return default;
    } // 0x0000000180D45830-0x0000000180D45B40
    [BlackList] // 0x0000000189783E10-0x0000000189783E60
                // [IDTag] // 0x0000000189783E10-0x0000000189783E60
                // [XID] // 0x0000000189783E10-0x0000000189783E60
    public static bool ArrayFromJson(JSONNode node, out ConfigHomeworldFurnitureUnit[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBF4B0-0x0000000180DBF830
      // [IDTag] // 0x0000000189791210-0x0000000189791250
      // [XID] // 0x0000000189791210-0x0000000189791250
    private static bool InternalArrayFromJson(JSONNode node, out ConfigHomeworldFurnitureUnit[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D92EF0-0x0000000180D931A0
    [BlackList] // 0x000000018979C280-0x000000018979C2D0
                // [IDTag] // 0x000000018979C280-0x000000018979C2D0
                // [XID] // 0x000000018979C280-0x000000018979C2D0
    public static bool EnumStrToVal(string str, out InterPriorityType e)
    {
        e = default;
        return default;
    } // 0x0000000180D43AE0-0x0000000180D43CB0
    [BlackList] // 0x00000001897A96E0-0x00000001897A9730
                // [IDTag] // 0x00000001897A96E0-0x00000001897A9730
                // [XID] // 0x00000001897A96E0-0x00000001897A9730
    public static bool EnumStrToVal(string str, out InteractionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5DAE0-0x0000000180D5E480
    [BlackList] // 0x00000001897B76D0-0x00000001897B7720
                // [IDTag] // 0x00000001897B76D0-0x00000001897B7720
                // [XID] // 0x00000001897B76D0-0x00000001897B7720
    public static bool EnumStrToVal(string str, out AnimatorParamType2 e)
    {
        e = default;
        return default;
    } // 0x0000000180D67510-0x0000000180D676E0
    [BlackList] // 0x00000001897C51B0-0x00000001897C5200
                // [IDTag] // 0x00000001897C51B0-0x00000001897C5200
                // [XID] // 0x00000001897C51B0-0x00000001897C5200
    public static bool EnumStrToVal(string str, out DialogType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6B9D0-0x0000000180D6BBA0
    [BlackList] // 0x00000001897D28F0-0x00000001897D2940
                // [IDTag] // 0x00000001897D28F0-0x00000001897D2940
                // [XID] // 0x00000001897D28F0-0x00000001897D2940
    public static bool EnumStrToVal(string str, out DialogSteerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6C3D0-0x0000000180D6C710
    [BlackList] // 0x00000001897E0250-0x00000001897E02A0
                // [IDTag] // 0x00000001897E0250-0x00000001897E02A0
                // [XID] // 0x00000001897E0250-0x00000001897E02A0
    public static bool EnumStrToVal(string str, out StoryCameraPosType e)
    {
        e = default;
        return default;
    } // 0x0000000180D48150-0x0000000180D484F0
    [BlackList] // 0x00000001897EDDD0-0x00000001897EDE20
                // [IDTag] // 0x00000001897EDDD0-0x00000001897EDE20
                // [XID] // 0x00000001897EDDD0-0x00000001897EDE20
    public static bool EnumStrToVal(string str, out StoryCameraTargetType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5B760-0x0000000180D5BAA0
    [BlackList] // 0x00000001897FB950-0x00000001897FB9A0
                // [IDTag] // 0x00000001897FB950-0x00000001897FB9A0
                // [XID] // 0x00000001897FB950-0x00000001897FB9A0
    public static bool EnumStrToVal(string str, out BlackScreenType e)
    {
        e = default;
        return default;
    } // 0x0000000180D54C30-0x0000000180D54E40
    [BlackList] // 0x0000000189808A60-0x0000000189808AB0
                // [IDTag] // 0x0000000189808A60-0x0000000189808AB0
                // [XID] // 0x0000000189808A60-0x0000000189808AB0
    public static bool EnumStrToVal(string str, out EmoBackType e)
    {
        e = default;
        return default;
    } // 0x0000000180D74960-0x0000000180D74AF0
    [BlackList] // 0x0000000189816150-0x00000001898161A0
                // [IDTag] // 0x0000000189816150-0x00000001898161A0
                // [XID] // 0x0000000189816150-0x00000001898161A0
    public static bool EnumStrToVal(string str, out MoveToType e)
    {
        e = default;
        return default;
    } // 0x0000000180D443A0-0x0000000180D44570
    [BlackList] // 0x0000000189823810-0x0000000189823860
                // [IDTag] // 0x0000000189823810-0x0000000189823860
                // [XID] // 0x0000000189823810-0x0000000189823860
    public static bool EnumStrToVal(string str, out StandDirection e)
    {
        e = default;
        return default;
    } // 0x0000000180D53110-0x0000000180D532A0
    [BlackList] // 0x0000000189830EA0-0x0000000189830EF0
                // [IDTag] // 0x0000000189830EA0-0x0000000189830EF0
                // [XID] // 0x0000000189830EA0-0x0000000189830EF0
    public static bool EnumStrToVal(string str, out RemoveActorType e)
    {
        e = default;
        return default;
    } // 0x0000000180D42270-0x0000000180D42400
    [BlackList] // 0x000000018983E3C0-0x000000018983E410
                // [IDTag] // 0x000000018983E3C0-0x000000018983E410
                // [XID] // 0x000000018983E3C0-0x000000018983E410
    public static bool EnumStrToVal(string str, out LookAtTargetType e)
    {
        e = default;
        return default;
    } // 0x0000000180D75F10-0x0000000180D760A0
    [BlackList] // 0x000000018984B970-0x000000018984B9C0
                // [IDTag] // 0x000000018984B970-0x000000018984B9C0
                // [XID] // 0x000000018984B970-0x000000018984B9C0
    public static bool ArrayFromJson(JSONNode node, out ConfigInterActor[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAA4B0-0x0000000180DAA830
      // [IDTag] // 0x0000000189858D00-0x0000000189858D40
      // [XID] // 0x0000000189858D00-0x0000000189858D40
    private static bool InternalArrayFromJson(JSONNode node, out ConfigInterActor[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9CF80-0x0000000180D9D230
    [BlackList] // 0x0000000189863170-0x00000001898631C0
                // [IDTag] // 0x0000000189863170-0x00000001898631C0
                // [XID] // 0x0000000189863170-0x00000001898631C0
    public static bool ArrayFromJson(JSONNode node, out ConfigBaseInterAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC3E30-0x0000000180DC41B0
      // [IDTag] // 0x0000000189870240-0x0000000189870280
      // [XID] // 0x0000000189870240-0x0000000189870280
    private static bool InternalArrayFromJson(JSONNode node, out ConfigBaseInterAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8F3D0-0x0000000180D8F660
    [BlackList] // 0x000000018987AE30-0x000000018987AE80
                // [IDTag] // 0x000000018987AE30-0x000000018987AE80
                // [XID] // 0x000000018987AE30-0x000000018987AE80
    public static bool ArrayFromJson(JSONNode node, out ConfigBaseInterAction[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC7630-0x0000000180DC79B0
      // [IDTag] // 0x0000000189887DC0-0x0000000189887E00
      // [XID] // 0x0000000189887DC0-0x0000000189887E00
    private static bool InternalArrayFromJson(JSONNode node, out ConfigBaseInterAction[][] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8B320-0x0000000180D8B5D0
    [BlackList] // 0x0000000189892000-0x0000000189892050
                // [IDTag] // 0x0000000189892000-0x0000000189892050
                // [XID] // 0x0000000189892000-0x0000000189892050
    public static bool ArrayFromJson(JSONNode node, out ConfigInterGrpId[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC95B0-0x0000000180DC9930
      // [IDTag] // 0x000000018989F260-0x000000018989F2A0
      // [XID] // 0x000000018989F260-0x000000018989F2A0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigInterGrpId[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D98F90-0x0000000180D99240
    [BlackList] // 0x00000001898A9A10-0x00000001898A9A60
                // [IDTag] // 0x00000001898A9A10-0x00000001898A9A60
                // [XID] // 0x00000001898A9A10-0x00000001898A9A60
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigLCBaseIntee> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB7920-0x0000000180CB7CA0
      // [IDTag] // 0x00000001898B7210-0x00000001898B7250
      // [XID] // 0x00000001898B7210-0x00000001898B7250
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigLCBaseIntee> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2F030-0x0000000180D2F520
    [BlackList] // 0x00000001898C1A00-0x00000001898C1A50
                // [IDTag] // 0x00000001898C1A00-0x00000001898C1A50
                // [XID] // 0x00000001898C1A00-0x00000001898C1A50
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigLCGadgetIntee> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD43A0-0x0000000180CD4720
      // [IDTag] // 0x00000001898CF410-0x00000001898CF450
      // [XID] // 0x00000001898CF410-0x00000001898CF450
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigLCGadgetIntee> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D31670-0x0000000180D31BA0
    [BlackList] // 0x00000001898D9C50-0x00000001898D9CA0
                // [IDTag] // 0x00000001898D9C50-0x00000001898D9CA0
                // [XID] // 0x00000001898D9C50-0x00000001898D9CA0
    public static bool EnumStrToVal(string str, out KeyboardType e)
    {
        e = default;
        return default;
    } // 0x0000000180D780F0-0x0000000180D782C0
    [BlackList] // 0x00000001898E7BD0-0x00000001898E7C20
                // [IDTag] // 0x00000001898E7BD0-0x00000001898E7C20
                // [XID] // 0x00000001898E7BD0-0x00000001898E7C20
    public static bool EnumStrToVal(string str, out InputActionGroupType e)
    {
        e = default;
        return default;
    } // 0x0000000180D48A90-0x0000000180D48C20
    [BlackList] // 0x00000001898F5320-0x00000001898F5370
                // [IDTag] // 0x00000001898F5320-0x00000001898F5370
                // [XID] // 0x00000001898F5320-0x00000001898F5370
    public static bool DictFromJson(JSONNode node, out Dictionary<ConfigKeyCode, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDE4A0-0x0000000180CDE820
      // [IDTag] // 0x0000000189902C50-0x0000000189902C90
      // [XID] // 0x0000000189902C50-0x0000000189902C90
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ConfigKeyCode, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2BCE0-0x0000000180D2C2E0
    [BlackList] // 0x000000018990D430-0x000000018990D480
                // [IDTag] // 0x000000018990D430-0x000000018990D480
                // [XID] // 0x000000018990D430-0x000000018990D480
    public static bool DictFromJson(JSONNode node, out Dictionary<KeyboardType, ConfigKeyboardLayoutItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE7B20-0x0000000180CE7EA0
      // [IDTag] // 0x000000018991ADC0-0x000000018991AE00
      // [XID] // 0x000000018991ADC0-0x000000018991AE00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<KeyboardType, ConfigKeyboardLayoutItem> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D39760-0x0000000180D39D60
    [BlackList] // 0x0000000189925520-0x0000000189925570
                // [IDTag] // 0x0000000189925520-0x0000000189925570
                // [XID] // 0x0000000189925520-0x0000000189925570
    public static bool DictFromJson(JSONNode node, out Dictionary<InputActionGroupType, InputActionType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDA220-0x0000000180CDA5A0
      // [IDTag] // 0x0000000189932C40-0x0000000189932C80
      // [XID] // 0x0000000189932C40-0x0000000189932C80
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<InputActionGroupType, InputActionType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEAF20-0x0000000180CEB520
    [BlackList] // 0x000000018993D470-0x000000018993D4C0
                // [IDTag] // 0x000000018993D470-0x000000018993D4C0
                // [XID] // 0x000000018993D470-0x000000018993D4C0
    public static bool EnumStrToVal(string str, out ConfigKeyCode e)
    {
        e = default;
        return default;
    } // 0x0000000180D6D560-0x0000000180D70F60
    [BlackList] // 0x000000018994A740-0x000000018994A790
                // [IDTag] // 0x000000018994A740-0x000000018994A790
                // [XID] // 0x000000018994A740-0x000000018994A790
    public static bool ArrayFromJson(JSONNode node, out TextLanguageType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC25B0-0x0000000180DC2930
      // [IDTag] // 0x0000000189958070-0x00000001899580B0
      // [XID] // 0x0000000189958070-0x00000001899580B0
    private static bool InternalArrayFromJson(JSONNode node, out TextLanguageType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D95740-0x0000000180D95A00
    [BlackList] // 0x0000000189962B30-0x0000000189962B80
                // [IDTag] // 0x0000000189962B30-0x0000000189962B80
                // [XID] // 0x0000000189962B30-0x0000000189962B80
    public static bool DictFromJson(JSONNode node, out Dictionary<string, TextLanguageType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBE5A0-0x0000000180CBE920
      // [IDTag] // 0x000000018996FC70-0x000000018996FCB0
      // [XID] // 0x000000018996FC70-0x000000018996FCB0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, TextLanguageType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2F520-0x0000000180D2FA20
    [BlackList] // 0x000000018997A990-0x000000018997A9E0
                // [IDTag] // 0x000000018997A990-0x000000018997A9E0
                // [XID] // 0x000000018997A990-0x000000018997A9E0
    public static bool ArrayFromJson(JSONNode node, out VoiceLanguageType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB2D30-0x0000000180DB30B0
      // [IDTag] // 0x0000000189987F80-0x0000000189987FC0
      // [XID] // 0x0000000189987F80-0x0000000189987FC0
    private static bool InternalArrayFromJson(JSONNode node, out VoiceLanguageType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D951D0-0x0000000180D95490
    [BlackList] // 0x0000000189992D90-0x0000000189992DE0
                // [IDTag] // 0x0000000189992D90-0x0000000189992DE0
                // [XID] // 0x0000000189992D90-0x0000000189992DE0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, VoiceLanguageType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDBAA0-0x0000000180CDBE20
      // [IDTag] // 0x00000001899A0700-0x00000001899A0740
      // [XID] // 0x00000001899A0700-0x00000001899A0740
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, VoiceLanguageType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0B8E0-0x0000000180D0BDE0
    [BlackList] // 0x00000001899AB1C0-0x00000001899AB210
                // [IDTag] // 0x00000001899AB1C0-0x00000001899AB210
                // [XID] // 0x00000001899AB1C0-0x00000001899AB210
    public static bool EnumStrToVal(string str, out TextLanguageType e)
    {
        e = default;
        return default;
    } // 0x0000000180D453D0-0x0000000180D45830
    [BlackList] // 0x00000001899B8640-0x00000001899B8690
                // [IDTag] // 0x00000001899B8640-0x00000001899B8690
                // [XID] // 0x00000001899B8640-0x00000001899B8690
    public static bool EnumStrToVal(string str, out VoiceLanguageType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5AF60-0x0000000180D5B130
    [BlackList] // 0x00000001899C61D0-0x00000001899C6220
                // [IDTag] // 0x00000001899C61D0-0x00000001899C6220
                // [XID] // 0x00000001899C61D0-0x00000001899C6220
    public static bool ArrayFromJson(JSONNode node, out ConfigActionPoint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAFC30-0x0000000180DAFFB0
      // [IDTag] // 0x00000001899D3710-0x00000001899D3750
      // [XID] // 0x00000001899D3710-0x00000001899D3750
    private static bool InternalArrayFromJson(JSONNode node, out ConfigActionPoint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8CB70-0x0000000180D8CE20
    [BlackList] // 0x00000001899DDBF0-0x00000001899DDC40
                // [IDTag] // 0x00000001899DDBF0-0x00000001899DDC40
                // [XID] // 0x00000001899DDBF0-0x00000001899DDC40
    public static bool EnumStrToVal(string str, out ChestShowMoment e)
    {
        e = default;
        return default;
    } // 0x0000000180D59360-0x0000000180D594F0
    [BlackList] // 0x00000001899EB120-0x00000001899EB170
                // [IDTag] // 0x00000001899EB120-0x00000001899EB170
                // [XID] // 0x00000001899EB120-0x00000001899EB170
    public static bool EnumStrToVal(string str, out ChestShowUIRemind e)
    {
        e = default;
        return default;
    } // 0x0000000180D56000-0x0000000180D56190
    [BlackList] // 0x00000001899F8B30-0x00000001899F8B80
                // [IDTag] // 0x00000001899F8B30-0x00000001899F8B80
                // [XID] // 0x00000001899F8B30-0x00000001899F8B80
    public static bool EnumStrToVal(string str, out ChestShowCutsceneType e)
    {
        e = default;
        return default;
    } // 0x0000000180D762F0-0x0000000180D76480
    [BlackList] // 0x0000000189A063B0-0x0000000189A06400
                // [IDTag] // 0x0000000189A063B0-0x0000000189A06400
                // [XID] // 0x0000000189A063B0-0x0000000189A06400
    public static bool EnumStrToVal(string str, out IndicatorDistanceInfoType e)
    {
        e = default;
        return default;
    } // 0x0000000180D611A0-0x0000000180D61330
    [BlackList] // 0x0000000189A13980-0x0000000189A139D0
                // [IDTag] // 0x0000000189A13980-0x0000000189A139D0
                // [XID] // 0x0000000189A13980-0x0000000189A139D0
    public static bool EnumStrToVal(string str, out IndicatorOperator e)
    {
        e = default;
        return default;
    } // 0x0000000180D64540-0x0000000180D64680
    [BlackList] // 0x0000000189A20A50-0x0000000189A20AA0
                // [IDTag] // 0x0000000189A20A50-0x0000000189A20AA0
                // [XID] // 0x0000000189A20A50-0x0000000189A20AA0
    public static bool ArrayFromJson(JSONNode node, out IndicatorCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC2230-0x0000000180DC25B0
      // [IDTag] // 0x0000000189A2DBB0-0x0000000189A2DBF0
      // [XID] // 0x0000000189A2DBB0-0x0000000189A2DBF0
    private static bool InternalArrayFromJson(JSONNode node, out IndicatorCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D87560-0x0000000180D877F0
    [BlackList] // 0x0000000189A38670-0x0000000189A386C0
                // [IDTag] // 0x0000000189A38670-0x0000000189A386C0
                // [XID] // 0x0000000189A38670-0x0000000189A386C0
    public static bool ArrayFromJson(JSONNode node, out IndicatorLogic[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA50B0-0x0000000180DA5430
      // [IDTag] // 0x0000000189A45CE0-0x0000000189A45D20
      // [XID] // 0x0000000189A45CE0-0x0000000189A45D20
    private static bool InternalArrayFromJson(JSONNode node, out IndicatorLogic[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D994F0-0x0000000180D997A0
    [BlackList] // 0x0000000189A50520-0x0000000189A50570
                // [IDTag] // 0x0000000189A50520-0x0000000189A50570
                // [XID] // 0x0000000189A50520-0x0000000189A50570
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigUIIndicator> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC9820-0x0000000180CC9BA0
      // [IDTag] // 0x0000000189A5DE40-0x0000000189A5DE80
      // [XID] // 0x0000000189A5DE40-0x0000000189A5DE80
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigUIIndicator> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D06FE0-0x0000000180D074E0
    [BlackList] // 0x0000000189A68AB0-0x0000000189A68B00
                // [IDTag] // 0x0000000189A68AB0-0x0000000189A68B00
                // [XID] // 0x0000000189A68AB0-0x0000000189A68B00
    public static bool ArrayFromJson(JSONNode node, out LevelGadget[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9F230-0x0000000180D9F5B0
      // [IDTag] // 0x0000000189A75E10-0x0000000189A75E50
      // [XID] // 0x0000000189A75E10-0x0000000189A75E50
    private static bool InternalArrayFromJson(JSONNode node, out LevelGadget[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7FF60-0x0000000180D80210
    [BlackList] // 0x0000000189A80520-0x0000000189A80570
                // [IDTag] // 0x0000000189A80520-0x0000000189A80570
                // [XID] // 0x0000000189A80520-0x0000000189A80570
    public static bool ArrayFromJson(JSONNode node, out ConfigLevelBlockMeta[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC6130-0x0000000180DC64B0
      // [IDTag] // 0x0000000189A8E310-0x0000000189A8E350
      // [XID] // 0x0000000189A8E310-0x0000000189A8E350
    private static bool InternalArrayFromJson(JSONNode node, out ConfigLevelBlockMeta[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D88010-0x0000000180D882C0
    [BlackList] // 0x0000000189A98BD0-0x0000000189A98C20
                // [IDTag] // 0x0000000189A98BD0-0x0000000189A98C20
                // [XID] // 0x0000000189A98BD0-0x0000000189A98C20
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ConfigLevelBlockMeta[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD8D20-0x0000000180CD90A0
      // [IDTag] // 0x0000000189AA5E70-0x0000000189AA5EB0
      // [XID] // 0x0000000189AA5E70-0x0000000189AA5EB0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ConfigLevelBlockMeta[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D090D0-0x0000000180D096A0
    [BlackList] // 0x0000000189AB0720-0x0000000189AB0770
                // [IDTag] // 0x0000000189AB0720-0x0000000189AB0770
                // [XID] // 0x0000000189AB0720-0x0000000189AB0770
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigLevelBlockMeta[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCAD20-0x0000000180CCB0A0
      // [IDTag] // 0x0000000189ABE1D0-0x0000000189ABE210
      // [XID] // 0x0000000189ABE1D0-0x0000000189ABE210
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigLevelBlockMeta[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2CF50-0x0000000180D2D580
    [BlackList] // 0x0000000189AC89B0-0x0000000189AC8A00
                // [IDTag] // 0x0000000189AC89B0-0x0000000189AC8A00
                // [XID] // 0x0000000189AC89B0-0x0000000189AC8A00
    public static bool ArrayFromJson(JSONNode node, out ConfigLevelMonsterUnit[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBD1B0-0x0000000180DBD530
      // [IDTag] // 0x0000000189AD6800-0x0000000189AD6840
      // [XID] // 0x0000000189AD6800-0x0000000189AD6840
    private static bool InternalArrayFromJson(JSONNode node, out ConfigLevelMonsterUnit[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D84FC0-0x0000000180D85270
    [BlackList] // 0x0000000189AE11A0-0x0000000189AE11F0
                // [IDTag] // 0x0000000189AE11A0-0x0000000189AE11F0
                // [XID] // 0x0000000189AE11A0-0x0000000189AE11F0
    public static bool EnumStrToVal(string str, out ConfigLevelPolygonTag e)
    {
        e = default;
        return default;
    } // 0x0000000180D42060-0x0000000180D42270
    [BlackList] // 0x0000000189AEEDE0-0x0000000189AEEE30
                // [IDTag] // 0x0000000189AEEDE0-0x0000000189AEEE30
                // [XID] // 0x0000000189AEEDE0-0x0000000189AEEE30
    public static bool ArrayFromJson(JSONNode node, out ConfigLevelPolygonTag[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA7AB0-0x0000000180DA7E30
      // [IDTag] // 0x0000000189AFBFB0-0x0000000189AFBFF0
      // [XID] // 0x0000000189AFBFB0-0x0000000189AFBFF0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigLevelPolygonTag[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D87AA0-0x0000000180D87D60
    [BlackList] // 0x0000000189B068C0-0x0000000189B06910
                // [IDTag] // 0x0000000189B068C0-0x0000000189B06910
                // [XID] // 0x0000000189B068C0-0x0000000189B06910
    public static bool ArrayFromJson(JSONNode node, out ConfigLevelPolygon[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCD830-0x0000000180DCDBB0
      // [IDTag] // 0x0000000189B13CC0-0x0000000189B13D00
      // [XID] // 0x0000000189B13CC0-0x0000000189B13D00
    private static bool InternalArrayFromJson(JSONNode node, out ConfigLevelPolygon[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D85FE0-0x0000000180D86290
    [BlackList] // 0x0000000189B1E1B0-0x0000000189B1E200
                // [IDTag] // 0x0000000189B1E1B0-0x0000000189B1E200
                // [XID] // 0x0000000189B1E1B0-0x0000000189B1E200
    public static bool ArrayFromJson(JSONNode node, out ConfigWaypoint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC72B0-0x0000000180DC7630
      // [IDTag] // 0x0000000189B2B780-0x0000000189B2B7C0
      // [XID] // 0x0000000189B2B780-0x0000000189B2B7C0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigWaypoint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D86540-0x0000000180D867F0
    [BlackList] // 0x0000000189B359E0-0x0000000189B35A30
                // [IDTag] // 0x0000000189B359E0-0x0000000189B35A30
                // [XID] // 0x0000000189B359E0-0x0000000189B35A30
    public static bool EnumStrToVal(string str, out RouteType e)
    {
        e = default;
        return default;
    } // 0x0000000180D54780-0x0000000180D54910
    [BlackList] // 0x0000000189B43700-0x0000000189B43750
                // [IDTag] // 0x0000000189B43700-0x0000000189B43750
                // [XID] // 0x0000000189B43700-0x0000000189B43750
    public static bool EnumStrToVal(string str, out RotType e)
    {
        e = default;
        return default;
    } // 0x0000000180D471D0-0x0000000180D47360
    [BlackList] // 0x0000000189B51050-0x0000000189B510A0
                // [IDTag] // 0x0000000189B51050-0x0000000189B510A0
                // [XID] // 0x0000000189B51050-0x0000000189B510A0
    public static bool EnumStrToVal(string str, out RotAngleType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5C3E0-0x0000000180D5C570
    [BlackList] // 0x0000000189B5E950-0x0000000189B5E9A0
                // [IDTag] // 0x0000000189B5E950-0x0000000189B5E9A0
                // [XID] // 0x0000000189B5E950-0x0000000189B5E9A0
    public static bool ArrayFromJson(JSONNode node, out ConfigRoute[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBC3B0-0x0000000180DBC730
      // [IDTag] // 0x0000000189B6BB70-0x0000000189B6BBB0
      // [XID] // 0x0000000189B6BB70-0x0000000189B6BBB0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigRoute[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8C610-0x0000000180D8C8C0
    [BlackList] // 0x0000000189B76320-0x0000000189B76370
                // [IDTag] // 0x0000000189B76320-0x0000000189B76370
                // [XID] // 0x0000000189B76320-0x0000000189B76370
    public static bool EnumStrToVal(string str, out RouteRecordMode e)
    {
        e = default;
        return default;
    } // 0x0000000180D43290-0x0000000180D43420
    [BlackList] // 0x0000000189B83BA0-0x0000000189B83BF0
                // [IDTag] // 0x0000000189B83BA0-0x0000000189B83BF0
                // [XID] // 0x0000000189B83BA0-0x0000000189B83BF0
    public static bool ArrayFromJson(JSONNode node, out ConfigPoint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA8FB0-0x0000000180DA9330
      // [IDTag] // 0x0000000189B91010-0x0000000189B91050
      // [XID] // 0x0000000189B91010-0x0000000189B91050
    private static bool InternalArrayFromJson(JSONNode node, out ConfigPoint[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8A5B0-0x0000000180D8A860
    [BlackList] // 0x0000000189B9B340-0x0000000189B9B390
                // [IDTag] // 0x0000000189B9B340-0x0000000189B9B390
                // [XID] // 0x0000000189B9B340-0x0000000189B9B390
    public static bool ArrayFromJson(JSONNode node, out ConfigPointArray[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC9230-0x0000000180DC95B0
      // [IDTag] // 0x0000000189BA85B0-0x0000000189BA85F0
      // [XID] // 0x0000000189BA85B0-0x0000000189BA85F0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigPointArray[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D89AE0-0x0000000180D89D90
    [BlackList] // 0x0000000189BB2B90-0x0000000189BB2BE0
                // [IDTag] // 0x0000000189BB2B90-0x0000000189BB2BE0
                // [XID] // 0x0000000189BB2B90-0x0000000189BB2BE0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigLogoPage> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBB820-0x0000000180CBBBA0
      // [IDTag] // 0x0000000189BBFFD0-0x0000000189BC0010
      // [XID] // 0x0000000189BBFFD0-0x0000000189BC0010
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigLogoPage> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D26540-0x0000000180D26A40
    [BlackList] // 0x0000000189BCB040-0x0000000189BCB090
                // [IDTag] // 0x0000000189BCB040-0x0000000189BCB090
                // [XID] // 0x0000000189BCB040-0x0000000189BCB090
    public static bool EnumStrToVal(string str, out ActorType e)
    {
        e = default;
        return default;
    } // 0x0000000180D47DB0-0x0000000180D48150
    [BlackList] // 0x0000000189BD8250-0x0000000189BD82A0
                // [IDTag] // 0x0000000189BD8250-0x0000000189BD82A0
                // [XID] // 0x0000000189BD8250-0x0000000189BD82A0
    public static bool EnumStrToVal(string str, out TaskID e)
    {
        e = default;
        return default;
    } // 0x0000000180D66A60-0x0000000180D66DD0
    [BlackList] // 0x00000001895EB1B0-0x00000001895EB200
                // [IDTag] // 0x00000001895EB1B0-0x00000001895EB200
                // [XID] // 0x00000001895EB1B0-0x00000001895EB200
    public static bool EnumStrToVal(string str, out InterTimingType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4BE70-0x0000000180D4C000
    [BlackList] // 0x00000001895F8AB0-0x00000001895F8B00
                // [IDTag] // 0x00000001895F8AB0-0x00000001895F8B00
                // [XID] // 0x00000001895F8AB0-0x00000001895F8B00
    public static bool EnumStrToVal(string str, out ActorEvtTargetType e)
    {
        e = default;
        return default;
    } // 0x0000000180D69D70-0x0000000180D69EB0
    [BlackList] // 0x0000000189605FF0-0x0000000189606040
                // [IDTag] // 0x0000000189605FF0-0x0000000189606040
                // [XID] // 0x0000000189605FF0-0x0000000189606040
    public static bool EnumStrToVal(string str, out WeatherType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6CE90-0x0000000180D6D0E0
    [BlackList] // 0x0000000189613680-0x00000001896136D0
                // [IDTag] // 0x0000000189613680-0x00000001896136D0
                // [XID] // 0x0000000189613680-0x00000001896136D0
    public static bool EnumStrToVal(string str, out LuaTaskType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5BAA0-0x0000000180D5BE40
    [BlackList] // 0x0000000189620DC0-0x0000000189620E10
                // [IDTag] // 0x0000000189620DC0-0x0000000189620E10
                // [XID] // 0x0000000189620DC0-0x0000000189620E10
    public static bool EnumStrToVal(string str, out BeFollowState e)
    {
        e = default;
        return default;
    } // 0x0000000180D48840-0x0000000180D48A90
    [BlackList] // 0x000000018962E4B0-0x000000018962E500
                // [IDTag] // 0x000000018962E4B0-0x000000018962E500
                // [XID] // 0x000000018962E4B0-0x000000018962E500
    public static bool EnumStrToVal(string str, out NarratorState e)
    {
        e = default;
        return default;
    } // 0x0000000180D60F20-0x0000000180D61060
    [BlackList] // 0x000000018963BF80-0x000000018963BFD0
                // [IDTag] // 0x000000018963BF80-0x000000018963BFD0
                // [XID] // 0x000000018963BF80-0x000000018963BFD0
    public static bool EnumStrToVal(string str, out QState e)
    {
        e = default;
        return default;
    } // 0x0000000180D54E40-0x0000000180D55050
    [BlackList] // 0x00000001896496C0-0x0000000189649710
                // [IDTag] // 0x00000001896496C0-0x0000000189649710
                // [XID] // 0x00000001896496C0-0x0000000189649710
    public static bool EnumStrToVal(string str, out DistType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5F860-0x0000000180D5F9A0
    [BlackList] // 0x0000000189656DF0-0x0000000189656E40
                // [IDTag] // 0x0000000189656DF0-0x0000000189656E40
                // [XID] // 0x0000000189656DF0-0x0000000189656E40
    public static bool ArrayFromJson(JSONNode node, out ConfigVCustomMapMark[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAFFB0-0x0000000180DB0330
      // [IDTag] // 0x0000000189664280-0x00000001896642C0
      // [XID] // 0x0000000189664280-0x00000001896642C0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigVCustomMapMark[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D81780-0x0000000180D81A40
    [BlackList] // 0x000000018966EDA0-0x000000018966EDF0
                // [IDTag] // 0x000000018966EDA0-0x000000018966EDF0
                // [XID] // 0x000000018966EDA0-0x000000018966EDF0
    public static bool EnumStrToVal(string str, out MarkType e)
    {
        e = default;
        return default;
    } // 0x0000000180D465C0-0x0000000180D46B50
    [BlackList] // 0x000000018967C940-0x000000018967C990
                // [IDTag] // 0x000000018967C940-0x000000018967C990
                // [XID] // 0x000000018967C940-0x000000018967C990
    public static bool EnumStrToVal(string str, out MarkIconType e)
    {
        e = default;
        return default;
    } // 0x0000000180D629F0-0x0000000180D63E50
    [BlackList] // 0x000000018968A350-0x000000018968A3A0
                // [IDTag] // 0x000000018968A350-0x000000018968A3A0
                // [XID] // 0x000000018968A350-0x000000018968A3A0
    public static bool EnumStrToVal(string str, out MarkOrder e)
    {
        e = default;
        return default;
    } // 0x0000000180D47360-0x0000000180D47920
    [BlackList] // 0x0000000189697F40-0x0000000189697F90
                // [IDTag] // 0x0000000189697F40-0x0000000189697F90
                // [XID] // 0x0000000189697F40-0x0000000189697F90
    public static bool EnumStrToVal(string str, out MarkVisibleType e)
    {
        e = default;
        return default;
    } // 0x0000000180D74E10-0x0000000180D75020
    [BlackList] // 0x00000001896A4E80-0x00000001896A4ED0
                // [IDTag] // 0x00000001896A4E80-0x00000001896A4ED0
                // [XID] // 0x00000001896A4E80-0x00000001896A4ED0
    public static bool EnumStrToVal(string str, out MarkViewType e)
    {
        e = default;
        return default;
    } // 0x0000000180D69040-0x0000000180D69380
    [BlackList] // 0x00000001896B1E30-0x00000001896B1E80
                // [IDTag] // 0x00000001896B1E30-0x00000001896B1E80
                // [XID] // 0x00000001896B1E30-0x00000001896B1E80
    public static bool EnumStrToVal(string str, out MarkCustomType e)
    {
        e = default;
        return default;
    } // 0x0000000180D74AF0-0x0000000180D74C80
    [BlackList] // 0x00000001896BF2B0-0x00000001896BF300
                // [IDTag] // 0x00000001896BF2B0-0x00000001896BF300
                // [XID] // 0x00000001896BF2B0-0x00000001896BF300
    public static bool EnumStrToVal(string str, out MarkLayerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D56190-0x0000000180D56320
    [BlackList] // 0x00000001896CC9B0-0x00000001896CCA00
                // [IDTag] // 0x00000001896CC9B0-0x00000001896CCA00
                // [XID] // 0x00000001896CC9B0-0x00000001896CCA00
    public static bool ArrayFromJson(JSONNode node, out ConfigVBaseMark[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB6530-0x0000000180DB68B0
      // [IDTag] // 0x00000001896DA150-0x00000001896DA190
      // [XID] // 0x00000001896DA150-0x00000001896DA190
    private static bool InternalArrayFromJson(JSONNode node, out ConfigVBaseMark[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D882C0-0x0000000180D88550
    [BlackList] // 0x00000001896E4690-0x00000001896E46E0
                // [IDTag] // 0x00000001896E4690-0x00000001896E46E0
                // [XID] // 0x00000001896E4690-0x00000001896E46E0
    public static bool EnumStrToVal(string str, out MarkVisibilityType e)
    {
        e = default;
        return default;
    } // 0x0000000180D566C0-0x0000000180D56890
    [BlackList] // 0x00000001896F1400-0x00000001896F1450
                // [IDTag] // 0x00000001896F1400-0x00000001896F1450
                // [XID] // 0x00000001896F1400-0x00000001896F1450
    public static bool EnumStrToVal(string str, out ShowHeightType e)
    {
        e = default;
        return default;
    } // 0x0000000180D60D90-0x0000000180D60F20
    [BlackList] // 0x00000001896FF2D0-0x00000001896FF320
                // [IDTag] // 0x00000001896FF2D0-0x00000001896FF320
                // [XID] // 0x00000001896FF2D0-0x00000001896FF320
    public static bool DictFromJson(JSONNode node, out Dictionary<MarkType, ConfigMark> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCC5A0-0x0000000180CCC920
      // [IDTag] // 0x000000018970C580-0x000000018970C5C0
      // [XID] // 0x000000018970C580-0x000000018970C5C0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<MarkType, ConfigMark> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF60F0-0x0000000180CF6730
    [BlackList] // 0x0000000189716B60-0x0000000189716BB0
                // [IDTag] // 0x0000000189716B60-0x0000000189716BB0
                // [XID] // 0x0000000189716B60-0x0000000189716BB0
    public static bool DictFromJson(JSONNode node, out Dictionary<MarkIconType, ConfigMarkIcon> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE0B20-0x0000000180CE0EA0
      // [IDTag] // 0x0000000189724240-0x0000000189724280
      // [XID] // 0x0000000189724240-0x0000000189724280
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<MarkIconType, ConfigMarkIcon> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEB520-0x0000000180CEBC00
    [BlackList] // 0x000000018972E9F0-0x000000018972EA40
                // [IDTag] // 0x000000018972E9F0-0x000000018972EA40
                // [XID] // 0x000000018972E9F0-0x000000018972EA40
    public static bool ArrayFromJson(JSONNode node, out MarkIconType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA3BB0-0x0000000180DA3F30
      // [IDTag] // 0x000000018973C310-0x000000018973C350
      // [XID] // 0x000000018973C310-0x000000018973C350
    private static bool InternalArrayFromJson(JSONNode node, out MarkIconType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D81FB0-0x0000000180D82270
    [BlackList] // 0x0000000189746B00-0x0000000189746B50
                // [IDTag] // 0x0000000189746B00-0x0000000189746B50
                // [XID] // 0x0000000189746B00-0x0000000189746B50
    public static bool DictFromJson(JSONNode node, out Dictionary<SceneBuildingType, MarkIconType> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD6320-0x0000000180CD66A0
      // [IDTag] // 0x00000001897541A0-0x00000001897541E0
      // [XID] // 0x00000001897541A0-0x00000001897541E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SceneBuildingType, MarkIconType> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1B2E0-0x0000000180D1B900
    [BlackList] // 0x000000018975E7F0-0x000000018975E840
                // [IDTag] // 0x000000018975E7F0-0x000000018975E840
                // [XID] // 0x000000018975E7F0-0x000000018975E840
    public static bool DictFromJson(JSONNode node, out Dictionary<MarkOrder, int> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC2820-0x0000000180CC2BA0
      // [IDTag] // 0x000000018976BF60-0x000000018976BFA0
      // [XID] // 0x000000018976BF60-0x000000018976BFA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<MarkOrder, int> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0EE70-0x0000000180D0F470
    [BlackList] // 0x0000000189776660-0x00000001897766B0
                // [IDTag] // 0x0000000189776660-0x00000001897766B0
                // [XID] // 0x0000000189776660-0x00000001897766B0
    public static bool DictFromJson(JSONNode node, out Dictionary<MarkOrder, SimpleSafeInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC2120-0x0000000180CC24A0
      // [IDTag] // 0x0000000189783DD0-0x0000000189783E10
      // [XID] // 0x0000000189783DD0-0x0000000189783E10
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<MarkOrder, SimpleSafeInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFCC40-0x0000000180CFD280
    [BlackList] // 0x000000018978E210-0x000000018978E260
                // [IDTag] // 0x000000018978E210-0x000000018978E260
                // [XID] // 0x000000018978E210-0x000000018978E260
    public static bool EnumStrToVal(string str, out VelocityForceType e)
    {
        e = default;
        return default;
    } // 0x0000000180D59800-0x0000000180D59BA0
    [BlackList] // 0x000000018979C230-0x000000018979C280
                // [IDTag] // 0x000000018979C230-0x000000018979C280
                // [XID] // 0x000000018979C230-0x000000018979C280
    public static bool ArrayFromJson(JSONNode node, out VelocityForceType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB1830-0x0000000180DB1BB0
      // [IDTag] // 0x00000001897A96A0-0x00000001897A96E0
      // [XID] // 0x00000001897A96A0-0x00000001897A96E0
    private static bool InternalArrayFromJson(JSONNode node, out VelocityForceType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9DFA0-0x0000000180D9E260
    [BlackList] // 0x00000001897B45B0-0x00000001897B4600
                // [IDTag] // 0x00000001897B45B0-0x00000001897B4600
                // [XID] // 0x00000001897B45B0-0x00000001897B4600
    public static bool EnumStrToVal(string str, out FacingMoveType e)
    {
        e = default;
        return default;
    } // 0x0000000180D3FFB0-0x0000000180D40180
    [BlackList] // 0x00000001897C2190-0x00000001897C21E0
                // [IDTag] // 0x00000001897C2190-0x00000001897C21E0
                // [XID] // 0x00000001897C2190-0x00000001897C21E0
    public static bool EnumStrToVal(string str, out MonsterSizeType e)
    {
        e = default;
        return default;
    } // 0x0000000180D60B80-0x0000000180D60D90
    [BlackList] // 0x00000001897CF9B0-0x00000001897CFA00
                // [IDTag] // 0x00000001897CF9B0-0x00000001897CFA00
                // [XID] // 0x00000001897CF9B0-0x00000001897CFA00
    public static bool EnumStrToVal(string str, out PositionModifyState e)
    {
        e = default;
        return default;
    } // 0x0000000180D55E30-0x0000000180D56000
    [BlackList] // 0x00000001897DD0E0-0x00000001897DD130
                // [IDTag] // 0x00000001897DD0E0-0x00000001897DD130
                // [XID] // 0x00000001897DD0E0-0x00000001897DD130
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, PositionModifyState> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD3220-0x0000000180CD35A0
      // [IDTag] // 0x00000001897EAAE0-0x00000001897EAB20
      // [XID] // 0x00000001897EAAE0-0x00000001897EAB20
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, PositionModifyState> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF85B0-0x0000000180CF8B90
    [BlackList] // 0x00000001897F54E0-0x00000001897F5530
                // [IDTag] // 0x00000001897F54E0-0x00000001897F5530
                // [XID] // 0x00000001897F54E0-0x00000001897F5530
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, PositionModifyState> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE3C20-0x0000000180CE3FA0
      // [IDTag] // 0x0000000189802DC0-0x0000000189802E00
      // [XID] // 0x0000000189802DC0-0x0000000189802E00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, PositionModifyState> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0C980-0x0000000180D0CFC0
    [BlackList] // 0x000000018980D0C0-0x000000018980D110
                // [IDTag] // 0x000000018980D0C0-0x000000018980D110
                // [XID] // 0x000000018980D0C0-0x000000018980D110
    public static bool EnumStrToVal(string str, out MovePlatformDelayType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6CD00-0x0000000180D6CE90
    [BlackList] // 0x000000018981ABD0-0x000000018981AC20
                // [IDTag] // 0x000000018981ABD0-0x000000018981AC20
                // [XID] // 0x000000018981ABD0-0x000000018981AC20
    public static bool EnumStrToVal(string str, out UnstickAction e)
    {
        e = default;
        return default;
    } // 0x0000000180D665C0-0x0000000180D66790
    [BlackList] // 0x00000001898283F0-0x0000000189828440
                // [IDTag] // 0x00000001898283F0-0x0000000189828440
                // [XID] // 0x00000001898283F0-0x0000000189828440
    public static bool EnumStrToVal(string str, out FollowTarget e)
    {
        e = default;
        return default;
    } // 0x0000000180D67300-0x0000000180D67510
    [BlackList] // 0x0000000189835700-0x0000000189835750
                // [IDTag] // 0x0000000189835700-0x0000000189835750
                // [XID] // 0x0000000189835700-0x0000000189835750
    public static bool EnumStrToVal(string str, out EntityColliderType e)
    {
        e = default;
        return default;
    } // 0x0000000180D77990-0x0000000180D77AD0
    [BlackList] // 0x0000000189842D10-0x0000000189842D60
                // [IDTag] // 0x0000000189842D10-0x0000000189842D60
                // [XID] // 0x0000000189842D10-0x0000000189842D60
    public static bool ArrayFromJson(JSONNode node, out ConfigEntityCollider[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB5AB0-0x0000000180DB5E30
      // [IDTag] // 0x000000018984FDF0-0x000000018984FE30
      // [XID] // 0x000000018984FDF0-0x000000018984FE30
    private static bool InternalArrayFromJson(JSONNode node, out ConfigEntityCollider[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D96CD0-0x0000000180D96F80
    [BlackList] // 0x000000018985A410-0x000000018985A460
                // [IDTag] // 0x000000018985A410-0x000000018985A460
                // [XID] // 0x000000018985A410-0x000000018985A460
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigPlatformUIAction> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCA9A0-0x0000000180CCAD20
      // [IDTag] // 0x0000000189867590-0x00000001898675D0
      // [XID] // 0x0000000189867590-0x00000001898675D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigPlatformUIAction> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D3AF90-0x0000000180D3B490
    [BlackList] // 0x0000000189871AD0-0x0000000189871B20
                // [IDTag] // 0x0000000189871AD0-0x0000000189871B20
                // [XID] // 0x0000000189871AD0-0x0000000189871B20
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigPlatformUIData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBD0A0-0x0000000180CBD420
      // [IDTag] // 0x000000018987F180-0x000000018987F1C0
      // [XID] // 0x000000018987F180-0x000000018987F1C0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigPlatformUIData> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D30520-0x0000000180D30A20
    [BlackList] // 0x0000000189889520-0x0000000189889570
                // [IDTag] // 0x0000000189889520-0x0000000189889570
                // [XID] // 0x0000000189889520-0x0000000189889570
    public static bool EnumStrToVal(string str, out MusicGameParam e)
    {
        e = default;
        return default;
    } // 0x0000000180D402C0-0x0000000180D40660
    [BlackList] // 0x0000000189896760-0x00000001898967B0
                // [IDTag] // 0x0000000189896760-0x00000001898967B0
                // [XID] // 0x0000000189896760-0x00000001898967B0
    public static bool ArrayFromJson(JSONNode node, out MusicGameParam[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA1FB0-0x0000000180DA2330
      // [IDTag] // 0x00000001898A3E40-0x00000001898A3E80
      // [XID] // 0x00000001898A3E40-0x00000001898A3E80
    private static bool InternalArrayFromJson(JSONNode node, out MusicGameParam[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D99A50-0x0000000180D99D10
    [BlackList] // 0x00000001898AE610-0x00000001898AE660
                // [IDTag] // 0x00000001898AE610-0x00000001898AE660
                // [XID] // 0x00000001898AE610-0x00000001898AE660
    public static bool EnumStrToVal(string str, out MusicStimulus e)
    {
        e = default;
        return default;
    } // 0x0000000180D4DD00-0x0000000180D4E280
    [BlackList] // 0x00000001898BBD50-0x00000001898BBDA0
                // [IDTag] // 0x00000001898BBD50-0x00000001898BBDA0
                // [XID] // 0x00000001898BBD50-0x00000001898BBDA0
    public static bool EnumStrToVal(string str, out MusicBehaviourIgnorance e)
    {
        e = default;
        return default;
    } // 0x0000000180D738C0-0x0000000180D73BD0
    [BlackList] // 0x00000001898C9300-0x00000001898C9350
                // [IDTag] // 0x00000001898C9300-0x00000001898C9350
                // [XID] // 0x00000001898C9300-0x00000001898C9350
    public static bool ArrayFromJson(JSONNode node, out ConfigMusicCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB8130-0x0000000180DB84B0
      // [IDTag] // 0x00000001898D6C40-0x00000001898D6C80
      // [XID] // 0x00000001898D6C40-0x00000001898D6C80
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMusicCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D93C60-0x0000000180D93EF0
    [BlackList] // 0x00000001898E17D0-0x00000001898E1820
                // [IDTag] // 0x00000001898E17D0-0x00000001898E1820
                // [XID] // 0x00000001898E17D0-0x00000001898E1820
    public static bool ArrayFromJson(JSONNode node, out ConfigMusicShifter[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC48B0-0x0000000180DC4C30
      // [IDTag] // 0x00000001898EF2E0-0x00000001898EF320
      // [XID] // 0x00000001898EF2E0-0x00000001898EF320
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMusicShifter[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8CE20-0x0000000180D8D0D0
    [BlackList] // 0x00000001898F9A90-0x00000001898F9AE0
                // [IDTag] // 0x00000001898F9A90-0x00000001898F9AE0
                // [XID] // 0x00000001898F9A90-0x00000001898F9AE0
    public static bool ArrayFromJson(JSONNode node, out ConfigMusicFixedTimeTransitions[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA57B0-0x0000000180DA5B30
      // [IDTag] // 0x00000001899073F0-0x0000000189907430
      // [XID] // 0x00000001899073F0-0x0000000189907430
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMusicFixedTimeTransitions[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D85D30-0x0000000180D85FE0
    [BlackList] // 0x0000000189911C40-0x0000000189911C90
                // [IDTag] // 0x0000000189911C40-0x0000000189911C90
                // [XID] // 0x0000000189911C40-0x0000000189911C90
    public static bool ArrayFromJson(JSONNode node, out ConfigMusicStimulusHandler[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB76B0-0x0000000180DB7A30
      // [IDTag] // 0x000000018991F320-0x000000018991F360
      // [XID] // 0x000000018991F320-0x000000018991F360
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMusicStimulusHandler[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9B780-0x0000000180D9BA10
    [BlackList] // 0x0000000189929CA0-0x0000000189929CF0
                // [IDTag] // 0x0000000189929CA0-0x0000000189929CF0
                // [XID] // 0x0000000189929CA0-0x0000000189929CF0
    public static bool ArrayFromJson(JSONNode node, out ConfigSong[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB3430-0x0000000180DB37B0
      // [IDTag] // 0x0000000189937010-0x0000000189937050
      // [XID] // 0x0000000189937010-0x0000000189937050
    private static bool InternalArrayFromJson(JSONNode node, out ConfigSong[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D80CC0-0x0000000180D80F70
    [BlackList] // 0x0000000189941600-0x0000000189941650
                // [IDTag] // 0x0000000189941600-0x0000000189941650
                // [XID] // 0x0000000189941600-0x0000000189941650
    public static bool EnumStrToVal(string str, out MusicKeyType e)
    {
        e = default;
        return default;
    } // 0x0000000180D74180-0x0000000180D744C0
    [BlackList] // 0x000000018994EFE0-0x000000018994F030
                // [IDTag] // 0x000000018994EFE0-0x000000018994F030
                // [XID] // 0x000000018994EFE0-0x000000018994F030
    public static bool ArrayFromJson(JSONNode node, out ConfigMusicGameKey[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB6C30-0x0000000180DB6FB0
      // [IDTag] // 0x000000018995C680-0x000000018995C6C0
      // [XID] // 0x000000018995C680-0x000000018995C6C0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMusicGameKey[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D974C0-0x0000000180D97770
    [BlackList] // 0x0000000189967110-0x0000000189967160
                // [IDTag] // 0x0000000189967110-0x0000000189967160
                // [XID] // 0x0000000189967110-0x0000000189967160
    public static bool ArrayFromJson(JSONNode node, out CameraPlayCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC1EB0-0x0000000180DC2230
      // [IDTag] // 0x0000000189974810-0x0000000189974850
      // [XID] // 0x0000000189974810-0x0000000189974850
    private static bool InternalArrayFromJson(JSONNode node, out CameraPlayCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D98A30-0x0000000180D98CE0
    [BlackList] // 0x000000018997EC60-0x000000018997ECB0
                // [IDTag] // 0x000000018997EC60-0x000000018997ECB0
                // [XID] // 0x000000018997EC60-0x000000018997ECB0
    public static bool ArrayFromJson(JSONNode node, out ConfigMusicCamera[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBEA30-0x0000000180DBEDB0
      // [IDTag] // 0x000000018998C8F0-0x000000018998C930
      // [XID] // 0x000000018998C8F0-0x000000018998C930
    private static bool InternalArrayFromJson(JSONNode node, out ConfigMusicCamera[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8A050-0x0000000180D8A300
    [BlackList] // 0x0000000189997360-0x00000001899973B0
                // [IDTag] // 0x0000000189997360-0x00000001899973B0
                // [XID] // 0x0000000189997360-0x00000001899973B0
    public static bool EnumStrToVal(string str, out NavType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4C550-0x0000000180D4C690
    [BlackList] // 0x00000001899A5070-0x00000001899A50C0
                // [IDTag] // 0x00000001899A5070-0x00000001899A50C0
                // [XID] // 0x00000001899A5070-0x00000001899A50C0
    public static bool ArrayFromJson(JSONNode node, out ConfigNpcBornPos[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9FCB0-0x0000000180DA0030
      // [IDTag] // 0x00000001899B2C90-0x00000001899B2CD0
      // [XID] // 0x00000001899B2C90-0x00000001899B2CD0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigNpcBornPos[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9D4E0-0x0000000180D9D790
    [BlackList] // 0x00000001899BD030-0x00000001899BD080
                // [IDTag] // 0x00000001899BD030-0x00000001899BD080
                // [XID] // 0x00000001899BD030-0x00000001899BD080
    public static bool EnumStrToVal(string str, out PaimonSkill e)
    {
        e = default;
        return default;
    } // 0x0000000180D78490-0x0000000180D787A0
    [BlackList] // 0x00000001899CA800-0x00000001899CA850
                // [IDTag] // 0x00000001899CA800-0x00000001899CA850
                // [XID] // 0x00000001899CA800-0x00000001899CA850
    public static bool EnumStrToVal(string str, out PaimonRequestFrom e)
    {
        e = default;
        return default;
    } // 0x0000000180D416D0-0x0000000180D418A0
    [BlackList] // 0x00000001899D7CF0-0x00000001899D7D40
                // [IDTag] // 0x00000001899D7CF0-0x00000001899D7D40
                // [XID] // 0x00000001899D7CF0-0x00000001899D7D40
    public static bool EnumStrToVal(string str, out ActionBtnType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5BE40-0x0000000180D5C2A0
    [BlackList] // 0x00000001899E58C0-0x00000001899E5910
                // [IDTag] // 0x00000001899E58C0-0x00000001899E5910
                // [XID] // 0x00000001899E58C0-0x00000001899E5910
    public static bool EnumStrToVal(string str, out ActionSlotType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6C710-0x0000000180D6CA80
    [BlackList] // 0x00000001899F2D60-0x00000001899F2DB0
                // [IDTag] // 0x00000001899F2D60-0x00000001899F2DB0
                // [XID] // 0x00000001899F2D60-0x00000001899F2DB0
    public static bool EnumStrToVal(string str, out PlayModeType e)
    {
        e = default;
        return default;
    } // 0x0000000180D76480-0x0000000180D768B0
    [BlackList] // 0x0000000189A00080-0x0000000189A000D0
                // [IDTag] // 0x0000000189A00080-0x0000000189A000D0
                // [XID] // 0x0000000189A00080-0x0000000189A000D0
    public static bool ArrayFromJson(JSONNode node, out ConfigActionButton[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC4FB0-0x0000000180DC5330
      // [IDTag] // 0x0000000189A0D910-0x0000000189A0D950
      // [XID] // 0x0000000189A0D910-0x0000000189A0D950
    private static bool InternalArrayFromJson(JSONNode node, out ConfigActionButton[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8DE50-0x0000000180D8E100
    [BlackList] // 0x0000000189A17C90-0x0000000189A17CE0
                // [IDTag] // 0x0000000189A17C90-0x0000000189A17CE0
                // [XID] // 0x0000000189A17C90-0x0000000189A17CE0
    public static bool DictFromJson(JSONNode node, out Dictionary<ActionSlotType, ConfigActionButton[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD74A0-0x0000000180CD7820
      // [IDTag] // 0x0000000189A25020-0x0000000189A25060
      // [XID] // 0x0000000189A25020-0x0000000189A25060
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ActionSlotType, ConfigActionButton[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFBA30-0x0000000180CFC030
    [BlackList] // 0x0000000189A2F5D0-0x0000000189A2F620
                // [IDTag] // 0x0000000189A2F5D0-0x0000000189A2F620
                // [XID] // 0x0000000189A2F5D0-0x0000000189A2F620
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigActionPanelState> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDF620-0x0000000180CDF9A0
      // [IDTag] // 0x0000000189A3CC60-0x0000000189A3CCA0
      // [XID] // 0x0000000189A3CC60-0x0000000189A3CCA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigActionPanelState> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF9160-0x0000000180CF9660
    [BlackList] // 0x0000000189A474D0-0x0000000189A47520
                // [IDTag] // 0x0000000189A474D0-0x0000000189A47520
                // [XID] // 0x0000000189A474D0-0x0000000189A47520
    public static bool DictFromJson(JSONNode node, out Dictionary<ActionPanelState, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCD3A0-0x0000000180CCD720
      // [IDTag] // 0x0000000189A54C10-0x0000000189A54C50
      // [XID] // 0x0000000189A54C10-0x0000000189A54C50
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ActionPanelState, string> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF49C0-0x0000000180CF4FC0
    [BlackList] // 0x0000000189A5F630-0x0000000189A5F680
                // [IDTag] // 0x0000000189A5F630-0x0000000189A5F680
                // [XID] // 0x0000000189A5F630-0x0000000189A5F680
    public static bool DictFromJson(JSONNode node, out Dictionary<PlayModeType, ConfigActionPanelMode> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE07A0-0x0000000180CE0B20
      // [IDTag] // 0x0000000189A6CD60-0x0000000189A6CDA0
      // [XID] // 0x0000000189A6CD60-0x0000000189A6CDA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<PlayModeType, ConfigActionPanelMode> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D35F10-0x0000000180D36510
    [BlackList] // 0x0000000189A77590-0x0000000189A775E0
                // [IDTag] // 0x0000000189A77590-0x0000000189A775E0
                // [XID] // 0x0000000189A77590-0x0000000189A775E0
    public static bool EnumStrToVal(string str, out ConfigPreloadType e)
    {
        e = default;
        return default;
    } // 0x0000000180D490F0-0x0000000180D49230
    [BlackList] // 0x0000000189A85180-0x0000000189A851D0
                // [IDTag] // 0x0000000189A85180-0x0000000189A851D0
                // [XID] // 0x0000000189A85180-0x0000000189A851D0
    public static bool DictFromJson(JSONNode node, out Dictionary<ConfigPreloadType, string[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC4420-0x0000000180CC47A0
      // [IDTag] // 0x0000000189A929A0-0x0000000189A929E0
      // [XID] // 0x0000000189A929A0-0x0000000189A929E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ConfigPreloadType, string[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D39D60-0x0000000180D3A360
    [BlackList] // 0x0000000189A9D070-0x0000000189A9D0C0
                // [IDTag] // 0x0000000189A9D070-0x0000000189A9D0C0
                // [XID] // 0x0000000189A9D070-0x0000000189A9D0C0
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ConfigPreload> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCDAA0-0x0000000180CCDE20
      // [IDTag] // 0x0000000189AAA350-0x0000000189AAA390
      // [XID] // 0x0000000189AAA350-0x0000000189AAA390
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ConfigPreload> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0C3B0-0x0000000180D0C980
    [BlackList] // 0x0000000189AB4E30-0x0000000189AB4E80
                // [IDTag] // 0x0000000189AB4E30-0x0000000189AB4E80
                // [XID] // 0x0000000189AB4E30-0x0000000189AB4E80
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigPreload> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC0FA0-0x0000000180CC1320
      // [IDTag] // 0x0000000189AC2B60-0x0000000189AC2BA0
      // [XID] // 0x0000000189AC2B60-0x0000000189AC2BA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigPreload> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D118D0-0x0000000180D11F00
    [BlackList] // 0x0000000189ACD2A0-0x0000000189ACD2F0
                // [IDTag] // 0x0000000189ACD2A0-0x0000000189ACD2F0
                // [XID] // 0x0000000189ACD2A0-0x0000000189ACD2F0
    public static bool ArrayFromJson(JSONNode node, out ConfigPreloadType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBF830-0x0000000180DBFBB0
      // [IDTag] // 0x0000000189ADAF00-0x0000000189ADAF40
      // [XID] // 0x0000000189ADAF00-0x0000000189ADAF40
    private static bool InternalArrayFromJson(JSONNode node, out ConfigPreloadType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9ACB0-0x0000000180D9AF70
    [BlackList] // 0x0000000189AE5BE0-0x0000000189AE5C30
                // [IDTag] // 0x0000000189AE5BE0-0x0000000189AE5C30
                // [XID] // 0x0000000189AE5BE0-0x0000000189AE5C30
    public static bool DictFromJson(JSONNode node, out Dictionary<ConfigPreloadType, ConfigPreloadType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD4720-0x0000000180CD4AA0
      // [IDTag] // 0x0000000189AF34B0-0x0000000189AF34F0
      // [XID] // 0x0000000189AF34B0-0x0000000189AF34F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ConfigPreloadType, ConfigPreloadType[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2FA20-0x0000000180D30020
    [BlackList] // 0x0000000189AFD990-0x0000000189AFD9E0
                // [IDTag] // 0x0000000189AFD990-0x0000000189AFD9E0
                // [XID] // 0x0000000189AFD990-0x0000000189AFD9E0
    public static bool ArrayFromJson(JSONNode node, out ConfigContentRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCB8B0-0x0000000180DCBC30
      // [IDTag] // 0x0000000189B0AF20-0x0000000189B0AF60
      // [XID] // 0x0000000189B0AF20-0x0000000189B0AF60
    private static bool InternalArrayFromJson(JSONNode node, out ConfigContentRestriction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7C160-0x0000000180D7C410
    [BlackList] // 0x0000000189B15310-0x0000000189B15360
                // [IDTag] // 0x0000000189B15310-0x0000000189B15360
                // [XID] // 0x0000000189B15310-0x0000000189B15360
    public static bool ArrayFromJson(JSONNode node, out QuestCondEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAABB0-0x0000000180DAAF30
      // [IDTag] // 0x0000000189B22AB0-0x0000000189B22AF0
      // [XID] // 0x0000000189B22AB0-0x0000000189B22AF0
    private static bool InternalArrayFromJson(JSONNode node, out QuestCondEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D84A80-0x0000000180D84D30
    [BlackList] // 0x0000000189B2CE30-0x0000000189B2CE80
                // [IDTag] // 0x0000000189B2CE30-0x0000000189B2CE80
                // [XID] // 0x0000000189B2CE30-0x0000000189B2CE80
    public static bool ArrayFromJson(JSONNode node, out QuestContentEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA5EB0-0x0000000180DA6230
      // [IDTag] // 0x0000000189B3A530-0x0000000189B3A570
      // [XID] // 0x0000000189B3A530-0x0000000189B3A570
    private static bool InternalArrayFromJson(JSONNode node, out QuestContentEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9DA40-0x0000000180D9DCF0
    [BlackList] // 0x0000000189B45030-0x0000000189B45080
                // [IDTag] // 0x0000000189B45030-0x0000000189B45080
                // [XID] // 0x0000000189B45030-0x0000000189B45080
    public static bool ArrayFromJson(JSONNode node, out QuestExecEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAC0B0-0x0000000180DAC430
      // [IDTag] // 0x0000000189B525C0-0x0000000189B52600
      // [XID] // 0x0000000189B525C0-0x0000000189B52600
    private static bool InternalArrayFromJson(JSONNode node, out QuestExecEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D96F80-0x0000000180D97230
    [BlackList] // 0x0000000189B5D010-0x0000000189B5D060
                // [IDTag] // 0x0000000189B5D010-0x0000000189B5D060
                // [XID] // 0x0000000189B5D010-0x0000000189B5D060
    public static bool ArrayFromJson(JSONNode node, out ConfigTalkScheme[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCDF30-0x0000000180DCE2B0
      // [IDTag] // 0x0000000189B6A710-0x0000000189B6A750
      // [XID] // 0x0000000189B6A710-0x0000000189B6A750
    private static bool InternalArrayFromJson(JSONNode node, out ConfigTalkScheme[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D95F60-0x0000000180D96210
    [BlackList] // 0x0000000189B74B10-0x0000000189B74B60
                // [IDTag] // 0x0000000189B74B10-0x0000000189B74B60
                // [XID] // 0x0000000189B74B10-0x0000000189B74B60
    public static bool ArrayFromJson(JSONNode node, out ConfigQuestScheme[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC3AB0-0x0000000180DC3E30
      // [IDTag] // 0x0000000189B82190-0x0000000189B821D0
      // [XID] // 0x0000000189B82190-0x0000000189B821D0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigQuestScheme[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9D230-0x0000000180D9D4E0
    [BlackList] // 0x0000000189B8C360-0x0000000189B8C3B0
                // [IDTag] // 0x0000000189B8C360-0x0000000189B8C3B0
                // [XID] // 0x0000000189B8C360-0x0000000189B8C3B0
    public static bool EnumStrToVal(string str, out QuestType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5FF10-0x0000000180D60250
    [BlackList] // 0x0000000189B99960-0x0000000189B999B0
                // [IDTag] // 0x0000000189B99960-0x0000000189B999B0
                // [XID] // 0x0000000189B99960-0x0000000189B999B0
    public static bool EnumStrToVal(string str, out QuestState e)
    {
        e = default;
        return default;
    } // 0x0000000180D77AD0-0x0000000180D77CE0
    [BlackList] // 0x0000000189BA6F00-0x0000000189BA6F50
                // [IDTag] // 0x0000000189BA6F00-0x0000000189BA6F50
                // [XID] // 0x0000000189BA6F00-0x0000000189BA6F50
    public static bool EnumStrToVal(string str, out ParentQuestState e)
    {
        e = default;
        return default;
    } // 0x0000000180D55050-0x0000000180D55220
    [BlackList] // 0x0000000189BB4350-0x0000000189BB43A0
                // [IDTag] // 0x0000000189BB4350-0x0000000189BB43A0
                // [XID] // 0x0000000189BB4350-0x0000000189BB43A0
    public static bool EnumStrToVal(string str, out QuestShowType e)
    {
        e = default;
        return default;
    } // 0x0000000180D77FB0-0x0000000180D780F0
    [BlackList] // 0x0000000189BC1F90-0x0000000189BC1FE0
                // [IDTag] // 0x0000000189BC1F90-0x0000000189BC1FE0
                // [XID] // 0x0000000189BC1F90-0x0000000189BC1FE0
    public static bool EnumStrToVal(string str, out MainQuestTagType e)
    {
        e = default;
        return default;
    } // 0x0000000180D71C90-0x0000000180D71E20
    [BlackList] // 0x0000000189BCF5D0-0x0000000189BCF620
                // [IDTag] // 0x0000000189BCF5D0-0x0000000189BCF620
                // [XID] // 0x0000000189BCF5D0-0x0000000189BCF620
    public static bool EnumStrToVal(string str, out QuestCondCompareType e)
    {
        e = default;
        return default;
    } // 0x0000000180D754F0-0x0000000180D75680
    [BlackList] // 0x0000000189BDCFC0-0x0000000189BDD010
                // [IDTag] // 0x0000000189BDCFC0-0x0000000189BDD010
                // [XID] // 0x0000000189BDCFC0-0x0000000189BDD010
    public static bool EnumStrToVal(string str, out QuestCondType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6A670-0x0000000180D6B390
    [BlackList] // 0x00000001895EF940-0x00000001895EF990
                // [IDTag] // 0x00000001895EF940-0x00000001895EF990
                // [XID] // 0x00000001895EF940-0x00000001895EF990
    public static bool EnumStrToVal(string str, out QuestContentType e)
    {
        e = default;
        return default;
    } // 0x0000000180D52450-0x0000000180D52F80
    [BlackList] // 0x00000001895FCE10-0x00000001895FCE60
                // [IDTag] // 0x00000001895FCE10-0x00000001895FCE60
                // [XID] // 0x00000001895FCE10-0x00000001895FCE60
    public static bool EnumStrToVal(string str, out QuestGuideType e)
    {
        e = default;
        return default;
    } // 0x0000000180D41540-0x0000000180D416D0
    [BlackList] // 0x000000018960A890-0x000000018960A8E0
                // [IDTag] // 0x000000018960A890-0x000000018960A8E0
                // [XID] // 0x000000018960A890-0x000000018960A8E0
    public static bool EnumStrToVal(string str, out QuestGuideNPCSelectType e)
    {
        e = default;
        return default;
    } // 0x0000000180D40F00-0x0000000180D41040
    [BlackList] // 0x0000000189617BE0-0x0000000189617C30
                // [IDTag] // 0x0000000189617BE0-0x0000000189617C30
                // [XID] // 0x0000000189617BE0-0x0000000189617C30
    public static bool EnumStrToVal(string str, out ShowQuestGuideType e)
    {
        e = default;
        return default;
    } // 0x0000000180D54150-0x0000000180D542E0
    [BlackList] // 0x0000000189625410-0x0000000189625460
                // [IDTag] // 0x0000000189625410-0x0000000189625460
                // [XID] // 0x0000000189625410-0x0000000189625460
    public static bool EnumStrToVal(string str, out QuestGuideAuto e)
    {
        e = default;
        return default;
    } // 0x0000000180D744C0-0x0000000180D74650
    [BlackList] // 0x0000000189632C80-0x0000000189632CD0
                // [IDTag] // 0x0000000189632C80-0x0000000189632CD0
                // [XID] // 0x0000000189632C80-0x0000000189632CD0
    public static bool EnumStrToVal(string str, out QuestGuideStyle e)
    {
        e = default;
        return default;
    } // 0x0000000180D50A40-0x0000000180D50C50
    [BlackList] // 0x0000000189640410-0x0000000189640460
                // [IDTag] // 0x0000000189640410-0x0000000189640460
                // [XID] // 0x0000000189640410-0x0000000189640460
    public static bool EnumStrToVal(string str, out QuestGuideLayer e)
    {
        e = default;
        return default;
    } // 0x0000000180D409A0-0x0000000180D40B30
    [BlackList] // 0x000000018964DD80-0x000000018964DDD0
                // [IDTag] // 0x000000018964DD80-0x000000018964DDD0
                // [XID] // 0x000000018964DD80-0x000000018964DDD0
    public static bool EnumStrToVal(string str, out QuestExecType e)
    {
        e = default;
        return default;
    } // 0x0000000180D50FA0-0x0000000180D51B00
    [BlackList] // 0x000000018965B5B0-0x000000018965B600
                // [IDTag] // 0x000000018965B5B0-0x000000018965B600
                // [XID] // 0x000000018965B5B0-0x000000018965B600
    public static bool EnumStrToVal(string str, out TalkExecType e)
    {
        e = default;
        return default;
    } // 0x0000000180D48C20-0x0000000180D48D60
    [BlackList] // 0x0000000189668DE0-0x0000000189668E30
                // [IDTag] // 0x0000000189668DE0-0x0000000189668E30
                // [XID] // 0x0000000189668DE0-0x0000000189668E30
    public static bool EnumStrToVal(string str, out TalkBeginWay e)
    {
        e = default;
        return default;
    } // 0x0000000180D65530-0x0000000180D656C0
    [BlackList] // 0x00000001896767A0-0x00000001896767F0
                // [IDTag] // 0x00000001896767A0-0x00000001896767F0
                // [XID] // 0x00000001896767A0-0x00000001896767F0
    public static bool EnumStrToVal(string str, out TalkHeroType e)
    {
        e = default;
        return default;
    } // 0x0000000180D710A0-0x0000000180D711E0
    [BlackList] // 0x0000000189683FB0-0x0000000189684000
                // [IDTag] // 0x0000000189683FB0-0x0000000189684000
                // [XID] // 0x0000000189683FB0-0x0000000189684000
    public static bool EnumStrToVal(string str, out TalkLoadType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4DAF0-0x0000000180D4DD00
    [BlackList] // 0x0000000189692090-0x00000001896920E0
                // [IDTag] // 0x0000000189692090-0x00000001896920E0
                // [XID] // 0x0000000189692090-0x00000001896920E0
    public static bool EnumStrToVal(string str, out TalkRoleType e)
    {
        e = default;
        return default;
    } // 0x0000000180D59BA0-0x0000000180D59DB0
    [BlackList] // 0x000000018969F230-0x000000018969F280
                // [IDTag] // 0x000000018969F230-0x000000018969F280
                // [XID] // 0x000000018969F230-0x000000018969F280
    public static bool EnumStrToVal(string str, out TalkShowType e)
    {
        e = default;
        return default;
    } // 0x0000000180D66480-0x0000000180D665C0
    [BlackList] // 0x00000001896AC750-0x00000001896AC7A0
                // [IDTag] // 0x00000001896AC750-0x00000001896AC7A0
                // [XID] // 0x00000001896AC750-0x00000001896AC7A0
    public static bool EnumStrToVal(string str, out TalkMarkType e)
    {
        e = default;
        return default;
    } // 0x0000000180D69AF0-0x0000000180D69C30
    [BlackList] // 0x00000001896B98D0-0x00000001896B9920
                // [IDTag] // 0x00000001896B98D0-0x00000001896B9920
                // [XID] // 0x00000001896B98D0-0x00000001896B9920
    public static bool EnumStrToVal(string str, out RandomQuestFilterType e)
    {
        e = default;
        return default;
    } // 0x0000000180D43FC0-0x0000000180D44190
    [BlackList] // 0x00000001896C6BF0-0x00000001896C6C40
                // [IDTag] // 0x00000001896C6BF0-0x00000001896C6C40
                // [XID] // 0x00000001896C6BF0-0x00000001896C6C40
    public static bool ArrayFromJson(JSONNode node, out AnimatorFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA73B0-0x0000000180DA7730
      // [IDTag] // 0x00000001896D3C80-0x00000001896D3CC0
      // [XID] // 0x00000001896D3C80-0x00000001896D3CC0
    private static bool InternalArrayFromJson(JSONNode node, out AnimatorFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D88AB0-0x0000000180D88D60
    [BlackList] // 0x00000001896DE6E0-0x00000001896DE730
                // [IDTag] // 0x00000001896DE6E0-0x00000001896DE730
                // [XID] // 0x00000001896DE6E0-0x00000001896DE730
    public static bool ArrayFromJson(JSONNode node, out AnimatorInt[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC87B0-0x0000000180DC8B30
      // [IDTag] // 0x00000001896EBB00-0x00000001896EBB40
      // [XID] // 0x00000001896EBB00-0x00000001896EBB40
    private static bool InternalArrayFromJson(JSONNode node, out AnimatorInt[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D83A60-0x0000000180D83D10
    [BlackList] // 0x00000001896F61C0-0x00000001896F6210
                // [IDTag] // 0x00000001896F61C0-0x00000001896F6210
                // [XID] // 0x00000001896F61C0-0x00000001896F6210
    public static bool ArrayFromJson(JSONNode node, out AnimatorBool[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB8F30-0x0000000180DB92B0
      // [IDTag] // 0x0000000189703750-0x0000000189703790
      // [XID] // 0x0000000189703750-0x0000000189703790
    private static bool InternalArrayFromJson(JSONNode node, out AnimatorBool[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D83FC0-0x0000000180D84270
    [BlackList] // 0x000000018970DE90-0x000000018970DEE0
                // [IDTag] // 0x000000018970DE90-0x000000018970DEE0
                // [XID] // 0x000000018970DE90-0x000000018970DEE0
    public static bool ArrayFromJson(JSONNode node, out AnimatorTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBB930-0x0000000180DBBCB0
      // [IDTag] // 0x000000018971B780-0x000000018971B7C0
      // [XID] // 0x000000018971B780-0x000000018971B7C0
    private static bool InternalArrayFromJson(JSONNode node, out AnimatorTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8DBA0-0x0000000180D8DE50
    [BlackList] // 0x0000000189725B80-0x0000000189725BD0
                // [IDTag] // 0x0000000189725B80-0x0000000189725BD0
                // [XID] // 0x0000000189725B80-0x0000000189725BD0
    public static bool ArrayFromJson(JSONNode node, out RendererFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC7D30-0x0000000180DC80B0
      // [IDTag] // 0x0000000189733140-0x0000000189733180
      // [XID] // 0x0000000189733140-0x0000000189733180
    private static bool InternalArrayFromJson(JSONNode node, out RendererFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D941A0-0x0000000180D94450
    [BlackList] // 0x000000018973DED0-0x000000018973DF20
                // [IDTag] // 0x000000018973DED0-0x000000018973DF20
                // [XID] // 0x000000018973DED0-0x000000018973DF20
    public static bool ArrayFromJson(JSONNode node, out MaterialFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA34B0-0x0000000180DA3830
      // [IDTag] // 0x000000018974B580-0x000000018974B5C0
      // [XID] // 0x000000018974B580-0x000000018974B5C0
    private static bool InternalArrayFromJson(JSONNode node, out MaterialFloat[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8EE80-0x0000000180D8F130
    [BlackList] // 0x0000000189755B30-0x0000000189755B80
                // [IDTag] // 0x0000000189755B30-0x0000000189755B80
                // [XID] // 0x0000000189755B30-0x0000000189755B80
    public static bool EnumStrToVal(string str, out EmoRecordTypeEnum e)
    {
        e = default;
        return default;
    } // 0x0000000180D5C8B0-0x0000000180D5CCB0
    [BlackList] // 0x0000000189763030-0x0000000189763080
                // [IDTag] // 0x0000000189763030-0x0000000189763080
                // [XID] // 0x0000000189763030-0x0000000189763080
    public static bool ArrayFromJson(JSONNode node, out ConfigRecordEmoFunc[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB53B0-0x0000000180DB5730
      // [IDTag] // 0x00000001897704B0-0x00000001897704F0
      // [XID] // 0x00000001897704B0-0x00000001897704F0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigRecordEmoFunc[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D80F70-0x0000000180D81220
    [BlackList] // 0x000000018977AB20-0x000000018977AB70
                // [IDTag] // 0x000000018977AB20-0x000000018977AB70
                // [XID] // 0x000000018977AB20-0x000000018977AB70
    public static bool ArrayFromJson(JSONNode node, out ConfigRecordActorBase[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBE6B0-0x0000000180DBEA30
      // [IDTag] // 0x00000001897883A0-0x00000001897883E0
      // [XID] // 0x00000001897883A0-0x00000001897883E0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigRecordActorBase[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9AA20-0x0000000180D9ACB0
    [BlackList] // 0x0000000189792A60-0x0000000189792AB0
                // [IDTag] // 0x0000000189792A60-0x0000000189792AB0
                // [XID] // 0x0000000189792A60-0x0000000189792AB0
    public static bool EnumStrToVal(string str, out RecordActorType e)
    {
        e = default;
        return default;
    } // 0x0000000180D768B0-0x0000000180D769F0
    [BlackList] // 0x00000001897A07F0-0x00000001897A0840
                // [IDTag] // 0x00000001897A07F0-0x00000001897A0840
                // [XID] // 0x00000001897A07F0-0x00000001897A0840
    public static bool ArrayFromJson(JSONNode node, out ConfigRecordFrame[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA2330-0x0000000180DA26B0
      // [IDTag] // 0x00000001897ADEB0-0x00000001897ADEF0
      // [XID] // 0x00000001897ADEB0-0x00000001897ADEF0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigRecordFrame[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D89830-0x0000000180D89AE0
    [BlackList] // 0x00000001897B8BC0-0x00000001897B8C10
                // [IDTag] // 0x00000001897B8BC0-0x00000001897B8C10
                // [XID] // 0x00000001897B8BC0-0x00000001897B8C10
    public static bool ArrayFromJson(JSONNode node, out ConfigRecordActorInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB4230-0x0000000180DB45B0
      // [IDTag] // 0x00000001897C6CA0-0x00000001897C6CE0
      // [XID] // 0x00000001897C6CA0-0x00000001897C6CE0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigRecordActorInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8A300-0x0000000180D8A5B0
    [BlackList] // 0x00000001897D1030-0x00000001897D1080
                // [IDTag] // 0x00000001897D1030-0x00000001897D1080
                // [XID] // 0x00000001897D1030-0x00000001897D1080
    public static bool DictFromJson(JSONNode node, out Dictionary<ElementType, ConfigResonanceCutScene> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD19A0-0x0000000180CD1D20
      // [IDTag] // 0x00000001897DE870-0x00000001897DE8B0
      // [XID] // 0x00000001897DE870-0x00000001897DE8B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<ElementType, ConfigResonanceCutScene> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D00FF0-0x0000000180D015F0
    [BlackList] // 0x00000001897E92F0-0x00000001897E9340
                // [IDTag] // 0x00000001897E92F0-0x00000001897E9340
                // [XID] // 0x00000001897E92F0-0x00000001897E9340
    public static bool EnumStrToVal(string str, out ScenePointType e)
    {
        e = default;
        return default;
    } // 0x0000000180D68E70-0x0000000180D69040
    [BlackList] // 0x00000001897F6B40-0x00000001897F6B90
                // [IDTag] // 0x00000001897F6B40-0x00000001897F6B90
                // [XID] // 0x00000001897F6B40-0x00000001897F6B90
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigScenePoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBBF20-0x0000000180CBC2A0
      // [IDTag] // 0x0000000189804450-0x0000000189804490
      // [XID] // 0x0000000189804450-0x0000000189804490
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigScenePoint> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D22760-0x0000000180D22C30
    [BlackList] // 0x000000018980EA50-0x000000018980EAA0
                // [IDTag] // 0x000000018980EA50-0x000000018980EAA0
                // [XID] // 0x000000018980EA50-0x000000018980EAA0
    public static bool ArrayFromJson(JSONNode node, out DungeonQuestCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA26B0-0x0000000180DA2A30
      // [IDTag] // 0x000000018981C2E0-0x000000018981C320
      // [XID] // 0x000000018981C2E0-0x000000018981C320
    private static bool InternalArrayFromJson(JSONNode node, out DungeonQuestCondition[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D83250-0x0000000180D83500
    [BlackList] // 0x0000000189826910-0x0000000189826960
                // [IDTag] // 0x0000000189826910-0x0000000189826960
                // [XID] // 0x0000000189826910-0x0000000189826960
    public static bool EnumStrToVal(string str, out DungeonEntryType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5D770-0x0000000180D5DAE0
    [BlackList] // 0x0000000189833F40-0x0000000189833F90
                // [IDTag] // 0x0000000189833F40-0x0000000189833F90
                // [XID] // 0x0000000189833F40-0x0000000189833F90
    public static bool EnumStrToVal(string str, out PointMapVisibility e)
    {
        e = default;
        return default;
    } // 0x0000000180D45C80-0x0000000180D45E10
    [BlackList] // 0x00000001898411A0-0x00000001898411F0
                // [IDTag] // 0x00000001898411A0-0x00000001898411F0
                // [XID] // 0x00000001898411A0-0x00000001898411F0
    public static bool EnumStrToVal(string str, out SceneBuildingType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5EE80-0x0000000180D5F550
    [BlackList] // 0x000000018984E960-0x000000018984E9B0
                // [IDTag] // 0x000000018984E960-0x000000018984E9B0
                // [XID] // 0x000000018984E960-0x000000018984E9B0
    public static bool EnumStrToVal(string str, out SceneAreaType e)
    {
        e = default;
        return default;
    } // 0x0000000180D5B130-0x0000000180D5B2C0
    [BlackList] // 0x000000018985BB70-0x000000018985BBC0
                // [IDTag] // 0x000000018985BB70-0x000000018985BBC0
                // [XID] // 0x000000018985BB70-0x000000018985BBC0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigSceneArea> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC0520-0x0000000180CC08A0
      // [IDTag] // 0x0000000189868E50-0x0000000189868E90
      // [XID] // 0x0000000189868E50-0x0000000189868E90
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigSceneArea> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF5BF0-0x0000000180CF60F0
    [BlackList] // 0x0000000189873190-0x00000001898731E0
                // [IDTag] // 0x0000000189873190-0x00000001898731E0
                // [XID] // 0x0000000189873190-0x00000001898731E0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigForceField> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC6AA0-0x0000000180CC6E20
      // [IDTag] // 0x00000001898808C0-0x0000000189880900
      // [XID] // 0x00000001898808C0-0x0000000189880900
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigForceField> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2A740-0x0000000180D2AC10
    [BlackList] // 0x000000018988AB70-0x000000018988ABC0
                // [IDTag] // 0x000000018988AB70-0x000000018988ABC0
                // [XID] // 0x000000018988AB70-0x000000018988ABC0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigLocalEntity> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE5F20-0x0000000180CE62A0
      // [IDTag] // 0x0000000189897EC0-0x0000000189897F00
      // [XID] // 0x0000000189897EC0-0x0000000189897F00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigLocalEntity> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D27A10-0x0000000180D27EE0
    [BlackList] // 0x00000001898A2400-0x00000001898A2450
                // [IDTag] // 0x00000001898A2400-0x00000001898A2450
                // [XID] // 0x00000001898A2400-0x00000001898A2450
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigLoadingDoor> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB83A0-0x0000000180CB8720
      // [IDTag] // 0x00000001898AFCF0-0x00000001898AFD30
      // [XID] // 0x00000001898AFCF0-0x00000001898AFD30
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigLoadingDoor> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0E490-0x0000000180D0E9A0
    [BlackList] // 0x00000001898BA820-0x00000001898BA870
                // [IDTag] // 0x00000001898BA820-0x00000001898BA870
                // [XID] // 0x00000001898BA820-0x00000001898BA870
    public static bool ArrayFromJson(JSONNode node, out ConfigWorldArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB0330-0x0000000180DB06B0
      // [IDTag] // 0x00000001898C7C80-0x00000001898C7CC0
      // [XID] // 0x00000001898C7C80-0x00000001898C7CC0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigWorldArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D91150-0x0000000180D91400
    [BlackList] // 0x00000001898D2350-0x00000001898D23A0
                // [IDTag] // 0x00000001898D2350-0x00000001898D23A0
                // [XID] // 0x00000001898D2350-0x00000001898D23A0
    public static bool ArrayFromJson(JSONNode node, out ConfigLevel1WorldArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC33B0-0x0000000180DC3730
      // [IDTag] // 0x00000001898E0100-0x00000001898E0140
      // [XID] // 0x00000001898E0100-0x00000001898E0140
    private static bool InternalArrayFromJson(JSONNode node, out ConfigLevel1WorldArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7CEB0-0x0000000180D7D160
    [BlackList] // 0x00000001898EABB0-0x00000001898EAC00
                // [IDTag] // 0x00000001898EABB0-0x00000001898EAC00
                // [XID] // 0x00000001898EABB0-0x00000001898EAC00
    public static bool ArrayFromJson(JSONNode node, out ConfigLevelArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBA7B0-0x0000000180DBAB30
      // [IDTag] // 0x00000001898F8470-0x00000001898F84B0
      // [XID] // 0x00000001898F8470-0x00000001898F84B0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigLevelArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D97CB0-0x0000000180D97F60
    [BlackList] // 0x0000000189902C00-0x0000000189902C50
                // [IDTag] // 0x0000000189902C00-0x0000000189902C50
                // [XID] // 0x0000000189902C00-0x0000000189902C50
    public static bool ArrayFromJson(JSONNode node, out ConfigLevelBlock[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC0630-0x0000000180DC09B0
      // [IDTag] // 0x0000000189910190-0x00000001899101D0
      // [XID] // 0x0000000189910190-0x00000001899101D0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigLevelBlock[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7D410-0x0000000180D7D6C0
    [BlackList] // 0x000000018991AD70-0x000000018991ADC0
                // [IDTag] // 0x000000018991AD70-0x000000018991ADC0
                // [XID] // 0x000000018991AD70-0x000000018991ADC0
    public static bool EnumStrToVal(string str, out EnvZoneEventType e)
    {
        e = default;
        return default;
    } // 0x0000000180D542E0-0x0000000180D544B0
    [BlackList] // 0x0000000189928650-0x00000001899286A0
                // [IDTag] // 0x0000000189928650-0x00000001899286A0
                // [XID] // 0x0000000189928650-0x00000001899286A0
    public static bool ArrayFromJson(JSONNode node, out EnvZoneEventType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAB2B0-0x0000000180DAB630
      // [IDTag] // 0x0000000189935870-0x00000001899358B0
      // [XID] // 0x0000000189935870-0x00000001899358B0
    private static bool InternalArrayFromJson(JSONNode node, out EnvZoneEventType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7E6F0-0x0000000180D7E9B0
    [BlackList] // 0x00000001899401A0-0x00000001899401F0
                // [IDTag] // 0x00000001899401A0-0x00000001899401F0
                // [XID] // 0x00000001899401A0-0x00000001899401F0
    public static bool ArrayFromJson(JSONNode node, out ConfigEnvironmentZone[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9F5B0-0x0000000180D9F930
      // [IDTag] // 0x000000018994D7D0-0x000000018994D810
      // [XID] // 0x000000018994D7D0-0x000000018994D810
    private static bool InternalArrayFromJson(JSONNode node, out ConfigEnvironmentZone[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D80A10-0x0000000180D80CC0
    [BlackList] // 0x0000000189958020-0x0000000189958070
                // [IDTag] // 0x0000000189958020-0x0000000189958070
                // [XID] // 0x0000000189958020-0x0000000189958070
    public static bool ArrayFromJson(JSONNode node, out ConfigWeatherArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBCE30-0x0000000180DBD1B0
      // [IDTag] // 0x00000001899657F0-0x0000000189965830
      // [XID] // 0x00000001899657F0-0x0000000189965830
    private static bool InternalArrayFromJson(JSONNode node, out ConfigWeatherArea[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7FCB0-0x0000000180D7FF60
    [BlackList] // 0x000000018996FC20-0x000000018996FC70
                // [IDTag] // 0x000000018996FC20-0x000000018996FC70
                // [XID] // 0x000000018996FC20-0x000000018996FC70
    public static bool ArrayFromJson(JSONNode node, out ConfigHomeFurniture[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCA3B0-0x0000000180DCA730
      // [IDTag] // 0x000000018997D090-0x000000018997D0D0
      // [XID] // 0x000000018997D090-0x000000018997D0D0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigHomeFurniture[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D86AA0-0x0000000180D86D50
    [BlackList] // 0x0000000189987F30-0x0000000189987F80
                // [IDTag] // 0x0000000189987F30-0x0000000189987F80
                // [XID] // 0x0000000189987F30-0x0000000189987F80
    public static bool ArrayFromJson(JSONNode node, out ConfigHomeFurnitureSuite[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCAE30-0x0000000180DCB1B0
      // [IDTag] // 0x0000000189995C30-0x0000000189995C70
      // [XID] // 0x0000000189995C30-0x0000000189995C70
    private static bool InternalArrayFromJson(JSONNode node, out ConfigHomeFurnitureSuite[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D79670-0x0000000180D79920
    [BlackList] // 0x00000001899A06B0-0x00000001899A0700
                // [IDTag] // 0x00000001899A06B0-0x00000001899A0700
                // [XID] // 0x00000001899A06B0-0x00000001899A0700
    public static bool ArrayFromJson(JSONNode node, out ConfigHomeAnimal[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC3030-0x0000000180DC33B0
      // [IDTag] // 0x00000001899AE0A0-0x00000001899AE0E0
      // [XID] // 0x00000001899AE0A0-0x00000001899AE0E0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigHomeAnimal[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9C4A0-0x0000000180D9C750
    [BlackList] // 0x00000001899B85F0-0x00000001899B8640
                // [IDTag] // 0x00000001899B85F0-0x00000001899B8640
                // [XID] // 0x00000001899B85F0-0x00000001899B8640
    public static bool ArrayFromJson(JSONNode node, out ConfigWeekendDjinn[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA6230-0x0000000180DA65B0
      // [IDTag] // 0x00000001899C6190-0x00000001899C61D0
      // [XID] // 0x00000001899C6190-0x00000001899C61D0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigWeekendDjinn[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D814D0-0x0000000180D81780
    [BlackList] // 0x00000001899D0800-0x00000001899D0850
                // [IDTag] // 0x00000001899D0800-0x00000001899D0850
                // [XID] // 0x00000001899D0800-0x00000001899D0850
    public static bool ArrayFromJson(JSONNode node, out ConfigHomeBlock[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB3EB0-0x0000000180DB4230
      // [IDTag] // 0x00000001899DDBB0-0x00000001899DDBF0
      // [XID] // 0x00000001899DDBB0-0x00000001899DDBF0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigHomeBlock[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D892D0-0x0000000180D89580
    [BlackList] // 0x00000001899E8720-0x00000001899E8770
                // [IDTag] // 0x00000001899E8720-0x00000001899E8770
                // [XID] // 0x00000001899E8720-0x00000001899E8770
    public static bool EnumStrToVal(string str, out ConfigSchedulePlatform e)
    {
        e = default;
        return default;
    } // 0x0000000180D3E450-0x0000000180D3E850
    [BlackList] // 0x00000001899F5B60-0x00000001899F5BB0
                // [IDTag] // 0x00000001899F5B60-0x00000001899F5BB0
                // [XID] // 0x00000001899F5B60-0x00000001899F5BB0
    public static bool EnumStrToVal(string str, out ConfigScheduleJobType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4CAB0-0x0000000180D4CBF0
    [BlackList] // 0x0000000189A031B0-0x0000000189A03200
                // [IDTag] // 0x0000000189A031B0-0x0000000189A03200
                // [XID] // 0x0000000189A031B0-0x0000000189A03200
    public static bool EnumStrToVal(string str, out ConfigSchedulerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D60250-0x0000000180D605F0
    [BlackList] // 0x0000000189A10650-0x0000000189A106A0
                // [IDTag] // 0x0000000189A10650-0x0000000189A106A0
                // [XID] // 0x0000000189A10650-0x0000000189A106A0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, ConfigJob> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCCCA0-0x0000000180CCD020
      // [IDTag] // 0x0000000189A1DAC0-0x0000000189A1DB00
      // [XID] // 0x0000000189A1DAC0-0x0000000189A1DB00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, ConfigJob> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D0BDE0-0x0000000180D0C3B0
    [BlackList] // 0x0000000189A27DE0-0x0000000189A27E30
                // [IDTag] // 0x0000000189A27DE0-0x0000000189A27E30
                // [XID] // 0x0000000189A27DE0-0x0000000189A27E30
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigJob> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBDB20-0x0000000180CBDEA0
      // [IDTag] // 0x0000000189A35790-0x0000000189A357D0
      // [XID] // 0x0000000189A35790-0x0000000189A357D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, ConfigJob> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF3D60-0x0000000180CF4390
    [BlackList] // 0x0000000189A3FE20-0x0000000189A3FE70
                // [IDTag] // 0x0000000189A3FE20-0x0000000189A3FE70
                // [XID] // 0x0000000189A3FE20-0x0000000189A3FE70
    public static bool DictFromJson(JSONNode node, out Dictionary<int, Dictionary<int, ConfigJob>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC8320-0x0000000180CC86A0
      // [IDTag] // 0x0000000189A4D3E0-0x0000000189A4D420
      // [XID] // 0x0000000189A4D3E0-0x0000000189A4D420
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, Dictionary<int, ConfigJob>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CED910-0x0000000180CEDEE0
    [BlackList] // 0x0000000189A579F0-0x0000000189A57A40
                // [IDTag] // 0x0000000189A579F0-0x0000000189A57A40
                // [XID] // 0x0000000189A579F0-0x0000000189A57A40
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigJob>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD90A0-0x0000000180CD9420
      // [IDTag] // 0x0000000189A65700-0x0000000189A65740
      // [XID] // 0x0000000189A65700-0x0000000189A65740
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigJob>> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF7F80-0x0000000180CF85B0
    [BlackList] // 0x0000000189A6FEA0-0x0000000189A6FEF0
                // [IDTag] // 0x0000000189A6FEA0-0x0000000189A6FEF0
                // [XID] // 0x0000000189A6FEA0-0x0000000189A6FEF0
    public static bool EnumStrToVal(string str, out SECTR_PlatformType e)
    {
        e = default;
        return default;
    } // 0x0000000180D54910-0x0000000180D54AA0
    [BlackList] // 0x0000000189A7D8F0-0x0000000189A7D940
                // [IDTag] // 0x0000000189A7D8F0-0x0000000189A7D940
                // [XID] // 0x0000000189A7D8F0-0x0000000189A7D940
    public static bool EnumStrToVal(string str, out SECTR_ObjectType e)
    {
        e = default;
        return default;
    } // 0x0000000180D54AA0-0x0000000180D54C30
    [BlackList] // 0x0000000189A8B200-0x0000000189A8B250
                // [IDTag] // 0x0000000189A8B200-0x0000000189A8B250
                // [XID] // 0x0000000189A8B200-0x0000000189A8B250
    public static bool EnumStrToVal(string str, out SECTR_SectorType e)
    {
        e = default;
        return default;
    } // 0x0000000180D43740-0x0000000180D438D0
    [BlackList] // 0x0000000189A98B80-0x0000000189A98BD0
                // [IDTag] // 0x0000000189A98B80-0x0000000189A98BD0
                // [XID] // 0x0000000189A98B80-0x0000000189A98BD0
    public static bool EnumStrToVal(string str, out SECTR_LayerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D53C70-0x0000000180D54150
    [BlackList] // 0x0000000189AA5E20-0x0000000189AA5E70
                // [IDTag] // 0x0000000189AA5E20-0x0000000189AA5E70
                // [XID] // 0x0000000189AA5E20-0x0000000189AA5E70
    public static bool EnumStrToVal(string str, out SECTR_StreamObjectType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6D0E0-0x0000000180D6D560
    [BlackList] // 0x0000000189AB36A0-0x0000000189AB36F0
                // [IDTag] // 0x0000000189AB36A0-0x0000000189AB36F0
                // [XID] // 0x0000000189AB36A0-0x0000000189AB36F0
    public static bool ArrayFromJson(JSONNode node, out SECTR_PlatformStreamLayer[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9EEB0-0x0000000180D9F230
      // [IDTag] // 0x0000000189AC1030-0x0000000189AC1070
      // [XID] // 0x0000000189AC1030-0x0000000189AC1070
    private static bool InternalArrayFromJson(JSONNode node, out SECTR_PlatformStreamLayer[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D804A0-0x0000000180D80750
    [BlackList] // 0x0000000189ACB950-0x0000000189ACB9A0
                // [IDTag] // 0x0000000189ACB950-0x0000000189ACB9A0
                // [XID] // 0x0000000189ACB950-0x0000000189ACB9A0
    public static bool ArrayFromJson(JSONNode node, out SECTR_AttachStreamLayer[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA9330-0x0000000180DA96B0
      // [IDTag] // 0x0000000189AD9770-0x0000000189AD97B0
      // [XID] // 0x0000000189AD9770-0x0000000189AD97B0
    private static bool InternalArrayFromJson(JSONNode node, out SECTR_AttachStreamLayer[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D79920-0x0000000180D79BD0
    [BlackList] // 0x0000000189AE4250-0x0000000189AE42A0
                // [IDTag] // 0x0000000189AE4250-0x0000000189AE42A0
                // [XID] // 0x0000000189AE4250-0x0000000189AE42A0
    public static bool ArrayFromJson(JSONNode node, out SECTR_StreamLayer[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC9CB0-0x0000000180DCA030
      // [IDTag] // 0x0000000189AF1C50-0x0000000189AF1C90
      // [XID] // 0x0000000189AF1C50-0x0000000189AF1C90
    private static bool InternalArrayFromJson(JSONNode node, out SECTR_StreamLayer[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7EC70-0x0000000180D7EF20
    [BlackList] // 0x0000000189AFBF60-0x0000000189AFBFB0
                // [IDTag] // 0x0000000189AFBF60-0x0000000189AFBFB0
                // [XID] // 0x0000000189AFBF60-0x0000000189AFBFB0
    public static bool ArrayFromJson(JSONNode node, out SECTR_LayerGroup[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC2930-0x0000000180DC2CB0
      // [IDTag] // 0x0000000189B09750-0x0000000189B09790
      // [XID] // 0x0000000189B09750-0x0000000189B09790
    private static bool InternalArrayFromJson(JSONNode node, out SECTR_LayerGroup[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D89020-0x0000000180D892D0
    [BlackList] // 0x0000000189B13C70-0x0000000189B13CC0
                // [IDTag] // 0x0000000189B13C70-0x0000000189B13CC0
                // [XID] // 0x0000000189B13C70-0x0000000189B13CC0
    public static bool ArrayFromJson(JSONNode node, out SECTR_StreamObject[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC0D30-0x0000000180DC10B0
      // [IDTag] // 0x0000000189B21110-0x0000000189B21150
      // [XID] // 0x0000000189B21110-0x0000000189B21150
    private static bool InternalArrayFromJson(JSONNode node, out SECTR_StreamObject[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D94C70-0x0000000180D94F20
    [BlackList] // 0x0000000189B2B730-0x0000000189B2B780
                // [IDTag] // 0x0000000189B2B730-0x0000000189B2B780
                // [XID] // 0x0000000189B2B730-0x0000000189B2B780
    public static bool ArrayFromJson(JSONNode node, out SECTR_BakeLayerInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCE630-0x0000000180DCE9B0
      // [IDTag] // 0x0000000189B38BD0-0x0000000189B38C10
      // [XID] // 0x0000000189B38BD0-0x0000000189B38C10
    private static bool InternalArrayFromJson(JSONNode node, out SECTR_BakeLayerInfo[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D86290-0x0000000180D86540
    [BlackList] // 0x0000000189B436B0-0x0000000189B43700
                // [IDTag] // 0x0000000189B436B0-0x0000000189B43700
                // [XID] // 0x0000000189B436B0-0x0000000189B43700
    public static bool EnumStrToVal(string str, out CenterPosType e)
    {
        e = default;
        return default;
    } // 0x0000000180D40CC0-0x0000000180D40E00
    [BlackList] // 0x0000000189B51000-0x0000000189B51050
                // [IDTag] // 0x0000000189B51000-0x0000000189B51050
                // [XID] // 0x0000000189B51000-0x0000000189B51050
    public static bool EnumStrToVal(string str, out HeightPosType e)
    {
        e = default;
        return default;
    } // 0x0000000180D496D0-0x0000000180D49810
    [BlackList] // 0x0000000189B5E900-0x0000000189B5E950
                // [IDTag] // 0x0000000189B5E900-0x0000000189B5E950
                // [XID] // 0x0000000189B5E900-0x0000000189B5E950
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigBaseShape> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD4E20-0x0000000180CD51A0
      // [IDTag] // 0x0000000189B6BB30-0x0000000189B6BB70
      // [XID] // 0x0000000189B6BB30-0x0000000189B6BB70
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigBaseShape> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D31BA0-0x0000000180D32070
    [BlackList] // 0x0000000189B762D0-0x0000000189B76320
                // [IDTag] // 0x0000000189B762D0-0x0000000189B76320
                // [XID] // 0x0000000189B762D0-0x0000000189B76320
    public static bool ArrayFromJson(JSONNode node, out TemplateParam[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBDC30-0x0000000180DBDFB0
      // [IDTag] // 0x0000000189B83B60-0x0000000189B83BA0
      // [XID] // 0x0000000189B83B60-0x0000000189B83BA0
    private static bool InternalArrayFromJson(JSONNode node, out TemplateParam[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9BF80-0x0000000180D9C210
    [BlackList] // 0x0000000189B8DD30-0x0000000189B8DD80
                // [IDTag] // 0x0000000189B8DD30-0x0000000189B8DD80
                // [XID] // 0x0000000189B8DD30-0x0000000189B8DD80
    public static bool ArrayFromJson(JSONNode node, out SkinColor[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCDBB0-0x0000000180DCDF30
      // [IDTag] // 0x0000000189B9B300-0x0000000189B9B340
      // [XID] // 0x0000000189B9B300-0x0000000189B9B340
    private static bool InternalArrayFromJson(JSONNode node, out SkinColor[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D867F0-0x0000000180D86AA0
    [BlackList] // 0x0000000189BA5890-0x0000000189BA58E0
                // [IDTag] // 0x0000000189BA5890-0x0000000189BA58E0
                // [XID] // 0x0000000189BA5890-0x0000000189BA58E0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigSkin> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD12A0-0x0000000180CD1620
      // [IDTag] // 0x0000000189BB2B50-0x0000000189BB2B90
      // [XID] // 0x0000000189BB2B50-0x0000000189BB2B90
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigSkin> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D042B0-0x0000000180D04780
    [BlackList] // 0x0000000189BBD100-0x0000000189BBD150
                // [IDTag] // 0x0000000189BBD100-0x0000000189BBD150
                // [XID] // 0x0000000189BBD100-0x0000000189BBD150
    public static bool EnumStrToVal(string str, out SoundBankUnloadPolicy e)
    {
        e = default;
        return default;
    } // 0x0000000180D72280-0x0000000180D72410
    [BlackList] // 0x0000000189BCAFF0-0x0000000189BCB040
                // [IDTag] // 0x0000000189BCAFF0-0x0000000189BCB040
                // [XID] // 0x0000000189BCAFF0-0x0000000189BCB040
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigSoundBankUnloadPolicy> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB6EA0-0x0000000180CB7220
      // [IDTag] // 0x0000000189BD8210-0x0000000189BD8250
      // [XID] // 0x0000000189BD8210-0x0000000189BD8250
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigSoundBankUnloadPolicy> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D191B0-0x0000000180D196B0
    [BlackList] // 0x00000001895E7F90-0x00000001895E7FE0
                // [IDTag] // 0x00000001895E7F90-0x00000001895E7FE0
                // [XID] // 0x00000001895E7F90-0x00000001895E7FE0
    public static bool ArrayFromJson(JSONNode node, out ConfigSpatialBoxRoomTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB45B0-0x0000000180DB4930
      // [IDTag] // 0x00000001895F5890-0x00000001895F58D0
      // [XID] // 0x00000001895F5890-0x00000001895F58D0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigSpatialBoxRoomTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8FBC0-0x0000000180D8FE70
    [BlackList] // 0x00000001895FFE70-0x00000001895FFEC0
                // [IDTag] // 0x00000001895FFE70-0x00000001895FFEC0
                // [XID] // 0x00000001895FFE70-0x00000001895FFEC0
    public static bool ArrayFromJson(JSONNode node, out ConfigSpatialSphereRoomTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAE730-0x0000000180DAEAB0
      // [IDTag] // 0x000000018960D800-0x000000018960D840
      // [XID] // 0x000000018960D800-0x000000018960D840
    private static bool InternalArrayFromJson(JSONNode node, out ConfigSpatialSphereRoomTrigger[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7BEB0-0x0000000180D7C160
    [BlackList] // 0x0000000189617B90-0x0000000189617BE0
                // [IDTag] // 0x0000000189617B90-0x0000000189617BE0
                // [XID] // 0x0000000189617B90-0x0000000189617BE0
    public static bool ArrayFromJson(JSONNode node, out ConfigSpatialRoom[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA18B0-0x0000000180DA1C30
      // [IDTag] // 0x00000001896253D0-0x0000000189625410
      // [XID] // 0x00000001896253D0-0x0000000189625410
    private static bool InternalArrayFromJson(JSONNode node, out ConfigSpatialRoom[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D94700-0x0000000180D949B0
    [BlackList] // 0x000000018962FD60-0x000000018962FDB0
                // [IDTag] // 0x000000018962FD60-0x000000018962FDB0
                // [XID] // 0x000000018962FD60-0x000000018962FDB0
    public static bool ArrayFromJson(JSONNode node, out ConfigSpatialPortal[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC64B0-0x0000000180DC6830
      // [IDTag] // 0x000000018963D850-0x000000018963D890
      // [XID] // 0x000000018963D850-0x000000018963D890
    private static bool InternalArrayFromJson(JSONNode node, out ConfigSpatialPortal[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7B6A0-0x0000000180D7B950
    [BlackList] // 0x0000000189647C70-0x0000000189647CC0
                // [IDTag] // 0x0000000189647C70-0x0000000189647CC0
                // [XID] // 0x0000000189647C70-0x0000000189647CC0
    public static bool EnumStrToVal(string str, out StateAudioEventUsage e)
    {
        e = default;
        return default;
    } // 0x0000000180D668D0-0x0000000180D66A60
    [BlackList] // 0x00000001896555E0-0x0000000189655630
                // [IDTag] // 0x00000001896555E0-0x0000000189655630
                // [XID] // 0x00000001896555E0-0x0000000189655630
    public static bool ArrayFromJson(JSONNode node, out ConfigStateAudioEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA0030-0x0000000180DA03B0
      // [IDTag] // 0x0000000189662A00-0x0000000189662A40
      // [XID] // 0x0000000189662A00-0x0000000189662A40
    private static bool InternalArrayFromJson(JSONNode node, out ConfigStateAudioEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7BC00-0x0000000180D7BEB0
    [BlackList] // 0x000000018966D220-0x000000018966D270
                // [IDTag] // 0x000000018966D220-0x000000018966D270
                // [XID] // 0x000000018966D220-0x000000018966D270
    public static bool EnumStrToVal(string str, out ActionPanelState e)
    {
        e = default;
        return default;
    } // 0x0000000180D5D370-0x0000000180D5D770
    [BlackList] // 0x000000018967AF00-0x000000018967AF50
                // [IDTag] // 0x000000018967AF00-0x000000018967AF50
                // [XID] // 0x000000018967AF00-0x000000018967AF50
    public static bool EnumStrToVal(string str, out MoveType e)
    {
        e = default;
        return default;
    } // 0x0000000180D564B0-0x0000000180D566C0
    [BlackList] // 0x0000000189688BE0-0x0000000189688C30
                // [IDTag] // 0x0000000189688BE0-0x0000000189688C30
                // [XID] // 0x0000000189688BE0-0x0000000189688C30
    public static bool EnumStrToVal(string str, out StateCameraType e)
    {
        e = default;
        return default;
    } // 0x0000000180D45E10-0x0000000180D45FA0
    [BlackList] // 0x00000001896967F0-0x0000000189696840
                // [IDTag] // 0x00000001896967F0-0x0000000189696840
                // [XID] // 0x00000001896967F0-0x0000000189696840
    public static bool ArrayFromJson(JSONNode node, out ConfigAnimatorBoolean[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAAF30-0x0000000180DAB2B0
      // [IDTag] // 0x00000001896A3960-0x00000001896A39A0
      // [XID] // 0x00000001896A3960-0x00000001896A39A0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigAnimatorBoolean[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9A4C0-0x0000000180D9A770
    [BlackList] // 0x00000001896ADB90-0x00000001896ADBE0
                // [IDTag] // 0x00000001896ADB90-0x00000001896ADBE0
                // [XID] // 0x00000001896ADB90-0x00000001896ADBE0
    public static bool ArrayFromJson(JSONNode node, out ConfigCanChangeAvatar[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA4630-0x0000000180DA49B0
      // [IDTag] // 0x00000001896BB170-0x00000001896BB1B0
      // [XID] // 0x00000001896BB170-0x00000001896BB1B0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigCanChangeAvatar[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D92450-0x0000000180D92700
    [BlackList] // 0x00000001896C5410-0x00000001896C5460
                // [IDTag] // 0x00000001896C5410-0x00000001896C5460
                // [XID] // 0x00000001896C5410-0x00000001896C5460
    public static bool ArrayFromJson(JSONNode node, out ConfigEquipReattach[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB9630-0x0000000180DB99B0
      // [IDTag] // 0x00000001896D26A0-0x00000001896D26E0
      // [XID] // 0x00000001896D26A0-0x00000001896D26E0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigEquipReattach[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D93EF0-0x0000000180D941A0
    [BlackList] // 0x00000001896DCD00-0x00000001896DCD50
                // [IDTag] // 0x00000001896DCD00-0x00000001896DCD50
                // [XID] // 0x00000001896DCD00-0x00000001896DCD50
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigNormalStateIDInfo> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE2AA0-0x0000000180CE2E20
      // [IDTag] // 0x00000001896EA420-0x00000001896EA460
      // [XID] // 0x00000001896EA420-0x00000001896EA460
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigNormalStateIDInfo> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D12520-0x0000000180D129F0
    [BlackList] // 0x00000001896F49C0-0x00000001896F4A10
                // [IDTag] // 0x00000001896F49C0-0x00000001896F4A10
                // [XID] // 0x00000001896F49C0-0x00000001896F4A10
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigBaseStateLayer> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCFDA0-0x0000000180CD0120
      // [IDTag] // 0x0000000189701F60-0x0000000189701FA0
      // [XID] // 0x0000000189701F60-0x0000000189701FA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigBaseStateLayer> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D211A0-0x0000000180D21670
    [BlackList] // 0x000000018970C530-0x000000018970C580
                // [IDTag] // 0x000000018970C530-0x000000018970C580
                // [XID] // 0x000000018970C530-0x000000018970C580
    public static bool ArrayFromJson(JSONNode node, out ConfigTalentMixin[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB2630-0x0000000180DB29B0
      // [IDTag] // 0x0000000189719F30-0x0000000189719F70
      // [XID] // 0x0000000189719F30-0x0000000189719F70
    private static bool InternalArrayFromJson(JSONNode node, out ConfigTalentMixin[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D9C210-0x0000000180D9C4A0
    [BlackList] // 0x00000001897241F0-0x0000000189724240
                // [IDTag] // 0x00000001897241F0-0x0000000189724240
                // [XID] // 0x00000001897241F0-0x0000000189724240
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigTalentMixin[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCFA20-0x0000000180CCFDA0
      // [IDTag] // 0x0000000189731860-0x00000001897318A0
      // [XID] // 0x0000000189731860-0x00000001897318A0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigTalentMixin[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2D580-0x0000000180D2DA80
    [BlackList] // 0x000000018973C2C0-0x000000018973C310
                // [IDTag] // 0x000000018973C2C0-0x000000018973C310
                // [XID] // 0x000000018973C2C0-0x000000018973C310
    public static bool EnumStrToVal(string str, out TalentType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6BBA0-0x0000000180D6BD70
    [BlackList] // 0x0000000189749C00-0x0000000189749C50
                // [IDTag] // 0x0000000189749C00-0x0000000189749C50
                // [XID] // 0x0000000189749C00-0x0000000189749C50
    public static bool ArrayFromJson(JSONNode node, out TalkCondEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA8C30-0x0000000180DA8FB0
      // [IDTag] // 0x0000000189757200-0x0000000189757240
      // [XID] // 0x0000000189757200-0x0000000189757240
    private static bool InternalArrayFromJson(JSONNode node, out TalkCondEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D94F20-0x0000000180D951D0
    [BlackList] // 0x00000001897619D0-0x0000000189761A20
                // [IDTag] // 0x00000001897619D0-0x0000000189761A20
                // [XID] // 0x00000001897619D0-0x0000000189761A20
    public static bool ArrayFromJson(JSONNode node, out TalkExecEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCCA30-0x0000000180DCCDB0
      // [IDTag] // 0x000000018976EBC0-0x000000018976EC00
      // [XID] // 0x000000018976EBC0-0x000000018976EC00
    private static bool InternalArrayFromJson(JSONNode node, out TalkExecEx[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D87000-0x0000000180D872B0
    [BlackList] // 0x0000000189779580-0x00000001897795D0
                // [IDTag] // 0x0000000189779580-0x00000001897795D0
                // [XID] // 0x0000000189779580-0x00000001897795D0
    public static bool EnumStrToVal(string str, out DialogGroupSchemeType e)
    {
        e = default;
        return default;
    } // 0x0000000180D78AE0-0x0000000180D78DF0
    [BlackList] // 0x0000000189786C60-0x0000000189786CB0
                // [IDTag] // 0x0000000189786C60-0x0000000189786CB0
                // [XID] // 0x0000000189786C60-0x0000000189786CB0
    public static bool ArrayFromJson(JSONNode node, out ConfigDialogScheme[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBC030-0x0000000180DBC3B0
      // [IDTag] // 0x0000000189793E20-0x0000000189793E60
      // [XID] // 0x0000000189793E20-0x0000000189793E60
    private static bool InternalArrayFromJson(JSONNode node, out ConfigDialogScheme[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D984C0-0x0000000180D98770
    [BlackList] // 0x000000018979F1D0-0x000000018979F220
                // [IDTag] // 0x000000018979F1D0-0x000000018979F220
                // [XID] // 0x000000018979F1D0-0x000000018979F220
    public static bool EnumStrToVal(string str, out TextMapPlatformType e)
    {
        e = default;
        return default;
    } // 0x0000000180D46B50-0x0000000180D46E60
    [BlackList] // 0x00000001897AC640-0x00000001897AC690
                // [IDTag] // 0x00000001897AC640-0x00000001897AC690
                // [XID] // 0x00000001897AC640-0x00000001897AC690
    public static bool DictFromJson(JSONNode node, out Dictionary<int, TextMapLevelStruct> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CBECA0-0x0000000180CBF020
      // [IDTag] // 0x00000001897BA070-0x00000001897BA0B0
      // [XID] // 0x00000001897BA070-0x00000001897BA0B0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, TextMapLevelStruct> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFE880-0x0000000180CFEE50
    [BlackList] // 0x00000001897C5160-0x00000001897C51B0
                // [IDTag] // 0x00000001897C5160-0x00000001897C51B0
                // [XID] // 0x00000001897C5160-0x00000001897C51B0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, TextMapLevelStruct> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE00A0-0x0000000180CE0420
      // [IDTag] // 0x00000001897D28B0-0x00000001897D28F0
      // [XID] // 0x00000001897D28B0-0x00000001897D28F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, TextMapLevelStruct> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D069B0-0x0000000180D06FE0
    [BlackList] // 0x00000001897DD090-0x00000001897DD0E0
                // [IDTag] // 0x00000001897DD090-0x00000001897DD0E0
                // [XID] // 0x00000001897DD090-0x00000001897DD0E0
    public static bool DictFromJson(JSONNode node, out Dictionary<TextMapPlatformType, int> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB7CA0-0x0000000180CB8020
      // [IDTag] // 0x00000001897EAAA0-0x00000001897EAAE0
      // [XID] // 0x00000001897EAAA0-0x00000001897EAAE0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<TextMapPlatformType, int> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF7980-0x0000000180CF7F80
    [BlackList] // 0x00000001897F5490-0x00000001897F54E0
                // [IDTag] // 0x00000001897F5490-0x00000001897F54E0
                // [XID] // 0x00000001897F5490-0x00000001897F54E0
    public static bool DictFromJson(JSONNode node, out Dictionary<TextMapPlatformType, SimpleSafeInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCDE20-0x0000000180CCE1A0
      // [IDTag] // 0x0000000189802D80-0x0000000189802DC0
      // [XID] // 0x0000000189802D80-0x0000000189802DC0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<TextMapPlatformType, SimpleSafeInt32> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D2C2E0-0x0000000180D2C920
    [BlackList] // 0x000000018980D070-0x000000018980D0C0
                // [IDTag] // 0x000000018980D070-0x000000018980D0C0
                // [XID] // 0x000000018980D070-0x000000018980D0C0
    public static bool EnumStrToVal(string str, out ConcernType e)
    {
        e = default;
        return default;
    } // 0x0000000180D438D0-0x0000000180D43AE0
    [BlackList] // 0x000000018981AB80-0x000000018981ABD0
                // [IDTag] // 0x000000018981AB80-0x000000018981ABD0
                // [XID] // 0x000000018981AB80-0x000000018981ABD0
    public static bool EnumStrToVal(string str, out TriggerFlag e)
    {
        e = default;
        return default;
    } // 0x0000000180D46E60-0x0000000180D471D0
    [BlackList] // 0x00000001898283A0-0x00000001898283F0
                // [IDTag] // 0x00000001898283A0-0x00000001898283F0
                // [XID] // 0x00000001898283A0-0x00000001898283F0
    public static bool EnumStrToVal(string str, out InputActionType e)
    {
        e = default;
        return default;
    } // 0x0000000180D56890-0x0000000180D580A0
    [BlackList] // 0x00000001898356B0-0x0000000189835700
                // [IDTag] // 0x00000001898356B0-0x0000000189835700
                // [XID] // 0x00000001898356B0-0x0000000189835700
    public static bool EnumStrToVal(string str, out InputValueType e)
    {
        e = default;
        return default;
    } // 0x0000000180D55CA0-0x0000000180D55E30
    [BlackList] // 0x0000000189842CC0-0x0000000189842D10
                // [IDTag] // 0x0000000189842CC0-0x0000000189842D10
                // [XID] // 0x0000000189842CC0-0x0000000189842D10
    public static bool EnumStrToVal(string str, out ActionEventType e)
    {
        e = default;
        return default;
    } // 0x0000000180D58AB0-0x0000000180D58EB0
    [BlackList] // 0x000000018984FDA0-0x000000018984FDF0
                // [IDTag] // 0x000000018984FDA0-0x000000018984FDF0
                // [XID] // 0x000000018984FDA0-0x000000018984FDF0
    public static bool EnumStrToVal(string str, out InputEventType e)
    {
        e = default;
        return default;
    } // 0x0000000180D49D70-0x0000000180D4BBA0
    [BlackList] // 0x000000018985CDD0-0x000000018985CE20
                // [IDTag] // 0x000000018985CDD0-0x000000018985CE20
                // [XID] // 0x000000018985CDD0-0x000000018985CE20
    public static bool EnumStrToVal(string str, out InputDeviceType e)
    {
        e = default;
        return default;
    } // 0x0000000180D759A0-0x0000000180D75B70
    [BlackList] // 0x000000018986A6E0-0x000000018986A730
                // [IDTag] // 0x000000018986A6E0-0x000000018986A730
                // [XID] // 0x000000018986A6E0-0x000000018986A730
    public static bool DictFromJson(JSONNode node, out Dictionary<InputActionType, ConfigBaseInputAction> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE2E20-0x0000000180CE31A0
      // [IDTag] // 0x0000000189877890-0x00000001898778D0
      // [XID] // 0x0000000189877890-0x00000001898778D0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<InputActionType, ConfigBaseInputAction> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D181D0-0x0000000180D187A0
    [BlackList] // 0x0000000189881D80-0x0000000189881DD0
                // [IDTag] // 0x0000000189881D80-0x0000000189881DD0
                // [XID] // 0x0000000189881D80-0x0000000189881DD0
    public static bool EnumStrToVal(string str, out ActionCompoundType e)
    {
        e = default;
        return default;
    } // 0x0000000180D6CBC0-0x0000000180D6CD00
    [BlackList] // 0x000000018988F1E0-0x000000018988F230
                // [IDTag] // 0x000000018988F1E0-0x000000018988F230
                // [XID] // 0x000000018988F1E0-0x000000018988F230
    public static bool DictFromJson(JSONNode node, out Dictionary<InputEventType, ConfigBaseInputEvent> dict)
    {
        return InternalDictFromJson(node, out dict);
    } // 0x0000000180CBA6A0-0x0000000180CBAA20
      // [IDTag] // 0x000000018989C6A0-0x000000018989C6E0
      // [XID] // 0x000000018989C6A0-0x000000018989C6E0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<InputEventType, ConfigBaseInputEvent> dict)
    {
        var e = InputEventType.Invalid;
        if (node.Count > 0)
        {
            var json = node as JSONClass;
            if (json == 0)
            {
                JsonTool.GetEmptyValue(out dict);
                SuperDebug.LogError("node is not JSONClass for map: Dictionary<InputEventType, ConfigBaseInputEvent>");
                return false;
            }
            var val = MoleMole.Lazy<InputEventTypeComparer>.Get<InputEventTypeComparer>();
            dict = new Dictionary<InputEventType, ConfigBaseInputEvent>(val);

            foreach (JSONNode j in json)
            {
                string cnm = null;
                foreach (var key in j.Keys)//获取0x00的key 之后换个更好的方法
                {
                    if (cnm == null)
                    {
                        cnm = key;
                        break;
                    }
                }
                if (!EnumStrToVal(cnm, out e))
                {
                    SuperDebug.LogError("convert key:" + j + "to InputEventType fails");
                    return false;
                }
                if (dict.ContainsKey(e))
                {

                    SuperDebug.LogError("Dictionary<InputEventType, ConfigBaseInputEvent> already contains key:" + e);
                    return false;
                }
                var configEvent = new ConfigBaseInputEvent();
                if (!configEvent.FromJson(j.Value))
                {
                    SuperDebug.LogError("FromJson for: ConfigBaseInputEvent fails! in:" + e);
                    return false;
                }
                dict[e] = configEvent;
            }
        }
        else
        {
            GetEmptyValue(out dict);
        }
        return true;
    } // 0x0000000180D0A710-0x0000000180D0AD10
    [BlackList] // 0x00000001898A6DC0-0x00000001898A6E10
                // [IDTag] // 0x00000001898A6DC0-0x00000001898A6E10
                // [XID] // 0x00000001898A6DC0-0x00000001898A6E10
    public static bool EnumStrToVal(string str, out ContextEventType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4E410-0x0000000180D50430
    [BlackList] // 0x00000001898B4080-0x00000001898B40D0
                // [IDTag] // 0x00000001898B4080-0x00000001898B40D0
                // [XID] // 0x00000001898B4080-0x00000001898B40D0
    public static bool ArrayFromJson(JSONNode node, out InputActionEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DA11B0-0x0000000180DA1530
      // [IDTag] // 0x00000001898C19C0-0x00000001898C1A00
      // [XID] // 0x00000001898C19C0-0x00000001898C1A00
    private static bool InternalArrayFromJson(JSONNode node, out InputActionEvent[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7E9B0-0x0000000180D7EC70
    [BlackList] // 0x00000001898CC110-0x00000001898CC160
                // [IDTag] // 0x00000001898CC110-0x00000001898CC160
                // [XID] // 0x00000001898CC110-0x00000001898CC160
    public static bool DictFromJson(JSONNode node, out Dictionary<string, InputActionEvent[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDACA0-0x0000000180CDB020
      // [IDTag] // 0x00000001898D9C10-0x00000001898D9C50
      // [XID] // 0x00000001898D9C10-0x00000001898D9C50
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, InputActionEvent[]> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CFF420-0x0000000180CFF920
    [BlackList] // 0x00000001898E4780-0x00000001898E47D0
                // [IDTag] // 0x00000001898E4780-0x00000001898E47D0
                // [XID] // 0x00000001898E4780-0x00000001898E47D0
    public static bool DictFromJson(JSONNode node, out Dictionary<int, DeviceAction> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB75A0-0x0000000180CB7920
      // [IDTag] // 0x00000001898F22D0-0x00000001898F2310
      // [XID] // 0x00000001898F22D0-0x00000001898F2310
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<int, DeviceAction> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D22170-0x0000000180D22760
    [BlackList] // 0x00000001898FC9D0-0x00000001898FCA20
                // [IDTag] // 0x00000001898FC9D0-0x00000001898FCA20
                // [XID] // 0x00000001898FC9D0-0x00000001898FCA20
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, DeviceAction> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE23A0-0x0000000180CE2720
      // [IDTag] // 0x000000018990A220-0x000000018990A260
      // [XID] // 0x000000018990A220-0x000000018990A260
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeInt32, DeviceAction> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF7330-0x0000000180CF7980
    [BlackList] // 0x0000000189914B60-0x0000000189914BB0
                // [IDTag] // 0x0000000189914B60-0x0000000189914BB0
                // [XID] // 0x0000000189914B60-0x0000000189914BB0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigBaseContext> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC9120-0x0000000180CC94A0
      // [IDTag] // 0x0000000189922540-0x0000000189922580
      // [XID] // 0x0000000189922540-0x0000000189922580
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigBaseContext> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1A810-0x0000000180D1AD10
    [BlackList] // 0x000000018992CA60-0x000000018992CAB0
                // [IDTag] // 0x000000018992CA60-0x000000018992CAB0
                // [XID] // 0x000000018992CA60-0x000000018992CAB0
    public static bool EnumStrToVal(string str, out MainPageUIDisableType e)
    {
        e = default;
        return default;
    } // 0x0000000180D4CD30-0x0000000180D4D130
    [BlackList] // 0x000000018993A570-0x000000018993A5C0
                // [IDTag] // 0x000000018993A570-0x000000018993A5C0
                // [XID] // 0x000000018993A570-0x000000018993A5C0
    public static bool ArrayFromJson(JSONNode node, out MainPageUIDisableType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAB630-0x0000000180DAB9B0
      // [IDTag] // 0x0000000189947780-0x00000001899477C0
      // [XID] // 0x0000000189947780-0x00000001899477C0
    private static bool InternalArrayFromJson(JSONNode node, out MainPageUIDisableType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D98770-0x0000000180D98A30
    [BlackList] // 0x0000000189952170-0x00000001899521C0
                // [IDTag] // 0x0000000189952170-0x00000001899521C0
                // [XID] // 0x0000000189952170-0x00000001899521C0
    public static bool ArrayFromJson(JSONNode node, out InputEventType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DAF8B0-0x0000000180DAFC30
      // [IDTag] // 0x000000018995F850-0x000000018995F890
      // [XID] // 0x000000018995F850-0x000000018995F890
    private static bool InternalArrayFromJson(JSONNode node, out InputEventType[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D7F9F0-0x0000000180D7FCB0
    [BlackList] // 0x0000000189969E60-0x0000000189969EB0
                // [IDTag] // 0x0000000189969E60-0x0000000189969EB0
                // [XID] // 0x0000000189969E60-0x0000000189969EB0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigMainPageDisableInfo> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC01A0-0x0000000180CC0520
      // [IDTag] // 0x0000000189977AC0-0x0000000189977B00
      // [XID] // 0x0000000189977AC0-0x0000000189977B00
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigMainPageDisableInfo> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D187A0-0x0000000180D18CA0
    [BlackList] // 0x0000000189982320-0x0000000189982370
                // [IDTag] // 0x0000000189982320-0x0000000189982370
                // [XID] // 0x0000000189982320-0x0000000189982370
    public static bool EnumStrToVal(string str, out ConfigWeatherType e)
    {
        e = default;
        return default;
    } // 0x0000000180D53640-0x0000000180D53950
    [BlackList] // 0x000000018998F9C0-0x000000018998FA10
                // [IDTag] // 0x000000018998F9C0-0x000000018998FA10
                // [XID] // 0x000000018998F9C0-0x000000018998FA10
    public static bool EnumStrToVal(string str, out ElemBallTriggerType e)
    {
        e = default;
        return default;
    } // 0x0000000180D47920-0x0000000180D47B30
    [BlackList] // 0x000000018999D730-0x000000018999D780
                // [IDTag] // 0x000000018999D730-0x000000018999D780
                // [XID] // 0x000000018999D730-0x000000018999D780
    public static bool ArrayFromJson(JSONNode node, out ConfigElemBall[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DBCAB0-0x0000000180DBCE30
      // [IDTag] // 0x00000001899AB180-0x00000001899AB1C0
      // [XID] // 0x00000001899AB180-0x00000001899AB1C0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigElemBall[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8FE70-0x0000000180D90120
    [BlackList] // 0x00000001899B5860-0x00000001899B58B0
                // [IDTag] // 0x00000001899B5860-0x00000001899B58B0
                // [XID] // 0x00000001899B5860-0x00000001899B58B0
    public static bool EnumStrToVal(string str, out WidgetEventType e)
    {
        e = default;
        return default;
    } // 0x0000000180D77700-0x0000000180D77800
    [BlackList] // 0x00000001899C3320-0x00000001899C3370
                // [IDTag] // 0x00000001899C3320-0x00000001899C3370
                // [XID] // 0x00000001899C3320-0x00000001899C3370
    public static bool EnumStrToVal(string str, out CollectorType e)
    {
        e = default;
        return default;
    } // 0x0000000180D753F0-0x0000000180D754F0
    [BlackList] // 0x00000001899D07B0-0x00000001899D0800
                // [IDTag] // 0x00000001899D07B0-0x00000001899D0800
                // [XID] // 0x00000001899D07B0-0x00000001899D0800
    public static bool EnumStrToVal(string str, out OrnamentsType e)
    {
        e = default;
        return default;
    } // 0x0000000180D484F0-0x0000000180D48630
    [BlackList] // 0x00000001899DDB60-0x00000001899DDBB0
                // [IDTag] // 0x00000001899DDB60-0x00000001899DDBB0
                // [XID] // 0x00000001899DDB60-0x00000001899DDBB0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigBaseWidget> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE38A0-0x0000000180CE3C20
      // [IDTag] // 0x00000001899EB0E0-0x00000001899EB120
      // [XID] // 0x00000001899EB0E0-0x00000001899EB120
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigBaseWidget> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D379E0-0x0000000180D37EB0
    [BlackList] // 0x00000001899F5B10-0x00000001899F5B60
                // [IDTag] // 0x00000001899F5B10-0x00000001899F5B60
                // [XID] // 0x00000001899F5B10-0x00000001899F5B60
    public static bool ArrayFromJson(JSONNode node, out ConfigWidgetAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DCB1B0-0x0000000180DCB530
      // [IDTag] // 0x0000000189A03170-0x0000000189A031B0
      // [XID] // 0x0000000189A03170-0x0000000189A031B0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigWidgetAction[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D99D10-0x0000000180D99FA0
    [BlackList] // 0x0000000189A0D8C0-0x0000000189A0D910
                // [IDTag] // 0x0000000189A0D8C0-0x0000000189A0D910
                // [XID] // 0x0000000189A0D8C0-0x0000000189A0D910
    public static bool ArrayFromJson(JSONNode node, out ConfigWidgetPredict[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC17B0-0x0000000180DC1B30
      // [IDTag] // 0x0000000189A1AA70-0x0000000189A1AAB0
      // [XID] // 0x0000000189A1AA70-0x0000000189A1AAB0
    private static bool InternalArrayFromJson(JSONNode node, out ConfigWidgetPredict[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D84D30-0x0000000180D84FC0
    [BlackList] // 0x0000000189A24FD0-0x0000000189A25020
                // [IDTag] // 0x0000000189A24FD0-0x0000000189A25020
                // [XID] // 0x0000000189A24FD0-0x0000000189A25020
    public static bool EnumStrToVal(string str, out WidgetOccupyTag e)
    {
        e = default;
        return default;
    } // 0x0000000180D72140-0x0000000180D72280
    [BlackList] // 0x0000000189A323C0-0x0000000189A32410
                // [IDTag] // 0x0000000189A323C0-0x0000000189A32410
                // [XID] // 0x0000000189A323C0-0x0000000189A32410
    public static bool ArrayFromJson(JSONNode node, out WidgetOccupyTag[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DC79B0-0x0000000180DC7D30
      // [IDTag] // 0x0000000189A3FDE0-0x0000000189A3FE20
      // [XID] // 0x0000000189A3FDE0-0x0000000189A3FE20
    private static bool InternalArrayFromJson(JSONNode node, out WidgetOccupyTag[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8C0A0-0x0000000180D8C360
    [BlackList] // 0x0000000189A4A340-0x0000000189A4A390
                // [IDTag] // 0x0000000189A4A340-0x0000000189A4A390
                // [XID] // 0x0000000189A4A340-0x0000000189A4A390
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ConfigWidgetGadget> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CCF320-0x0000000180CCF6A0
      // [IDTag] // 0x0000000189A579B0-0x0000000189A579F0
      // [XID] // 0x0000000189A579B0-0x0000000189A579F0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ConfigWidgetGadget> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D00A20-0x0000000180D00FF0
    [BlackList] // 0x0000000189A62250-0x0000000189A622A0
                // [IDTag] // 0x0000000189A62250-0x0000000189A622A0
                // [XID] // 0x0000000189A62250-0x0000000189A622A0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigWidgetGadget> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CD0BA0-0x0000000180CD0F20
      // [IDTag] // 0x0000000189A6FE60-0x0000000189A6FEA0
      // [XID] // 0x0000000189A6FE60-0x0000000189A6FEA0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigWidgetGadget> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CF6D00-0x0000000180CF7330
    [BlackList] // 0x0000000189A7AB10-0x0000000189A7AB60
                // [IDTag] // 0x0000000189A7AB10-0x0000000189A7AB60
                // [XID] // 0x0000000189A7AB10-0x0000000189A7AB60
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ConfigWidgetCdGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CE3FA0-0x0000000180CE4320
      // [IDTag] // 0x0000000189A88240-0x0000000189A88280
      // [XID] // 0x0000000189A88240-0x0000000189A88280
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ConfigWidgetCdGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D24230-0x0000000180D24800
    [BlackList] // 0x0000000189A92950-0x0000000189A929A0
                // [IDTag] // 0x0000000189A92950-0x0000000189A929A0
                // [XID] // 0x0000000189A92950-0x0000000189A929A0
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigWidgetCdGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB8E20-0x0000000180CB91A0
      // [IDTag] // 0x0000000189A9FE90-0x0000000189A9FED0
      // [XID] // 0x0000000189A9FE90-0x0000000189A9FED0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigWidgetCdGroup> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D036B0-0x0000000180D03CE0
    [BlackList] // 0x0000000189AAA300-0x0000000189AAA350
                // [IDTag] // 0x0000000189AAA300-0x0000000189AAA350
                // [XID] // 0x0000000189AAA300-0x0000000189AAA350
    public static bool EnumStrToVal(string str, out WidgetConsumeTime e)
    {
        e = default;
        return default;
    } // 0x0000000180D61060-0x0000000180D611A0
    [BlackList] // 0x0000000189AB7D80-0x0000000189AB7DD0
                // [IDTag] // 0x0000000189AB7D80-0x0000000189AB7DD0
                // [XID] // 0x0000000189AB7D80-0x0000000189AB7DD0
    public static bool DictFromJson(JSONNode node, out Dictionary<uint, ConfigBaseWidgetToy> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CDB020-0x0000000180CDB3A0
      // [IDTag] // 0x0000000189AC5D70-0x0000000189AC5DB0
      // [XID] // 0x0000000189AC5D70-0x0000000189AC5DB0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<uint, ConfigBaseWidgetToy> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D09BA0-0x0000000180D0A140
    [BlackList] // 0x0000000189AD01B0-0x0000000189AD0200
                // [IDTag] // 0x0000000189AD01B0-0x0000000189AD0200
                // [XID] // 0x0000000189AD01B0-0x0000000189AD0200
    public static bool DictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigBaseWidgetToy> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CC86A0-0x0000000180CC8A20
      // [IDTag] // 0x0000000189ADE180-0x0000000189ADE1C0
      // [XID] // 0x0000000189ADE180-0x0000000189ADE1C0
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<SimpleSafeUInt32, ConfigBaseWidgetToy> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CEC1D0-0x0000000180CEC7E0
    [BlackList] // 0x0000000189AE8710-0x0000000189AE8760
                // [IDTag] // 0x0000000189AE8710-0x0000000189AE8760
                // [XID] // 0x0000000189AE8710-0x0000000189AE8760
    public static bool ArrayFromJson(JSONNode node, out ConfigWwiseString[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180DB7A30-0x0000000180DB7DB0
      // [IDTag] // 0x0000000189AF62D0-0x0000000189AF6310
      // [XID] // 0x0000000189AF62D0-0x0000000189AF6310
    private static bool InternalArrayFromJson(JSONNode node, out ConfigWwiseString[] arr)
    {
        arr = default;
        return default;
    } // 0x0000000180D8ADC0-0x0000000180D8B070
    [BlackList] // 0x0000000189B00890-0x0000000189B008E0
                // [IDTag] // 0x0000000189B00890-0x0000000189B008E0
                // [XID] // 0x0000000189B00890-0x0000000189B008E0
    public static bool DictFromJson(JSONNode node, out Dictionary<string, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180CB8720-0x0000000180CB8AA0
      // [IDTag] // 0x0000000189B0E050-0x0000000189B0E090
      // [XID] // 0x0000000189B0E050-0x0000000189B0E090
    private static bool InternalDictFromJson(JSONNode node, out Dictionary<string, ConfigWwiseString> dict)
    {
        dict = default;
        return default;
    } // 0x0000000180D1EB20-0x0000000180D1F020
      // [IDTag] // 0x0000000189B18420-0x0000000189B18460
      // [XID] // 0x0000000189B18420-0x0000000189B18460
    public static string EnumValToStr(ElementType e) => default; // 0x0000000180D78F80-0x0000000180D79110
                                                                 // [IDTag] // 0x0000000189B22A70-0x0000000189B22AB0
                                                                 // [XID] // 0x0000000189B22A70-0x0000000189B22AB0
    public static string EnumValToStr(ElementReactionType e) => default; // 0x0000000180D78DF0-0x0000000180D78F80
}


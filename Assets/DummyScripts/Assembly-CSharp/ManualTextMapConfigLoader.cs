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

public static class ManualTextMapConfigLoader // TypeDefIndex: 16186
{
	// Fields
	private static Dictionary<string, ManualTextMapConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ManualTextMapConfig>> customApplyHotfixAction; // 0x08
	public static Action<ManualTextMapConfig, ManualTextMapConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ManualTextMapConfig>, Dictionary<string, ManualTextMapConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<string, ManualTextMapConfig> dataDict { /* [XID] */ /* 0x00000001897002A0-0x00000001897002C0 */ get; } // 0x000000018506B2C0-0x000000018506B370 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018970F500-0x000000018970F520 */ get; } // 0x000000018506A120-0x000000018506A1C0 

	// Methods
	// [XID] // 0x00000001896F8A80-0x00000001896F8AA0
	public static void Register() {} // 0x000000018506B6A0-0x000000018506B740
	// [XID] // 0x0000000189707AD0-0x0000000189707AF0
	public static ManualTextMapConfig GetData(string textMapId) => default; // 0x0000000185069FE0-0x000000018506A120
	// [XID] // 0x00000001897168E0-0x0000000189716900
	public static void LoadData() {} // 0x000000018506A750-0x000000018506A840
	// [XID] // 0x000000018971E320-0x000000018971E340
	private static void RegisterHotfixGenerated() {} // 0x000000018506A580-0x000000018506A750
	// [XID] // 0x0000000189725860-0x0000000189725880
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018506A1C0-0x000000018506A580
	// [IDTag] // 0x000000018972CD60-0x000000018972CDA0
	// [XID] // 0x000000018972CD60-0x000000018972CDA0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018506AC20-0x000000018506AD20
	// [XID] // 0x0000000189737960-0x0000000189737980
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ManualTextMapConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018506B370-0x000000018506B6A0
	// [XID] // 0x000000018973F440-0x000000018973F460
	private static bool ParseConfigFromLine(string line, out ManualTextMapConfig data) {
		data = default;
		return default;
	} // 0x000000018506A840-0x000000018506A980
	// [IDTag] // 0x00000001897467A0-0x00000001897467E0
	// [XID] // 0x00000001897467A0-0x00000001897467E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ManualTextMapConfig> configList) => default; // 0x000000018506A980-0x000000018506AC20
	// [IDTag] // 0x0000000189750E40-0x0000000189750E80
	// [XID] // 0x0000000189750E40-0x0000000189750E80
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF339B */, bool useObjectPool = false /* Metadata: 0x00AF339F */) => default; // 0x000000018506B070-0x000000018506B2C0
	// [IDTag] // 0x000000018975B280-0x000000018975B2C0
	// [XID] // 0x000000018975B280-0x000000018975B2C0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33A0 */, bool useObjectPool = false /* Metadata: 0x00AF33A4 */) => default; // 0x000000018506AD20-0x000000018506B070
}


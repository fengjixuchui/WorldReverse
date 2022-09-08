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

public static class OverflowTransformExcelConfigLoader // TypeDefIndex: 14883
{
	// Fields
	private static List<OverflowTransformExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<OverflowTransformExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<OverflowTransformExcelConfig, OverflowTransformExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<OverflowTransformExcelConfig>, List<OverflowTransformExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static uint transformFormat { /* [XID] */ /* 0x0000000189833F20-0x0000000189833F40 */ get; } // 0x0000000183112460-0x0000000183112630 
	public static List<OverflowTransformExcelConfig> dataList { /* [XID] */ /* 0x0000000189842CA0-0x0000000189842CC0 */ get; } // 0x0000000183112F50-0x0000000183113000 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018984A0D0-0x000000018984A0F0 */ get; } // 0x00000001831119B0-0x0000000183111A50 

	// Methods
	// [XID] // 0x000000018982CA30-0x000000018982CA50
	public static OverflowTransformExcelConfig GetDataByTransformId(uint transformId) => default; // 0x0000000183112050-0x0000000183112230
	// [XID] // 0x000000018983B380-0x000000018983B3A0
	public static void Register() {} // 0x0000000183113330-0x00000001831133D0
	// [XID] // 0x00000001898516B0-0x00000001898516D0
	public static void LoadData() {} // 0x0000000183112230-0x0000000183112320
	// [XID] // 0x0000000189858CE0-0x0000000189858D00
	private static void RegisterHotfixGenerated() {} // 0x0000000183111E80-0x0000000183112050
	// [XID] // 0x000000018985FF10-0x000000018985FF30
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183111A50-0x0000000183111E80
	// [IDTag] // 0x0000000189867550-0x0000000189867590
	// [XID] // 0x0000000189867550-0x0000000189867590
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001831128D0-0x00000001831129D0
	// [XID] // 0x0000000189871AB0-0x0000000189871AD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<OverflowTransformExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183113000-0x0000000183113330
	// [XID] // 0x0000000189879310-0x0000000189879330
	private static bool ParseConfigFromLine(string line, out OverflowTransformExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183112320-0x0000000183112460
	// [IDTag] // 0x0000000189880880-0x00000001898808C0
	// [XID] // 0x0000000189880880-0x00000001898808C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<OverflowTransformExcelConfig> configList) => default; // 0x0000000183112630-0x00000001831128D0
	// [IDTag] // 0x000000018988AAD0-0x000000018988AB10
	// [XID] // 0x000000018988AAD0-0x000000018988AB10
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF8DB */, bool useObjectPool = false /* Metadata: 0x00AEF8DF */) => default; // 0x00000001831129D0-0x0000000183112C20
	// [IDTag] // 0x0000000189894FB0-0x0000000189894FF0
	// [XID] // 0x0000000189894FB0-0x0000000189894FF0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8E0 */, bool useObjectPool = false /* Metadata: 0x00AEF8E4 */) => default; // 0x0000000183112C20-0x0000000183112F50
}


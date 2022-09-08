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

public static class HuntingClueTextExcelConfigLoader // TypeDefIndex: 15758
{
	// Fields
	private static Dictionary<uint, HuntingClueTextExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<HuntingClueTextExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<HuntingClueTextExcelConfig, HuntingClueTextExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<HuntingClueTextExcelConfig>, Dictionary<uint, HuntingClueTextExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, HuntingClueTextExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A33AE0-0x0000000189A33B00 */ get; } // 0x0000000183B95400-0x0000000183B954B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A42CB0-0x0000000189A42CD0 */ get; } // 0x0000000183B94250-0x0000000183B942F0 

	// Methods
	// [XID] // 0x0000000189A2C3B0-0x0000000189A2C3D0
	public static void Register() {} // 0x0000000183B957E0-0x0000000183B95880
	// [XID] // 0x0000000189A3B240-0x0000000189A3B260
	public static HuntingClueTextExcelConfig GetData(uint clueTextId) => default; // 0x0000000183B94120-0x0000000183B94250
	// [XID] // 0x0000000189A4A0E0-0x0000000189A4A100
	public static void LoadData() {} // 0x0000000183B94880-0x0000000183B94970
	// [XID] // 0x0000000189A51A90-0x0000000189A51AB0
	private static void RegisterHotfixGenerated() {} // 0x0000000183B946B0-0x0000000183B94880
	// [XID] // 0x0000000189A59280-0x0000000189A592A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183B942F0-0x0000000183B946B0
	// [IDTag] // 0x0000000189A60BE0-0x0000000189A60C20
	// [XID] // 0x0000000189A60BE0-0x0000000189A60C20
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183B94D60-0x0000000183B94E60
	// [XID] // 0x0000000189A6B690-0x0000000189A6B6B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<HuntingClueTextExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183B954B0-0x0000000183B957E0
	// [XID] // 0x0000000189A72DE0-0x0000000189A72E00
	private static bool ParseConfigFromLine(string line, out HuntingClueTextExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183B94970-0x0000000183B94AB0
	// [IDTag] // 0x0000000189A7A990-0x0000000189A7A9D0
	// [XID] // 0x0000000189A7A990-0x0000000189A7A9D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<HuntingClueTextExcelConfig> configList) => default; // 0x0000000183B94AB0-0x0000000183B94D60
	// [IDTag] // 0x0000000189A84F80-0x0000000189A84FC0
	// [XID] // 0x0000000189A84F80-0x0000000189A84FC0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF253A */, bool useObjectPool = false /* Metadata: 0x00AF253E */) => default; // 0x0000000183B951B0-0x0000000183B95400
	// [IDTag] // 0x0000000189A8F8D0-0x0000000189A8F910
	// [XID] // 0x0000000189A8F8D0-0x0000000189A8F910
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF253F */, bool useObjectPool = false /* Metadata: 0x00AF2543 */) => default; // 0x0000000183B94E60-0x0000000183B951B0
}


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

public static class ProductIdConfigLoader // TypeDefIndex: 16150
{
	// Fields
	private static Dictionary<string, ProductIdConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ProductIdConfig>> customApplyHotfixAction; // 0x08
	public static Action<ProductIdConfig, ProductIdConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ProductIdConfig>, Dictionary<string, ProductIdConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<string, ProductIdConfig> dataDict { /* [XID] */ /* 0x00000001897467E0-0x0000000189746800 */ get; } // 0x00000001840AB760-0x00000001840AB810 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189755870-0x0000000189755890 */ get; } // 0x00000001840AA5C0-0x00000001840AA660 

	// Methods
	// [XID] // 0x000000018973F460-0x000000018973F480
	public static void Register() {} // 0x00000001840ABB40-0x00000001840ABBE0
	// [XID] // 0x000000018974E170-0x000000018974E190
	public static ProductIdConfig GetData(string productId) => default; // 0x00000001840AA480-0x00000001840AA5C0
	// [XID] // 0x000000018975CB50-0x000000018975CB70
	public static void LoadData() {} // 0x00000001840AABF0-0x00000001840AACE0
	// [XID] // 0x0000000189764360-0x0000000189764380
	private static void RegisterHotfixGenerated() {} // 0x00000001840AAA20-0x00000001840AABF0
	// [XID] // 0x000000018976BC60-0x000000018976BC80
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001840AA660-0x00000001840AAA20
	// [IDTag] // 0x00000001897731C0-0x0000000189773200
	// [XID] // 0x00000001897731C0-0x0000000189773200
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001840AB0C0-0x00000001840AB1C0
	// [XID] // 0x000000018977DA80-0x000000018977DAA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ProductIdConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001840AB810-0x00000001840ABB40
	// [XID] // 0x0000000189785260-0x0000000189785280
	private static bool ParseConfigFromLine(string line, out ProductIdConfig data) {
		data = default;
		return default;
	} // 0x00000001840AACE0-0x00000001840AAE20
	// [IDTag] // 0x000000018978C790-0x000000018978C7D0
	// [XID] // 0x000000018978C790-0x000000018978C7D0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ProductIdConfig> configList) => default; // 0x00000001840AAE20-0x00000001840AB0C0
	// [IDTag] // 0x0000000189796E90-0x0000000189796ED0
	// [XID] // 0x0000000189796E90-0x0000000189796ED0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF328B */, bool useObjectPool = false /* Metadata: 0x00AF328F */) => default; // 0x00000001840AB1C0-0x00000001840AB410
	// [IDTag] // 0x00000001897A1C40-0x00000001897A1C80
	// [XID] // 0x00000001897A1C40-0x00000001897A1C80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3290 */, bool useObjectPool = false /* Metadata: 0x00AF3294 */) => default; // 0x00000001840AB410-0x00000001840AB760
}


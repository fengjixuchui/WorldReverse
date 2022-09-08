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

public static class ProductMcoinDetailConfigLoader // TypeDefIndex: 16139
{
	// Fields
	private static Dictionary<uint, ProductMcoinDetailConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ProductMcoinDetailConfig>> customApplyHotfixAction; // 0x08
	public static Action<ProductMcoinDetailConfig, ProductMcoinDetailConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ProductMcoinDetailConfig>, Dictionary<uint, ProductMcoinDetailConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ProductMcoinDetailConfig> dataDict { /* [XID] */ /* 0x00000001896B36F0-0x00000001896B3710 */ get; } // 0x00000001812169B0-0x0000000181216A60 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896C1FE0-0x00000001896C2000 */ get; } // 0x0000000181215800-0x00000001812158A0 

	// Methods
	// [XID] // 0x00000001896AC410-0x00000001896AC430
	public static void Register() {} // 0x0000000181216D90-0x0000000181216E30
	// [XID] // 0x00000001896BAE70-0x00000001896BAE90
	public static ProductMcoinDetailConfig GetData(uint configId) => default; // 0x00000001812156D0-0x0000000181215800
	// [XID] // 0x00000001896C9590-0x00000001896C95B0
	public static void LoadData() {} // 0x0000000181215E30-0x0000000181215F20
	// [XID] // 0x00000001896D0D80-0x00000001896D0DA0
	private static void RegisterHotfixGenerated() {} // 0x0000000181215C60-0x0000000181215E30
	// [XID] // 0x00000001896D83F0-0x00000001896D8410
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001812158A0-0x0000000181215C60
	// [IDTag] // 0x00000001896DFD80-0x00000001896DFDC0
	// [XID] // 0x00000001896DFD80-0x00000001896DFDC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181216060-0x0000000181216160
	// [XID] // 0x00000001896EA180-0x00000001896EA1A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ProductMcoinDetailConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181216A60-0x0000000181216D90
	// [XID] // 0x00000001896F11C0-0x00000001896F11E0
	private static bool ParseConfigFromLine(string line, out ProductMcoinDetailConfig data) {
		data = default;
		return default;
	} // 0x0000000181215F20-0x0000000181216060
	// [IDTag] // 0x00000001896F8AA0-0x00000001896F8AE0
	// [XID] // 0x00000001896F8AA0-0x00000001896F8AE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ProductMcoinDetailConfig> configList) => default; // 0x0000000181216160-0x0000000181216410
	// [IDTag] // 0x00000001897034D0-0x0000000189703510
	// [XID] // 0x00000001897034D0-0x0000000189703510
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF323B */, bool useObjectPool = false /* Metadata: 0x00AF323F */) => default; // 0x0000000181216410-0x0000000181216660
	// [IDTag] // 0x000000018970DB90-0x000000018970DBD0
	// [XID] // 0x000000018970DB90-0x000000018970DBD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3240 */, bool useObjectPool = false /* Metadata: 0x00AF3244 */) => default; // 0x0000000181216660-0x00000001812169B0
}


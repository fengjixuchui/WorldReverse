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

public static class ProductPS4PackageDetailConfigLoader // TypeDefIndex: 16146
{
	// Fields
	private static Dictionary<uint, ProductPS4PackageDetailConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ProductPS4PackageDetailConfig>> customApplyHotfixAction; // 0x08
	public static Action<ProductPS4PackageDetailConfig, ProductPS4PackageDetailConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ProductPS4PackageDetailConfig>, Dictionary<uint, ProductPS4PackageDetailConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ProductPS4PackageDetailConfig> dataDict { /* [XID] */ /* 0x0000000189B40300-0x0000000189B40320 */ get; } // 0x000000018279D0C0-0x000000018279D170 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B4F4B0-0x0000000189B4F4D0 */ get; } // 0x000000018279BF10-0x000000018279BFB0 

	// Methods
	// [XID] // 0x0000000189B38950-0x0000000189B38970
	public static void Register() {} // 0x000000018279D4A0-0x000000018279D540
	// [XID] // 0x0000000189B47BE0-0x0000000189B47C00
	public static ProductPS4PackageDetailConfig GetData(uint configId) => default; // 0x000000018279BDE0-0x000000018279BF10
	// [XID] // 0x0000000189B56DB0-0x0000000189B56DD0
	public static void LoadData() {} // 0x000000018279C540-0x000000018279C630
	// [XID] // 0x0000000189B5E660-0x0000000189B5E680
	private static void RegisterHotfixGenerated() {} // 0x000000018279C370-0x000000018279C540
	// [XID] // 0x0000000189B65BC0-0x0000000189B65BE0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018279BFB0-0x000000018279C370
	// [IDTag] // 0x0000000189B6D160-0x0000000189B6D1A0
	// [XID] // 0x0000000189B6D160-0x0000000189B6D1A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018279CA20-0x000000018279CB20
	// [XID] // 0x0000000189B77730-0x0000000189B77750
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ProductPS4PackageDetailConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018279D170-0x000000018279D4A0
	// [XID] // 0x0000000189B7EC60-0x0000000189B7EC80
	private static bool ParseConfigFromLine(string line, out ProductPS4PackageDetailConfig data) {
		data = default;
		return default;
	} // 0x000000018279C630-0x000000018279C770
	// [IDTag] // 0x0000000189B86840-0x0000000189B86880
	// [XID] // 0x0000000189B86840-0x0000000189B86880
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ProductPS4PackageDetailConfig> configList) => default; // 0x000000018279C770-0x000000018279CA20
	// [IDTag] // 0x0000000189B90C30-0x0000000189B90C70
	// [XID] // 0x0000000189B90C30-0x0000000189B90C70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF326D */, bool useObjectPool = false /* Metadata: 0x00AF3271 */) => default; // 0x000000018279CE70-0x000000018279D0C0
	// [IDTag] // 0x0000000189B9AFA0-0x0000000189B9AFE0
	// [XID] // 0x0000000189B9AFA0-0x0000000189B9AFE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3272 */, bool useObjectPool = false /* Metadata: 0x00AF3276 */) => default; // 0x000000018279CB20-0x000000018279CE70
}


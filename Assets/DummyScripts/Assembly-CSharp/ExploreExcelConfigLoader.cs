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

public static class ExploreExcelConfigLoader // TypeDefIndex: 15600
{
	// Fields
	private static Dictionary<uint, ExploreExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExploreExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExploreExcelConfig, ExploreExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExploreExcelConfig>, Dictionary<uint, ExploreExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExploreExcelConfig> dataDict { /* [XID] */ /* 0x00000001896EB900-0x00000001896EB920 */ get; } // 0x0000000180FD7210-0x0000000180FD72C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896FA6F0-0x00000001896FA710 */ get; } // 0x0000000180FD6060-0x0000000180FD6100 

	// Methods
	// [XID] // 0x00000001896E44D0-0x00000001896E44F0
	public static void Register() {} // 0x0000000180FD75F0-0x0000000180FD7690
	// [XID] // 0x00000001896F2DD0-0x00000001896F2DF0
	public static ExploreExcelConfig GetData(uint materialID) => default; // 0x0000000180FD5F30-0x0000000180FD6060
	// [XID] // 0x0000000189701D80-0x0000000189701DA0
	public static void LoadData() {} // 0x0000000180FD6690-0x0000000180FD6780
	// [XID] // 0x0000000189709620-0x0000000189709640
	private static void RegisterHotfixGenerated() {} // 0x0000000180FD64C0-0x0000000180FD6690
	// [XID] // 0x0000000189710ED0-0x0000000189710EF0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000180FD6100-0x0000000180FD64C0
	// [IDTag] // 0x0000000189718250-0x0000000189718290
	// [XID] // 0x0000000189718250-0x0000000189718290
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000180FD6B70-0x0000000180FD6C70
	// [XID] // 0x0000000189722880-0x00000001897228A0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExploreExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000180FD72C0-0x0000000180FD75F0
	// [XID] // 0x0000000189729FE0-0x000000018972A000
	private static bool ParseConfigFromLine(string line, out ExploreExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000180FD6780-0x0000000180FD68C0
	// [IDTag] // 0x0000000189731680-0x00000001897316C0
	// [XID] // 0x0000000189731680-0x00000001897316C0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExploreExcelConfig> configList) => default; // 0x0000000180FD68C0-0x0000000180FD6B70
	// [IDTag] // 0x000000018973C0C0-0x000000018973C100
	// [XID] // 0x000000018973C0C0-0x000000018973C100
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2033 */, bool useObjectPool = false /* Metadata: 0x00AF2037 */) => default; // 0x0000000180FD6FC0-0x0000000180FD7210
	// [IDTag] // 0x0000000189746920-0x0000000189746960
	// [XID] // 0x0000000189746920-0x0000000189746960
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2038 */, bool useObjectPool = false /* Metadata: 0x00AF203C */) => default; // 0x0000000180FD6C70-0x0000000180FD6FC0
}


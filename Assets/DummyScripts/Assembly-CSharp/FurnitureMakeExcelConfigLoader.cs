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

public static class FurnitureMakeExcelConfigLoader // TypeDefIndex: 15721
{
	// Fields
	private static Dictionary<uint, FurnitureMakeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<FurnitureMakeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<FurnitureMakeExcelConfig, FurnitureMakeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<FurnitureMakeExcelConfig>, Dictionary<uint, FurnitureMakeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, FurnitureMakeExcelConfig> dataDict { /* [XID] */ /* 0x00000001896B1BF0-0x00000001896B1C10 */ get; } // 0x0000000181968990-0x0000000181968A40 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896C09E0-0x00000001896C0A00 */ get; } // 0x00000001819677E0-0x0000000181967880 

	// Methods
	// [XID] // 0x00000001896AAC10-0x00000001896AAC30
	public static void Register() {} // 0x0000000181968D70-0x0000000181968E10
	// [XID] // 0x00000001896B9690-0x00000001896B96B0
	public static FurnitureMakeExcelConfig GetData(uint configID) => default; // 0x00000001819676B0-0x00000001819677E0
	// [XID] // 0x00000001896C8150-0x00000001896C8170
	public static void LoadData() {} // 0x0000000181967E10-0x0000000181967F00
	// [XID] // 0x00000001896CFA50-0x00000001896CFA70
	private static void RegisterHotfixGenerated() {} // 0x0000000181967C40-0x0000000181967E10
	// [XID] // 0x00000001896D6D00-0x00000001896D6D20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181967880-0x0000000181967C40
	// [IDTag] // 0x00000001896DE4A0-0x00000001896DE4E0
	// [XID] // 0x00000001896DE4A0-0x00000001896DE4E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181968040-0x0000000181968140
	// [XID] // 0x00000001896E88A0-0x00000001896E88C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<FurnitureMakeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181968A40-0x0000000181968D70
	// [XID] // 0x00000001896EFCE0-0x00000001896EFD00
	private static bool ParseConfigFromLine(string line, out FurnitureMakeExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181967F00-0x0000000181968040
	// [IDTag] // 0x00000001896F76D0-0x00000001896F7710
	// [XID] // 0x00000001896F76D0-0x00000001896F7710
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<FurnitureMakeExcelConfig> configList) => default; // 0x0000000181968140-0x00000001819683F0
	// [IDTag] // 0x0000000189701D00-0x0000000189701D40
	// [XID] // 0x0000000189701D00-0x0000000189701D40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2431 */, bool useObjectPool = false /* Metadata: 0x00AF2435 */) => default; // 0x00000001819683F0-0x0000000181968640
	// [IDTag] // 0x000000018970C3D0-0x000000018970C410
	// [XID] // 0x000000018970C3D0-0x000000018970C410
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2436 */, bool useObjectPool = false /* Metadata: 0x00AF243A */) => default; // 0x0000000181968640-0x0000000181968990
}


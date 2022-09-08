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

public static class MechanicusExcelConfigLoader // TypeDefIndex: 16213
{
	// Fields
	private static Dictionary<uint, MechanicusExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MechanicusExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MechanicusExcelConfig, MechanicusExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MechanicusExcelConfig>, Dictionary<uint, MechanicusExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MechanicusExcelConfig> dataDict { /* [XID] */ /* 0x0000000189663F80-0x0000000189663FA0 */ get; } // 0x0000000182AA98A0-0x0000000182AA9950 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189673420-0x0000000189673440 */ get; } // 0x0000000182AA86F0-0x0000000182AA8790 

	// Methods
	// [XID] // 0x000000018965CAC0-0x000000018965CAE0
	public static void Register() {} // 0x0000000182AA9C80-0x0000000182AA9D20
	// [XID] // 0x000000018966B660-0x000000018966B680
	public static MechanicusExcelConfig GetData(uint mechanicusID) => default; // 0x0000000182AA85C0-0x0000000182AA86F0
	// [XID] // 0x000000018967AC20-0x000000018967AC40
	public static void LoadData() {} // 0x0000000182AA8D20-0x0000000182AA8E10
	// [XID] // 0x0000000189682570-0x0000000189682590
	private static void RegisterHotfixGenerated() {} // 0x0000000182AA8B50-0x0000000182AA8D20
	// [XID] // 0x0000000189689F30-0x0000000189689F50
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182AA8790-0x0000000182AA8B50
	// [IDTag] // 0x0000000189691CB0-0x0000000189691CF0
	// [XID] // 0x0000000189691CB0-0x0000000189691CF0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182AA8F50-0x0000000182AA9050
	// [XID] // 0x000000018969C1E0-0x000000018969C200
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MechanicusExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182AA9950-0x0000000182AA9C80
	// [XID] // 0x00000001896A3640-0x00000001896A3660
	private static bool ParseConfigFromLine(string line, out MechanicusExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182AA8E10-0x0000000182AA8F50
	// [IDTag] // 0x00000001896AAB30-0x00000001896AAB70
	// [XID] // 0x00000001896AAB30-0x00000001896AAB70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MechanicusExcelConfig> configList) => default; // 0x0000000182AA9050-0x0000000182AA9300
	// [IDTag] // 0x00000001896B51B0-0x00000001896B51F0
	// [XID] // 0x00000001896B51B0-0x00000001896B51F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF347D */, bool useObjectPool = false /* Metadata: 0x00AF3481 */) => default; // 0x0000000182AA9300-0x0000000182AA9550
	// [IDTag] // 0x00000001896BEFD0-0x00000001896BF010
	// [XID] // 0x00000001896BEFD0-0x00000001896BF010
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3482 */, bool useObjectPool = false /* Metadata: 0x00AF3486 */) => default; // 0x0000000182AA9550-0x0000000182AA98A0
}


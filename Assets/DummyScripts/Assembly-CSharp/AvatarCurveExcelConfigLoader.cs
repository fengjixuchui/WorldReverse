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

public static class AvatarCurveExcelConfigLoader // TypeDefIndex: 15676
{
	// Fields
	private static Dictionary<uint, AvatarCurveExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarCurveExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarCurveExcelConfig, AvatarCurveExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarCurveExcelConfig>, Dictionary<uint, AvatarCurveExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AvatarCurveExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B3CFE0-0x0000000189B3D000 */ get; } // 0x0000000181F043A0-0x0000000181F04450 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B4C600-0x0000000189B4C620 */ get; } // 0x0000000181F031F0-0x0000000181F03290 

	// Methods
	// [XID] // 0x0000000189B35820-0x0000000189B35840
	public static void Register() {} // 0x0000000181F04780-0x0000000181F04820
	// [XID] // 0x0000000189B44E10-0x0000000189B44E30
	public static AvatarCurveExcelConfig GetData(uint level) => default; // 0x0000000181F030C0-0x0000000181F031F0
	// [XID] // 0x0000000189B53CA0-0x0000000189B53CC0
	public static void LoadData() {} // 0x0000000181F03820-0x0000000181F03910
	// [XID] // 0x0000000189B5B570-0x0000000189B5B590
	private static void RegisterHotfixGenerated() {} // 0x0000000181F03650-0x0000000181F03820
	// [XID] // 0x0000000189B62A00-0x0000000189B62A20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181F03290-0x0000000181F03650
	// [IDTag] // 0x0000000189B6A510-0x0000000189B6A550
	// [XID] // 0x0000000189B6A510-0x0000000189B6A550
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181F03D00-0x0000000181F03E00
	// [XID] // 0x0000000189B74950-0x0000000189B74970
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarCurveExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181F04450-0x0000000181F04780
	// [XID] // 0x0000000189B7BF10-0x0000000189B7BF30
	private static bool ParseConfigFromLine(string line, out AvatarCurveExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181F03910-0x0000000181F03A50
	// [IDTag] // 0x0000000189B83820-0x0000000189B83860
	// [XID] // 0x0000000189B83820-0x0000000189B83860
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarCurveExcelConfig> configList) => default; // 0x0000000181F03A50-0x0000000181F03D00
	// [IDTag] // 0x0000000189B8DAB0-0x0000000189B8DAF0
	// [XID] // 0x0000000189B8DAB0-0x0000000189B8DAF0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF22B0 */, bool useObjectPool = false /* Metadata: 0x00AF22B4 */) => default; // 0x0000000181F03E00-0x0000000181F04050
	// [IDTag] // 0x0000000189B98040-0x0000000189B98080
	// [XID] // 0x0000000189B98040-0x0000000189B98080
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22B5 */, bool useObjectPool = false /* Metadata: 0x00AF22B9 */) => default; // 0x0000000181F04050-0x0000000181F043A0
}


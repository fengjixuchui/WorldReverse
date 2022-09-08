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

public static class ExpeditionPathExcelConfigLoader // TypeDefIndex: 15084
{
	// Fields
	private static Dictionary<uint, ExpeditionPathExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ExpeditionPathExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ExpeditionPathExcelConfig, ExpeditionPathExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ExpeditionPathExcelConfig>, Dictionary<uint, ExpeditionPathExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ExpeditionPathExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A71380-0x0000000189A713A0 */ get; } // 0x0000000182945C10-0x0000000182945CC0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A80400-0x0000000189A80420 */ get; } // 0x0000000182944A60-0x0000000182944B00 

	// Methods
	// [XID] // 0x0000000189A6A050-0x0000000189A6A070
	public static void Register() {} // 0x0000000182945FF0-0x0000000182946090
	// [XID] // 0x0000000189A78FA0-0x0000000189A78FC0
	public static ExpeditionPathExcelConfig GetData(uint id) => default; // 0x0000000182944930-0x0000000182944A60
	// [XID] // 0x0000000189A88180-0x0000000189A881A0
	public static void LoadData() {} // 0x0000000182945090-0x0000000182945180
	// [XID] // 0x0000000189A8FA10-0x0000000189A8FA30
	private static void RegisterHotfixGenerated() {} // 0x0000000182944EC0-0x0000000182945090
	// [XID] // 0x0000000189A97060-0x0000000189A97080
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182944B00-0x0000000182944EC0
	// [IDTag] // 0x0000000189A9E430-0x0000000189A9E470
	// [XID] // 0x0000000189A9E430-0x0000000189A9E470
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182945570-0x0000000182945670
	// [XID] // 0x0000000189AA8A80-0x0000000189AA8AA0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ExpeditionPathExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182945CC0-0x0000000182945FF0
	// [XID] // 0x0000000189AB0660-0x0000000189AB0680
	private static bool ParseConfigFromLine(string line, out ExpeditionPathExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182945180-0x00000001829452C0
	// [IDTag] // 0x0000000189AB7CA0-0x0000000189AB7CE0
	// [XID] // 0x0000000189AB7CA0-0x0000000189AB7CE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ExpeditionPathExcelConfig> configList) => default; // 0x00000001829452C0-0x0000000182945570
	// [IDTag] // 0x0000000189AC2AE0-0x0000000189AC2B20
	// [XID] // 0x0000000189AC2AE0-0x0000000189AC2B20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF005D */, bool useObjectPool = false /* Metadata: 0x00AF0061 */) => default; // 0x0000000182945670-0x00000001829458C0
	// [IDTag] // 0x0000000189ACD1C0-0x0000000189ACD200
	// [XID] // 0x0000000189ACD1C0-0x0000000189ACD200
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0062 */, bool useObjectPool = false /* Metadata: 0x00AF0066 */) => default; // 0x00000001829458C0-0x0000000182945C10
}


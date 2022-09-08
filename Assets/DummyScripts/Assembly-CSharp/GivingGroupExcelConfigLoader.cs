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

public static class GivingGroupExcelConfigLoader // TypeDefIndex: 15674
{
	// Fields
	private static Dictionary<uint, GivingGroupExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<GivingGroupExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<GivingGroupExcelConfig, GivingGroupExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<GivingGroupExcelConfig>, Dictionary<uint, GivingGroupExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, GivingGroupExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A4A140-0x0000000189A4A160 */ get; } // 0x0000000181E1A070-0x0000000181E1A120 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A592E0-0x0000000189A59300 */ get; } // 0x0000000181E18EC0-0x0000000181E18F60 

	// Methods
	// [XID] // 0x0000000189A42CD0-0x0000000189A42CF0
	public static void Register() {} // 0x0000000181E1A450-0x0000000181E1A4F0
	// [XID] // 0x0000000189A51AD0-0x0000000189A51AF0
	public static GivingGroupExcelConfig GetData(uint Id) => default; // 0x0000000181E18D90-0x0000000181E18EC0
	// [XID] // 0x0000000189A60C20-0x0000000189A60C40
	public static void LoadData() {} // 0x0000000181E194F0-0x0000000181E195E0
	// [XID] // 0x0000000189A68930-0x0000000189A68950
	private static void RegisterHotfixGenerated() {} // 0x0000000181E19320-0x0000000181E194F0
	// [XID] // 0x0000000189A6FD40-0x0000000189A6FD60
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181E18F60-0x0000000181E19320
	// [IDTag] // 0x0000000189A77490-0x0000000189A774D0
	// [XID] // 0x0000000189A77490-0x0000000189A774D0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181E19720-0x0000000181E19820
	// [XID] // 0x0000000189A81E90-0x0000000189A81EB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<GivingGroupExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181E1A120-0x0000000181E1A450
	// [XID] // 0x0000000189A89910-0x0000000189A89930
	private static bool ParseConfigFromLine(string line, out GivingGroupExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181E195E0-0x0000000181E19720
	// [IDTag] // 0x0000000189A91010-0x0000000189A91050
	// [XID] // 0x0000000189A91010-0x0000000189A91050
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<GivingGroupExcelConfig> configList) => default; // 0x0000000181E19820-0x0000000181E19AD0
	// [IDTag] // 0x0000000189A9B720-0x0000000189A9B760
	// [XID] // 0x0000000189A9B720-0x0000000189A9B760
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF22A1 */, bool useObjectPool = false /* Metadata: 0x00AF22A5 */) => default; // 0x0000000181E19E20-0x0000000181E1A070
	// [IDTag] // 0x0000000189AA5C80-0x0000000189AA5CC0
	// [XID] // 0x0000000189AA5C80-0x0000000189AA5CC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22A6 */, bool useObjectPool = false /* Metadata: 0x00AF22AA */) => default; // 0x0000000181E19AD0-0x0000000181E19E20
}


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

public static class AsterAvatarUpExcelConfigLoader // TypeDefIndex: 14832
{
	// Fields
	private static Dictionary<uint, List<AsterAvatarUpExcelConfig>> _asterAvatarUpDic; // 0x00
	private static Dictionary<uint, AsterAvatarUpExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<AsterAvatarUpExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<AsterAvatarUpExcelConfig, AsterAvatarUpExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<AsterAvatarUpExcelConfig>, Dictionary<uint, AsterAvatarUpExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, AsterAvatarUpExcelConfig> dataDict { /* [XID] */ /* 0x000000018971B760-0x000000018971B780 */ get; } // 0x00000001841591B0-0x0000000184159280 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018972A1C0-0x000000018972A1E0 */ get; } // 0x0000000184157730-0x00000001841577D0 

	// Constructors
	static AsterAvatarUpExcelConfigLoader() {} // 0x0000000184159690-0x00000001841596F0

	// Methods
	// [XID] // 0x0000000189704E90-0x0000000189704EB0
	public static void BuildAsterUpDic() {} // 0x0000000184157DE0-0x00000001841581E0
	// [XID] // 0x000000018970C510-0x000000018970C530
	public static List<AsterAvatarUpExcelConfig> GetAsterAvatarUpConfig(uint activityId) => default; // 0x00000001841577D0-0x0000000184157900
	// [XID] // 0x0000000189713EC0-0x0000000189713EE0
	public static void Register() {} // 0x00000001841595D0-0x0000000184159690
	// [XID] // 0x0000000189722AA0-0x0000000189722AC0
	public static AsterAvatarUpExcelConfig GetData(uint id) => default; // 0x0000000184157590-0x0000000184157730
	// [XID] // 0x0000000189731840-0x0000000189731860
	public static void LoadData() {} // 0x0000000184158450-0x0000000184158580
	// [XID] // 0x0000000189739030-0x0000000189739050
	private static void RegisterHotfixGenerated() {} // 0x00000001841581E0-0x0000000184158450
	// [XID] // 0x0000000189740DE0-0x0000000189740E00
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184157900-0x0000000184157DE0
	// [IDTag] // 0x0000000189748340-0x0000000189748380
	// [XID] // 0x0000000189748340-0x0000000189748380
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184158A10-0x0000000184158B70
	// [XID] // 0x0000000189752730-0x0000000189752750
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AsterAvatarUpExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184159280-0x00000001841595D0
	// [XID] // 0x0000000189759D60-0x0000000189759D80
	private static bool ParseConfigFromLine(string line, out AsterAvatarUpExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184158580-0x00000001841586C0
	// [IDTag] // 0x0000000189761970-0x00000001897619B0
	// [XID] // 0x0000000189761970-0x00000001897619B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AsterAvatarUpExcelConfig> configList) => default; // 0x00000001841586C0-0x0000000184158A10
	// [IDTag] // 0x000000018976BF00-0x000000018976BF40
	// [XID] // 0x000000018976BF00-0x000000018976BF40
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF6ED */, bool useObjectPool = false /* Metadata: 0x00AEF6F1 */) => default; // 0x0000000184158F00-0x00000001841591B0
	// [IDTag] // 0x0000000189776620-0x0000000189776660
	// [XID] // 0x0000000189776620-0x0000000189776660
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6F2 */, bool useObjectPool = false /* Metadata: 0x00AEF6F6 */) => default; // 0x0000000184158B70-0x0000000184158F00
}


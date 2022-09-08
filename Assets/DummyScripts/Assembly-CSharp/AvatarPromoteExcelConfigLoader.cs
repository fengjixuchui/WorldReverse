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

public static class AvatarPromoteExcelConfigLoader // TypeDefIndex: 14835
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, AvatarPromoteExcelConfig>> _avatarPromoteDic; // 0x00
	private static List<AvatarPromoteExcelConfig> _dataList; // 0x08
	public static Action<List<DataHotfixMeta>, List<AvatarPromoteExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<AvatarPromoteExcelConfig, AvatarPromoteExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<AvatarPromoteExcelConfig>, List<AvatarPromoteExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static List<AvatarPromoteExcelConfig> dataList { /* [XID] */ /* 0x0000000189B00870-0x0000000189B00890 */ get; } // 0x0000000181F591D0-0x0000000181F592A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B07F70-0x0000000189B07F90 */ get; } // 0x0000000181F576A0-0x0000000181F57740 

	// Constructors
	static AvatarPromoteExcelConfigLoader() {} // 0x0000000181F596B0-0x0000000181F59710

	// Methods
	// [XID] // 0x0000000189AE9F50-0x0000000189AE9F70
	public static void BuildAvatarPromoteDic() {} // 0x0000000181F58DA0-0x0000000181F591D0
	// [XID] // 0x0000000189AF1C30-0x0000000189AF1C50
	public static AvatarPromoteExcelConfig GetAvatarPromoteConfig(uint promoteLevel, uint promoteId) => default; // 0x0000000181F58C30-0x0000000181F58DA0
	// [XID] // 0x0000000189AF9450-0x0000000189AF9470
	public static void Register() {} // 0x0000000181F595F0-0x0000000181F596B0
	// [XID] // 0x0000000189B0F890-0x0000000189B0F8B0
	public static void LoadData() {} // 0x0000000181F57F00-0x0000000181F58030
	// [XID] // 0x0000000189B16A90-0x0000000189B16AB0
	private static void RegisterHotfixGenerated() {} // 0x0000000181F57C90-0x0000000181F57F00
	// [XID] // 0x0000000189B1E190-0x0000000189B1E1B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181F57740-0x0000000181F57C90
	// [IDTag] // 0x0000000189B25A20-0x0000000189B25A60
	// [XID] // 0x0000000189B25A20-0x0000000189B25A60
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181F58170-0x0000000181F582D0
	// [XID] // 0x0000000189B2FC10-0x0000000189B2FC30
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarPromoteExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181F592A0-0x0000000181F595F0
	// [XID] // 0x0000000189B375D0-0x0000000189B375F0
	private static bool ParseConfigFromLine(string line, out AvatarPromoteExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181F58030-0x0000000181F58170
	// [IDTag] // 0x0000000189B3EE80-0x0000000189B3EEC0
	// [XID] // 0x0000000189B3EE80-0x0000000189B3EEC0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarPromoteExcelConfig> configList) => default; // 0x0000000181F582D0-0x0000000181F58600
	// [IDTag] // 0x0000000189B49980-0x0000000189B499C0
	// [XID] // 0x0000000189B49980-0x0000000189B499C0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF706 */, bool useObjectPool = false /* Metadata: 0x00AEF70A */) => default; // 0x0000000181F58980-0x0000000181F58C30
	// [IDTag] // 0x0000000189B53F00-0x0000000189B53F40
	// [XID] // 0x0000000189B53F00-0x0000000189B53F40
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF70B */, bool useObjectPool = false /* Metadata: 0x00AEF70F */) => default; // 0x0000000181F58600-0x0000000181F58980
}


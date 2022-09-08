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

public static class AvatarHeroEntityExcelConfigLoader // TypeDefIndex: 15215
{
	// Fields
	private static Dictionary<uint, AvatarHeroEntityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarHeroEntityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarHeroEntityExcelConfig, AvatarHeroEntityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarHeroEntityExcelConfig>, Dictionary<uint, AvatarHeroEntityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AvatarHeroEntityExcelConfig> dataDict { /* [XID] */ /* 0x00000001899D1E40-0x00000001899D1E60 */ get; } // 0x0000000182B2F0C0-0x0000000182B2F170 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899E0A40-0x00000001899E0A60 */ get; } // 0x0000000182B2DF10-0x0000000182B2DFB0 

	// Methods
	// [XID] // 0x00000001899CA6A0-0x00000001899CA6C0
	public static void Register() {} // 0x0000000182B2F4A0-0x0000000182B2F540
	// [XID] // 0x00000001899D9350-0x00000001899D9370
	public static AvatarHeroEntityExcelConfig GetData(uint avatarId) => default; // 0x0000000182B2DDE0-0x0000000182B2DF10
	// [XID] // 0x00000001899E85A0-0x00000001899E85C0
	public static void LoadData() {} // 0x0000000182B2E540-0x0000000182B2E630
	// [XID] // 0x00000001899EFBD0-0x00000001899EFBF0
	private static void RegisterHotfixGenerated() {} // 0x0000000182B2E370-0x0000000182B2E540
	// [XID] // 0x00000001899F72B0-0x00000001899F72D0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182B2DFB0-0x0000000182B2E370
	// [IDTag] // 0x00000001899FE9F0-0x00000001899FEA30
	// [XID] // 0x00000001899FE9F0-0x00000001899FEA30
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182B2EA20-0x0000000182B2EB20
	// [XID] // 0x0000000189A08F90-0x0000000189A08FB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarHeroEntityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182B2F170-0x0000000182B2F4A0
	// [XID] // 0x0000000189A104B0-0x0000000189A104D0
	private static bool ParseConfigFromLine(string line, out AvatarHeroEntityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182B2E630-0x0000000182B2E770
	// [IDTag] // 0x0000000189A17A90-0x0000000189A17AD0
	// [XID] // 0x0000000189A17A90-0x0000000189A17AD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarHeroEntityExcelConfig> configList) => default; // 0x0000000182B2E770-0x0000000182B2EA20
	// [IDTag] // 0x0000000189A221B0-0x0000000189A221F0
	// [XID] // 0x0000000189A221B0-0x0000000189A221F0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF040C */, bool useObjectPool = false /* Metadata: 0x00AF0410 */) => default; // 0x0000000182B2EE70-0x0000000182B2F0C0
	// [IDTag] // 0x0000000189A2C450-0x0000000189A2C490
	// [XID] // 0x0000000189A2C450-0x0000000189A2C490
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0411 */, bool useObjectPool = false /* Metadata: 0x00AF0415 */) => default; // 0x0000000182B2EB20-0x0000000182B2EE70
}


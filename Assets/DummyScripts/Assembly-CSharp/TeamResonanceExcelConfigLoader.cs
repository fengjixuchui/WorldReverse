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

public static class TeamResonanceExcelConfigLoader // TypeDefIndex: 16180
{
	// Fields
	private static Dictionary<uint, TeamResonanceExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<TeamResonanceExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<TeamResonanceExcelConfig, TeamResonanceExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TeamResonanceExcelConfig>, Dictionary<uint, TeamResonanceExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, TeamResonanceExcelConfig> dataDict { /* [XID] */ /* 0x0000000189BCDCA0-0x0000000189BCDCC0 */ get; } // 0x0000000184EBA300-0x0000000184EBA3B0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189BDCD40-0x0000000189BDCD60 */ get; } // 0x0000000184EB9150-0x0000000184EB91F0 

	// Methods
	// [XID] // 0x0000000189BC6120-0x0000000189BC6140
	public static void Register() {} // 0x0000000184EBA6E0-0x0000000184EBA780
	// [XID] // 0x0000000189BD5170-0x0000000189BD5190
	public static TeamResonanceExcelConfig GetData(uint teamResonanceId) => default; // 0x0000000184EB9020-0x0000000184EB9150
	// [XID] // 0x00000001895E9470-0x00000001895E9490
	public static void LoadData() {} // 0x0000000184EB9780-0x0000000184EB9870
	// [XID] // 0x00000001895F0CE0-0x00000001895F0D00
	private static void RegisterHotfixGenerated() {} // 0x0000000184EB95B0-0x0000000184EB9780
	// [XID] // 0x00000001895F8690-0x00000001895F86B0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184EB91F0-0x0000000184EB95B0
	// [IDTag] // 0x00000001895FFB10-0x00000001895FFB50
	// [XID] // 0x00000001895FFB10-0x00000001895FFB50
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184EB9C60-0x0000000184EB9D60
	// [XID] // 0x000000018960A630-0x000000018960A650
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TeamResonanceExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184EBA3B0-0x0000000184EBA6E0
	// [XID] // 0x0000000189611DA0-0x0000000189611DC0
	private static bool ParseConfigFromLine(string line, out TeamResonanceExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184EB9870-0x0000000184EB99B0
	// [IDTag] // 0x00000001896196A0-0x00000001896196E0
	// [XID] // 0x00000001896196A0-0x00000001896196E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TeamResonanceExcelConfig> configList) => default; // 0x0000000184EB99B0-0x0000000184EB9C60
	// [IDTag] // 0x00000001896239C0-0x0000000189623A00
	// [XID] // 0x00000001896239C0-0x0000000189623A00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF337C */, bool useObjectPool = false /* Metadata: 0x00AF3380 */) => default; // 0x0000000184EB9D60-0x0000000184EB9FB0
	// [IDTag] // 0x000000018962E250-0x000000018962E290
	// [XID] // 0x000000018962E250-0x000000018962E290
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3381 */, bool useObjectPool = false /* Metadata: 0x00AF3385 */) => default; // 0x0000000184EB9FB0-0x0000000184EBA300
}


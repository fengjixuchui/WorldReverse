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

public static class AvatarExcelConfigLoader // TypeDefIndex: 15208
{
	// Fields
	private static Dictionary<uint, AvatarExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<AvatarExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<AvatarExcelConfig, AvatarExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<AvatarExcelConfig>, Dictionary<uint, AvatarExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, AvatarExcelConfig> dataDict { /* [XID] */ /* 0x000000018960D720-0x000000018960D740 */ get; } // 0x00000001820F0290-0x00000001820F0340 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018961C6C0-0x000000018961C6E0 */ get; } // 0x00000001820EF0E0-0x00000001820EF180 

	// Methods
	// [XID] // 0x0000000189605ED0-0x0000000189605EF0
	public static void Register() {} // 0x00000001820F0670-0x00000001820F0710
	// [XID] // 0x000000018992A260-0x000000018992A280
	public static AvatarExcelConfig GetData(uint id) => default; // 0x00000001820EEFB0-0x00000001820EF0E0
	// [XID] // 0x0000000189623B60-0x0000000189623B80
	public static void LoadData() {} // 0x00000001820EF710-0x00000001820EF800
	// [XID] // 0x000000018962B380-0x000000018962B3A0
	private static void RegisterHotfixGenerated() {} // 0x00000001820EF540-0x00000001820EF710
	// [XID] // 0x0000000189632B40-0x0000000189632B60
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001820EF180-0x00000001820EF540
	// [IDTag] // 0x000000018963A5B0-0x000000018963A5F0
	// [XID] // 0x000000018963A5B0-0x000000018963A5F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001820EF940-0x00000001820EFA40
	// [XID] // 0x0000000189644C30-0x0000000189644C50
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<AvatarExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001820F0340-0x00000001820F0670
	// [XID] // 0x000000018964C690-0x000000018964C6B0
	private static bool ParseConfigFromLine(string line, out AvatarExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001820EF800-0x00000001820EF940
	// [IDTag] // 0x0000000189653BA0-0x0000000189653BE0
	// [XID] // 0x0000000189653BA0-0x0000000189653BE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<AvatarExcelConfig> configList) => default; // 0x00000001820EFA40-0x00000001820EFCF0
	// [IDTag] // 0x000000018965E350-0x000000018965E390
	// [XID] // 0x000000018965E350-0x000000018965E390
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF03DA */, bool useObjectPool = false /* Metadata: 0x00AF03DE */) => default; // 0x00000001820F0040-0x00000001820F0290
	// [IDTag] // 0x0000000189668C80-0x0000000189668CC0
	// [XID] // 0x0000000189668C80-0x0000000189668CC0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03DF */, bool useObjectPool = false /* Metadata: 0x00AF03E3 */) => default; // 0x00000001820EFCF0-0x00000001820F0040
}


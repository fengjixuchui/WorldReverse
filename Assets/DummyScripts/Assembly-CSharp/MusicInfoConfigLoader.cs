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

public static class MusicInfoConfigLoader // TypeDefIndex: 15148
{
	// Fields
	private static Dictionary<uint, MusicInfoConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MusicInfoConfig>> customApplyHotfixAction; // 0x08
	public static Action<MusicInfoConfig, MusicInfoConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MusicInfoConfig>, Dictionary<uint, MusicInfoConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MusicInfoConfig> dataDict { /* [XID] */ /* 0x0000000189870100-0x0000000189870120 */ get; } // 0x000000018182B1C0-0x000000018182B270 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018987F000-0x000000018987F020 */ get; } // 0x000000018182A010-0x000000018182A0B0 

	// Methods
	// [XID] // 0x0000000189868D30-0x0000000189868D50
	public static void Register() {} // 0x000000018182B5A0-0x000000018182B640
	// [XID] // 0x0000000189877770-0x0000000189877790
	public static MusicInfoConfig GetData(uint musicID) => default; // 0x0000000181829EE0-0x000000018182A010
	// [XID] // 0x00000001898865C0-0x00000001898865E0
	public static void LoadData() {} // 0x000000018182A640-0x000000018182A730
	// [XID] // 0x000000018988D7A0-0x000000018988D7C0
	private static void RegisterHotfixGenerated() {} // 0x000000018182A470-0x000000018182A640
	// [XID] // 0x0000000189894EB0-0x0000000189894ED0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018182A0B0-0x000000018182A470
	// [IDTag] // 0x000000018989C5C0-0x000000018989C600
	// [XID] // 0x000000018989C5C0-0x000000018989C600
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018182A870-0x000000018182A970
	// [XID] // 0x00000001898A6CC0-0x00000001898A6CE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MusicInfoConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018182B270-0x000000018182B5A0
	// [XID] // 0x00000001898AE4F0-0x00000001898AE510
	private static bool ParseConfigFromLine(string line, out MusicInfoConfig data) {
		data = default;
		return default;
	} // 0x000000018182A730-0x000000018182A870
	// [IDTag] // 0x00000001898B59B0-0x00000001898B59F0
	// [XID] // 0x00000001898B59B0-0x00000001898B59F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MusicInfoConfig> configList) => default; // 0x000000018182A970-0x000000018182AC20
	// [IDTag] // 0x00000001898C0240-0x00000001898C0280
	// [XID] // 0x00000001898C0240-0x00000001898C0280
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0230 */, bool useObjectPool = false /* Metadata: 0x00AF0234 */) => default; // 0x000000018182AC20-0x000000018182AE70
	// [IDTag] // 0x00000001898CABE0-0x00000001898CAC20
	// [XID] // 0x00000001898CABE0-0x00000001898CAC20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0235 */, bool useObjectPool = false /* Metadata: 0x00AF0239 */) => default; // 0x000000018182AE70-0x000000018182B1C0
}


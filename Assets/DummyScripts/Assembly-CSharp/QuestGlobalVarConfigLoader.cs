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

public static class QuestGlobalVarConfigLoader // TypeDefIndex: 15993
{
	// Fields
	private static Dictionary<uint, QuestGlobalVarConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<QuestGlobalVarConfig>> customApplyHotfixAction; // 0x08
	public static Action<QuestGlobalVarConfig, QuestGlobalVarConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<QuestGlobalVarConfig>, Dictionary<uint, QuestGlobalVarConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, QuestGlobalVarConfig> dataDict { /* [XID] */ /* 0x0000000189880640-0x0000000189880660 */ get; } // 0x00000001812BBBE0-0x00000001812BBC90 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018988EF00-0x000000018988EF20 */ get; } // 0x00000001812BAA30-0x00000001812BAAD0 

	// Methods
	// [XID] // 0x0000000189879030-0x0000000189879050
	public static void Register() {} // 0x00000001812BBFC0-0x00000001812BC060
	// [XID] // 0x0000000189B4B260-0x0000000189B4B280
	public static QuestGlobalVarConfig GetData(uint id) => default; // 0x00000001812BA900-0x00000001812BAA30
	// [XID] // 0x0000000189896460-0x0000000189896480
	public static void LoadData() {} // 0x00000001812BB060-0x00000001812BB150
	// [XID] // 0x000000018989DA60-0x000000018989DA80
	private static void RegisterHotfixGenerated() {} // 0x00000001812BAE90-0x00000001812BB060
	// [XID] // 0x00000001898A5320-0x00000001898A5340
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001812BAAD0-0x00000001812BAE90
	// [IDTag] // 0x00000001898AC900-0x00000001898AC940
	// [XID] // 0x00000001898AC900-0x00000001898AC940
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001812BB290-0x00000001812BB390
	// [XID] // 0x00000001898B6FB0-0x00000001898B6FD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<QuestGlobalVarConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001812BBC90-0x00000001812BBFC0
	// [XID] // 0x00000001898BE720-0x00000001898BE740
	private static bool ParseConfigFromLine(string line, out QuestGlobalVarConfig data) {
		data = default;
		return default;
	} // 0x00000001812BB150-0x00000001812BB290
	// [IDTag] // 0x00000001898C5ED0-0x00000001898C5F10
	// [XID] // 0x00000001898C5ED0-0x00000001898C5F10
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<QuestGlobalVarConfig> configList) => default; // 0x00000001812BB390-0x00000001812BB640
	// [IDTag] // 0x00000001898D0960-0x00000001898D09A0
	// [XID] // 0x00000001898D0960-0x00000001898D09A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2D33 */, bool useObjectPool = false /* Metadata: 0x00AF2D37 */) => default; // 0x00000001812BB640-0x00000001812BB890
	// [IDTag] // 0x00000001898DAF60-0x00000001898DAFA0
	// [XID] // 0x00000001898DAF60-0x00000001898DAFA0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D38 */, bool useObjectPool = false /* Metadata: 0x00AF2D3C */) => default; // 0x00000001812BB890-0x00000001812BBBE0
}


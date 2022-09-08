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

public static class TransPointRewardConfigLoader // TypeDefIndex: 16305
{
	// Fields
	private static List<TransPointRewardConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<TransPointRewardConfig>> customApplyHotfixAction; // 0x08
	public static Action<TransPointRewardConfig, TransPointRewardConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<TransPointRewardConfig>, List<TransPointRewardConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<TransPointRewardConfig> dataList { /* [XID] */ /* 0x0000000189AEB750-0x0000000189AEB770 */ get; } // 0x00000001849A1EF0-0x00000001849A1FA0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189AF3090-0x0000000189AF30B0 */ get; } // 0x00000001849A0D00-0x00000001849A0DA0 

	// Methods
	// [XID] // 0x0000000189AE3ED0-0x0000000189AE3EF0
	public static void Register() {} // 0x00000001849A22D0-0x00000001849A2370
	// [XID] // 0x0000000189AFA9A0-0x0000000189AFA9C0
	public static void LoadData() {} // 0x00000001849A13A0-0x00000001849A1490
	// [XID] // 0x0000000189B01F30-0x0000000189B01F50
	private static void RegisterHotfixGenerated() {} // 0x00000001849A11D0-0x00000001849A13A0
	// [XID] // 0x0000000189B09470-0x0000000189B09490
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001849A0DA0-0x00000001849A11D0
	// [IDTag] // 0x0000000189B10F30-0x0000000189B10F70
	// [XID] // 0x0000000189B10F30-0x0000000189B10F70
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001849A15D0-0x00000001849A16D0
	// [XID] // 0x0000000189B1B100-0x0000000189B1B120
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TransPointRewardConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001849A1FA0-0x00000001849A22D0
	// [XID] // 0x0000000189B22830-0x0000000189B22850
	private static bool ParseConfigFromLine(string line, out TransPointRewardConfig data) {
		data = default;
		return default;
	} // 0x00000001849A1490-0x00000001849A15D0
	// [IDTag] // 0x0000000189B29DC0-0x0000000189B29E00
	// [XID] // 0x0000000189B29DC0-0x0000000189B29E00
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TransPointRewardConfig> configList) => default; // 0x00000001849A16D0-0x00000001849A1970
	// [IDTag] // 0x0000000189B340A0-0x0000000189B340E0
	// [XID] // 0x0000000189B340A0-0x0000000189B340E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF371A */, bool useObjectPool = false /* Metadata: 0x00AF371E */) => default; // 0x00000001849A1CA0-0x00000001849A1EF0
	// [IDTag] // 0x0000000189B3EAE0-0x0000000189B3EB20
	// [XID] // 0x0000000189B3EAE0-0x0000000189B3EB20
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF371F */, bool useObjectPool = false /* Metadata: 0x00AF3723 */) => default; // 0x00000001849A1970-0x00000001849A1CA0
}


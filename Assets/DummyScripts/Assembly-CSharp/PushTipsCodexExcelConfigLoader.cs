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

public static class PushTipsCodexExcelConfigLoader // TypeDefIndex: 15320
{
	// Fields
	private static Dictionary<uint, PushTipsCodexExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PushTipsCodexExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PushTipsCodexExcelConfig, PushTipsCodexExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PushTipsCodexExcelConfig>, Dictionary<uint, PushTipsCodexExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PushTipsCodexExcelConfig> dataDict { /* [XID] */ /* 0x000000018968CFC0-0x000000018968CFE0 */ get; } // 0x00000001836EA6F0-0x00000001836EA7A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018969C340-0x000000018969C360 */ get; } // 0x00000001836E9540-0x00000001836E95E0 

	// Methods
	// [XID] // 0x00000001896855C0-0x00000001896855E0
	public static void Register() {} // 0x00000001836EAAD0-0x00000001836EAB70
	// [XID] // 0x0000000189694B80-0x0000000189694BA0
	public static PushTipsCodexExcelConfig GetData(uint Id) => default; // 0x00000001836E9410-0x00000001836E9540
	// [XID] // 0x00000001896A37E0-0x00000001896A3800
	public static void LoadData() {} // 0x00000001836E9B70-0x00000001836E9C60
	// [XID] // 0x00000001896AAC90-0x00000001896AACB0
	private static void RegisterHotfixGenerated() {} // 0x00000001836E99A0-0x00000001836E9B70
	// [XID] // 0x00000001896B1C70-0x00000001896B1C90
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001836E95E0-0x00000001836E99A0
	// [IDTag] // 0x00000001896B9770-0x00000001896B97B0
	// [XID] // 0x00000001896B9770-0x00000001896B97B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001836EA050-0x00000001836EA150
	// [XID] // 0x00000001896C3AC0-0x00000001896C3AE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PushTipsCodexExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001836EA7A0-0x00000001836EAAD0
	// [XID] // 0x00000001896CAFB0-0x00000001896CAFD0
	private static bool ParseConfigFromLine(string line, out PushTipsCodexExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001836E9C60-0x00000001836E9DA0
	// [IDTag] // 0x00000001896D2520-0x00000001896D2560
	// [XID] // 0x00000001896D2520-0x00000001896D2560
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PushTipsCodexExcelConfig> configList) => default; // 0x00000001836E9DA0-0x00000001836EA050
	// [IDTag] // 0x00000001896DCBC0-0x00000001896DCC00
	// [XID] // 0x00000001896DCBC0-0x00000001896DCC00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0772 */, bool useObjectPool = false /* Metadata: 0x00AF0776 */) => default; // 0x00000001836EA150-0x00000001836EA3A0
	// [IDTag] // 0x00000001896E7160-0x00000001896E71A0
	// [XID] // 0x00000001896E7160-0x00000001896E71A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0777 */, bool useObjectPool = false /* Metadata: 0x00AF077B */) => default; // 0x00000001836EA3A0-0x00000001836EA6F0
}


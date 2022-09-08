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

public static class MailExcelConfigLoader // TypeDefIndex: 15796
{
	// Fields
	private static Dictionary<uint, MailExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MailExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MailExcelConfig, MailExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MailExcelConfig>, Dictionary<uint, MailExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MailExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B497E0-0x0000000189B49800 */ get; } // 0x0000000184AA6930-0x0000000184AA69E0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B58630-0x0000000189B58650 */ get; } // 0x0000000184AA5780-0x0000000184AA5820 

	// Methods
	// [XID] // 0x0000000189B41E30-0x0000000189B41E50
	public static void Register() {} // 0x0000000184AA6D10-0x0000000184AA6DB0
	// [XID] // 0x0000000189B50E60-0x0000000189B50E80
	public static MailExcelConfig GetData(uint id) => default; // 0x0000000184AA5650-0x0000000184AA5780
	// [XID] // 0x0000000189B60020-0x0000000189B60040
	public static void LoadData() {} // 0x0000000184AA5DB0-0x0000000184AA5EA0
	// [XID] // 0x0000000189B676E0-0x0000000189B67700
	private static void RegisterHotfixGenerated() {} // 0x0000000184AA5BE0-0x0000000184AA5DB0
	// [XID] // 0x0000000189B6E900-0x0000000189B6E920
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184AA5820-0x0000000184AA5BE0
	// [IDTag] // 0x0000000189B761B0-0x0000000189B761F0
	// [XID] // 0x0000000189B761B0-0x0000000189B761F0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184AA6290-0x0000000184AA6390
	// [XID] // 0x0000000189B80510-0x0000000189B80530
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MailExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184AA69E0-0x0000000184AA6D10
	// [XID] // 0x0000000189B880A0-0x0000000189B880C0
	private static bool ParseConfigFromLine(string line, out MailExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184AA5EA0-0x0000000184AA5FE0
	// [IDTag] // 0x0000000189B8F2B0-0x0000000189B8F2F0
	// [XID] // 0x0000000189B8F2B0-0x0000000189B8F2F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MailExcelConfig> configList) => default; // 0x0000000184AA5FE0-0x0000000184AA6290
	// [IDTag] // 0x0000000189B99720-0x0000000189B99760
	// [XID] // 0x0000000189B99720-0x0000000189B99760
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2643 */, bool useObjectPool = false /* Metadata: 0x00AF2647 */) => default; // 0x0000000184AA66E0-0x0000000184AA6930
	// [IDTag] // 0x0000000189BA3D90-0x0000000189BA3DD0
	// [XID] // 0x0000000189BA3D90-0x0000000189BA3DD0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2648 */, bool useObjectPool = false /* Metadata: 0x00AF264C */) => default; // 0x0000000184AA6390-0x0000000184AA66E0
}


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

public static class PersonalLineActivityExcelConfigLoader // TypeDefIndex: 15943
{
	// Fields
	private static Dictionary<uint, PersonalLineActivityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PersonalLineActivityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PersonalLineActivityExcelConfig, PersonalLineActivityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PersonalLineActivityExcelConfig>, Dictionary<uint, PersonalLineActivityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PersonalLineActivityExcelConfig> dataDict { /* [XID] */ /* 0x0000000189756F60-0x0000000189756F80 */ get; } // 0x0000000183EBA210-0x0000000183EBA2C0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189765B90-0x0000000189765BB0 */ get; } // 0x0000000183EB9060-0x0000000183EB9100 

	// Methods
	// [XID] // 0x000000018974F970-0x000000018974F990
	public static void Register() {} // 0x0000000183EBA5F0-0x0000000183EBA690
	// [XID] // 0x000000018975E530-0x000000018975E550
	public static PersonalLineActivityExcelConfig GetData(uint id) => default; // 0x0000000183EB8F30-0x0000000183EB9060
	// [XID] // 0x000000018976D300-0x000000018976D320
	public static void LoadData() {} // 0x0000000183EB9690-0x0000000183EB9780
	// [XID] // 0x0000000189774750-0x0000000189774770
	private static void RegisterHotfixGenerated() {} // 0x0000000183EB94C0-0x0000000183EB9690
	// [XID] // 0x000000018977C180-0x000000018977C1A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183EB9100-0x0000000183EB94C0
	// [IDTag] // 0x0000000189783B50-0x0000000189783B90
	// [XID] // 0x0000000189783B50-0x0000000189783B90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183EB98C0-0x0000000183EB99C0
	// [XID] // 0x000000018978DFD0-0x000000018978DFF0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PersonalLineActivityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183EBA2C0-0x0000000183EBA5F0
	// [XID] // 0x00000001897956C0-0x00000001897956E0
	private static bool ParseConfigFromLine(string line, out PersonalLineActivityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183EB9780-0x0000000183EB98C0
	// [IDTag] // 0x000000018979DB30-0x000000018979DB70
	// [XID] // 0x000000018979DB30-0x000000018979DB70
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PersonalLineActivityExcelConfig> configList) => default; // 0x0000000183EB99C0-0x0000000183EB9C70
	// [IDTag] // 0x00000001897A7AE0-0x00000001897A7B20
	// [XID] // 0x00000001897A7AE0-0x00000001897A7B20
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2BCF */, bool useObjectPool = false /* Metadata: 0x00AF2BD3 */) => default; // 0x0000000183EB9FC0-0x0000000183EBA210
	// [IDTag] // 0x00000001897B25D0-0x00000001897B2610
	// [XID] // 0x00000001897B25D0-0x00000001897B2610
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BD4 */, bool useObjectPool = false /* Metadata: 0x00AF2BD8 */) => default; // 0x0000000183EB9C70-0x0000000183EB9FC0
}


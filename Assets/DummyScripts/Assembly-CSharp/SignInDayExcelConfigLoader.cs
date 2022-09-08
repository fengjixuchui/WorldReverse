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

public static class SignInDayExcelConfigLoader // TypeDefIndex: 16162
{
	// Fields
	private static List<SignInDayExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<SignInDayExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<SignInDayExcelConfig, SignInDayExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SignInDayExcelConfig>, List<SignInDayExcelConfig>, string, bool> customValidateFunc; // 0x20
	public static Dictionary<uint, List<SignInDayExcelConfig>> signInDataDic; // 0x28

	// Properties
	public static List<SignInDayExcelConfig> dataList { /* [XID] */ /* 0x0000000189A83620-0x0000000189A83640 */ get; } // 0x0000000182EE6F50-0x0000000182EE7020 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A8AEE0-0x0000000189A8AF00 */ get; } // 0x0000000182EE59D0-0x0000000182EE5A70 

	// Constructors
	static SignInDayExcelConfigLoader() {} // 0x0000000182EE7430-0x0000000182EE7490

	// Methods
	// [XID] // 0x0000000189A7BC80-0x0000000189A7BCA0
	public static void Register() {} // 0x0000000182EE7370-0x0000000182EE7430
	// [XID] // 0x0000000189A92610-0x0000000189A92630
	public static void LoadData() {} // 0x0000000182EE6230-0x0000000182EE6360
	// [XID] // 0x0000000189A9A120-0x0000000189A9A140
	private static void RegisterHotfixGenerated() {} // 0x0000000182EE5FC0-0x0000000182EE6230
	// [XID] // 0x0000000189AA1080-0x0000000189AA10A0
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182EE5A70-0x0000000182EE5FC0
	// [IDTag] // 0x0000000189AA8820-0x0000000189AA8860
	// [XID] // 0x0000000189AA8820-0x0000000189AA8860
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182EE67C0-0x0000000182EE6920
	// [XID] // 0x0000000189AB3420-0x0000000189AB3440
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SignInDayExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182EE7020-0x0000000182EE7370
	// [XID] // 0x0000000189ABB130-0x0000000189ABB150
	private static bool ParseConfigFromLine(string line, out SignInDayExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182EE6360-0x0000000182EE64A0
	// [IDTag] // 0x0000000189AC2920-0x0000000189AC2960
	// [XID] // 0x0000000189AC2920-0x0000000189AC2960
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SignInDayExcelConfig> configList) => default; // 0x0000000182EE64A0-0x0000000182EE67C0
	// [IDTag] // 0x0000000189ACCF40-0x0000000189ACCF80
	// [XID] // 0x0000000189ACCF40-0x0000000189ACCF80
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF32EF */, bool useObjectPool = false /* Metadata: 0x00AF32F3 */) => default; // 0x0000000182EE6920-0x0000000182EE6BD0
	// [IDTag] // 0x0000000189AD7CA0-0x0000000189AD7CE0
	// [XID] // 0x0000000189AD7CA0-0x0000000189AD7CE0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF32F4 */, bool useObjectPool = false /* Metadata: 0x00AF32F8 */) => default; // 0x0000000182EE6BD0-0x0000000182EE6F50
	// [XID] // 0x0000000189AE23E0-0x0000000189AE2400
	public static void LoadAndBuildSignInDayDic() {} // 0x0000000182EE5610-0x0000000182EE59D0
}


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

public static class SignInPeriodExcelConfigLoader // TypeDefIndex: 16164
{
	// Fields
	private static List<SignInPeriodExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<SignInPeriodExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<SignInPeriodExcelConfig, SignInPeriodExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SignInPeriodExcelConfig>, List<SignInPeriodExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<SignInPeriodExcelConfig> dataList { /* [XID] */ /* 0x0000000189B85350-0x0000000189B85370 */ get; } // 0x000000018593C270-0x000000018593C320 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B8C160-0x0000000189B8C180 */ get; } // 0x000000018593AEC0-0x000000018593AF60 

	// Methods
	// [XID] // 0x0000000189B7D600-0x0000000189B7D620
	public static void Register() {} // 0x000000018593C650-0x000000018593C6F0
	// [XID] // 0x0000000189B939F0-0x0000000189B93A10
	public static void LoadData() {} // 0x000000018593B560-0x000000018593B650
	// [XID] // 0x0000000189B9AF80-0x0000000189B9AFA0
	private static void RegisterHotfixGenerated() {} // 0x000000018593B390-0x000000018593B560
	// [XID] // 0x0000000189BA27D0-0x0000000189BA27F0
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018593AF60-0x000000018593B390
	// [IDTag] // 0x0000000189BA9BC0-0x0000000189BA9C00
	// [XID] // 0x0000000189BA9BC0-0x0000000189BA9C00
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018593B790-0x000000018593B890
	// [XID] // 0x0000000189BB3F90-0x0000000189BB3FB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SignInPeriodExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018593C320-0x000000018593C650
	// [XID] // 0x0000000189BBB670-0x0000000189BBB690
	private static bool ParseConfigFromLine(string line, out SignInPeriodExcelConfig data) {
		data = default;
		return default;
	} // 0x000000018593B650-0x000000018593B790
	// [IDTag] // 0x0000000189BC3470-0x0000000189BC34B0
	// [XID] // 0x0000000189BC3470-0x0000000189BC34B0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SignInPeriodExcelConfig> configList) => default; // 0x000000018593B890-0x000000018593BB30
	// [IDTag] // 0x0000000189BCDCC0-0x0000000189BCDD00
	// [XID] // 0x0000000189BCDCC0-0x0000000189BCDD00
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF32FE */, bool useObjectPool = false /* Metadata: 0x00AF3302 */) => default; // 0x000000018593BE60-0x000000018593C0B0
	// [IDTag] // 0x0000000189BD8030-0x0000000189BD8070
	// [XID] // 0x0000000189BD8030-0x0000000189BD8070
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3303 */, bool useObjectPool = false /* Metadata: 0x00AF3307 */) => default; // 0x000000018593BB30-0x000000018593BE60
	// [XID] // 0x00000001895E7CD0-0x00000001895E7CF0
	public static SignInPeriodExcelConfig GetSignInPeriodExcelConfig(uint configID, uint peroid) => default; // 0x000000018593C0B0-0x000000018593C270
}


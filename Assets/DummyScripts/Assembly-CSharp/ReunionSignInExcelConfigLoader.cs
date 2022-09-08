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

public static class ReunionSignInExcelConfigLoader // TypeDefIndex: 16057
{
	// Fields
	private static List<ReunionSignInExcelConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ReunionSignInExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ReunionSignInExcelConfig, ReunionSignInExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ReunionSignInExcelConfig>, List<ReunionSignInExcelConfig>, string, bool> customValidateFunc; // 0x20
	public static Dictionary<uint, Dictionary<uint, ReunionSignInExcelConfig>> reunionSignInDataDic; // 0x28

	// Properties
	public static List<ReunionSignInExcelConfig> dataList { /* [XID] */ /* 0x0000000189AFA9E0-0x0000000189AFAA00 */ get; } // 0x0000000184AC7000-0x0000000184AC70D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B01FD0-0x0000000189B01FF0 */ get; } // 0x0000000184AC55D0-0x0000000184AC5670 

	// Constructors
	static ReunionSignInExcelConfigLoader() {} // 0x0000000184AC74E0-0x0000000184AC7540

	// Methods
	// [XID] // 0x0000000189AF3150-0x0000000189AF3170
	public static void Register() {} // 0x0000000184AC7420-0x0000000184AC74E0
	// [XID] // 0x0000000189B09490-0x0000000189B094B0
	public static void LoadData() {} // 0x0000000184AC62E0-0x0000000184AC6410
	// [XID] // 0x0000000189B10F70-0x0000000189B10F90
	private static void RegisterHotfixGenerated() {} // 0x0000000184AC6070-0x0000000184AC62E0
	// [XID] // 0x0000000189B181E0-0x0000000189B18200
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000184AC5B20-0x0000000184AC6070
	// [IDTag] // 0x0000000189B1F8A0-0x0000000189B1F8E0
	// [XID] // 0x0000000189B1F8A0-0x0000000189B1F8E0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184AC6870-0x0000000184AC69D0
	// [XID] // 0x0000000189B29E40-0x0000000189B29E60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ReunionSignInExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184AC70D0-0x0000000184AC7420
	// [XID] // 0x0000000189B31490-0x0000000189B314B0
	private static bool ParseConfigFromLine(string line, out ReunionSignInExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000184AC6410-0x0000000184AC6550
	// [IDTag] // 0x0000000189B389B0-0x0000000189B389F0
	// [XID] // 0x0000000189B389B0-0x0000000189B389F0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ReunionSignInExcelConfig> configList) => default; // 0x0000000184AC6550-0x0000000184AC6870
	// [IDTag] // 0x0000000189B43490-0x0000000189B434D0
	// [XID] // 0x0000000189B43490-0x0000000189B434D0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2F1B */, bool useObjectPool = false /* Metadata: 0x00AF2F1F */) => default; // 0x0000000184AC69D0-0x0000000184AC6C80
	// [IDTag] // 0x0000000189B4DB20-0x0000000189B4DB60
	// [XID] // 0x0000000189B4DB20-0x0000000189B4DB60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F20 */, bool useObjectPool = false /* Metadata: 0x00AF2F24 */) => default; // 0x0000000184AC6C80-0x0000000184AC7000
	// [XID] // 0x0000000189B58590-0x0000000189B585B0
	public static void LoadAndBuildReunionSignInDic() {} // 0x0000000184AC5670-0x0000000184AC5B20
}


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

public static class SensitiveWordConfigLoader // TypeDefIndex: 16102
{
	// Fields
	private static List<SensitiveWordConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<SensitiveWordConfig>> customApplyHotfixAction; // 0x08
	public static Action<SensitiveWordConfig, SensitiveWordConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<SensitiveWordConfig>, List<SensitiveWordConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<SensitiveWordConfig> dataList { /* [XID] */ /* 0x0000000189650A30-0x0000000189650A50 */ get; } // 0x0000000183B486A0-0x0000000183B48750 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189658270-0x0000000189658290 */ get; } // 0x0000000183B474B0-0x0000000183B47550 

	// Methods
	// [XID] // 0x0000000189649480-0x00000001896494A0
	public static void Register() {} // 0x0000000183B48A80-0x0000000183B48B20
	// [XID] // 0x000000018965F840-0x000000018965F860
	public static void LoadData() {} // 0x0000000183B47B50-0x0000000183B47C40
	// [XID] // 0x00000001896672B0-0x00000001896672D0
	private static void RegisterHotfixGenerated() {} // 0x0000000183B47980-0x0000000183B47B50
	// [XID] // 0x000000018966EB20-0x000000018966EB40
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000183B47550-0x0000000183B47980
	// [IDTag] // 0x0000000189676500-0x0000000189676540
	// [XID] // 0x0000000189676500-0x0000000189676540
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183B47D80-0x0000000183B47E80
	// [XID] // 0x0000000189680FC0-0x0000000189680FE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<SensitiveWordConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000183B48750-0x0000000183B48A80
	// [XID] // 0x0000000189688A20-0x0000000189688A40
	private static bool ParseConfigFromLine(string line, out SensitiveWordConfig data) {
		data = default;
		return default;
	} // 0x0000000183B47C40-0x0000000183B47D80
	// [IDTag] // 0x00000001896903E0-0x0000000189690420
	// [XID] // 0x00000001896903E0-0x0000000189690420
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<SensitiveWordConfig> configList) => default; // 0x0000000183B47E80-0x0000000183B48120
	// [IDTag] // 0x000000018969A810-0x000000018969A850
	// [XID] // 0x000000018969A810-0x000000018969A850
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF304F */, bool useObjectPool = false /* Metadata: 0x00AF3053 */) => default; // 0x0000000183B48120-0x0000000183B48370
	// [IDTag] // 0x00000001896A4C20-0x00000001896A4C60
	// [XID] // 0x00000001896A4C20-0x00000001896A4C60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3054 */, bool useObjectPool = false /* Metadata: 0x00AF3058 */) => default; // 0x0000000183B48370-0x0000000183B486A0
}


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

public static class BoredMonsterPoolConfigLoader // TypeDefIndex: 15293
{
	// Fields
	private static Dictionary<uint, BoredMonsterPoolConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<BoredMonsterPoolConfig>> customApplyHotfixAction; // 0x08
	public static Action<BoredMonsterPoolConfig, BoredMonsterPoolConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<BoredMonsterPoolConfig>, Dictionary<uint, BoredMonsterPoolConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, BoredMonsterPoolConfig> dataDict { /* [XID] */ /* 0x00000001895EF7C0-0x00000001895EF7E0 */ get; } // 0x000000018552AD00-0x000000018552ADB0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001895FE4E0-0x00000001895FE500 */ get; } // 0x0000000185529B50-0x0000000185529BF0 

	// Methods
	// [XID] // 0x00000001895E7E30-0x00000001895E7E50
	public static void Register() {} // 0x000000018552B0E0-0x000000018552B180
	// [XID] // 0x00000001895F70E0-0x00000001895F7100
	public static BoredMonsterPoolConfig GetData(uint id) => default; // 0x0000000185529A20-0x0000000185529B50
	// [XID] // 0x0000000189605E70-0x0000000189605E90
	public static void LoadData() {} // 0x000000018552A180-0x000000018552A270
	// [XID] // 0x000000018960D700-0x000000018960D720
	private static void RegisterHotfixGenerated() {} // 0x0000000185529FB0-0x000000018552A180
	// [XID] // 0x0000000189614F00-0x0000000189614F20
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185529BF0-0x0000000185529FB0
	// [IDTag] // 0x000000018961C660-0x000000018961C6A0
	// [XID] // 0x000000018961C660-0x000000018961C6A0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x000000018552A3B0-0x000000018552A4B0
	// [XID] // 0x0000000189626AC0-0x0000000189626AE0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<BoredMonsterPoolConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x000000018552ADB0-0x000000018552B0E0
	// [XID] // 0x000000018962E3F0-0x000000018962E410
	private static bool ParseConfigFromLine(string line, out BoredMonsterPoolConfig data) {
		data = default;
		return default;
	} // 0x000000018552A270-0x000000018552A3B0
	// [IDTag] // 0x0000000189635F90-0x0000000189635FD0
	// [XID] // 0x0000000189635F90-0x0000000189635FD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<BoredMonsterPoolConfig> configList) => default; // 0x000000018552A4B0-0x000000018552A760
	// [IDTag] // 0x0000000189640310-0x0000000189640350
	// [XID] // 0x0000000189640310-0x0000000189640350
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF0692 */, bool useObjectPool = false /* Metadata: 0x00AF0696 */) => default; // 0x000000018552AAB0-0x000000018552AD00
	// [IDTag] // 0x000000018964AB40-0x000000018964AB80
	// [XID] // 0x000000018964AB40-0x000000018964AB80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0697 */, bool useObjectPool = false /* Metadata: 0x00AF069B */) => default; // 0x000000018552A760-0x000000018552AAB0
}


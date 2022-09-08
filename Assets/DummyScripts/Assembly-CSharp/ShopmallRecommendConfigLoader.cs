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

public static class ShopmallRecommendConfigLoader // TypeDefIndex: 16137
{
	// Fields
	private static List<ShopmallRecommendConfig> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<ShopmallRecommendConfig>> customApplyHotfixAction; // 0x08
	public static Action<ShopmallRecommendConfig, ShopmallRecommendConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ShopmallRecommendConfig>, List<ShopmallRecommendConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<ShopmallRecommendConfig> dataList { /* [XID] */ /* 0x0000000189B70240-0x0000000189B70260 */ get; } // 0x00000001834884F0-0x00000001834885A0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B77750-0x0000000189B77770 */ get; } // 0x0000000183487300-0x00000001834873A0 

	// Methods
	// [XID] // 0x0000000189B68D40-0x0000000189B68D60
	public static void Register() {} // 0x00000001834888D0-0x0000000183488970
	// [XID] // 0x0000000189B7EC80-0x0000000189B7ECA0
	public static void LoadData() {} // 0x00000001834879A0-0x0000000183487A90
	// [XID] // 0x0000000189B86880-0x0000000189B868A0
	private static void RegisterHotfixGenerated() {} // 0x00000001834877D0-0x00000001834879A0
	// [XID] // 0x0000000189B8DA30-0x0000000189B8DA50
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001834873A0-0x00000001834877D0
	// [IDTag] // 0x0000000189B94F90-0x0000000189B94FD0
	// [XID] // 0x0000000189B94F90-0x0000000189B94FD0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183487E70-0x0000000183487F70
	// [XID] // 0x0000000189B9F390-0x0000000189B9F3B0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ShopmallRecommendConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001834885A0-0x00000001834888D0
	// [XID] // 0x0000000189BA6C20-0x0000000189BA6C40
	private static bool ParseConfigFromLine(string line, out ShopmallRecommendConfig data) {
		data = default;
		return default;
	} // 0x0000000183487A90-0x0000000183487BD0
	// [IDTag] // 0x0000000189BADDA0-0x0000000189BADDE0
	// [XID] // 0x0000000189BADDA0-0x0000000189BADDE0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ShopmallRecommendConfig> configList) => default; // 0x0000000183487BD0-0x0000000183487E70
	// [IDTag] // 0x0000000189BB84A0-0x0000000189BB84E0
	// [XID] // 0x0000000189BB84A0-0x0000000189BB84E0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF322C */, bool useObjectPool = false /* Metadata: 0x00AF3230 */) => default; // 0x00000001834882A0-0x00000001834884F0
	// [IDTag] // 0x0000000189BC34D0-0x0000000189BC3510
	// [XID] // 0x0000000189BC34D0-0x0000000189BC3510
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3231 */, bool useObjectPool = false /* Metadata: 0x00AF3235 */) => default; // 0x0000000183487F70-0x00000001834882A0
}


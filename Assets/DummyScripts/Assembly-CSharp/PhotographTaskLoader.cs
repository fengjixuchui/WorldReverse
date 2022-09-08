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

public static class PhotographTaskLoader // TypeDefIndex: 15951
{
	// Fields
	private static List<PhotographTask> _dataList; // 0x00
	public static Action<List<DataHotfixMeta>, List<PhotographTask>> customApplyHotfixAction; // 0x08
	public static Action<PhotographTask, PhotographTask> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PhotographTask>, List<PhotographTask>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static List<PhotographTask> dataList { /* [XID] */ /* 0x0000000189644B70-0x0000000189644B90 */ get; } // 0x0000000184718320-0x00000001847183D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x000000018964C510-0x000000018964C530 */ get; } // 0x0000000184717130-0x00000001847171D0 

	// Methods
	// [XID] // 0x000000018963D5B0-0x000000018963D5D0
	public static void Register() {} // 0x0000000184718700-0x00000001847187A0
	// [XID] // 0x0000000189653AE0-0x0000000189653B00
	public static void LoadData() {} // 0x00000001847177D0-0x00000001847178C0
	// [XID] // 0x000000018965B350-0x000000018965B370
	private static void RegisterHotfixGenerated() {} // 0x0000000184717600-0x00000001847177D0
	// [XID] // 0x0000000189662800-0x0000000189662820
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001847171D0-0x0000000184717600
	// [IDTag] // 0x000000018966A380-0x000000018966A3C0
	// [XID] // 0x000000018966A380-0x000000018966A3C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184717A00-0x0000000184717B00
	// [XID] // 0x0000000189674E90-0x0000000189674EB0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PhotographTask> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001847183D0-0x0000000184718700
	// [XID] // 0x000000018967C680-0x000000018967C6A0
	private static bool ParseConfigFromLine(string line, out PhotographTask data) {
		data = default;
		return default;
	} // 0x00000001847178C0-0x0000000184717A00
	// [IDTag] // 0x0000000189683D90-0x0000000189683DD0
	// [XID] // 0x0000000189683D90-0x0000000189683DD0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PhotographTask> configList) => default; // 0x0000000184717B00-0x0000000184717DA0
	// [IDTag] // 0x000000018968EC90-0x000000018968ECD0
	// [XID] // 0x000000018968EC90-0x000000018968ECD0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2C0B */, bool useObjectPool = false /* Metadata: 0x00AF2C0F */) => default; // 0x00000001847180D0-0x0000000184718320
	// [IDTag] // 0x0000000189699320-0x0000000189699360
	// [XID] // 0x0000000189699320-0x0000000189699360
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C10 */, bool useObjectPool = false /* Metadata: 0x00AF2C14 */) => default; // 0x0000000184717DA0-0x00000001847180D0
}


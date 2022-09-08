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

public static class PhotographPoseExcelConfigLoader // TypeDefIndex: 15945
{
	// Fields
	private static Dictionary<uint, PhotographPoseExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<PhotographPoseExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<PhotographPoseExcelConfig, PhotographPoseExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<PhotographPoseExcelConfig>, Dictionary<uint, PhotographPoseExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, PhotographPoseExcelConfig> dataDict { /* [XID] */ /* 0x0000000189849EF0-0x0000000189849F10 */ get; } // 0x0000000182236780-0x0000000182236830 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189858AE0-0x0000000189858B00 */ get; } // 0x00000001822355D0-0x0000000182235670 

	// Methods
	// [XID] // 0x0000000189842B40-0x0000000189842B60
	public static void Register() {} // 0x0000000182236B60-0x0000000182236C00
	// [XID] // 0x0000000189851570-0x0000000189851590
	public static PhotographPoseExcelConfig GetData(uint character_id) => default; // 0x00000001822354A0-0x00000001822355D0
	// [XID] // 0x000000018985FC90-0x000000018985FCB0
	public static void LoadData() {} // 0x0000000182235C00-0x0000000182235CF0
	// [XID] // 0x0000000189867330-0x0000000189867350
	private static void RegisterHotfixGenerated() {} // 0x0000000182235A30-0x0000000182235C00
	// [XID] // 0x000000018986EAF0-0x000000018986EB10
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182235670-0x0000000182235A30
	// [IDTag] // 0x0000000189875F80-0x0000000189875FC0
	// [XID] // 0x0000000189875F80-0x0000000189875FC0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001822360E0-0x00000001822361E0
	// [XID] // 0x0000000189880660-0x0000000189880680
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<PhotographPoseExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182236830-0x0000000182236B60
	// [XID] // 0x0000000189887C00-0x0000000189887C20
	private static bool ParseConfigFromLine(string line, out PhotographPoseExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182235CF0-0x0000000182235E30
	// [IDTag] // 0x000000018988EF40-0x000000018988EF80
	// [XID] // 0x000000018988EF40-0x000000018988EF80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<PhotographPoseExcelConfig> configList) => default; // 0x0000000182235E30-0x00000001822360E0
	// [IDTag] // 0x00000001898996D0-0x0000000189899710
	// [XID] // 0x00000001898996D0-0x0000000189899710
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2BDE */, bool useObjectPool = false /* Metadata: 0x00AF2BE2 */) => default; // 0x0000000182236530-0x0000000182236780
	// [IDTag] // 0x00000001898A3B40-0x00000001898A3B80
	// [XID] // 0x00000001898A3B40-0x00000001898A3B80
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BE3 */, bool useObjectPool = false /* Metadata: 0x00AF2BE7 */) => default; // 0x00000001822361E0-0x0000000182236530
}


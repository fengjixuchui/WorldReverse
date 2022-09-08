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

public static class OpActivityExcelConfigLoader // TypeDefIndex: 15929
{
	// Fields
	private static Dictionary<uint, OpActivityExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<OpActivityExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<OpActivityExcelConfig, OpActivityExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<OpActivityExcelConfig>, Dictionary<uint, OpActivityExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, OpActivityExcelConfig> dataDict { /* [XID] */ /* 0x0000000189744F90-0x0000000189744FB0 */ get; } // 0x0000000183021020-0x00000001830210D0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189753E40-0x0000000189753E60 */ get; } // 0x000000018301FE70-0x000000018301FF10 

	// Methods
	// [XID] // 0x000000018973DBD0-0x000000018973DBF0
	public static void Register() {} // 0x0000000183021400-0x00000001830214A0
	// [XID] // 0x000000018974CAC0-0x000000018974CAE0
	public static OpActivityExcelConfig GetData(uint opActivityId) => default; // 0x000000018301FD40-0x000000018301FE70
	// [XID] // 0x000000018975B300-0x000000018975B320
	public static void LoadData() {} // 0x00000001830204A0-0x0000000183020590
	// [XID] // 0x0000000189762D10-0x0000000189762D30
	private static void RegisterHotfixGenerated() {} // 0x00000001830202D0-0x00000001830204A0
	// [XID] // 0x000000018976A310-0x000000018976A330
	public static void ApplyHotfix(JSONNode node) {} // 0x000000018301FF10-0x00000001830202D0
	// [IDTag] // 0x0000000189771B50-0x0000000189771B90
	// [XID] // 0x0000000189771B50-0x0000000189771B90
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000183020980-0x0000000183020A80
	// [XID] // 0x000000018977C1A0-0x000000018977C1C0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<OpActivityExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001830210D0-0x0000000183021400
	// [XID] // 0x0000000189783B90-0x0000000189783BB0
	private static bool ParseConfigFromLine(string line, out OpActivityExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000183020590-0x00000001830206D0
	// [IDTag] // 0x000000018978B340-0x000000018978B380
	// [XID] // 0x000000018978B340-0x000000018978B380
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<OpActivityExcelConfig> configList) => default; // 0x00000001830206D0-0x0000000183020980
	// [IDTag] // 0x00000001897956E0-0x0000000189795720
	// [XID] // 0x00000001897956E0-0x0000000189795720
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF2B68 */, bool useObjectPool = false /* Metadata: 0x00AF2B6C */) => default; // 0x0000000183020DD0-0x0000000183021020
	// [IDTag] // 0x00000001897A0530-0x00000001897A0570
	// [XID] // 0x00000001897A0530-0x00000001897A0570
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B6D */, bool useObjectPool = false /* Metadata: 0x00AF2B71 */) => default; // 0x0000000183020A80-0x0000000183020DD0
}


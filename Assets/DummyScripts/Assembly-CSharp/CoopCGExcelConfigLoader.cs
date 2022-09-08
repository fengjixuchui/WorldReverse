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

public static class CoopCGExcelConfigLoader // TypeDefIndex: 14856
{
	// Fields
	private static Dictionary<uint, List<uint>> _pointId2cgIdListDic; // 0x00
	private static Dictionary<uint, CoopCGExcelConfig> _dataDict; // 0x08
	public static Action<List<DataHotfixMeta>, List<CoopCGExcelConfig>> customApplyHotfixAction; // 0x10
	public static Action<CoopCGExcelConfig, CoopCGExcelConfig> onUpdateConfig; // 0x18
	public static Action onApplyHotfixFinish; // 0x20
	public static Func<List<DataHotfixMeta>, List<CoopCGExcelConfig>, Dictionary<uint, CoopCGExcelConfig>, string, bool> customValidateFunc; // 0x28

	// Properties
	public static Dictionary<uint, CoopCGExcelConfig> dataDict { /* [XID] */ /* 0x00000001896AF310-0x00000001896AF330 */ get; } // 0x0000000182A096A0-0x0000000182A09770 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001896BDB80-0x00000001896BDBA0 */ get; } // 0x0000000182A07920-0x0000000182A079C0 

	// Constructors
	static CoopCGExcelConfigLoader() {} // 0x0000000182A09CD0-0x0000000182A09D30

	// Methods
	// [XID] // 0x0000000189682730-0x0000000189682750
	public static void BuildCoopPointId2CGListDic() {} // 0x0000000182A08600-0x0000000182A08A60
	// [XID] // 0x000000018968A2D0-0x000000018968A2F0
	public static List<uint> GetPointCGList(uint pointId) => default; // 0x0000000182A084D0-0x0000000182A08600
	// [XID] // 0x0000000189692050-0x0000000189692070
	public static uint GetCGChapterId(uint configId) => default; // 0x0000000182A09770-0x0000000182A098C0
	// [XID] // 0x00000001896994E0-0x0000000189699500
	public static uint GetSortId(uint configId) => default; // 0x0000000182A08F10-0x0000000182A09060
	// [XID] // 0x00000001896A0950-0x00000001896A0970
	public static CoopCGType GetCGType(uint configId) => default; // 0x0000000182A08110-0x0000000182A08260
	// [XID] // 0x00000001896A7F20-0x00000001896A7F40
	public static void Register() {} // 0x0000000182A09C10-0x0000000182A09CD0
	// [XID] // 0x00000001896B6880-0x00000001896B68A0
	public static CoopCGExcelConfig GetData(uint id) => default; // 0x0000000182A07780-0x0000000182A07920
	// [XID] // 0x00000001896C53F0-0x00000001896C5410
	public static void LoadData() {} // 0x0000000182A08260-0x0000000182A08390
	// [XID] // 0x00000001896CC990-0x00000001896CC9B0
	private static void RegisterHotfixGenerated() {} // 0x0000000182A07EA0-0x0000000182A08110
	// [XID] // 0x00000001896D3C60-0x00000001896D3C80
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000182A079C0-0x0000000182A07EA0
	// [IDTag] // 0x00000001896DB5C0-0x00000001896DB600
	// [XID] // 0x00000001896DB5C0-0x00000001896DB600
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000182A08A60-0x0000000182A08BC0
	// [XID] // 0x00000001896E5A50-0x00000001896E5A70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<CoopCGExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000182A098C0-0x0000000182A09C10
	// [XID] // 0x00000001896ED0A0-0x00000001896ED0C0
	private static bool ParseConfigFromLine(string line, out CoopCGExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000182A08390-0x0000000182A084D0
	// [IDTag] // 0x00000001896F4920-0x00000001896F4960
	// [XID] // 0x00000001896F4920-0x00000001896F4960
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<CoopCGExcelConfig> configList) => default; // 0x0000000182A08BC0-0x0000000182A08F10
	// [IDTag] // 0x00000001896FF250-0x00000001896FF290
	// [XID] // 0x00000001896FF250-0x00000001896FF290
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF7E5 */, bool useObjectPool = false /* Metadata: 0x00AEF7E9 */) => default; // 0x0000000182A093F0-0x0000000182A096A0
	// [IDTag] // 0x0000000189709740-0x0000000189709780
	// [XID] // 0x0000000189709740-0x0000000189709780
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7EA */, bool useObjectPool = false /* Metadata: 0x00AEF7EE */) => default; // 0x0000000182A09060-0x0000000182A093F0
}


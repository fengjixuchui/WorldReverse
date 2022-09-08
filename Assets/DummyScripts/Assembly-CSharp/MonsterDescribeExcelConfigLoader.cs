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

public static class MonsterDescribeExcelConfigLoader // TypeDefIndex: 14877
{
	// Fields
	private static Dictionary<uint, MonsterDescribeExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<MonsterDescribeExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<MonsterDescribeExcelConfig, MonsterDescribeExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<MonsterDescribeExcelConfig>, Dictionary<uint, MonsterDescribeExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, MonsterDescribeExcelConfig> dataDict { /* [XID] */ /* 0x0000000189B53E60-0x0000000189B53E80 */ get; } // 0x00000001851149A0-0x0000000185114A50 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189B62C60-0x0000000189B62C80 */ get; } // 0x00000001851137F0-0x0000000185113890 

	// Methods
	// [XID] // 0x0000000189B44FF0-0x0000000189B45010
	public static MonsterDescribeExcelConfig GetDataByMonsterId(uint monsterId) => default; // 0x0000000185114E20-0x0000000185114EF0
	// [XID] // 0x0000000189B4C7A0-0x0000000189B4C7C0
	public static void Register() {} // 0x0000000185114D80-0x0000000185114E20
	// [XID] // 0x0000000189B5B7B0-0x0000000189B5B7D0
	public static MonsterDescribeExcelConfig GetData(uint id) => default; // 0x00000001851136C0-0x00000001851137F0
	// [XID] // 0x0000000189B6A6B0-0x0000000189B6A6D0
	public static void LoadData() {} // 0x0000000185113E20-0x0000000185113F10
	// [XID] // 0x0000000189B71E50-0x0000000189B71E70
	private static void RegisterHotfixGenerated() {} // 0x0000000185113C50-0x0000000185113E20
	// [XID] // 0x0000000189B79260-0x0000000189B79280
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000185113890-0x0000000185113C50
	// [IDTag] // 0x0000000189B80670-0x0000000189B806B0
	// [XID] // 0x0000000189B80670-0x0000000189B806B0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000185114050-0x0000000185114150
	// [XID] // 0x0000000189B8ACB0-0x0000000189B8ACD0
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<MonsterDescribeExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000185114A50-0x0000000185114D80
	// [XID] // 0x0000000189B92340-0x0000000189B92360
	private static bool ParseConfigFromLine(string line, out MonsterDescribeExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000185113F10-0x0000000185114050
	// [IDTag] // 0x0000000189B99900-0x0000000189B99940
	// [XID] // 0x0000000189B99900-0x0000000189B99940
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<MonsterDescribeExcelConfig> configList) => default; // 0x0000000185114150-0x0000000185114400
	// [IDTag] // 0x0000000189BA3F30-0x0000000189BA3F70
	// [XID] // 0x0000000189BA3F30-0x0000000189BA3F70
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF8BD */, bool useObjectPool = false /* Metadata: 0x00AEF8C1 */) => default; // 0x0000000185114750-0x00000001851149A0
	// [IDTag] // 0x0000000189BAE000-0x0000000189BAE040
	// [XID] // 0x0000000189BAE000-0x0000000189BAE040
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8C2 */, bool useObjectPool = false /* Metadata: 0x00AEF8C6 */) => default; // 0x0000000185114400-0x0000000185114750
}


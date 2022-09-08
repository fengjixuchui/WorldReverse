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

public static class ChannellerSlabBuffEnergyExcelConfigLoader // TypeDefIndex: 14815
{
	// Fields
	private static Dictionary<uint, ChannellerSlabBuffEnergyExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ChannellerSlabBuffEnergyExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<ChannellerSlabBuffEnergyExcelConfig, ChannellerSlabBuffEnergyExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ChannellerSlabBuffEnergyExcelConfig>, Dictionary<uint, ChannellerSlabBuffEnergyExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ChannellerSlabBuffEnergyExcelConfig> dataDict { /* [XID] */ /* 0x0000000189A06390-0x0000000189A063B0 */ get; } // 0x00000001849A6E40-0x00000001849A6EF0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189A14FA0-0x0000000189A14FC0 */ get; } // 0x00000001849A5C90-0x00000001849A5D30 

	// Methods
	// [XID] // 0x00000001899F7450-0x00000001899F7470
	public static ChannellerSlabBuffEnergyExcelConfig GetDataByAvatarLevel(uint avatarLevel) => default; // 0x00000001849A6EF0-0x00000001849A7190
	// [XID] // 0x00000001899FEB90-0x00000001899FEBB0
	public static void Register() {} // 0x00000001849A74C0-0x00000001849A7560
	// [XID] // 0x0000000189A0D8A0-0x0000000189A0D8C0
	public static ChannellerSlabBuffEnergyExcelConfig GetData(uint id) => default; // 0x00000001849A5B60-0x00000001849A5C90
	// [XID] // 0x0000000189A1C0F0-0x0000000189A1C110
	public static void LoadData() {} // 0x00000001849A62C0-0x00000001849A63B0
	// [XID] // 0x0000000189A23A00-0x0000000189A23A20
	private static void RegisterHotfixGenerated() {} // 0x00000001849A60F0-0x00000001849A62C0
	// [XID] // 0x0000000189A2AE20-0x0000000189A2AE40
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001849A5D30-0x00000001849A60F0
	// [IDTag] // 0x0000000189A32380-0x0000000189A323C0
	// [XID] // 0x0000000189A32380-0x0000000189A323C0
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001849A64F0-0x00000001849A65F0
	// [XID] // 0x0000000189A3CC40-0x0000000189A3CC60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ChannellerSlabBuffEnergyExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001849A7190-0x00000001849A74C0
	// [XID] // 0x0000000189A44630-0x0000000189A44650
	private static bool ParseConfigFromLine(string line, out ChannellerSlabBuffEnergyExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001849A63B0-0x00000001849A64F0
	// [IDTag] // 0x0000000189A4BC40-0x0000000189A4BC80
	// [XID] // 0x0000000189A4BC40-0x0000000189A4BC80
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ChannellerSlabBuffEnergyExcelConfig> configList) => default; // 0x00000001849A65F0-0x00000001849A68A0
	// [IDTag] // 0x0000000189A56400-0x0000000189A56440
	// [XID] // 0x0000000189A56400-0x0000000189A56440
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF652 */, bool useObjectPool = false /* Metadata: 0x00AEF656 */) => default; // 0x00000001849A68A0-0x00000001849A6AF0
	// [IDTag] // 0x0000000189A60E20-0x0000000189A60E60
	// [XID] // 0x0000000189A60E20-0x0000000189A60E60
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF657 */, bool useObjectPool = false /* Metadata: 0x00AEF65B */) => default; // 0x00000001849A6AF0-0x00000001849A6E40
}


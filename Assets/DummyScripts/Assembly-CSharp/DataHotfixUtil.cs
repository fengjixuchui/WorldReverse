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

public static class DataHotfixUtil // TypeDefIndex: 31391
{
	// Fields
	private static Dictionary<string, ApplyHotfixAction> _applyHotfixActionDict; // 0x00
	public static Dictionary<string, ValidateHotfixFunc> _validateHotfixFuncDict; // 0x08
	private static Dictionary<string, object> _originalDataDict; // 0x10
	private static Dictionary<string, JSONNode> _hotfixLazyLoadDict; // 0x18
	private static Dictionary<int, Dictionary<uint, string>> _hotfixTextMapDict; // 0x20
	private static Dictionary<string, ConfigAbility> _hotfixConfigAbilityDict; // 0x28

	// Nested types
	public delegate void ApplyHotfixAction(JSONNode node); // TypeDefIndex: 31392; 0x000000018153DE90-0x000000018153E0F0

	public delegate bool ValidateHotfixFunc(JSONNode node); // TypeDefIndex: 31393; 0x000000018153D8F0-0x000000018153DB50

	// Constructors
	static DataHotfixUtil() {} // 0x0000000181559E90-0x0000000181559F50

	// Methods
	// [XID] // 0x0000000189B95930-0x0000000189B95950
	public static void ApplyAllHotfixData() {} // 0x00000001815565A0-0x00000001815568E0
	// [XID] // 0x0000000189B9CED0-0x0000000189B9CEF0
	private static bool ValidateHotfixData(string type, string jsonData) => default; // 0x0000000181557E20-0x0000000181557F90
	// [XID] // 0x0000000189BA47D0-0x0000000189BA47F0
	private static void ApplyHotfixData(string type, string jsonData) {} // 0x0000000181558EC0-0x0000000181559020
	// [XID] // 0x0000000189BABB30-0x0000000189BABB50
	private static bool ValidateHotfixDataVersion(string jsonData) => default; // 0x0000000181557460-0x0000000181557810
	// [XID] // 0x0000000189BB3220-0x0000000189BB3240
	public static void AddApplyHotfixAction(string type, ApplyHotfixAction action) {} // 0x00000001815564A0-0x00000001815565A0
	// [XID] // 0x0000000189BBA7E0-0x0000000189BBA800
	public static ApplyHotfixAction GetApplyHotfixAction(string type) => default; // 0x0000000181557A10-0x0000000181557B20
	// [XID] // 0x0000000189BC2800-0x0000000189BC2820
	public static void AddValidateHotfixFunc(string type, ValidateHotfixFunc action) {} // 0x0000000181557B20-0x0000000181557C20
	// [XID] // 0x0000000189BC9F60-0x0000000189BC9F80
	public static ValidateHotfixFunc GetValidateHotfixFunc(string type) => default; // 0x0000000181559D80-0x0000000181559E90
	// [XID] // 0x0000000189BD15E0-0x0000000189BD1600
	public static DataHotfixMeta ParseDataHotFixMeta(JSONNode node) => default; // 0x0000000181556F60-0x0000000181557150
	// [XID] // 0x0000000189BD8BE0-0x0000000189BD8C00
	public static int CalculateAddCount(List<DataHotfixMeta> metaList) => default; // 0x0000000181557810-0x0000000181557A10
	// [XID] // 0x00000001895E57A0-0x00000001895E57C0
	public static void AddOriginalData(string type, object data) {} // 0x0000000181558760-0x00000001815588F0
	// [XID] // 0x00000001895ED0F0-0x00000001895ED110
	public static object GetOriginalData(string type) => default; // 0x0000000181556E20-0x0000000181556F60
	// [IDTag] // 0x00000001895F4770-0x00000001895F47B0
	// [XID] // 0x00000001895F4770-0x00000001895F47B0
	public static void ReportDataError(string configType, DataHotfixUpdateType updateType, int configIndex, object key, bool isDict) {} // 0x00000001815594F0-0x0000000181559C30
	// [IDTag] // 0x00000001895FEE90-0x00000001895FEED0
	// [XID] // 0x00000001895FEE90-0x00000001895FEED0
	public static void ReportDataError(string configType, string errorMsg) {} // 0x0000000181559C30-0x0000000181559D80
	// [XID] // 0x00000001896097F0-0x0000000189609810
	public static void PrintHotfixData() {} // 0x0000000181557C20-0x0000000181557E20
	// [XID] // 0x0000000189611060-0x0000000189611080
	public static void AddHotfixLazyLoadData(string type, JSONNode node) {} // 0x0000000181557150-0x00000001815572E0
	// [XID] // 0x0000000189618A30-0x0000000189618A50
	public static JSONNode GetHotfixLazyLoadData(string type) => default; // 0x00000001815588F0-0x0000000181558A30
	// [XID] // 0x000000018961FFC0-0x000000018961FFE0
	public static void RegisterHotfixActions() {} // 0x0000000181556BC0-0x0000000181556E20
	// [XID] // 0x0000000189627450-0x0000000189627470
	public static void ClearHotfixData() {} // 0x00000001815572E0-0x0000000181557460
	// [XID] // 0x000000018962EF50-0x000000018962EF70
	private static void ApplyHotfixTextMap(JSONNode node) {} // 0x0000000181557F90-0x0000000181558760
	// [XID] // 0x0000000189636910-0x0000000189636930
	public static string GetHotfixText(uint textMapId) => default; // 0x0000000181556A20-0x0000000181556BC0
	// [XID] // 0x000000018963DDE0-0x000000018963DE00
	private static void ApplyHotfixConfigAbility(JSONNode node) {} // 0x0000000181558A30-0x0000000181558EC0
	// [XID] // 0x0000000189645790-0x00000001896457B0
	public static Dictionary<string, ConfigAbility>[] ProcessHotfixConfigAbilitys(Dictionary<string, ConfigAbility>[] abilityConfigs) => default; // 0x0000000181559020-0x00000001815594F0
	// [XID] // 0x00000001898E9AD0-0x00000001898E9AF0
	public static ConfigAbility GetHotfixConfigAbility(string abilityName) => default; // 0x00000001815568E0-0x0000000181556A20
}


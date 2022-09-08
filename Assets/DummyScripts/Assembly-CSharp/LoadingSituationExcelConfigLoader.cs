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

public static class LoadingSituationExcelConfigLoader // TypeDefIndex: 15789
{
	// Fields
	private static Dictionary<uint, LoadingSituationExcelConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<LoadingSituationExcelConfig>> customApplyHotfixAction; // 0x08
	public static Action<LoadingSituationExcelConfig, LoadingSituationExcelConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<LoadingSituationExcelConfig>, Dictionary<uint, LoadingSituationExcelConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, LoadingSituationExcelConfig> dataDict { /* [XID] */ /* 0x0000000189879110-0x0000000189879130 */ get; } // 0x0000000181F66C30-0x0000000181F66CE0 
	private static string FILE_LOCATION { /* [XID] */ /* 0x0000000189887C60-0x0000000189887C80 */ get; } // 0x0000000181F65A80-0x0000000181F65B20 

	// Methods
	// [XID] // 0x0000000189871850-0x0000000189871870
	public static void Register() {} // 0x0000000181F67010-0x0000000181F670B0
	// [XID] // 0x00000001898806C0-0x00000001898806E0
	public static LoadingSituationExcelConfig GetData(uint stageID) => default; // 0x0000000181F65950-0x0000000181F65A80
	// [XID] // 0x000000018988EFE0-0x000000018988F000
	public static void LoadData() {} // 0x0000000181F660B0-0x0000000181F661A0
	// [XID] // 0x00000001898964E0-0x0000000189896500
	private static void RegisterHotfixGenerated() {} // 0x0000000181F65EE0-0x0000000181F660B0
	// [XID] // 0x000000018989DAE0-0x000000018989DB00
	public static void ApplyHotfix(JSONNode node) {} // 0x0000000181F65B20-0x0000000181F65EE0
	// [IDTag] // 0x00000001898A53C0-0x00000001898A5400
	// [XID] // 0x00000001898A53C0-0x00000001898A5400
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000181F662E0-0x0000000181F663E0
	// [XID] // 0x00000001898AFA50-0x00000001898AFA70
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<LoadingSituationExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000181F66CE0-0x0000000181F67010
	// [XID] // 0x00000001898B6FF0-0x00000001898B7010
	private static bool ParseConfigFromLine(string line, out LoadingSituationExcelConfig data) {
		data = default;
		return default;
	} // 0x0000000181F661A0-0x0000000181F662E0
	// [IDTag] // 0x00000001898BE7A0-0x00000001898BE7E0
	// [XID] // 0x00000001898BE7A0-0x00000001898BE7E0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<LoadingSituationExcelConfig> configList) => default; // 0x0000000181F663E0-0x0000000181F66690
	// [IDTag] // 0x00000001898C9160-0x00000001898C91A0
	// [XID] // 0x00000001898C9160-0x00000001898C91A0
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF260B */, bool useObjectPool = false /* Metadata: 0x00AF260F */) => default; // 0x0000000181F66690-0x0000000181F668E0
	// [IDTag] // 0x00000001898D3750-0x00000001898D3790
	// [XID] // 0x00000001898D3750-0x00000001898D3790
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2610 */, bool useObjectPool = false /* Metadata: 0x00AF2614 */) => default; // 0x0000000181F668E0-0x0000000181F66C30
}


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

public static class ProductCardDetailConfigLoader // TypeDefIndex: 16141
{
	// Fields
	private static Dictionary<uint, ProductCardDetailConfig> _dataDict; // 0x00
	public static Action<List<DataHotfixMeta>, List<ProductCardDetailConfig>> customApplyHotfixAction; // 0x08
	public static Action<ProductCardDetailConfig, ProductCardDetailConfig> onUpdateConfig; // 0x10
	public static Action onApplyHotfixFinish; // 0x18
	public static Func<List<DataHotfixMeta>, List<ProductCardDetailConfig>, Dictionary<uint, ProductCardDetailConfig>, string, bool> customValidateFunc; // 0x20

	// Properties
	public static Dictionary<uint, ProductCardDetailConfig> dataDict { /* [XID] */ /* 0x0000000189905820-0x0000000189905840 */ get; } // 0x00000001845265E0-0x0000000184526690 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001899148C0-0x00000001899148E0 */ get; } // 0x0000000184525430-0x00000001845254D0 

	// Methods
	// [XID] // 0x00000001898FE060-0x00000001898FE080
	public static void Register() {} // 0x00000001845269C0-0x0000000184526A60
	// [XID] // 0x000000018990D150-0x000000018990D170
	public static ProductCardDetailConfig GetData(uint configId) => default; // 0x0000000184525300-0x0000000184525430
	// [XID] // 0x000000018991C4C0-0x000000018991C4E0
	public static void LoadData() {} // 0x0000000184525A60-0x0000000184525B50
	// [XID] // 0x0000000189923C00-0x0000000189923C20
	private static void RegisterHotfixGenerated() {} // 0x0000000184525890-0x0000000184525A60
	// [XID] // 0x000000018992B260-0x000000018992B280
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001845254D0-0x0000000184525890
	// [IDTag] // 0x00000001899328C0-0x0000000189932900
	// [XID] // 0x00000001899328C0-0x0000000189932900
	public static bool ValidateHotfix(JSONNode node) => default; // 0x0000000184525F40-0x0000000184526040
	// [XID] // 0x000000018993D110-0x000000018993D130
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<ProductCardDetailConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x0000000184526690-0x00000001845269C0
	// [XID] // 0x0000000189944760-0x0000000189944780
	private static bool ParseConfigFromLine(string line, out ProductCardDetailConfig data) {
		data = default;
		return default;
	} // 0x0000000184525B50-0x0000000184525C90
	// [IDTag] // 0x000000018994BD60-0x000000018994BDA0
	// [XID] // 0x000000018994BD60-0x000000018994BDA0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<ProductCardDetailConfig> configList) => default; // 0x0000000184525C90-0x0000000184525F40
	// [IDTag] // 0x00000001899562E0-0x0000000189956320
	// [XID] // 0x00000001899562E0-0x0000000189956320
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AF324A */, bool useObjectPool = false /* Metadata: 0x00AF324E */) => default; // 0x0000000184526040-0x0000000184526290
	// [IDTag] // 0x0000000189960CC0-0x0000000189960D00
	// [XID] // 0x0000000189960CC0-0x0000000189960D00
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF324F */, bool useObjectPool = false /* Metadata: 0x00AF3253 */) => default; // 0x0000000184526290-0x00000001845265E0
}


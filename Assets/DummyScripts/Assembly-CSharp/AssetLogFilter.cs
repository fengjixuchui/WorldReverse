/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AssetLogFilter // TypeDefIndex: 31583
{
	// Fields
	private AssetLogFilter _premise; // 0x10
	private List<AssetLogFilter> _childrenFilters; // 0x18
	private FilterRule _filterRule; // 0x20
	private List<MemoryAssetList.AssetItem> _parsedItems; // 0x28
	private int _indentCount; // 0x30
	private float _sizeMB; // 0x34
	private int _validAssetItemCount; // 0x38
	private string _nodeName; // 0x40
	private System.Type _assetFetchType; // 0x48
	private bool _bOthers; // 0x50
	private static Dictionary<System.Type, List<MemoryAssetList.AssetItem>> _typeAssetItemMap; // 0x00

	// Properties
	public bool bLeafNode { /* [XID] */ /* 0x0000000189BB02C0-0x0000000189BB02E0 */ get => default; } // 0x000000018277E020-0x000000018277E0D0 

	// Constructors
	public AssetLogFilter() {} // Dummy constructor
	public AssetLogFilter(AssetLogFilter inPremiseFilter, string inNodeName, bool rootPlaceHolderTaggedAsOthers) {} // 0x000000018277F5C0-0x000000018277F680
	public AssetLogFilter(AssetLogFilter inPremiseFilter, string inNodeName, System.Type inAssetFetchType, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] symbols) {} // 0x000000018277F3B0-0x000000018277F4A0
	public AssetLogFilter(AssetLogFilter inPremiseFilter, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] symbols) {} // 0x000000018277F4A0-0x000000018277F5C0
	public AssetLogFilter(AssetLogFilter inPremiseFilter, bool printParentTransformPath, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] symbols) {} // 0x000000018277F680-0x000000018277F7A0

	// Methods
	// [XID] // 0x0000000189B40DF0-0x0000000189B40E10
	public static void RegisterAssetItemMap(Dictionary<System.Type, List<MemoryAssetList.AssetItem>> inTATM) {} // 0x000000018277DD60-0x000000018277DE60
	// [XID] // 0x00000001897E7E10-0x00000001897E7E30
	public static void FlushAssetItemMap() {} // 0x000000018277ECE0-0x000000018277EDD0
	// [XID] // 0x0000000189B4FE80-0x0000000189B4FEA0
	public string FullName() => default; // 0x000000018277E9C0-0x000000018277EB60
	// [XID] // 0x0000000189B576C0-0x0000000189B576E0
	public string ToLog() => default; // 0x000000018277DA40-0x000000018277DB80
	// [XID] // 0x00000001897859E0-0x0000000189785A00
	public void WriteLog(StatLog.IBufferLogger inLogger) {} // 0x000000018277E610-0x000000018277E9C0
	// [XID] // 0x0000000189B66640-0x0000000189B66660
	public static string GetIndentStr(int count) => default; // 0x000000018277E340-0x000000018277E450
	// [XID] // 0x0000000189B6DBE0-0x0000000189B6DC00
	public static string GenAlignmentString(string beginStr, int targetAlignementCount, bool bAppend = false /* Metadata: 0x00B13357 */) => default; // 0x000000018277E450-0x000000018277E610
	// [XID] // 0x0000000189B75230-0x0000000189B75250
	private void RegisterChildFilter(AssetLogFilter inFilter) {} // 0x000000018277EDD0-0x000000018277EED0
	// [XID] // 0x0000000189B7C680-0x0000000189B7C6A0
	private void SetPremiseFilter(AssetLogFilter inPremiseFilter) {} // 0x000000018277EED0-0x000000018277EFA0
	// [XID] // 0x0000000189B84480-0x0000000189B844A0
	public void SetExclusiveFilterStyle() {} // 0x000000018277EC30-0x000000018277ECE0
	// [XID] // 0x0000000189B8B350-0x0000000189B8B370
	private bool ParseItem(MemoryAssetList.AssetItem inAssetItem) => default; // 0x000000018277DC90-0x000000018277DD60
	// [XID] // 0x0000000189B92AA0-0x0000000189B92AC0
	public static string ToString(string prefix, string[] inWildcards) => default; // 0x000000018277DE60-0x000000018277E020
	// [XID] // 0x0000000189B9A000-0x0000000189B9A020
	public static bool EndAny(string targetString, string[] inWildcards) => default; // 0x000000018277DB80-0x000000018277DC90
	// [XID] // 0x0000000189BA1780-0x0000000189BA17A0
	public static bool ContainAny(string targetString, string[] inWildcards) => default; // 0x000000018277E140-0x000000018277E250
	// [XID] // 0x0000000189BA8B70-0x0000000189BA8B90
	private bool InternalParseItem(ref MemoryAssetList.AssetItem inAssetItem) => default; // 0x000000018277EB60-0x000000018277EC30
	// [XID] // 0x0000000189BB7700-0x0000000189BB7720
	public long Parse(List<MemoryAssetList.AssetItem> inAssetItems) => default; // 0x000000018277EFA0-0x000000018277F3B0
	// [XID] // 0x0000000189BBEDA0-0x0000000189BBEDC0
	public void Flush() {} // 0x000000018277E250-0x000000018277E340
}


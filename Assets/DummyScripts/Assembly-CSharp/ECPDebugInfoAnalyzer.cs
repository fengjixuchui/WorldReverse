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

public class ECPDebugInfoAnalyzer // TypeDefIndex: 27813
{
	// Fields
	private static ECPDebugInfoAnalyzer _instance; // 0x00
	private List<BaseEntity> _cachedEntitySortList; // 0x10
	private Dictionary<string, BaseEntity.ECPDebugInfo> _cachedCategoryEntityInfo; // 0x18
	private List<BaseEntity.ECPDebugInfo> _cachedECPDebugInfos; // 0x20
	private List<BaseEntity.ECPDebugInfo> _cachedECPDebugInfosResult; // 0x28

	// Properties
	public static ECPDebugInfoAnalyzer instance { /* [XID] */ /* 0x0000000189769A80-0x0000000189769AA0 */ get => default; } // 0x00000001842E0000-0x00000001842E0140 

	// Constructors
	public ECPDebugInfoAnalyzer() {} // 0x00000001842E0C50-0x00000001842E0D50
	static ECPDebugInfoAnalyzer() {} // 0x00000001842E0BF0-0x00000001842E0C50

	// Methods
	// [IDTag] // 0x0000000189771090-0x00000001897710D0
	// [XID] // 0x0000000189771090-0x00000001897710D0
	public List<BaseEntity> GetAllToStatEntities(IEnumerable<CycleStatLogNode> inCycleStatLogs, bool useFilter) => default; // 0x00000001842E0780-0x00000001842E09D0
	// [IDTag] // 0x000000018977B600-0x000000018977B640
	// [XID] // 0x000000018977B600-0x000000018977B640
	public List<BaseEntity> GetAllToStatEntities(IEnumerable<BaseEntity> inTargetEntities, bool useFilter) => default; // 0x00000001842E09D0-0x00000001842E0BF0
	// [XID] // 0x0000000189785F30-0x0000000189785F50
	public List<BaseEntity.ECPDebugInfo> GetAllDebugInfo(IEnumerable<BaseEntity> inTargetEntities, bool useCategory, bool statGameObject, Comparison<BaseEntity.ECPDebugInfo> comparison) => default; // 0x00000001842E0140-0x00000001842E0780
}


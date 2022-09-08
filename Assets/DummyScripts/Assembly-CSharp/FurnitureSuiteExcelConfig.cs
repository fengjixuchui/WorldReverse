/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class FurnitureSuiteExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15716
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 suiteIDRawNum; // 0x10
	protected string _jsonName; // 0x18
	protected uint _suiteNameTextMapHash; // 0x20
	protected SimpleSafeUInt32 drawingIDRawNum; // 0x24
	protected SimpleSafeUInt32[] _favoriteNpcExcelIdVec; // 0x28
	protected SimpleSafeUInt32[] _furnType; // 0x30
	protected string _itemIcon; // 0x38
	protected string _mapIcon; // 0x40

	// Properties
	public uint suiteID { /* [XID] */ /* 0x00000001898CBF70-0x00000001898CBF90 */ get => default; /* [XID] */ /* 0x00000001898D37B0-0x00000001898D37D0 */ protected set {} } // 0x000000018553DC10-0x000000018553DCE0 0x000000018553DD80-0x000000018553DE60
	public string jsonName { /* [XID] */ /* 0x00000001898DB000-0x00000001898DB020 */ get => default; /* [XID] */ /* 0x00000001898E2CE0-0x00000001898E2D00 */ protected set {} } // 0x000000018553FA90-0x000000018553FB30 0x000000018553F060-0x000000018553F110
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint suiteNameTextMapHash { /* [XID] */ /* 0x00000001898EAA10-0x00000001898EAA30 */ get => default; /* [XID] */ /* 0x00000001898F2170-0x00000001898F2190 */ protected set {} } // 0x000000018553DCE0-0x000000018553DD80 0x000000018553EF00-0x000000018553EFB0
	public string suiteName { /* [XID] */ /* 0x00000001898F98B0-0x00000001898F98D0 */ get => default; } // 0x000000018553F860-0x000000018553F9E0 
	public uint drawingID { /* [XID] */ /* 0x0000000189901210-0x0000000189901230 */ get => default; /* [XID] */ /* 0x0000000189908A90-0x0000000189908AB0 */ protected set {} } // 0x000000018553FBD0-0x000000018553FCA0 0x000000018553DE60-0x000000018553DF40
	public SimpleSafeUInt32[] favoriteNpcExcelIdVec { /* [XID] */ /* 0x0000000189910090-0x00000001899100B0 */ get => default; /* [XID] */ /* 0x0000000189917C20-0x0000000189917C40 */ protected set {} } // 0x000000018553DB70-0x000000018553DC10 0x000000018553EFB0-0x000000018553F060
	public SimpleSafeUInt32[] furnType { /* [XID] */ /* 0x000000018991F140-0x000000018991F160 */ get => default; /* [XID] */ /* 0x0000000189926BA0-0x0000000189926BC0 */ protected set {} } // 0x000000018553D930-0x000000018553D9D0 0x000000018553F9E0-0x000000018553FA90
	public string itemIcon { /* [XID] */ /* 0x000000018992E330-0x000000018992E350 */ get => default; /* [XID] */ /* 0x0000000189935650-0x0000000189935670 */ protected set {} } // 0x000000018553FE90-0x000000018553FF30 0x000000018553D880-0x000000018553D930
	public string mapIcon { /* [XID] */ /* 0x000000018993D190-0x000000018993D1B0 */ get => default; /* [XID] */ /* 0x00000001899448A0-0x00000001899448C0 */ protected set {} } // 0x000000018553FB30-0x000000018553FBD0 0x000000018553FCA0-0x000000018553FD50

	// Constructors
	public FurnitureSuiteExcelConfig() {} // 0x000000018553FFD0-0x0000000185540030

	// Methods
	// [IDTag] // 0x000000018994BE20-0x000000018994BE60
	// [XID] // 0x000000018994BE20-0x000000018994BE60
	public virtual bool ParseFromLine(string line) => default; // 0x000000018553DF40-0x000000018553E730
	// [IDTag] // 0x0000000189956380-0x00000001899563C0
	// [XID] // 0x0000000189956380-0x00000001899563C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018553E730-0x000000018553EF00
	// [XID] // 0x0000000189960DE0-0x0000000189960E00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF240E */, bool useObjectPool = false /* Metadata: 0x00AF2412 */) => default; // 0x000000018553F110-0x000000018553F860
	[BlackList] // 0x0000000189968540-0x0000000189968580
	// [XID] // 0x0000000189968540-0x0000000189968580
	public virtual void AutoAllocTypeFields() {} // 0x000000018553D9D0-0x000000018553DA70
	[BlackList] // 0x0000000189972E90-0x0000000189972ED0
	// [XID] // 0x0000000189972E90-0x0000000189972ED0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018553DA70-0x000000018553DB70
	[BlackList] // 0x000000018997CEF0-0x000000018997CF30
	// [XID] // 0x000000018997CEF0-0x000000018997CF30
	public virtual void ReturnToObjectPool() {} // 0x000000018553FF30-0x000000018553FFD0
	[BlackList] // 0x0000000189987CD0-0x0000000189987D10
	// [XID] // 0x0000000189987CD0-0x0000000189987D10
	public virtual void OnPoolAllocated() {} // 0x000000018553FDF0-0x000000018553FE90
	[BlackList] // 0x0000000189992A30-0x0000000189992A70
	// [XID] // 0x0000000189992A30-0x0000000189992A70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018553FD50-0x000000018553FDF0
}


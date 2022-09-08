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
public class WorldAreaConfig : IAutoAllocRecycle // TypeDefIndex: 16296
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 SceneIDRawNum; // 0x14
	protected WorldAreaType _AreaType; // 0x18
	protected SimpleSafeUInt32 AreaID_1RawNum; // 0x1C
	protected SimpleSafeUInt32 AreaID_2RawNum; // 0x20
	protected bool _AreaDefaultLock; // 0x24
	protected uint _AreaNameTextMapHash; // 0x28
	protected SimpleSafeUInt32 GreyLevelRawNum; // 0x2C
	protected SimpleSafeUInt32 tower_point_idRawNum; // 0x30
	protected ElementType _elementType; // 0x34
	protected AreaTerrainType _terrainType; // 0x38
	protected bool _showTips; // 0x3C
	protected SimpleSafeFloat minimapScaleRawNum; // 0x40

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189B066C0-0x0000000189B066E0 */ get => default; /* [XID] */ /* 0x0000000189B0DD30-0x0000000189B0DD50 */ protected set {} } // 0x00000001840B46A0-0x00000001840B4770 0x00000001840B28C0-0x00000001840B29A0
	public uint SceneID { /* [XID] */ /* 0x0000000189B150F0-0x0000000189B15110 */ get => default; /* [XID] */ /* 0x0000000189B1CB30-0x0000000189B1CB50 */ protected set {} } // 0x00000001840B5720-0x00000001840B57F0 0x00000001840B4440-0x00000001840B4520
	public WorldAreaType AreaType { /* [XID] */ /* 0x0000000189B240A0-0x0000000189B240C0 */ get => default; /* [XID] */ /* 0x0000000189B2B510-0x0000000189B2B530 */ protected set {} } // 0x00000001840B59D0-0x00000001840B5A70 0x00000001840B5670-0x00000001840B5720
	public uint AreaID_1 { /* [XID] */ /* 0x0000000189B32A40-0x0000000189B32A60 */ get => default; /* [XID] */ /* 0x0000000189B3A350-0x0000000189B3A370 */ protected set {} } // 0x00000001840B2BC0-0x00000001840B2C90 0x00000001840B4200-0x00000001840B42E0
	public uint AreaID_2 { /* [XID] */ /* 0x0000000189B41D50-0x0000000189B41D70 */ get => default; /* [XID] */ /* 0x0000000189B496C0-0x0000000189B496E0 */ protected set {} } // 0x00000001840B5360-0x00000001840B5430 0x00000001840B2D70-0x00000001840B2E50
	public bool AreaDefaultLock { /* [XID] */ /* 0x0000000189B50D60-0x0000000189B50D80 */ get => default; /* [XID] */ /* 0x0000000189B58530-0x0000000189B58550 */ protected set {} } // 0x00000001840B4080-0x00000001840B4120 0x00000001840B2810-0x00000001840B28C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint AreaNameTextMapHash { /* [XID] */ /* 0x0000000189B5FEC0-0x0000000189B5FEE0 */ get => default; /* [XID] */ /* 0x0000000189B67620-0x0000000189B67640 */ protected set {} } // 0x00000001840B3F40-0x00000001840B3FE0 0x00000001840B42E0-0x00000001840B4390
	public string AreaName { /* [XID] */ /* 0x0000000189B6E860-0x0000000189B6E880 */ get => default; } // 0x00000001840B4520-0x00000001840B46A0 
	public uint GreyLevel { /* [XID] */ /* 0x0000000189B76110-0x0000000189B76130 */ get => default; /* [XID] */ /* 0x0000000189B7D5E0-0x0000000189B7D600 */ protected set {} } // 0x00000001840B2E50-0x00000001840B2F20 0x00000001840B2C90-0x00000001840B2D70
	public uint tower_point_id { /* [XID] */ /* 0x0000000189B85310-0x0000000189B85330 */ get => default; /* [XID] */ /* 0x0000000189B8C120-0x0000000189B8C140 */ protected set {} } // 0x00000001840B2F20-0x00000001840B2FF0 0x00000001840B54E0-0x00000001840B55C0
	public ElementType elementType { /* [XID] */ /* 0x0000000189B93950-0x0000000189B93970 */ get => default; /* [XID] */ /* 0x0000000189B9AF40-0x0000000189B9AF60 */ protected set {} } // 0x00000001840B3FE0-0x00000001840B4080 0x00000001840B55C0-0x00000001840B5670
	public AreaTerrainType terrainType { /* [XID] */ /* 0x0000000189BA2790-0x0000000189BA27B0 */ get => default; /* [XID] */ /* 0x0000000189BA9B80-0x0000000189BA9BA0 */ protected set {} } // 0x00000001840B5930-0x00000001840B59D0 0x00000001840B4390-0x00000001840B4440
	public bool showTips { /* [XID] */ /* 0x0000000189BB1490-0x0000000189BB14B0 */ get => default; /* [XID] */ /* 0x0000000189BB8460-0x0000000189BB8480 */ protected set {} } // 0x00000001840B4770-0x00000001840B4810 0x00000001840B5430-0x00000001840B54E0
	public float minimapScale { /* [XID] */ /* 0x0000000189BBFD10-0x0000000189BBFD30 */ get => default; /* [XID] */ /* 0x0000000189BC7760-0x0000000189BC7780 */ protected set {} } // 0x00000001840B5280-0x00000001840B5360 0x00000001840B4120-0x00000001840B4200

	// Constructors
	public WorldAreaConfig() {} // 0x00000001840B5B10-0x00000001840B5B70

	// Methods
	// [IDTag] // 0x0000000189BCF370-0x0000000189BCF3B0
	// [XID] // 0x0000000189BCF370-0x0000000189BCF3B0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001840B37A0-0x00000001840B3F40
	// [IDTag] // 0x0000000189BD9840-0x0000000189BD9880
	// [XID] // 0x0000000189BD9840-0x0000000189BD9880
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001840B2FF0-0x00000001840B37A0
	// [XID] // 0x00000001895E9450-0x00000001895E9470
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF36E3 */, bool useObjectPool = false /* Metadata: 0x00AF36E7 */) => default; // 0x00000001840B4810-0x00000001840B5280
	[BlackList] // 0x00000001895F0C80-0x00000001895F0CC0
	// [XID] // 0x00000001895F0C80-0x00000001895F0CC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001840B29A0-0x00000001840B2A40
	[BlackList] // 0x00000001895FB510-0x00000001895FB550
	// [XID] // 0x00000001895FB510-0x00000001895FB550
	public virtual void AutoRecycleTypeFields() {} // 0x00000001840B2A40-0x00000001840B2BC0
	[BlackList] // 0x0000000189605C90-0x0000000189605CD0
	// [XID] // 0x0000000189605C90-0x0000000189605CD0
	public virtual void ReturnToObjectPool() {} // 0x00000001840B5A70-0x00000001840B5B10
	[BlackList] // 0x00000001896105F0-0x0000000189610630
	// [XID] // 0x00000001896105F0-0x0000000189610630
	public virtual void OnPoolAllocated() {} // 0x00000001840B5890-0x00000001840B5930
	[BlackList] // 0x000000018961ABA0-0x000000018961ABE0
	// [XID] // 0x000000018961ABA0-0x000000018961ABE0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840B57F0-0x00000001840B5890
}


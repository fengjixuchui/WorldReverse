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
public class CityConfig : IAutoAllocRecycle // TypeDefIndex: 16306
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 cityIdRawNum; // 0x10
	protected SimpleSafeUInt32 sceneIdRawNum; // 0x14
	protected SimpleSafeUInt32[] _areaIdVec; // 0x18
	protected uint _cityNameTextMapHash; // 0x20
	protected SimpleSafeInt32 mapPosXRawNum; // 0x24
	protected SimpleSafeInt32 mapPosYRawNum; // 0x28
	protected SimpleSafeFloat zoomForExplorationRawNum; // 0x2C
	protected SimpleSafeUInt32 adventurePointIdRawNum; // 0x30
	protected string _ExpeditionMap; // 0x38
	protected string _ExpeditionWaterMark; // 0x40
	protected OpenStateType _openState; // 0x48
	protected uint _cityGoddnessNameTextMapHash; // 0x4C
	protected uint _cityGoddnessDescTextMapHash; // 0x50

	// Properties
	public uint cityId { /* [XID] */ /* 0x00000001899DB120-0x00000001899DB140 */ get => default; /* [XID] */ /* 0x0000000189B58510-0x0000000189B58530 */ protected set {} } // 0x000000018401B2D0-0x000000018401B3A0 0x0000000184019DB0-0x0000000184019E90
	public uint sceneId { /* [XID] */ /* 0x000000018999DB40-0x000000018999DB60 */ get => default; /* [XID] */ /* 0x0000000189B67600-0x0000000189B67620 */ protected set {} } // 0x000000018401A250-0x000000018401A320 0x000000018401AF10-0x000000018401AFF0
	public SimpleSafeUInt32[] areaIdVec { /* [XID] */ /* 0x0000000189B6E840-0x0000000189B6E860 */ get => default; /* [XID] */ /* 0x0000000189B760F0-0x0000000189B76110 */ protected set {} } // 0x0000000184018430-0x00000001840184D0 0x000000018401AD90-0x000000018401AE40
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cityNameTextMapHash { /* [XID] */ /* 0x0000000189B7D5C0-0x0000000189B7D5E0 */ get => default; /* [XID] */ /* 0x0000000189B852F0-0x0000000189B85310 */ protected set {} } // 0x0000000184018160-0x0000000184018200 0x00000001840184D0-0x0000000184018580
	public string cityName { /* [XID] */ /* 0x0000000189B8C100-0x0000000189B8C120 */ get => default; } // 0x0000000184019970-0x0000000184019AF0 
	public int mapPosX { /* [XID] */ /* 0x0000000189B93930-0x0000000189B93950 */ get => default; /* [XID] */ /* 0x0000000189B9AF20-0x0000000189B9AF40 */ protected set {} } // 0x000000018401AE40-0x000000018401AF10 0x000000018401A170-0x000000018401A250
	public int mapPosY { /* [XID] */ /* 0x0000000189BA2770-0x0000000189BA2790 */ get => default; /* [XID] */ /* 0x0000000189BA9B60-0x0000000189BA9B80 */ protected set {} } // 0x0000000184017D90-0x0000000184017E60 0x000000018401B4E0-0x000000018401B5C0
	public float zoomForExploration { /* [XID] */ /* 0x0000000189BB1470-0x0000000189BB1490 */ get => default; /* [XID] */ /* 0x0000000189BB8440-0x0000000189BB8460 */ protected set {} } // 0x0000000184018350-0x0000000184018430 0x0000000184019F40-0x000000018401A020
	public uint adventurePointId { /* [XID] */ /* 0x0000000189BBFCF0-0x0000000189BBFD10 */ get => default; /* [XID] */ /* 0x0000000189BC7740-0x0000000189BC7760 */ protected set {} } // 0x0000000184018090-0x0000000184018160 0x0000000184019890-0x0000000184019970
	public string ExpeditionMap { /* [XID] */ /* 0x0000000189BCF350-0x0000000189BCF370 */ get => default; /* [XID] */ /* 0x0000000189BD66C0-0x0000000189BD66E0 */ protected set {} } // 0x0000000184019B90-0x0000000184019C30 0x0000000184019E90-0x0000000184019F40
	public string ExpeditionWaterMark { /* [XID] */ /* 0x0000000189BDE340-0x0000000189BDE360 */ get => default; /* [XID] */ /* 0x00000001895EAEB0-0x00000001895EAED0 */ protected set {} } // 0x00000001840197F0-0x0000000184019890 0x000000018401A0C0-0x000000018401A170
	public OpenStateType openState { /* [XID] */ /* 0x00000001895F2350-0x00000001895F2370 */ get => default; /* [XID] */ /* 0x00000001895F9CE0-0x00000001895F9D00 */ protected set {} } // 0x00000001840182B0-0x0000000184018350 0x000000018401B0A0-0x000000018401B150
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cityGoddnessNameTextMapHash { /* [XID] */ /* 0x0000000189601560-0x0000000189601580 */ get => default; /* [XID] */ /* 0x0000000189608DF0-0x0000000189608E10 */ protected set {} } // 0x000000018401A020-0x000000018401A0C0 0x000000018401AFF0-0x000000018401B0A0
	public string cityGoddnessName { /* [XID] */ /* 0x00000001896105D0-0x00000001896105F0 */ get => default; } // 0x000000018401B150-0x000000018401B2D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cityGoddnessDescTextMapHash { /* [XID] */ /* 0x0000000189617910-0x0000000189617930 */ get => default; /* [XID] */ /* 0x000000018961F520-0x000000018961F540 */ protected set {} } // 0x0000000184019AF0-0x0000000184019B90 0x0000000184018200-0x00000001840182B0
	public string cityGoddnessDesc { /* [XID] */ /* 0x0000000189626960-0x0000000189626980 */ get => default; } // 0x0000000184019C30-0x0000000184019DB0 

	// Constructors
	public CityConfig() {} // 0x000000018401B660-0x000000018401B6C0

	// Methods
	// [IDTag] // 0x000000018962E190-0x000000018962E1D0
	// [XID] // 0x000000018962E190-0x000000018962E1D0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184018EC0-0x00000001840197F0
	// [IDTag] // 0x0000000189638D50-0x0000000189638D90
	// [XID] // 0x0000000189638D50-0x0000000189638D90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184018580-0x0000000184018EC0
	// [XID] // 0x0000000189643360-0x0000000189643380
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3724 */, bool useObjectPool = false /* Metadata: 0x00AF3728 */) => default; // 0x000000018401A320-0x000000018401AD90
	[BlackList] // 0x000000018964A980-0x000000018964A9C0
	// [XID] // 0x000000018964A980-0x000000018964A9C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184017E60-0x0000000184017F00
	[BlackList] // 0x0000000189655260-0x00000001896552A0
	// [XID] // 0x0000000189655260-0x00000001896552A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184017F00-0x0000000184018090
	[BlackList] // 0x000000018965F800-0x000000018965F840
	// [XID] // 0x000000018965F800-0x000000018965F840
	public virtual void ReturnToObjectPool() {} // 0x000000018401B5C0-0x000000018401B660
	[BlackList] // 0x000000018966A300-0x000000018966A340
	// [XID] // 0x000000018966A300-0x000000018966A340
	public virtual void OnPoolAllocated() {} // 0x000000018401B440-0x000000018401B4E0
	[BlackList] // 0x0000000189674D50-0x0000000189674D90
	// [XID] // 0x0000000189674D50-0x0000000189674D90
	public virtual void OnBeforePoolRecycled() {} // 0x000000018401B3A0-0x000000018401B440
}


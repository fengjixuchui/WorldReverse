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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigGlobalHit : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18095
{
	// Fields
	private SimpleSafeFloat minHitVXRawNum; // 0x10
	private SimpleSafeFloat maxHitVXRawNum; // 0x14
	private SimpleSafeFloat minHitVYRawNum; // 0x18
	private SimpleSafeFloat maxHitVYRawNum; // 0x1C
	private SimpleSafeFloat gravityRawNum; // 0x20
	private SimpleSafeFloat hitRetreatFrictionRawNum; // 0x24
	private SimpleSafeFloat airFrictionXRawNum; // 0x28
	private SimpleSafeFloat airFrictionYRawNum; // 0x2C
	private SimpleSafeFloat dieRetreatRatioRawNum; // 0x30
	private SimpleSafeFloat dieRetreatLightRatioRawNum; // 0x34
	private SimpleSafeFloat dieRetreatHeavyRatioRawNum; // 0x38
	private SimpleSafeFloat dieRetreatAddRawNum; // 0x3C
	private SimpleSafeFloat dieRetreatHeavyAddRawNum; // 0x40
	private SimpleSafeFloat dieRetreatAirXAddRawNum; // 0x44
	private SimpleSafeFloat dieRetreatAirYAddRawNum; // 0x48

	// Properties
	public float minHitVX { /* [XID] */ /* 0x000000018988F760-0x000000018988F780 */ get => default; /* [XID] */ /* 0x0000000189AC24E0-0x0000000189AC2500 */ private set {} } // 0x0000000184E9F130-0x0000000184E9F210 0x0000000184E9EF70-0x0000000184E9F050
	public float maxHitVX { /* [XID] */ /* 0x00000001899C0450-0x00000001899C0470 */ get => default; /* [XID] */ /* 0x0000000189AD13F0-0x0000000189AD1410 */ private set {} } // 0x0000000184EA0390-0x0000000184EA0470 0x0000000184EA0F40-0x0000000184EA1020
	public float minHitVY { /* [XID] */ /* 0x0000000189896C80-0x0000000189896CA0 */ get => default; /* [XID] */ /* 0x0000000189AE0BE0-0x0000000189AE0C00 */ private set {} } // 0x0000000184E9FE50-0x0000000184E9FF30 0x0000000184E9FD70-0x0000000184E9FE50
	public float maxHitVY { /* [XID] */ /* 0x000000018989E120-0x000000018989E140 */ get => default; /* [XID] */ /* 0x0000000189AEFFD0-0x0000000189AEFFF0 */ private set {} } // 0x0000000184E9F050-0x0000000184E9F130 0x0000000184EA1480-0x0000000184EA1560
	public float gravity { /* [XID] */ /* 0x0000000189AF7460-0x0000000189AF7480 */ get => default; /* [XID] */ /* 0x0000000189AFEB10-0x0000000189AFEB30 */ private set {} } // 0x0000000184EA1020-0x0000000184EA1100 0x0000000184EA1100-0x0000000184EA11E0
	public float hitRetreatFriction { /* [XID] */ /* 0x0000000189B062A0-0x0000000189B062C0 */ get => default; /* [XID] */ /* 0x0000000189B0DA50-0x0000000189B0DA70 */ private set {} } // 0x0000000184EA07F0-0x0000000184EA08D0 0x0000000184E9FF30-0x0000000184EA0010
	public float airFrictionX { /* [XID] */ /* 0x0000000189B14E70-0x0000000189B14E90 */ get => default; /* [XID] */ /* 0x0000000189B1C810-0x0000000189B1C830 */ private set {} } // 0x0000000184EA2420-0x0000000184EA2500 0x0000000184EA0710-0x0000000184EA07F0
	public float airFrictionY { /* [XID] */ /* 0x0000000189B23DA0-0x0000000189B23DC0 */ get => default; /* [XID] */ /* 0x0000000189B2B0A0-0x0000000189B2B0C0 */ private set {} } // 0x0000000184EA1FA0-0x0000000184EA2080 0x0000000184E9EA30-0x0000000184E9EB10
	public float dieRetreatRatio { /* [XID] */ /* 0x0000000189B3AC10-0x0000000189B3AC30 */ get => default; /* [XID] */ /* 0x0000000189B39FD0-0x0000000189B39FF0 */ private set {} } // 0x0000000184EA0A80-0x0000000184EA0B60 0x0000000184EA0E60-0x0000000184EA0F40
	public float dieRetreatLightRatio { /* [XID] */ /* 0x0000000189B515E0-0x0000000189B51600 */ get => default; /* [XID] */ /* 0x0000000189B493A0-0x0000000189B493C0 */ private set {} } // 0x0000000184EA13A0-0x0000000184EA1480 0x0000000184E9EB10-0x0000000184E9EBF0
	public float dieRetreatHeavyRatio { /* [XID] */ /* 0x0000000189B50960-0x0000000189B50980 */ get => default; /* [XID] */ /* 0x0000000189B58280-0x0000000189B582A0 */ private set {} } // 0x0000000184E9ECD0-0x0000000184E9EDB0 0x0000000184EA11E0-0x0000000184EA12C0
	public float dieRetreatAdd { /* [XID] */ /* 0x0000000189B5FB60-0x0000000189B5FB80 */ get => default; /* [XID] */ /* 0x0000000189B67220-0x0000000189B67240 */ private set {} } // 0x0000000184EA0550-0x0000000184EA0630 0x0000000184EA1560-0x0000000184EA1640
	public float dieRetreatHeavyAdd { /* [XID] */ /* 0x0000000189B6E4C0-0x0000000189B6E4E0 */ get => default; /* [XID] */ /* 0x0000000189B75C90-0x0000000189B75CB0 */ private set {} } // 0x0000000184E9EE90-0x0000000184E9EF70 0x0000000184E9EDB0-0x0000000184E9EE90
	public float dieRetreatAirXAdd { /* [XID] */ /* 0x0000000189B7D120-0x0000000189B7D140 */ get => default; /* [XID] */ /* 0x0000000189B84F30-0x0000000189B84F50 */ private set {} } // 0x0000000184EA0470-0x0000000184EA0550 0x0000000184EA12C0-0x0000000184EA13A0
	public float dieRetreatAirYAdd { /* [XID] */ /* 0x00000001896002D0-0x00000001896002F0 */ get => default; /* [XID] */ /* 0x0000000189B93570-0x0000000189B93590 */ private set {} } // 0x0000000184E9EBF0-0x0000000184E9ECD0 0x0000000184EA0630-0x0000000184EA0710

	// Constructors
	public ConfigGlobalHit() {} // 0x0000000184EA25A0-0x0000000184EA2600

	// Methods
	// [XID] // 0x0000000189B9AB20-0x0000000189B9AB40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184EA2080-0x0000000184EA22E0
	// [XID] // 0x0000000189BA2310-0x0000000189BA2330
	public void InitEmpty() {} // 0x0000000184EA08D0-0x0000000184EA0A80
	[BlackList] // 0x0000000189BA9740-0x0000000189BA9780
	// [XID] // 0x0000000189BA9740-0x0000000189BA9780
	public bool FromJson(JSONNode node) => default; // 0x0000000184EA0010-0x0000000184EA0390
	// [XID] // 0x0000000189BB3CD0-0x0000000189BB3CF0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184E9D340-0x0000000184E9E4E0
	// [XID] // 0x0000000189BBB270-0x0000000189BBB290
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8ACD */, bool useObjectPool = false /* Metadata: 0x00AF8AD1 */) => default; // 0x0000000184EA0B60-0x0000000184EA0E60
	// [XID] // 0x0000000189BC30D0-0x0000000189BC30F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AD2 */, bool useObjectPool = false /* Metadata: 0x00AF8AD6 */) => default; // 0x0000000184E9F210-0x0000000184E9FD70
	[BlackList] // 0x0000000189BCA930-0x0000000189BCA970
	// [XID] // 0x0000000189BCA930-0x0000000189BCA970
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184E9E4E0-0x0000000184E9E7B0
	// [XID] // 0x0000000189BD4D10-0x0000000189BD4D30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184EA1640-0x0000000184EA1FA0
	[BlackList] // 0x0000000189BDC7E0-0x0000000189BDC820
	// [XID] // 0x0000000189BDC7E0-0x0000000189BDC820
	public virtual void AutoAllocTypeFields() {} // 0x0000000184E9E7B0-0x0000000184E9E850
	[BlackList] // 0x00000001895EC2D0-0x00000001895EC310
	// [XID] // 0x00000001895EC2D0-0x00000001895EC310
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184E9E850-0x0000000184E9EA30
	[BlackList] // 0x00000001895F6B80-0x00000001895F6BC0
	// [XID] // 0x00000001895F6B80-0x00000001895F6BC0
	public virtual void ReturnToObjectPool() {} // 0x0000000184EA2500-0x0000000184EA25A0
	[BlackList] // 0x00000001896010A0-0x00000001896010E0
	// [XID] // 0x00000001896010A0-0x00000001896010E0
	public virtual void OnPoolAllocated() {} // 0x0000000184EA2380-0x0000000184EA2420
	[BlackList] // 0x000000018960BA40-0x000000018960BA80
	// [XID] // 0x000000018960BA40-0x000000018960BA80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184EA22E0-0x0000000184EA2380
}


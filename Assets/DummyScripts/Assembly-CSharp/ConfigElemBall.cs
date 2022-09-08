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
public class ConfigElemBall : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19115
{
	// Fields
	private ElemBallTriggerType _type; // 0x10
	private ElementType _elementType; // 0x14
	private SimpleSafeInt32 curMaxNumRawNum; // 0x18
	private SimpleSafeFloat[] _intervalTimes; // 0x20
	private SimpleSafeUInt32[] _dropItems; // 0x28
	private SimpleSafeUInt32[] _dropCounts; // 0x30
	private SimpleSafeInt32 maxNumRawNum; // 0x38
	private SimpleSafeFloat poissonDiskRawNum; // 0x3C
	private SimpleSafeFloat minRadiusRawNum; // 0x40
	private SimpleSafeFloat maxRadiusRawNum; // 0x44

	// Properties
	public ElemBallTriggerType type { /* [XID] */ /* 0x0000000189B38430-0x0000000189B38450 */ get => default; /* [XID] */ /* 0x0000000189B3FE20-0x0000000189B3FE40 */ private set {} } // 0x0000000183EDF5A0-0x0000000183EDF640 0x0000000183EDE700-0x0000000183EDE7B0
	public ElementType elementType { /* [XID] */ /* 0x0000000189B47680-0x0000000189B476A0 */ get => default; /* [XID] */ /* 0x0000000189B4EE10-0x0000000189B4EE30 */ private set {} } // 0x0000000183EDD640-0x0000000183EDD6E0 0x0000000183EDE490-0x0000000183EDE540
	public int curMaxNum { /* [XID] */ /* 0x0000000189B56830-0x0000000189B56850 */ get => default; /* [XID] */ /* 0x0000000189B5E000-0x0000000189B5E020 */ private set {} } // 0x0000000183EDE3C0-0x0000000183EDE490 0x0000000183EDDB10-0x0000000183EDDBF0
	public SimpleSafeFloat[] intervalTimes { /* [XID] */ /* 0x0000000189B654C0-0x0000000189B654E0 */ get => default; /* [XID] */ /* 0x0000000189B6CB00-0x0000000189B6CB20 */ private set {} } // 0x0000000183EDCCD0-0x0000000183EDCD70 0x0000000183EDE890-0x0000000183EDE940
	public SimpleSafeUInt32[] dropItems { /* [XID] */ /* 0x0000000189B742D0-0x0000000189B742F0 */ get => default; /* [XID] */ /* 0x0000000189B7B890-0x0000000189B7B8B0 */ private set {} } // 0x0000000183EDBE80-0x0000000183EDBF20 0x0000000183EDDA60-0x0000000183EDDB10
	public SimpleSafeUInt32[] dropCounts { /* [XID] */ /* 0x0000000189B83200-0x0000000189B83220 */ get => default; /* [XID] */ /* 0x0000000189B8A710-0x0000000189B8A730 */ private set {} } // 0x0000000183EDDD90-0x0000000183EDDE30 0x0000000183EDBF20-0x0000000183EDBFD0
	public int maxNum { /* [XID] */ /* 0x0000000189B91D00-0x0000000189B91D20 */ get => default; /* [XID] */ /* 0x0000000189B99200-0x0000000189B99220 */ private set {} } // 0x0000000183EDE210-0x0000000183EDE2E0 0x0000000183EDF0C0-0x0000000183EDF1A0
	public float poissonDisk { /* [XID] */ /* 0x0000000189BA0610-0x0000000189BA0630 */ get => default; /* [XID] */ /* 0x0000000189BA7E10-0x0000000189BA7E30 */ private set {} } // 0x0000000183EDE540-0x0000000183EDE620 0x0000000183EDE7B0-0x0000000183EDE890
	public float minRadius { /* [XID] */ /* 0x0000000189BAF2C0-0x0000000189BAF2E0 */ get => default; /* [XID] */ /* 0x0000000189BB68B0-0x0000000189BB68D0 */ private set {} } // 0x0000000183EDDE30-0x0000000183EDDF10 0x0000000183EDF4C0-0x0000000183EDF5A0
	public float maxRadius { /* [XID] */ /* 0x0000000189BBDF30-0x0000000189BBDF50 */ get => default; /* [XID] */ /* 0x0000000189BC5BE0-0x0000000189BC5C00 */ private set {} } // 0x0000000183EDE2E0-0x0000000183EDE3C0 0x0000000183EDE620-0x0000000183EDE700

	// Constructors
	public ConfigElemBall() {} // 0x0000000183EDF6E0-0x0000000183EDF7E0

	// Methods
	// [XID] // 0x0000000189BCD640-0x0000000189BCD660
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183EDF1A0-0x0000000183EDF380
	// [XID] // 0x0000000189BD4B90-0x0000000189BD4BB0
	public void InitEmpty() {} // 0x0000000183EDDBF0-0x0000000183EDDD90
	[BlackList] // 0x0000000189BDC620-0x0000000189BDC660
	// [XID] // 0x0000000189BDC620-0x0000000189BDC660
	public bool FromJson(JSONNode node) => default; // 0x0000000183EDD6E0-0x0000000183EDDA60
	// [XID] // 0x00000001895EC170-0x00000001895EC190
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183EDBFD0-0x0000000183EDCA00
	// [XID] // 0x00000001895F3650-0x00000001895F3670
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC275 */, bool useObjectPool = false /* Metadata: 0x00AFC279 */) => default; // 0x0000000183EDDF10-0x0000000183EDE210
	// [XID] // 0x00000001895FAF70-0x00000001895FAF90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC27A */, bool useObjectPool = false /* Metadata: 0x00AFC27E */) => default; // 0x0000000183EDCF60-0x0000000183EDD640
	[BlackList] // 0x0000000189602790-0x00000001896027D0
	// [XID] // 0x0000000189602790-0x00000001896027D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183EDCA00-0x0000000183EDCCD0
	// [XID] // 0x000000018960CF00-0x000000018960CF20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183EDE940-0x0000000183EDF0C0
	[BlackList] // 0x0000000189614580-0x00000001896145C0
	// [XID] // 0x0000000189614580-0x00000001896145C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183EDCD70-0x0000000183EDCE10
	[BlackList] // 0x000000018961EFE0-0x000000018961F020
	// [XID] // 0x000000018961EFE0-0x000000018961F020
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183EDCE10-0x0000000183EDCF60
	[BlackList] // 0x00000001896295D0-0x0000000189629610
	// [XID] // 0x00000001896295D0-0x0000000189629610
	public virtual void ReturnToObjectPool() {} // 0x0000000183EDF640-0x0000000183EDF6E0
	[BlackList] // 0x0000000189633E90-0x0000000189633ED0
	// [XID] // 0x0000000189633E90-0x0000000189633ED0
	public virtual void OnPoolAllocated() {} // 0x0000000183EDF420-0x0000000183EDF4C0
	[BlackList] // 0x000000018963E5A0-0x000000018963E5E0
	// [XID] // 0x000000018963E5A0-0x000000018963E5E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183EDF380-0x0000000183EDF420
}


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
public class AudioAmbiencePositionedEvent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17545
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _eventName; // 0x10
	private SimpleSafeFloat minInitDelayRawNum; // 0x18
	private SimpleSafeFloat maxInitDelayRawNum; // 0x1C
	private SimpleSafeFloat minIntervalRawNum; // 0x20
	private SimpleSafeFloat maxIntervalRawNum; // 0x24

	// Properties
	public ConfigWwiseString eventName { /* [XID] */ /* 0x000000018993F080-0x000000018993F0A0 */ get => default; /* [XID] */ /* 0x0000000189654FE0-0x0000000189655000 */ private set {} } // 0x0000000182956720-0x00000001829567C0 0x0000000182956210-0x00000001829562C0
	public float minInitDelay { /* [XID] */ /* 0x00000001897E9900-0x00000001897E9920 */ get => default; /* [XID] */ /* 0x0000000189663DC0-0x0000000189663DE0 */ private set {} } // 0x0000000182956DC0-0x0000000182956EA0 0x0000000182955680-0x0000000182955760
	public float maxInitDelay { /* [XID] */ /* 0x000000018966B500-0x000000018966B520 */ get => default; /* [XID] */ /* 0x0000000189673220-0x0000000189673240 */ private set {} } // 0x0000000182956640-0x0000000182956720 0x0000000182956900-0x00000001829569E0
	public float minInterval { /* [XID] */ /* 0x000000018967A920-0x000000018967A940 */ get => default; /* [XID] */ /* 0x00000001896821F0-0x0000000189682210 */ private set {} } // 0x0000000182954F10-0x0000000182954FF0 0x0000000182956CE0-0x0000000182956DC0
	public float maxInterval { /* [XID] */ /* 0x0000000189689BF0-0x0000000189689C10 */ get => default; /* [XID] */ /* 0x0000000189691A70-0x0000000189691A90 */ private set {} } // 0x0000000182955C60-0x0000000182955D40 0x0000000182957550-0x0000000182957630

	// Constructors
	public AudioAmbiencePositionedEvent() {} // 0x00000001829576D0-0x0000000182957730

	// Methods
	// [XID] // 0x0000000189698FE0-0x0000000189699000
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829572A0-0x0000000182957410
	// [XID] // 0x00000001896A0590-0x00000001896A05B0
	public void InitEmpty() {} // 0x00000001829567C0-0x0000000182956900
	[BlackList] // 0x00000001896A7A80-0x00000001896A7AC0
	// [XID] // 0x00000001896A7A80-0x00000001896A7AC0
	public bool FromJson(JSONNode node) => default; // 0x00000001829562C0-0x0000000182956640
	// [XID] // 0x00000001896B18D0-0x00000001896B18F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182954FF0-0x0000000182955680
	// [XID] // 0x00000001896B92D0-0x00000001896B92F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7269 */, bool useObjectPool = false /* Metadata: 0x00AF726D */) => default; // 0x00000001829569E0-0x0000000182956CE0
	// [XID] // 0x00000001896C06E0-0x00000001896C0700
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF726E */, bool useObjectPool = false /* Metadata: 0x00AF7272 */) => default; // 0x0000000182955D40-0x0000000182956210
	[BlackList] // 0x00000001896C7DD0-0x00000001896C7E10
	// [XID] // 0x00000001896C7DD0-0x00000001896C7E10
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182955760-0x0000000182955A30
	// [XID] // 0x00000001896D21E0-0x00000001896D2200
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182956EA0-0x00000001829572A0
	[BlackList] // 0x00000001896D9B50-0x00000001896D9B90
	// [XID] // 0x00000001896D9B50-0x00000001896D9B90
	public virtual void AutoAllocTypeFields() {} // 0x0000000182955A30-0x0000000182955AD0
	[BlackList] // 0x00000001896E4110-0x00000001896E4150
	// [XID] // 0x00000001896E4110-0x00000001896E4150
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182955AD0-0x0000000182955C60
	[BlackList] // 0x00000001896EE350-0x00000001896EE390
	// [XID] // 0x00000001896EE350-0x00000001896EE390
	public virtual void ReturnToObjectPool() {} // 0x0000000182957630-0x00000001829576D0
	[BlackList] // 0x00000001896F87E0-0x00000001896F8820
	// [XID] // 0x00000001896F87E0-0x00000001896F8820
	public virtual void OnPoolAllocated() {} // 0x00000001829574B0-0x0000000182957550
	[BlackList] // 0x00000001897031B0-0x00000001897031F0
	// [XID] // 0x00000001897031B0-0x00000001897031F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182957410-0x00000001829574B0
}


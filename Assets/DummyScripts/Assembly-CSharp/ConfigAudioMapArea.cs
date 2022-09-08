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
public class ConfigAudioMapArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17592
{
	// Fields
	private SimpleSafeUInt32 idRawNum; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stateValue; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _subStateGroup; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _defaultSubStateValue; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWwiseString[] _eventsOnEnter; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWwiseString[] _eventsOnExit; // 0x38

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898878C0-0x00000001898878E0 */ get => default; /* [XID] */ /* 0x000000018988EBE0-0x000000018988EC00 */ private set {} } // 0x0000000183B7FCE0-0x0000000183B7FDB0 0x0000000183B7EED0-0x0000000183B7EFB0
	public ConfigWwiseString stateValue { /* [XID] */ /* 0x0000000189896100-0x0000000189896120 */ get => default; /* [XID] */ /* 0x000000018989D700-0x000000018989D720 */ private set {} } // 0x0000000183B7F950-0x0000000183B7F9F0 0x0000000183B7F8A0-0x0000000183B7F950
	public ConfigWwiseString subStateGroup { /* [XID] */ /* 0x00000001898A5100-0x00000001898A5120 */ get => default; /* [XID] */ /* 0x00000001898AC560-0x00000001898AC580 */ private set {} } // 0x0000000183B7EC40-0x0000000183B7ECE0 0x0000000183B7E030-0x0000000183B7E0E0
	public ConfigWwiseString defaultSubStateValue { /* [XID] */ /* 0x00000001898B3B20-0x00000001898B3B40 */ get => default; /* [XID] */ /* 0x00000001898BB8D0-0x00000001898BB8F0 */ private set {} } // 0x0000000183B7E240-0x0000000183B7E2E0 0x0000000183B7E190-0x0000000183B7E240
	public ConfigWwiseString[] eventsOnEnter { /* [XID] */ /* 0x00000001898C2B80-0x00000001898C2BA0 */ get => default; /* [XID] */ /* 0x00000001898CA540-0x00000001898CA560 */ private set {} } // 0x0000000183B7F2B0-0x0000000183B7F350 0x0000000183B7D9B0-0x0000000183B7DA60
	public ConfigWwiseString[] eventsOnExit { /* [XID] */ /* 0x00000001898D1DD0-0x00000001898D1DF0 */ get => default; /* [XID] */ /* 0x00000001898D9610-0x00000001898D9630 */ private set {} } // 0x0000000183B7ECE0-0x0000000183B7ED80 0x0000000183B7E0E0-0x0000000183B7E190

	// Constructors
	public ConfigAudioMapArea() {} // 0x0000000183B7FE50-0x0000000183B7FEB0

	// Methods
	// [XID] // 0x00000001898E12E0-0x00000001898E1300
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B7F9F0-0x0000000183B7FBA0
	// [XID] // 0x00000001898E8D00-0x00000001898E8D20
	public void InitEmpty() {} // 0x0000000183B7ED80-0x0000000183B7EED0
	[BlackList] // 0x00000001898F0440-0x00000001898F0480
	// [XID] // 0x00000001898F0440-0x00000001898F0480
	public bool FromJson(JSONNode node) => default; // 0x0000000183B7E8C0-0x0000000183B7EC40
	// [XID] // 0x00000001898FAAE0-0x00000001898FAB00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183B7D2D0-0x0000000183B7D9B0
	// [XID] // 0x00000001899026A0-0x00000001899026C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF740B */, bool useObjectPool = false /* Metadata: 0x00AF740F */) => default; // 0x0000000183B7EFB0-0x0000000183B7F2B0
	// [XID] // 0x0000000189909C80-0x0000000189909CA0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7410 */, bool useObjectPool = false /* Metadata: 0x00AF7414 */) => default; // 0x0000000183B7E2E0-0x0000000183B7E8C0
	[BlackList] // 0x00000001899114A0-0x00000001899114E0
	// [XID] // 0x00000001899114A0-0x00000001899114E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B7DA60-0x0000000183B7DD30
	// [XID] // 0x000000018991C180-0x000000018991C1A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B7F350-0x0000000183B7F8A0
	[BlackList] // 0x0000000189923860-0x00000001899238A0
	// [XID] // 0x0000000189923860-0x00000001899238A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B7DD30-0x0000000183B7DDD0
	[BlackList] // 0x000000018992DEB0-0x000000018992DEF0
	// [XID] // 0x000000018992DEB0-0x000000018992DEF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B7DDD0-0x0000000183B7E030
	[BlackList] // 0x0000000189938290-0x00000001899382D0
	// [XID] // 0x0000000189938290-0x00000001899382D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183B7FDB0-0x0000000183B7FE50
	[BlackList] // 0x0000000189942950-0x0000000189942990
	// [XID] // 0x0000000189942950-0x0000000189942990
	public virtual void OnPoolAllocated() {} // 0x0000000183B7FC40-0x0000000183B7FCE0
	[BlackList] // 0x000000018994D0D0-0x000000018994D110
	// [XID] // 0x000000018994D0D0-0x000000018994D110
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B7FBA0-0x0000000183B7FC40
}


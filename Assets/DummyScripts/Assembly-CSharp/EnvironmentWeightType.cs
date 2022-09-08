/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class EnvironmentWeightType : IAutoAllocRecycle // TypeDefIndex: 15573
{
	// Fields
	protected SimpleSafeUInt32 animalIdRawNum; // 0x10
	protected EntityType _entityType; // 0x14
	protected SimpleSafeUInt32 weightRawNum; // 0x18
	protected Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> _aliveHourMap; // 0x20

	// Properties
	public uint animalId { /* [XID] */ /* 0x0000000189B38A50-0x0000000189B38A70 */ get => default; /* [XID] */ /* 0x0000000189B403C0-0x0000000189B403E0 */ protected set {} } // 0x0000000181544EC0-0x0000000181544F90 0x0000000181543E90-0x0000000181543F70
	public EntityType entityType { /* [XID] */ /* 0x0000000189B47C80-0x0000000189B47CA0 */ get => default; /* [XID] */ /* 0x0000000189B4F570-0x0000000189B4F590 */ protected set {} } // 0x00000001815447E0-0x0000000181544880 0x00000001815441A0-0x0000000181544250
	public uint weight { /* [XID] */ /* 0x0000000189B56E50-0x0000000189B56E70 */ get => default; /* [XID] */ /* 0x0000000189B5E760-0x0000000189B5E780 */ protected set {} } // 0x00000001815450D0-0x00000001815451A0 0x0000000181544880-0x0000000181544960
	public Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> aliveHourMap { /* [XID] */ /* 0x0000000189B65CC0-0x0000000189B65CE0 */ get => default; /* [XID] */ /* 0x0000000189B6D2A0-0x0000000189B6D2C0 */ protected set {} } // 0x0000000181544100-0x00000001815441A0 0x0000000181544960-0x0000000181544A10

	// Constructors
	public EnvironmentWeightType() {} // 0x0000000181545240-0x00000001815452A0

	// Methods
	// [XID] // 0x0000000189B74990-0x0000000189B749B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181544250-0x00000001815447E0
	// [XID] // 0x0000000189B7BF70-0x0000000189B7BF90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F7A */, bool useObjectPool = false /* Metadata: 0x00AF1F7E */) => default; // 0x0000000181544A10-0x0000000181544EC0
	[BlackList] // 0x0000000189B83860-0x0000000189B838A0
	// [XID] // 0x0000000189B83860-0x0000000189B838A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181543F70-0x0000000181544010
	[BlackList] // 0x0000000189B8DB50-0x0000000189B8DB90
	// [XID] // 0x0000000189B8DB50-0x0000000189B8DB90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181544010-0x0000000181544100
	[BlackList] // 0x0000000189B98080-0x0000000189B980C0
	// [XID] // 0x0000000189B98080-0x0000000189B980C0
	public virtual void ReturnToObjectPool() {} // 0x00000001815451A0-0x0000000181545240
	[BlackList] // 0x0000000189BA2890-0x0000000189BA28D0
	// [XID] // 0x0000000189BA2890-0x0000000189BA28D0
	public virtual void OnPoolAllocated() {} // 0x0000000181545030-0x00000001815450D0
	[BlackList] // 0x0000000189BAC850-0x0000000189BAC890
	// [XID] // 0x0000000189BAC850-0x0000000189BAC890
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181544F90-0x0000000181545030
}


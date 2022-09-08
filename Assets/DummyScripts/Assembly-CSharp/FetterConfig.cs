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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class FetterConfig : IAutoAllocRecycle // TypeDefIndex: 15410
{
	// Fields
	protected SimpleSafeUInt32 fetter_idRawNum; // 0x10
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected FetterConditionConfig[] _openConds; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected FetterConditionConfig[] _finishConds; // 0x20

	// Properties
	public uint fetter_id { /* [XID] */ /* 0x0000000189738EB0-0x0000000189738ED0 */ get => default; /* [XID] */ /* 0x0000000189740C80-0x0000000189740CA0 */ protected set {} } // 0x000000018306AE00-0x000000018306AED0 0x000000018306B4F0-0x000000018306B5D0
	public uint avatarId { /* [XID] */ /* 0x00000001897481C0-0x00000001897481E0 */ get => default; /* [XID] */ /* 0x000000018974FA50-0x000000018974FA70 */ protected set {} } // 0x000000018306AED0-0x000000018306AFA0 0x000000018306A610-0x000000018306A6F0
	public FetterConditionConfig[] openConds { /* [XID] */ /* 0x0000000189757020-0x0000000189757040 */ get => default; /* [XID] */ /* 0x000000018975E5F0-0x000000018975E610 */ protected set {} } // 0x000000018306AFA0-0x000000018306B040 0x000000018306A890-0x000000018306A940
	public FetterConditionConfig[] finishConds { /* [XID] */ /* 0x0000000189765C70-0x0000000189765C90 */ get => default; /* [XID] */ /* 0x000000018976D400-0x000000018976D420 */ protected set {} } // 0x000000018306A570-0x000000018306A610 0x000000018306B710-0x000000018306B7C0

	// Constructors
	public FetterConfig() {} // 0x000000018306B860-0x000000018306B8C0

	// Methods
	// [XID] // 0x0000000189774850-0x0000000189774870
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018306A940-0x000000018306AE00
	// [XID] // 0x000000018977C220-0x000000018977C240
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1460 */, bool useObjectPool = false /* Metadata: 0x00AF1464 */) => default; // 0x000000018306B040-0x000000018306B4F0
	[BlackList] // 0x0000000189783C90-0x0000000189783CD0
	// [XID] // 0x0000000189783C90-0x0000000189783CD0
	public virtual void AutoAllocTypeFields() {} // 0x000000018306A6F0-0x000000018306A790
	[BlackList] // 0x000000018978E0F0-0x000000018978E130
	// [XID] // 0x000000018978E0F0-0x000000018978E130
	public virtual void AutoRecycleTypeFields() {} // 0x000000018306A790-0x000000018306A890
	[BlackList] // 0x0000000189798800-0x0000000189798840
	// [XID] // 0x0000000189798800-0x0000000189798840
	public virtual void ReturnToObjectPool() {} // 0x000000018306B7C0-0x000000018306B860
	[BlackList] // 0x00000001897A35E0-0x00000001897A3620
	// [XID] // 0x00000001897A35E0-0x00000001897A3620
	public virtual void OnPoolAllocated() {} // 0x000000018306B670-0x000000018306B710
	[BlackList] // 0x00000001897ADC30-0x00000001897ADC70
	// [XID] // 0x00000001897ADC30-0x00000001897ADC70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018306B5D0-0x000000018306B670
}


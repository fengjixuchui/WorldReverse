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
public class CityLevelupConfig : IAutoAllocRecycle // TypeDefIndex: 16303
{
	// Fields
	protected SimpleSafeUInt32 scene_idRawNum; // 0x10
	protected SimpleSafeUInt32 city_idRawNum; // 0x14
	protected SimpleSafeUInt32 levelRawNum; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected WorldAreaLevelupConsumeItem _consume_item; // 0x20
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected WorldAreaLevelupAction[] _action_vec; // 0x30

	// Properties
	public uint scene_id { /* [XID] */ /* 0x0000000189995A10-0x0000000189995A30 */ get => default; /* [XID] */ /* 0x000000018999D310-0x000000018999D330 */ protected set {} } // 0x000000018520C180-0x000000018520C250 0x000000018520C0A0-0x000000018520C180
	public uint city_id { /* [XID] */ /* 0x00000001899A4CD0-0x00000001899A4CF0 */ get => default; /* [XID] */ /* 0x00000001899AC830-0x00000001899AC850 */ protected set {} } // 0x000000018520CF80-0x000000018520D050 0x000000018520CCF0-0x000000018520CDD0
	public uint level { /* [XID] */ /* 0x00000001899B3FA0-0x00000001899B3FC0 */ get => default; /* [XID] */ /* 0x00000001899BB470-0x00000001899BB490 */ protected set {} } // 0x000000018520D7E0-0x000000018520D8B0 0x000000018520D700-0x000000018520D7E0
	public WorldAreaLevelupConsumeItem consume_item { /* [XID] */ /* 0x00000001899C2FA0-0x00000001899C2FC0 */ get => default; /* [XID] */ /* 0x00000001899CA340-0x00000001899CA360 */ protected set {} } // 0x000000018520D8B0-0x000000018520D950 0x000000018520C250-0x000000018520C300
	public uint rewardID { /* [XID] */ /* 0x00000001899D1BC0-0x00000001899D1BE0 */ get => default; /* [XID] */ /* 0x00000001899D9070-0x00000001899D9090 */ protected set {} } // 0x000000018520CEB0-0x000000018520CF80 0x000000018520CDD0-0x000000018520CEB0
	public WorldAreaLevelupAction[] action_vec { /* [XID] */ /* 0x00000001899E0800-0x00000001899E0820 */ get => default; /* [XID] */ /* 0x00000001899E82C0-0x00000001899E82E0 */ protected set {} } // 0x000000018520BE40-0x000000018520BEE0 0x000000018520D050-0x000000018520D100

	// Constructors
	public CityLevelupConfig() {} // 0x000000018520DB30-0x000000018520DB90

	// Methods
	// [IDTag] // 0x00000001899EF870-0x00000001899EF8B0
	// [XID] // 0x00000001899EF870-0x00000001899EF8B0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018520C300-0x000000018520C850
	// [IDTag] // 0x00000001899F9FD0-0x00000001899FA010
	// [XID] // 0x00000001899F9FD0-0x00000001899FA010
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018520C850-0x000000018520CCF0
	// [XID] // 0x0000000189A04550-0x0000000189A04570
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3710 */, bool useObjectPool = false /* Metadata: 0x00AF3714 */) => default; // 0x000000018520D100-0x000000018520D700
	[BlackList] // 0x0000000189A0BC90-0x0000000189A0BCD0
	// [XID] // 0x0000000189A0BC90-0x0000000189A0BCD0
	public virtual void AutoAllocTypeFields() {} // 0x000000018520BEE0-0x000000018520BF80
	[BlackList] // 0x0000000189A16300-0x0000000189A16340
	// [XID] // 0x0000000189A16300-0x0000000189A16340
	public virtual void AutoRecycleTypeFields() {} // 0x000000018520BF80-0x000000018520C0A0
	[BlackList] // 0x0000000189A20870-0x0000000189A208B0
	// [XID] // 0x0000000189A20870-0x0000000189A208B0
	public virtual void ReturnToObjectPool() {} // 0x000000018520DA90-0x000000018520DB30
	[BlackList] // 0x0000000189A2ABA0-0x0000000189A2ABE0
	// [XID] // 0x0000000189A2ABA0-0x0000000189A2ABE0
	public virtual void OnPoolAllocated() {} // 0x000000018520D9F0-0x000000018520DA90
	[BlackList] // 0x0000000189A35470-0x0000000189A354B0
	// [XID] // 0x0000000189A35470-0x0000000189A354B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018520D950-0x000000018520D9F0
}


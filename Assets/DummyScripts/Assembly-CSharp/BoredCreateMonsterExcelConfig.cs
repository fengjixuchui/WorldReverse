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
public class BoredCreateMonsterExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15290
{
	// Fields
	protected SimpleSafeUInt32 player_levelRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected BoredMonsterConfig[] _monster_config_vec; // 0x18

	// Properties
	public uint player_level { /* [XID] */ /* 0x0000000189A3E530-0x0000000189A3E550 */ get => default; /* [XID] */ /* 0x0000000189A45BC0-0x0000000189A45BE0 */ protected set {} } // 0x000000018508EB30-0x000000018508EC00 0x000000018508E630-0x000000018508E710
	public BoredMonsterConfig[] monster_config_vec { /* [XID] */ /* 0x0000000189A4D360-0x0000000189A4D380 */ get => default; /* [XID] */ /* 0x0000000189A54B10-0x0000000189A54B30 */ protected set {} } // 0x000000018508E590-0x000000018508E630 0x000000018508E710-0x000000018508E7C0

	// Constructors
	public BoredCreateMonsterExcelConfig() {} // 0x000000018508EDE0-0x000000018508EE40

	// Methods
	// [IDTag] // 0x0000000189A5C5C0-0x0000000189A5C600
	// [XID] // 0x0000000189A5C5C0-0x0000000189A5C600
	public virtual bool ParseFromLine(string line) => default; // 0x000000018508DF20-0x000000018508E2A0
	// [IDTag] // 0x0000000189A66D40-0x0000000189A66D80
	// [XID] // 0x0000000189A66D40-0x0000000189A66D80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018508E2A0-0x000000018508E590
	// [XID] // 0x0000000189A712E0-0x0000000189A71300
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF067E */, bool useObjectPool = false /* Metadata: 0x00AF0682 */) => default; // 0x000000018508E7C0-0x000000018508EB30
	[BlackList] // 0x0000000189A78EA0-0x0000000189A78EE0
	// [XID] // 0x0000000189A78EA0-0x0000000189A78EE0
	public virtual void AutoAllocTypeFields() {} // 0x000000018508DDA0-0x000000018508DE40
	[BlackList] // 0x0000000189A83840-0x0000000189A83880
	// [XID] // 0x0000000189A83840-0x0000000189A83880
	public virtual void AutoRecycleTypeFields() {} // 0x000000018508DE40-0x000000018508DF20
	[BlackList] // 0x0000000189A8E130-0x0000000189A8E170
	// [XID] // 0x0000000189A8E130-0x0000000189A8E170
	public virtual void ReturnToObjectPool() {} // 0x000000018508ED40-0x000000018508EDE0
	[BlackList] // 0x0000000189A98A20-0x0000000189A98A60
	// [XID] // 0x0000000189A98A20-0x0000000189A98A60
	public virtual void OnPoolAllocated() {} // 0x000000018508ECA0-0x000000018508ED40
	[BlackList] // 0x0000000189AA2BA0-0x0000000189AA2BE0
	// [XID] // 0x0000000189AA2BA0-0x0000000189AA2BE0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018508EC00-0x000000018508ECA0
}


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
public class WorldAreaLevelupConfig : IAutoAllocRecycle // TypeDefIndex: 16301
{
	// Fields
	protected SimpleSafeUInt32 scene_idRawNum; // 0x10
	protected SimpleSafeUInt32 area_idRawNum; // 0x14
	protected SimpleSafeUInt32 levelRawNum; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected WorldAreaLevelupConsumeItem _consume_item; // 0x20
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected WorldAreaLevelupAction[] _action_vec; // 0x30

	// Properties
	public uint scene_id { /* [XID] */ /* 0x000000018985FB30-0x000000018985FB50 */ get => default; /* [XID] */ /* 0x0000000189867270-0x0000000189867290 */ protected set {} } // 0x0000000181805CF0-0x0000000181805DC0 0x0000000181805C10-0x0000000181805CF0
	public uint area_id { /* [XID] */ /* 0x000000018986EA10-0x000000018986EA30 */ get => default; /* [XID] */ /* 0x0000000189875F20-0x0000000189875F40 */ protected set {} } // 0x00000001818073F0-0x00000001818074C0 0x0000000181807270-0x0000000181807350
	public uint level { /* [XID] */ /* 0x000000018987DAE0-0x000000018987DB00 */ get => default; /* [XID] */ /* 0x0000000189884950-0x0000000189884970 */ protected set {} } // 0x00000001818071A0-0x0000000181807270 0x00000001818070C0-0x00000001818071A0
	public WorldAreaLevelupConsumeItem consume_item { /* [XID] */ /* 0x000000018988C000-0x000000018988C020 */ get => default; /* [XID] */ /* 0x0000000189893610-0x0000000189893630 */ protected set {} } // 0x0000000181807350-0x00000001818073F0 0x0000000181805DC0-0x0000000181805E70
	public uint rewardID { /* [XID] */ /* 0x000000018989AD10-0x000000018989AD30 */ get => default; /* [XID] */ /* 0x00000001898A2060-0x00000001898A2080 */ protected set {} } // 0x0000000181806940-0x0000000181806A10 0x0000000181806860-0x0000000181806940
	public WorldAreaLevelupAction[] action_vec { /* [XID] */ /* 0x00000001898A9870-0x00000001898A9890 */ get => default; /* [XID] */ /* 0x00000001898B1160-0x00000001898B1180 */ protected set {} } // 0x00000001818059B0-0x0000000181805A50 0x0000000181806A10-0x0000000181806AC0

	// Constructors
	public WorldAreaLevelupConfig() {} // 0x00000001818076A0-0x0000000181807700

	// Methods
	// [IDTag] // 0x00000001898B8960-0x00000001898B89A0
	// [XID] // 0x00000001898B8960-0x00000001898B89A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181806310-0x0000000181806860
	// [IDTag] // 0x00000001898C2EC0-0x00000001898C2F00
	// [XID] // 0x00000001898C2EC0-0x00000001898C2F00
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181805E70-0x0000000181806310
	// [XID] // 0x00000001898CD620-0x00000001898CD640
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3701 */, bool useObjectPool = false /* Metadata: 0x00AF3705 */) => default; // 0x0000000181806AC0-0x00000001818070C0
	[BlackList] // 0x00000001898D5070-0x00000001898D50B0
	// [XID] // 0x00000001898D5070-0x00000001898D50B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181805A50-0x0000000181805AF0
	[BlackList] // 0x00000001898DFDA0-0x00000001898DFDE0
	// [XID] // 0x00000001898DFDA0-0x00000001898DFDE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181805AF0-0x0000000181805C10
	[BlackList] // 0x00000001898EA830-0x00000001898EA870
	// [XID] // 0x00000001898EA830-0x00000001898EA870
	public virtual void ReturnToObjectPool() {} // 0x0000000181807600-0x00000001818076A0
	[BlackList] // 0x00000001898F4F00-0x00000001898F4F40
	// [XID] // 0x00000001898F4F00-0x00000001898F4F40
	public virtual void OnPoolAllocated() {} // 0x0000000181807560-0x0000000181807600
	[BlackList] // 0x00000001898FF790-0x00000001898FF7D0
	// [XID] // 0x00000001898FF790-0x00000001898FF7D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001818074C0-0x0000000181807560
}


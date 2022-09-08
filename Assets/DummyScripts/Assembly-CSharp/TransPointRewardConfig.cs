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
public class TransPointRewardConfig : IAutoAllocRecycle // TypeDefIndex: 16304
{
	// Fields
	protected SimpleSafeUInt32 scene_idRawNum; // 0x10
	protected SimpleSafeUInt32 point_idRawNum; // 0x14
	protected SimpleSafeUInt32 reward_idRawNum; // 0x18
	protected SimpleSafeUInt32[] _group_id_vec; // 0x20

	// Properties
	public uint scene_id { /* [XID] */ /* 0x0000000189A471F0-0x0000000189A47210 */ get => default; /* [XID] */ /* 0x0000000189A4EB10-0x0000000189A4EB30 */ protected set {} } // 0x00000001834E5D10-0x00000001834E5DE0 0x00000001834E5B80-0x00000001834E5C60
	public uint point_id { /* [XID] */ /* 0x0000000189A56180-0x0000000189A561A0 */ get => default; /* [XID] */ /* 0x0000000189A5DCA0-0x0000000189A5DCC0 */ protected set {} } // 0x00000001834E6880-0x00000001834E6950 0x00000001834E5AA0-0x00000001834E5B80
	public uint reward_id { /* [XID] */ /* 0x0000000189A65460-0x0000000189A65480 */ get => default; /* [XID] */ /* 0x0000000189A6CB80-0x0000000189A6CBA0 */ protected set {} } // 0x00000001834E6E00-0x00000001834E6ED0 0x00000001834E6ED0-0x00000001834E6FB0
	public SimpleSafeUInt32[] group_id_vec { /* [XID] */ /* 0x0000000189A742D0-0x0000000189A742F0 */ get => default; /* [XID] */ /* 0x0000000189A7BC60-0x0000000189A7BC80 */ protected set {} } // 0x00000001834E67E0-0x00000001834E6880 0x00000001834E5C60-0x00000001834E5D10

	// Constructors
	public TransPointRewardConfig() {} // 0x00000001834E7190-0x00000001834E71F0

	// Methods
	// [IDTag] // 0x0000000189A835E0-0x0000000189A83620
	// [XID] // 0x0000000189A835E0-0x0000000189A83620
	public virtual bool ParseFromLine(string line) => default; // 0x00000001834E62C0-0x00000001834E67E0
	// [IDTag] // 0x0000000189A8DF10-0x0000000189A8DF50
	// [XID] // 0x0000000189A8DF10-0x0000000189A8DF50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001834E5DE0-0x00000001834E62C0
	// [XID] // 0x0000000189A98780-0x0000000189A987A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3715 */, bool useObjectPool = false /* Metadata: 0x00AF3719 */) => default; // 0x00000001834E6950-0x00000001834E6E00
	[BlackList] // 0x0000000189A9FC10-0x0000000189A9FC50
	// [XID] // 0x0000000189A9FC10-0x0000000189A9FC50
	public virtual void AutoAllocTypeFields() {} // 0x00000001834E5900-0x00000001834E59A0
	[BlackList] // 0x0000000189AAA040-0x0000000189AAA080
	// [XID] // 0x0000000189AAA040-0x0000000189AAA080
	public virtual void AutoRecycleTypeFields() {} // 0x00000001834E59A0-0x00000001834E5AA0
	[BlackList] // 0x0000000189AB4B90-0x0000000189AB4BD0
	// [XID] // 0x0000000189AB4B90-0x0000000189AB4BD0
	public virtual void ReturnToObjectPool() {} // 0x00000001834E70F0-0x00000001834E7190
	[BlackList] // 0x0000000189ABF4B0-0x0000000189ABF4F0
	// [XID] // 0x0000000189ABF4B0-0x0000000189ABF4F0
	public virtual void OnPoolAllocated() {} // 0x00000001834E7050-0x00000001834E70F0
	[BlackList] // 0x0000000189AC9E80-0x0000000189AC9EC0
	// [XID] // 0x0000000189AC9E80-0x0000000189AC9EC0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001834E6FB0-0x00000001834E7050
}


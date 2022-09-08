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
public class ReunionPrivilegeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16063
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 dailyNumRawNum; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ReunionPrivilegeConfig[] _privilegeType; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189805770-0x0000000189805790 */ get => default; /* [XID] */ /* 0x000000018980CD70-0x000000018980CD90 */ protected set {} } // 0x00000001851A5820-0x00000001851A58F0 0x00000001851A51F0-0x00000001851A52D0
	public uint dailyNum { /* [XID] */ /* 0x00000001898145D0-0x00000001898145F0 */ get => default; /* [XID] */ /* 0x000000018981C060-0x000000018981C080 */ protected set {} } // 0x00000001851A58F0-0x00000001851A59C0 0x00000001851A4990-0x00000001851A4A70
	public ReunionPrivilegeConfig[] privilegeType { /* [XID] */ /* 0x0000000189823530-0x0000000189823550 */ get => default; /* [XID] */ /* 0x000000018982AF30-0x000000018982AF50 */ protected set {} } // 0x00000001851A4840-0x00000001851A48E0 0x00000001851A48E0-0x00000001851A4990

	// Constructors
	public ReunionPrivilegeExcelConfig() {} // 0x00000001851A5A60-0x00000001851A5AC0

	// Methods
	// [IDTag] // 0x0000000189832410-0x0000000189832450
	// [XID] // 0x0000000189832410-0x0000000189832450
	public virtual bool ParseFromLine(string line) => default; // 0x00000001851A4A70-0x00000001851A4E80
	// [IDTag] // 0x000000018983CB50-0x000000018983CB90
	// [XID] // 0x000000018983CB50-0x000000018983CB90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001851A4E80-0x00000001851A51F0
	// [XID] // 0x00000001898470F0-0x0000000189847110
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F48 */, bool useObjectPool = false /* Metadata: 0x00AF2F4C */) => default; // 0x00000001851A52D0-0x00000001851A56E0
	[BlackList] // 0x000000018984E6A0-0x000000018984E6E0
	// [XID] // 0x000000018984E6A0-0x000000018984E6E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001851A46B0-0x00000001851A4750
	[BlackList] // 0x0000000189858A80-0x0000000189858AC0
	// [XID] // 0x0000000189858A80-0x0000000189858AC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851A4750-0x00000001851A4840
	[BlackList] // 0x0000000189862F30-0x0000000189862F70
	// [XID] // 0x0000000189862F30-0x0000000189862F70
	public virtual void ReturnToObjectPool() {} // 0x00000001851A59C0-0x00000001851A5A60
	[BlackList] // 0x000000018986D070-0x000000018986D0B0
	// [XID] // 0x000000018986D070-0x000000018986D0B0
	public virtual void OnPoolAllocated() {} // 0x00000001851A5780-0x00000001851A5820
	[BlackList] // 0x0000000189877670-0x00000001898776B0
	// [XID] // 0x0000000189877670-0x00000001898776B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851A56E0-0x00000001851A5780
}


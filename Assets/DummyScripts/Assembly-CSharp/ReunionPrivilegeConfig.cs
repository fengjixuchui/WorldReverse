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
public class ReunionPrivilegeConfig : IAutoAllocRecycle // TypeDefIndex: 16062
{
	// Fields
	protected ReunionPrivilegeType _type; // 0x10
	protected string _sub_type; // 0x18

	// Properties
	public ReunionPrivilegeType type { /* [XID] */ /* 0x0000000189793CA0-0x0000000189793CC0 */ get => default; /* [XID] */ /* 0x000000018979C010-0x000000018979C030 */ protected set {} } // 0x0000000182AA6B10-0x0000000182AA6BB0 0x0000000182AA6920-0x0000000182AA69D0
	public string sub_type { /* [XID] */ /* 0x00000001897A34C0-0x00000001897A34E0 */ get => default; /* [XID] */ /* 0x00000001897AAA60-0x00000001897AAA80 */ protected set {} } // 0x0000000182AA6460-0x0000000182AA6500 0x0000000182AA6500-0x0000000182AA65B0

	// Constructors
	public ReunionPrivilegeConfig() {} // 0x0000000182AA6C50-0x0000000182AA6CB0

	// Methods
	// [XID] // 0x00000001897B2590-0x00000001897B25B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182AA6220-0x0000000182AA6460
	// [XID] // 0x00000001897B9E70-0x00000001897B9E90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F43 */, bool useObjectPool = false /* Metadata: 0x00AF2F47 */) => default; // 0x0000000182AA65B0-0x0000000182AA6920
	[BlackList] // 0x00000001897C1FB0-0x00000001897C1FF0
	// [XID] // 0x00000001897C1FB0-0x00000001897C1FF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AA60E0-0x0000000182AA6180
	[BlackList] // 0x00000001897CC650-0x00000001897CC690
	// [XID] // 0x00000001897CC650-0x00000001897CC690
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AA6180-0x0000000182AA6220
	[BlackList] // 0x00000001897D6FC0-0x00000001897D7000
	// [XID] // 0x00000001897D6FC0-0x00000001897D7000
	public virtual void ReturnToObjectPool() {} // 0x0000000182AA6BB0-0x0000000182AA6C50
	[BlackList] // 0x00000001897E17E0-0x00000001897E1820
	// [XID] // 0x00000001897E17E0-0x00000001897E1820
	public virtual void OnPoolAllocated() {} // 0x0000000182AA6A70-0x0000000182AA6B10
	[BlackList] // 0x00000001897EC280-0x00000001897EC2C0
	// [XID] // 0x00000001897EC280-0x00000001897EC2C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AA69D0-0x0000000182AA6A70
}


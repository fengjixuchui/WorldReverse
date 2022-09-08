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
public class MatchLimitExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15804
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected MatchCond[] _cond; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897583F0-0x0000000189758410 */ get => default; /* [XID] */ /* 0x000000018975FE30-0x000000018975FE50 */ protected set {} } // 0x000000018420E3A0-0x000000018420E470 0x000000018420DD70-0x000000018420DE50
	public MatchCond[] cond { /* [XID] */ /* 0x0000000189767480-0x00000001897674A0 */ get => default; /* [XID] */ /* 0x000000018976EA40-0x000000018976EA60 */ protected set {} } // 0x000000018420E1C0-0x000000018420E260 0x000000018420D9D0-0x000000018420DA80

	// Constructors
	public MatchLimitExcelConfig() {} // 0x000000018420E510-0x000000018420E570

	// Methods
	// [XID] // 0x0000000189776440-0x0000000189776460
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018420DA80-0x000000018420DD70
	// [XID] // 0x000000018977DB40-0x000000018977DB60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2671 */, bool useObjectPool = false /* Metadata: 0x00AF2675 */) => default; // 0x000000018420DE50-0x000000018420E1C0
	[BlackList] // 0x0000000189785340-0x0000000189785380
	// [XID] // 0x0000000189785340-0x0000000189785380
	public virtual void AutoAllocTypeFields() {} // 0x000000018420D850-0x000000018420D8F0
	[BlackList] // 0x000000018978F720-0x000000018978F760
	// [XID] // 0x000000018978F720-0x000000018978F760
	public virtual void AutoRecycleTypeFields() {} // 0x000000018420D8F0-0x000000018420D9D0
	[BlackList] // 0x0000000189799DD0-0x0000000189799E10
	// [XID] // 0x0000000189799DD0-0x0000000189799E10
	public virtual void ReturnToObjectPool() {} // 0x000000018420E470-0x000000018420E510
	[BlackList] // 0x00000001897A4F10-0x00000001897A4F50
	// [XID] // 0x00000001897A4F10-0x00000001897A4F50
	public virtual void OnPoolAllocated() {} // 0x000000018420E300-0x000000018420E3A0
	[BlackList] // 0x00000001897AF5B0-0x00000001897AF5F0
	// [XID] // 0x00000001897AF5B0-0x00000001897AF5F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018420E260-0x000000018420E300
}


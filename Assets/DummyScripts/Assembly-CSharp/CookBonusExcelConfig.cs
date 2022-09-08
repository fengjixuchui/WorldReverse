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
public class CookBonusExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15448
{
	// Fields
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x10
	protected SimpleSafeUInt32 recipeIdRawNum; // 0x14
	protected CookBonusType _bonusType; // 0x18
	protected SimpleSafeUInt32[] _paramVec; // 0x20
	protected SimpleSafeUInt32[] _complexParamVec; // 0x28

	// Properties
	public uint avatarId { /* [XID] */ /* 0x0000000189A1F110-0x0000000189A1F130 */ get => default; /* [XID] */ /* 0x0000000189A26700-0x0000000189A26720 */ protected set {} } // 0x0000000183824B30-0x0000000183824C00 0x00000001838238B0-0x0000000183823990
	public uint recipeId { /* [XID] */ /* 0x0000000189A2DA30-0x0000000189A2DA50 */ get => default; /* [XID] */ /* 0x0000000189A35650-0x0000000189A35670 */ protected set {} } // 0x0000000183824C00-0x0000000183824CD0 0x0000000183823B20-0x0000000183823C00
	public CookBonusType bonusType { /* [XID] */ /* 0x0000000189A3CA60-0x0000000189A3CA80 */ get => default; /* [XID] */ /* 0x0000000189A444B0-0x0000000189A444D0 */ protected set {} } // 0x0000000183824CD0-0x0000000183824D70 0x0000000183823D40-0x0000000183823DF0
	public SimpleSafeUInt32[] paramVec { /* [XID] */ /* 0x0000000189A4BA80-0x0000000189A4BAA0 */ get => default; /* [XID] */ /* 0x0000000189A53160-0x0000000189A53180 */ protected set {} } // 0x0000000183823CA0-0x0000000183823D40 0x00000001838252C0-0x0000000183825370
	public SimpleSafeUInt32[] complexParamVec { /* [XID] */ /* 0x0000000189A5A910-0x0000000189A5A930 */ get => default; /* [XID] */ /* 0x0000000189A620F0-0x0000000189A62110 */ protected set {} } // 0x0000000183823C00-0x0000000183823CA0 0x0000000183825370-0x0000000183825420

	// Constructors
	public CookBonusExcelConfig() {} // 0x0000000183825600-0x0000000183825660

	// Methods
	// [IDTag] // 0x0000000189A69FD0-0x0000000189A6A010
	// [XID] // 0x0000000189A69FD0-0x0000000189A6A010
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183824470-0x0000000183824B30
	// [IDTag] // 0x0000000189A74430-0x0000000189A74470
	// [XID] // 0x0000000189A74430-0x0000000189A74470
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183823DF0-0x0000000183824470
	// [XID] // 0x0000000189A7ED40-0x0000000189A7ED60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1AC2 */, bool useObjectPool = false /* Metadata: 0x00AF1AC6 */) => default; // 0x0000000183824D70-0x00000001838252C0
	[BlackList] // 0x0000000189A86570-0x0000000189A865B0
	// [XID] // 0x0000000189A86570-0x0000000189A865B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183823990-0x0000000183823A30
	[BlackList] // 0x0000000189A91070-0x0000000189A910B0
	// [XID] // 0x0000000189A91070-0x0000000189A910B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183823A30-0x0000000183823B20
	[BlackList] // 0x0000000189A9B7A0-0x0000000189A9B7E0
	// [XID] // 0x0000000189A9B7A0-0x0000000189A9B7E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183825560-0x0000000183825600
	[BlackList] // 0x0000000189AA5D00-0x0000000189AA5D40
	// [XID] // 0x0000000189AA5D00-0x0000000189AA5D40
	public virtual void OnPoolAllocated() {} // 0x00000001838254C0-0x0000000183825560
	[BlackList] // 0x0000000189AB05A0-0x0000000189AB05E0
	// [XID] // 0x0000000189AB05A0-0x0000000189AB05E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183825420-0x00000001838254C0
}


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
public class RandomQuestFilterConfig : IAutoAllocRecycle // TypeDefIndex: 15979
{
	// Fields
	protected RandomQuestFilterType _filterType; // 0x10
	protected string _filterFactor; // 0x18
	protected uint[] _filterParamList; // 0x20

	// Properties
	public RandomQuestFilterType filterType { /* [XID] */ /* 0x0000000189B16850-0x0000000189B16870 */ get => default; /* [XID] */ /* 0x0000000189B1DF70-0x0000000189B1DF90 */ protected set {} } // 0x00000001841682B0-0x0000000184168350 0x0000000184168350-0x0000000184168400
	public string filterFactor { /* [XID] */ /* 0x0000000189B257E0-0x0000000189B25800 */ get => default; /* [XID] */ /* 0x0000000189B2CCF0-0x0000000189B2CD10 */ protected set {} } // 0x0000000184168B50-0x0000000184168BF0 0x0000000184168400-0x00000001841684B0
	public uint[] filterParamList { /* [XID] */ /* 0x0000000189B34120-0x0000000189B34140 */ get => default; /* [XID] */ /* 0x0000000189B3BAB0-0x0000000189B3BAD0 */ protected set {} } // 0x0000000184168560-0x0000000184168600 0x00000001841684B0-0x0000000184168560

	// Constructors
	public RandomQuestFilterConfig() {} // 0x0000000184168C90-0x0000000184168CF0

	// Methods
	// [XID] // 0x0000000189B434F0-0x0000000189B43510
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184167E40-0x00000001841682B0
	// [XID] // 0x0000000189B4ACB0-0x0000000189B4ACD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CD4 */, bool useObjectPool = false /* Metadata: 0x00AF2CD8 */) => default; // 0x0000000184168600-0x0000000184168A10
	[BlackList] // 0x0000000189B522E0-0x0000000189B52320
	// [XID] // 0x0000000189B522E0-0x0000000189B52320
	public virtual void AutoAllocTypeFields() {} // 0x0000000184167CF0-0x0000000184167D90
	[BlackList] // 0x0000000189B5CD70-0x0000000189B5CDB0
	// [XID] // 0x0000000189B5CD70-0x0000000189B5CDB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184167D90-0x0000000184167E40
	[BlackList] // 0x0000000189B67680-0x0000000189B676C0
	// [XID] // 0x0000000189B67680-0x0000000189B676C0
	public virtual void ReturnToObjectPool() {} // 0x0000000184168BF0-0x0000000184168C90
	[BlackList] // 0x0000000189B71C10-0x0000000189B71C50
	// [XID] // 0x0000000189B71C10-0x0000000189B71C50
	public virtual void OnPoolAllocated() {} // 0x0000000184168AB0-0x0000000184168B50
	[BlackList] // 0x0000000189B7BE50-0x0000000189B7BE90
	// [XID] // 0x0000000189B7BE50-0x0000000189B7BE90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184168A10-0x0000000184168AB0
}


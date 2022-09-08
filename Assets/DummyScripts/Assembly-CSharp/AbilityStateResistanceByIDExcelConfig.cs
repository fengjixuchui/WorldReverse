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
public class AbilityStateResistanceByIDExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15228
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected AbilityState[] _abilityStates; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899FA1F0-0x00000001899FA210 */ get => default; /* [XID] */ /* 0x0000000189A015B0-0x0000000189A015D0 */ protected set {} } // 0x0000000181300CB0-0x0000000181300D80 0x0000000181300680-0x0000000181300760
	public AbilityState[] abilityStates { /* [XID] */ /* 0x0000000189A08F70-0x0000000189A08F90 */ get => default; /* [XID] */ /* 0x0000000189A10490-0x0000000189A104B0 */ protected set {} } // 0x0000000181300AD0-0x0000000181300B70 0x0000000181300D80-0x0000000181300E30

	// Constructors
	public AbilityStateResistanceByIDExcelConfig() {} // 0x0000000181300ED0-0x0000000181300F30

	// Methods
	// [IDTag] // 0x0000000189A17A50-0x0000000189A17A90
	// [XID] // 0x0000000189A17A50-0x0000000189A17A90
	public virtual bool ParseFromLine(string line) => default; // 0x00000001813002F0-0x0000000181300680
	// [IDTag] // 0x0000000189A22170-0x0000000189A221B0
	// [XID] // 0x0000000189A22170-0x0000000189A221B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001812FFFB0-0x00000001813002F0
	// [XID] // 0x0000000189A2C430-0x0000000189A2C450
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0462 */, bool useObjectPool = false /* Metadata: 0x00AF0466 */) => default; // 0x0000000181300760-0x0000000181300AD0
	[BlackList] // 0x0000000189A33B20-0x0000000189A33B60
	// [XID] // 0x0000000189A33B20-0x0000000189A33B60
	public virtual void AutoAllocTypeFields() {} // 0x00000001812FFE30-0x00000001812FFED0
	[BlackList] // 0x0000000189A3E550-0x0000000189A3E590
	// [XID] // 0x0000000189A3E550-0x0000000189A3E590
	public virtual void AutoRecycleTypeFields() {} // 0x00000001812FFED0-0x00000001812FFFB0
	[BlackList] // 0x0000000189A48B30-0x0000000189A48B70
	// [XID] // 0x0000000189A48B30-0x0000000189A48B70
	public virtual void ReturnToObjectPool() {} // 0x0000000181300E30-0x0000000181300ED0
	[BlackList] // 0x0000000189A531E0-0x0000000189A53220
	// [XID] // 0x0000000189A531E0-0x0000000189A53220
	public virtual void OnPoolAllocated() {} // 0x0000000181300C10-0x0000000181300CB0
	[BlackList] // 0x0000000189A5DD60-0x0000000189A5DDA0
	// [XID] // 0x0000000189A5DD60-0x0000000189A5DDA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181300B70-0x0000000181300C10
}


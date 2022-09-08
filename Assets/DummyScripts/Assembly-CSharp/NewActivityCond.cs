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
public class NewActivityCond : IAutoAllocRecycle // TypeDefIndex: 15889
{
	// Fields
	protected NewActivityCondType _type; // 0x10
	protected SimpleSafeInt32[] _param; // 0x18

	// Properties
	public NewActivityCondType type { /* [XID] */ /* 0x000000018976A330-0x000000018976A350 */ get => default; /* [XID] */ /* 0x0000000189771B90-0x0000000189771BB0 */ protected set {} } // 0x0000000183AD8C10-0x0000000183AD8CB0 0x0000000183AD8A20-0x0000000183AD8AD0
	public SimpleSafeInt32[] param { /* [XID] */ /* 0x0000000189779340-0x0000000189779360 */ get => default; /* [XID] */ /* 0x0000000189780B00-0x0000000189780B20 */ protected set {} } // 0x0000000183AD8D60-0x0000000183AD8E00 0x0000000183AD8CB0-0x0000000183AD8D60

	// Constructors
	public NewActivityCond() {} // 0x0000000183AD8EA0-0x0000000183AD8F00

	// Methods
	// [XID] // 0x0000000189788140-0x0000000189788160
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183AD82B0-0x0000000183AD86B0
	// [XID] // 0x000000018978F700-0x000000018978F720
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A55 */, bool useObjectPool = false /* Metadata: 0x00AF2A59 */) => default; // 0x0000000183AD86B0-0x0000000183AD8A20
	[BlackList] // 0x0000000189796F30-0x0000000189796F70
	// [XID] // 0x0000000189796F30-0x0000000189796F70
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AD8170-0x0000000183AD8210
	[BlackList] // 0x00000001897A1CC0-0x00000001897A1D00
	// [XID] // 0x00000001897A1CC0-0x00000001897A1D00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AD8210-0x0000000183AD82B0
	[BlackList] // 0x00000001897AC440-0x00000001897AC480
	// [XID] // 0x00000001897AC440-0x00000001897AC480
	public virtual void ReturnToObjectPool() {} // 0x0000000183AD8E00-0x0000000183AD8EA0
	[BlackList] // 0x00000001897B7490-0x00000001897B74D0
	// [XID] // 0x00000001897B7490-0x00000001897B74D0
	public virtual void OnPoolAllocated() {} // 0x0000000183AD8B70-0x0000000183AD8C10
	[BlackList] // 0x00000001897C2030-0x00000001897C2070
	// [XID] // 0x00000001897C2030-0x00000001897C2070
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AD8AD0-0x0000000183AD8B70
}


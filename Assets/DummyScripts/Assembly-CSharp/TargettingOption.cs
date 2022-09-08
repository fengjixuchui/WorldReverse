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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TargettingOption : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16828
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _range; // 0x10

	// Properties
	public DynamicFloat range { /* [XID] */ /* 0x00000001898D9730-0x00000001898D9750 */ get => default; /* [XID] */ /* 0x00000001898E14B0-0x00000001898E14D0 */ private set {} } // 0x00000001837E6BF0-0x00000001837E6C90 0x00000001837E6C90-0x00000001837E6D40

	// Constructors
	public TargettingOption() {} // 0x00000001837E7B80-0x00000001837E7BE0

	// Methods
	// [XID] // 0x00000001898E8EC0-0x00000001898E8EE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837E78C0-0x00000001837E79A0
	// [XID] // 0x00000001898F0680-0x00000001898F06A0
	public void InitEmpty() {} // 0x00000001837E7310-0x00000001837E73E0
	[BlackList] // 0x00000001898F8050-0x00000001898F8090
	// [XID] // 0x00000001898F8050-0x00000001898F8090
	public bool FromJson(JSONNode node) => default; // 0x00000001837E6F90-0x00000001837E7310
	// [XID] // 0x00000001899027E0-0x0000000189902800
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001837E6560-0x00000001837E6760
	// [XID] // 0x0000000189909DE0-0x0000000189909E00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF47D2 */, bool useObjectPool = false /* Metadata: 0x00AF47D6 */) => default; // 0x00000001837E73E0-0x00000001837E76E0
	// [XID] // 0x00000001899116C0-0x00000001899116E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF47D7 */, bool useObjectPool = false /* Metadata: 0x00AF47DB */) => default; // 0x00000001837E6D40-0x00000001837E6F90
	[BlackList] // 0x0000000189919240-0x0000000189919280
	// [XID] // 0x0000000189919240-0x0000000189919280
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001837E6760-0x00000001837E6A30
	// [XID] // 0x0000000189923A60-0x0000000189923A80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837E76E0-0x00000001837E78C0
	[BlackList] // 0x000000018992B0E0-0x000000018992B120
	// [XID] // 0x000000018992B0E0-0x000000018992B120
	public virtual void AutoAllocTypeFields() {} // 0x00000001837E6A30-0x00000001837E6AD0
	[BlackList] // 0x0000000189935430-0x0000000189935470
	// [XID] // 0x0000000189935430-0x0000000189935470
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837E6AD0-0x00000001837E6BF0
	[BlackList] // 0x000000018993FDA0-0x000000018993FDE0
	// [XID] // 0x000000018993FDA0-0x000000018993FDE0
	public virtual void ReturnToObjectPool() {} // 0x00000001837E7AE0-0x00000001837E7B80
	[BlackList] // 0x000000018994A2C0-0x000000018994A300
	// [XID] // 0x000000018994A2C0-0x000000018994A300
	public virtual void OnPoolAllocated() {} // 0x00000001837E7A40-0x00000001837E7AE0
	[BlackList] // 0x00000001899549E0-0x0000000189954A20
	// [XID] // 0x00000001899549E0-0x0000000189954A20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837E79A0-0x00000001837E7A40
}


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
public class WeaponLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16273
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected SimpleSafeUInt32[] _requiredExps; // 0x18

	// Properties
	public uint level { /* [XID] */ /* 0x000000018988D600-0x000000018988D620 */ get => default; /* [XID] */ /* 0x0000000189894D90-0x0000000189894DB0 */ protected set {} } // 0x00000001820E7E20-0x00000001820E7EF0 0x00000001820E7D40-0x00000001820E7E20
	public SimpleSafeUInt32[] requiredExps { /* [XID] */ /* 0x000000018989C420-0x000000018989C440 */ get => default; /* [XID] */ /* 0x00000001898A3A80-0x00000001898A3AA0 */ protected set {} } // 0x00000001820E7930-0x00000001820E79D0 0x00000001820E7880-0x00000001820E7930

	// Constructors
	public WeaponLevelExcelConfig() {} // 0x00000001820E80D0-0x00000001820E8130

	// Methods
	// [IDTag] // 0x00000001898AAD60-0x00000001898AADA0
	// [XID] // 0x00000001898AAD60-0x00000001898AADA0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001820E74F0-0x00000001820E7880
	// [IDTag] // 0x00000001898B5750-0x00000001898B5790
	// [XID] // 0x00000001898B5750-0x00000001898B5790
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001820E71B0-0x00000001820E74F0
	// [XID] // 0x00000001898BFFE0-0x00000001898C0000
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF361C */, bool useObjectPool = false /* Metadata: 0x00AF3620 */) => default; // 0x00000001820E79D0-0x00000001820E7D40
	[BlackList] // 0x00000001898C7900-0x00000001898C7940
	// [XID] // 0x00000001898C7900-0x00000001898C7940
	public virtual void AutoAllocTypeFields() {} // 0x00000001820E7030-0x00000001820E70D0
	[BlackList] // 0x00000001898D1F50-0x00000001898D1F90
	// [XID] // 0x00000001898D1F50-0x00000001898D1F90
	public virtual void AutoRecycleTypeFields() {} // 0x00000001820E70D0-0x00000001820E71B0
	[BlackList] // 0x00000001898DC9B0-0x00000001898DC9F0
	// [XID] // 0x00000001898DC9B0-0x00000001898DC9F0
	public virtual void ReturnToObjectPool() {} // 0x00000001820E8030-0x00000001820E80D0
	[BlackList] // 0x00000001898E7850-0x00000001898E7890
	// [XID] // 0x00000001898E7850-0x00000001898E7890
	public virtual void OnPoolAllocated() {} // 0x00000001820E7F90-0x00000001820E8030
	[BlackList] // 0x00000001898F1FB0-0x00000001898F1FF0
	// [XID] // 0x00000001898F1FB0-0x00000001898F1FF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001820E7EF0-0x00000001820E7F90
}


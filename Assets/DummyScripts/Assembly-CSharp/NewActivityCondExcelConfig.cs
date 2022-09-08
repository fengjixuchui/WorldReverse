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
public class NewActivityCondExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15890
{
	// Fields
	protected SimpleSafeUInt32 condIdRawNum; // 0x10
	protected LogicType _condComb; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected NewActivityCond[] _cond; // 0x18

	// Properties
	public uint condId { /* [XID] */ /* 0x00000001897DB830-0x00000001897DB850 */ get => default; /* [XID] */ /* 0x00000001897E3040-0x00000001897E3060 */ protected set {} } // 0x0000000184E66530-0x0000000184E66600 0x0000000184E655D0-0x0000000184E656B0
	public LogicType condComb { /* [XID] */ /* 0x00000001897EA7E0-0x00000001897EA800 */ get => default; /* [XID] */ /* 0x00000001897F2630-0x00000001897F2650 */ protected set {} } // 0x0000000184E666B0-0x0000000184E66750 0x0000000184E66600-0x0000000184E666B0
	public NewActivityCond[] cond { /* [XID] */ /* 0x00000001897F9DA0-0x00000001897F9DC0 */ get => default; /* [XID] */ /* 0x0000000189801340-0x0000000189801360 */ protected set {} } // 0x0000000184E66490-0x0000000184E66530 0x0000000184E65830-0x0000000184E658E0

	// Constructors
	public NewActivityCondExcelConfig() {} // 0x0000000184E66930-0x0000000184E66990

	// Methods
	// [IDTag] // 0x0000000189808740-0x0000000189808780
	// [XID] // 0x0000000189808740-0x0000000189808780
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184E658E0-0x0000000184E65D00
	// [IDTag] // 0x0000000189812E40-0x0000000189812E80
	// [XID] // 0x0000000189812E40-0x0000000189812E80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184E65D00-0x0000000184E66080
	// [XID] // 0x000000018981D910-0x000000018981D930
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A5A */, bool useObjectPool = false /* Metadata: 0x00AF2A5E */) => default; // 0x0000000184E66080-0x0000000184E66490
	[BlackList] // 0x0000000189824DE0-0x0000000189824E20
	// [XID] // 0x0000000189824DE0-0x0000000189824E20
	public virtual void AutoAllocTypeFields() {} // 0x0000000184E656B0-0x0000000184E65750
	[BlackList] // 0x000000018982F380-0x000000018982F3C0
	// [XID] // 0x000000018982F380-0x000000018982F3C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184E65750-0x0000000184E65830
	[BlackList] // 0x0000000189839A00-0x0000000189839A40
	// [XID] // 0x0000000189839A00-0x0000000189839A40
	public virtual void ReturnToObjectPool() {} // 0x0000000184E66890-0x0000000184E66930
	[BlackList] // 0x0000000189844280-0x00000001898442C0
	// [XID] // 0x0000000189844280-0x00000001898442C0
	public virtual void OnPoolAllocated() {} // 0x0000000184E667F0-0x0000000184E66890
	[BlackList] // 0x000000018984E6E0-0x000000018984E720
	// [XID] // 0x000000018984E6E0-0x000000018984E720
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184E66750-0x0000000184E667F0
}


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
public class LockTemplateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15327
{
	// Fields
	protected string _type; // 0x10
	protected SimpleSafeFloat rangeRawNum; // 0x18
	protected SimpleSafeFloat combatPriRawNum; // 0x1C
	protected SimpleSafeFloat normalPriRawNum; // 0x20

	// Properties
	public string type { /* [XID] */ /* 0x0000000189AA1300-0x0000000189AA1320 */ get => default; /* [XID] */ /* 0x0000000189AA89E0-0x0000000189AA8A00 */ protected set {} } // 0x0000000181DF54D0-0x0000000181DF5570 0x0000000181DF52E0-0x0000000181DF5390
	public float range { /* [XID] */ /* 0x0000000189AB05E0-0x0000000189AB0600 */ get => default; /* [XID] */ /* 0x0000000189AB7C20-0x0000000189AB7C40 */ protected set {} } // 0x0000000181DF4350-0x0000000181DF4430 0x0000000181DF4430-0x0000000181DF4510
	public float combatPri { /* [XID] */ /* 0x0000000189ABF730-0x0000000189ABF750 */ get => default; /* [XID] */ /* 0x0000000189AC7100-0x0000000189AC7120 */ protected set {} } // 0x0000000181DF40D0-0x0000000181DF41B0 0x0000000181DF5200-0x0000000181DF52E0
	public float normalPri { /* [XID] */ /* 0x0000000189ACE7F0-0x0000000189ACE810 */ get => default; /* [XID] */ /* 0x0000000189AD66E0-0x0000000189AD6700 */ protected set {} } // 0x0000000181DF5120-0x0000000181DF5200 0x0000000181DF4B80-0x0000000181DF4C60

	// Constructors
	public LockTemplateExcelConfig() {} // 0x0000000181DF5610-0x0000000181DF5860

	// Methods
	// [IDTag] // 0x0000000189ADDF60-0x0000000189ADDFA0
	// [XID] // 0x0000000189ADDF60-0x0000000189ADDFA0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181DF4510-0x0000000181DF4860
	// [IDTag] // 0x0000000189AE84F0-0x0000000189AE8530
	// [XID] // 0x0000000189AE84F0-0x0000000189AE8530
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181DF4860-0x0000000181DF4B80
	// [XID] // 0x0000000189AF3310-0x0000000189AF3330
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07A9 */, bool useObjectPool = false /* Metadata: 0x00AF07AD */) => default; // 0x0000000181DF4C60-0x0000000181DF5120
	[BlackList] // 0x0000000189AFAB20-0x0000000189AFAB60
	// [XID] // 0x0000000189AFAB20-0x0000000189AFAB60
	public virtual void AutoAllocTypeFields() {} // 0x0000000181DF41B0-0x0000000181DF4250
	[BlackList] // 0x0000000189B04EA0-0x0000000189B04EE0
	// [XID] // 0x0000000189B04EA0-0x0000000189B04EE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181DF4250-0x0000000181DF4350
	[BlackList] // 0x0000000189B0F690-0x0000000189B0F6D0
	// [XID] // 0x0000000189B0F690-0x0000000189B0F6D0
	public virtual void ReturnToObjectPool() {} // 0x0000000181DF5570-0x0000000181DF5610
	[BlackList] // 0x0000000189B19910-0x0000000189B19950
	// [XID] // 0x0000000189B19910-0x0000000189B19950
	public virtual void OnPoolAllocated() {} // 0x0000000181DF5430-0x0000000181DF54D0
	[BlackList] // 0x0000000189B24220-0x0000000189B24260
	// [XID] // 0x0000000189B24220-0x0000000189B24260
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181DF5390-0x0000000181DF5430
}


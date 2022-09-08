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
public class CityTaskOpenExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15487
{
	// Fields
	protected SimpleSafeUInt32 cityIdRawNum; // 0x10
	protected SimpleSafeUInt32 questIdRawNum; // 0x14

	// Properties
	public uint cityId { /* [XID] */ /* 0x000000018977A900-0x000000018977A920 */ get => default; /* [XID] */ /* 0x0000000189782520-0x0000000189782540 */ protected set {} } // 0x0000000183190680-0x0000000183190750 0x0000000183190160-0x0000000183190240
	public uint questId { /* [XID] */ /* 0x0000000189789840-0x0000000189789860 */ get => default; /* [XID] */ /* 0x0000000189790F70-0x0000000189790F90 */ protected set {} } // 0x0000000183190090-0x0000000183190160 0x0000000183190240-0x0000000183190320

	// Constructors
	public CityTaskOpenExcelConfig() {} // 0x0000000183190930-0x0000000183190990

	// Methods
	// [IDTag] // 0x00000001897987A0-0x00000001897987E0
	// [XID] // 0x00000001897987A0-0x00000001897987E0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018318FE20-0x0000000183190090
	// [IDTag] // 0x00000001897A35A0-0x00000001897A35E0
	// [XID] // 0x00000001897A35A0-0x00000001897A35E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018318FC00-0x000000018318FE20
	// [XID] // 0x00000001897ADC10-0x00000001897ADC30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C18 */, bool useObjectPool = false /* Metadata: 0x00AF1C1C */) => default; // 0x0000000183190320-0x0000000183190680
	[BlackList] // 0x00000001897B5D90-0x00000001897B5DD0
	// [XID] // 0x00000001897B5D90-0x00000001897B5DD0
	public virtual void AutoAllocTypeFields() {} // 0x000000018318FA80-0x000000018318FB20
	[BlackList] // 0x00000001897C0A20-0x00000001897C0A60
	// [XID] // 0x00000001897C0A20-0x00000001897C0A60
	public virtual void AutoRecycleTypeFields() {} // 0x000000018318FB20-0x000000018318FC00
	[BlackList] // 0x00000001897CB070-0x00000001897CB0B0
	// [XID] // 0x00000001897CB070-0x00000001897CB0B0
	public virtual void ReturnToObjectPool() {} // 0x0000000183190890-0x0000000183190930
	[BlackList] // 0x00000001897D5790-0x00000001897D57D0
	// [XID] // 0x00000001897D5790-0x00000001897D57D0
	public virtual void OnPoolAllocated() {} // 0x00000001831907F0-0x0000000183190890
	[BlackList] // 0x00000001897E00F0-0x00000001897E0130
	// [XID] // 0x00000001897E00F0-0x00000001897E0130
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183190750-0x00000001831907F0
}


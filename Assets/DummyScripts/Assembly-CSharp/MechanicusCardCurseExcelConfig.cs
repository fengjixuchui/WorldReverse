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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MechanicusCardCurseExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16225
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 effectIDRawNum; // 0x14
	protected SimpleSafeUInt32 lastRoundRawNum; // 0x18
	protected uint _descTextMapHash; // 0x1C
	protected string[] _descParamList; // 0x20

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001898DE620-0x00000001898DE640 */ get => default; /* [XID] */ /* 0x00000001898E5E40-0x00000001898E5E60 */ protected set {} } // 0x000000018434AD70-0x000000018434AE40 0x0000000184349DE0-0x0000000184349EC0
	public uint effectID { /* [XID] */ /* 0x00000001898ED720-0x00000001898ED740 */ get => default; /* [XID] */ /* 0x00000001898F4F40-0x00000001898F4F60 */ protected set {} } // 0x000000018434B7D0-0x000000018434B8A0 0x000000018434ABE0-0x000000018434ACC0
	public uint lastRound { /* [XID] */ /* 0x00000001898FC670-0x00000001898FC690 */ get => default; /* [XID] */ /* 0x00000001899040F0-0x0000000189904110 */ protected set {} } // 0x000000018434A100-0x000000018434A1D0 0x000000018434AE40-0x000000018434AF20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018990B710-0x000000018990B730 */ get => default; /* [XID] */ /* 0x0000000189913400-0x0000000189913420 */ protected set {} } // 0x000000018434B5F0-0x000000018434B690 0x000000018434A1D0-0x000000018434A280
	public string desc { /* [XID] */ /* 0x000000018991AB50-0x000000018991AB70 */ get => default; } // 0x000000018434AF20-0x000000018434B0A0 
	public string[] descParamList { /* [XID] */ /* 0x0000000189922380-0x00000001899223A0 */ get => default; /* [XID] */ /* 0x0000000189929B40-0x0000000189929B60 */ protected set {} } // 0x0000000184349EC0-0x0000000184349F60 0x000000018434ACC0-0x000000018434AD70

	// Constructors
	public MechanicusCardCurseExcelConfig() {} // 0x000000018434B940-0x000000018434B9A0

	// Methods
	// [IDTag] // 0x0000000189931080-0x00000001899310C0
	// [XID] // 0x0000000189931080-0x00000001899310C0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018434A710-0x000000018434ABE0
	// [IDTag] // 0x000000018993BA50-0x000000018993BA90
	// [XID] // 0x000000018993BA50-0x000000018993BA90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018434A280-0x000000018434A710
	// [XID] // 0x0000000189945EC0-0x0000000189945EE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34D2 */, bool useObjectPool = false /* Metadata: 0x00AF34D6 */) => default; // 0x000000018434B0A0-0x000000018434B5F0
	[BlackList] // 0x000000018994D3F0-0x000000018994D430
	// [XID] // 0x000000018994D3F0-0x000000018994D430
	public virtual void AutoAllocTypeFields() {} // 0x0000000184349F60-0x000000018434A000
	[BlackList] // 0x0000000189957D00-0x0000000189957D40
	// [XID] // 0x0000000189957D00-0x0000000189957D40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018434A000-0x000000018434A100
	[BlackList] // 0x00000001899627F0-0x0000000189962830
	// [XID] // 0x00000001899627F0-0x0000000189962830
	public virtual void ReturnToObjectPool() {} // 0x000000018434B8A0-0x000000018434B940
	[BlackList] // 0x000000018996CBF0-0x000000018996CC30
	// [XID] // 0x000000018996CBF0-0x000000018996CC30
	public virtual void OnPoolAllocated() {} // 0x000000018434B730-0x000000018434B7D0
	[BlackList] // 0x00000001899776A0-0x00000001899776E0
	// [XID] // 0x00000001899776A0-0x00000001899776E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018434B690-0x000000018434B730
}


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
public class MpPlayScoreExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15877
{
	// Fields
	protected MpPlayType _playType; // 0x10
	protected SimpleSafeUInt32[] _param; // 0x18
	protected bool _isCalcScore; // 0x20

	// Properties
	public MpPlayType playType { /* [XID] */ /* 0x0000000189A01450-0x0000000189A01470 */ get => default; /* [XID] */ /* 0x0000000189A08D90-0x0000000189A08DB0 */ protected set {} } // 0x000000018319F610-0x000000018319F6B0 0x000000018319E630-0x000000018319E6E0
	public SimpleSafeUInt32[] param { /* [XID] */ /* 0x0000000189A10390-0x0000000189A103B0 */ get => default; /* [XID] */ /* 0x0000000189A17910-0x0000000189A17930 */ protected set {} } // 0x000000018319F6B0-0x000000018319F750 0x000000018319F560-0x000000018319F610
	public bool isCalcScore { /* [XID] */ /* 0x0000000189A1EFD0-0x0000000189A1EFF0 */ get => default; /* [XID] */ /* 0x0000000189A26600-0x0000000189A26620 */ protected set {} } // 0x000000018319F380-0x000000018319F420 0x000000018319EEC0-0x000000018319EF70

	// Constructors
	public MpPlayScoreExcelConfig() {} // 0x000000018319F7F0-0x000000018319F850

	// Methods
	// [IDTag] // 0x0000000189A2D930-0x0000000189A2D970
	// [XID] // 0x0000000189A2D930-0x0000000189A2D970
	public virtual bool ParseFromLine(string line) => default; // 0x000000018319EAA0-0x000000018319EEC0
	// [IDTag] // 0x0000000189A38490-0x0000000189A384D0
	// [XID] // 0x0000000189A38490-0x0000000189A384D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018319E6E0-0x000000018319EAA0
	// [XID] // 0x0000000189A42C30-0x0000000189A42C50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2928 */, bool useObjectPool = false /* Metadata: 0x00AF292C */) => default; // 0x000000018319EF70-0x000000018319F380
	[BlackList] // 0x0000000189A4A080-0x0000000189A4A0C0
	// [XID] // 0x0000000189A4A080-0x0000000189A4A0C0
	public virtual void AutoAllocTypeFields() {} // 0x000000018319E4E0-0x000000018319E580
	[BlackList] // 0x0000000189A54970-0x0000000189A549B0
	// [XID] // 0x0000000189A54970-0x0000000189A549B0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018319E580-0x000000018319E630
	[BlackList] // 0x0000000189A5F330-0x0000000189A5F370
	// [XID] // 0x0000000189A5F330-0x0000000189A5F370
	public virtual void ReturnToObjectPool() {} // 0x000000018319F750-0x000000018319F7F0
	[BlackList] // 0x0000000189A69ED0-0x0000000189A69F10
	// [XID] // 0x0000000189A69ED0-0x0000000189A69F10
	public virtual void OnPoolAllocated() {} // 0x000000018319F4C0-0x000000018319F560
	[BlackList] // 0x0000000189A74370-0x0000000189A743B0
	// [XID] // 0x0000000189A74370-0x0000000189A743B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018319F420-0x000000018319F4C0
}


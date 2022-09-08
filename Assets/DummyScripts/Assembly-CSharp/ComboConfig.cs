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
public class ComboConfig : IAutoAllocRecycle // TypeDefIndex: 15145
{
	// Fields
	protected SimpleSafeUInt32 comboUpLimitRawNum; // 0x10
	protected SimpleSafeFloat rateRawNum; // 0x14

	// Properties
	public uint comboUpLimit { /* [XID] */ /* 0x00000001896165A0-0x00000001896165C0 */ get => default; /* [XID] */ /* 0x000000018961DDD0-0x000000018961DDF0 */ protected set {} } // 0x0000000183689420-0x00000001836894F0 0x0000000183689B60-0x0000000183689C40
	public float rate { /* [XID] */ /* 0x0000000189625230-0x0000000189625250 */ get => default; /* [XID] */ /* 0x000000018962CA10-0x000000018962CA30 */ protected set {} } // 0x0000000183689710-0x00000001836897F0 0x0000000183689C40-0x0000000183689D20

	// Constructors
	public ComboConfig() {} // 0x0000000183689F00-0x0000000183689F60

	// Methods
	// [XID] // 0x0000000189634790-0x00000001896347B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001836894F0-0x0000000183689710
	// [XID] // 0x000000018963BEC0-0x000000018963BEE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0221 */, bool useObjectPool = false /* Metadata: 0x00AF0225 */) => default; // 0x00000001836897F0-0x0000000183689B60
	[BlackList] // 0x0000000189643580-0x00000001896435C0
	// [XID] // 0x0000000189643580-0x00000001896435C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183689280-0x0000000183689320
	[BlackList] // 0x000000018964DBA0-0x000000018964DBE0
	// [XID] // 0x000000018964DBA0-0x000000018964DBE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183689320-0x0000000183689420
	[BlackList] // 0x00000001896583B0-0x00000001896583F0
	// [XID] // 0x00000001896583B0-0x00000001896583F0
	public virtual void ReturnToObjectPool() {} // 0x0000000183689E60-0x0000000183689F00
	[BlackList] // 0x0000000189662900-0x0000000189662940
	// [XID] // 0x0000000189662900-0x0000000189662940
	public virtual void OnPoolAllocated() {} // 0x0000000183689DC0-0x0000000183689E60
	[BlackList] // 0x000000018966D160-0x000000018966D1A0
	// [XID] // 0x000000018966D160-0x000000018966D1A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183689D20-0x0000000183689DC0
}


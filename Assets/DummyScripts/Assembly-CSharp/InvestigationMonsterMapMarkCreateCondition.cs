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
public class InvestigationMonsterMapMarkCreateCondition : IAutoAllocRecycle // TypeDefIndex: 15771
{
	// Fields
	protected InvestigationMonsterMapMarkCreateConditionType _conditionType; // 0x10
	protected SimpleSafeUInt32 conditionParamRawNum; // 0x14

	// Properties
	public InvestigationMonsterMapMarkCreateConditionType conditionType { /* [XID] */ /* 0x000000018976BD00-0x000000018976BD20 */ get => default; /* [XID] */ /* 0x00000001897732C0-0x00000001897732E0 */ protected set {} } // 0x000000018491EEB0-0x000000018491EF50 0x000000018491EF50-0x000000018491F000
	public uint conditionParam { /* [XID] */ /* 0x000000018977A880-0x000000018977A8A0 */ get => default; /* [XID] */ /* 0x00000001897824C0-0x00000001897824E0 */ protected set {} } // 0x000000018491EA30-0x000000018491EB00 0x000000018491F360-0x000000018491F440

	// Constructors
	public InvestigationMonsterMapMarkCreateCondition() {} // 0x000000018491F620-0x000000018491F680

	// Methods
	// [XID] // 0x00000001897897A0-0x00000001897897C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018491EC70-0x000000018491EEB0
	// [XID] // 0x0000000189790F10-0x0000000189790F30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2592 */, bool useObjectPool = false /* Metadata: 0x00AF2596 */) => default; // 0x000000018491F000-0x000000018491F360
	[BlackList] // 0x0000000189798720-0x0000000189798760
	// [XID] // 0x0000000189798720-0x0000000189798760
	public virtual void AutoAllocTypeFields() {} // 0x000000018491EB00-0x000000018491EBA0
	[BlackList] // 0x00000001897A3520-0x00000001897A3560
	// [XID] // 0x00000001897A3520-0x00000001897A3560
	public virtual void AutoRecycleTypeFields() {} // 0x000000018491EBA0-0x000000018491EC70
	[BlackList] // 0x00000001897ADB70-0x00000001897ADBB0
	// [XID] // 0x00000001897ADB70-0x00000001897ADBB0
	public virtual void ReturnToObjectPool() {} // 0x000000018491F580-0x000000018491F620
	[BlackList] // 0x00000001897B89C0-0x00000001897B8A00
	// [XID] // 0x00000001897B89C0-0x00000001897B8A00
	public virtual void OnPoolAllocated() {} // 0x000000018491F4E0-0x000000018491F580
	[BlackList] // 0x00000001897C38B0-0x00000001897C38F0
	// [XID] // 0x00000001897C38B0-0x00000001897C38F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018491F440-0x000000018491F4E0
}


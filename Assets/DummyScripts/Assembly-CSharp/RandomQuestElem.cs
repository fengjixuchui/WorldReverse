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
public class RandomQuestElem : IAutoAllocRecycle // TypeDefIndex: 15982
{
	// Fields
	protected string[] _name; // 0x10
	protected SimpleSafeUInt32 poolIdRawNum; // 0x18

	// Properties
	public string[] name { /* [XID] */ /* 0x00000001896B5210-0x00000001896B5230 */ get => default; /* [XID] */ /* 0x00000001896BC3E0-0x00000001896BC400 */ protected set {} } // 0x0000000184B53420-0x0000000184B534C0 0x0000000184B52EC0-0x0000000184B52F70
	public uint poolId { /* [XID] */ /* 0x00000001896C3960-0x00000001896C3980 */ get => default; /* [XID] */ /* 0x00000001896CADB0-0x00000001896CADD0 */ protected set {} } // 0x0000000184B52900-0x0000000184B529D0 0x0000000184B52DE0-0x0000000184B52EC0

	// Constructors
	public RandomQuestElem() {} // 0x0000000184B53560-0x0000000184B535C0

	// Methods
	// [XID] // 0x00000001896D2460-0x00000001896D2480
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B529D0-0x0000000184B52DE0
	// [XID] // 0x00000001896D9E90-0x00000001896D9EB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CE8 */, bool useObjectPool = false /* Metadata: 0x00AF2CEC */) => default; // 0x0000000184B52F70-0x0000000184B532E0
	[BlackList] // 0x00000001896E14D0-0x00000001896E1510
	// [XID] // 0x00000001896E14D0-0x00000001896E1510
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B52780-0x0000000184B52820
	[BlackList] // 0x00000001896EB860-0x00000001896EB8A0
	// [XID] // 0x00000001896EB860-0x00000001896EB8A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B52820-0x0000000184B52900
	[BlackList] // 0x00000001896F5F60-0x00000001896F5FA0
	// [XID] // 0x00000001896F5F60-0x00000001896F5FA0
	public virtual void ReturnToObjectPool() {} // 0x0000000184B534C0-0x0000000184B53560
	[BlackList] // 0x0000000189700320-0x0000000189700360
	// [XID] // 0x0000000189700320-0x0000000189700360
	public virtual void OnPoolAllocated() {} // 0x0000000184B53380-0x0000000184B53420
	[BlackList] // 0x000000018970ABE0-0x000000018970AC20
	// [XID] // 0x000000018970ABE0-0x000000018970AC20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B532E0-0x0000000184B53380
}


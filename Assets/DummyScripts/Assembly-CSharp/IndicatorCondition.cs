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
public class IndicatorCondition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18477
{
	// Properties
	public virtual bool TimeCheck { /* [XID] */ /* 0x000000018982EF20-0x000000018982EF40 */ get => default; } // 0x000000018515CB60-0x000000018515CC00 

	// Constructors
	public IndicatorCondition() {} // 0x000000018515DF60-0x000000018515DFC0

	// Methods
	// [XID] // 0x00000001897B9A90-0x00000001897B9AB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018515DBF0-0x000000018515DCA0
	// [XID] // 0x00000001897C1B30-0x00000001897C1B50
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018515D9A0-0x000000018515DA50
	// [XID] // 0x00000001897C9500-0x00000001897C9520
	public virtual IndicatorCondition Clone(bool useObjectPool = false /* Metadata: 0x00AF9EBD */) => default; // 0x000000018515D6C0-0x000000018515D7A0
	// [XID] // 0x00000001897D0AF0-0x00000001897D0B10
	public virtual int GetHashNum() => default; // 0x000000018515CA90-0x000000018515CB60
	// [XID] // 0x00000001897D88D0-0x00000001897D88F0
	public virtual void InitEmpty() {} // 0x000000018515D230-0x000000018515D2D0
	[BlackList] // 0x00000001897DF970-0x00000001897DF9B0
	// [XID] // 0x00000001897DF970-0x00000001897DF9B0
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018515CCE0-0x000000018515D060
	// [XID] // 0x00000001897EA320-0x00000001897EA340
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018515C5D0-0x000000018515C680
	[BlackList] // 0x00000001897F1FD0-0x00000001897F2010
	// [XID] // 0x00000001897F1FD0-0x00000001897F2010
	public static IndicatorCondition ParseFromJson(JSONNode node) => default; // 0x000000018515D7A0-0x000000018515D9A0
	// [XID] // 0x00000001897FC8C0-0x00000001897FC8E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EBE */, bool useObjectPool = false /* Metadata: 0x00AF9EC2 */) => default; // 0x000000018515D3C0-0x000000018515D6C0
	// [XID] // 0x0000000189803DD0-0x0000000189803DF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EC3 */, bool useObjectPool = false /* Metadata: 0x00AF9EC7 */) => default; // 0x000000018515CC00-0x000000018515CCE0
	// [XID] // 0x000000018980B2A0-0x000000018980B2C0
	public static IndicatorCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EC8 */, bool useObjectPool = false /* Metadata: 0x00AF9ECC */) => default; // 0x000000018515D060-0x000000018515D230
	[BlackList] // 0x00000001898129A0-0x00000001898129E0
	// [XID] // 0x00000001898129A0-0x00000001898129E0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018515C680-0x000000018515C950
	// [XID] // 0x000000018981D4F0-0x000000018981D510
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018515DA50-0x000000018515DB00
	[BlackList] // 0x0000000189824960-0x00000001898249A0
	// [XID] // 0x0000000189824960-0x00000001898249A0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018515D2D0-0x000000018515D3C0
	// [XID] // 0x0000000189836830-0x0000000189836850
	public virtual bool Register(LCIndicatorPlugin plugin, int state, int index, LCIndicatorPlugin.DominatorCondition condition) => default; // 0x000000018515DB00-0x000000018515DBF0
	// [XID] // 0x000000018983DC00-0x000000018983DC20
	public virtual bool OnTriggered(LCIndicatorPlugin plugin, int state, BaseEvent fromEvent) => default; // 0x000000018515DDE0-0x000000018515DEC0
	[BlackList] // 0x0000000189845450-0x0000000189845490
	// [XID] // 0x0000000189845450-0x0000000189845490
	public virtual void AutoAllocTypeFields() {} // 0x000000018515C950-0x000000018515C9F0
	[BlackList] // 0x000000018984F7C0-0x000000018984F800
	// [XID] // 0x000000018984F7C0-0x000000018984F800
	public virtual void AutoRecycleTypeFields() {} // 0x000000018515C9F0-0x000000018515CA90
	[BlackList] // 0x0000000189859DD0-0x0000000189859E10
	// [XID] // 0x0000000189859DD0-0x0000000189859E10
	public virtual void ReturnToObjectPool() {} // 0x000000018515DEC0-0x000000018515DF60
	[BlackList] // 0x0000000189864250-0x0000000189864290
	// [XID] // 0x0000000189864250-0x0000000189864290
	public virtual void OnPoolAllocated() {} // 0x000000018515DD40-0x000000018515DDE0
	[BlackList] // 0x000000018986E670-0x000000018986E6B0
	// [XID] // 0x000000018986E670-0x000000018986E6B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018515DCA0-0x000000018515DD40
}


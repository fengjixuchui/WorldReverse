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
public class EmotionTemplateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15567
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeInt32 freeStyleIdRawNum; // 0x14
	protected string _bubbleName; // 0x18
	protected string _emotionPath; // 0x20
	protected SimpleSafeFloat protectTimeRawNum; // 0x28

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001897C4F60-0x00000001897C4F80 */ get => default; /* [XID] */ /* 0x00000001897CC750-0x00000001897CC770 */ protected set {} } // 0x00000001845BD2C0-0x00000001845BD390 0x00000001845BC620-0x00000001845BC700
	public int freeStyleId { /* [XID] */ /* 0x00000001897D3FC0-0x00000001897D3FE0 */ get => default; /* [XID] */ /* 0x00000001897DB8F0-0x00000001897DB910 */ protected set {} } // 0x00000001845BD390-0x00000001845BD460 0x00000001845BDA60-0x00000001845BDB40
	public string bubbleName { /* [XID] */ /* 0x00000001897E3140-0x00000001897E3160 */ get => default; /* [XID] */ /* 0x00000001897EA8E0-0x00000001897EA900 */ protected set {} } // 0x00000001845BD9C0-0x00000001845BDA60 0x00000001845BD210-0x00000001845BD2C0
	public string emotionPath { /* [XID] */ /* 0x00000001897F2670-0x00000001897F2690 */ get => default; /* [XID] */ /* 0x00000001897F9E40-0x00000001897F9E60 */ protected set {} } // 0x00000001845BC990-0x00000001845BCA30 0x00000001845BC700-0x00000001845BC7B0
	public float protectTime { /* [XID] */ /* 0x0000000189801400-0x0000000189801420 */ get => default; /* [XID] */ /* 0x0000000189808800-0x0000000189808820 */ protected set {} } // 0x00000001845BCA30-0x00000001845BCB10 0x00000001845BC540-0x00000001845BC620

	// Constructors
	public EmotionTemplateExcelConfig() {} // 0x00000001845BDD20-0x00000001845BDD80

	// Methods
	// [IDTag] // 0x00000001898101D0-0x0000000189810210
	// [XID] // 0x00000001898101D0-0x0000000189810210
	public virtual bool ParseFromLine(string line) => default; // 0x00000001845BCE80-0x00000001845BD210
	// [IDTag] // 0x000000018981AA40-0x000000018981AA80
	// [XID] // 0x000000018981AA40-0x000000018981AA80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001845BCB10-0x00000001845BCE80
	// [XID] // 0x0000000189824E80-0x0000000189824EA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F4D */, bool useObjectPool = false /* Metadata: 0x00AF1F51 */) => default; // 0x00000001845BD460-0x00000001845BD9C0
	[BlackList] // 0x000000018982C850-0x000000018982C890
	// [XID] // 0x000000018982C850-0x000000018982C890
	public virtual void AutoAllocTypeFields() {} // 0x00000001845BC7B0-0x00000001845BC850
	[BlackList] // 0x0000000189836D90-0x0000000189836DD0
	// [XID] // 0x0000000189836D90-0x0000000189836DD0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001845BC850-0x00000001845BC990
	[BlackList] // 0x0000000189840FC0-0x0000000189841000
	// [XID] // 0x0000000189840FC0-0x0000000189841000
	public virtual void ReturnToObjectPool() {} // 0x00000001845BDC80-0x00000001845BDD20
	[BlackList] // 0x000000018984B750-0x000000018984B790
	// [XID] // 0x000000018984B750-0x000000018984B790
	public virtual void OnPoolAllocated() {} // 0x00000001845BDBE0-0x00000001845BDC80
	[BlackList] // 0x00000001898557B0-0x00000001898557F0
	// [XID] // 0x00000001898557B0-0x00000001898557F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845BDB40-0x00000001845BDBE0
}


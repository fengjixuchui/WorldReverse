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
public class PriceTierConfig : IAutoAllocRecycle // TypeDefIndex: 16147
{
	// Fields
	protected string _tierName; // 0x10
	protected SimpleSafeUInt32 vipPointRawNum; // 0x18

	// Properties
	public string tierName { /* [XID] */ /* 0x0000000189BAC710-0x0000000189BAC730 */ get => default; /* [XID] */ /* 0x0000000189BB3FB0-0x0000000189BB3FD0 */ protected set {} } // 0x0000000182E77000-0x0000000182E770A0 0x0000000182E770A0-0x0000000182E77150
	public uint vipPoint { /* [XID] */ /* 0x0000000189BBB690-0x0000000189BBB6B0 */ get => default; /* [XID] */ /* 0x0000000189BC34B0-0x0000000189BC34D0 */ protected set {} } // 0x0000000182E76F30-0x0000000182E77000 0x0000000182E76830-0x0000000182E76910

	// Constructors
	public PriceTierConfig() {} // 0x0000000182E776A0-0x0000000182E77700

	// Methods
	// [IDTag] // 0x0000000189BCAC50-0x0000000189BCAC90
	// [XID] // 0x0000000189BCAC50-0x0000000189BCAC90
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182E76A90-0x0000000182E76D00
	// [IDTag] // 0x0000000189BD5190-0x0000000189BD51D0
	// [XID] // 0x0000000189BD5190-0x0000000189BD51D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E76D00-0x0000000182E76F30
	// [XID] // 0x0000000189BDFB60-0x0000000189BDFB80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3277 */, bool useObjectPool = false /* Metadata: 0x00AF327B */) => default; // 0x0000000182E77150-0x0000000182E774C0
	[BlackList] // 0x00000001895EC770-0x00000001895EC7B0
	// [XID] // 0x00000001895EC770-0x00000001895EC7B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E76910-0x0000000182E769B0
	[BlackList] // 0x00000001895F6FE0-0x00000001895F7020
	// [XID] // 0x00000001895F6FE0-0x00000001895F7020
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E769B0-0x0000000182E76A90
	[BlackList] // 0x0000000189601580-0x00000001896015C0
	// [XID] // 0x0000000189601580-0x00000001896015C0
	public virtual void ReturnToObjectPool() {} // 0x0000000182E77600-0x0000000182E776A0
	[BlackList] // 0x000000018960BE00-0x000000018960BE40
	// [XID] // 0x000000018960BE00-0x000000018960BE40
	public virtual void OnPoolAllocated() {} // 0x0000000182E77560-0x0000000182E77600
	[BlackList] // 0x0000000189616340-0x0000000189616380
	// [XID] // 0x0000000189616340-0x0000000189616380
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E774C0-0x0000000182E77560
}


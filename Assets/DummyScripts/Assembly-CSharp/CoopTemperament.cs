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
public class CoopTemperament : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17759
{
	// Fields
	private uint _value; // 0x10
	private float _ratio; // 0x14

	// Properties
	public uint value { /* [XID] */ /* 0x00000001898B85A0-0x00000001898B85C0 */ get => default; /* [XID] */ /* 0x00000001898BFD20-0x00000001898BFD40 */ private set {} } // 0x0000000183743670-0x0000000183743710 0x00000001837435C0-0x0000000183743670
	public float ratio { /* [XID] */ /* 0x00000001898C7620-0x00000001898C7640 */ get => default; /* [XID] */ /* 0x00000001898CEC30-0x00000001898CEC50 */ private set {} } // 0x00000001837432C0-0x0000000183743370 0x0000000183743A90-0x0000000183743B40

	// Constructors
	public CoopTemperament() {} // 0x0000000183744420-0x0000000183744480

	// Methods
	// [XID] // 0x00000001898D6600-0x00000001898D6620
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183744130-0x0000000183744240
	// [XID] // 0x00000001898DE2E0-0x00000001898DE300
	public void InitEmpty() {} // 0x0000000183743B40-0x0000000183743BE0
	[BlackList] // 0x00000001898E5AE0-0x00000001898E5B20
	// [XID] // 0x00000001898E5AE0-0x00000001898E5B20
	public bool FromJson(JSONNode node) => default; // 0x0000000183743710-0x0000000183743A90
	// [XID] // 0x00000001898F03E0-0x00000001898F0400
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183742C30-0x0000000183742EB0
	// [XID] // 0x00000001898F7E30-0x00000001898F7E50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B2F */, bool useObjectPool = false /* Metadata: 0x00AF7B33 */) => default; // 0x0000000183743BE0-0x0000000183743EE0
	// [XID] // 0x00000001898FF4B0-0x00000001898FF4D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B34 */, bool useObjectPool = false /* Metadata: 0x00AF7B38 */) => default; // 0x0000000183743370-0x00000001837435C0
	[BlackList] // 0x0000000189906C70-0x0000000189906CB0
	// [XID] // 0x0000000189906C70-0x0000000189906CB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183742EB0-0x0000000183743180
	// [XID] // 0x0000000189911400-0x0000000189911420
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183743EE0-0x0000000183744130
	[BlackList] // 0x0000000189918FE0-0x0000000189919020
	// [XID] // 0x0000000189918FE0-0x0000000189919020
	public virtual void AutoAllocTypeFields() {} // 0x0000000183743180-0x0000000183743220
	[BlackList] // 0x0000000189923820-0x0000000189923860
	// [XID] // 0x0000000189923820-0x0000000189923860
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183743220-0x00000001837432C0
	[BlackList] // 0x000000018992DE30-0x000000018992DE70
	// [XID] // 0x000000018992DE30-0x000000018992DE70
	public virtual void ReturnToObjectPool() {} // 0x0000000183744380-0x0000000183744420
	[BlackList] // 0x0000000189938230-0x0000000189938270
	// [XID] // 0x0000000189938230-0x0000000189938270
	public virtual void OnPoolAllocated() {} // 0x00000001837442E0-0x0000000183744380
	[BlackList] // 0x00000001899428D0-0x0000000189942910
	// [XID] // 0x00000001899428D0-0x0000000189942910
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183744240-0x00000001837442E0
}


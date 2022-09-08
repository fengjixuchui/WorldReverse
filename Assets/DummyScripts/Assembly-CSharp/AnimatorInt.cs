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
public class AnimatorInt : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18863
{
	// Fields
	private string _name; // 0x10
	private SimpleSafeUInt32 valueRawNum; // 0x18

	// Properties
	public string name { /* [XID] */ /* 0x00000001898BB750-0x00000001898BB770 */ get => default; /* [XID] */ /* 0x00000001898C29A0-0x00000001898C29C0 */ private set {} } // 0x0000000180F76BF0-0x0000000180F76C90 0x0000000180F76280-0x0000000180F76330
	public uint value { /* [XID] */ /* 0x00000001898CA3C0-0x00000001898CA3E0 */ get => default; /* [XID] */ /* 0x00000001898D1BF0-0x00000001898D1C10 */ private set {} } // 0x0000000180F75E30-0x0000000180F75F00 0x0000000180F75D50-0x0000000180F75E30

	// Constructors
	public AnimatorInt() {} // 0x0000000180F76D30-0x0000000180F76D90

	// Methods
	// [XID] // 0x00000001898D9470-0x00000001898D9490
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180F769A0-0x0000000180F76AB0
	// [XID] // 0x00000001898E1040-0x00000001898E1060
	public void InitEmpty() {} // 0x0000000180F76330-0x0000000180F76430
	[BlackList] // 0x00000001898E8B20-0x00000001898E8B60
	// [XID] // 0x00000001898E8B20-0x00000001898E8B60
	public bool FromJson(JSONNode node) => default; // 0x0000000180F75F00-0x0000000180F76280
	// [XID] // 0x00000001898F32A0-0x00000001898F32C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180F75330-0x0000000180F75640
	// [XID] // 0x00000001898FA920-0x00000001898FA940
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB17B */, bool useObjectPool = false /* Metadata: 0x00AFB17F */) => default; // 0x0000000180F76430-0x0000000180F76730
	// [XID] // 0x0000000189902520-0x0000000189902540
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB180 */, bool useObjectPool = false /* Metadata: 0x00AFB184 */) => default; // 0x0000000180F75A90-0x0000000180F75D50
	[BlackList] // 0x0000000189909AA0-0x0000000189909AE0
	// [XID] // 0x0000000189909AA0-0x0000000189909AE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180F75640-0x0000000180F75910
	// [XID] // 0x0000000189914480-0x00000001899144A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180F76730-0x0000000180F769A0
	[BlackList] // 0x000000018991BF40-0x000000018991BF80
	// [XID] // 0x000000018991BF40-0x000000018991BF80
	public virtual void AutoAllocTypeFields() {} // 0x0000000180F75910-0x0000000180F759B0
	[BlackList] // 0x0000000189926600-0x0000000189926640
	// [XID] // 0x0000000189926600-0x0000000189926640
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180F759B0-0x0000000180F75A90
	[BlackList] // 0x0000000189930D00-0x0000000189930D40
	// [XID] // 0x0000000189930D00-0x0000000189930D40
	public virtual void ReturnToObjectPool() {} // 0x0000000180F76C90-0x0000000180F76D30
	[BlackList] // 0x000000018993B5B0-0x000000018993B5F0
	// [XID] // 0x000000018993B5B0-0x000000018993B5F0
	public virtual void OnPoolAllocated() {} // 0x0000000180F76B50-0x0000000180F76BF0
	[BlackList] // 0x0000000189945A40-0x0000000189945A80
	// [XID] // 0x0000000189945A40-0x0000000189945A80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180F76AB0-0x0000000180F76B50
}


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
public class AIPoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17383
{
	// Fields
	private SimpleSafeFloat xRawNum; // 0x10
	private SimpleSafeFloat yRawNum; // 0x14

	// Properties
	public float x { /* [XID] */ /* 0x0000000189618250-0x0000000189618270 */ get => default; /* [XID] */ /* 0x0000000189840DA0-0x0000000189840DC0 */ private set {} } // 0x0000000183CF6050-0x0000000183CF6130 0x0000000183CF6510-0x0000000183CF65F0
	public float y { /* [XID] */ /* 0x0000000189778240-0x0000000189778260 */ get => default; /* [XID] */ /* 0x000000018984F980-0x000000018984F9A0 */ private set {} } // 0x0000000183CF5BF0-0x0000000183CF5CD0 0x0000000183CF65F0-0x0000000183CF66D0

	// Constructors
	public AIPoint() {} // 0x0000000183CF6C10-0x0000000183CF6CB0

	// Methods
	// [XID] // 0x00000001897CE750-0x00000001897CE770
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183CF6920-0x0000000183CF6A30
	// [XID] // 0x000000018985DE10-0x000000018985DE30
	public void InitEmpty() {} // 0x0000000183CF6130-0x0000000183CF6210
	[BlackList] // 0x0000000189865850-0x0000000189865890
	// [XID] // 0x0000000189865850-0x0000000189865890
	public bool FromJson(JSONNode node) => default; // 0x0000000183CF5CD0-0x0000000183CF6050
	// [XID] // 0x000000018986FD40-0x000000018986FD60
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183CF5240-0x0000000183CF5550
	// [XID] // 0x0000000189877450-0x0000000189877470
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C7B */, bool useObjectPool = false /* Metadata: 0x00AF6C7F */) => default; // 0x0000000183CF6210-0x0000000183CF6510
	// [XID] // 0x000000018987ECC0-0x000000018987ECE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C80 */, bool useObjectPool = false /* Metadata: 0x00AF6C84 */) => default; // 0x0000000183CF59A0-0x0000000183CF5BF0
	[BlackList] // 0x0000000189886180-0x00000001898861C0
	// [XID] // 0x0000000189886180-0x00000001898861C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183CF5550-0x0000000183CF5820
	// [XID] // 0x0000000189890420-0x0000000189890440
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183CF66D0-0x0000000183CF6920
	[BlackList] // 0x00000001898979A0-0x00000001898979E0
	// [XID] // 0x00000001898979A0-0x00000001898979E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183CF5820-0x0000000183CF58C0
	[BlackList] // 0x00000001898A1F20-0x00000001898A1F60
	// [XID] // 0x00000001898A1F20-0x00000001898A1F60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183CF58C0-0x0000000183CF59A0
	[BlackList] // 0x00000001898AC620-0x00000001898AC660
	// [XID] // 0x00000001898AC620-0x00000001898AC660
	public virtual void ReturnToObjectPool() {} // 0x0000000183CF6B70-0x0000000183CF6C10
	[BlackList] // 0x00000001898B6DF0-0x00000001898B6E30
	// [XID] // 0x00000001898B6DF0-0x00000001898B6E30
	public virtual void OnPoolAllocated() {} // 0x0000000183CF6AD0-0x0000000183CF6B70
	[BlackList] // 0x00000001898C1600-0x00000001898C1640
	// [XID] // 0x00000001898C1600-0x00000001898C1640
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183CF6A30-0x0000000183CF6AD0
}


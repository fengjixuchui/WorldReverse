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
public class ConfigMoveSmoothedSpeed : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18572
{
	// Fields
	private SimpleSafeFloat maxSpeedRawNum; // 0x10
	private SimpleSafeFloat accelerationXZRawNum; // 0x14
	private SimpleSafeFloat accelerationYRawNum; // 0x18
	private SimpleSafeFloat zeroingSpeedXZRawNum; // 0x1C
	private SimpleSafeFloat zeroingSpeedYRawNum; // 0x20

	// Properties
	public float maxSpeed { /* [XID] */ /* 0x0000000189814BD0-0x0000000189814BF0 */ get => default; /* [XID] */ /* 0x0000000189B61090-0x0000000189B610B0 */ private set {} } // 0x000000018529E010-0x000000018529E0F0 0x000000018529E6C0-0x000000018529E7A0
	public float accelerationXZ { /* [XID] */ /* 0x0000000189B687E0-0x0000000189B68800 */ get => default; /* [XID] */ /* 0x0000000189B6FCE0-0x0000000189B6FD00 */ private set {} } // 0x000000018529D550-0x000000018529D630 0x000000018529DF30-0x000000018529E010
	public float accelerationY { /* [XID] */ /* 0x0000000189B771B0-0x0000000189B771D0 */ get => default; /* [XID] */ /* 0x0000000189B7E800-0x0000000189B7E820 */ private set {} } // 0x000000018529D390-0x000000018529D470 0x000000018529EE20-0x000000018529EF00
	public float zeroingSpeedXZ { /* [XID] */ /* 0x0000000189B864E0-0x0000000189B86500 */ get => default; /* [XID] */ /* 0x0000000189B8D530-0x0000000189B8D550 */ private set {} } // 0x000000018529DAD0-0x000000018529DBB0 0x000000018529E500-0x000000018529E5E0
	public float zeroingSpeedY { /* [XID] */ /* 0x0000000189B94B30-0x0000000189B94B50 */ get => default; /* [XID] */ /* 0x0000000189B9C220-0x0000000189B9C240 */ private set {} } // 0x000000018529D470-0x000000018529D550 0x000000018529E5E0-0x000000018529E6C0

	// Constructors
	public ConfigMoveSmoothedSpeed() {} // 0x000000018529EFA0-0x000000018529F000

	// Methods
	// [XID] // 0x0000000189BA3970-0x0000000189BA3990
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018529EB80-0x000000018529ECE0
	// [XID] // 0x0000000189BAADE0-0x0000000189BAAE00
	public void InitEmpty() {} // 0x000000018529E0F0-0x000000018529E200
	[BlackList] // 0x0000000189BB23B0-0x0000000189BB23F0
	// [XID] // 0x0000000189BB23B0-0x0000000189BB23F0
	public bool FromJson(JSONNode node) => default; // 0x000000018529DBB0-0x000000018529DF30
	// [XID] // 0x0000000189BBC8D0-0x0000000189BBC8F0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018529C850-0x000000018529CF00
	// [XID] // 0x0000000189BC4540-0x0000000189BC4560
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA471 */, bool useObjectPool = false /* Metadata: 0x00AFA475 */) => default; // 0x000000018529E200-0x000000018529E500
	// [XID] // 0x0000000189BCBF40-0x0000000189BCBF60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA476 */, bool useObjectPool = false /* Metadata: 0x00AFA47A */) => default; // 0x000000018529D630-0x000000018529DAD0
	[BlackList] // 0x0000000189BD34B0-0x0000000189BD34F0
	// [XID] // 0x0000000189BD34B0-0x0000000189BD34F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018529CF00-0x000000018529D1D0
	// [XID] // 0x0000000189BDDF20-0x0000000189BDDF40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018529E7A0-0x000000018529EB80
	[BlackList] // 0x00000001895EAB10-0x00000001895EAB50
	// [XID] // 0x00000001895EAB10-0x00000001895EAB50
	public virtual void AutoAllocTypeFields() {} // 0x000000018529D1D0-0x000000018529D270
	[BlackList] // 0x00000001895F51D0-0x00000001895F5210
	// [XID] // 0x00000001895F51D0-0x00000001895F5210
	public virtual void AutoRecycleTypeFields() {} // 0x000000018529D270-0x000000018529D390
	[BlackList] // 0x00000001895FF7D0-0x00000001895FF810
	// [XID] // 0x00000001895FF7D0-0x00000001895FF810
	public virtual void ReturnToObjectPool() {} // 0x000000018529EF00-0x000000018529EFA0
	[BlackList] // 0x000000018960A170-0x000000018960A1B0
	// [XID] // 0x000000018960A170-0x000000018960A1B0
	public virtual void OnPoolAllocated() {} // 0x000000018529ED80-0x000000018529EE20
	[BlackList] // 0x00000001896146A0-0x00000001896146E0
	// [XID] // 0x00000001896146A0-0x00000001896146E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018529ECE0-0x000000018529ED80
}


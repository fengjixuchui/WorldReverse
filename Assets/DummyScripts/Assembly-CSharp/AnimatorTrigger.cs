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
public class AnimatorTrigger : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18865
{
	// Fields
	private SimpleSafeUInt32 idRawNum; // 0x10
	private bool _isSet; // 0x14

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899F3F30-0x00000001899F3F50 */ get => default; /* [XID] */ /* 0x00000001899FB6B0-0x00000001899FB6D0 */ private set {} } // 0x00000001831411C0-0x0000000183141290 0x0000000183140870-0x0000000183140950
	public bool isSet { /* [XID] */ /* 0x0000000189A02970-0x0000000189A02990 */ get => default; /* [XID] */ /* 0x0000000189A0A0E0-0x0000000189A0A100 */ private set {} } // 0x0000000183140700-0x00000001831407A0 0x0000000183140EC0-0x0000000183140F70

	// Constructors
	public AnimatorTrigger() {} // 0x0000000183141330-0x0000000183141390

	// Methods
	// [XID] // 0x0000000189A11A20-0x0000000189A11A40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183140F70-0x0000000183141080
	// [XID] // 0x0000000189A18C30-0x0000000189A18C50
	public void InitEmpty() {} // 0x00000001831407A0-0x0000000183140870
	[BlackList] // 0x0000000189A20290-0x0000000189A202D0
	// [XID] // 0x0000000189A20290-0x0000000189A202D0
	public bool FromJson(JSONNode node) => default; // 0x0000000183140380-0x0000000183140700
	// [XID] // 0x0000000189A2A760-0x0000000189A2A780
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018313F9D0-0x000000018313FCB0
	// [XID] // 0x0000000189A31CA0-0x0000000189A31CC0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB18F */, bool useObjectPool = false /* Metadata: 0x00AFB193 */) => default; // 0x0000000183140950-0x0000000183140C50
	// [XID] // 0x0000000189A39710-0x0000000189A39730
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB194 */, bool useObjectPool = false /* Metadata: 0x00AFB198 */) => default; // 0x00000001831400F0-0x0000000183140380
	[BlackList] // 0x0000000189A40E90-0x0000000189A40ED0
	// [XID] // 0x0000000189A40E90-0x0000000189A40ED0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018313FCB0-0x000000018313FF80
	// [XID] // 0x0000000189A4B4A0-0x0000000189A4B4C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183140C50-0x0000000183140EC0
	[BlackList] // 0x0000000189A52AC0-0x0000000189A52B00
	// [XID] // 0x0000000189A52AC0-0x0000000189A52B00
	public virtual void AutoAllocTypeFields() {} // 0x000000018313FF80-0x0000000183140020
	[BlackList] // 0x0000000189A5D5E0-0x0000000189A5D620
	// [XID] // 0x0000000189A5D5E0-0x0000000189A5D620
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183140020-0x00000001831400F0
	[BlackList] // 0x0000000189A68230-0x0000000189A68270
	// [XID] // 0x0000000189A68230-0x0000000189A68270
	public virtual void ReturnToObjectPool() {} // 0x0000000183141290-0x0000000183141330
	[BlackList] // 0x0000000189A727B0-0x0000000189A727F0
	// [XID] // 0x0000000189A727B0-0x0000000189A727F0
	public virtual void OnPoolAllocated() {} // 0x0000000183141120-0x00000001831411C0
	[BlackList] // 0x0000000189A7D190-0x0000000189A7D1D0
	// [XID] // 0x0000000189A7D190-0x0000000189A7D1D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183141080-0x0000000183141120
}


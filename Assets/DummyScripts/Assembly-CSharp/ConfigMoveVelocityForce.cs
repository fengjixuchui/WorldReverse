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
public class ConfigMoveVelocityForce : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18571
{
	// Fields
	private bool _muteAll; // 0x10
	private bool _useAll; // 0x11
	private VelocityForceType[] _includeForces; // 0x18
	private VelocityForceType[] _excludeForces; // 0x20

	// Properties
	public bool muteAll { /* [XID] */ /* 0x0000000189A9F790-0x0000000189A9F7B0 */ get => default; /* [XID] */ /* 0x0000000189AA7020-0x0000000189AA7040 */ private set {} } // 0x00000001831D9230-0x00000001831D92D0 0x00000001831D9180-0x00000001831D9230
	public bool useAll { /* [XID] */ /* 0x0000000189AAE6C0-0x0000000189AAE6E0 */ get => default; /* [XID] */ /* 0x0000000189AB5F40-0x0000000189AB5F60 */ private set {} } // 0x00000001831D92D0-0x00000001831D9370 0x00000001831D99A0-0x00000001831D9A50
	public VelocityForceType[] includeForces { /* [XID] */ /* 0x0000000189ABD9D0-0x0000000189ABD9F0 */ get => default; /* [XID] */ /* 0x0000000189AC5530-0x0000000189AC5550 */ private set {} } // 0x00000001831D8BA0-0x00000001831D8C40 0x00000001831D8C40-0x00000001831D8CF0
	public VelocityForceType[] excludeForces { /* [XID] */ /* 0x0000000189ACC940-0x0000000189ACC960 */ get => default; /* [XID] */ /* 0x0000000189AD46E0-0x0000000189AD4700 */ private set {} } // 0x00000001831D8CF0-0x00000001831D8D90 0x00000001831D9A50-0x00000001831D9B00

	// Constructors
	public ConfigMoveVelocityForce() {} // 0x00000001831D9BA0-0x00000001831D9C10

	// Methods
	// [XID] // 0x0000000189ADC060-0x0000000189ADC080
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001831D9720-0x00000001831D9860
	// [XID] // 0x0000000189AE39F0-0x0000000189AE3A10
	public void InitEmpty() {} // 0x00000001831D8D90-0x00000001831D8E80
	[BlackList] // 0x0000000189AEB270-0x0000000189AEB2B0
	// [XID] // 0x0000000189AEB270-0x0000000189AEB2B0
	public bool FromJson(JSONNode node) => default; // 0x00000001831D8820-0x00000001831D8BA0
	// [XID] // 0x0000000189AF5AF0-0x0000000189AF5B10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001831D7C10-0x00000001831D8050
	// [XID] // 0x0000000189AFCFF0-0x0000000189AFD010
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA467 */, bool useObjectPool = false /* Metadata: 0x00AFA46B */) => default; // 0x00000001831D8E80-0x00000001831D9180
	// [XID] // 0x0000000189B047C0-0x0000000189B047E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA46C */, bool useObjectPool = false /* Metadata: 0x00AFA470 */) => default; // 0x00000001831D8470-0x00000001831D8820
	[BlackList] // 0x0000000189B0BF90-0x0000000189B0BFD0
	// [XID] // 0x0000000189B0BF90-0x0000000189B0BFD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001831D8050-0x00000001831D8320
	// [XID] // 0x0000000189B162F0-0x0000000189B16310
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001831D9370-0x00000001831D9720
	[BlackList] // 0x0000000189B1DA50-0x0000000189B1DA90
	// [XID] // 0x0000000189B1DA50-0x0000000189B1DA90
	public virtual void AutoAllocTypeFields() {} // 0x00000001831D8320-0x00000001831D83C0
	[BlackList] // 0x0000000189B280D0-0x0000000189B28110
	// [XID] // 0x0000000189B280D0-0x0000000189B28110
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831D83C0-0x00000001831D8470
	[BlackList] // 0x0000000189B32600-0x0000000189B32640
	// [XID] // 0x0000000189B32600-0x0000000189B32640
	public virtual void ReturnToObjectPool() {} // 0x00000001831D9B00-0x00000001831D9BA0
	[BlackList] // 0x0000000189B3CBA0-0x0000000189B3CBE0
	// [XID] // 0x0000000189B3CBA0-0x0000000189B3CBE0
	public virtual void OnPoolAllocated() {} // 0x00000001831D9900-0x00000001831D99A0
	[BlackList] // 0x0000000189B477E0-0x0000000189B47820
	// [XID] // 0x0000000189B477E0-0x0000000189B47820
	public virtual void OnBeforePoolRecycled() {} // 0x00000001831D9860-0x00000001831D9900
}


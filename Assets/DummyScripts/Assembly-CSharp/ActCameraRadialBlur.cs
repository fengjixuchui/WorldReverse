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
public class ActCameraRadialBlur : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16474
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCameraRadialBlur _cameraRadialBlur; // 0x68

	// Properties
	public ConfigCameraRadialBlur cameraRadialBlur { /* [XID] */ /* 0x0000000189AF03B0-0x0000000189AF03D0 */ get => default; /* [XID] */ /* 0x0000000189AF7800-0x0000000189AF7820 */ private set {} } // 0x0000000184FD3380-0x0000000184FD3420 0x0000000184FD3150-0x0000000184FD3200
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B81E70-0x0000000189B81E90 */ get => default; } // 0x0000000184FD3D50-0x0000000184FD3DF0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B89570-0x0000000189B89590 */ get => default; } // 0x0000000184FD32E0-0x0000000184FD3380 

	// Constructors
	public ActCameraRadialBlur() {} // 0x0000000184FD4460-0x0000000184FD44C0

	// Methods
	// [XID] // 0x0000000189AFEE30-0x0000000189AFEE50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184FD4240-0x0000000184FD4320
	// [XID] // 0x0000000189B06620-0x0000000189B06640
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184FD3E50-0x0000000184FD3F30
	// [XID] // 0x0000000189B0DC70-0x0000000189B0DC90
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3C90 */) => default; // 0x0000000184FD39C0-0x0000000184FD3AA0
	// [XID] // 0x0000000189B150B0-0x0000000189B150D0
	public override int GetHashNum() => default; // 0x0000000184FD2490-0x0000000184FD2560
	// [XID] // 0x0000000189B1CA90-0x0000000189B1CAB0
	public override void InitEmpty() {} // 0x0000000184FD3420-0x0000000184FD34F0
	[BlackList] // 0x0000000189B24060-0x0000000189B240A0
	// [XID] // 0x0000000189B24060-0x0000000189B240A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184FD2BB0-0x0000000184FD2F30
	// [XID] // 0x0000000189B2E1D0-0x0000000189B2E1F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184FD1C20-0x0000000184FD1E60
	[BlackList] // 0x0000000189B35660-0x0000000189B356A0
	// [XID] // 0x0000000189B35660-0x0000000189B356A0
	public static new ActCameraRadialBlur ParseFromJson(JSONNode node) => default; // 0x0000000184FD3B00-0x0000000184FD3D50
	// [XID] // 0x0000000189B40280-0x0000000189B402A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C91 */, bool useObjectPool = false /* Metadata: 0x00AF3C95 */) => default; // 0x0000000184FD36C0-0x0000000184FD39C0
	// [XID] // 0x0000000189B47B40-0x0000000189B47B60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C96 */, bool useObjectPool = false /* Metadata: 0x00AF3C9A */) => default; // 0x0000000184FD26B0-0x0000000184FD2950
	// [XID] // 0x0000000189B4F3D0-0x0000000189B4F3F0
	public static new ActCameraRadialBlur ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C9B */, bool useObjectPool = false /* Metadata: 0x00AF3C9F */) => default; // 0x0000000184FD2F30-0x0000000184FD3150
	[BlackList] // 0x0000000189B56D10-0x0000000189B56D50
	// [XID] // 0x0000000189B56D10-0x0000000189B56D50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184FD1E60-0x0000000184FD2130
	// [XID] // 0x0000000189B612D0-0x0000000189B612F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184FD4010-0x0000000184FD4240
	[BlackList] // 0x0000000189B68BE0-0x0000000189B68C20
	// [XID] // 0x0000000189B68BE0-0x0000000189B68C20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184FD35D0-0x0000000184FD36C0
	// [XID] // 0x0000000189B73070-0x0000000189B73090
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184FD4320-0x0000000184FD43C0
	// [XID] // 0x0000000189B7A630-0x0000000189B7A650
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184FD2950-0x0000000184FD2AB0
	[BlackList] // 0x0000000189B90B30-0x0000000189B90B70
	// [XID] // 0x0000000189B90B30-0x0000000189B90B70
	public override void AutoAllocTypeFields() {} // 0x0000000184FD2130-0x0000000184FD21D0
	[BlackList] // 0x0000000189B9AE00-0x0000000189B9AE40
	// [XID] // 0x0000000189B9AE00-0x0000000189B9AE40
	public override void AutoRecycleTypeFields() {} // 0x0000000184FD21D0-0x0000000184FD2300
	[BlackList] // 0x0000000189BA54D0-0x0000000189BA5510
	// [XID] // 0x0000000189BA54D0-0x0000000189BA5510
	public override void ReturnToObjectPool() {} // 0x0000000184FD43C0-0x0000000184FD4460
}


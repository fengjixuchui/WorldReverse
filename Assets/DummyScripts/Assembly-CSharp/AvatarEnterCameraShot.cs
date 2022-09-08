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
public class AvatarEnterCameraShot : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16365
{
	// Fields
	private string _cameraMoveCfgPath; // 0x68
	private AbilityCameraShotType _shotType; // 0x70

	// Properties
	public string cameraMoveCfgPath { /* [XID] */ /* 0x00000001896178F0-0x0000000189617910 */ get => default; /* [XID] */ /* 0x000000018961F500-0x000000018961F520 */ private set {} } // 0x00000001829398A0-0x0000000182939940 0x0000000182938A50-0x0000000182938B00
	public AbilityCameraShotType shotType { /* [XID] */ /* 0x0000000189626940-0x0000000189626960 */ get => default; /* [XID] */ /* 0x000000018962E150-0x000000018962E170 */ private set {} } // 0x0000000182938BD0-0x0000000182938C70 0x0000000182939AC0-0x0000000182939B70
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896B9490-0x00000001896B94B0 */ get => default; } // 0x000000018293A4A0-0x000000018293A540 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896C0860-0x00000001896C0880 */ get => default; } // 0x0000000182939A20-0x0000000182939AC0 

	// Constructors
	public AvatarEnterCameraShot() {} // 0x000000018293AC40-0x000000018293ACA0

	// Methods
	// [XID] // 0x0000000189635E10-0x0000000189635E30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018293A9F0-0x000000018293AB00
	// [XID] // 0x000000018963D510-0x000000018963D530
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018293A5A0-0x000000018293A680
	// [XID] // 0x0000000189644AF0-0x0000000189644B10
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3928 */) => default; // 0x000000018293A110-0x000000018293A1F0
	// [XID] // 0x000000018964C3B0-0x000000018964C3D0
	public override int GetHashNum() => default; // 0x0000000182938B00-0x0000000182938BD0
	// [XID] // 0x0000000189653A20-0x0000000189653A40
	public override void InitEmpty() {} // 0x0000000182939B70-0x0000000182939C40
	[BlackList] // 0x000000018965B2F0-0x000000018965B330
	// [XID] // 0x000000018965B2F0-0x000000018965B330
	public override bool FromJson(JSONNode node) => default; // 0x0000000182939300-0x0000000182939680
	// [XID] // 0x0000000189665790-0x00000001896657B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182938190-0x00000001829384A0
	[BlackList] // 0x000000018966CEE0-0x000000018966CF20
	// [XID] // 0x000000018966CEE0-0x000000018966CF20
	public static new AvatarEnterCameraShot ParseFromJson(JSONNode node) => default; // 0x000000018293A250-0x000000018293A4A0
	// [XID] // 0x0000000189677E50-0x0000000189677E70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3929 */, bool useObjectPool = false /* Metadata: 0x00AF392D */) => default; // 0x0000000182939E10-0x000000018293A110
	// [XID] // 0x000000018967F400-0x000000018967F420
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF392E */, bool useObjectPool = false /* Metadata: 0x00AF3932 */) => default; // 0x0000000182938DC0-0x00000001829390A0
	// [XID] // 0x0000000189686C70-0x0000000189686C90
	public static new AvatarEnterCameraShot ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3933 */, bool useObjectPool = false /* Metadata: 0x00AF3937 */) => default; // 0x0000000182939680-0x00000001829398A0
	[BlackList] // 0x000000018968EB70-0x000000018968EBB0
	// [XID] // 0x000000018968EB70-0x000000018968EBB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829384A0-0x0000000182938770
	// [XID] // 0x0000000189699200-0x0000000189699220
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018293A760-0x000000018293A9F0
	[BlackList] // 0x00000001896A0710-0x00000001896A0750
	// [XID] // 0x00000001896A0710-0x00000001896A0750
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182939D20-0x0000000182939E10
	// [XID] // 0x00000001896AAB10-0x00000001896AAB30
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018293AB00-0x000000018293ABA0
	// [XID] // 0x00000001896B1AB0-0x00000001896B1AD0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001829390A0-0x0000000182939200
	[BlackList] // 0x00000001896C7FF0-0x00000001896C8030
	// [XID] // 0x00000001896C7FF0-0x00000001896C8030
	public override void AutoAllocTypeFields() {} // 0x0000000182938770-0x0000000182938810
	[BlackList] // 0x00000001896D23A0-0x00000001896D23E0
	// [XID] // 0x00000001896D23A0-0x00000001896D23E0
	public override void AutoRecycleTypeFields() {} // 0x0000000182938810-0x00000001829388C0
	[BlackList] // 0x00000001896DCA60-0x00000001896DCAA0
	// [XID] // 0x00000001896DCA60-0x00000001896DCAA0
	public override void ReturnToObjectPool() {} // 0x000000018293ABA0-0x000000018293AC40
}


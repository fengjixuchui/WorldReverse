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
public class CreateMovingPlatform : CreateGadget, IAutoAllocRecycle // TypeDefIndex: 16501
{
	// Fields
	private SimpleSafeUInt32 routeIDRawNum; // 0xA0
	private SimpleSafeFloat detectHeightRawNum; // 0xA4
	private SimpleSafeFloat detectWidthRawNum; // 0xA8
	private bool _enableRotationOffset; // 0xAC
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _failActions; // 0xB0

	// Properties
	public uint routeID { /* [XID] */ /* 0x0000000189BDB300-0x0000000189BDB320 */ get => default; /* [XID] */ /* 0x00000001895E7BF0-0x00000001895E7C10 */ private set {} } // 0x0000000182258FF0-0x00000001822590C0 0x000000018225B030-0x000000018225B110
	public float detectHeight { /* [XID] */ /* 0x00000001895EF580-0x00000001895EF5A0 */ get => default; /* [XID] */ /* 0x00000001895F6F80-0x00000001895F6FA0 */ private set {} } // 0x000000018225AD30-0x000000018225AE10 0x000000018225BCA0-0x000000018225BD80
	public float detectWidth { /* [XID] */ /* 0x00000001895FE320-0x00000001895FE340 */ get => default; /* [XID] */ /* 0x0000000189605BD0-0x0000000189605BF0 */ private set {} } // 0x000000018225C8E0-0x000000018225C9C0 0x000000018225A720-0x000000018225A800
	public bool enableRotationOffset { /* [XID] */ /* 0x000000018960D500-0x000000018960D520 */ get => default; /* [XID] */ /* 0x0000000189614BC0-0x0000000189614BE0 */ private set {} } // 0x000000018225BFD0-0x000000018225C080 0x000000018225B180-0x000000018225B230
	public ConfigAbilityAction[] failActions { /* [XID] */ /* 0x000000018961C4C0-0x000000018961C4E0 */ get => default; /* [XID] */ /* 0x0000000189623880-0x00000001896238A0 */ private set {} } // 0x000000018225A900-0x000000018225A9B0 0x000000018225C9C0-0x000000018225CA70
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896AEFF0-0x00000001896AF010 */ get => default; } // 0x000000018225BD80-0x000000018225BE20 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896B65C0-0x00000001896B65E0 */ get => default; } // 0x000000018225B230-0x000000018225B2D0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001896BD8A0-0x00000001896BD8C0 */ get => default; } // 0x0000000182259EF0-0x0000000182259F90 

	// Constructors
	public CreateMovingPlatform() {} // 0x000000018225CB10-0x000000018225CB80

	// Methods
	// [XID] // 0x000000018962B180-0x000000018962B1A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018225C780-0x000000018225C8E0
	// [XID] // 0x0000000189632920-0x0000000189632940
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018225BEF0-0x000000018225BFD0
	// [XID] // 0x000000018963A3F0-0x000000018963A410
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3D6A */) => default; // 0x000000018225B910-0x000000018225B9F0
	// [XID] // 0x0000000189641940-0x0000000189641960
	public override int GetHashNum() => default; // 0x0000000182259E20-0x0000000182259EF0
	// [XID] // 0x00000001896493C0-0x00000001896493E0
	public override void InitEmpty() {} // 0x000000018225B2D0-0x000000018225B430
	[BlackList] // 0x00000001896509B0-0x00000001896509F0
	// [XID] // 0x00000001896509B0-0x00000001896509F0
	public override bool FromJson(JSONNode node) => default; // 0x000000018225A9B0-0x000000018225AD30
	// [XID] // 0x000000018965B270-0x000000018965B290
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822591B0-0x00000001822597E0
	[BlackList] // 0x0000000189662700-0x0000000189662740
	// [XID] // 0x0000000189662700-0x0000000189662740
	public static new CreateMovingPlatform ParseFromJson(JSONNode node) => default; // 0x000000018225BA50-0x000000018225BCA0
	// [XID] // 0x000000018966CE60-0x000000018966CE80
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D6B */, bool useObjectPool = false /* Metadata: 0x00AF3D6F */) => default; // 0x000000018225B610-0x000000018225B910
	// [XID] // 0x0000000189674C90-0x0000000189674CB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D70 */, bool useObjectPool = false /* Metadata: 0x00AF3D74 */) => default; // 0x000000018225A0E0-0x000000018225A5C0
	// [XID] // 0x000000018967C560-0x000000018967C580
	public static new CreateMovingPlatform ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D75 */, bool useObjectPool = false /* Metadata: 0x00AF3D79 */) => default; // 0x000000018225AE10-0x000000018225B030
	[BlackList] // 0x0000000189683BD0-0x0000000189683C10
	// [XID] // 0x0000000189683BD0-0x0000000189683C10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001822597E0-0x0000000182259AB0
	// [XID] // 0x000000018968EA90-0x000000018968EAB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018225C2E0-0x000000018225C780
	[BlackList] // 0x0000000189696530-0x0000000189696570
	// [XID] // 0x0000000189696530-0x0000000189696570
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018225B510-0x000000018225B610
	// [XID] // 0x00000001896A06D0-0x00000001896A06F0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018225A5C0-0x000000018225A720
	// [XID] // 0x00000001896A7BA0-0x00000001896A7BC0
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018225C160-0x000000018225C2E0
	[BlackList] // 0x00000001896C5050-0x00000001896C5090
	// [XID] // 0x00000001896C5050-0x00000001896C5090
	public override void AutoAllocTypeFields() {} // 0x0000000182259AB0-0x0000000182259B50
	[BlackList] // 0x00000001896CF890-0x00000001896CF8D0
	// [XID] // 0x00000001896CF890-0x00000001896CF8D0
	public override void AutoRecycleTypeFields() {} // 0x0000000182259B50-0x0000000182259C90
	[BlackList] // 0x00000001896D9D90-0x00000001896D9DD0
	// [XID] // 0x00000001896D9D90-0x00000001896D9DD0
	public override void ReturnToObjectPool() {} // 0x000000018225CA70-0x000000018225CB10
}


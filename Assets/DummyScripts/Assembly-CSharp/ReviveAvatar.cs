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
public class ReviveAvatar : HealHP, IAutoAllocRecycle // TypeDefIndex: 16448
{
	// Properties
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018971B4A0-0x000000018971B4C0 */ get => default; } // 0x000000018255AE10-0x000000018255AEB0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897226E0-0x0000000189722700 */ get => default; } // 0x000000018255A460-0x000000018255A500 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189729E60-0x0000000189729E80 */ get => default; } // 0x00000001825598A0-0x0000000182559940 

	// Constructors
	public ReviveAvatar() {} // 0x000000018255B3F0-0x000000018255B450

	// Methods
	// [XID] // 0x00000001896991E0-0x0000000189699200
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018255B200-0x000000018255B2B0
	// [XID] // 0x00000001896A06F0-0x00000001896A0710
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018255AF80-0x000000018255B030
	// [XID] // 0x00000001896A7BC0-0x00000001896A7BE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3BBA */) => default; // 0x000000018255AA80-0x000000018255AB60
	// [XID] // 0x00000001896AF010-0x00000001896AF030
	public override int GetHashNum() => default; // 0x00000001825597D0-0x00000001825598A0
	// [XID] // 0x00000001896B65E0-0x00000001896B6600
	public override void InitEmpty() {} // 0x000000018255A500-0x000000018255A5A0
	[BlackList] // 0x00000001896BD8C0-0x00000001896BD900
	// [XID] // 0x00000001896BD8C0-0x00000001896BD900
	public override bool FromJson(JSONNode node) => default; // 0x0000000182559DE0-0x000000018255A160
	// [XID] // 0x00000001896C7FD0-0x00000001896C7FF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182559140-0x0000000182559230
	[BlackList] // 0x00000001896CF910-0x00000001896CF950
	// [XID] // 0x00000001896CF910-0x00000001896CF950
	public static new ReviveAvatar ParseFromJson(JSONNode node) => default; // 0x000000018255ABC0-0x000000018255AE10
	// [XID] // 0x00000001896D9DD0-0x00000001896D9DF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BBB */, bool useObjectPool = false /* Metadata: 0x00AF3BBF */) => default; // 0x000000018255A780-0x000000018255AA80
	// [XID] // 0x00000001896E13F0-0x00000001896E1410
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BC0 */, bool useObjectPool = false /* Metadata: 0x00AF3BC4 */) => default; // 0x0000000182559A90-0x0000000182559BC0
	// [XID] // 0x00000001896E8680-0x00000001896E86A0
	public static new ReviveAvatar ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BC5 */, bool useObjectPool = false /* Metadata: 0x00AF3BC9 */) => default; // 0x000000018255A160-0x000000018255A380
	[BlackList] // 0x00000001896EFBC0-0x00000001896EFC00
	// [XID] // 0x00000001896EFBC0-0x00000001896EFC00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182559230-0x0000000182559500
	// [XID] // 0x00000001896FA4D0-0x00000001896FA4F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018255B110-0x000000018255B200
	[BlackList] // 0x0000000189701BE0-0x0000000189701C20
	// [XID] // 0x0000000189701BE0-0x0000000189701C20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018255A680-0x000000018255A780
	// [XID] // 0x000000018970C2D0-0x000000018970C2F0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018255B2B0-0x000000018255B350
	// [XID] // 0x0000000189713C80-0x0000000189713CA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182559BC0-0x0000000182559CE0
	[BlackList] // 0x0000000189731540-0x0000000189731580
	// [XID] // 0x0000000189731540-0x0000000189731580
	public override void AutoAllocTypeFields() {} // 0x0000000182559500-0x00000001825595A0
	[BlackList] // 0x000000018973BE80-0x000000018973BEC0
	// [XID] // 0x000000018973BE80-0x000000018973BEC0
	public override void AutoRecycleTypeFields() {} // 0x00000001825595A0-0x0000000182559640
	[BlackList] // 0x0000000189746700-0x0000000189746740
	// [XID] // 0x0000000189746700-0x0000000189746740
	public override void ReturnToObjectPool() {} // 0x000000018255B350-0x000000018255B3F0
}


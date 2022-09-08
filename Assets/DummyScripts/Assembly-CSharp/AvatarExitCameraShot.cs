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
public class AvatarExitCameraShot : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16367
{
	// Fields
	private AbilityCameraShotType _shotType; // 0x68

	// Properties
	public AbilityCameraShotType shotType { /* [XID] */ /* 0x00000001896EE570-0x00000001896EE590 */ get => default; /* [XID] */ /* 0x00000001896F5EC0-0x00000001896F5EE0 */ private set {} } // 0x0000000183E01CF0-0x0000000183E01D90 0x0000000183E02A90-0x0000000183E02B40
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189780A00-0x0000000189780A20 */ get => default; } // 0x0000000183E03440-0x0000000183E034E0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189788060-0x0000000189788080 */ get => default; } // 0x0000000183E029F0-0x0000000183E02A90 

	// Constructors
	public AvatarExitCameraShot() {} // 0x0000000183E03B00-0x0000000183E03B60

	// Methods
	// [XID] // 0x00000001896FD690-0x00000001896FD6B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E038D0-0x0000000183E039C0
	// [XID] // 0x0000000189704B30-0x0000000189704B50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183E03540-0x0000000183E035F0
	// [XID] // 0x000000018970C2F0-0x000000018970C310
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3938 */) => default; // 0x0000000183E030B0-0x0000000183E03190
	// [XID] // 0x0000000189713CA0-0x0000000189713CC0
	public override int GetHashNum() => default; // 0x0000000183E01C20-0x0000000183E01CF0
	// [XID] // 0x000000018971B4C0-0x000000018971B4E0
	public override void InitEmpty() {} // 0x0000000183E02B40-0x0000000183E02BE0
	[BlackList] // 0x0000000189722700-0x0000000189722740
	// [XID] // 0x0000000189722700-0x0000000189722740
	public override bool FromJson(JSONNode node) => default; // 0x0000000183E02370-0x0000000183E026F0
	// [XID] // 0x000000018972CD20-0x000000018972CD40
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183E01450-0x0000000183E01670
	[BlackList] // 0x00000001897344F0-0x0000000189734530
	// [XID] // 0x00000001897344F0-0x0000000189734530
	public static new AvatarExitCameraShot ParseFromJson(JSONNode node) => default; // 0x0000000183E031F0-0x0000000183E03440
	// [XID] // 0x000000018973F3E0-0x000000018973F400
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3939 */, bool useObjectPool = false /* Metadata: 0x00AF393D */) => default; // 0x0000000183E02DB0-0x0000000183E030B0
	// [XID] // 0x0000000189746740-0x0000000189746760
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF393E */, bool useObjectPool = false /* Metadata: 0x00AF3942 */) => default; // 0x0000000183E01EE0-0x0000000183E02110
	// [XID] // 0x000000018974E150-0x000000018974E170
	public static new AvatarExitCameraShot ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3943 */, bool useObjectPool = false /* Metadata: 0x00AF3947 */) => default; // 0x0000000183E026F0-0x0000000183E02910
	[BlackList] // 0x0000000189755830-0x0000000189755870
	// [XID] // 0x0000000189755830-0x0000000189755870
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E01670-0x0000000183E01940
	// [XID] // 0x000000018975FD50-0x000000018975FD70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E036D0-0x0000000183E038D0
	[BlackList] // 0x00000001897673C0-0x0000000189767400
	// [XID] // 0x00000001897673C0-0x0000000189767400
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183E02CC0-0x0000000183E02DB0
	// [XID] // 0x0000000189771AD0-0x0000000189771AF0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183E039C0-0x0000000183E03A60
	// [XID] // 0x0000000189779260-0x0000000189779280
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183E02110-0x0000000183E02270
	[BlackList] // 0x000000018978F640-0x000000018978F680
	// [XID] // 0x000000018978F640-0x000000018978F680
	public override void AutoAllocTypeFields() {} // 0x0000000183E01940-0x0000000183E019E0
	[BlackList] // 0x0000000189799C70-0x0000000189799CB0
	// [XID] // 0x0000000189799C70-0x0000000189799CB0
	public override void AutoRecycleTypeFields() {} // 0x0000000183E019E0-0x0000000183E01A90
	[BlackList] // 0x00000001897A4D90-0x00000001897A4DD0
	// [XID] // 0x00000001897A4D90-0x00000001897A4DD0
	public override void ReturnToObjectPool() {} // 0x0000000183E03A60-0x0000000183E03B00
}


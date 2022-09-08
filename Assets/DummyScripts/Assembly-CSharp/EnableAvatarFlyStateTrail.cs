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
public class EnableAvatarFlyStateTrail : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16677
{
	// Fields
	private bool _setEnable; // 0x68

	// Properties
	public bool setEnable { /* [XID] */ /* 0x0000000189707A90-0x0000000189707AB0 */ get => default; /* [XID] */ /* 0x000000018970F460-0x000000018970F480 */ private set {} } // 0x0000000184CBEA50-0x0000000184CBEAF0 0x0000000184CBF730-0x0000000184CBF7E0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189799C30-0x0000000189799C50 */ get => default; } // 0x0000000184CBF4A0-0x0000000184CBF540 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897A1AA0-0x00000001897A1AC0 */ get => default; } // 0x0000000184CBEAF0-0x0000000184CBEB90 

	// Constructors
	public EnableAvatarFlyStateTrail() {} // 0x0000000184CBFC10-0x0000000184CBFC70

	// Methods
	// [XID] // 0x00000001897167C0-0x00000001897167E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184CBF9E0-0x0000000184CBFAD0
	// [XID] // 0x000000018971E200-0x000000018971E220
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184CBF5A0-0x0000000184CBF650
	// [XID] // 0x0000000189725760-0x0000000189725780
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF42CE */) => default; // 0x0000000184CBF110-0x0000000184CBF1F0
	// [XID] // 0x000000018972CCA0-0x000000018972CCC0
	public override int GetHashNum() => default; // 0x0000000184CBDD20-0x0000000184CBDDF0
	// [XID] // 0x0000000189734490-0x00000001897344B0
	public override void InitEmpty() {} // 0x0000000184CBEB90-0x0000000184CBEC30
	[BlackList] // 0x000000018973BDE0-0x000000018973BE20
	// [XID] // 0x000000018973BDE0-0x000000018973BE20
	public override bool FromJson(JSONNode node) => default; // 0x0000000184CBE3D0-0x0000000184CBE750
	// [XID] // 0x0000000189746600-0x0000000189746620
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184CBD570-0x0000000184CBD770
	[BlackList] // 0x000000018974E090-0x000000018974E0D0
	// [XID] // 0x000000018974E090-0x000000018974E0D0
	public static new EnableAvatarFlyStateTrail ParseFromJson(JSONNode node) => default; // 0x0000000184CBF250-0x0000000184CBF4A0
	// [XID] // 0x0000000189758170-0x0000000189758190
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42CF */, bool useObjectPool = false /* Metadata: 0x00AF42D3 */) => default; // 0x0000000184CBEE10-0x0000000184CBF110
	// [XID] // 0x000000018975FC90-0x000000018975FCB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42D4 */, bool useObjectPool = false /* Metadata: 0x00AF42D8 */) => default; // 0x0000000184CBDF40-0x0000000184CBE170
	// [XID] // 0x0000000189767300-0x0000000189767320
	public static new EnableAvatarFlyStateTrail ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42D9 */, bool useObjectPool = false /* Metadata: 0x00AF42DD */) => default; // 0x0000000184CBE750-0x0000000184CBE970
	[BlackList] // 0x000000018976E7E0-0x000000018976E820
	// [XID] // 0x000000018976E7E0-0x000000018976E820
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184CBD770-0x0000000184CBDA40
	// [XID] // 0x0000000189779140-0x0000000189779160
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184CBF7E0-0x0000000184CBF9E0
	[BlackList] // 0x00000001897808E0-0x0000000189780920
	// [XID] // 0x00000001897808E0-0x0000000189780920
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184CBED10-0x0000000184CBEE10
	// [XID] // 0x000000018978B180-0x000000018978B1A0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184CBFAD0-0x0000000184CBFB70
	// [XID] // 0x0000000189792720-0x0000000189792740
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184CBE170-0x0000000184CBE2D0
	[BlackList] // 0x00000001897A9340-0x00000001897A9380
	// [XID] // 0x00000001897A9340-0x00000001897A9380
	public override void AutoAllocTypeFields() {} // 0x0000000184CBDA40-0x0000000184CBDAE0
	[BlackList] // 0x00000001897B41D0-0x00000001897B4210
	// [XID] // 0x00000001897B41D0-0x00000001897B4210
	public override void AutoRecycleTypeFields() {} // 0x0000000184CBDAE0-0x0000000184CBDB90
	[BlackList] // 0x00000001897BF230-0x00000001897BF270
	// [XID] // 0x00000001897BF230-0x00000001897BF270
	public override void ReturnToObjectPool() {} // 0x0000000184CBFB70-0x0000000184CBFC10
}


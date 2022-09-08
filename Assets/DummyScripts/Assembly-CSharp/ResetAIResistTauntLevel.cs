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
public class ResetAIResistTauntLevel : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16705
{
	// Fields
	private TauntLevel _resistTauntLevel; // 0x68

	// Properties
	public TauntLevel resistTauntLevel { /* [XID] */ /* 0x00000001896964B0-0x00000001896964D0 */ get => default; /* [XID] */ /* 0x000000018969DA50-0x000000018969DA70 */ private set {} } // 0x000000018313F280-0x000000018313F320 0x000000018313F400-0x000000018313F4B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018971FA10-0x000000018971FA30 */ get => default; } // 0x000000018313F0D0-0x000000018313F170 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189727080-0x00000001897270A0 */ get => default; } // 0x000000018313E720-0x000000018313E7C0 

	// Constructors
	public ResetAIResistTauntLevel() {} // 0x000000018313F840-0x000000018313F8B0

	// Methods
	// [XID] // 0x00000001896A4AE0-0x00000001896A4B00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018313F6B0-0x000000018313F7A0
	// [XID] // 0x00000001896AC2F0-0x00000001896AC310
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018313F1D0-0x000000018313F280
	// [XID] // 0x00000001896B35F0-0x00000001896B3610
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF43AE */) => default; // 0x000000018313ED40-0x000000018313EE20
	// [XID] // 0x00000001896BAD10-0x00000001896BAD30
	public override int GetHashNum() => default; // 0x000000018313DA60-0x000000018313DB30
	// [XID] // 0x00000001896C1E40-0x00000001896C1E60
	public override void InitEmpty() {} // 0x000000018313E7C0-0x000000018313E860
	[BlackList] // 0x00000001896C9450-0x00000001896C9490
	// [XID] // 0x00000001896C9450-0x00000001896C9490
	public override bool FromJson(JSONNode node) => default; // 0x000000018313E110-0x000000018313E490
	// [XID] // 0x00000001896D3840-0x00000001896D3860
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018313D290-0x000000018313D4B0
	[BlackList] // 0x00000001896DB380-0x00000001896DB3C0
	// [XID] // 0x00000001896DB380-0x00000001896DB3C0
	public static new ResetAIResistTauntLevel ParseFromJson(JSONNode node) => default; // 0x000000018313EE80-0x000000018313F0D0
	// [XID] // 0x00000001896E56F0-0x00000001896E5710
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43AF */, bool useObjectPool = false /* Metadata: 0x00AF43B3 */) => default; // 0x000000018313EA40-0x000000018313ED40
	// [XID] // 0x00000001896ECDC0-0x00000001896ECDE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43B4 */, bool useObjectPool = false /* Metadata: 0x00AF43B8 */) => default; // 0x000000018313DC80-0x000000018313DEB0
	// [XID] // 0x00000001896F4580-0x00000001896F45A0
	public static new ResetAIResistTauntLevel ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43B9 */, bool useObjectPool = false /* Metadata: 0x00AF43BD */) => default; // 0x000000018313E490-0x000000018313E6B0
	[BlackList] // 0x00000001896FBDB0-0x00000001896FBDF0
	// [XID] // 0x00000001896FBDB0-0x00000001896FBDF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018313D4B0-0x000000018313D780
	// [XID] // 0x00000001897061A0-0x00000001897061C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018313F4B0-0x000000018313F6B0
	[BlackList] // 0x000000018970DAD0-0x000000018970DB10
	// [XID] // 0x000000018970DAD0-0x000000018970DB10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018313E940-0x000000018313EA40
	// [XID] // 0x0000000189718010-0x0000000189718030
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018313DEB0-0x000000018313E010
	[BlackList] // 0x000000018972E5F0-0x000000018972E630
	// [XID] // 0x000000018972E5F0-0x000000018972E630
	public override void AutoAllocTypeFields() {} // 0x000000018313D780-0x000000018313D820
	[BlackList] // 0x0000000189738D90-0x0000000189738DD0
	// [XID] // 0x0000000189738D90-0x0000000189738DD0
	public override void AutoRecycleTypeFields() {} // 0x000000018313D820-0x000000018313D8D0
	[BlackList] // 0x0000000189743670-0x00000001897436B0
	// [XID] // 0x0000000189743670-0x00000001897436B0
	public override void ReturnToObjectPool() {} // 0x000000018313F7A0-0x000000018313F840
}


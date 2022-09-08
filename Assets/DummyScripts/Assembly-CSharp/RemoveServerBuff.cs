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
public class RemoveServerBuff : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16671
{
	// Fields
	private SimpleSafeUInt32 sBuffIdRawNum; // 0x68
	private bool _isTeamBuff; // 0x6C

	// Properties
	public uint sBuffId { /* [XID] */ /* 0x0000000189A399F0-0x0000000189A39A10 */ get => default; /* [XID] */ /* 0x0000000189A412F0-0x0000000189A41310 */ private set {} } // 0x0000000183012330-0x0000000183012400 0x0000000183011C80-0x0000000183011D60
	public bool isTeamBuff { /* [XID] */ /* 0x0000000189A488F0-0x0000000189A48910 */ get => default; /* [XID] */ /* 0x0000000189A50040-0x0000000189A50060 */ private set {} } // 0x0000000183012480-0x0000000183012520 0x0000000183013CF0-0x0000000183013DA0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189ADC460-0x0000000189ADC480 */ get => default; } // 0x0000000183013580-0x0000000183013620 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189AE3E30-0x0000000189AE3E50 */ get => default; } // 0x0000000183012BA0-0x0000000183012C40 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189AEB6D0-0x0000000189AEB6F0 */ get => default; } // 0x0000000183011BE0-0x0000000183011C80 

	// Constructors
	public RemoveServerBuff() {} // 0x0000000183013E40-0x0000000183013EA0

	// Methods
	// [XID] // 0x0000000189A57650-0x0000000189A57670
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183013B40-0x0000000183013C50
	// [XID] // 0x0000000189A5F150-0x0000000189A5F170
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001830136F0-0x00000001830137A0
	// [XID] // 0x0000000189A66A00-0x0000000189A66A20
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF429E */) => default; // 0x00000001830131F0-0x00000001830132D0
	// [XID] // 0x0000000189A6E320-0x0000000189A6E340
	public override int GetHashNum() => default; // 0x0000000183011B10-0x0000000183011BE0
	// [XID] // 0x0000000189A75930-0x0000000189A75950
	public override void InitEmpty() {} // 0x0000000183012C40-0x0000000183012D10
	[BlackList] // 0x0000000189A7D5B0-0x0000000189A7D5F0
	// [XID] // 0x0000000189A7D5B0-0x0000000189A7D5F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183012520-0x00000001830128A0
	// [XID] // 0x0000000189A87EE0-0x0000000189A87F00
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183011210-0x0000000183011530
	[BlackList] // 0x0000000189A8F710-0x0000000189A8F750
	// [XID] // 0x0000000189A8F710-0x0000000189A8F750
	public static new RemoveServerBuff ParseFromJson(JSONNode node) => default; // 0x0000000183013330-0x0000000183013580
	// [XID] // 0x0000000189A9A020-0x0000000189A9A040
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF429F */, bool useObjectPool = false /* Metadata: 0x00AF42A3 */) => default; // 0x0000000183012EF0-0x00000001830131F0
	// [XID] // 0x0000000189AA0FE0-0x0000000189AA1000
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42A4 */, bool useObjectPool = false /* Metadata: 0x00AF42A8 */) => default; // 0x0000000183011EB0-0x0000000183012190
	// [XID] // 0x0000000189AA86C0-0x0000000189AA86E0
	public static new RemoveServerBuff ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42A9 */, bool useObjectPool = false /* Metadata: 0x00AF42AD */) => default; // 0x00000001830128A0-0x0000000183012AC0
	[BlackList] // 0x0000000189AB0300-0x0000000189AB0340
	// [XID] // 0x0000000189AB0300-0x0000000189AB0340
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183011530-0x0000000183011800
	// [XID] // 0x0000000189ABAFF0-0x0000000189ABB010
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183013880-0x0000000183013B40
	[BlackList] // 0x0000000189AC27E0-0x0000000189AC2820
	// [XID] // 0x0000000189AC27E0-0x0000000189AC2820
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183012DF0-0x0000000183012EF0
	// [XID] // 0x0000000189ACCE60-0x0000000189ACCE80
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183013C50-0x0000000183013CF0
	// [XID] // 0x0000000189AD4AE0-0x0000000189AD4B00
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183012190-0x00000001830122B0
	[BlackList] // 0x0000000189AF2FF0-0x0000000189AF3030
	// [XID] // 0x0000000189AF2FF0-0x0000000189AF3030
	public override void AutoAllocTypeFields() {} // 0x0000000183011800-0x00000001830118A0
	[BlackList] // 0x0000000189AFD3F0-0x0000000189AFD430
	// [XID] // 0x0000000189AFD3F0-0x0000000189AFD430
	public override void AutoRecycleTypeFields() {} // 0x00000001830118A0-0x0000000183011980
	[BlackList] // 0x0000000189B07B10-0x0000000189B07B50
	// [XID] // 0x0000000189B07B10-0x0000000189B07B50
	public override void ReturnToObjectPool() {} // 0x0000000183013DA0-0x0000000183013E40
}


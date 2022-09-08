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
public class EnablePartControl : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16585
{
	// Fields
	private string[] _partRootNames; // 0x68
	private bool _enable; // 0x70

	// Properties
	public string[] partRootNames { /* [XID] */ /* 0x0000000189A86450-0x0000000189A86470 */ get => default; /* [XID] */ /* 0x0000000189A8DEB0-0x0000000189A8DED0 */ private set {} } // 0x0000000184A7FAC0-0x0000000184A7FB60 0x0000000184A808A0-0x0000000184A80950
	public bool enable { /* [XID] */ /* 0x0000000189A95430-0x0000000189A95450 */ get => default; /* [XID] */ /* 0x0000000189A9CC70-0x0000000189A9CC90 */ private set {} } // 0x0000000184A7F800-0x0000000184A7F8A0 0x0000000184A80610-0x0000000184A806C0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B284B0-0x0000000189B284D0 */ get => default; } // 0x0000000184A806C0-0x0000000184A80760 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B2F810-0x0000000189B2F830 */ get => default; } // 0x0000000184A7FC40-0x0000000184A7FCE0 

	// Constructors
	public EnablePartControl() {} // 0x0000000184A80F40-0x0000000184A80FA0

	// Methods
	// [XID] // 0x0000000189AA4460-0x0000000189AA4480
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A80CF0-0x0000000184A80E00
	// [XID] // 0x0000000189AAB970-0x0000000189AAB990
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A807C0-0x0000000184A808A0
	// [XID] // 0x0000000189AB3300-0x0000000189AB3320
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3FFA */) => default; // 0x0000000184A80280-0x0000000184A80360
	// [XID] // 0x0000000189ABB030-0x0000000189ABB050
	public override int GetHashNum() => default; // 0x0000000184A7ED20-0x0000000184A7EDF0
	// [XID] // 0x0000000189AC2840-0x0000000189AC2860
	public override void InitEmpty() {} // 0x0000000184A7FCE0-0x0000000184A7FDB0
	[BlackList] // 0x0000000189AC9E00-0x0000000189AC9E40
	// [XID] // 0x0000000189AC9E00-0x0000000189AC9E40
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A7F480-0x0000000184A7F800
	// [XID] // 0x0000000189AD4B40-0x0000000189AD4B60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A7E480-0x0000000184A7E770
	[BlackList] // 0x0000000189ADC480-0x0000000189ADC4C0
	// [XID] // 0x0000000189ADC480-0x0000000189ADC4C0
	public static new EnablePartControl ParseFromJson(JSONNode node) => default; // 0x0000000184A803C0-0x0000000184A80610
	// [XID] // 0x0000000189AE6E50-0x0000000189AE6E70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FFB */, bool useObjectPool = false /* Metadata: 0x00AF3FFF */) => default; // 0x0000000184A7FF80-0x0000000184A80280
	// [XID] // 0x0000000189AEE940-0x0000000189AEE960
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4000 */, bool useObjectPool = false /* Metadata: 0x00AF4004 */) => default; // 0x0000000184A7EF40-0x0000000184A7F220
	// [XID] // 0x0000000189AF5F50-0x0000000189AF5F70
	public static new EnablePartControl ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4005 */, bool useObjectPool = false /* Metadata: 0x00AF4009 */) => default; // 0x0000000184A7F8A0-0x0000000184A7FAC0
	[BlackList] // 0x0000000189AFD430-0x0000000189AFD470
	// [XID] // 0x0000000189AFD430-0x0000000189AFD470
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A7E770-0x0000000184A7EA40
	// [XID] // 0x0000000189B07B90-0x0000000189B07BB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A80A30-0x0000000184A80CF0
	[BlackList] // 0x0000000189B0F430-0x0000000189B0F470
	// [XID] // 0x0000000189B0F430-0x0000000189B0F470
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A7FE90-0x0000000184A7FF80
	// [XID] // 0x0000000189B19710-0x0000000189B19730
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184A80E00-0x0000000184A80EA0
	// [XID] // 0x0000000189B20DF0-0x0000000189B20E10
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184A7F220-0x0000000184A7F380
	[BlackList] // 0x0000000189B370F0-0x0000000189B37130
	// [XID] // 0x0000000189B370F0-0x0000000189B37130
	public override void AutoAllocTypeFields() {} // 0x0000000184A7EA40-0x0000000184A7EAE0
	[BlackList] // 0x0000000189B41C90-0x0000000189B41CD0
	// [XID] // 0x0000000189B41C90-0x0000000189B41CD0
	public override void AutoRecycleTypeFields() {} // 0x0000000184A7EAE0-0x0000000184A7EB90
	[BlackList] // 0x0000000189B4C4A0-0x0000000189B4C4E0
	// [XID] // 0x0000000189B4C4A0-0x0000000189B4C4E0
	public override void ReturnToObjectPool() {} // 0x0000000184A80EA0-0x0000000184A80F40
}


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
public class SetCanDieImmediately : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16621
{
	// Fields
	private bool _dieImmediately; // 0x68

	// Properties
	public bool dieImmediately { /* [XID] */ /* 0x0000000189846F50-0x0000000189846F70 */ get => default; /* [XID] */ /* 0x000000018984E560-0x000000018984E580 */ private set {} } // 0x00000001815B1F70-0x00000001815B2010 0x00000001815B3240-0x00000001815B32F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898D7F60-0x00000001898D7F80 */ get => default; } // 0x00000001815B2CC0-0x00000001815B2D60 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898DFD20-0x00000001898DFD40 */ get => default; } // 0x00000001815B2310-0x00000001815B23B0 

	// Constructors
	public SetCanDieImmediately() {} // 0x00000001815B3430-0x00000001815B3490

	// Methods
	// [XID] // 0x0000000189855650-0x0000000189855670
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001815B3150-0x00000001815B3240
	// [XID] // 0x000000018985CBB0-0x000000018985CBD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001815B2DC0-0x00000001815B2E70
	// [XID] // 0x0000000189864550-0x0000000189864570
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF411A */) => default; // 0x00000001815B2930-0x00000001815B2A10
	// [XID] // 0x000000018986BA80-0x000000018986BAA0
	public override int GetHashNum() => default; // 0x00000001815B1540-0x00000001815B1610
	// [XID] // 0x0000000189872D10-0x0000000189872D30
	public override void InitEmpty() {} // 0x00000001815B23B0-0x00000001815B2450
	[BlackList] // 0x000000018987A9F0-0x000000018987AA30
	// [XID] // 0x000000018987A9F0-0x000000018987AA30
	public override bool FromJson(JSONNode node) => default; // 0x00000001815B1BF0-0x00000001815B1F70
	// [XID] // 0x0000000189884930-0x0000000189884950
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001815B0D90-0x00000001815B0F90
	[BlackList] // 0x000000018988BFC0-0x000000018988C000
	// [XID] // 0x000000018988BFC0-0x000000018988C000
	public static new SetCanDieImmediately ParseFromJson(JSONNode node) => default; // 0x00000001815B2A70-0x00000001815B2CC0
	// [XID] // 0x0000000189896300-0x0000000189896320
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF411B */, bool useObjectPool = false /* Metadata: 0x00AF411F */) => default; // 0x00000001815B2630-0x00000001815B2930
	// [XID] // 0x000000018989D980-0x000000018989D9A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4120 */, bool useObjectPool = false /* Metadata: 0x00AF4124 */) => default; // 0x00000001815B1760-0x00000001815B1990
	// [XID] // 0x00000001898A52C0-0x00000001898A52E0
	public static new SetCanDieImmediately ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4125 */, bool useObjectPool = false /* Metadata: 0x00AF4129 */) => default; // 0x00000001815B2010-0x00000001815B2230
	[BlackList] // 0x00000001898AC820-0x00000001898AC860
	// [XID] // 0x00000001898AC820-0x00000001898AC860
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001815B0F90-0x00000001815B1260
	// [XID] // 0x00000001898B6EF0-0x00000001898B6F10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001815B2F50-0x00000001815B3150
	[BlackList] // 0x00000001898BE680-0x00000001898BE6C0
	// [XID] // 0x00000001898BE680-0x00000001898BE6C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001815B2530-0x00000001815B2630
	// [XID] // 0x00000001898C9040-0x00000001898C9060
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001815B32F0-0x00000001815B3390
	// [XID] // 0x00000001898D0880-0x00000001898D08A0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001815B1990-0x00000001815B1AF0
	[BlackList] // 0x00000001898E77D0-0x00000001898E7810
	// [XID] // 0x00000001898E77D0-0x00000001898E7810
	public override void AutoAllocTypeFields() {} // 0x00000001815B1260-0x00000001815B1300
	[BlackList] // 0x00000001898F1EF0-0x00000001898F1F30
	// [XID] // 0x00000001898F1EF0-0x00000001898F1F30
	public override void AutoRecycleTypeFields() {} // 0x00000001815B1300-0x00000001815B13B0
	[BlackList] // 0x00000001898FC590-0x00000001898FC5D0
	// [XID] // 0x00000001898FC590-0x00000001898FC5D0
	public override void ReturnToObjectPool() {} // 0x00000001815B3390-0x00000001815B3430
}


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
public class AttackCostElementMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17000
{
	// Fields
	private StrikeType _strikeType; // 0x30
	private ElementType _elementType; // 0x34
	private AttackType _attackType; // 0x38
	private SimpleSafeFloat strikeCostRatioRawNum; // 0x3C
	private SimpleSafeFloat attackCostRatioRawNum; // 0x40
	private SimpleSafeFloat elementCostRatioRawNum; // 0x44
	private ElementType _costElementType; // 0x48
	private AttackCostType _costType; // 0x4C

	// Properties
	public StrikeType strikeType { /* [XID] */ /* 0x0000000189671E60-0x0000000189671E80 */ get => default; /* [XID] */ /* 0x0000000189679650-0x0000000189679670 */ private set {} } // 0x0000000184777890-0x0000000184777930 0x0000000184776DD0-0x0000000184776E80
	public ElementType elementType { /* [XID] */ /* 0x0000000189680DA0-0x0000000189680DC0 */ get => default; /* [XID] */ /* 0x00000001896887C0-0x00000001896887E0 */ private set {} } // 0x0000000184775F90-0x0000000184776030 0x0000000184777480-0x0000000184777530
	public AttackType attackType { /* [XID] */ /* 0x0000000189690180-0x00000001896901A0 */ get => default; /* [XID] */ /* 0x0000000189697B40-0x0000000189697B60 */ private set {} } // 0x0000000184776950-0x00000001847769F0 0x0000000184775790-0x0000000184775840
	public float strikeCostRatio { /* [XID] */ /* 0x000000018969EEB0-0x000000018969EED0 */ get => default; /* [XID] */ /* 0x00000001896A6350-0x00000001896A6370 */ private set {} } // 0x0000000184777340-0x0000000184777420 0x0000000184775530-0x0000000184775610
	public float attackCostRatio { /* [XID] */ /* 0x00000001896AD8B0-0x00000001896AD8D0 */ get => default; /* [XID] */ /* 0x00000001896B4F90-0x00000001896B4FB0 */ private set {} } // 0x0000000184775450-0x0000000184775530 0x0000000184775840-0x0000000184775920
	public float elementCostRatio { /* [XID] */ /* 0x00000001896BC280-0x00000001896BC2A0 */ get => default; /* [XID] */ /* 0x00000001896C3680-0x00000001896C36A0 */ private set {} } // 0x0000000184775920-0x0000000184775A00 0x00000001847765C0-0x00000001847766A0
	public ElementType costElementType { /* [XID] */ /* 0x00000001896CAC30-0x00000001896CAC50 */ get => default; /* [XID] */ /* 0x00000001896D22E0-0x00000001896D2300 */ private set {} } // 0x0000000184775670-0x0000000184775710 0x0000000184777F80-0x0000000184778030
	public AttackCostType costType { /* [XID] */ /* 0x00000001896D9C70-0x00000001896D9C90 */ get => default; /* [XID] */ /* 0x00000001896E12F0-0x00000001896E1310 */ private set {} } // 0x0000000184777930-0x00000001847779D0 0x0000000184776C30-0x0000000184776CE0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189764200-0x0000000189764220 */ get => default; } // 0x0000000184776130-0x00000001847761D0 

	// Constructors
	public AttackCostElementMixin() {} // 0x0000000184778280-0x0000000184778330

	// Methods
	// [XID] // 0x00000001896E85A0-0x00000001896E85C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184778030-0x00000001847781E0
	// [XID] // 0x00000001896EFAA0-0x00000001896EFAC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847777E0-0x0000000184777890
	// [XID] // 0x00000001896F74D0-0x00000001896F74F0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5FFD */) => default; // 0x0000000184777260-0x0000000184777340
	// [XID] // 0x00000001896FEE90-0x00000001896FEEB0
	public override int GetHashNum() => default; // 0x0000000184775380-0x0000000184775450
	// [XID] // 0x00000001897060E0-0x0000000189706100
	public override void InitEmpty() {} // 0x0000000184776A60-0x0000000184776B50
	[BlackList] // 0x000000018970D9F0-0x000000018970DA30
	// [XID] // 0x000000018970D9F0-0x000000018970DA30
	public override bool FromJson(JSONNode node) => default; // 0x00000001847761D0-0x0000000184776550
	// [XID] // 0x0000000189717FB0-0x0000000189717FD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184774570-0x0000000184774DF0
	[BlackList] // 0x000000018971F970-0x000000018971F9B0
	// [XID] // 0x000000018971F970-0x000000018971F9B0
	public static new AttackCostElementMixin ParseFromJson(JSONNode node) => default; // 0x0000000184777530-0x0000000184777780
	// [XID] // 0x0000000189729D80-0x0000000189729DA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FFE */, bool useObjectPool = false /* Metadata: 0x00AF6002 */) => default; // 0x0000000184776E80-0x0000000184777180
	// [XID] // 0x0000000189731480-0x00000001897314A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6003 */, bool useObjectPool = false /* Metadata: 0x00AF6007 */) => default; // 0x0000000184775A00-0x0000000184775F90
	// [XID] // 0x0000000189738CD0-0x0000000189738CF0
	public static new AttackCostElementMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6008 */, bool useObjectPool = false /* Metadata: 0x00AF600C */) => default; // 0x00000001847766A0-0x00000001847768C0
	[BlackList] // 0x0000000189740AA0-0x0000000189740AE0
	// [XID] // 0x0000000189740AA0-0x0000000189740AE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184774DF0-0x00000001847750C0
	// [XID] // 0x000000018974B320-0x000000018974B340
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847779D0-0x0000000184777F80
	[BlackList] // 0x00000001897523F0-0x0000000189752430
	// [XID] // 0x00000001897523F0-0x0000000189752430
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184776CE0-0x0000000184776DD0
	// [XID] // 0x000000018975CA70-0x000000018975CA90
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184777180-0x0000000184777260
	[BlackList] // 0x000000018976BAA0-0x000000018976BAE0
	// [XID] // 0x000000018976BAA0-0x000000018976BAE0
	public override void AutoAllocTypeFields() {} // 0x00000001847750C0-0x0000000184775160
	[BlackList] // 0x00000001897761E0-0x0000000189776220
	// [XID] // 0x00000001897761E0-0x0000000189776220
	public override void AutoRecycleTypeFields() {} // 0x0000000184775160-0x0000000184775260
	[BlackList] // 0x00000001897808A0-0x00000001897808E0
	// [XID] // 0x00000001897808A0-0x00000001897808E0
	public override void ReturnToObjectPool() {} // 0x00000001847781E0-0x0000000184778280
}


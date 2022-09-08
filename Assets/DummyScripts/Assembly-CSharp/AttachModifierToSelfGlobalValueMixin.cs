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
public class AttachModifierToSelfGlobalValueMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16928
{
	// Fields
	private AbilityTargetting _globalValueTarget; // 0x30
	private string _globalValueKey; // 0x38
	private AddActionType _addAction; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _defaultGlobalValueOnCreate; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private DynamicFloat[] _valueSteps; // 0x50
	private string[] _modifierNameSteps; // 0x58
	private ConfigAbilityAction[][] _actionQueues; // 0x60
	private bool _removeAppliedModifier; // 0x68

	// Properties
	public AbilityTargetting globalValueTarget { /* [XID] */ /* 0x00000001898BA380-0x00000001898BA3A0 */ get => default; /* [XID] */ /* 0x00000001898C16E0-0x00000001898C1700 */ private set {} } // 0x0000000184C43B40-0x0000000184C43BE0 0x0000000184C454C0-0x0000000184C45570
	public string globalValueKey { /* [XID] */ /* 0x00000001898C8FE0-0x00000001898C9000 */ get => default; /* [XID] */ /* 0x00000001898D0800-0x00000001898D0820 */ private set {} } // 0x0000000184C449C0-0x0000000184C44A60 0x0000000184C43340-0x0000000184C433F0
	public AddActionType addAction { /* [XID] */ /* 0x00000001898D7EC0-0x00000001898D7EE0 */ get => default; /* [XID] */ /* 0x00000001898DFCC0-0x00000001898DFCE0 */ private set {} } // 0x0000000184C422C0-0x0000000184C42360 0x0000000184C42E10-0x0000000184C42EC0
	public DynamicFloat defaultGlobalValueOnCreate { /* [XID] */ /* 0x00000001898E7710-0x00000001898E7730 */ get => default; /* [XID] */ /* 0x00000001898EEEE0-0x00000001898EEF00 */ private set {} } // 0x0000000184C44A60-0x0000000184C44B00 0x0000000184C45410-0x0000000184C454C0
	public DynamicFloat[] valueSteps { /* [XID] */ /* 0x00000001898F67E0-0x00000001898F6800 */ get => default; /* [XID] */ /* 0x00000001898FDF20-0x00000001898FDF40 */ private set {} } // 0x0000000184C44620-0x0000000184C446C0 0x0000000184C44250-0x0000000184C44300
	public string[] modifierNameSteps { /* [XID] */ /* 0x0000000189905700-0x0000000189905720 */ get => default; /* [XID] */ /* 0x000000018990CF50-0x000000018990CF70 */ private set {} } // 0x0000000184C43D10-0x0000000184C43DB0 0x0000000184C43BE0-0x0000000184C43C90
	public ConfigAbilityAction[][] actionQueues { /* [XID] */ /* 0x0000000189914720-0x0000000189914740 */ get => default; /* [XID] */ /* 0x000000018991C2A0-0x000000018991C2C0 */ private set {} } // 0x0000000184C446C0-0x0000000184C44760 0x0000000184C450B0-0x0000000184C45160
	public bool removeAppliedModifier { /* [XID] */ /* 0x0000000189923A20-0x0000000189923A40 */ get => default; /* [XID] */ /* 0x000000018992B060-0x000000018992B080 */ private set {} } // 0x0000000184C43150-0x0000000184C431F0 0x0000000184C45720-0x0000000184C457D0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899AF590-0x00000001899AF5B0 */ get => default; } // 0x0000000184C43E30-0x0000000184C43ED0 

	// Constructors
	public AttachModifierToSelfGlobalValueMixin() {} // 0x0000000184C46090-0x0000000184C46130

	// Methods
	// [XID] // 0x0000000189932700-0x0000000189932720
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184C45E20-0x0000000184C45FF0
	// [XID] // 0x000000018993A110-0x000000018993A130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184C455D0-0x0000000184C45720
	// [XID] // 0x00000001899412E0-0x0000000189941300
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5DCD */) => default; // 0x0000000184C44FD0-0x0000000184C450B0
	// [XID] // 0x0000000189948E40-0x0000000189948E60
	public override int GetHashNum() => default; // 0x0000000184C43270-0x0000000184C43340
	// [XID] // 0x0000000189950630-0x0000000189950650
	public override void InitEmpty() {} // 0x0000000184C447D0-0x0000000184C448E0
	[BlackList] // 0x0000000189957B40-0x0000000189957B80
	// [XID] // 0x0000000189957B40-0x0000000189957B80
	public override bool FromJson(JSONNode node) => default; // 0x0000000184C43ED0-0x0000000184C44250
	// [XID] // 0x0000000189962710-0x0000000189962730
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184C42360-0x0000000184C42B40
	[BlackList] // 0x0000000189969AC0-0x0000000189969B00
	// [XID] // 0x0000000189969AC0-0x0000000189969B00
	public static new AttachModifierToSelfGlobalValueMixin ParseFromJson(JSONNode node) => default; // 0x0000000184C451C0-0x0000000184C45410
	// [XID] // 0x00000001899744F0-0x0000000189974510
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DCE */, bool useObjectPool = false /* Metadata: 0x00AF5DD2 */) => default; // 0x0000000184C44BF0-0x0000000184C44EF0
	// [XID] // 0x000000018997BB40-0x000000018997BB60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DD3 */, bool useObjectPool = false /* Metadata: 0x00AF5DD7 */) => default; // 0x0000000184C434D0-0x0000000184C43B40
	// [XID] // 0x0000000189983690-0x00000001899836B0
	public static new AttachModifierToSelfGlobalValueMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DD8 */, bool useObjectPool = false /* Metadata: 0x00AF5DDC */) => default; // 0x0000000184C44370-0x0000000184C44590
	[BlackList] // 0x000000018998AE00-0x000000018998AE40
	// [XID] // 0x000000018998AE00-0x000000018998AE40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184C42B40-0x0000000184C42E10
	// [XID] // 0x0000000189995910-0x0000000189995930
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184C457D0-0x0000000184C45E20
	[BlackList] // 0x000000018999D210-0x000000018999D250
	// [XID] // 0x000000018999D210-0x000000018999D250
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184C44B00-0x0000000184C44BF0
	// [XID] // 0x00000001899A7E80-0x00000001899A7EA0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184C44EF0-0x0000000184C44FD0
	[BlackList] // 0x00000001899B6AB0-0x00000001899B6AF0
	// [XID] // 0x00000001899B6AB0-0x00000001899B6AF0
	public override void AutoAllocTypeFields() {} // 0x0000000184C42EC0-0x0000000184C42F60
	[BlackList] // 0x00000001899C1550-0x00000001899C1590
	// [XID] // 0x00000001899C1550-0x00000001899C1590
	public override void AutoRecycleTypeFields() {} // 0x0000000184C42F60-0x0000000184C430B0
	[BlackList] // 0x00000001899CBDE0-0x00000001899CBE20
	// [XID] // 0x00000001899CBDE0-0x00000001899CBE20
	public override void ReturnToObjectPool() {} // 0x0000000184C45FF0-0x0000000184C46090
}


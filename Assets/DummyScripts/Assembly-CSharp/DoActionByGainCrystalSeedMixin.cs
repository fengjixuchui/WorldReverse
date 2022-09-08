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
public class DoActionByGainCrystalSeedMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17108
{
	// Fields
	private ElementType[] _elementTypes; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x38

	// Properties
	public ElementType[] elementTypes { /* [XID] */ /* 0x00000001899D61F0-0x00000001899D6210 */ get => default; /* [XID] */ /* 0x00000001899DD680-0x00000001899DD6A0 */ private set {} } // 0x000000018473B550-0x000000018473B5F0 0x000000018473B980-0x000000018473BA30
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x00000001899E5360-0x00000001899E5380 */ get => default; /* [XID] */ /* 0x00000001899EC630-0x00000001899EC650 */ private set {} } // 0x000000018473CE70-0x000000018473CF10 0x000000018473B250-0x000000018473B300
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A6FAE0-0x0000000189A6FB00 */ get => default; } // 0x000000018473BB30-0x000000018473BBD0 

	// Constructors
	public DoActionByGainCrystalSeedMixin() {} // 0x000000018473D3B0-0x000000018473D410

	// Methods
	// [XID] // 0x00000001899F43B0-0x00000001899F43D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018473D200-0x000000018473D310
	// [XID] // 0x00000001899FB910-0x00000001899FB930
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018473CD70-0x000000018473CE70
	// [XID] // 0x0000000189A02CD0-0x0000000189A02CF0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6383 */) => default; // 0x000000018473C980-0x000000018473CA60
	// [XID] // 0x0000000189A0A300-0x0000000189A0A320
	public override int GetHashNum() => default; // 0x000000018473B420-0x000000018473B4F0
	// [XID] // 0x0000000189A11C60-0x0000000189A11C80
	public override void InitEmpty() {} // 0x000000018473C2E0-0x000000018473C3D0
	[BlackList] // 0x0000000189A18F10-0x0000000189A18F50
	// [XID] // 0x0000000189A18F10-0x0000000189A18F50
	public override bool FromJson(JSONNode node) => default; // 0x000000018473BBD0-0x000000018473BF50
	// [XID] // 0x0000000189A23660-0x0000000189A23680
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018473AB00-0x000000018473AE20
	[BlackList] // 0x0000000189A2AA40-0x0000000189A2AA80
	// [XID] // 0x0000000189A2AA40-0x0000000189A2AA80
	public static new DoActionByGainCrystalSeedMixin ParseFromJson(JSONNode node) => default; // 0x000000018473CAC0-0x000000018473CD10
	// [XID] // 0x0000000189A35250-0x0000000189A35270
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6384 */, bool useObjectPool = false /* Metadata: 0x00AF6388 */) => default; // 0x000000018473C5A0-0x000000018473C8A0
	// [XID] // 0x0000000189A3C800-0x0000000189A3C820
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6389 */, bool useObjectPool = false /* Metadata: 0x00AF638D */) => default; // 0x000000018473B670-0x000000018473B980
	// [XID] // 0x0000000189A44270-0x0000000189A44290
	public static new DoActionByGainCrystalSeedMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF638E */, bool useObjectPool = false /* Metadata: 0x00AF6392 */) => default; // 0x000000018473BFC0-0x000000018473C1E0
	[BlackList] // 0x0000000189A4B7A0-0x0000000189A4B7E0
	// [XID] // 0x0000000189A4B7A0-0x0000000189A4B7E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018473AE20-0x000000018473B0F0
	// [XID] // 0x0000000189A56060-0x0000000189A56080
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018473CF10-0x000000018473D200
	[BlackList] // 0x0000000189A5DAE0-0x0000000189A5DB20
	// [XID] // 0x0000000189A5DAE0-0x0000000189A5DB20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018473C4B0-0x000000018473C5A0
	// [XID] // 0x0000000189A686F0-0x0000000189A68710
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018473C8A0-0x000000018473C980
	[BlackList] // 0x0000000189A77230-0x0000000189A77270
	// [XID] // 0x0000000189A77230-0x0000000189A77270
	public override void AutoAllocTypeFields() {} // 0x000000018473B0F0-0x000000018473B190
	[BlackList] // 0x0000000189A81BF0-0x0000000189A81C30
	// [XID] // 0x0000000189A81BF0-0x0000000189A81C30
	public override void AutoRecycleTypeFields() {} // 0x000000018473B190-0x000000018473B250
	[BlackList] // 0x0000000189A8C5D0-0x0000000189A8C610
	// [XID] // 0x0000000189A8C5D0-0x0000000189A8C610
	public override void ReturnToObjectPool() {} // 0x000000018473D310-0x000000018473D3B0
}


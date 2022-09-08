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
public class DoActionByStateIDMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17047
{
	// Fields
	private string[] _stateIDs; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _enterPredicates; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _exitPredicates; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _enterActions; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _exitActions; // 0x50

	// Properties
	public string[] stateIDs { /* [XID] */ /* 0x00000001898CD5A0-0x00000001898CD5C0 */ get => default; /* [XID] */ /* 0x00000001898D4F90-0x00000001898D4FB0 */ private set {} } // 0x00000001851F2550-0x00000001851F25F0 0x00000001851F25F0-0x00000001851F26A0
	public ConfigAbilityPredicate[] enterPredicates { /* [XID] */ /* 0x00000001898DC8F0-0x00000001898DC910 */ get => default; /* [XID] */ /* 0x00000001898E4340-0x00000001898E4360 */ private set {} } // 0x00000001851F0E70-0x00000001851F0F10 0x00000001851EFC10-0x00000001851EFCC0
	public ConfigAbilityPredicate[] exitPredicates { /* [XID] */ /* 0x00000001898EBD50-0x00000001898EBD70 */ get => default; /* [XID] */ /* 0x00000001898F3620-0x00000001898F3640 */ private set {} } // 0x00000001851EF2F0-0x00000001851EF390 0x00000001851F1BC0-0x00000001851F1C70
	public ConfigAbilityAction[] enterActions { /* [XID] */ /* 0x00000001898FAC40-0x00000001898FAC60 */ get => default; /* [XID] */ /* 0x00000001899027A0-0x00000001899027C0 */ private set {} } // 0x00000001851F10B0-0x00000001851F1150 0x00000001851F2330-0x00000001851F23E0
	public ConfigAbilityAction[] exitActions { /* [XID] */ /* 0x0000000189909DA0-0x0000000189909DC0 */ get => default; /* [XID] */ /* 0x0000000189911600-0x0000000189911620 */ private set {} } // 0x00000001851F0FA0-0x00000001851F1040 0x00000001851F0DC0-0x00000001851F0E70
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899958D0-0x00000001899958F0 */ get => default; } // 0x00000001851F0710-0x00000001851F07B0 

	// Constructors
	public DoActionByStateIDMixin() {} // 0x00000001851F2740-0x00000001851F27A0

	// Methods
	// [XID] // 0x00000001899191C0-0x00000001899191E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851F23E0-0x00000001851F2550
	// [XID] // 0x0000000189920710-0x0000000189920730
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001851F1CD0-0x00000001851F1E20
	// [XID] // 0x00000001899280B0-0x00000001899280D0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6173 */) => default; // 0x00000001851F1830-0x00000001851F1910
	// [XID] // 0x000000018992F700-0x000000018992F720
	public override int GetHashNum() => default; // 0x00000001851EFF60-0x00000001851F0030
	// [XID] // 0x0000000189936B70-0x0000000189936B90
	public override void InitEmpty() {} // 0x00000001851F1150-0x00000001851F1280
	[BlackList] // 0x000000018993E730-0x000000018993E770
	// [XID] // 0x000000018993E730-0x000000018993E770
	public override bool FromJson(JSONNode node) => default; // 0x00000001851F07B0-0x00000001851F0B30
	// [XID] // 0x0000000189948D60-0x0000000189948D80
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001851EF390-0x00000001851EF940
	[BlackList] // 0x0000000189950550-0x0000000189950590
	// [XID] // 0x0000000189950550-0x0000000189950590
	public static new DoActionByStateIDMixin ParseFromJson(JSONNode node) => default; // 0x00000001851F1970-0x00000001851F1BC0
	// [XID] // 0x000000018995AB70-0x000000018995AB90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6174 */, bool useObjectPool = false /* Metadata: 0x00AF6178 */) => default; // 0x00000001851F1450-0x00000001851F1750
	// [XID] // 0x00000001899626D0-0x00000001899626F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6179 */, bool useObjectPool = false /* Metadata: 0x00AF617D */) => default; // 0x00000001851F0110-0x00000001851F0610
	// [XID] // 0x0000000189969A80-0x0000000189969AA0
	public static new DoActionByStateIDMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF617E */, bool useObjectPool = false /* Metadata: 0x00AF6182 */) => default; // 0x00000001851F0BA0-0x00000001851F0DC0
	[BlackList] // 0x0000000189971800-0x0000000189971840
	// [XID] // 0x0000000189971800-0x0000000189971840
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001851EF940-0x00000001851EFC10
	// [XID] // 0x000000018997BB00-0x000000018997BB20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851F1E20-0x00000001851F2330
	[BlackList] // 0x00000001899835F0-0x0000000189983630
	// [XID] // 0x00000001899835F0-0x0000000189983630
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851F1360-0x00000001851F1450
	// [XID] // 0x000000018998DDE0-0x000000018998DE00
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001851F1750-0x00000001851F1830
	[BlackList] // 0x000000018999D1B0-0x000000018999D1F0
	// [XID] // 0x000000018999D1B0-0x000000018999D1F0
	public override void AutoAllocTypeFields() {} // 0x00000001851EFCC0-0x00000001851EFD60
	[BlackList] // 0x00000001899A7E40-0x00000001899A7E80
	// [XID] // 0x00000001899A7E40-0x00000001899A7E80
	public override void AutoRecycleTypeFields() {} // 0x00000001851EFD60-0x00000001851EFE40
	[BlackList] // 0x00000001899B26F0-0x00000001899B2730
	// [XID] // 0x00000001899B26F0-0x00000001899B2730
	public override void ReturnToObjectPool() {} // 0x00000001851F26A0-0x00000001851F2740
}


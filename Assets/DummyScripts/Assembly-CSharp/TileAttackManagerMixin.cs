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
public class TileAttackManagerMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17072
{
	// Fields
	private string _attackID; // 0x30
	private SimpleSafeFloat intervalRawNum; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAttackInfo _attackInfo; // 0x40

	// Properties
	public string attackID { /* [XID] */ /* 0x0000000189840DE0-0x0000000189840E00 */ get => default; /* [XID] */ /* 0x00000001898482C0-0x00000001898482E0 */ private set {} } // 0x0000000181E166B0-0x0000000181E16750 0x0000000181E16750-0x0000000181E16800
	public float interval { /* [XID] */ /* 0x000000018984FA40-0x000000018984FA60 */ get => default; /* [XID] */ /* 0x0000000189856DC0-0x0000000189856DE0 */ private set {} } // 0x0000000181E17F00-0x0000000181E17FE0 0x0000000181E16CC0-0x0000000181E16DA0
	public ConfigAttackInfo attackInfo { /* [XID] */ /* 0x000000018985DED0-0x000000018985DEF0 */ get => default; /* [XID] */ /* 0x0000000189865930-0x0000000189865950 */ private set {} } // 0x0000000181E17D20-0x0000000181E17DC0 0x0000000181E15AE0-0x0000000181E15B90
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898E8E40-0x00000001898E8E60 */ get => default; } // 0x0000000181E16EA0-0x0000000181E16F40 

	// Constructors
	public TileAttackManagerMixin() {} // 0x0000000181E188B0-0x0000000181E18910

	// Methods
	// [XID] // 0x000000018986CDD0-0x000000018986CDF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181E186D0-0x0000000181E18810
	// [XID] // 0x0000000189874260-0x0000000189874280
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181E18290-0x0000000181E18390
	// [XID] // 0x000000018987BD80-0x000000018987BDA0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6233 */) => default; // 0x0000000181E17DC0-0x0000000181E17EA0
	// [XID] // 0x0000000189882F30-0x0000000189882F50
	public override int GetHashNum() => default; // 0x0000000181E165E0-0x0000000181E166B0
	// [XID] // 0x000000018988A6D0-0x000000018988A6F0
	public override void InitEmpty() {} // 0x0000000181E17650-0x0000000181E17770
	[BlackList] // 0x0000000189891BE0-0x0000000189891C20
	// [XID] // 0x0000000189891BE0-0x0000000189891C20
	public override bool FromJson(JSONNode node) => default; // 0x0000000181E16F40-0x0000000181E172C0
	// [XID] // 0x000000018989C180-0x000000018989C1A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181E15B90-0x0000000181E15FE0
	[BlackList] // 0x00000001898A37E0-0x00000001898A3820
	// [XID] // 0x00000001898A37E0-0x00000001898A3820
	public static new TileAttackManagerMixin ParseFromJson(JSONNode node) => default; // 0x0000000181E17FE0-0x0000000181E18230
	// [XID] // 0x00000001898AE0D0-0x00000001898AE0F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6234 */, bool useObjectPool = false /* Metadata: 0x00AF6238 */) => default; // 0x0000000181E17940-0x0000000181E17C40
	// [XID] // 0x00000001898B5610-0x00000001898B5630
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6239 */, bool useObjectPool = false /* Metadata: 0x00AF623D */) => default; // 0x0000000181E168E0-0x0000000181E16CC0
	// [XID] // 0x00000001898BCFE0-0x00000001898BD000
	public static new TileAttackManagerMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF623E */, bool useObjectPool = false /* Metadata: 0x00AF6242 */) => default; // 0x0000000181E17330-0x0000000181E17550
	[BlackList] // 0x00000001898C47E0-0x00000001898C4820
	// [XID] // 0x00000001898C47E0-0x00000001898C4820
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181E15FE0-0x0000000181E162B0
	// [XID] // 0x00000001898CEDB0-0x00000001898CEDD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181E18390-0x0000000181E186D0
	[BlackList] // 0x00000001898D6800-0x00000001898D6840
	// [XID] // 0x00000001898D6800-0x00000001898D6840
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181E17850-0x0000000181E17940
	// [XID] // 0x00000001898E13F0-0x00000001898E1410
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181E17C40-0x0000000181E17D20
	[BlackList] // 0x00000001898F0580-0x00000001898F05C0
	// [XID] // 0x00000001898F0580-0x00000001898F05C0
	public override void AutoAllocTypeFields() {} // 0x0000000181E162B0-0x0000000181E16350
	[BlackList] // 0x00000001898FAC00-0x00000001898FAC40
	// [XID] // 0x00000001898FAC00-0x00000001898FAC40
	public override void AutoRecycleTypeFields() {} // 0x0000000181E16350-0x0000000181E164C0
	[BlackList] // 0x0000000189905660-0x00000001899056A0
	// [XID] // 0x0000000189905660-0x00000001899056A0
	public override void ReturnToObjectPool() {} // 0x0000000181E18810-0x0000000181E188B0
}


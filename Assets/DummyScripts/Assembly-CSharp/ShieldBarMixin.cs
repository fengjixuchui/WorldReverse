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
public class ShieldBarMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16914
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onShieldBroken; // 0x30
	private bool _revert; // 0x38
	private string _showDamageText; // 0x40
	private bool _useMutiPlayerFixData; // 0x48

	// Properties
	public ConfigAbilityAction[] onShieldBroken { /* [XID] */ /* 0x000000018993FD40-0x000000018993FD60 */ get => default; /* [XID] */ /* 0x0000000189947460-0x0000000189947480 */ private set {} } // 0x0000000182C2F9C0-0x0000000182C2FA60 0x0000000182C2E620-0x0000000182C2E6D0
	public bool revert { /* [XID] */ /* 0x000000018994EBC0-0x000000018994EBE0 */ get => default; /* [XID] */ /* 0x0000000189956120-0x0000000189956140 */ private set {} } // 0x0000000182C2D800-0x0000000182C2D8A0 0x0000000182C2F720-0x0000000182C2F7D0
	public string showDamageText { /* [XID] */ /* 0x000000018995DC30-0x000000018995DC50 */ get => default; /* [XID] */ /* 0x0000000189965450-0x0000000189965470 */ private set {} } // 0x0000000182C2F920-0x0000000182C2F9C0 0x0000000182C2D6F0-0x0000000182C2D7A0
	public bool useMutiPlayerFixData { /* [XID] */ /* 0x000000018996CA70-0x000000018996CA90 */ get => default; /* [XID] */ /* 0x0000000189974510-0x0000000189974530 */ private set {} } // 0x0000000182C2DF70-0x0000000182C2E010 0x0000000182C2DDA0-0x0000000182C2DE50
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899F8770-0x00000001899F8790 */ get => default; } // 0x0000000182C2DED0-0x0000000182C2DF70 

	// Constructors
	public ShieldBarMixin() {} // 0x0000000182C2FB00-0x0000000182C2FB70

	// Methods
	// [XID] // 0x000000018997BB60-0x000000018997BB80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C2F7D0-0x0000000182C2F920
	// [XID] // 0x00000001899836B0-0x00000001899836D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182C2F260-0x0000000182C2F360
	// [XID] // 0x000000018998AE40-0x000000018998AE60
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5D69 */) => default; // 0x0000000182C2EE70-0x0000000182C2EF50
	// [XID] // 0x0000000189992730-0x0000000189992750
	public override int GetHashNum() => default; // 0x0000000182C2D620-0x0000000182C2D6F0
	// [XID] // 0x000000018999A510-0x000000018999A530
	public override void InitEmpty() {} // 0x0000000182C2E7D0-0x0000000182C2E8C0
	[BlackList] // 0x00000001899A1B90-0x00000001899A1BD0
	// [XID] // 0x00000001899A1B90-0x00000001899A1BD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182C2E010-0x0000000182C2E390
	// [XID] // 0x00000001899AC770-0x00000001899AC790
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182C2CC50-0x0000000182C2D0D0
	[BlackList] // 0x00000001899B3E60-0x00000001899B3EA0
	// [XID] // 0x00000001899B3E60-0x00000001899B3EA0
	public static new ShieldBarMixin ParseFromJson(JSONNode node) => default; // 0x0000000182C2EFB0-0x0000000182C2F200
	// [XID] // 0x00000001899BE570-0x00000001899BE590
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D6A */, bool useObjectPool = false /* Metadata: 0x00AF5D6E */) => default; // 0x0000000182C2EA90-0x0000000182C2ED90
	// [XID] // 0x00000001899C5D30-0x00000001899C5D50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D6F */, bool useObjectPool = false /* Metadata: 0x00AF5D73 */) => default; // 0x0000000182C2D920-0x0000000182C2DD20
	// [XID] // 0x00000001899CD4B0-0x00000001899CD4D0
	public static new ShieldBarMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D74 */, bool useObjectPool = false /* Metadata: 0x00AF5D78 */) => default; // 0x0000000182C2E400-0x0000000182C2E620
	[BlackList] // 0x00000001899D4970-0x00000001899D49B0
	// [XID] // 0x00000001899D4970-0x00000001899D49B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C2D0D0-0x0000000182C2D3A0
	// [XID] // 0x00000001899DEDD0-0x00000001899DEDF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C2F360-0x0000000182C2F720
	[BlackList] // 0x00000001899E69B0-0x00000001899E69F0
	// [XID] // 0x00000001899E69B0-0x00000001899E69F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182C2E9A0-0x0000000182C2EA90
	// [XID] // 0x00000001899F0E50-0x00000001899F0E70
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182C2ED90-0x0000000182C2EE70
	[BlackList] // 0x00000001899FFD00-0x00000001899FFD40
	// [XID] // 0x00000001899FFD00-0x00000001899FFD40
	public override void AutoAllocTypeFields() {} // 0x0000000182C2D3A0-0x0000000182C2D440
	[BlackList] // 0x0000000189A0A3E0-0x0000000189A0A420
	// [XID] // 0x0000000189A0A3E0-0x0000000189A0A420
	public override void AutoRecycleTypeFields() {} // 0x0000000182C2D440-0x0000000182C2D500
	[BlackList] // 0x0000000189A14BC0-0x0000000189A14C00
	// [XID] // 0x0000000189A14BC0-0x0000000189A14C00
	public override void ReturnToObjectPool() {} // 0x0000000182C2FA60-0x0000000182C2FB00
}


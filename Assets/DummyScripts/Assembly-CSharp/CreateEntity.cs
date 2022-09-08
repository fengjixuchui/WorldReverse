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
public class CreateEntity : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16497
{
	// Fields
	private bool _ownerIsTarget; // 0x68
	private AbilityTargetting _ownerIs; // 0x6C
	private AbilityTargetting _propOwnerIs; // 0x70
	private bool _lifeByOwnerIsAlive; // 0x74
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private CheckGround _checkGround; // 0x80
	private bool _sightGroupWithOwner; // 0x88

	// Properties
	public bool ownerIsTarget { /* [XID] */ /* 0x00000001899CBEE0-0x00000001899CBF00 */ get => default; /* [XID] */ /* 0x00000001899D3410-0x00000001899D3430 */ private set {} } // 0x0000000183CC3B80-0x0000000183CC3C20 0x0000000183CC2710-0x0000000183CC27C0
	public AbilityTargetting ownerIs { /* [XID] */ /* 0x00000001899DA980-0x00000001899DA9A0 */ get => default; /* [XID] */ /* 0x00000001899E2300-0x00000001899E2320 */ private set {} } // 0x0000000183CC2CA0-0x0000000183CC2D40 0x0000000183CC3EB0-0x0000000183CC3F60
	public AbilityTargetting propOwnerIs { /* [XID] */ /* 0x00000001899E97C0-0x00000001899E97E0 */ get => default; /* [XID] */ /* 0x00000001899F0F10-0x00000001899F0F30 */ private set {} } // 0x0000000183CC2B30-0x0000000183CC2BD0 0x0000000183CC3620-0x0000000183CC36D0
	public bool lifeByOwnerIsAlive { /* [XID] */ /* 0x00000001899F87D0-0x00000001899F87F0 */ get => default; /* [XID] */ /* 0x00000001899FFDA0-0x00000001899FFDC0 */ private set {} } // 0x0000000183CC1CC0-0x0000000183CC1D60 0x0000000183CC36D0-0x0000000183CC3780
	public ConfigBornType born { /* [XID] */ /* 0x0000000189A07630-0x0000000189A07650 */ get => default; /* [XID] */ /* 0x0000000189A0EAB0-0x0000000189A0EAD0 */ private set {} } // 0x0000000183CC2DF0-0x0000000183CC2E90 0x0000000183CC51E0-0x0000000183CC5290
	public CheckGround checkGround { /* [XID] */ /* 0x0000000189A16200-0x0000000189A16220 */ get => default; /* [XID] */ /* 0x0000000189A1D7A0-0x0000000189A1D7C0 */ private set {} } // 0x0000000183CC4F70-0x0000000183CC5020 0x0000000183CC1B90-0x0000000183CC1C40
	public bool sightGroupWithOwner { /* [XID] */ /* 0x0000000189A24B50-0x0000000189A24B70 */ get => default; /* [XID] */ /* 0x0000000189A2C1F0-0x0000000189A2C210 */ private set {} } // 0x0000000183CC3570-0x0000000183CC3620 0x0000000183CC2D40-0x0000000183CC2DF0

	// Constructors
	public CreateEntity() {} // 0x0000000183CC5330-0x0000000183CC53B0

	// Methods
	// [XID] // 0x0000000189A33920-0x0000000189A33940
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183CC5020-0x0000000183CC51E0
	// [XID] // 0x0000000189A3B0C0-0x0000000189A3B0E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183CC4910-0x0000000183CC4A10
	// [XID] // 0x0000000189A42A10-0x0000000189A42A30
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3D4A */) => default; // 0x0000000183CC4520-0x0000000183CC4600
	// [XID] // 0x0000000189A49F20-0x0000000189A49F40
	public override int GetHashNum() => default; // 0x0000000183CC2BD0-0x0000000183CC2CA0
	// [XID] // 0x0000000189A518B0-0x0000000189A518D0
	public override void InitEmpty() {} // 0x0000000183CC3F60-0x0000000183CC4050
	[BlackList] // 0x0000000189A59140-0x0000000189A59180
	// [XID] // 0x0000000189A59140-0x0000000189A59180
	public override bool FromJson(JSONNode node) => default; // 0x0000000183CC3800-0x0000000183CC3B80
	// [XID] // 0x0000000189A63C30-0x0000000189A63C50
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183CC1D60-0x0000000183CC2440
	[BlackList] // 0x0000000189A6B450-0x0000000189A6B490
	// [XID] // 0x0000000189A6B450-0x0000000189A6B490
	public static new CreateEntity ParseFromJson(JSONNode node) => default; // 0x0000000183CC4660-0x0000000183CC48B0
	// [XID] // 0x0000000189A759B0-0x0000000189A759D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D4B */, bool useObjectPool = false /* Metadata: 0x00AF3D4F */) => default; // 0x0000000183CC4220-0x0000000183CC4520
	// [XID] // 0x0000000189A7D650-0x0000000189A7D670
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D50 */, bool useObjectPool = false /* Metadata: 0x00AF3D54 */) => default; // 0x0000000183CC2F70-0x0000000183CC34F0
	// [XID] // 0x0000000189A84DA0-0x0000000189A84DC0
	public static new CreateEntity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D55 */, bool useObjectPool = false /* Metadata: 0x00AF3D59 */) => default; // 0x0000000183CC3C20-0x0000000183CC3E40
	[BlackList] // 0x0000000189A8C710-0x0000000189A8C750
	// [XID] // 0x0000000189A8C710-0x0000000189A8C750
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183CC2440-0x0000000183CC2710
	// [XID] // 0x0000000189A96D00-0x0000000189A96D20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183CC4A10-0x0000000183CC4F70
	[BlackList] // 0x0000000189A9E150-0x0000000189A9E190
	// [XID] // 0x0000000189A9E150-0x0000000189A9E190
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183CC4130-0x0000000183CC4220
	[BlackList] // 0x0000000189AA8700-0x0000000189AA8740
	// [XID] // 0x0000000189AA8700-0x0000000189AA8740
	public override void AutoAllocTypeFields() {} // 0x0000000183CC27C0-0x0000000183CC2860
	[BlackList] // 0x0000000189AB3320-0x0000000189AB3360
	// [XID] // 0x0000000189AB3320-0x0000000189AB3360
	public override void AutoRecycleTypeFields() {} // 0x0000000183CC2860-0x0000000183CC2A10
	[BlackList] // 0x0000000189ABDDD0-0x0000000189ABDE10
	// [XID] // 0x0000000189ABDDD0-0x0000000189ABDE10
	public override void ReturnToObjectPool() {} // 0x0000000183CC5290-0x0000000183CC5330
}


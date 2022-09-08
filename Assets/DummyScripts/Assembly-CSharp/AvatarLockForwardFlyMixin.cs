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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AvatarLockForwardFlyMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17039
{
	// Fields
	private MoleMole.Config.Vector _worldForward; // 0x30
	private SimpleSafeFloat flySpeedScaleRawNum; // 0x3C
	private SimpleSafeFloat flyBackSpeedScaleRawNum; // 0x40
	private MoleMole.Config.Vector _eularRawInput; // 0x44

	// Properties
	public MoleMole.Config.Vector worldForward { /* [XID] */ /* 0x0000000189B7BD90-0x0000000189B7BDB0 */ get => default; /* [XID] */ /* 0x0000000189B83640-0x0000000189B83660 */ private set {} } // 0x00000001832D7260-0x00000001832D7340 0x00000001832D8AC0-0x00000001832D8B90
	public float flySpeedScale { /* [XID] */ /* 0x0000000189B8AA90-0x0000000189B8AAB0 */ get => default; /* [XID] */ /* 0x0000000189B92040-0x0000000189B92060 */ private set {} } // 0x00000001832D7AA0-0x00000001832D7B80 0x00000001832D6D60-0x00000001832D6E40
	public float flyBackSpeedScale { /* [XID] */ /* 0x0000000189B99580-0x0000000189B995A0 */ get => default; /* [XID] */ /* 0x0000000189BA0A50-0x0000000189BA0A70 */ private set {} } // 0x00000001832D77A0-0x00000001832D7880 0x00000001832D65E0-0x00000001832D66C0
	public MoleMole.Config.Vector eularRawInput { /* [XID] */ /* 0x0000000189BA8110-0x0000000189BA8130 */ get => default; /* [XID] */ /* 0x0000000189BAF5A0-0x0000000189BAF5C0 */ private set {} } // 0x00000001832D67A0-0x00000001832D6880 0x00000001832D75D0-0x00000001832D76A0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189638C30-0x0000000189638C50 */ get => default; } // 0x00000001832D6E40-0x00000001832D6EE0 

	// Constructors
	public AvatarLockForwardFlyMixin() {} // 0x00000001832D8C30-0x00000001832D8CE0

	// Methods
	// [XID] // 0x0000000189BB6C50-0x0000000189BB6C70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832D8920-0x00000001832D8AC0
	// [XID] // 0x0000000189BBE2F0-0x0000000189BBE310
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001832D8440-0x00000001832D84F0
	// [XID] // 0x0000000189BC5F80-0x0000000189BC5FA0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6133 */) => default; // 0x00000001832D8050-0x00000001832D8130
	// [XID] // 0x0000000189BCDAA0-0x0000000189BCDAC0
	public override int GetHashNum() => default; // 0x00000001832D6510-0x00000001832D65E0
	// [XID] // 0x0000000189BD4F70-0x0000000189BD4F90
	public override void InitEmpty() {} // 0x00000001832D7880-0x00000001832D79C0
	[BlackList] // 0x0000000189BDCAE0-0x0000000189BDCB20
	// [XID] // 0x0000000189BDCAE0-0x0000000189BDCB20
	public override bool FromJson(JSONNode node) => default; // 0x00000001832D6EE0-0x00000001832D7260
	// [XID] // 0x00000001895EC550-0x00000001895EC570
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001832D5A50-0x00000001832D5F70
	[BlackList] // 0x00000001895F3A70-0x00000001895F3AB0
	// [XID] // 0x00000001895F3A70-0x00000001895F3AB0
	public static new AvatarLockForwardFlyMixin ParseFromJson(JSONNode node) => default; // 0x00000001832D8190-0x00000001832D83E0
	// [XID] // 0x00000001895FE200-0x00000001895FE220
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6134 */, bool useObjectPool = false /* Metadata: 0x00AF6138 */) => default; // 0x00000001832D7C70-0x00000001832D7F70
	// [XID] // 0x0000000189605A10-0x0000000189605A30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6139 */, bool useObjectPool = false /* Metadata: 0x00AF613D */) => default; // 0x00000001832D6880-0x00000001832D6C60
	// [XID] // 0x000000018960D380-0x000000018960D3A0
	public static new AvatarLockForwardFlyMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF613E */, bool useObjectPool = false /* Metadata: 0x00AF6142 */) => default; // 0x00000001832D73B0-0x00000001832D75D0
	[BlackList] // 0x0000000189614A20-0x0000000189614A60
	// [XID] // 0x0000000189614A20-0x0000000189614A60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001832D5F70-0x00000001832D6240
	// [XID] // 0x000000018961F3C0-0x000000018961F3E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832D84F0-0x00000001832D8920
	[BlackList] // 0x00000001896267C0-0x0000000189626800
	// [XID] // 0x00000001896267C0-0x0000000189626800
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001832D7B80-0x00000001832D7C70
	// [XID] // 0x0000000189631280-0x00000001896312A0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001832D7F70-0x00000001832D8050
	[BlackList] // 0x00000001896400B0-0x00000001896400F0
	// [XID] // 0x00000001896400B0-0x00000001896400F0
	public override void AutoAllocTypeFields() {} // 0x00000001832D6240-0x00000001832D62E0
	[BlackList] // 0x000000018964A860-0x000000018964A8A0
	// [XID] // 0x000000018964A860-0x000000018964A8A0
	public override void AutoRecycleTypeFields() {} // 0x00000001832D62E0-0x00000001832D63F0
	[BlackList] // 0x00000001896550A0-0x00000001896550E0
	// [XID] // 0x00000001896550A0-0x00000001896550E0
	public override void ReturnToObjectPool() {} // 0x00000001832D8B90-0x00000001832D8C30
}


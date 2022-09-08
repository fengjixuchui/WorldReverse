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
public class AutoDefenceMixin : EntityDefenceMixin, IAutoAllocRecycle // TypeDefIndex: 16973
{
	// Fields
	private SimpleSafeFloat costStaminaRatioRawNum; // 0x70

	// Properties
	public float costStaminaRatio { /* [XID] */ /* 0x0000000189799BF0-0x0000000189799C10 */ get => default; /* [XID] */ /* 0x00000001897A1A60-0x00000001897A1A80 */ private set {} } // 0x00000001831E1400-0x00000001831E14E0 0x00000001831E0940-0x00000001831E0A20
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189826450-0x0000000189826470 */ get => default; } // 0x00000001831E0040-0x00000001831E00E0 

	// Constructors
	public AutoDefenceMixin() {} // 0x00000001831E1870-0x00000001831E18D0

	// Methods
	// [XID] // 0x00000001897A92E0-0x00000001897A9300
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001831E16D0-0x00000001831E17D0
	// [XID] // 0x00000001897B0AC0-0x00000001897B0AE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001831E1350-0x00000001831E1400
	// [XID] // 0x00000001897B8820-0x00000001897B8840
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5F2F */) => default; // 0x00000001831E0F60-0x00000001831E1040
	// [XID] // 0x00000001897C0880-0x00000001897C08A0
	public override int GetHashNum() => default; // 0x00000001831DFB20-0x00000001831DFBF0
	// [XID] // 0x00000001897C8150-0x00000001897C8170
	public override void InitEmpty() {} // 0x00000001831E07F0-0x00000001831E08C0
	[BlackList] // 0x00000001897CF510-0x00000001897CF550
	// [XID] // 0x00000001897CF510-0x00000001897CF550
	public override bool FromJson(JSONNode node) => default; // 0x00000001831E00E0-0x00000001831E0460
	// [XID] // 0x00000001897DA1D0-0x00000001897DA1F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001831DF340-0x00000001831DF5B0
	[BlackList] // 0x00000001897E1600-0x00000001897E1640
	// [XID] // 0x00000001897E1600-0x00000001897E1640
	public static new AutoDefenceMixin ParseFromJson(JSONNode node) => default; // 0x00000001831E10A0-0x00000001831E12F0
	// [XID] // 0x00000001897EC0C0-0x00000001897EC0E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F30 */, bool useObjectPool = false /* Metadata: 0x00AF5F34 */) => default; // 0x00000001831E0B80-0x00000001831E0E80
	// [XID] // 0x00000001897F3A70-0x00000001897F3A90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F35 */, bool useObjectPool = false /* Metadata: 0x00AF5F39 */) => default; // 0x00000001831DFCD0-0x00000001831DFF40
	// [XID] // 0x00000001897FB470-0x00000001897FB490
	public static new AutoDefenceMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F3A */, bool useObjectPool = false /* Metadata: 0x00AF5F3E */) => default; // 0x00000001831E04D0-0x00000001831E06F0
	[BlackList] // 0x0000000189802840-0x0000000189802880
	// [XID] // 0x0000000189802840-0x0000000189802880
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001831DF5B0-0x00000001831DF880
	// [XID] // 0x000000018980CB50-0x000000018980CB70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001831E14E0-0x00000001831E16D0
	[BlackList] // 0x00000001898143D0-0x0000000189814410
	// [XID] // 0x00000001898143D0-0x0000000189814410
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001831E0A80-0x00000001831E0B80
	// [XID] // 0x000000018981EF80-0x000000018981EFA0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001831E0E80-0x00000001831E0F60
	[BlackList] // 0x000000018982DAE0-0x000000018982DB20
	// [XID] // 0x000000018982DAE0-0x000000018982DB20
	public override void AutoAllocTypeFields() {} // 0x00000001831DF880-0x00000001831DF920
	[BlackList] // 0x0000000189838160-0x00000001898381A0
	// [XID] // 0x0000000189838160-0x00000001898381A0
	public override void AutoRecycleTypeFields() {} // 0x00000001831DF920-0x00000001831DFA00
	[BlackList] // 0x00000001898428E0-0x0000000189842920
	// [XID] // 0x00000001898428E0-0x0000000189842920
	public override void ReturnToObjectPool() {} // 0x00000001831E17D0-0x00000001831E1870
}


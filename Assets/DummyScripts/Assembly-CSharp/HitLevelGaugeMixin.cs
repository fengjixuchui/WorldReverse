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
public class HitLevelGaugeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17014
{
	// Fields
	private HitLevel _fromHitLevel; // 0x30
	private HitLevel _toHitLevel; // 0x34
	private SimpleSafeFloat maxChargeRawNum; // 0x38
	private SimpleSafeFloat minChargeDeltaRawNum; // 0x3C
	private SimpleSafeFloat maxChargeDeltaRawNum; // 0x40
	private SimpleSafeFloat fadeTimeRawNum; // 0x44

	// Properties
	public HitLevel fromHitLevel { /* [XID] */ /* 0x0000000189756C80-0x0000000189756CA0 */ get => default; /* [XID] */ /* 0x000000018975E150-0x000000018975E170 */ private set {} } // 0x0000000183421D40-0x0000000183421DE0 0x00000001834217D0-0x0000000183421880
	public HitLevel toHitLevel { /* [XID] */ /* 0x00000001897658F0-0x0000000189765910 */ get => default; /* [XID] */ /* 0x000000018976D1A0-0x000000018976D1C0 */ private set {} } // 0x0000000183420290-0x0000000183420330 0x0000000183422170-0x0000000183422220
	public float maxCharge { /* [XID] */ /* 0x00000001897745B0-0x00000001897745D0 */ get => default; /* [XID] */ /* 0x000000018977BFC0-0x000000018977BFE0 */ private set {} } // 0x0000000183421400-0x00000001834214E0 0x000000018341FFF0-0x00000001834200D0
	public float minChargeDelta { /* [XID] */ /* 0x0000000189783890-0x00000001897838B0 */ get => default; /* [XID] */ /* 0x000000018978B0A0-0x000000018978B0C0 */ private set {} } // 0x0000000183420F90-0x0000000183421070 0x0000000183420470-0x0000000183420550
	public float maxChargeDelta { /* [XID] */ /* 0x00000001897925E0-0x0000000189792600 */ get => default; /* [XID] */ /* 0x0000000189799B90-0x0000000189799BB0 */ private set {} } // 0x00000001834201B0-0x0000000183420290 0x0000000183421E40-0x0000000183421F20
	public float fadeTime { /* [XID] */ /* 0x00000001897A1A00-0x00000001897A1A20 */ get => default; /* [XID] */ /* 0x00000001897A9280-0x00000001897A92A0 */ private set {} } // 0x00000001834200D0-0x00000001834201B0 0x0000000183420330-0x0000000183420410
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018982DAC0-0x000000018982DAE0 */ get => default; } // 0x0000000183420B70-0x0000000183420C10 

	// Constructors
	public HitLevelGaugeMixin() {} // 0x0000000183422A00-0x0000000183422AE0

	// Methods
	// [XID] // 0x00000001897B0A60-0x00000001897B0A80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001834227E0-0x0000000183422960
	// [XID] // 0x00000001897B87C0-0x00000001897B87E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183422280-0x0000000183422330
	// [XID] // 0x00000001897C0820-0x00000001897C0840
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF606D */) => default; // 0x0000000183421C60-0x0000000183421D40
	// [XID] // 0x00000001897C80F0-0x00000001897C8110
	public override int GetHashNum() => default; // 0x000000018341FF20-0x000000018341FFF0
	// [XID] // 0x00000001897CF4B0-0x00000001897CF4D0
	public override void InitEmpty() {} // 0x00000001834214E0-0x0000000183421600
	[BlackList] // 0x00000001897D6D40-0x00000001897D6D80
	// [XID] // 0x00000001897D6D40-0x00000001897D6D80
	public override bool FromJson(JSONNode node) => default; // 0x0000000183420C10-0x0000000183420F90
	// [XID] // 0x00000001897E15E0-0x00000001897E1600
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018341F260-0x000000018341F960
	[BlackList] // 0x00000001897E8E90-0x00000001897E8ED0
	// [XID] // 0x00000001897E8E90-0x00000001897E8ED0
	public static new HitLevelGaugeMixin ParseFromJson(JSONNode node) => default; // 0x0000000183421F20-0x0000000183422170
	// [XID] // 0x00000001897F3A50-0x00000001897F3A70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF606E */, bool useObjectPool = false /* Metadata: 0x00AF6072 */) => default; // 0x0000000183421880-0x0000000183421B80
	// [XID] // 0x00000001897FB450-0x00000001897FB470
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6073 */, bool useObjectPool = false /* Metadata: 0x00AF6077 */) => default; // 0x00000001834205D0-0x0000000183420A70
	// [XID] // 0x0000000189802800-0x0000000189802820
	public static new HitLevelGaugeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6078 */, bool useObjectPool = false /* Metadata: 0x00AF607C */) => default; // 0x00000001834210E0-0x0000000183421300
	[BlackList] // 0x0000000189809E90-0x0000000189809ED0
	// [XID] // 0x0000000189809E90-0x0000000189809ED0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018341F960-0x000000018341FC30
	// [XID] // 0x00000001898143B0-0x00000001898143D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183422330-0x00000001834227E0
	[BlackList] // 0x000000018981BEE0-0x000000018981BF20
	// [XID] // 0x000000018981BEE0-0x000000018981BF20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001834216E0-0x00000001834217D0
	// [XID] // 0x0000000189826430-0x0000000189826450
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183421B80-0x0000000183421C60
	[BlackList] // 0x00000001898351B0-0x00000001898351F0
	// [XID] // 0x00000001898351B0-0x00000001898351F0
	public override void AutoAllocTypeFields() {} // 0x000000018341FC30-0x000000018341FCD0
	[BlackList] // 0x000000018983F850-0x000000018983F890
	// [XID] // 0x000000018983F850-0x000000018983F890
	public override void AutoRecycleTypeFields() {} // 0x000000018341FCD0-0x000000018341FE00
	[BlackList] // 0x0000000189849BD0-0x0000000189849C10
	// [XID] // 0x0000000189849BD0-0x0000000189849C10
	public override void ReturnToObjectPool() {} // 0x0000000183422960-0x0000000183422A00
}


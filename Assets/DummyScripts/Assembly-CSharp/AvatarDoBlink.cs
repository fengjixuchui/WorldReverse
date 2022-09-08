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
public class AvatarDoBlink : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16559
{
	// Fields
	private bool _PreferInput; // 0x68
	private SimpleSafeFloat DistanceRawNum; // 0x6C

	// Properties
	public bool PreferInput { /* [XID] */ /* 0x0000000189B76010-0x0000000189B76030 */ get => default; /* [XID] */ /* 0x0000000189B7D520-0x0000000189B7D540 */ private set {} } // 0x0000000184842150-0x00000001848421F0 0x00000001848420A0-0x0000000184842150
	public float Distance { /* [XID] */ /* 0x0000000189B85270-0x0000000189B85290 */ get => default; /* [XID] */ /* 0x0000000189B8C080-0x0000000189B8C0A0 */ private set {} } // 0x0000000184843390-0x0000000184843470 0x0000000184842E30-0x0000000184842F10
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018961C480-0x000000018961C4A0 */ get => default; } // 0x0000000184844140-0x00000001848441E0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189623820-0x0000000189623840 */ get => default; } // 0x0000000184843770-0x0000000184843810 

	// Constructors
	public AvatarDoBlink() {} // 0x00000001848448B0-0x0000000184844920

	// Methods
	// [XID] // 0x0000000189B93890-0x0000000189B938B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184844660-0x0000000184844770
	// [XID] // 0x0000000189B9ADC0-0x0000000189B9ADE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184844240-0x00000001848442F0
	// [XID] // 0x0000000189BA2670-0x0000000189BA2690
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3F2E */) => default; // 0x0000000184843DB0-0x0000000184843E90
	// [XID] // 0x0000000189BA9AC0-0x0000000189BA9AE0
	public override int GetHashNum() => default; // 0x00000001848427D0-0x00000001848428A0
	// [XID] // 0x0000000189BB1330-0x0000000189BB1350
	public override void InitEmpty() {} // 0x0000000184843810-0x00000001848438E0
	[BlackList] // 0x0000000189BB83E0-0x0000000189BB8420
	// [XID] // 0x0000000189BB83E0-0x0000000189BB8420
	public override bool FromJson(JSONNode node) => default; // 0x0000000184843010-0x0000000184843390
	// [XID] // 0x0000000189BC3350-0x0000000189BC3370
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184841D60-0x00000001848420A0
	[BlackList] // 0x0000000189BCABB0-0x0000000189BCABF0
	// [XID] // 0x0000000189BCABB0-0x0000000189BCABF0
	public static new AvatarDoBlink ParseFromJson(JSONNode node) => default; // 0x0000000184843EF0-0x0000000184844140
	// [XID] // 0x0000000189BD50B0-0x0000000189BD50D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F2F */, bool useObjectPool = false /* Metadata: 0x00AF3F33 */) => default; // 0x0000000184843AB0-0x0000000184843DB0
	// [XID] // 0x0000000189BDCBE0-0x0000000189BDCC00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F34 */, bool useObjectPool = false /* Metadata: 0x00AF3F38 */) => default; // 0x00000001848429F0-0x0000000184842CD0
	// [XID] // 0x00000001895E9390-0x00000001895E93B0
	public static new AvatarDoBlink ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F39 */, bool useObjectPool = false /* Metadata: 0x00AF3F3D */) => default; // 0x0000000184843470-0x0000000184843690
	[BlackList] // 0x00000001895F0B60-0x00000001895F0BA0
	// [XID] // 0x00000001895F0B60-0x00000001895F0BA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001848421F0-0x00000001848424C0
	// [XID] // 0x00000001895FB410-0x00000001895FB430
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001848443D0-0x0000000184844660
	[BlackList] // 0x0000000189602B90-0x0000000189602BD0
	// [XID] // 0x0000000189602B90-0x0000000189602BD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001848439C0-0x0000000184843AB0
	// [XID] // 0x000000018960D4C0-0x000000018960D4E0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184844770-0x0000000184844810
	// [XID] // 0x0000000189614B80-0x0000000189614BA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184842CD0-0x0000000184842E30
	[BlackList] // 0x000000018962B140-0x000000018962B180
	// [XID] // 0x000000018962B140-0x000000018962B180
	public override void AutoAllocTypeFields() {} // 0x00000001848424C0-0x0000000184842560
	[BlackList] // 0x0000000189635D70-0x0000000189635DB0
	// [XID] // 0x0000000189635D70-0x0000000189635DB0
	public override void AutoRecycleTypeFields() {} // 0x0000000184842560-0x0000000184842640
	[BlackList] // 0x0000000189640150-0x0000000189640190
	// [XID] // 0x0000000189640150-0x0000000189640190
	public override void ReturnToObjectPool() {} // 0x0000000184844810-0x00000001848448B0
}


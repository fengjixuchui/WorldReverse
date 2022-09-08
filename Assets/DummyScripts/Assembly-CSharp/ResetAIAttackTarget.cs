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
public class ResetAIAttackTarget : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16703
{
	// Properties
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018965F740-0x000000018965F760 */ get => default; } // 0x0000000181C010E0-0x0000000181C01180 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189667190-0x00000001896671B0 */ get => default; } // 0x0000000181C00730-0x0000000181C007D0 

	// Constructors
	public ResetAIAttackTarget() {} // 0x0000000181C01650-0x0000000181C016B0

	// Methods
	// [XID] // 0x0000000189BD6660-0x0000000189BD6680
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C01460-0x0000000181C01510
	// [XID] // 0x0000000189BDE2E0-0x0000000189BDE300
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181C011E0-0x0000000181C01290
	// [XID] // 0x00000001895EAE30-0x00000001895EAE50
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF439E */) => default; // 0x0000000181C00D50-0x0000000181C00E30
	// [XID] // 0x00000001895F2290-0x00000001895F22B0
	public override int GetHashNum() => default; // 0x0000000181BFFB00-0x0000000181BFFBD0
	// [XID] // 0x00000001895F9C80-0x00000001895F9CA0
	public override void InitEmpty() {} // 0x0000000181C007D0-0x0000000181C00870
	[BlackList] // 0x0000000189601460-0x00000001896014A0
	// [XID] // 0x0000000189601460-0x00000001896014A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181C000B0-0x0000000181C00430
	// [XID] // 0x000000018960BCC0-0x000000018960BCE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181BFF470-0x0000000181BFF560
	[BlackList] // 0x00000001896132C0-0x0000000189613300
	// [XID] // 0x00000001896132C0-0x0000000189613300
	public static new ResetAIAttackTarget ParseFromJson(JSONNode node) => default; // 0x0000000181C00E90-0x0000000181C010E0
	// [XID] // 0x000000018961DA90-0x000000018961DAB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF439F */, bool useObjectPool = false /* Metadata: 0x00AF43A3 */) => default; // 0x0000000181C00A50-0x0000000181C00D50
	// [XID] // 0x0000000189624F30-0x0000000189624F50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43A4 */, bool useObjectPool = false /* Metadata: 0x00AF43A8 */) => default; // 0x0000000181BFFD20-0x0000000181BFFE50
	// [XID] // 0x000000018962C770-0x000000018962C790
	public static new ResetAIAttackTarget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43A9 */, bool useObjectPool = false /* Metadata: 0x00AF43AD */) => default; // 0x0000000181C00430-0x0000000181C00650
	[BlackList] // 0x0000000189634430-0x0000000189634470
	// [XID] // 0x0000000189634430-0x0000000189634470
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181BFF560-0x0000000181BFF830
	// [XID] // 0x000000018963EA60-0x000000018963EA80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C01370-0x0000000181C01460
	[BlackList] // 0x00000001896461A0-0x00000001896461E0
	// [XID] // 0x00000001896461A0-0x00000001896461E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181C00950-0x0000000181C00A50
	// [XID] // 0x0000000189650950-0x0000000189650970
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181C01510-0x0000000181C015B0
	// [XID] // 0x00000001896581F0-0x0000000189658210
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181BFFE50-0x0000000181BFFFB0
	[BlackList] // 0x000000018966E940-0x000000018966E980
	// [XID] // 0x000000018966E940-0x000000018966E980
	public override void AutoAllocTypeFields() {} // 0x0000000181BFF830-0x0000000181BFF8D0
	[BlackList] // 0x0000000189679730-0x0000000189679770
	// [XID] // 0x0000000189679730-0x0000000189679770
	public override void AutoRecycleTypeFields() {} // 0x0000000181BFF8D0-0x0000000181BFF970
	[BlackList] // 0x0000000189683B90-0x0000000189683BD0
	// [XID] // 0x0000000189683B90-0x0000000189683BD0
	public override void ReturnToObjectPool() {} // 0x0000000181C015B0-0x0000000181C01650
}


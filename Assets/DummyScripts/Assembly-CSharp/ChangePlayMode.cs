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
public class ChangePlayMode : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16693
{
	// Fields
	private PlayModeType _toPlayMode; // 0x68

	// Properties
	public PlayModeType toPlayMode { /* [XID] */ /* 0x00000001897B8880-0x00000001897B88A0 */ get => default; /* [XID] */ /* 0x00000001897C0900-0x00000001897C0920 */ private set {} } // 0x00000001832E0F20-0x00000001832E0FC0 0x00000001832E0580-0x00000001832E0630
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018984B590-0x000000018984B5B0 */ get => default; } // 0x00000001832E1C70-0x00000001832E1D10 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898526A0-0x00000001898526C0 */ get => default; } // 0x00000001832E12C0-0x00000001832E1360 

	// Constructors
	public ChangePlayMode() {} // 0x00000001832E2330-0x00000001832E2390

	// Methods
	// [XID] // 0x00000001897C8290-0x00000001897C82B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832E2100-0x00000001832E21F0
	// [XID] // 0x00000001897CF5F0-0x00000001897CF610
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001832E1D70-0x00000001832E1E20
	// [XID] // 0x00000001897D6E80-0x00000001897D6EA0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF434E */) => default; // 0x00000001832E18E0-0x00000001832E19C0
	// [XID] // 0x00000001897DE510-0x00000001897DE530
	public override int GetHashNum() => default; // 0x00000001832E0440-0x00000001832E0510
	// [XID] // 0x00000001897E5FF0-0x00000001897E6010
	public override void InitEmpty() {} // 0x00000001832E1360-0x00000001832E1400
	[BlackList] // 0x00000001897ED9B0-0x00000001897ED9F0
	// [XID] // 0x00000001897ED9B0-0x00000001897ED9F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001832E0BA0-0x00000001832E0F20
	// [XID] // 0x00000001897F8300-0x00000001897F8320
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001832DFC70-0x00000001832DFE90
	[BlackList] // 0x00000001897FFA30-0x00000001897FFA70
	// [XID] // 0x00000001897FFA30-0x00000001897FFA70
	public static new ChangePlayMode ParseFromJson(JSONNode node) => default; // 0x00000001832E1A20-0x00000001832E1C70
	// [XID] // 0x0000000189809FF0-0x000000018980A010
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF434F */, bool useObjectPool = false /* Metadata: 0x00AF4353 */) => default; // 0x00000001832E15E0-0x00000001832E18E0
	// [XID] // 0x0000000189811680-0x00000001898116A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4354 */, bool useObjectPool = false /* Metadata: 0x00AF4358 */) => default; // 0x00000001832E0710-0x00000001832E0940
	// [XID] // 0x00000001898191F0-0x0000000189819210
	public static new ChangePlayMode ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4359 */, bool useObjectPool = false /* Metadata: 0x00AF435D */) => default; // 0x00000001832E0FC0-0x00000001832E11E0
	[BlackList] // 0x00000001898209F0-0x0000000189820A30
	// [XID] // 0x00000001898209F0-0x0000000189820A30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001832DFE90-0x00000001832E0160
	// [XID] // 0x000000018982AE50-0x000000018982AE70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832E1F00-0x00000001832E2100
	[BlackList] // 0x0000000189832310-0x0000000189832350
	// [XID] // 0x0000000189832310-0x0000000189832350
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001832E14E0-0x00000001832E15E0
	// [XID] // 0x000000018983CA10-0x000000018983CA30
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001832E21F0-0x00000001832E2290
	// [XID] // 0x0000000189844140-0x0000000189844160
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001832E0940-0x00000001832E0AA0
	[BlackList] // 0x000000018985A110-0x000000018985A150
	// [XID] // 0x000000018985A110-0x000000018985A150
	public override void AutoAllocTypeFields() {} // 0x00000001832E0160-0x00000001832E0200
	[BlackList] // 0x0000000189864510-0x0000000189864550
	// [XID] // 0x0000000189864510-0x0000000189864550
	public override void AutoRecycleTypeFields() {} // 0x00000001832E0200-0x00000001832E02B0
	[BlackList] // 0x000000018986E990-0x000000018986E9D0
	// [XID] // 0x000000018986E990-0x000000018986E9D0
	public override void ReturnToObjectPool() {} // 0x00000001832E2290-0x00000001832E2330
}


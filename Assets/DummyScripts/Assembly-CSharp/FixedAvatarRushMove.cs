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
public class FixedAvatarRushMove : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16757
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _toPos; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _timeRange; // 0x70
	private SimpleSafeFloat maxRangeRawNum; // 0x78
	private string[] _animatorStateIDs; // 0x80
	private string _overrideMoveCollider; // 0x88
	private bool _isInAir; // 0x90
	private bool _checkAnimatorStateOnExitOnly; // 0x91

	// Properties
	public ConfigBornType toPos { /* [XID] */ /* 0x0000000189A7A6F0-0x0000000189A7A710 */ get => default; /* [XID] */ /* 0x0000000189A81C70-0x0000000189A81C90 */ private set {} } // 0x0000000183998820-0x00000001839988C0 0x0000000183997180-0x0000000183997230
	public DynamicFloat timeRange { /* [XID] */ /* 0x0000000189A89710-0x0000000189A89730 */ get => default; /* [XID] */ /* 0x0000000189A90E90-0x0000000189A90EB0 */ private set {} } // 0x0000000183998550-0x00000001839985F0 0x0000000183996800-0x00000001839968B0
	public float maxRange { /* [XID] */ /* 0x0000000189A986E0-0x0000000189A98700 */ get => default; /* [XID] */ /* 0x0000000189A9FAF0-0x0000000189A9FB10 */ private set {} } // 0x00000001839965A0-0x0000000183996680 0x0000000183997900-0x00000001839979E0
	public string[] animatorStateIDs { /* [XID] */ /* 0x0000000189AA72E0-0x0000000189AA7300 */ get => default; /* [XID] */ /* 0x0000000189AAE9E0-0x0000000189AAEA00 */ private set {} } // 0x0000000183999010-0x00000001839990C0 0x00000001839970D0-0x0000000183997180
	public string overrideMoveCollider { /* [XID] */ /* 0x0000000189AB62E0-0x0000000189AB6300 */ get => default; /* [XID] */ /* 0x0000000189ABDD50-0x0000000189ABDD70 */ private set {} } // 0x0000000183997AF0-0x0000000183997BA0 0x0000000183996680-0x0000000183996730
	public bool isInAir { /* [XID] */ /* 0x0000000189AC58D0-0x0000000189AC58F0 */ get => default; /* [XID] */ /* 0x0000000189ACCE20-0x0000000189ACCE40 */ private set {} } // 0x0000000183999340-0x00000001839993F0 0x0000000183999290-0x0000000183999340
	public bool checkAnimatorStateOnExitOnly { /* [XID] */ /* 0x0000000189AD4A80-0x0000000189AD4AA0 */ get => default; /* [XID] */ /* 0x0000000189ADC3E0-0x0000000189ADC400 */ private set {} } // 0x00000001839988C0-0x0000000183998970 0x0000000183997850-0x0000000183997900
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B5FE20-0x0000000189B5FE40 */ get => default; } // 0x00000001839985F0-0x0000000183998690 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B674C0-0x0000000189B674E0 */ get => default; } // 0x0000000183997A50-0x0000000183997AF0 

	// Constructors
	public FixedAvatarRushMove() {} // 0x0000000183999490-0x0000000183999560

	// Methods
	// [XID] // 0x0000000189AE3DD0-0x0000000189AE3DF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839990C0-0x0000000183999290
	// [XID] // 0x0000000189AEB630-0x0000000189AEB650
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001839986F0-0x0000000183998820
	// [XID] // 0x0000000189AF2FB0-0x0000000189AF2FD0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF454E */) => default; // 0x00000001839981C0-0x00000001839982A0
	// [XID] // 0x0000000189AFA880-0x0000000189AFA8A0
	public override int GetHashNum() => default; // 0x00000001839964D0-0x00000001839965A0
	// [XID] // 0x0000000189B01E50-0x0000000189B01E70
	public override void InitEmpty() {} // 0x0000000183997BA0-0x0000000183997CE0
	[BlackList] // 0x0000000189B09390-0x0000000189B093D0
	// [XID] // 0x0000000189B09390-0x0000000189B093D0
	public override bool FromJson(JSONNode node) => default; // 0x00000001839972B0-0x0000000183997630
	// [XID] // 0x0000000189B13990-0x0000000189B139B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001839956D0-0x0000000183995DF0
	[BlackList] // 0x0000000189B1AFA0-0x0000000189B1AFE0
	// [XID] // 0x0000000189B1AFA0-0x0000000189B1AFE0
	public static new FixedAvatarRushMove ParseFromJson(JSONNode node) => default; // 0x0000000183998300-0x0000000183998550
	// [XID] // 0x0000000189B255E0-0x0000000189B25600
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF454F */, bool useObjectPool = false /* Metadata: 0x00AF4553 */) => default; // 0x0000000183997EC0-0x00000001839981C0
	// [XID] // 0x0000000189B2CB50-0x0000000189B2CB70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4554 */, bool useObjectPool = false /* Metadata: 0x00AF4558 */) => default; // 0x0000000183996930-0x0000000183996EF0
	// [XID] // 0x0000000189B34000-0x0000000189B34020
	public static new FixedAvatarRushMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4559 */, bool useObjectPool = false /* Metadata: 0x00AF455D */) => default; // 0x0000000183997630-0x0000000183997850
	[BlackList] // 0x0000000189B3B8D0-0x0000000189B3B910
	// [XID] // 0x0000000189B3B8D0-0x0000000189B3B910
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183995DF0-0x00000001839960C0
	// [XID] // 0x0000000189B463E0-0x0000000189B46400
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183998A50-0x0000000183999010
	[BlackList] // 0x0000000189B4D960-0x0000000189B4D9A0
	// [XID] // 0x0000000189B4D960-0x0000000189B4D9A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183997DC0-0x0000000183997EC0
	// [XID] // 0x0000000189B58490-0x0000000189B584B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183996EF0-0x0000000183997050
	[BlackList] // 0x0000000189B6E740-0x0000000189B6E780
	// [XID] // 0x0000000189B6E740-0x0000000189B6E780
	public override void AutoAllocTypeFields() {} // 0x00000001839960C0-0x0000000183996160
	[BlackList] // 0x0000000189B78E00-0x0000000189B78E40
	// [XID] // 0x0000000189B78E00-0x0000000189B78E40
	public override void AutoRecycleTypeFields() {} // 0x0000000183996160-0x0000000183996340
	[BlackList] // 0x0000000189B83660-0x0000000189B836A0
	// [XID] // 0x0000000189B83660-0x0000000189B836A0
	public override void ReturnToObjectPool() {} // 0x00000001839993F0-0x0000000183999490
}


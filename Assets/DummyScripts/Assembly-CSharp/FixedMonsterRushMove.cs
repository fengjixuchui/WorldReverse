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
public class FixedMonsterRushMove : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16755
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
	public ConfigBornType toPos { /* [XID] */ /* 0x0000000189950650-0x0000000189950670 */ get => default; /* [XID] */ /* 0x0000000189957B80-0x0000000189957BA0 */ private set {} } // 0x0000000182F8A790-0x0000000182F8A830 0x0000000182F890F0-0x0000000182F891A0
	public DynamicFloat timeRange { /* [XID] */ /* 0x000000018995F3F0-0x000000018995F410 */ get => default; /* [XID] */ /* 0x0000000189966D10-0x0000000189966D30 */ private set {} } // 0x0000000182F8A4C0-0x0000000182F8A560 0x0000000182F88770-0x0000000182F88820
	public float maxRange { /* [XID] */ /* 0x000000018996E000-0x000000018996E020 */ get => default; /* [XID] */ /* 0x0000000189975C10-0x0000000189975C30 */ private set {} } // 0x0000000182F88510-0x0000000182F885F0 0x0000000182F89870-0x0000000182F89950
	public string[] animatorStateIDs { /* [XID] */ /* 0x000000018997CC50-0x000000018997CC70 */ get => default; /* [XID] */ /* 0x00000001899849F0-0x0000000189984A10 */ private set {} } // 0x0000000182F8AF80-0x0000000182F8B030 0x0000000182F89040-0x0000000182F890F0
	public string overrideMoveCollider { /* [XID] */ /* 0x000000018998C570-0x000000018998C590 */ get => default; /* [XID] */ /* 0x0000000189994290-0x00000001899942B0 */ private set {} } // 0x0000000182F89A60-0x0000000182F89B10 0x0000000182F885F0-0x0000000182F886A0
	public bool isInAir { /* [XID] */ /* 0x000000018999BAC0-0x000000018999BAE0 */ get => default; /* [XID] */ /* 0x00000001899A3290-0x00000001899A32B0 */ private set {} } // 0x0000000182F8B2B0-0x0000000182F8B360 0x0000000182F8B200-0x0000000182F8B2B0
	public bool checkAnimatorStateOnExitOnly { /* [XID] */ /* 0x00000001899AAD20-0x00000001899AAD40 */ get => default; /* [XID] */ /* 0x00000001899B2810-0x00000001899B2830 */ private set {} } // 0x0000000182F8A830-0x0000000182F8A8E0 0x0000000182F897C0-0x0000000182F89870
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A352F0-0x0000000189A35310 */ get => default; } // 0x0000000182F8A560-0x0000000182F8A600 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A3C8C0-0x0000000189A3C8E0 */ get => default; } // 0x0000000182F899C0-0x0000000182F89A60 

	// Constructors
	public FixedMonsterRushMove() {} // 0x0000000182F8B400-0x0000000182F8B4D0

	// Methods
	// [XID] // 0x00000001899B9A70-0x00000001899B9A90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182F8B030-0x0000000182F8B200
	// [XID] // 0x00000001899C15B0-0x00000001899C15D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182F8A660-0x0000000182F8A790
	// [XID] // 0x00000001899C8B20-0x00000001899C8B40
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF453E */) => default; // 0x0000000182F8A130-0x0000000182F8A210
	// [XID] // 0x00000001899D04B0-0x00000001899D04D0
	public override int GetHashNum() => default; // 0x0000000182F88440-0x0000000182F88510
	// [XID] // 0x00000001899D7950-0x00000001899D7970
	public override void InitEmpty() {} // 0x0000000182F89B10-0x0000000182F89C50
	[BlackList] // 0x00000001899DEDF0-0x00000001899DEE30
	// [XID] // 0x00000001899DEDF0-0x00000001899DEE30
	public override bool FromJson(JSONNode node) => default; // 0x0000000182F89220-0x0000000182F895A0
	// [XID] // 0x00000001899E9780-0x00000001899E97A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182F87640-0x0000000182F87D60
	[BlackList] // 0x00000001899F0E70-0x00000001899F0EB0
	// [XID] // 0x00000001899F0E70-0x00000001899F0EB0
	public static new FixedMonsterRushMove ParseFromJson(JSONNode node) => default; // 0x0000000182F8A270-0x0000000182F8A4C0
	// [XID] // 0x00000001899FBA50-0x00000001899FBA70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF453F */, bool useObjectPool = false /* Metadata: 0x00AF4543 */) => default; // 0x0000000182F89E30-0x0000000182F8A130
	// [XID] // 0x0000000189A02E30-0x0000000189A02E50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4544 */, bool useObjectPool = false /* Metadata: 0x00AF4548 */) => default; // 0x0000000182F888A0-0x0000000182F88E60
	// [XID] // 0x0000000189A0A480-0x0000000189A0A4A0
	public static new FixedMonsterRushMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4549 */, bool useObjectPool = false /* Metadata: 0x00AF454D */) => default; // 0x0000000182F895A0-0x0000000182F897C0
	[BlackList] // 0x0000000189A11D40-0x0000000189A11D80
	// [XID] // 0x0000000189A11D40-0x0000000189A11D80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182F87D60-0x0000000182F88030
	// [XID] // 0x0000000189A1BE70-0x0000000189A1BE90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182F8A9C0-0x0000000182F8AF80
	[BlackList] // 0x0000000189A236A0-0x0000000189A236E0
	// [XID] // 0x0000000189A236A0-0x0000000189A236E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182F89D30-0x0000000182F89E30
	// [XID] // 0x0000000189A2D790-0x0000000189A2D7B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182F88E60-0x0000000182F88FC0
	[BlackList] // 0x0000000189A44310-0x0000000189A44350
	// [XID] // 0x0000000189A44310-0x0000000189A44350
	public override void AutoAllocTypeFields() {} // 0x0000000182F88030-0x0000000182F880D0
	[BlackList] // 0x0000000189A4EA30-0x0000000189A4EA70
	// [XID] // 0x0000000189A4EA30-0x0000000189A4EA70
	public override void AutoRecycleTypeFields() {} // 0x0000000182F880D0-0x0000000182F882B0
	[BlackList] // 0x0000000189A59060-0x0000000189A590A0
	// [XID] // 0x0000000189A59060-0x0000000189A590A0
	public override void ReturnToObjectPool() {} // 0x0000000182F8B360-0x0000000182F8B400
}


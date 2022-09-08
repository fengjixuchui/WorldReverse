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
public class TriggerBullet : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16488
{
	// Fields
	private SimpleSafeUInt32 bulletIDRawNum; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	private bool _ownerIsTarget; // 0x78
	private AbilityTargetting _ownerIs; // 0x7C
	private AbilityTargetting _propOwnerIs; // 0x80
	private bool _lifeByOwnerIsAlive; // 0x84
	private AbilityTargetting _trackTarget; // 0x88
	private bool _sightGroupWithOwner; // 0x8C

	// Properties
	public uint bulletID { /* [XID] */ /* 0x0000000189B65B80-0x0000000189B65BA0 */ get => default; /* [XID] */ /* 0x0000000189B6D0C0-0x0000000189B6D0E0 */ private set {} } // 0x000000018298E330-0x000000018298E400 0x000000018298EE70-0x000000018298EF50
	public ConfigBornType born { /* [XID] */ /* 0x0000000189B74790-0x0000000189B747B0 */ get => default; /* [XID] */ /* 0x0000000189B7BE10-0x0000000189B7BE30 */ private set {} } // 0x000000018298F000-0x000000018298F0A0 0x00000001829918D0-0x0000000182991980
	public bool ownerIsTarget { /* [XID] */ /* 0x0000000189B83740-0x0000000189B83760 */ get => default; /* [XID] */ /* 0x0000000189B8AB10-0x0000000189B8AB30 */ private set {} } // 0x000000018298FF40-0x000000018298FFE0 0x000000018298E6D0-0x000000018298E780
	public AbilityTargetting ownerIs { /* [XID] */ /* 0x0000000189B92140-0x0000000189B92160 */ get => default; /* [XID] */ /* 0x0000000189B99680-0x0000000189B996A0 */ private set {} } // 0x000000018298ED60-0x000000018298EE00 0x0000000182990420-0x00000001829904D0
	public AbilityTargetting propOwnerIs { /* [XID] */ /* 0x0000000189BA0C10-0x0000000189BA0C30 */ get => default; /* [XID] */ /* 0x0000000189BA8270-0x0000000189BA8290 */ private set {} } // 0x000000018298EB40-0x000000018298EBE0 0x000000018298F9E0-0x000000018298FA90
	public bool lifeByOwnerIsAlive { /* [XID] */ /* 0x0000000189BAF740-0x0000000189BAF760 */ get => default; /* [XID] */ /* 0x0000000189BB6DB0-0x0000000189BB6DD0 */ private set {} } // 0x000000018298DA90-0x000000018298DB40 0x000000018298FA90-0x000000018298FB40
	public AbilityTargetting trackTarget { /* [XID] */ /* 0x0000000189BBE390-0x0000000189BBE3B0 */ get => default; /* [XID] */ /* 0x0000000189BC6080-0x0000000189BC60A0 */ private set {} } // 0x0000000182990200-0x00000001829902A0 0x000000018298ECB0-0x000000018298ED60
	public bool sightGroupWithOwner { /* [XID] */ /* 0x0000000189BCDBE0-0x0000000189BCDC00 */ get => default; /* [XID] */ /* 0x0000000189BD50F0-0x0000000189BD5110 */ private set {} } // 0x000000018298F930-0x000000018298F9E0 0x000000018298EF50-0x000000018298F000
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189665750-0x0000000189665770 */ get => default; } // 0x0000000182990E40-0x0000000182990EE0 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018966CE80-0x000000018966CEA0 */ get => default; } // 0x0000000182990380-0x0000000182990420 

	// Constructors
	public TriggerBullet() {} // 0x0000000182991AC0-0x0000000182991B40

	// Methods
	// [XID] // 0x0000000189BDCC20-0x0000000189BDCC40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182991710-0x00000001829918D0
	// [XID] // 0x00000001895E93D0-0x00000001895E93F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182990F40-0x0000000182991020
	// [XID] // 0x00000001895F0BE0-0x00000001895F0C00
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3D00 */) => default; // 0x0000000182990AB0-0x0000000182990B90
	// [XID] // 0x00000001895F85B0-0x00000001895F85D0
	public override int GetHashNum() => default; // 0x000000018298EBE0-0x000000018298ECB0
	// [XID] // 0x00000001895FFA70-0x00000001895FFA90
	public override void InitEmpty() {} // 0x00000001829904D0-0x00000001829905E0
	[BlackList] // 0x0000000189607200-0x0000000189607240
	// [XID] // 0x0000000189607200-0x0000000189607240
	public override bool FromJson(JSONNode node) => default; // 0x000000018298FBC0-0x000000018298FF40
	// [XID] // 0x0000000189611C80-0x0000000189611CA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018298DB40-0x000000018298E330
	[BlackList] // 0x0000000189619540-0x0000000189619580
	// [XID] // 0x0000000189619540-0x0000000189619580
	public static new TriggerBullet ParseFromJson(JSONNode node) => default; // 0x0000000182990BF0-0x0000000182990E40
	// [XID] // 0x00000001896238A0-0x00000001896238C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D01 */, bool useObjectPool = false /* Metadata: 0x00AF3D05 */) => default; // 0x00000001829907B0-0x0000000182990AB0
	// [XID] // 0x000000018962B1A0-0x000000018962B1C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D06 */, bool useObjectPool = false /* Metadata: 0x00AF3D0A */) => default; // 0x000000018298F180-0x000000018298F750
	// [XID] // 0x0000000189632940-0x0000000189632960
	public static new TriggerBullet ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D0B */, bool useObjectPool = false /* Metadata: 0x00AF3D0F */) => default; // 0x000000018298FFE0-0x0000000182990200
	[BlackList] // 0x000000018963A410-0x000000018963A450
	// [XID] // 0x000000018963A410-0x000000018963A450
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018298E400-0x000000018298E6D0
	// [XID] // 0x0000000189644AD0-0x0000000189644AF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182991100-0x0000000182991710
	[BlackList] // 0x000000018964C2F0-0x000000018964C330
	// [XID] // 0x000000018964C2F0-0x000000018964C330
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829906C0-0x00000001829907B0
	// [XID] // 0x0000000189656930-0x0000000189656950
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182991980-0x0000000182991A20
	// [XID] // 0x000000018965E010-0x000000018965E030
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018298F750-0x000000018298F8B0
	[BlackList] // 0x0000000189674CB0-0x0000000189674CF0
	// [XID] // 0x0000000189674CB0-0x0000000189674CF0
	public override void AutoAllocTypeFields() {} // 0x000000018298E780-0x000000018298E820
	[BlackList] // 0x000000018967F380-0x000000018967F3C0
	// [XID] // 0x000000018967F380-0x000000018967F3C0
	public override void AutoRecycleTypeFields() {} // 0x000000018298E820-0x000000018298E9B0
	[BlackList] // 0x0000000189689EB0-0x0000000189689EF0
	// [XID] // 0x0000000189689EB0-0x0000000189689EF0
	public override void ReturnToObjectPool() {} // 0x0000000182991A20-0x0000000182991AC0
}


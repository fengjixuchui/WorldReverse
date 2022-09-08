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
public class ReviveDeadAvatar : ReviveAvatar, IAutoAllocRecycle // TypeDefIndex: 16450
{
	// Fields
	private bool _isReviveOtherPlayerAvatar; // 0xA0
	private SimpleSafeUInt32 skillIDRawNum; // 0xA4
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _cdRatio; // 0xA8
	private SimpleSafeFloat rangeRawNum; // 0xB0

	// Properties
	public bool isReviveOtherPlayerAvatar { /* [XID] */ /* 0x000000018975FD10-0x000000018975FD30 */ get => default; /* [XID] */ /* 0x0000000189767380-0x00000001897673A0 */ private set {} } // 0x00000001850C7BE0-0x00000001850C7C90 0x00000001850C5F70-0x00000001850C6020
	public uint skillID { /* [XID] */ /* 0x000000018976E920-0x000000018976E940 */ get => default; /* [XID] */ /* 0x00000001897762E0-0x0000000189776300 */ private set {} } // 0x00000001850C7920-0x00000001850C79F0 0x00000001850C8BF0-0x00000001850C8CD0
	public DynamicFloat cdRatio { /* [XID] */ /* 0x000000018977DA00-0x000000018977DA20 */ get => default; /* [XID] */ /* 0x00000001897851A0-0x00000001897851C0 */ private set {} } // 0x00000001850C6920-0x00000001850C69D0 0x00000001850C8170-0x00000001850C8220
	public float range { /* [XID] */ /* 0x000000018978C6F0-0x000000018978C710 */ get => default; /* [XID] */ /* 0x0000000189793BA0-0x0000000189793BC0 */ private set {} } // 0x00000001850C6540-0x00000001850C6620 0x00000001850C6AA0-0x00000001850C6B80
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189820A90-0x0000000189820AB0 */ get => default; } // 0x00000001850C84D0-0x00000001850C8570 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189827FE0-0x0000000189828000 */ get => default; } // 0x00000001850C7880-0x00000001850C7920 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x000000018982F260-0x000000018982F280 */ get => default; } // 0x00000001850C6880-0x00000001850C6920 

	// Constructors
	public ReviveDeadAvatar() {} // 0x00000001850C8F70-0x00000001850C9080

	// Methods
	// [XID] // 0x000000018979BF10-0x000000018979BF30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001850C8CD0-0x00000001850C8E30
	// [XID] // 0x00000001897A3380-0x00000001897A33A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001850C8640-0x00000001850C8720
	// [XID] // 0x00000001897AA900-0x00000001897AA920
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3BCA */) => default; // 0x00000001850C8090-0x00000001850C8170
	// [XID] // 0x00000001897B24D0-0x00000001897B24F0
	public override int GetHashNum() => default; // 0x00000001850C67B0-0x00000001850C6880
	// [XID] // 0x00000001897B9DF0-0x00000001897B9E10
	public override void InitEmpty() {} // 0x00000001850C79F0-0x00000001850C7B00
	[BlackList] // 0x00000001897C1EB0-0x00000001897C1EF0
	// [XID] // 0x00000001897C1EB0-0x00000001897C1EF0
	public override bool FromJson(JSONNode node) => default; // 0x00000001850C7200-0x00000001850C7580
	// [XID] // 0x00000001897CC570-0x00000001897CC590
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001850C5A90-0x00000001850C5F70
	[BlackList] // 0x00000001897D3E60-0x00000001897D3EA0
	// [XID] // 0x00000001897D3E60-0x00000001897D3EA0
	public static new ReviveDeadAvatar ParseFromJson(JSONNode node) => default; // 0x00000001850C8280-0x00000001850C84D0
	// [XID] // 0x00000001897DE570-0x00000001897DE590
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BCB */, bool useObjectPool = false /* Metadata: 0x00AF3BCF */) => default; // 0x00000001850C7D90-0x00000001850C8090
	// [XID] // 0x00000001897E6090-0x00000001897E60B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BD0 */, bool useObjectPool = false /* Metadata: 0x00AF3BD4 */) => default; // 0x00000001850C6C00-0x00000001850C6FE0
	// [XID] // 0x00000001897EDA30-0x00000001897EDA50
	public static new ReviveDeadAvatar ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BD5 */, bool useObjectPool = false /* Metadata: 0x00AF3BD9 */) => default; // 0x00000001850C7580-0x00000001850C77A0
	[BlackList] // 0x00000001897F5150-0x00000001897F5190
	// [XID] // 0x00000001897F5150-0x00000001897F5190
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001850C6020-0x00000001850C62F0
	// [XID] // 0x00000001897FFAB0-0x00000001897FFAD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001850C8800-0x00000001850C8BF0
	[BlackList] // 0x0000000189807150-0x0000000189807190
	// [XID] // 0x0000000189807150-0x0000000189807190
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001850C7C90-0x00000001850C7D90
	// [XID] // 0x00000001898116E0-0x0000000189811700
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001850C8E30-0x00000001850C8ED0
	// [XID] // 0x0000000189819250-0x0000000189819270
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001850C6FE0-0x00000001850C7100
	[BlackList] // 0x0000000189836B10-0x0000000189836B50
	// [XID] // 0x0000000189836B10-0x0000000189836B50
	public override void AutoAllocTypeFields() {} // 0x00000001850C62F0-0x00000001850C6390
	[BlackList] // 0x0000000189840E60-0x0000000189840EA0
	// [XID] // 0x0000000189840E60-0x0000000189840EA0
	public override void AutoRecycleTypeFields() {} // 0x00000001850C6390-0x00000001850C6540
	[BlackList] // 0x000000018984B5B0-0x000000018984B5F0
	// [XID] // 0x000000018984B5B0-0x000000018984B5F0
	public override void ReturnToObjectPool() {} // 0x00000001850C8ED0-0x00000001850C8F70
}


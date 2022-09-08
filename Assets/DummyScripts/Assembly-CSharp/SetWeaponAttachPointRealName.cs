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
public class SetWeaponAttachPointRealName : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16687
{
	// Fields
	private string _partName; // 0x68
	private string _realName; // 0x70

	// Properties
	public string partName { /* [XID] */ /* 0x0000000189B4C440-0x0000000189B4C460 */ get => default; /* [XID] */ /* 0x0000000189B53A80-0x0000000189B53AA0 */ private set {} } // 0x00000001816A6240-0x00000001816A62E0 0x00000001816A8330-0x00000001816A83E0
	public string realName { /* [XID] */ /* 0x0000000189B5B3D0-0x0000000189B5B3F0 */ get => default; /* [XID] */ /* 0x0000000189B62800-0x0000000189B62820 */ private set {} } // 0x00000001816A7590-0x00000001816A7630 0x00000001816A7310-0x00000001816A73C0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001895F22B0-0x00000001895F22D0 */ get => default; } // 0x00000001816A7DC0-0x00000001816A7E60 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001895F9CA0-0x00000001895F9CC0 */ get => default; } // 0x00000001816A7270-0x00000001816A7310 

	// Constructors
	public SetWeaponAttachPointRealName() {} // 0x00000001816A8630-0x00000001816A8690

	// Methods
	// [XID] // 0x0000000189B6A370-0x0000000189B6A390
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001816A83E0-0x00000001816A84F0
	// [XID] // 0x0000000189B71AB0-0x0000000189B71AD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001816A7EC0-0x00000001816A7FC0
	// [XID] // 0x0000000189B78E40-0x0000000189B78E60
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF431E */) => default; // 0x00000001816A7A30-0x00000001816A7B10
	// [XID] // 0x0000000189B803D0-0x0000000189B803F0
	public override int GetHashNum() => default; // 0x00000001816A6470-0x00000001816A6540
	// [XID] // 0x0000000189B87EA0-0x0000000189B87EC0
	public override void InitEmpty() {} // 0x00000001816A73C0-0x00000001816A74B0
	[BlackList] // 0x0000000189B8F070-0x0000000189B8F0B0
	// [XID] // 0x0000000189B8F070-0x0000000189B8F0B0
	public override bool FromJson(JSONNode node) => default; // 0x00000001816A6BF0-0x00000001816A6F70
	// [XID] // 0x0000000189B995E0-0x0000000189B99600
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001816A5B10-0x00000001816A5E20
	[BlackList] // 0x0000000189BA0B50-0x0000000189BA0B90
	// [XID] // 0x0000000189BA0B50-0x0000000189BA0B90
	public static new SetWeaponAttachPointRealName ParseFromJson(JSONNode node) => default; // 0x00000001816A7B70-0x00000001816A7DC0
	// [XID] // 0x0000000189BAB180-0x0000000189BAB1A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF431F */, bool useObjectPool = false /* Metadata: 0x00AF4323 */) => default; // 0x00000001816A7730-0x00000001816A7A30
	// [XID] // 0x0000000189BB2750-0x0000000189BB2770
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4324 */, bool useObjectPool = false /* Metadata: 0x00AF4328 */) => default; // 0x00000001816A6690-0x00000001816A6990
	// [XID] // 0x0000000189BB9BC0-0x0000000189BB9BE0
	public static new SetWeaponAttachPointRealName ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4329 */, bool useObjectPool = false /* Metadata: 0x00AF432D */) => default; // 0x00000001816A6F70-0x00000001816A7190
	[BlackList] // 0x0000000189BC1B50-0x0000000189BC1B90
	// [XID] // 0x0000000189BC1B50-0x0000000189BC1B90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001816A5E20-0x00000001816A60F0
	// [XID] // 0x0000000189BCC220-0x0000000189BCC240
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001816A80A0-0x00000001816A8330
	[BlackList] // 0x0000000189BD3870-0x0000000189BD38B0
	// [XID] // 0x0000000189BD3870-0x0000000189BD38B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001816A7630-0x00000001816A7730
	// [XID] // 0x0000000189BDE300-0x0000000189BDE320
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001816A84F0-0x00000001816A8590
	// [XID] // 0x00000001895EAE50-0x00000001895EAE70
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001816A6990-0x00000001816A6AF0
	[BlackList] // 0x00000001896014A0-0x00000001896014E0
	// [XID] // 0x00000001896014A0-0x00000001896014E0
	public override void AutoAllocTypeFields() {} // 0x00000001816A60F0-0x00000001816A6190
	[BlackList] // 0x000000018960BCE0-0x000000018960BD20
	// [XID] // 0x000000018960BCE0-0x000000018960BD20
	public override void AutoRecycleTypeFields() {} // 0x00000001816A6190-0x00000001816A6240
	[BlackList] // 0x0000000189616240-0x0000000189616280
	// [XID] // 0x0000000189616240-0x0000000189616280
	public override void ReturnToObjectPool() {} // 0x00000001816A8590-0x00000001816A8630
}


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
public class DoReviveMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17010
{
	// Fields
	private AvatarStageType _type; // 0x30
	private bool _ignoreDieAbyss; // 0x34
	private bool _ignoreDieDrawn; // 0x35
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onKillActions; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onReviveActions; // 0x40

	// Properties
	public AvatarStageType type { /* [XID] */ /* 0x0000000189B61230-0x0000000189B61250 */ get => default; /* [XID] */ /* 0x0000000189B68B00-0x0000000189B68B20 */ private set {} } // 0x0000000183AA84B0-0x0000000183AA8550 0x0000000183AA7E30-0x0000000183AA7EE0
	public bool ignoreDieAbyss { /* [XID] */ /* 0x0000000189B70100-0x0000000189B70120 */ get => default; /* [XID] */ /* 0x0000000189B774D0-0x0000000189B774F0 */ private set {} } // 0x0000000183AA6560-0x0000000183AA6600 0x0000000183AA6F90-0x0000000183AA7040
	public bool ignoreDieDrawn { /* [XID] */ /* 0x0000000189B7EAC0-0x0000000189B7EAE0 */ get => default; /* [XID] */ /* 0x0000000189B86740-0x0000000189B86760 */ private set {} } // 0x0000000183AA70B0-0x0000000183AA7150 0x0000000183AA5BF0-0x0000000183AA5CA0
	public ConfigAbilityAction[] onKillActions { /* [XID] */ /* 0x0000000189B8D870-0x0000000189B8D890 */ get => default; /* [XID] */ /* 0x0000000189B94E50-0x0000000189B94E70 */ private set {} } // 0x0000000183AA7150-0x0000000183AA71F0 0x0000000183AA6BC0-0x0000000183AA6C70
	public ConfigAbilityAction[] onReviveActions { /* [XID] */ /* 0x0000000189B9C5E0-0x0000000189B9C600 */ get => default; /* [XID] */ /* 0x0000000189BA3BF0-0x0000000189BA3C10 */ private set {} } // 0x0000000183AA6600-0x0000000183AA66A0 0x0000000183AA73C0-0x0000000183AA7470
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018962C690-0x000000018962C6B0 */ get => default; } // 0x0000000183AA67A0-0x0000000183AA6840 

	// Constructors
	public DoReviveMixin() {} // 0x0000000183AA85F0-0x0000000183AA8660

	// Methods
	// [XID] // 0x0000000189BAB060-0x0000000189BAB080
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AA8350-0x0000000183AA84B0
	// [XID] // 0x0000000189BB2650-0x0000000189BB2670
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183AA7D30-0x0000000183AA7E30
	// [XID] // 0x0000000189BB9A40-0x0000000189BB9A60
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF604D */) => default; // 0x0000000183AA7940-0x0000000183AA7A20
	// [XID] // 0x0000000189BC1A20-0x0000000189BC1A40
	public override int GetHashNum() => default; // 0x0000000183AA5F30-0x0000000183AA6000
	// [XID] // 0x0000000189BC9040-0x0000000189BC9060
	public override void InitEmpty() {} // 0x0000000183AA71F0-0x0000000183AA72E0
	[BlackList] // 0x0000000189BD0930-0x0000000189BD0970
	// [XID] // 0x0000000189BD0930-0x0000000189BD0970
	public override bool FromJson(JSONNode node) => default; // 0x0000000183AA6840-0x0000000183AA6BC0
	// [XID] // 0x0000000189BDB160-0x0000000189BDB180
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183AA53D0-0x0000000183AA5920
	[BlackList] // 0x00000001895E7A90-0x00000001895E7AD0
	// [XID] // 0x00000001895E7A90-0x00000001895E7AD0
	public static new DoReviveMixin ParseFromJson(JSONNode node) => default; // 0x0000000183AA7A80-0x0000000183AA7CD0
	// [XID] // 0x00000001895F2210-0x00000001895F2230
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF604E */, bool useObjectPool = false /* Metadata: 0x00AF6052 */) => default; // 0x0000000183AA7560-0x0000000183AA7860
	// [XID] // 0x00000001895F9BC0-0x00000001895F9BE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6053 */, bool useObjectPool = false /* Metadata: 0x00AF6057 */) => default; // 0x0000000183AA60E0-0x0000000183AA6560
	// [XID] // 0x0000000189601320-0x0000000189601340
	public static new DoReviveMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6058 */, bool useObjectPool = false /* Metadata: 0x00AF605C */) => default; // 0x0000000183AA6CE0-0x0000000183AA6F00
	[BlackList] // 0x0000000189608D30-0x0000000189608D70
	// [XID] // 0x0000000189608D30-0x0000000189608D70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AA5920-0x0000000183AA5BF0
	// [XID] // 0x0000000189613200-0x0000000189613220
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AA7EE0-0x0000000183AA8350
	[BlackList] // 0x000000018961AA80-0x000000018961AAC0
	// [XID] // 0x000000018961AA80-0x000000018961AAC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183AA7470-0x0000000183AA7560
	// [XID] // 0x0000000189624ED0-0x0000000189624EF0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183AA7860-0x0000000183AA7940
	[BlackList] // 0x0000000189634370-0x00000001896343B0
	// [XID] // 0x0000000189634370-0x00000001896343B0
	public override void AutoAllocTypeFields() {} // 0x0000000183AA5CA0-0x0000000183AA5D40
	[BlackList] // 0x000000018963E9C0-0x000000018963EA00
	// [XID] // 0x000000018963E9C0-0x000000018963EA00
	public override void AutoRecycleTypeFields() {} // 0x0000000183AA5D40-0x0000000183AA5E10
	[BlackList] // 0x0000000189649320-0x0000000189649360
	// [XID] // 0x0000000189649320-0x0000000189649360
	public override void ReturnToObjectPool() {} // 0x0000000183AA8550-0x0000000183AA85F0
}


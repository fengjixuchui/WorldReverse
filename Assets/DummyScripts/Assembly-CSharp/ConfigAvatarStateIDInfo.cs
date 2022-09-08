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
public class ConfigAvatarStateIDInfo : ConfigNormalStateIDInfo, IAutoAllocRecycle // TypeDefIndex: 19030
{
	// Fields
	private StateCameraType _cameraType; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigStateCameraParam _cameraParam; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCanChangeAvatar[] _canChangeAvatar; // 0x70
	private bool _canSupportChange; // 0x78
	private ActionPanelState _actionPanelState; // 0x7C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEquipReattach[] _equipReattach; // 0x80
	private SimpleSafeFloat jumpCancelStartRawNum; // 0x88
	private SimpleSafeFloat jumpCancelEndRawNum; // 0x8C
	private SimpleSafeFloat sprintCancelStartRawNum; // 0x90
	private SimpleSafeFloat sprintCancelEndRawNum; // 0x94
	private SimpleSafeFloat flyCancelStartRawNum; // 0x98
	private SimpleSafeFloat flyCancelEndRawNum; // 0x9C
	private string _animatorTriggerOnLanded; // 0xA0
	private bool _battouOnStart; // 0xA8
	private bool _sheatheOnStart; // 0xA9
	private bool _sheatheOnEnd; // 0xAA

	// Properties
	public StateCameraType cameraType { /* [XID] */ /* 0x0000000189A2A6A0-0x0000000189A2A6C0 */ get => default; /* [XID] */ /* 0x0000000189A31C20-0x0000000189A31C40 */ private set {} } // 0x0000000183DDD530-0x0000000183DDD5D0 0x0000000183DDB570-0x0000000183DDB620
	public ConfigStateCameraParam cameraParam { /* [XID] */ /* 0x0000000189A39670-0x0000000189A39690 */ get => default; /* [XID] */ /* 0x0000000189A40E30-0x0000000189A40E50 */ private set {} } // 0x0000000183DDEB40-0x0000000183DDEBE0 0x0000000183DDE040-0x0000000183DDE0F0
	public ConfigCanChangeAvatar[] canChangeAvatar { /* [XID] */ /* 0x0000000189A48490-0x0000000189A484B0 */ get => default; /* [XID] */ /* 0x0000000189A4FD60-0x0000000189A4FD80 */ private set {} } // 0x0000000183DDC8F0-0x0000000183DDC990 0x0000000183DDE300-0x0000000183DDE3B0
	public bool canSupportChange { /* [XID] */ /* 0x0000000189A57250-0x0000000189A57270 */ get => default; /* [XID] */ /* 0x0000000189A5EDB0-0x0000000189A5EDD0 */ private set {} } // 0x0000000183DDFA90-0x0000000183DDFB30 0x0000000183DDE1A0-0x0000000183DDE250
	public ActionPanelState actionPanelState { /* [XID] */ /* 0x0000000189A66680-0x0000000189A666A0 */ get => default; /* [XID] */ /* 0x0000000189A6DEE0-0x0000000189A6DF00 */ private set {} } // 0x0000000183DDB880-0x0000000183DDB920 0x0000000183DDBBC0-0x0000000183DDBC70
	public ConfigEquipReattach[] equipReattach { /* [XID] */ /* 0x0000000189A753D0-0x0000000189A753F0 */ get => default; /* [XID] */ /* 0x0000000189A7D130-0x0000000189A7D150 */ private set {} } // 0x0000000183DDD680-0x0000000183DDD730 0x0000000183DDE250-0x0000000183DDE300
	public float jumpCancelStart { /* [XID] */ /* 0x0000000189A84980-0x0000000189A849A0 */ get => default; /* [XID] */ /* 0x0000000189A8C1F0-0x0000000189A8C210 */ private set {} } // 0x0000000183DDB7A0-0x0000000183DDB880 0x0000000183DDFF80-0x0000000183DE0060
	public float jumpCancelEnd { /* [XID] */ /* 0x0000000189A936B0-0x0000000189A936D0 */ get => default; /* [XID] */ /* 0x0000000189A9B300-0x0000000189A9B320 */ private set {} } // 0x0000000183DDCF20-0x0000000183DDD000 0x0000000183DDD300-0x0000000183DDD3E0
	public float sprintCancelStart { /* [XID] */ /* 0x0000000189AA2580-0x0000000189AA25A0 */ get => default; /* [XID] */ /* 0x0000000189AA9AE0-0x0000000189AA9B00 */ private set {} } // 0x0000000183DDD3E0-0x0000000183DDD4C0 0x0000000183DDCE40-0x0000000183DDCF20
	public float sprintCancelEnd { /* [XID] */ /* 0x0000000189AB19E0-0x0000000189AB1A00 */ get => default; /* [XID] */ /* 0x0000000189AB8CC0-0x0000000189AB8CE0 */ private set {} } // 0x0000000183DDB980-0x0000000183DDBA60 0x0000000183DD9C60-0x0000000183DD9D40
	public float flyCancelStart { /* [XID] */ /* 0x0000000189AC07F0-0x0000000189AC0810 */ get => default; /* [XID] */ /* 0x0000000189AC81F0-0x0000000189AC8210 */ private set {} } // 0x0000000183DDD220-0x0000000183DDD300 0x0000000183DDBA60-0x0000000183DDBB40
	public float flyCancelEnd { /* [XID] */ /* 0x0000000189ACF9B0-0x0000000189ACF9D0 */ get => default; /* [XID] */ /* 0x0000000189AD7680-0x0000000189AD76A0 */ private set {} } // 0x0000000183DDB360-0x0000000183DDB440 0x0000000183DDE3B0-0x0000000183DDE490
	public string animatorTriggerOnLanded { /* [XID] */ /* 0x0000000189ADF130-0x0000000189ADF150 */ get => default; /* [XID] */ /* 0x0000000189AE69E0-0x0000000189AE6A00 */ private set {} } // 0x0000000183DDD5D0-0x0000000183DDD680 0x0000000183DDBC70-0x0000000183DDBD20
	public bool battouOnStart { /* [XID] */ /* 0x0000000189AEE420-0x0000000189AEE440 */ get => default; /* [XID] */ /* 0x0000000189AF5A30-0x0000000189AF5A50 */ private set {} } // 0x0000000183DDAF70-0x0000000183DDB020 0x0000000183DDB440-0x0000000183DDB4F0
	public bool sheatheOnStart { /* [XID] */ /* 0x0000000189AFCEB0-0x0000000189AFCED0 */ get => default; /* [XID] */ /* 0x0000000189B046C0-0x0000000189B046E0 */ private set {} } // 0x0000000183DDB6F0-0x0000000183DDB7A0 0x0000000183DDEA90-0x0000000183DDEB40
	public bool sheatheOnEnd { /* [XID] */ /* 0x0000000189B0BF50-0x0000000189B0BF70 */ get => default; /* [XID] */ /* 0x0000000189B13560-0x0000000189B13580 */ private set {} } // 0x0000000183DDCA10-0x0000000183DDCAC0 0x0000000183DDE0F0-0x0000000183DDE1A0

	// Constructors
	public ConfigAvatarStateIDInfo() {} // 0x0000000183DE0100-0x0000000183DE0220

	// Methods
	// [XID] // 0x0000000189B1ACC0-0x0000000189B1ACE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183DDFB30-0x0000000183DDFDD0
	// [XID] // 0x0000000189B22210-0x0000000189B22230
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183DDE7A0-0x0000000183DDE8D0
	// [XID] // 0x0000000189B297E0-0x0000000189B29800
	public override ConfigBaseStateIDInfo Clone(bool useObjectPool = false /* Metadata: 0x00AFB809 */) => default; // 0x0000000183DDDF60-0x0000000183DDE040
	// [XID] // 0x0000000189B30D50-0x0000000189B30D70
	public override int GetHashNum() => default; // 0x0000000183DDB620-0x0000000183DDB6F0
	// [XID] // 0x0000000189B38450-0x0000000189B38470
	public override void InitEmpty() {} // 0x0000000183DDD730-0x0000000183DDD8F0
	[BlackList] // 0x0000000189B3FE40-0x0000000189B3FE80
	// [XID] // 0x0000000189B3FE40-0x0000000189B3FE80
	public override bool FromJson(JSONNode node) => default; // 0x0000000183DDCAC0-0x0000000183DDCE40
	// [XID] // 0x0000000189B4A7F0-0x0000000189B4A810
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183DD9D40-0x0000000183DDACA0
	[BlackList] // 0x0000000189B51F20-0x0000000189B51F60
	// [XID] // 0x0000000189B51F20-0x0000000189B51F60
	public static new ConfigAvatarStateIDInfo ParseFromJson(JSONNode node) => default; // 0x0000000183DDE4F0-0x0000000183DDE740
	// [XID] // 0x0000000189B5C870-0x0000000189B5C890
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB80A */, bool useObjectPool = false /* Metadata: 0x00AFB80E */) => default; // 0x0000000183DDDC60-0x0000000183DDDF60
	// [XID] // 0x0000000189B63E90-0x0000000189B63EB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB80F */, bool useObjectPool = false /* Metadata: 0x00AFB813 */) => default; // 0x0000000183DDBDB0-0x0000000183DDC870
	// [XID] // 0x0000000189B6B6B0-0x0000000189B6B6D0
	public static new ConfigAvatarStateIDInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB814 */, bool useObjectPool = false /* Metadata: 0x00AFB818 */) => default; // 0x0000000183DDD000-0x0000000183DDD220
	[BlackList] // 0x0000000189B72C30-0x0000000189B72C70
	// [XID] // 0x0000000189B72C30-0x0000000189B72C70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183DDACA0-0x0000000183DDAF70
	// [XID] // 0x0000000189B7CFE0-0x0000000189B7D000
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183DDEFB0-0x0000000183DDFA90
	[BlackList] // 0x0000000189B84E50-0x0000000189B84E90
	// [XID] // 0x0000000189B84E50-0x0000000189B84E90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183DDD9D0-0x0000000183DDDAC0
	[BlackList] // 0x0000000189B8EC90-0x0000000189B8ECD0
	// [XID] // 0x0000000189B8EC90-0x0000000189B8ECD0
	public override void AutoAllocTypeFields() {} // 0x0000000183DDB020-0x0000000183DDB0C0
	[BlackList] // 0x0000000189B99220-0x0000000189B99260
	// [XID] // 0x0000000189B99220-0x0000000189B99260
	public override void AutoRecycleTypeFields() {} // 0x0000000183DDB0C0-0x0000000183DDB2C0
	[BlackList] // 0x0000000189BA3910-0x0000000189BA3950
	// [XID] // 0x0000000189BA3910-0x0000000189BA3950
	public override void ReturnToObjectPool() {} // 0x0000000183DE0060-0x0000000183DE0100
	// [XID] // 0x0000000189BAD9A0-0x0000000189BAD9C0
	public override void ProcessNormalizedTime(BaseEntity entity, float normalizedTime) {} // 0x0000000183DDFDD0-0x0000000183DDFEC0
	// [XID] // 0x0000000189BB51F0-0x0000000189BB5210
	private void ProcessCanChangeAvatar(BaseEntity entity, float normalizedTime) {} // 0x0000000183DDDAC0-0x0000000183DDDC60
	// [XID] // 0x0000000189BBC870-0x0000000189BBC890
	private void ProcessCombatState(BaseEntity entity, float normalizedTime) {} // 0x0000000183DDE8D0-0x0000000183DDEA90
	// [XID] // 0x0000000189BC4520-0x0000000189BC4540
	public override void HandleAnimatorState(BaseEntity entity, bool isTo, int fromStateID, int toStateID, VCAnimatorEvent animatorComponent) {} // 0x0000000183DDEBE0-0x0000000183DDEFB0
}


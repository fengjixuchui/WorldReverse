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
public class SetSurroundAnchor : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16707
{
	// Fields
	private bool _setPoint; // 0x68
	private ActionPointType _actionPointType; // 0x6C
	private SimpleSafeUInt32 actionPointIDRawNum; // 0x70

	// Properties
	public bool setPoint { /* [XID] */ /* 0x00000001897557D0-0x00000001897557F0 */ get => default; /* [XID] */ /* 0x000000018975CAD0-0x000000018975CAF0 */ private set {} } // 0x000000018191F7E0-0x000000018191F880 0x0000000181920800-0x00000001819208B0
	public ActionPointType actionPointType { /* [XID] */ /* 0x0000000189764280-0x00000001897642A0 */ get => default; /* [XID] */ /* 0x000000018976BB60-0x000000018976BB80 */ private set {} } // 0x00000001819206C0-0x0000000181920760 0x00000001819211F0-0x00000001819212A0
	public uint actionPointID { /* [XID] */ /* 0x00000001897730C0-0x00000001897730E0 */ get => default; /* [XID] */ /* 0x000000018977A6A0-0x000000018977A6C0 */ private set {} } // 0x0000000181921870-0x0000000181921940 0x000000018191F9D0-0x000000018191FAB0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898070D0-0x00000001898070F0 */ get => default; } // 0x00000001819212A0-0x0000000181921340 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018980E6D0-0x000000018980E6F0 */ get => default; } // 0x0000000181920760-0x0000000181920800 

	// Constructors
	public SetSurroundAnchor() {} // 0x0000000181921BB0-0x0000000181921C50

	// Methods
	// [XID] // 0x00000001897822C0-0x00000001897822E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181921940-0x0000000181921A70
	// [XID] // 0x0000000189789640-0x0000000189789660
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001819213A0-0x0000000181921450
	// [XID] // 0x0000000189790D50-0x0000000189790D70
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF43BE */) => default; // 0x0000000181920E60-0x0000000181920F40
	// [XID] // 0x00000001897985E0-0x0000000189798600
	public override int GetHashNum() => default; // 0x000000018191F710-0x000000018191F7E0
	// [XID] // 0x00000001897A0430-0x00000001897A0450
	public override void InitEmpty() {} // 0x00000001819208B0-0x0000000181920980
	[BlackList] // 0x00000001897A7A40-0x00000001897A7A80
	// [XID] // 0x00000001897A7A40-0x00000001897A7A80
	public override bool FromJson(JSONNode node) => default; // 0x0000000181920040-0x00000001819203C0
	// [XID] // 0x00000001897B23D0-0x00000001897B23F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018191ED50-0x000000018191F130
	[BlackList] // 0x00000001897B9D70-0x00000001897B9DB0
	// [XID] // 0x00000001897B9D70-0x00000001897B9DB0
	public static new SetSurroundAnchor ParseFromJson(JSONNode node) => default; // 0x0000000181920FA0-0x00000001819211F0
	// [XID] // 0x00000001897C4CA0-0x00000001897C4CC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43BF */, bool useObjectPool = false /* Metadata: 0x00AF43C3 */) => default; // 0x0000000181920B60-0x0000000181920E60
	// [XID] // 0x00000001897CC4B0-0x00000001897CC4D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43C4 */, bool useObjectPool = false /* Metadata: 0x00AF43C8 */) => default; // 0x000000018191FAB0-0x000000018191FDE0
	// [XID] // 0x00000001897D3DA0-0x00000001897D3DC0
	public static new SetSurroundAnchor ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43C9 */, bool useObjectPool = false /* Metadata: 0x00AF43CD */) => default; // 0x00000001819203C0-0x00000001819205E0
	[BlackList] // 0x00000001897DB6D0-0x00000001897DB710
	// [XID] // 0x00000001897DB6D0-0x00000001897DB710
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018191F130-0x000000018191F400
	// [XID] // 0x00000001897E5FD0-0x00000001897E5FF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181921530-0x0000000181921870
	[BlackList] // 0x00000001897ED970-0x00000001897ED9B0
	// [XID] // 0x00000001897ED970-0x00000001897ED9B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181920A60-0x0000000181920B60
	// [XID] // 0x00000001897F82E0-0x00000001897F8300
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181921A70-0x0000000181921B10
	// [XID] // 0x00000001897FFA10-0x00000001897FFA30
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018191FDE0-0x000000018191FF40
	[BlackList] // 0x0000000189815E50-0x0000000189815E90
	// [XID] // 0x0000000189815E50-0x0000000189815E90
	public override void AutoAllocTypeFields() {} // 0x000000018191F400-0x000000018191F4A0
	[BlackList] // 0x00000001898209B0-0x00000001898209F0
	// [XID] // 0x00000001898209B0-0x00000001898209F0
	public override void AutoRecycleTypeFields() {} // 0x000000018191F4A0-0x000000018191F580
	[BlackList] // 0x000000018982AE10-0x000000018982AE50
	// [XID] // 0x000000018982AE10-0x000000018982AE50
	public override void ReturnToObjectPool() {} // 0x0000000181921B10-0x0000000181921BB0
}


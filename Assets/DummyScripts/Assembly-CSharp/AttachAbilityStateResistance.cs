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
public class AttachAbilityStateResistance : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16591
{
	// Fields
	private SimpleSafeUInt32 resistanceListIDRawNum; // 0x68
	private AbilityState[] _resistanceBuffDebuffs; // 0x70
	private SimpleSafeFloat durationRatioRawNum; // 0x78

	// Properties
	public uint resistanceListID { /* [XID] */ /* 0x00000001897C4D60-0x00000001897C4D80 */ get => default; /* [XID] */ /* 0x00000001897CC510-0x00000001897CC530 */ private set {} } // 0x0000000183745F20-0x0000000183745FF0 0x0000000183745120-0x0000000183745200
	public AbilityState[] resistanceBuffDebuffs { /* [XID] */ /* 0x00000001897D3DC0-0x00000001897D3DE0 */ get => default; /* [XID] */ /* 0x00000001897DB710-0x00000001897DB730 */ private set {} } // 0x0000000183746860-0x0000000183746900 0x0000000183744480-0x0000000183744530
	public float durationRatio { /* [XID] */ /* 0x00000001897E2EA0-0x00000001897E2EC0 */ get => default; /* [XID] */ /* 0x00000001897EA6C0-0x00000001897EA6E0 */ private set {} } // 0x0000000183745C20-0x0000000183745D00 0x00000001837473C0-0x00000001837474A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189874360-0x0000000189874380 */ get => default; } // 0x0000000183746BB0-0x0000000183746C50 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018987BF00-0x000000018987BF20 */ get => default; } // 0x00000001837460D0-0x0000000183746170 

	// Constructors
	public AttachAbilityStateResistance() {} // 0x0000000183747540-0x0000000183747600

	// Methods
	// [XID] // 0x00000001897F2450-0x00000001897F2470
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837471F0-0x0000000183747320
	// [XID] // 0x00000001897F9BA0-0x00000001897F9BC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183746CB0-0x0000000183746D90
	// [XID] // 0x0000000189801140-0x0000000189801160
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF402A */) => default; // 0x0000000183746780-0x0000000183746860
	// [XID] // 0x0000000189808500-0x0000000189808520
	public override int GetHashNum() => default; // 0x0000000183744FE0-0x00000001837450B0
	// [XID] // 0x00000001898100B0-0x00000001898100D0
	public override void InitEmpty() {} // 0x0000000183746170-0x00000001837462B0
	[BlackList] // 0x0000000189817680-0x00000001898176C0
	// [XID] // 0x0000000189817680-0x00000001898176C0
	public override bool FromJson(JSONNode node) => default; // 0x00000001837458A0-0x0000000183745C20
	// [XID] // 0x0000000189822010-0x0000000189822030
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837445B0-0x00000001837449D0
	[BlackList] // 0x0000000189829550-0x0000000189829590
	// [XID] // 0x0000000189829550-0x0000000189829590
	public static new AttachAbilityStateResistance ParseFromJson(JSONNode node) => default; // 0x0000000183746960-0x0000000183746BB0
	// [XID] // 0x0000000189833C00-0x0000000189833C20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF402B */, bool useObjectPool = false /* Metadata: 0x00AF402F */) => default; // 0x0000000183746480-0x0000000183746780
	// [XID] // 0x000000018983B140-0x000000018983B160
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4030 */, bool useObjectPool = false /* Metadata: 0x00AF4034 */) => default; // 0x00000001837452E0-0x0000000183745640
	// [XID] // 0x00000001898429E0-0x0000000189842A00
	public static new AttachAbilityStateResistance ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4035 */, bool useObjectPool = false /* Metadata: 0x00AF4039 */) => default; // 0x0000000183745D00-0x0000000183745F20
	[BlackList] // 0x0000000189849CB0-0x0000000189849CF0
	// [XID] // 0x0000000189849CB0-0x0000000189849CF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001837449D0-0x0000000183744CA0
	// [XID] // 0x0000000189853DA0-0x0000000189853DC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183746E70-0x00000001837471F0
	[BlackList] // 0x000000018985B870-0x000000018985B8B0
	// [XID] // 0x000000018985B870-0x000000018985B8B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183746390-0x0000000183746480
	// [XID] // 0x0000000189865A30-0x0000000189865A50
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183747320-0x00000001837473C0
	// [XID] // 0x000000018986CF50-0x000000018986CF70
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183745640-0x00000001837457A0
	[BlackList] // 0x0000000189883030-0x0000000189883070
	// [XID] // 0x0000000189883030-0x0000000189883070
	public override void AutoAllocTypeFields() {} // 0x0000000183744CA0-0x0000000183744D40
	[BlackList] // 0x000000018988D520-0x000000018988D560
	// [XID] // 0x000000018988D520-0x000000018988D560
	public override void AutoRecycleTypeFields() {} // 0x0000000183744D40-0x0000000183744E50
	[BlackList] // 0x0000000189897B60-0x0000000189897BA0
	// [XID] // 0x0000000189897B60-0x0000000189897BA0
	public override void ReturnToObjectPool() {} // 0x00000001837474A0-0x0000000183747540
}


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
public class PlayEmoSync : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16369
{
	// Fields
	private SimpleSafeUInt32 dialogIDRawNum; // 0x68
	private string _emoSyncAssetPath; // 0x70

	// Properties
	public uint dialogID { /* [XID] */ /* 0x00000001897B73F0-0x00000001897B7410 */ get => default; /* [XID] */ /* 0x00000001897BF2B0-0x00000001897BF2D0 */ private set {} } // 0x0000000181893ED0-0x0000000181893FA0 0x0000000181893760-0x0000000181893840
	public string emoSyncAssetPath { /* [XID] */ /* 0x00000001897C68A0-0x00000001897C68C0 */ get => default; /* [XID] */ /* 0x00000001897CE000-0x00000001897CE020 */ private set {} } // 0x00000001818940B0-0x0000000181894150 0x0000000181893170-0x0000000181893220
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898589C0-0x00000001898589E0 */ get => default; } // 0x0000000181894AC0-0x0000000181894B60 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018985FAD0-0x000000018985FAF0 */ get => default; } // 0x0000000181894010-0x00000001818940B0 

	// Constructors
	public PlayEmoSync() {} // 0x0000000181895290-0x0000000181895320

	// Methods
	// [XID] // 0x00000001897D5570-0x00000001897D5590
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181895040-0x0000000181895150
	// [XID] // 0x00000001897DCD30-0x00000001897DCD50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181894BC0-0x0000000181894CA0
	// [XID] // 0x00000001897E4690-0x00000001897E46B0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3948 */) => default; // 0x0000000181894730-0x0000000181894810
	// [XID] // 0x00000001897EC200-0x00000001897EC220
	public override int GetHashNum() => default; // 0x0000000181892FD0-0x00000001818930A0
	// [XID] // 0x00000001897F3B90-0x00000001897F3BB0
	public override void InitEmpty() {} // 0x0000000181894150-0x0000000181894260
	[BlackList] // 0x00000001897FB570-0x00000001897FB5B0
	// [XID] // 0x00000001897FB570-0x00000001897FB5B0
	public override bool FromJson(JSONNode node) => default; // 0x00000001818938C0-0x0000000181893C40
	// [XID] // 0x00000001898056B0-0x00000001898056D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001818926D0-0x00000001818929F0
	[BlackList] // 0x000000018980CCB0-0x000000018980CCF0
	// [XID] // 0x000000018980CCB0-0x000000018980CCF0
	public static new PlayEmoSync ParseFromJson(JSONNode node) => default; // 0x0000000181894870-0x0000000181894AC0
	// [XID] // 0x0000000189817780-0x00000001898177A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3949 */, bool useObjectPool = false /* Metadata: 0x00AF394D */) => default; // 0x0000000181894430-0x0000000181894730
	// [XID] // 0x000000018981F0E0-0x000000018981F100
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF394E */, bool useObjectPool = false /* Metadata: 0x00AF3952 */) => default; // 0x00000001818932A0-0x0000000181893580
	// [XID] // 0x00000001898265F0-0x0000000189826610
	public static new PlayEmoSync ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3953 */, bool useObjectPool = false /* Metadata: 0x00AF3957 */) => default; // 0x0000000181893C40-0x0000000181893E60
	[BlackList] // 0x000000018982DC60-0x000000018982DCA0
	// [XID] // 0x000000018982DC60-0x000000018982DCA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001818929F0-0x0000000181892CC0
	// [XID] // 0x0000000189838320-0x0000000189838340
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181894D80-0x0000000181895040
	[BlackList] // 0x000000018983F990-0x000000018983F9D0
	// [XID] // 0x000000018983F990-0x000000018983F9D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181894340-0x0000000181894430
	// [XID] // 0x0000000189849E10-0x0000000189849E30
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181895150-0x00000001818951F0
	// [XID] // 0x0000000189851450-0x0000000189851470
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181893580-0x00000001818936E0
	[BlackList] // 0x0000000189867230-0x0000000189867270
	// [XID] // 0x0000000189867230-0x0000000189867270
	public override void AutoAllocTypeFields() {} // 0x0000000181892CC0-0x0000000181892D60
	[BlackList] // 0x00000001898716B0-0x00000001898716F0
	// [XID] // 0x00000001898716B0-0x00000001898716F0
	public override void AutoRecycleTypeFields() {} // 0x0000000181892D60-0x0000000181892E40
	[BlackList] // 0x000000018987BFE0-0x000000018987C020
	// [XID] // 0x000000018987BFE0-0x000000018987C020
	public override void ReturnToObjectPool() {} // 0x00000001818951F0-0x0000000181895290
}


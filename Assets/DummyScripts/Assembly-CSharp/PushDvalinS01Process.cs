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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class PushDvalinS01Process : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16645
{
	// Fields
	private SimpleSafeFloat timeRawNum; // 0x68
	private SimpleSafeFloat toPercentageRawNum; // 0x6C
	private bool _unBreak; // 0x70
	private bool _setForce; // 0x71
	private MoleMole.Config.Vector _vector; // 0x74
	private SimpleSafeFloat attenuationRawNum; // 0x80

	// Properties
	public float time { /* [XID] */ /* 0x000000018961DAB0-0x000000018961DAD0 */ get => default; /* [XID] */ /* 0x0000000189624F50-0x0000000189624F70 */ private set {} } // 0x0000000182F92EB0-0x0000000182F92F90 0x0000000182F92B80-0x0000000182F92C60
	public float toPercentage { /* [XID] */ /* 0x000000018962C790-0x000000018962C7B0 */ get => default; /* [XID] */ /* 0x0000000189634470-0x0000000189634490 */ private set {} } // 0x0000000182F905D0-0x0000000182F906B0 0x0000000182F91270-0x0000000182F91350
	public bool unBreak { /* [XID] */ /* 0x000000018963BBE0-0x000000018963BC00 */ get => default; /* [XID] */ /* 0x00000001896432A0-0x00000001896432C0 */ private set {} } // 0x0000000182F92F90-0x0000000182F93030 0x0000000182F8FEE0-0x0000000182F8FF90
	public bool setForce { /* [XID] */ /* 0x000000018964A920-0x000000018964A940 */ get => default; /* [XID] */ /* 0x00000001896521E0-0x0000000189652200 */ private set {} } // 0x0000000182F90E50-0x0000000182F90EF0 0x0000000182F915E0-0x0000000182F91690
	public MoleMole.Config.Vector vector { /* [XID] */ /* 0x0000000189659870-0x0000000189659890 */ get => default; /* [XID] */ /* 0x0000000189660FF0-0x0000000189661010 */ private set {} } // 0x0000000182F91F70-0x0000000182F92050 0x0000000182F8FF90-0x0000000182F90060
	public float attenuation { /* [XID] */ /* 0x00000001896689E0-0x0000000189668A00 */ get => default; /* [XID] */ /* 0x00000001896705B0-0x00000001896705D0 */ private set {} } // 0x0000000182F920B0-0x0000000182F92190 0x0000000182F91700-0x0000000182F917E0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896FA430-0x00000001896FA450 */ get => default; } // 0x0000000182F923E0-0x0000000182F92480 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189701B40-0x0000000189701B60 */ get => default; } // 0x0000000182F917E0-0x0000000182F91880 

	// Constructors
	public PushDvalinS01Process() {} // 0x0000000182F930D0-0x0000000182F93140

	// Methods
	// [XID] // 0x0000000189677DD0-0x0000000189677DF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182F92C60-0x0000000182F92E10
	// [XID] // 0x000000018967F300-0x000000018967F320
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182F924E0-0x0000000182F92590
	// [XID] // 0x0000000189686BB0-0x0000000189686BD0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF41DA */) => default; // 0x0000000182F91E90-0x0000000182F91F70
	// [XID] // 0x000000018968EA50-0x000000018968EA70
	public override int GetHashNum() => default; // 0x0000000182F903B0-0x0000000182F90480
	// [XID] // 0x00000001896964D0-0x00000001896964F0
	public override void InitEmpty() {} // 0x0000000182F91880-0x0000000182F919B0
	[BlackList] // 0x000000018969DA70-0x000000018969DAB0
	// [XID] // 0x000000018969DA70-0x000000018969DAB0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182F90EF0-0x0000000182F91270
	// [XID] // 0x00000001896A7B40-0x00000001896A7B60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182F8F500-0x0000000182F8FC10
	[BlackList] // 0x00000001896AEFB0-0x00000001896AEFF0
	// [XID] // 0x00000001896AEFB0-0x00000001896AEFF0
	public static new PushDvalinS01Process ParseFromJson(JSONNode node) => default; // 0x0000000182F92190-0x0000000182F923E0
	// [XID] // 0x00000001896B93B0-0x00000001896B93D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41DB */, bool useObjectPool = false /* Metadata: 0x00AF41DF */) => default; // 0x0000000182F91B90-0x0000000182F91E90
	// [XID] // 0x00000001896C07C0-0x00000001896C07E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41E0 */, bool useObjectPool = false /* Metadata: 0x00AF41E4 */) => default; // 0x0000000182F906B0-0x0000000182F90BF0
	// [XID] // 0x00000001896C7F10-0x00000001896C7F30
	public static new PushDvalinS01Process ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41E5 */, bool useObjectPool = false /* Metadata: 0x00AF41E9 */) => default; // 0x0000000182F91350-0x0000000182F91570
	[BlackList] // 0x00000001896CF830-0x00000001896CF870
	// [XID] // 0x00000001896CF830-0x00000001896CF870
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182F8FC10-0x0000000182F8FEE0
	// [XID] // 0x00000001896D9D30-0x00000001896D9D50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182F92670-0x0000000182F92B80
	[BlackList] // 0x00000001896E13B0-0x00000001896E13F0
	// [XID] // 0x00000001896E13B0-0x00000001896E13F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182F91A90-0x0000000182F91B90
	// [XID] // 0x00000001896EB740-0x00000001896EB760
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182F92E10-0x0000000182F92EB0
	// [XID] // 0x00000001896F2B10-0x00000001896F2B30
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182F90BF0-0x0000000182F90D50
	[BlackList] // 0x0000000189709460-0x00000001897094A0
	// [XID] // 0x0000000189709460-0x00000001897094A0
	public override void AutoAllocTypeFields() {} // 0x0000000182F90060-0x0000000182F90100
	[BlackList] // 0x0000000189713C00-0x0000000189713C40
	// [XID] // 0x0000000189713C00-0x0000000189713C40
	public override void AutoRecycleTypeFields() {} // 0x0000000182F90100-0x0000000182F90220
	[BlackList] // 0x000000018971E220-0x000000018971E260
	// [XID] // 0x000000018971E220-0x000000018971E260
	public override void ReturnToObjectPool() {} // 0x0000000182F93030-0x0000000182F930D0
}


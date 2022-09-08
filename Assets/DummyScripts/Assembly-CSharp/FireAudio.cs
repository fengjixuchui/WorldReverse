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
public class FireAudio : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16470
{
	// Fields
	private string _audioPattern; // 0x68
	private bool _forcePlay; // 0x70

	// Properties
	public string audioPattern { /* [XID] */ /* 0x0000000189929B00-0x0000000189929B20 */ get => default; /* [XID] */ /* 0x0000000189931040-0x0000000189931060 */ private set {} } // 0x0000000183ADC470-0x0000000183ADC510 0x0000000183ADBA80-0x0000000183ADBB30
	public bool forcePlay { /* [XID] */ /* 0x00000001899384B0-0x00000001899384D0 */ get => default; /* [XID] */ /* 0x000000018993FEC0-0x000000018993FEE0 */ private set {} } // 0x0000000183ADD470-0x0000000183ADD510 0x0000000183ADD3C0-0x0000000183ADD470
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899CBF00-0x00000001899CBF20 */ get => default; } // 0x0000000183ADD1E0-0x0000000183ADD280 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899D3430-0x00000001899D3450 */ get => default; } // 0x0000000183ADC810-0x0000000183ADC8B0 

	// Constructors
	public FireAudio() {} // 0x0000000183ADDAD0-0x0000000183ADDB30

	// Methods
	// [XID] // 0x0000000189947560-0x0000000189947580
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183ADD880-0x0000000183ADD990
	// [XID] // 0x000000018994ECE0-0x000000018994ED00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183ADD2E0-0x0000000183ADD3C0
	// [XID] // 0x0000000189956260-0x0000000189956280
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3C70 */) => default; // 0x0000000183ADCE50-0x0000000183ADCF30
	// [XID] // 0x000000018995DD90-0x000000018995DDB0
	public override int GetHashNum() => default; // 0x0000000183ADB8E0-0x0000000183ADB9B0
	// [XID] // 0x0000000189965590-0x00000001899655B0
	public override void InitEmpty() {} // 0x0000000183ADC8B0-0x0000000183ADC980
	[BlackList] // 0x000000018996CB70-0x000000018996CBB0
	// [XID] // 0x000000018996CB70-0x000000018996CBB0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183ADC0F0-0x0000000183ADC470
	// [XID] // 0x0000000189977600-0x0000000189977620
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183ADB040-0x0000000183ADB330
	[BlackList] // 0x000000018997E8C0-0x000000018997E900
	// [XID] // 0x000000018997E8C0-0x000000018997E900
	public static new FireAudio ParseFromJson(JSONNode node) => default; // 0x0000000183ADCF90-0x0000000183ADD1E0
	// [XID] // 0x00000001899897C0-0x00000001899897E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C71 */, bool useObjectPool = false /* Metadata: 0x00AF3C75 */) => default; // 0x0000000183ADCB50-0x0000000183ADCE50
	// [XID] // 0x0000000189991050-0x0000000189991070
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C76 */, bool useObjectPool = false /* Metadata: 0x00AF3C7A */) => default; // 0x0000000183ADBBB0-0x0000000183ADBE90
	// [XID] // 0x0000000189998B10-0x0000000189998B30
	public static new FireAudio ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C7B */, bool useObjectPool = false /* Metadata: 0x00AF3C7F */) => default; // 0x0000000183ADC510-0x0000000183ADC730
	[BlackList] // 0x00000001899A0410-0x00000001899A0450
	// [XID] // 0x00000001899A0410-0x00000001899A0450
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183ADB330-0x0000000183ADB600
	// [XID] // 0x00000001899AAE00-0x00000001899AAE20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183ADD5F0-0x0000000183ADD880
	[BlackList] // 0x00000001899B28B0-0x00000001899B28F0
	// [XID] // 0x00000001899B28B0-0x00000001899B28F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183ADCA60-0x0000000183ADCB50
	// [XID] // 0x00000001899BCCB0-0x00000001899BCCD0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183ADD990-0x0000000183ADDA30
	// [XID] // 0x00000001899C4680-0x00000001899C46A0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183ADBE90-0x0000000183ADBFF0
	[BlackList] // 0x00000001899DA9A0-0x00000001899DA9E0
	// [XID] // 0x00000001899DA9A0-0x00000001899DA9E0
	public override void AutoAllocTypeFields() {} // 0x0000000183ADB600-0x0000000183ADB6A0
	[BlackList] // 0x00000001899E5520-0x00000001899E5560
	// [XID] // 0x00000001899E5520-0x00000001899E5560
	public override void AutoRecycleTypeFields() {} // 0x0000000183ADB6A0-0x0000000183ADB750
	[BlackList] // 0x00000001899EF7F0-0x00000001899EF830
	// [XID] // 0x00000001899EF7F0-0x00000001899EF830
	public override void ReturnToObjectPool() {} // 0x0000000183ADDA30-0x0000000183ADDAD0
}


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
public class TriggerAudio : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16511
{
	// Fields
	private OpResponder _responder; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAudioOperation _operation; // 0x70

	// Properties
	public OpResponder responder { /* [XID] */ /* 0x0000000189A161E0-0x0000000189A16200 */ get => default; /* [XID] */ /* 0x0000000189A1D780-0x0000000189A1D7A0 */ private set {} } // 0x0000000183A683F0-0x0000000183A68490 0x0000000183A66EA0-0x0000000183A66F50
	public ConfigAudioOperation operation { /* [XID] */ /* 0x0000000189A24B30-0x0000000189A24B50 */ get => default; /* [XID] */ /* 0x0000000189A2C1D0-0x0000000189A2C1F0 */ private set {} } // 0x0000000183A693E0-0x0000000183A69480 0x0000000183A68B70-0x0000000183A68C20
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AB7A40-0x0000000189AB7A60 */ get => default; } // 0x0000000183A68E70-0x0000000183A68F10 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189ABF490-0x0000000189ABF4B0 */ get => default; } // 0x0000000183A68350-0x0000000183A683F0 

	// Constructors
	public TriggerAudio() {} // 0x0000000183A696E0-0x0000000183A69740

	// Methods
	// [XID] // 0x0000000189A33900-0x0000000189A33920
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A69480-0x0000000183A695A0
	// [XID] // 0x0000000189A3B0A0-0x0000000189A3B0C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183A68F70-0x0000000183A69050
	// [XID] // 0x0000000189A429F0-0x0000000189A42A10
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3DB6 */) => default; // 0x0000000183A68A30-0x0000000183A68B10
	// [XID] // 0x0000000189A49F00-0x0000000189A49F20
	public override int GetHashNum() => default; // 0x0000000183A67590-0x0000000183A67660
	// [XID] // 0x0000000189A51890-0x0000000189A518B0
	public override void InitEmpty() {} // 0x0000000183A68490-0x0000000183A68560
	[BlackList] // 0x0000000189A59100-0x0000000189A59140
	// [XID] // 0x0000000189A59100-0x0000000189A59140
	public override bool FromJson(JSONNode node) => default; // 0x0000000183A67CD0-0x0000000183A68050
	// [XID] // 0x0000000189A63C10-0x0000000189A63C30
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183A66BA0-0x0000000183A66EA0
	[BlackList] // 0x0000000189A6B410-0x0000000189A6B450
	// [XID] // 0x0000000189A6B410-0x0000000189A6B450
	public static new TriggerAudio ParseFromJson(JSONNode node) => default; // 0x0000000183A68C20-0x0000000183A68E70
	// [XID] // 0x0000000189A75990-0x0000000189A759B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DB7 */, bool useObjectPool = false /* Metadata: 0x00AF3DBB */) => default; // 0x0000000183A68730-0x0000000183A68A30
	// [XID] // 0x0000000189A7D630-0x0000000189A7D650
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DBC */, bool useObjectPool = false /* Metadata: 0x00AF3DC0 */) => default; // 0x0000000183A677B0-0x0000000183A67A70
	// [XID] // 0x0000000189A84D80-0x0000000189A84DA0
	public static new TriggerAudio ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DC1 */, bool useObjectPool = false /* Metadata: 0x00AF3DC5 */) => default; // 0x0000000183A68050-0x0000000183A68270
	[BlackList] // 0x0000000189A8C6D0-0x0000000189A8C710
	// [XID] // 0x0000000189A8C6D0-0x0000000189A8C710
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A66F50-0x0000000183A67220
	// [XID] // 0x0000000189A96CE0-0x0000000189A96D00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A69130-0x0000000183A693E0
	[BlackList] // 0x0000000189A9E110-0x0000000189A9E150
	// [XID] // 0x0000000189A9E110-0x0000000189A9E150
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183A68640-0x0000000183A68730
	// [XID] // 0x0000000189AA86E0-0x0000000189AA8700
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183A695A0-0x0000000183A69640
	// [XID] // 0x0000000189AB0380-0x0000000189AB03A0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183A67A70-0x0000000183A67BD0
	[BlackList] // 0x0000000189AC6F40-0x0000000189AC6F80
	// [XID] // 0x0000000189AC6F40-0x0000000189AC6F80
	public override void AutoAllocTypeFields() {} // 0x0000000183A67220-0x0000000183A672C0
	[BlackList] // 0x0000000189AD1730-0x0000000189AD1770
	// [XID] // 0x0000000189AD1730-0x0000000189AD1770
	public override void AutoRecycleTypeFields() {} // 0x0000000183A672C0-0x0000000183A67400
	[BlackList] // 0x0000000189ADC4C0-0x0000000189ADC500
	// [XID] // 0x0000000189ADC4C0-0x0000000189ADC500
	public override void ReturnToObjectPool() {} // 0x0000000183A69640-0x0000000183A696E0
}


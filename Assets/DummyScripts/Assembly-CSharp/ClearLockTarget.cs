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
public class ClearLockTarget : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16537
{
	// Properties
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018994ECC0-0x000000018994ECE0 */ get => default; } // 0x000000018464BF00-0x000000018464BFA0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189956240-0x0000000189956260 */ get => default; } // 0x000000018464B560-0x000000018464B600 

	// Constructors
	public ClearLockTarget() {} // 0x000000018464C470-0x000000018464C4D0

	// Methods
	// [XID] // 0x00000001898CA7E0-0x00000001898CA800
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018464C280-0x000000018464C330
	// [XID] // 0x00000001898D1EF0-0x00000001898D1F10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018464C000-0x000000018464C0B0
	// [XID] // 0x00000001898D97B0-0x00000001898D97D0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E86 */) => default; // 0x000000018464BB70-0x000000018464BC50
	// [XID] // 0x00000001898E1510-0x00000001898E1530
	public override int GetHashNum() => default; // 0x000000018464A930-0x000000018464AA00
	// [XID] // 0x00000001898E8FA0-0x00000001898E8FC0
	public override void InitEmpty() {} // 0x000000018464B600-0x000000018464B6A0
	[BlackList] // 0x00000001898F0720-0x00000001898F0760
	// [XID] // 0x00000001898F0720-0x00000001898F0760
	public override bool FromJson(JSONNode node) => default; // 0x000000018464AEE0-0x000000018464B260
	// [XID] // 0x00000001898FAD60-0x00000001898FAD80
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018464A2A0-0x000000018464A390
	[BlackList] // 0x00000001899028A0-0x00000001899028E0
	// [XID] // 0x00000001899028A0-0x00000001899028E0
	public static new ClearLockTarget ParseFromJson(JSONNode node) => default; // 0x000000018464BCB0-0x000000018464BF00
	// [XID] // 0x000000018990D030-0x000000018990D050
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E87 */, bool useObjectPool = false /* Metadata: 0x00AF3E8B */) => default; // 0x000000018464B870-0x000000018464BB70
	// [XID] // 0x0000000189914800-0x0000000189914820
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E8C */, bool useObjectPool = false /* Metadata: 0x00AF3E90 */) => default; // 0x000000018464AB50-0x000000018464AC80
	// [XID] // 0x000000018991C420-0x000000018991C440
	public static new ClearLockTarget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E91 */, bool useObjectPool = false /* Metadata: 0x00AF3E95 */) => default; // 0x000000018464B260-0x000000018464B480
	[BlackList] // 0x0000000189923B20-0x0000000189923B60
	// [XID] // 0x0000000189923B20-0x0000000189923B60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018464A390-0x000000018464A660
	// [XID] // 0x000000018992E170-0x000000018992E190
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018464C190-0x000000018464C280
	[BlackList] // 0x0000000189935530-0x0000000189935570
	// [XID] // 0x0000000189935530-0x0000000189935570
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018464B780-0x000000018464B870
	// [XID] // 0x000000018993FEA0-0x000000018993FEC0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018464C330-0x000000018464C3D0
	// [XID] // 0x0000000189947540-0x0000000189947560
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018464AC80-0x000000018464ADE0
	[BlackList] // 0x000000018995DD30-0x000000018995DD70
	// [XID] // 0x000000018995DD30-0x000000018995DD70
	public override void AutoAllocTypeFields() {} // 0x000000018464A660-0x000000018464A700
	[BlackList] // 0x00000001899683E0-0x0000000189968420
	// [XID] // 0x00000001899683E0-0x0000000189968420
	public override void AutoRecycleTypeFields() {} // 0x000000018464A700-0x000000018464A7A0
	[BlackList] // 0x0000000189972CD0-0x0000000189972D10
	// [XID] // 0x0000000189972CD0-0x0000000189972D10
	public override void ReturnToObjectPool() {} // 0x000000018464C3D0-0x000000018464C470
}


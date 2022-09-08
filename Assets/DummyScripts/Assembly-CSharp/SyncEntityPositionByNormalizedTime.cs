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
public class SyncEntityPositionByNormalizedTime : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16775
{
	// Fields
	private SimpleSafeFloat normalizedTimeRawNum; // 0x68

	// Properties
	public float normalizedTime { /* [XID] */ /* 0x000000018963BB80-0x000000018963BBA0 */ get => default; /* [XID] */ /* 0x0000000189643200-0x0000000189643220 */ private set {} } // 0x00000001835536D0-0x00000001835537B0 0x0000000183552350-0x0000000183552430
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896C6890-0x00000001896C68B0 */ get => default; } // 0x0000000183553520-0x00000001835535C0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896CDEB0-0x00000001896CDED0 */ get => default; } // 0x0000000183552B40-0x0000000183552BE0 

	// Constructors
	public SyncEntityPositionByNormalizedTime() {} // 0x0000000183553C20-0x0000000183553C80

	// Methods
	// [XID] // 0x000000018964A900-0x000000018964A920
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183553A80-0x0000000183553B80
	// [XID] // 0x00000001896521C0-0x00000001896521E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183553620-0x00000001835536D0
	// [XID] // 0x0000000189659850-0x0000000189659870
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF45DE */) => default; // 0x0000000183553190-0x0000000183553270
	// [XID] // 0x0000000189660FD0-0x0000000189660FF0
	public override int GetHashNum() => default; // 0x0000000183551D60-0x0000000183551E30
	// [XID] // 0x00000001896689C0-0x00000001896689E0
	public override void InitEmpty() {} // 0x0000000183552BE0-0x0000000183552CB0
	[BlackList] // 0x0000000189670550-0x0000000189670590
	// [XID] // 0x0000000189670550-0x0000000189670590
	public override bool FromJson(JSONNode node) => default; // 0x0000000183552530-0x00000001835528B0
	// [XID] // 0x000000018967AB40-0x000000018967AB60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183551510-0x0000000183551780
	[BlackList] // 0x0000000189682450-0x0000000189682490
	// [XID] // 0x0000000189682450-0x0000000189682490
	public static new SyncEntityPositionByNormalizedTime ParseFromJson(JSONNode node) => default; // 0x00000001835532D0-0x0000000183553520
	// [XID] // 0x000000018968CE80-0x000000018968CEA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45DF */, bool useObjectPool = false /* Metadata: 0x00AF45E3 */) => default; // 0x0000000183552E90-0x0000000183553190
	// [XID] // 0x0000000189694980-0x00000001896949A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45E4 */, bool useObjectPool = false /* Metadata: 0x00AF45E8 */) => default; // 0x0000000183551F80-0x00000001835521F0
	// [XID] // 0x000000018969C140-0x000000018969C160
	public static new SyncEntityPositionByNormalizedTime ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45E9 */, bool useObjectPool = false /* Metadata: 0x00AF45ED */) => default; // 0x00000001835528B0-0x0000000183552AD0
	[BlackList] // 0x00000001896A3580-0x00000001896A35C0
	// [XID] // 0x00000001896A3580-0x00000001896A35C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183551780-0x0000000183551A50
	// [XID] // 0x00000001896AD970-0x00000001896AD990
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183553890-0x0000000183553A80
	[BlackList] // 0x00000001896B50B0-0x00000001896B50F0
	// [XID] // 0x00000001896B50B0-0x00000001896B50F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183552D90-0x0000000183552E90
	// [XID] // 0x00000001896BEF50-0x00000001896BEF70
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001835521F0-0x0000000183552350
	[BlackList] // 0x00000001896D5400-0x00000001896D5440
	// [XID] // 0x00000001896D5400-0x00000001896D5440
	public override void AutoAllocTypeFields() {} // 0x0000000183551A50-0x0000000183551AF0
	[BlackList] // 0x00000001896DFC00-0x00000001896DFC40
	// [XID] // 0x00000001896DFC00-0x00000001896DFC40
	public override void AutoRecycleTypeFields() {} // 0x0000000183551AF0-0x0000000183551BD0
	[BlackList] // 0x00000001896E9FE0-0x00000001896EA020
	// [XID] // 0x00000001896E9FE0-0x00000001896EA020
	public override void ReturnToObjectPool() {} // 0x0000000183553B80-0x0000000183553C20
}


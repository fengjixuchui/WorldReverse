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
public class SetPaimonLookAtAvatar : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16635
{
	// Fields
	private PaimonRequestFrom _from; // 0x68
	private bool _lookat; // 0x6C
	private SimpleSafeFloat minTimeRawNum; // 0x70
	private SimpleSafeFloat maxTimeRawNum; // 0x74

	// Properties
	public PaimonRequestFrom from { /* [XID] */ /* 0x00000001897F3B70-0x00000001897F3B90 */ get => default; /* [XID] */ /* 0x00000001897FB530-0x00000001897FB550 */ private set {} } // 0x0000000185149CA0-0x0000000185149D40 0x000000018514A000-0x000000018514A0B0
	public bool lookat { /* [XID] */ /* 0x00000001898029C0-0x00000001898029E0 */ get => default; /* [XID] */ /* 0x000000018980A010-0x000000018980A030 */ private set {} } // 0x0000000185148CC0-0x0000000185148D60 0x000000018514AAB0-0x000000018514AB60
	public float minTime { /* [XID] */ /* 0x00000001898116A0-0x00000001898116C0 */ get => default; /* [XID] */ /* 0x0000000189819210-0x0000000189819230 */ private set {} } // 0x000000018514A4F0-0x000000018514A5D0 0x000000018514A5D0-0x000000018514A6B0
	public float maxTime { /* [XID] */ /* 0x0000000189820A30-0x0000000189820A50 */ get => default; /* [XID] */ /* 0x0000000189827F80-0x0000000189827FA0 */ private set {} } // 0x0000000185149340-0x0000000185149420 0x0000000185149BC0-0x0000000185149CA0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898B1080-0x00000001898B10A0 */ get => default; } // 0x000000018514A900-0x000000018514A9A0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898B8820-0x00000001898B8840 */ get => default; } // 0x0000000185149B20-0x0000000185149BC0 

	// Constructors
	public SetPaimonLookAtAvatar() {} // 0x000000018514B270-0x000000018514B2D0

	// Methods
	// [XID] // 0x000000018982F240-0x000000018982F260
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018514AFE0-0x000000018514B130
	// [XID] // 0x0000000189836AF0-0x0000000189836B10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018514AA00-0x000000018514AAB0
	// [XID] // 0x000000018983DF60-0x000000018983DF80
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF418A */) => default; // 0x000000018514A3B0-0x000000018514A490
	// [XID] // 0x00000001898457B0-0x00000001898457D0
	public override int GetHashNum() => default; // 0x0000000185148AA0-0x0000000185148B70
	// [XID] // 0x000000018984CCC0-0x000000018984CCE0
	public override void InitEmpty() {} // 0x0000000185149D40-0x0000000185149E20
	[BlackList] // 0x0000000189853D20-0x0000000189853D60
	// [XID] // 0x0000000189853D20-0x0000000189853D60
	public override bool FromJson(JSONNode node) => default; // 0x00000001851494A0-0x0000000185149820
	// [XID] // 0x000000018985DF70-0x000000018985DF90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185147F70-0x00000001851484A0
	[BlackList] // 0x00000001898659D0-0x0000000189865A10
	// [XID] // 0x00000001898659D0-0x0000000189865A10
	public static new SetPaimonLookAtAvatar ParseFromJson(JSONNode node) => default; // 0x000000018514A6B0-0x000000018514A900
	// [XID] // 0x000000018986FEC0-0x000000018986FEE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF418B */, bool useObjectPool = false /* Metadata: 0x00AF418F */) => default; // 0x000000018514A0B0-0x000000018514A3B0
	// [XID] // 0x00000001898775B0-0x00000001898775D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4190 */, bool useObjectPool = false /* Metadata: 0x00AF4194 */) => default; // 0x0000000185148D60-0x0000000185149160
	// [XID] // 0x000000018987EE00-0x000000018987EE20
	public static new SetPaimonLookAtAvatar ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4195 */, bool useObjectPool = false /* Metadata: 0x00AF4199 */) => default; // 0x0000000185149820-0x0000000185149A40
	[BlackList] // 0x00000001898863C0-0x0000000189886400
	// [XID] // 0x00000001898863C0-0x0000000189886400
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001851484A0-0x0000000185148770
	// [XID] // 0x0000000189890600-0x0000000189890620
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018514AC40-0x000000018514AFE0
	[BlackList] // 0x0000000189897B00-0x0000000189897B40
	// [XID] // 0x0000000189897B00-0x0000000189897B40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185149F00-0x000000018514A000
	// [XID] // 0x00000001898A2040-0x00000001898A2060
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018514B130-0x000000018514B1D0
	// [XID] // 0x00000001898A97F0-0x00000001898A9810
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185149160-0x00000001851492C0
	[BlackList] // 0x00000001898BFF40-0x00000001898BFF80
	// [XID] // 0x00000001898BFF40-0x00000001898BFF80
	public override void AutoAllocTypeFields() {} // 0x0000000185148770-0x0000000185148810
	[BlackList] // 0x00000001898CA7A0-0x00000001898CA7E0
	// [XID] // 0x00000001898CA7A0-0x00000001898CA7E0
	public override void AutoRecycleTypeFields() {} // 0x0000000185148810-0x0000000185148910
	[BlackList] // 0x00000001898D4FF0-0x00000001898D5030
	// [XID] // 0x00000001898D4FF0-0x00000001898D5030
	public override void ReturnToObjectPool() {} // 0x000000018514B1D0-0x000000018514B270
}


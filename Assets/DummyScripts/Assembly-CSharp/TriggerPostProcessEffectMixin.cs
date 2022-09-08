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
public class TriggerPostProcessEffectMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16983
{
	// Fields
	private string _postEffectAssetName; // 0x30
	private SimpleSafeFloat durationRawNum; // 0x38
	private bool _isStageEffect; // 0x3C

	// Properties
	public string postEffectAssetName { /* [XID] */ /* 0x0000000189B77510-0x0000000189B77530 */ get => default; /* [XID] */ /* 0x0000000189B7EAE0-0x0000000189B7EB00 */ private set {} } // 0x000000018396A920-0x000000018396A9C0 0x00000001839686A0-0x0000000183968750
	public float duration { /* [XID] */ /* 0x0000000189B86780-0x0000000189B867A0 */ get => default; /* [XID] */ /* 0x0000000189B8D8B0-0x0000000189B8D8D0 */ private set {} } // 0x0000000183969040-0x0000000183969120 0x0000000183969750-0x0000000183969830
	public bool isStageEffect { /* [XID] */ /* 0x0000000189B94E90-0x0000000189B94EB0 */ get => default; /* [XID] */ /* 0x0000000189B9C620-0x0000000189B9C640 */ private set {} } // 0x000000018396A3C0-0x000000018396A460 0x00000001839691A0-0x0000000183969250
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189624EF0-0x0000000189624F10 */ get => default; } // 0x0000000183969930-0x00000001839699D0 

	// Constructors
	public TriggerPostProcessEffectMixin() {} // 0x000000018396B2A0-0x000000018396B340

	// Methods
	// [XID] // 0x0000000189BA3C30-0x0000000189BA3C50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018396B0D0-0x000000018396B200
	// [XID] // 0x0000000189BAB0A0-0x0000000189BAB0C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018396ACD0-0x000000018396ADB0
	// [XID] // 0x0000000189BB2690-0x0000000189BB26B0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5F7B */) => default; // 0x000000018396A840-0x000000018396A920
	// [XID] // 0x0000000189BB9A80-0x0000000189BB9AA0
	public override int GetHashNum() => default; // 0x0000000183969250-0x0000000183969320
	// [XID] // 0x0000000189BC1A60-0x0000000189BC1A80
	public override void InitEmpty() {} // 0x000000018396A0E0-0x000000018396A1F0
	[BlackList] // 0x0000000189BC9080-0x0000000189BC90C0
	// [XID] // 0x0000000189BC9080-0x0000000189BC90C0
	public override bool FromJson(JSONNode node) => default; // 0x00000001839699D0-0x0000000183969D50
	// [XID] // 0x0000000189BD37B0-0x0000000189BD37D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183968750-0x0000000183968B50
	[BlackList] // 0x0000000189BDB180-0x0000000189BDB1C0
	// [XID] // 0x0000000189BDB180-0x0000000189BDB1C0
	public static new TriggerPostProcessEffectMixin ParseFromJson(JSONNode node) => default; // 0x000000018396AA20-0x000000018396AC70
	// [XID] // 0x00000001895EAD50-0x00000001895EAD70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F7C */, bool useObjectPool = false /* Metadata: 0x00AF5F80 */) => default; // 0x000000018396A460-0x000000018396A760
	// [XID] // 0x00000001895F2230-0x00000001895F2250
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F81 */, bool useObjectPool = false /* Metadata: 0x00AF5F85 */) => default; // 0x0000000183969400-0x0000000183969750
	// [XID] // 0x00000001895F9C00-0x00000001895F9C20
	public static new TriggerPostProcessEffectMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F86 */, bool useObjectPool = false /* Metadata: 0x00AF5F8A */) => default; // 0x0000000183969DC0-0x0000000183969FE0
	[BlackList] // 0x0000000189601360-0x00000001896013A0
	// [XID] // 0x0000000189601360-0x00000001896013A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183968B50-0x0000000183968E20
	// [XID] // 0x000000018960BBE0-0x000000018960BC00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018396ADB0-0x000000018396B0D0
	[BlackList] // 0x0000000189613220-0x0000000189613260
	// [XID] // 0x0000000189613220-0x0000000189613260
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018396A2D0-0x000000018396A3C0
	// [XID] // 0x000000018961DA10-0x000000018961DA30
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018396A760-0x000000018396A840
	[BlackList] // 0x000000018962C6D0-0x000000018962C710
	// [XID] // 0x000000018962C6D0-0x000000018962C710
	public override void AutoAllocTypeFields() {} // 0x0000000183968E20-0x0000000183968EC0
	[BlackList] // 0x0000000189637420-0x0000000189637460
	// [XID] // 0x0000000189637420-0x0000000189637460
	public override void AutoRecycleTypeFields() {} // 0x0000000183968EC0-0x0000000183968FA0
	[BlackList] // 0x0000000189641880-0x00000001896418C0
	// [XID] // 0x0000000189641880-0x00000001896418C0
	public override void ReturnToObjectPool() {} // 0x000000018396B200-0x000000018396B2A0
}


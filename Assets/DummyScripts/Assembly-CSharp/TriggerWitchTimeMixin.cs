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
public class TriggerWitchTimeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16977
{
	// Fields
	private TargetType _ignoreTargetType; // 0x30
	private SimpleSafeFloat timescaleRawNum; // 0x34
	private SimpleSafeFloat durationRawNum; // 0x38
	private bool _useMax; // 0x3C
	private bool _enableEffect; // 0x3D
	private bool _enableDelay; // 0x3E
	private SimpleSafeFloat delayTimeScaleRawNum; // 0x40
	private SimpleSafeFloat delayDurationRawNum; // 0x44
	private string _openEffectPattern; // 0x48
	private string _closeEffectPattern; // 0x50
	private string _weatherPattern; // 0x58

	// Properties
	public TargetType ignoreTargetType { /* [XID] */ /* 0x00000001899239E0-0x0000000189923A00 */ get => default; /* [XID] */ /* 0x000000018992B020-0x000000018992B040 */ private set {} } // 0x00000001850CBE90-0x00000001850CBF30 0x00000001850CE950-0x00000001850CEA00
	public float timescale { /* [XID] */ /* 0x00000001899326A0-0x00000001899326C0 */ get => default; /* [XID] */ /* 0x000000018993A0B0-0x000000018993A0D0 */ private set {} } // 0x00000001850CDD40-0x00000001850CDE20 0x00000001850D02A0-0x00000001850D0380
	public float duration { /* [XID] */ /* 0x0000000189941280-0x00000001899412A0 */ get => default; /* [XID] */ /* 0x0000000189948DC0-0x0000000189948DE0 */ private set {} } // 0x00000001850CCF40-0x00000001850CD020 0x00000001850CDBE0-0x00000001850CDCC0
	public bool useMax { /* [XID] */ /* 0x00000001899505D0-0x00000001899505F0 */ get => default; /* [XID] */ /* 0x0000000189957B20-0x0000000189957B40 */ private set {} } // 0x00000001850CDE20-0x00000001850CDEC0 0x00000001850D0380-0x00000001850D0430
	public bool enableEffect { /* [XID] */ /* 0x000000018995F3B0-0x000000018995F3D0 */ get => default; /* [XID] */ /* 0x0000000189966CD0-0x0000000189966CF0 */ private set {} } // 0x00000001850CBDF0-0x00000001850CBE90 0x00000001850CF440-0x00000001850CF4F0
	public bool enableDelay { /* [XID] */ /* 0x000000018996DFE0-0x000000018996E000 */ get => default; /* [XID] */ /* 0x0000000189975BF0-0x0000000189975C10 */ private set {} } // 0x00000001850CE7D0-0x00000001850CE870 0x00000001850CF390-0x00000001850CF440
	public float delayTimeScale { /* [XID] */ /* 0x000000018997CC10-0x000000018997CC30 */ get => default; /* [XID] */ /* 0x00000001899849B0-0x00000001899849D0 */ private set {} } // 0x00000001850CE5F0-0x00000001850CE6D0 0x00000001850CE870-0x00000001850CE950
	public float delayDuration { /* [XID] */ /* 0x000000018998C4D0-0x000000018998C4F0 */ get => default; /* [XID] */ /* 0x00000001899941F0-0x0000000189994210 */ private set {} } // 0x00000001850CF4F0-0x00000001850CF5D0 0x00000001850CED00-0x00000001850CEDE0
	public string openEffectPattern { /* [XID] */ /* 0x000000018999BA60-0x000000018999BA80 */ get => default; /* [XID] */ /* 0x00000001899A31F0-0x00000001899A3210 */ private set {} } // 0x00000001850CFAA0-0x00000001850CFB40 0x00000001850CF9F0-0x00000001850CFAA0
	public string closeEffectPattern { /* [XID] */ /* 0x00000001899AAC60-0x00000001899AAC80 */ get => default; /* [XID] */ /* 0x00000001899B2750-0x00000001899B2770 */ private set {} } // 0x00000001850CD210-0x00000001850CD2B0 0x00000001850CEBF0-0x00000001850CECA0
	public string weatherPattern { /* [XID] */ /* 0x00000001899B99D0-0x00000001899B99F0 */ get => default; /* [XID] */ /* 0x00000001899C1510-0x00000001899C1530 */ private set {} } // 0x00000001850CD170-0x00000001850CD210 0x00000001850CD390-0x00000001850CD440
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A442B0-0x0000000189A442D0 */ get => default; } // 0x00000001850CDF40-0x00000001850CDFE0 

	// Constructors
	public TriggerWitchTimeMixin() {} // 0x00000001850D06D0-0x00000001850D07B0

	// Methods
	// [XID] // 0x00000001899C8A80-0x00000001899C8AA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001850D0430-0x00000001850D0630
	// [XID] // 0x00000001899D0450-0x00000001899D0470
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001850CF8E0-0x00000001850CF9F0
	// [XID] // 0x00000001899D78F0-0x00000001899D7910
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5F4F */) => default; // 0x00000001850CF2B0-0x00000001850CF390
	// [XID] // 0x00000001899DED50-0x00000001899DED70
	public override int GetHashNum() => default; // 0x00000001850CD0A0-0x00000001850CD170
	// [XID] // 0x00000001899E6970-0x00000001899E6990
	public override void InitEmpty() {} // 0x00000001850CEA00-0x00000001850CEB70
	[BlackList] // 0x00000001899EDF80-0x00000001899EDFC0
	// [XID] // 0x00000001899EDF80-0x00000001899EDFC0
	public override bool FromJson(JSONNode node) => default; // 0x00000001850CDFE0-0x00000001850CE360
	// [XID] // 0x00000001899F8750-0x00000001899F8770
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001850CBF30-0x00000001850CCA00
	[BlackList] // 0x00000001899FFCC0-0x00000001899FFD00
	// [XID] // 0x00000001899FFCC0-0x00000001899FFD00
	public static new TriggerWitchTimeMixin ParseFromJson(JSONNode node) => default; // 0x00000001850CF630-0x00000001850CF880
	// [XID] // 0x0000000189A0A340-0x0000000189A0A360
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F50 */, bool useObjectPool = false /* Metadata: 0x00AF5F54 */) => default; // 0x00000001850CEED0-0x00000001850CF1D0
	// [XID] // 0x0000000189A11CC0-0x0000000189A11CE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F55 */, bool useObjectPool = false /* Metadata: 0x00AF5F59 */) => default; // 0x00000001850CD440-0x00000001850CDBE0
	// [XID] // 0x0000000189A18F90-0x0000000189A18FB0
	public static new TriggerWitchTimeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F5A */, bool useObjectPool = false /* Metadata: 0x00AF5F5E */) => default; // 0x00000001850CE3D0-0x00000001850CE5F0
	[BlackList] // 0x0000000189A206B0-0x0000000189A206F0
	// [XID] // 0x0000000189A206B0-0x0000000189A206F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001850CCA00-0x00000001850CCCD0
	// [XID] // 0x0000000189A2AAA0-0x0000000189A2AAC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001850CFB40-0x00000001850D02A0
	[BlackList] // 0x0000000189A32080-0x0000000189A320C0
	// [XID] // 0x0000000189A32080-0x0000000189A320C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001850CEDE0-0x00000001850CEED0
	// [XID] // 0x0000000189A3C820-0x0000000189A3C840
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001850CF1D0-0x00000001850CF2B0
	[BlackList] // 0x0000000189A4B820-0x0000000189A4B860
	// [XID] // 0x0000000189A4B820-0x0000000189A4B860
	public override void AutoAllocTypeFields() {} // 0x00000001850CCCD0-0x00000001850CCD70
	[BlackList] // 0x0000000189A560A0-0x0000000189A560E0
	// [XID] // 0x0000000189A560A0-0x0000000189A560E0
	public override void AutoRecycleTypeFields() {} // 0x00000001850CCD70-0x00000001850CCEA0
	[BlackList] // 0x0000000189A60920-0x0000000189A60960
	// [XID] // 0x0000000189A60920-0x0000000189A60960
	public override void ReturnToObjectPool() {} // 0x00000001850D0630-0x00000001850D06D0
}


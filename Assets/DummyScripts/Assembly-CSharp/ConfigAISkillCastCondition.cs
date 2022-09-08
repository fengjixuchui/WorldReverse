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
public class ConfigAISkillCastCondition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17496
{
	// Fields
	private SimpleSafeInt32[] _pose; // 0x10
	private bool _needReInitCD; // 0x18
	private SimpleSafeFloat minTargetAngleXZRawNum; // 0x1C
	private SimpleSafeFloat maxTargetAngleXZRawNum; // 0x20
	private SimpleSafeFloat maxTargetAngleYRawNum; // 0x24
	private SimpleSafeFloat minTargetAngleYRawNum; // 0x28
	private SimpleSafeFloat pickRangeMinRawNum; // 0x2C
	private SimpleSafeFloat pickRangeMaxRawNum; // 0x30
	private SimpleSafeFloat pickRangeYMaxRawNum; // 0x34
	private SimpleSafeFloat pickRangeYMinRawNum; // 0x38
	private SimpleSafeFloat SkillAnchorRangeMinRawNum; // 0x3C
	private SimpleSafeFloat SkillAnchorRangeMaxRawNum; // 0x40
	private SimpleSafeFloat castRangeMinRawNum; // 0x44
	private SimpleSafeFloat castRangeMaxRawNum; // 0x48
	private string[] _globalValues; // 0x50
	private bool _globalValuesLogicAnd; // 0x58

	// Properties
	public SimpleSafeInt32[] pose { /* [XID] */ /* 0x000000018993EFA0-0x000000018993EFC0 */ get => default; /* [XID] */ /* 0x0000000189717ED0-0x0000000189717EF0 */ private set {} } // 0x000000018551E010-0x000000018551E0B0 0x000000018551D7C0-0x000000018551D870
	public bool needReInitCD { /* [XID] */ /* 0x00000001899374D0-0x00000001899374F0 */ get => default; /* [XID] */ /* 0x0000000189726EC0-0x0000000189726EE0 */ private set {} } // 0x000000018551E8E0-0x000000018551E980 0x000000018551C5B0-0x000000018551C660
	public float minTargetAngleXZ { /* [XID] */ /* 0x000000018972E3F0-0x000000018972E410 */ get => default; /* [XID] */ /* 0x0000000189735B80-0x0000000189735BA0 */ private set {} } // 0x000000018551EBE0-0x000000018551ECC0 0x000000018551E800-0x000000018551E8E0
	public float maxTargetAngleXZ { /* [XID] */ /* 0x000000018973D710-0x000000018973D730 */ get => default; /* [XID] */ /* 0x0000000189744BD0-0x0000000189744BF0 */ private set {} } // 0x000000018551EA60-0x000000018551EB40 0x000000018551C900-0x000000018551C9E0
	public float maxTargetAngleY { /* [XID] */ /* 0x0000000189B09D90-0x0000000189B09DB0 */ get => default; /* [XID] */ /* 0x0000000189753B20-0x0000000189753B40 */ private set {} } // 0x000000018551C660-0x000000018551C740 0x000000018551ECC0-0x000000018551EDA0
	public float minTargetAngleY { /* [XID] */ /* 0x0000000189B987C0-0x0000000189B987E0 */ get => default; /* [XID] */ /* 0x0000000189762A70-0x0000000189762A90 */ private set {} } // 0x000000018551DE50-0x000000018551DF30 0x000000018551D6E0-0x000000018551D7C0
	public float pickRangeMin { /* [XID] */ /* 0x000000018976A0D0-0x000000018976A0F0 */ get => default; /* [XID] */ /* 0x0000000189771930-0x0000000189771950 */ private set {} } // 0x000000018551BED0-0x000000018551BFB0 0x000000018551DCD0-0x000000018551DDB0
	public float pickRangeMax { /* [XID] */ /* 0x0000000189AFB180-0x0000000189AFB1A0 */ get => default; /* [XID] */ /* 0x0000000189780780-0x00000001897807A0 */ private set {} } // 0x000000018551E290-0x000000018551E370 0x000000018551C740-0x000000018551C820
	public float pickRangeYMax { /* [XID] */ /* 0x0000000189787EE0-0x0000000189787F00 */ get => default; /* [XID] */ /* 0x000000018978F4A0-0x000000018978F4C0 */ private set {} } // 0x000000018551E370-0x000000018551E450 0x000000018551D470-0x000000018551D550
	public float pickRangeYMin { /* [XID] */ /* 0x0000000189796C90-0x0000000189796CB0 */ get => default; /* [XID] */ /* 0x000000018979EDF0-0x000000018979EE10 */ private set {} } // 0x000000018551E980-0x000000018551EA60 0x000000018551C4D0-0x000000018551C5B0
	public float SkillAnchorRangeMin { /* [XID] */ /* 0x00000001897A63A0-0x00000001897A63C0 */ get => default; /* [XID] */ /* 0x00000001897AD890-0x00000001897AD8B0 */ private set {} } // 0x000000018551C9E0-0x000000018551CAC0 0x000000018551D550-0x000000018551D630
	public float SkillAnchorRangeMax { /* [XID] */ /* 0x0000000189A65C20-0x0000000189A65C40 */ get => default; /* [XID] */ /* 0x00000001897BD6E0-0x00000001897BD700 */ private set {} } // 0x000000018551C820-0x000000018551C900 0x000000018551F800-0x000000018551F8E0
	public float castRangeMin { /* [XID] */ /* 0x0000000189A5E3C0-0x0000000189A5E3E0 */ get => default; /* [XID] */ /* 0x00000001897CC350-0x00000001897CC370 */ private set {} } // 0x000000018551D870-0x000000018551D950 0x000000018551FCA0-0x000000018551FD80
	public float castRangeMax { /* [XID] */ /* 0x00000001897D3C80-0x00000001897D3CA0 */ get => default; /* [XID] */ /* 0x00000001897DB650-0x00000001897DB670 */ private set {} } // 0x000000018551FD80-0x000000018551FE60 0x000000018551DF30-0x000000018551E010
	public string[] globalValues { /* [XID] */ /* 0x00000001897E2DC0-0x00000001897E2DE0 */ get => default; /* [XID] */ /* 0x00000001897EA620-0x00000001897EA640 */ private set {} } // 0x000000018551DDB0-0x000000018551DE50 0x000000018551E750-0x000000018551E800
	public bool globalValuesLogicAnd { /* [XID] */ /* 0x0000000189BB2F80-0x0000000189BB2FA0 */ get => default; /* [XID] */ /* 0x00000001897F99A0-0x00000001897F99C0 */ private set {} } // 0x000000018551EB40-0x000000018551EBE0 0x000000018551D630-0x000000018551D6E0

	// Constructors
	public ConfigAISkillCastCondition() {} // 0x000000018551FF00-0x0000000185520060

	// Methods
	// [XID] // 0x0000000189800F00-0x0000000189800F20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018551F8E0-0x000000018551FB60
	// [XID] // 0x00000001898083A0-0x00000001898083C0
	public void InitEmpty() {} // 0x000000018551E0B0-0x000000018551E290
	[BlackList] // 0x000000018980FED0-0x000000018980FF10
	// [XID] // 0x000000018980FED0-0x000000018980FF10
	public bool FromJson(JSONNode node) => default; // 0x000000018551D950-0x000000018551DCD0
	// [XID] // 0x000000018981A6A0-0x000000018981A6C0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018551AEE0-0x000000018551BED0
	// [XID] // 0x0000000189821E90-0x0000000189821EB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70A9 */, bool useObjectPool = false /* Metadata: 0x00AF70AD */) => default; // 0x000000018551E450-0x000000018551E750
	// [XID] // 0x0000000189829370-0x0000000189829390
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70AE */, bool useObjectPool = false /* Metadata: 0x00AF70B2 */) => default; // 0x000000018551CAC0-0x000000018551D470
	[BlackList] // 0x0000000189830A00-0x0000000189830A40
	// [XID] // 0x0000000189830A00-0x0000000189830A40
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018551BFB0-0x000000018551C280
	// [XID] // 0x000000018983AFC0-0x000000018983AFE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018551EDA0-0x000000018551F800
	[BlackList] // 0x00000001898427E0-0x0000000189842820
	// [XID] // 0x00000001898427E0-0x0000000189842820
	public virtual void AutoAllocTypeFields() {} // 0x000000018551C280-0x000000018551C320
	[BlackList] // 0x000000018984CB60-0x000000018984CBA0
	// [XID] // 0x000000018984CB60-0x000000018984CBA0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018551C320-0x000000018551C4D0
	[BlackList] // 0x0000000189856C40-0x0000000189856C80
	// [XID] // 0x0000000189856C40-0x0000000189856C80
	public virtual void ReturnToObjectPool() {} // 0x000000018551FE60-0x000000018551FF00
	[BlackList] // 0x00000001898610F0-0x0000000189861130
	// [XID] // 0x00000001898610F0-0x0000000189861130
	public virtual void OnPoolAllocated() {} // 0x000000018551FC00-0x000000018551FCA0
	[BlackList] // 0x000000018986B900-0x000000018986B940
	// [XID] // 0x000000018986B900-0x000000018986B940
	public virtual void OnBeforePoolRecycled() {} // 0x000000018551FB60-0x000000018551FC00
}


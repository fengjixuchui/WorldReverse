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
public class ConfigAITSAbilityGlobalValueSetting : ConfigAIThreatScoreBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17391
{
	// Fields
	private string _caredGlobalValueName; // 0x30

	// Properties
	public string caredGlobalValueName { /* [XID] */ /* 0x00000001896C4F50-0x00000001896C4F70 */ get => default; /* [XID] */ /* 0x00000001896CC4F0-0x00000001896CC510 */ private set {} } // 0x0000000181204570-0x0000000181204610 0x0000000181203DB0-0x0000000181203E60

	// Constructors
	public ConfigAITSAbilityGlobalValueSetting() {} // 0x0000000181205F10-0x0000000181205F70

	// Methods
	// [XID] // 0x00000001896D36E0-0x00000001896D3700
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181205C80-0x0000000181205D70
	// [XID] // 0x00000001896DB1E0-0x00000001896DB200
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001812059A0-0x0000000181205A80
	// [XID] // 0x00000001896E2960-0x00000001896E2980
	public override ConfigAIThreatScoreBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6CF3 */) => default; // 0x00000001812055B0-0x0000000181205690
	// [XID] // 0x00000001896E9F20-0x00000001896E9F40
	public override int GetHashNum() => default; // 0x0000000181204440-0x0000000181204510
	// [XID] // 0x00000001896F1000-0x00000001896F1020
	public override void InitEmpty() {} // 0x0000000181205010-0x00000001812050E0
	[BlackList] // 0x00000001896F8860-0x00000001896F88A0
	// [XID] // 0x00000001896F8860-0x00000001896F88A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181204A00-0x0000000181204D80
	// [XID] // 0x00000001897031F0-0x0000000189703210
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181203B80-0x0000000181203DB0
	[BlackList] // 0x000000018970A8E0-0x000000018970A920
	// [XID] // 0x000000018970A8E0-0x000000018970A920
	public static new ConfigAITSAbilityGlobalValueSetting ParseFromJson(JSONNode node) => default; // 0x00000001812056F0-0x0000000181205940
	// [XID] // 0x0000000189714D70-0x0000000189714D90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6CF4 */, bool useObjectPool = false /* Metadata: 0x00AF6CF8 */) => default; // 0x00000001812052B0-0x00000001812055B0
	// [XID] // 0x000000018971C840-0x000000018971C860
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6CF9 */, bool useObjectPool = false /* Metadata: 0x00AF6CFD */) => default; // 0x0000000181204690-0x0000000181204900
	// [XID] // 0x0000000189723CD0-0x0000000189723CF0
	public static new ConfigAITSAbilityGlobalValueSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6CFE */, bool useObjectPool = false /* Metadata: 0x00AF6D02 */) => default; // 0x0000000181204D80-0x0000000181204FA0
	[BlackList] // 0x000000018972B3F0-0x000000018972B430
	// [XID] // 0x000000018972B3F0-0x000000018972B430
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181203E60-0x0000000181204130
	// [XID] // 0x0000000189735BC0-0x0000000189735BE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181205A80-0x0000000181205C80
	[BlackList] // 0x000000018973D7B0-0x000000018973D7F0
	// [XID] // 0x000000018973D7B0-0x000000018973D7F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001812051C0-0x00000001812052B0
	[BlackList] // 0x0000000189747E60-0x0000000189747EA0
	// [XID] // 0x0000000189747E60-0x0000000189747EA0
	public override void AutoAllocTypeFields() {} // 0x00000001812041D0-0x0000000181204270
	[BlackList] // 0x0000000189752330-0x0000000189752370
	// [XID] // 0x0000000189752330-0x0000000189752370
	public override void AutoRecycleTypeFields() {} // 0x0000000181204270-0x0000000181204320
	[BlackList] // 0x000000018975C950-0x000000018975C990
	// [XID] // 0x000000018975C950-0x000000018975C990
	public override void ReturnToObjectPool() {} // 0x0000000181205E70-0x0000000181205F10
	// [XID] // 0x0000000189767240-0x0000000189767260
	public override float CalculateScore(AIKnowledge aiKnowledge, ThreatInfo threatInfo, ThreadRuntimeInfo threatRuntimeInfo) => default; // 0x0000000181205D70-0x0000000181205E70
}


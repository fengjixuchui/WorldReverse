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
public class ModifyAbility : ConfigTalentMixin, IAutoAllocRecycle // TypeDefIndex: 19042
{
	// Fields
	private string _abilityName; // 0x10
	private string _paramSpecial; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicArgument _paramDelta; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicArgument _paramRatio; // 0x28

	// Properties
	public string abilityName { /* [XID] */ /* 0x0000000189ABC4C0-0x0000000189ABC4E0 */ get => default; /* [XID] */ /* 0x0000000189AC3DE0-0x0000000189AC3E00 */ private set {} } // 0x0000000183A7F5A0-0x0000000183A7F640 0x0000000183A800A0-0x0000000183A80150
	public string paramSpecial { /* [XID] */ /* 0x0000000189ACB1A0-0x0000000189ACB1C0 */ get => default; /* [XID] */ /* 0x0000000189AD2CC0-0x0000000189AD2CE0 */ private set {} } // 0x0000000183A7EF20-0x0000000183A7EFC0 0x0000000183A7FA90-0x0000000183A7FB40
	public DynamicArgument paramDelta { /* [XID] */ /* 0x0000000189ADA6E0-0x0000000189ADA700 */ get => default; /* [XID] */ /* 0x0000000189AE1F80-0x0000000189AE1FA0 */ private set {} } // 0x0000000183A7E7F0-0x0000000183A7E890 0x0000000183A7E740-0x0000000183A7E7F0
	public DynamicArgument paramRatio { /* [XID] */ /* 0x0000000189AE9770-0x0000000189AE9790 */ get => default; /* [XID] */ /* 0x0000000189AF15D0-0x0000000189AF15F0 */ private set {} } // 0x0000000183A7E010-0x0000000183A7E0B0 0x0000000183A7DF60-0x0000000183A7E010

	// Constructors
	public ModifyAbility() {} // 0x0000000183A80360-0x0000000183A803C0

	// Methods
	// [XID] // 0x0000000189AF8BA0-0x0000000189AF8BC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A80150-0x0000000183A802C0
	// [XID] // 0x0000000189B000F0-0x0000000189B00110
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183A7FBA0-0x0000000183A7FCD0
	// [XID] // 0x0000000189B076D0-0x0000000189B076F0
	public override ConfigTalentMixin Clone(bool useObjectPool = false /* Metadata: 0x00AFB879 */) => default; // 0x0000000183A7F700-0x0000000183A7F7E0
	// [XID] // 0x0000000189B0EEF0-0x0000000189B0EF10
	public override int GetHashNum() => default; // 0x0000000183A7DE90-0x0000000183A7DF60
	// [XID] // 0x0000000189B16210-0x0000000189B16230
	public override void InitEmpty() {} // 0x0000000183A7EFC0-0x0000000183A7F0D0
	[BlackList] // 0x0000000189B1D8F0-0x0000000189B1D930
	// [XID] // 0x0000000189B1D8F0-0x0000000189B1D930
	public override bool FromJson(JSONNode node) => default; // 0x0000000183A7E890-0x0000000183A7EC10
	// [XID] // 0x0000000189B27FF0-0x0000000189B28010
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183A7D370-0x0000000183A7D860
	[BlackList] // 0x0000000189B2F350-0x0000000189B2F390
	// [XID] // 0x0000000189B2F350-0x0000000189B2F390
	public static new ModifyAbility ParseFromJson(JSONNode node) => default; // 0x0000000183A7F840-0x0000000183A7FA90
	// [XID] // 0x0000000189B39DF0-0x0000000189B39E10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB87A */, bool useObjectPool = false /* Metadata: 0x00AFB87E */) => default; // 0x0000000183A7F2A0-0x0000000183A7F5A0
	// [XID] // 0x0000000189B41750-0x0000000189B41770
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB87F */, bool useObjectPool = false /* Metadata: 0x00AFB883 */) => default; // 0x0000000183A7E190-0x0000000183A7E640
	// [XID] // 0x0000000189B490E0-0x0000000189B49100
	public static new ModifyAbility ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB884 */, bool useObjectPool = false /* Metadata: 0x00AFB888 */) => default; // 0x0000000183A7EC10-0x0000000183A7EE30
	[BlackList] // 0x0000000189B506C0-0x0000000189B50700
	// [XID] // 0x0000000189B506C0-0x0000000189B50700
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A7D860-0x0000000183A7DB30
	// [XID] // 0x0000000189B5AEB0-0x0000000189B5AED0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A7FCD0-0x0000000183A800A0
	[BlackList] // 0x0000000189B62310-0x0000000189B62350
	// [XID] // 0x0000000189B62310-0x0000000189B62350
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183A7F1B0-0x0000000183A7F2A0
	// [XID] // 0x0000000189B6CB60-0x0000000189B6CB80
	public override BaseTalentMixin CreateInstancedMixin(ActorTalent instancedTalent) => default; // 0x0000000183A7F640-0x0000000183A7F700
	[BlackList] // 0x0000000189B74330-0x0000000189B74370
	// [XID] // 0x0000000189B74330-0x0000000189B74370
	public override void AutoAllocTypeFields() {} // 0x0000000183A7DB30-0x0000000183A7DBD0
	[BlackList] // 0x0000000189B7E780-0x0000000189B7E7C0
	// [XID] // 0x0000000189B7E780-0x0000000189B7E7C0
	public override void AutoRecycleTypeFields() {} // 0x0000000183A7DBD0-0x0000000183A7DD70
	[BlackList] // 0x0000000189B88FD0-0x0000000189B89010
	// [XID] // 0x0000000189B88FD0-0x0000000189B89010
	public override void ReturnToObjectPool() {} // 0x0000000183A802C0-0x0000000183A80360
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAISpacialChaseSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17465
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISpacialChaseData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAISpacialChaseData> _specification; // 0x30

	// Properties
	public ConfigAISpacialChaseData defaultSetting { /* [XID] */ /* 0x0000000189646040-0x0000000189646060 */ get => default; /* [XID] */ /* 0x000000018964D880-0x000000018964D8A0 */ private set {} } // 0x000000018223AB80-0x000000018223AC20 0x00000001822389C0-0x0000000182238A70
	public Dictionary<SimpleSafeInt32, ConfigAISpacialChaseData> specification { /* [XID] */ /* 0x0000000189655020-0x0000000189655040 */ get => default; /* [XID] */ /* 0x000000018965C8A0-0x000000018965C8C0 */ private set {} } // 0x0000000182239070-0x0000000182239110 0x000000018223A5E0-0x000000018223A690

	// Constructors
	public ConfigAISpacialChaseSetting() {} // 0x000000018223B0C0-0x000000018223B140

	// Methods
	// [XID] // 0x0000000189663E00-0x0000000189663E20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018223AF00-0x000000018223B020
	// [XID] // 0x000000018966B540-0x000000018966B560
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018223AA80-0x000000018223AB80
	// [XID] // 0x0000000189673280-0x00000001896732A0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6F85 */) => default; // 0x000000018223A690-0x000000018223A770
	// [XID] // 0x000000018967A9A0-0x000000018967A9C0
	public override int GetHashNum() => default; // 0x0000000182239420-0x00000001822394F0
	// [XID] // 0x0000000189682230-0x0000000189682250
	public override void InitEmpty() {} // 0x000000018223A020-0x000000018223A110
	[BlackList] // 0x0000000189689C30-0x0000000189689C70
	// [XID] // 0x0000000189689C30-0x0000000189689C70
	public override bool FromJson(JSONNode node) => default; // 0x0000000182239A10-0x0000000182239D90
	// [XID] // 0x0000000189694800-0x0000000189694820
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182238A70-0x0000000182238DA0
	[BlackList] // 0x000000018969BE80-0x000000018969BEC0
	// [XID] // 0x000000018969BE80-0x000000018969BEC0
	public static new ConfigAISpacialChaseSetting ParseFromJson(JSONNode node) => default; // 0x000000018223A7D0-0x000000018223AA20
	// [XID] // 0x00000001896A61F0-0x00000001896A6210
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F86 */, bool useObjectPool = false /* Metadata: 0x00AF6F8A */) => default; // 0x000000018223A2E0-0x000000018223A5E0
	// [XID] // 0x00000001896AD690-0x00000001896AD6B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F8B */, bool useObjectPool = false /* Metadata: 0x00AF6F8F */) => default; // 0x00000001822395D0-0x0000000182239910
	// [XID] // 0x00000001896B4DF0-0x00000001896B4E10
	public static new ConfigAISpacialChaseSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F90 */, bool useObjectPool = false /* Metadata: 0x00AF6F94 */) => default; // 0x0000000182239D90-0x0000000182239FB0
	[BlackList] // 0x00000001896BC100-0x00000001896BC140
	// [XID] // 0x00000001896BC100-0x00000001896BC140
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182238DA0-0x0000000182239070
	// [XID] // 0x00000001896C66D0-0x00000001896C66F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018223AC20-0x000000018223AF00
	[BlackList] // 0x00000001896CDC10-0x00000001896CDC50
	// [XID] // 0x00000001896CDC10-0x00000001896CDC50
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018223A1F0-0x000000018223A2E0
	[BlackList] // 0x00000001896D80F0-0x00000001896D8130
	// [XID] // 0x00000001896D80F0-0x00000001896D8130
	public override void AutoAllocTypeFields() {} // 0x0000000182239110-0x00000001822391B0
	[BlackList] // 0x00000001896E28C0-0x00000001896E2900
	// [XID] // 0x00000001896E28C0-0x00000001896E2900
	public override void AutoRecycleTypeFields() {} // 0x00000001822391B0-0x0000000182239300
	[BlackList] // 0x00000001896ECC60-0x00000001896ECCA0
	// [XID] // 0x00000001896ECC60-0x00000001896ECCA0
	public override void ReturnToObjectPool() {} // 0x000000018223B020-0x000000018223B0C0
}


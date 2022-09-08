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
public class ConfigGuideFinishQuestAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18340
{
	// Fields
	private SimpleSafeUInt32 questIDRawNum; // 0x18

	// Properties
	public uint questID { /* [XID] */ /* 0x0000000189BB80E0-0x0000000189BB8100 */ get => default; /* [XID] */ /* 0x0000000189BBF7F0-0x0000000189BBF810 */ private set {} } // 0x000000018197E710-0x000000018197E7E0 0x000000018197E630-0x000000018197E710

	// Constructors
	public ConfigGuideFinishQuestAction() {} // 0x000000018197EC20-0x000000018197EC80

	// Methods
	// [XID] // 0x0000000189BC7400-0x0000000189BC7420
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018197EA90-0x000000018197EB80
	// [XID] // 0x0000000189BCF0F0-0x0000000189BCF110
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018197E580-0x000000018197E630
	// [XID] // 0x0000000189BD6480-0x0000000189BD64A0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF949B */) => default; // 0x000000018197E190-0x000000018197E270
	// [XID] // 0x0000000189BDDFA0-0x0000000189BDDFC0
	public override int GetHashNum() => default; // 0x000000018197CF50-0x000000018197D020
	// [XID] // 0x00000001895EAB70-0x00000001895EAB90
	public override void InitEmpty() {} // 0x000000018197DB80-0x000000018197DC50
	[BlackList] // 0x00000001895F1FF0-0x00000001895F2030
	// [XID] // 0x00000001895F1FF0-0x00000001895F2030
	public override bool FromJson(JSONNode node) => default; // 0x000000018197D570-0x000000018197D8F0
	// [XID] // 0x00000001895FC7F0-0x00000001895FC810
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018197C780-0x000000018197C9E0
	[BlackList] // 0x0000000189604190-0x00000001896041D0
	// [XID] // 0x0000000189604190-0x00000001896041D0
	public static new ConfigGuideFinishQuestAction ParseFromJson(JSONNode node) => default; // 0x000000018197E2D0-0x000000018197E520
	// [XID] // 0x000000018960E900-0x000000018960E920
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF949C */, bool useObjectPool = false /* Metadata: 0x00AF94A0 */) => default; // 0x000000018197DE90-0x000000018197E190
	// [XID] // 0x0000000189615FA0-0x0000000189615FC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF94A1 */, bool useObjectPool = false /* Metadata: 0x00AF94A5 */) => default; // 0x000000018197D200-0x000000018197D470
	// [XID] // 0x000000018961D7F0-0x000000018961D810
	public static new ConfigGuideFinishQuestAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF94A6 */, bool useObjectPool = false /* Metadata: 0x00AF94AA */) => default; // 0x000000018197D8F0-0x000000018197DB10
	[BlackList] // 0x0000000189624C10-0x0000000189624C50
	// [XID] // 0x0000000189624C10-0x0000000189624C50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018197C9E0-0x000000018197CCB0
	// [XID] // 0x000000018962F600-0x000000018962F620
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018197E860-0x000000018197EA90
	[BlackList] // 0x00000001896371A0-0x00000001896371E0
	// [XID] // 0x00000001896371A0-0x00000001896371E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018197DDA0-0x000000018197DE90
	// [XID] // 0x0000000189641540-0x0000000189641560
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x000000018197D100-0x000000018197D200
	// [XID] // 0x0000000189648F40-0x0000000189648F60
	protected override bool Stop() => default; // 0x000000018197C6E0-0x000000018197C780
	[BlackList] // 0x0000000189650530-0x0000000189650570
	// [XID] // 0x0000000189650530-0x0000000189650570
	public override void AutoAllocTypeFields() {} // 0x000000018197CCB0-0x000000018197CD50
	[BlackList] // 0x000000018965ADB0-0x000000018965ADF0
	// [XID] // 0x000000018965ADB0-0x000000018965ADF0
	public override void AutoRecycleTypeFields() {} // 0x000000018197CD50-0x000000018197CE30
	[BlackList] // 0x0000000189665350-0x0000000189665390
	// [XID] // 0x0000000189665350-0x0000000189665390
	public override void ReturnToObjectPool() {} // 0x000000018197EB80-0x000000018197EC20
}


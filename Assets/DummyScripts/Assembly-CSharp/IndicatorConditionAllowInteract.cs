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
public class IndicatorConditionAllowInteract : IndicatorCondition, IAutoAllocRecycle // TypeDefIndex: 18481
{
	// Fields
	private bool _allowInteract; // 0x10

	// Properties
	public bool allowInteract { /* [XID] */ /* 0x0000000189948A40-0x0000000189948A60 */ get => default; /* [XID] */ /* 0x00000001899501F0-0x0000000189950210 */ private set {} } // 0x0000000180CB1860-0x0000000180CB1900 0x0000000180CB1900-0x0000000180CB19B0

	// Constructors
	public IndicatorConditionAllowInteract() {} // 0x0000000180CB3200-0x0000000180CB3260

	// Methods
	// [XID] // 0x00000001899576C0-0x00000001899576E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180CB2F60-0x0000000180CB3050
	// [XID] // 0x000000018995F110-0x000000018995F130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000180CB2B70-0x0000000180CB2C20
	// [XID] // 0x0000000189966990-0x00000001899669B0
	public override IndicatorCondition Clone(bool useObjectPool = false /* Metadata: 0x00AF9EDD */) => default; // 0x0000000180CB26F0-0x0000000180CB27D0
	// [XID] // 0x000000018996DD60-0x000000018996DD80
	public override int GetHashNum() => default; // 0x0000000180CB1480-0x0000000180CB1550
	// [XID] // 0x0000000189975970-0x0000000189975990
	public override void InitEmpty() {} // 0x0000000180CB20C0-0x0000000180CB2160
	[BlackList] // 0x000000018997CA10-0x000000018997CA50
	// [XID] // 0x000000018997CA10-0x000000018997CA50
	public override bool FromJson(JSONNode node) => default; // 0x0000000180CB1AB0-0x0000000180CB1E30
	// [XID] // 0x0000000189987750-0x0000000189987770
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000180CB0D40-0x0000000180CB0F40
	[BlackList] // 0x000000018998F3A0-0x000000018998F3E0
	// [XID] // 0x000000018998F3A0-0x000000018998F3E0
	public static new IndicatorConditionAllowInteract ParseFromJson(JSONNode node) => default; // 0x0000000180CB28C0-0x0000000180CB2B10
	// [XID] // 0x000000018999A230-0x000000018999A250
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EDE */, bool useObjectPool = false /* Metadata: 0x00AF9EE2 */) => default; // 0x0000000180CB23F0-0x0000000180CB26F0
	// [XID] // 0x00000001899A18D0-0x00000001899A18F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EE3 */, bool useObjectPool = false /* Metadata: 0x00AF9EE7 */) => default; // 0x0000000180CB1630-0x0000000180CB1860
	// [XID] // 0x00000001899A9140-0x00000001899A9160
	public static new IndicatorConditionAllowInteract ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EE8 */, bool useObjectPool = false /* Metadata: 0x00AF9EEC */) => default; // 0x0000000180CB1E30-0x0000000180CB2050
	[BlackList] // 0x00000001899B0C70-0x00000001899B0CB0
	// [XID] // 0x00000001899B0C70-0x00000001899B0CB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000180CB0F40-0x0000000180CB1210
	// [XID] // 0x00000001899BAFD0-0x00000001899BAFF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180CB2C20-0x0000000180CB2E20
	[BlackList] // 0x00000001899C2980-0x00000001899C29C0
	// [XID] // 0x00000001899C2980-0x00000001899C29C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000180CB2300-0x0000000180CB23F0
	// [XID] // 0x00000001899CD0B0-0x00000001899CD0D0
	public override bool Register(LCIndicatorPlugin plugin, int state, int index, LCIndicatorPlugin.DominatorCondition condition) => default; // 0x0000000180CB2E20-0x0000000180CB2F60
	// [XID] // 0x00000001899D4650-0x00000001899D4670
	public override bool OnTriggered(LCIndicatorPlugin plugin, int state, BaseEvent fromEvent) => default; // 0x0000000180CB3050-0x0000000180CB3160
	[BlackList] // 0x00000001899DBCD0-0x00000001899DBD10
	// [XID] // 0x00000001899DBCD0-0x00000001899DBD10
	public override void AutoAllocTypeFields() {} // 0x0000000180CB1210-0x0000000180CB12B0
	[BlackList] // 0x00000001899E66F0-0x00000001899E6730
	// [XID] // 0x00000001899E66F0-0x00000001899E6730
	public override void AutoRecycleTypeFields() {} // 0x0000000180CB12B0-0x0000000180CB1360
	[BlackList] // 0x00000001899F0B30-0x00000001899F0B70
	// [XID] // 0x00000001899F0B30-0x00000001899F0B70
	public override void ReturnToObjectPool() {} // 0x0000000180CB3160-0x0000000180CB3200
}


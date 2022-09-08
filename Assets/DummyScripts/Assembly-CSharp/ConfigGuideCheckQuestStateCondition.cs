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
public class ConfigGuideCheckQuestStateCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18256
{
	// Fields
	private SimpleSafeUInt32 questIdRawNum; // 0x20
	private SimpleSafeUInt32 questStateRawNum; // 0x24
	private bool _isEqual; // 0x28

	// Properties
	public uint questId { /* [XID] */ /* 0x000000018990CD10-0x000000018990CD30 */ get => default; /* [XID] */ /* 0x00000001899144C0-0x00000001899144E0 */ private set {} } // 0x000000018304D090-0x000000018304D160 0x000000018304D950-0x000000018304DA30
	public uint questState { /* [XID] */ /* 0x000000018991C040-0x000000018991C060 */ get => default; /* [XID] */ /* 0x0000000189923720-0x0000000189923740 */ private set {} } // 0x000000018304E820-0x000000018304E8F0 0x000000018304E740-0x000000018304E820
	public bool isEqual { /* [XID] */ /* 0x000000018992ADE0-0x000000018992AE00 */ get => default; /* [XID] */ /* 0x0000000189932400-0x0000000189932420 */ private set {} } // 0x000000018304D310-0x000000018304D3B0 0x000000018304E8F0-0x000000018304E9A0

	// Constructors
	public ConfigGuideCheckQuestStateCondition() {} // 0x000000018304EEE0-0x000000018304EF50

	// Methods
	// [XID] // 0x0000000189939E10-0x0000000189939E30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018304ED10-0x000000018304EE40
	// [XID] // 0x0000000189941000-0x0000000189941020
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018304E610-0x000000018304E6C0
	// [XID] // 0x0000000189948AC0-0x0000000189948AE0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF91B3 */) => default; // 0x000000018304E220-0x000000018304E300
	// [XID] // 0x0000000189950230-0x0000000189950250
	public override int GetHashNum() => default; // 0x000000018304CB60-0x000000018304CC30
	// [XID] // 0x0000000189957780-0x00000001899577A0
	public override void InitEmpty() {} // 0x000000018304DC70-0x000000018304DD50
	[BlackList] // 0x000000018995F150-0x000000018995F190
	// [XID] // 0x000000018995F150-0x000000018995F190
	public override bool FromJson(JSONNode node) => default; // 0x000000018304D3B0-0x000000018304D730
	// [XID] // 0x0000000189969800-0x0000000189969820
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018304C1B0-0x000000018304C5E0
	[BlackList] // 0x0000000189971520-0x0000000189971560
	// [XID] // 0x0000000189971520-0x0000000189971560
	public static new ConfigGuideCheckQuestStateCondition ParseFromJson(JSONNode node) => default; // 0x000000018304E360-0x000000018304E5B0
	// [XID] // 0x000000018997B8E0-0x000000018997B900
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91B4 */, bool useObjectPool = false /* Metadata: 0x00AF91B8 */) => default; // 0x000000018304DF20-0x000000018304E220
	// [XID] // 0x0000000189983410-0x0000000189983430
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91B9 */, bool useObjectPool = false /* Metadata: 0x00AF91BD */) => default; // 0x000000018304CD10-0x000000018304D090
	// [XID] // 0x000000018998AC00-0x000000018998AC20
	public static new ConfigGuideCheckQuestStateCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91BE */, bool useObjectPool = false /* Metadata: 0x00AF91C2 */) => default; // 0x000000018304D730-0x000000018304D950
	[BlackList] // 0x00000001899924B0-0x00000001899924F0
	// [XID] // 0x00000001899924B0-0x00000001899924F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018304C5E0-0x000000018304C8B0
	// [XID] // 0x000000018999D050-0x000000018999D070
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018304E9A0-0x000000018304ED10
	[BlackList] // 0x00000001899A49B0-0x00000001899A49F0
	// [XID] // 0x00000001899A49B0-0x00000001899A49F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018304DE30-0x000000018304DF20
	// [XID] // 0x00000001899AF310-0x00000001899AF330
	protected override bool Prepare(GuideManager manager) => default; // 0x000000018304D260-0x000000018304D310
	// [XID] // 0x00000001899B6710-0x00000001899B6730
	public override bool Ready(object body = null) => default; // 0x000000018304DAA0-0x000000018304DBF0
	[BlackList] // 0x00000001899BE310-0x00000001899BE350
	// [XID] // 0x00000001899BE310-0x00000001899BE350
	public override void AutoAllocTypeFields() {} // 0x000000018304C8B0-0x000000018304C950
	[BlackList] // 0x00000001899C8820-0x00000001899C8860
	// [XID] // 0x00000001899C8820-0x00000001899C8860
	public override void AutoRecycleTypeFields() {} // 0x000000018304C950-0x000000018304CA40
	[BlackList] // 0x00000001899D2F90-0x00000001899D2FD0
	// [XID] // 0x00000001899D2F90-0x00000001899D2FD0
	public override void ReturnToObjectPool() {} // 0x000000018304EE40-0x000000018304EEE0
}


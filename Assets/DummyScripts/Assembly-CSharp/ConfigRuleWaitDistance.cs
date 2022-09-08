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
public class ConfigRuleWaitDistance : ConfigAudioEventCullingRuleBase, IAutoAllocRecycle // TypeDefIndex: 17575
{
	// Fields
	private SimpleSafeFloat distanceRawNum; // 0x10
	private SimpleSafeInt32 recheckFrameRawNum; // 0x14

	// Properties
	public float distance { /* [XID] */ /* 0x00000001898D3570-0x00000001898D3590 */ get => default; /* [XID] */ /* 0x00000001898DACC0-0x00000001898DACE0 */ private set {} } // 0x0000000182514330-0x0000000182514410 0x00000001825160B0-0x0000000182516190
	public int recheckFrame { /* [XID] */ /* 0x00000001898E2B20-0x00000001898E2B40 */ get => default; /* [XID] */ /* 0x00000001898EA6F0-0x00000001898EA710 */ private set {} } // 0x00000001825167B0-0x0000000182516880 0x0000000182515FD0-0x00000001825160B0

	// Constructors
	public ConfigRuleWaitDistance() {} // 0x0000000182516A30-0x0000000182516AC0

	// Methods
	// [XID] // 0x00000001898F1D70-0x00000001898F1D90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182516880-0x0000000182516990
	// [XID] // 0x00000001898F95B0-0x00000001898F95D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182516440-0x00000001825164F0
	// [XID] // 0x0000000189900F90-0x0000000189900FB0
	public override ConfigAudioEventCullingRuleBase Clone(bool useObjectPool = false /* Metadata: 0x00AF736B */) => default; // 0x0000000182515E90-0x0000000182515F70
	// [XID] // 0x00000001899087D0-0x00000001899087F0
	public override int GetHashNum() => default; // 0x0000000182514D20-0x0000000182514DF0
	// [XID] // 0x000000018990FDB0-0x000000018990FDD0
	public override void InitEmpty() {} // 0x00000001825158C0-0x00000001825159C0
	[BlackList] // 0x0000000189917960-0x00000001899179A0
	// [XID] // 0x0000000189917960-0x00000001899179A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001825152B0-0x0000000182515630
	// [XID] // 0x0000000189922160-0x0000000189922180
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182514410-0x0000000182514780
	[BlackList] // 0x0000000189929920-0x0000000189929960
	// [XID] // 0x0000000189929920-0x0000000189929960
	public static new ConfigRuleWaitDistance ParseFromJson(JSONNode node) => default; // 0x0000000182516190-0x00000001825163E0
	// [XID] // 0x0000000189933C60-0x0000000189933C80
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF736C */, bool useObjectPool = false /* Metadata: 0x00AF7370 */) => default; // 0x0000000182515B90-0x0000000182515E90
	// [XID] // 0x000000018993B8B0-0x000000018993B8D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7371 */, bool useObjectPool = false /* Metadata: 0x00AF7375 */) => default; // 0x0000000182514ED0-0x00000001825151B0
	// [XID] // 0x0000000189942990-0x00000001899429B0
	public static new ConfigRuleWaitDistance ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7376 */, bool useObjectPool = false /* Metadata: 0x00AF737A */) => default; // 0x0000000182515630-0x0000000182515850
	[BlackList] // 0x000000018994A1A0-0x000000018994A1E0
	// [XID] // 0x000000018994A1A0-0x000000018994A1E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182514780-0x0000000182514A50
	// [XID] // 0x0000000189954820-0x0000000189954840
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825164F0-0x00000001825167B0
	[BlackList] // 0x000000018995C0E0-0x000000018995C120
	// [XID] // 0x000000018995C0E0-0x000000018995C120
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182515AA0-0x0000000182515B90
	[BlackList] // 0x0000000189966B70-0x0000000189966BB0
	// [XID] // 0x0000000189966B70-0x0000000189966BB0
	public override void AutoAllocTypeFields() {} // 0x0000000182514A50-0x0000000182514AF0
	[BlackList] // 0x0000000189971720-0x0000000189971760
	// [XID] // 0x0000000189971720-0x0000000189971760
	public override void AutoRecycleTypeFields() {} // 0x0000000182514AF0-0x0000000182514C00
	[BlackList] // 0x000000018997BA00-0x000000018997BA40
	// [XID] // 0x000000018997BA00-0x000000018997BA40
	public override void ReturnToObjectPool() {} // 0x0000000182516990-0x0000000182516A30
}


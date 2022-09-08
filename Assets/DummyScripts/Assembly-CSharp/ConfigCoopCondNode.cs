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
public class ConfigCoopCondNode : ConfigCoopBaseNode, IAutoAllocRecycle // TypeDefIndex: 17751
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private CoopCondGroup _coopCondGrp; // 0x20

	// Properties
	public CoopCondGroup coopCondGrp { /* [XID] */ /* 0x0000000189B430D0-0x0000000189B430F0 */ get => default; /* [XID] */ /* 0x0000000189B4A8F0-0x0000000189B4A910 */ private set {} } // 0x0000000182548310-0x00000001825483B0 0x0000000182547CA0-0x0000000182547D50

	// Constructors
	public ConfigCoopCondNode() {} // 0x0000000182548530-0x0000000182548590

	// Methods
	// [XID] // 0x0000000189B52040-0x0000000189B52060
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001825483B0-0x0000000182548490
	// [XID] // 0x0000000189B59960-0x0000000189B59980
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182548000-0x00000001825480E0
	// [XID] // 0x0000000189B61170-0x0000000189B61190
	public override ConfigCoopBaseNode Clone(bool useObjectPool = false /* Metadata: 0x00AF7AE5 */) => default; // 0x0000000182547B60-0x0000000182547C40
	// [XID] // 0x0000000189B68920-0x0000000189B68940
	public override int GetHashNum() => default; // 0x0000000182546A60-0x0000000182546B30
	// [XID] // 0x0000000189B6FE40-0x0000000189B6FE60
	public override void InitEmpty() {} // 0x00000001825475C0-0x0000000182547690
	[BlackList] // 0x0000000189B772B0-0x0000000189B772F0
	// [XID] // 0x0000000189B772B0-0x0000000189B772F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182546FB0-0x0000000182547330
	// [XID] // 0x0000000189B81BB0-0x0000000189B81BD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182546260-0x00000001825464A0
	[BlackList] // 0x0000000189B892B0-0x0000000189B892F0
	// [XID] // 0x0000000189B892B0-0x0000000189B892F0
	public static new ConfigCoopCondNode ParseFromJson(JSONNode node) => default; // 0x0000000182547D50-0x0000000182547FA0
	// [XID] // 0x0000000189B93610-0x0000000189B93630
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AE6 */, bool useObjectPool = false /* Metadata: 0x00AF7AEA */) => default; // 0x0000000182547860-0x0000000182547B60
	// [XID] // 0x0000000189B9AB80-0x0000000189B9ABA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AEB */, bool useObjectPool = false /* Metadata: 0x00AF7AEF */) => default; // 0x0000000182546C10-0x0000000182546EB0
	// [XID] // 0x0000000189BA2370-0x0000000189BA2390
	public static new ConfigCoopCondNode ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AF0 */, bool useObjectPool = false /* Metadata: 0x00AF7AF4 */) => default; // 0x0000000182547330-0x0000000182547550
	[BlackList] // 0x0000000189BA9820-0x0000000189BA9860
	// [XID] // 0x0000000189BA9820-0x0000000189BA9860
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001825464A0-0x0000000182546770
	// [XID] // 0x0000000189BB3D30-0x0000000189BB3D50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825480E0-0x0000000182548310
	[BlackList] // 0x0000000189BBB2D0-0x0000000189BBB310
	// [XID] // 0x0000000189BBB2D0-0x0000000189BBB310
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182547770-0x0000000182547860
	[BlackList] // 0x0000000189BC5E20-0x0000000189BC5E60
	// [XID] // 0x0000000189BC5E20-0x0000000189BC5E60
	public override void AutoAllocTypeFields() {} // 0x0000000182546770-0x0000000182546810
	[BlackList] // 0x0000000189BD0750-0x0000000189BD0790
	// [XID] // 0x0000000189BD0750-0x0000000189BD0790
	public override void AutoRecycleTypeFields() {} // 0x0000000182546810-0x0000000182546940
	[BlackList] // 0x0000000189BDAFC0-0x0000000189BDB000
	// [XID] // 0x0000000189BDAFC0-0x0000000189BDB000
	public override void ReturnToObjectPool() {} // 0x0000000182548490-0x0000000182548530
}


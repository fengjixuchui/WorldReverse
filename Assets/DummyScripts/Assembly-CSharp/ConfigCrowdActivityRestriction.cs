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
public class ConfigCrowdActivityRestriction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17765
{
	// Fields
	private SimpleSafeUInt32 activityTypeRawNum; // 0x10
	private bool _isActive; // 0x14
	private SimpleSafeUInt32[] _activityPhase; // 0x18
	private SimpleSafeUInt32 condIDRawNum; // 0x20

	// Properties
	public uint activityType { /* [XID] */ /* 0x000000018970F200-0x000000018970F220 */ get => default; /* [XID] */ /* 0x0000000189716600-0x0000000189716620 */ private set {} } // 0x00000001833A0C60-0x00000001833A0D30 0x00000001833A1220-0x00000001833A1300
	public bool isActive { /* [XID] */ /* 0x000000018971E080-0x000000018971E0A0 */ get => default; /* [XID] */ /* 0x00000001897255C0-0x00000001897255E0 */ private set {} } // 0x00000001833A16E0-0x00000001833A1780 0x00000001833A0830-0x00000001833A08E0
	public SimpleSafeUInt32[] activityPhase { /* [XID] */ /* 0x000000018972CB80-0x000000018972CBA0 */ get => default; /* [XID] */ /* 0x0000000189734330-0x0000000189734350 */ private set {} } // 0x000000018339FDE0-0x000000018339FE80 0x00000001833A0780-0x00000001833A0830
	public uint condID { /* [XID] */ /* 0x000000018973BBC0-0x000000018973BBE0 */ get => default; /* [XID] */ /* 0x00000001897434B0-0x00000001897434D0 */ private set {} } // 0x00000001833A02E0-0x00000001833A03B0 0x00000001833A1140-0x00000001833A1220

	// Constructors
	public ConfigCrowdActivityRestriction() {} // 0x00000001833A1AA0-0x00000001833A1B10

	// Methods
	// [XID] // 0x000000018974B0C0-0x000000018974B0E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833A1780-0x00000001833A18C0
	// [XID] // 0x0000000189752190-0x00000001897521B0
	public void InitEmpty() {} // 0x00000001833A0D30-0x00000001833A0E40
	[BlackList] // 0x00000001897597E0-0x0000000189759820
	// [XID] // 0x00000001897597E0-0x0000000189759820
	public bool FromJson(JSONNode node) => default; // 0x00000001833A08E0-0x00000001833A0C60
	// [XID] // 0x0000000189764040-0x0000000189764060
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018339F910-0x000000018339FDE0
	// [XID] // 0x000000018976B8E0-0x000000018976B900
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B6B */, bool useObjectPool = false /* Metadata: 0x00AF7B6F */) => default; // 0x00000001833A0E40-0x00000001833A1140
	// [XID] // 0x0000000189772D80-0x0000000189772DA0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B70 */, bool useObjectPool = false /* Metadata: 0x00AF7B74 */) => default; // 0x00000001833A03B0-0x00000001833A0780
	[BlackList] // 0x000000018977A4A0-0x000000018977A4E0
	// [XID] // 0x000000018977A4A0-0x000000018977A4E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018339FE80-0x00000001833A0150
	// [XID] // 0x0000000189784FC0-0x0000000189784FE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833A1300-0x00000001833A16E0
	[BlackList] // 0x000000018978C430-0x000000018978C470
	// [XID] // 0x000000018978C430-0x000000018978C470
	public virtual void AutoAllocTypeFields() {} // 0x00000001833A0150-0x00000001833A01F0
	[BlackList] // 0x0000000189796BB0-0x0000000189796BF0
	// [XID] // 0x0000000189796BB0-0x0000000189796BF0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833A01F0-0x00000001833A02E0
	[BlackList] // 0x00000001897A1880-0x00000001897A18C0
	// [XID] // 0x00000001897A1880-0x00000001897A18C0
	public virtual void ReturnToObjectPool() {} // 0x00000001833A1A00-0x00000001833A1AA0
	[BlackList] // 0x00000001897AC020-0x00000001897AC060
	// [XID] // 0x00000001897AC020-0x00000001897AC060
	public virtual void OnPoolAllocated() {} // 0x00000001833A1960-0x00000001833A1A00
	[BlackList] // 0x00000001897B7170-0x00000001897B71B0
	// [XID] // 0x00000001897B7170-0x00000001897B71B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833A18C0-0x00000001833A1960
}


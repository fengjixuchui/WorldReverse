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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TrialReliquaryExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16242
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 reliquaryIdRawNum; // 0x14
	protected SimpleSafeUInt32 levelRawNum; // 0x18
	protected SimpleSafeUInt32 promoteLevelRawNum; // 0x1C
	protected SimpleSafeUInt32 mainPropIdRawNum; // 0x20
	protected SimpleSafeUInt32[] _appendPropList; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A1D880-0x0000000189A1D8A0 */ get => default; /* [XID] */ /* 0x0000000189A24C90-0x0000000189A24CB0 */ protected set {} } // 0x000000018260AC90-0x000000018260AD60 0x000000018260A080-0x000000018260A160
	public uint reliquaryId { /* [XID] */ /* 0x0000000189A2C2D0-0x0000000189A2C2F0 */ get => default; /* [XID] */ /* 0x0000000189A33980-0x0000000189A339A0 */ protected set {} } // 0x0000000182609ED0-0x0000000182609FA0 0x0000000182609DF0-0x0000000182609ED0
	public uint level { /* [XID] */ /* 0x0000000189A3B120-0x0000000189A3B140 */ get => default; /* [XID] */ /* 0x0000000189A42AB0-0x0000000189A42AD0 */ protected set {} } // 0x000000018260A830-0x000000018260A900 0x000000018260A750-0x000000018260A830
	public uint promoteLevel { /* [XID] */ /* 0x0000000189A49FE0-0x0000000189A4A000 */ get => default; /* [XID] */ /* 0x0000000189A51950-0x0000000189A51970 */ protected set {} } // 0x000000018260A900-0x000000018260A9D0 0x0000000182609140-0x0000000182609220
	public uint mainPropId { /* [XID] */ /* 0x0000000189A591C0-0x0000000189A591E0 */ get => default; /* [XID] */ /* 0x0000000189A60A60-0x0000000189A60A80 */ protected set {} } // 0x000000018260A9D0-0x000000018260AAA0 0x0000000182609FA0-0x000000018260A080
	public SimpleSafeUInt32[] appendPropList { /* [XID] */ /* 0x0000000189A68890-0x0000000189A688B0 */ get => default; /* [XID] */ /* 0x0000000189A6FC40-0x0000000189A6FC60 */ protected set {} } // 0x0000000182608ED0-0x0000000182608F70 0x000000018260AAA0-0x000000018260AB50

	// Constructors
	public TrialReliquaryExcelConfig() {} // 0x000000018260AE00-0x000000018260AE60

	// Methods
	// [IDTag] // 0x0000000189A773B0-0x0000000189A773F0
	// [XID] // 0x0000000189A773B0-0x0000000189A773F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182609220-0x0000000182609820
	// [IDTag] // 0x0000000189A81D30-0x0000000189A81D70
	// [XID] // 0x0000000189A81D30-0x0000000189A81D70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182609820-0x0000000182609DF0
	// [XID] // 0x0000000189A8C7B0-0x0000000189A8C7D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3555 */, bool useObjectPool = false /* Metadata: 0x00AF3559 */) => default; // 0x000000018260A160-0x000000018260A750
	[BlackList] // 0x0000000189A93BB0-0x0000000189A93BF0
	// [XID] // 0x0000000189A93BB0-0x0000000189A93BF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182608F70-0x0000000182609010
	[BlackList] // 0x0000000189A9E230-0x0000000189A9E270
	// [XID] // 0x0000000189A9E230-0x0000000189A9E270
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182609010-0x0000000182609140
	[BlackList] // 0x0000000189AA87C0-0x0000000189AA8800
	// [XID] // 0x0000000189AA87C0-0x0000000189AA8800
	public virtual void ReturnToObjectPool() {} // 0x000000018260AD60-0x000000018260AE00
	[BlackList] // 0x0000000189AB33E0-0x0000000189AB3420
	// [XID] // 0x0000000189AB33E0-0x0000000189AB3420
	public virtual void OnPoolAllocated() {} // 0x000000018260ABF0-0x000000018260AC90
	[BlackList] // 0x0000000189ABDE90-0x0000000189ABDED0
	// [XID] // 0x0000000189ABDE90-0x0000000189ABDED0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018260AB50-0x000000018260ABF0
}


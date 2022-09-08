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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class PhotographPosenameExcelConfig : FetterConfig, IAutoAllocRecycle // TypeDefIndex: 15946
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected string _poseFile; // 0x28
	protected SimpleSafeUInt32 animatorstate_idRawNum; // 0x30
	protected string _poseIcon; // 0x38
	protected uint _poseNameTextMapHash; // 0x40
	protected uint _unlockDescTextMapHash; // 0x44

	// Properties
	public string poseFile { /* [XID] */ /* 0x00000001898B5870-0x00000001898B5890 */ get => default; /* [XID] */ /* 0x00000001898BD320-0x00000001898BD340 */ protected set {} } // 0x00000001845CF040-0x00000001845CF0E0 0x00000001845CF0E0-0x00000001845CF190
	public uint animatorstate_id { /* [XID] */ /* 0x00000001898C4A60-0x00000001898C4A80 */ get => default; /* [XID] */ /* 0x00000001898CBF30-0x00000001898CBF50 */ protected set {} } // 0x00000001845CF4B0-0x00000001845CF580 0x00000001845CDB40-0x00000001845CDC20
	public string poseIcon { /* [XID] */ /* 0x00000001898D3730-0x00000001898D3750 */ get => default; /* [XID] */ /* 0x00000001898DAFA0-0x00000001898DAFC0 */ protected set {} } // 0x00000001845CFE10-0x00000001845CFEB0 0x00000001845CFF10-0x00000001845CFFC0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint poseNameTextMapHash { /* [XID] */ /* 0x00000001898E2C40-0x00000001898E2C60 */ get => default; /* [XID] */ /* 0x00000001898EA970-0x00000001898EA990 */ protected set {} } // 0x00000001845CDE50-0x00000001845CDEF0 0x00000001845CFD60-0x00000001845CFE10
	public string poseName { /* [XID] */ /* 0x00000001898F2070-0x00000001898F2090 */ get => default; } // 0x00000001845CF190-0x00000001845CF310 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockDescTextMapHash { /* [XID] */ /* 0x00000001898F9830-0x00000001898F9850 */ get => default; /* [XID] */ /* 0x00000001899011D0-0x00000001899011F0 */ protected set {} } // 0x00000001845CEFA0-0x00000001845CF040 0x00000001845CF310-0x00000001845CF3C0
	public string unlockDesc { /* [XID] */ /* 0x0000000189908A50-0x0000000189908A70 */ get => default; } // 0x00000001845CEE20-0x00000001845CEFA0 

	// Constructors
	public PhotographPosenameExcelConfig() {} // 0x00000001845D0060-0x00000001845D00C0

	// Methods
	// [IDTag] // 0x000000018990FFF0-0x0000000189910030
	// [XID] // 0x000000018990FFF0-0x0000000189910030
	public virtual bool ParseFromLine(string line) => default; // 0x00000001845CE650-0x00000001845CEE20
	// [IDTag] // 0x000000018991AC10-0x000000018991AC50
	// [XID] // 0x000000018991AC10-0x000000018991AC50
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001845CDF50-0x00000001845CE650
	// [XID] // 0x0000000189925300-0x0000000189925320
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BE8 */, bool useObjectPool = false /* Metadata: 0x00AF2BEC */) => default; // 0x00000001845CF580-0x00000001845CFD60
	[BlackList] // 0x000000018992C8E0-0x000000018992C920
	// [XID] // 0x000000018992C8E0-0x000000018992C920
	public override void AutoAllocTypeFields() {} // 0x00000001845CDC20-0x00000001845CDCC0
	[BlackList] // 0x0000000189936DB0-0x0000000189936DF0
	// [XID] // 0x0000000189936DB0-0x0000000189936DF0
	public override void AutoRecycleTypeFields() {} // 0x00000001845CDCC0-0x00000001845CDDB0
	[BlackList] // 0x0000000189941420-0x0000000189941460
	// [XID] // 0x0000000189941420-0x0000000189941460
	public override void ReturnToObjectPool() {} // 0x00000001845CFFC0-0x00000001845D0060
}


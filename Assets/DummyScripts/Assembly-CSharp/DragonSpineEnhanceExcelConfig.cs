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
public class DragonSpineEnhanceExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15070
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityAbilityGroupIdRawNum; // 0x14
	protected SimpleSafeUInt32 processRawNum; // 0x18
	protected uint _descTextMapHash; // 0x1C

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899CA6C0-0x00000001899CA6E0 */ get => default; /* [XID] */ /* 0x00000001899D1E60-0x00000001899D1E80 */ protected set {} } // 0x0000000183C3E3D0-0x0000000183C3E4A0 0x0000000183C3DAB0-0x0000000183C3DB90
	public uint activityAbilityGroupId { /* [XID] */ /* 0x00000001899D9370-0x00000001899D9390 */ get => default; /* [XID] */ /* 0x00000001899E0A80-0x00000001899E0AA0 */ protected set {} } // 0x0000000183C3D860-0x0000000183C3D930 0x0000000183C3E1B0-0x0000000183C3E290
	public uint process { /* [XID] */ /* 0x00000001899E8620-0x00000001899E8640 */ get => default; /* [XID] */ /* 0x00000001899EFC90-0x00000001899EFCB0 */ protected set {} } // 0x0000000183C3E0E0-0x0000000183C3E1B0 0x0000000183C3E4A0-0x0000000183C3E580
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001899F7310-0x00000001899F7330 */ get => default; /* [XID] */ /* 0x00000001899FEA90-0x00000001899FEAB0 */ protected set {} } // 0x0000000183C3E040-0x0000000183C3E0E0 0x0000000183C3D140-0x0000000183C3D1F0
	public string desc { /* [XID] */ /* 0x0000000189A062B0-0x0000000189A062D0 */ get => default; } // 0x0000000183C3D930-0x0000000183C3DAB0 

	// Constructors
	public DragonSpineEnhanceExcelConfig() {} // 0x0000000183C3E620-0x0000000183C3E680

	// Methods
	// [IDTag] // 0x0000000189A0D780-0x0000000189A0D7C0
	// [XID] // 0x0000000189A0D780-0x0000000189A0D7C0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183C3D1F0-0x0000000183C3D540
	// [IDTag] // 0x0000000189A17B30-0x0000000189A17B70
	// [XID] // 0x0000000189A17B30-0x0000000189A17B70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183C3D540-0x0000000183C3D860
	// [XID] // 0x0000000189A22250-0x0000000189A22270
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFFF7 */, bool useObjectPool = false /* Metadata: 0x00AEFFFB */) => default; // 0x0000000183C3DB90-0x0000000183C3E040
	[BlackList] // 0x0000000189A29600-0x0000000189A29640
	// [XID] // 0x0000000189A29600-0x0000000189A29640
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C3CFA0-0x0000000183C3D040
	[BlackList] // 0x0000000189A33B80-0x0000000189A33BC0
	// [XID] // 0x0000000189A33B80-0x0000000189A33BC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C3D040-0x0000000183C3D140
	[BlackList] // 0x0000000189A3E5B0-0x0000000189A3E5F0
	// [XID] // 0x0000000189A3E5B0-0x0000000189A3E5F0
	public virtual void ReturnToObjectPool() {} // 0x0000000183C3E580-0x0000000183C3E620
	[BlackList] // 0x0000000189A48BF0-0x0000000189A48C30
	// [XID] // 0x0000000189A48BF0-0x0000000189A48C30
	public virtual void OnPoolAllocated() {} // 0x0000000183C3E330-0x0000000183C3E3D0
	[BlackList] // 0x0000000189A53220-0x0000000189A53260
	// [XID] // 0x0000000189A53220-0x0000000189A53260
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C3E290-0x0000000183C3E330
}


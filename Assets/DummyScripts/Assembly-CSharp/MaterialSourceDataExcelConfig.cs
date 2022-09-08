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
public class MaterialSourceDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15827
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _name; // 0x18
	protected SimpleSafeUInt32[] _dungeonList; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected SourceJumpConfig[] _jumpList; // 0x28
	protected uint[] _textList; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x000000018986BBE0-0x000000018986BC00 */ get => default; /* [XID] */ /* 0x0000000189872ED0-0x0000000189872EF0 */ protected set {} } // 0x00000001815B5310-0x00000001815B53E0 0x00000001815B4A40-0x00000001815B4B20
	public string name { /* [XID] */ /* 0x000000018987AC10-0x000000018987AC30 */ get => default; /* [XID] */ /* 0x0000000189881BA0-0x0000000189881BC0 */ protected set {} } // 0x00000001815B53E0-0x00000001815B5480 0x00000001815B4990-0x00000001815B4A40
	public SimpleSafeUInt32[] dungeonList { /* [XID] */ /* 0x00000001898892A0-0x00000001898892C0 */ get => default; /* [XID] */ /* 0x0000000189890700-0x0000000189890720 */ protected set {} } // 0x00000001815B36D0-0x00000001815B3770 0x00000001815B4580-0x00000001815B4630
	public SourceJumpConfig[] jumpList { /* [XID] */ /* 0x0000000189897CE0-0x0000000189897D00 */ get => default; /* [XID] */ /* 0x000000018989F080-0x000000018989F0A0 */ protected set {} } // 0x00000001815B4B20-0x00000001815B4BC0 0x00000001815B5120-0x00000001815B51D0
	public uint[] textList { /* [XID] */ /* 0x00000001898A6BE0-0x00000001898A6C00 */ get => default; /* [XID] */ /* 0x00000001898AE2F0-0x00000001898AE310 */ protected set {} } // 0x00000001815B44E0-0x00000001815B4580 0x00000001815B3490-0x00000001815B3540
	public string[] textListLocalized { /* [XID] */ /* 0x00000001898B58D0-0x00000001898B58F0 */ get => default; } // 0x00000001815B4630-0x00000001815B4990 

	// Constructors
	public MaterialSourceDataExcelConfig() {} // 0x00000001815B5520-0x00000001815B5580

	// Methods
	// [IDTag] // 0x00000001898BD340-0x00000001898BD380
	// [XID] // 0x00000001898BD340-0x00000001898BD380
	public virtual bool ParseFromLine(string line) => default; // 0x00000001815B3DD0-0x00000001815B44E0
	// [IDTag] // 0x00000001898C7A00-0x00000001898C7A40
	// [XID] // 0x00000001898C7A00-0x00000001898C7A40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001815B3770-0x00000001815B3DD0
	// [XID] // 0x00000001898D2090-0x00000001898D20B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2790 */, bool useObjectPool = false /* Metadata: 0x00AF2794 */) => default; // 0x00000001815B4BC0-0x00000001815B5120
	[BlackList] // 0x00000001898D9970-0x00000001898D99B0
	// [XID] // 0x00000001898D9970-0x00000001898D99B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001815B3540-0x00000001815B35E0
	[BlackList] // 0x00000001898E4500-0x00000001898E4540
	// [XID] // 0x00000001898E4500-0x00000001898E4540
	public virtual void AutoRecycleTypeFields() {} // 0x00000001815B35E0-0x00000001815B36D0
	[BlackList] // 0x00000001898EF040-0x00000001898EF080
	// [XID] // 0x00000001898EF040-0x00000001898EF080
	public virtual void ReturnToObjectPool() {} // 0x00000001815B5480-0x00000001815B5520
	[BlackList] // 0x00000001898F9870-0x00000001898F98B0
	// [XID] // 0x00000001898F9870-0x00000001898F98B0
	public virtual void OnPoolAllocated() {} // 0x00000001815B5270-0x00000001815B5310
	[BlackList] // 0x0000000189904170-0x00000001899041B0
	// [XID] // 0x0000000189904170-0x00000001899041B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001815B51D0-0x00000001815B5270
}


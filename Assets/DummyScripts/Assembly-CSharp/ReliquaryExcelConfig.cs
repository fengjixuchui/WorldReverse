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
public class ReliquaryExcelConfig : ItemConfig, IAutoAllocRecycle // TypeDefIndex: 16015
{
	// Fields
	protected EquipType _equipType; // 0x48
	protected string _showPic; // 0x50
	protected SimpleSafeUInt32 rankLevelRawNum; // 0x58
	protected SimpleSafeUInt32 mainPropDepotIdRawNum; // 0x5C
	protected SimpleSafeUInt32 appendPropDepotIdRawNum; // 0x60
	protected SimpleSafeUInt32 appendPropNumRawNum; // 0x64
	protected SimpleSafeUInt32 setIdRawNum; // 0x68
	protected SimpleSafeUInt32[] _addPropLevels; // 0x70
	protected SimpleSafeUInt32 baseConvExpRawNum; // 0x78
	protected SimpleSafeUInt32 maxLevelRawNum; // 0x7C
	protected SimpleSafeUInt32 storyIdRawNum; // 0x80
	protected MaterialDestroyType _destroyRule; // 0x84
	protected SimpleSafeUInt32[] _destroyReturnMaterial; // 0x88
	protected SimpleSafeUInt32[] _destroyReturnMaterialCount; // 0x90
	protected SimpleSafeUInt32 initialLockStateRawNum; // 0x98

	// Properties
	public EquipType equipType { /* [XID] */ /* 0x00000001899F10B0-0x00000001899F10D0 */ get => default; /* [XID] */ /* 0x00000001899F8890-0x00000001899F88B0 */ protected set {} } // 0x00000001843AEED0-0x00000001843AEF70 0x00000001843ABFF0-0x00000001843AC0A0
	public string showPic { /* [XID] */ /* 0x00000001899FFEA0-0x00000001899FFEC0 */ get => default; /* [XID] */ /* 0x0000000189A07770-0x0000000189A07790 */ protected set {} } // 0x00000001843B0A20-0x00000001843B0AC0 0x00000001843B0970-0x00000001843B0A20
	public uint rankLevel { /* [XID] */ /* 0x0000000189649A80-0x0000000189649AA0 */ get => default; /* [XID] */ /* 0x0000000189A163C0-0x0000000189A163E0 */ protected set {} } // 0x00000001843AF3C0-0x00000001843AF490 0x00000001843AF2E0-0x00000001843AF3C0
	public uint mainPropDepotId { /* [XID] */ /* 0x0000000189A1D960-0x0000000189A1D980 */ get => default; /* [XID] */ /* 0x0000000189A24D90-0x0000000189A24DB0 */ protected set {} } // 0x00000001843ABB90-0x00000001843ABC60 0x00000001843AC100-0x00000001843AC1E0
	public uint appendPropDepotId { /* [XID] */ /* 0x0000000189A2C350-0x0000000189A2C370 */ get => default; /* [XID] */ /* 0x0000000189A33A00-0x0000000189A33A20 */ protected set {} } // 0x00000001843B0E00-0x00000001843B0ED0 0x00000001843AF040-0x00000001843AF120
	public uint appendPropNum { /* [XID] */ /* 0x0000000189A3B1E0-0x0000000189A3B200 */ get => default; /* [XID] */ /* 0x0000000189A42BD0-0x0000000189A42BF0 */ protected set {} } // 0x00000001843AEF70-0x00000001843AF040 0x00000001843AC290-0x00000001843AC370
	public uint setId { /* [XID] */ /* 0x0000000189A4A040-0x0000000189A4A060 */ get => default; /* [XID] */ /* 0x0000000189A519D0-0x0000000189A519F0 */ protected set {} } // 0x00000001843AEBA0-0x00000001843AEC70 0x00000001843AEDF0-0x00000001843AEED0
	public SimpleSafeUInt32[] addPropLevels { /* [XID] */ /* 0x0000000189A59240-0x0000000189A59260 */ get => default; /* [XID] */ /* 0x0000000189A60BA0-0x0000000189A60BC0 */ protected set {} } // 0x00000001843ABAF0-0x00000001843ABB90 0x00000001843B0CF0-0x00000001843B0DA0
	public uint baseConvExp { /* [XID] */ /* 0x0000000189A68910-0x0000000189A68930 */ get => default; /* [XID] */ /* 0x0000000189A6FCE0-0x0000000189A6FD00 */ protected set {} } // 0x00000001843B0ED0-0x00000001843B0FA0 0x00000001843B0B70-0x00000001843B0C50
	public uint maxLevel { /* [XID] */ /* 0x0000000189A77430-0x0000000189A77450 */ get => default; /* [XID] */ /* 0x0000000189A7ECE0-0x0000000189A7ED00 */ protected set {} } // 0x00000001843AC370-0x00000001843AC440 0x00000001843B0FA0-0x00000001843B1080
	public uint storyId { /* [XID] */ /* 0x0000000189A86510-0x0000000189A86530 */ get => default; /* [XID] */ /* 0x0000000189A8DFD0-0x0000000189A8DFF0 */ protected set {} } // 0x00000001843AF520-0x00000001843AF5F0 0x00000001843AF120-0x00000001843AF200
	public MaterialDestroyType destroyRule { /* [XID] */ /* 0x0000000189A95530-0x0000000189A95550 */ get => default; /* [XID] */ /* 0x0000000189A9CD90-0x0000000189A9CDB0 */ protected set {} } // 0x00000001843B0C50-0x00000001843B0CF0 0x00000001843AED40-0x00000001843AEDF0
	public SimpleSafeUInt32[] destroyReturnMaterial { /* [XID] */ /* 0x0000000189AA4500-0x0000000189AA4520 */ get => default; /* [XID] */ /* 0x0000000189AABA50-0x0000000189AABA70 */ protected set {} } // 0x00000001843ABF40-0x00000001843ABFF0 0x00000001843AC1E0-0x00000001843AC290
	public SimpleSafeUInt32[] destroyReturnMaterialCount { /* [XID] */ /* 0x0000000189AB3440-0x0000000189AB3460 */ get => default; /* [XID] */ /* 0x0000000189ABB170-0x0000000189ABB190 */ protected set {} } // 0x00000001843AC440-0x00000001843AC4F0 0x00000001843B0AC0-0x00000001843B0B70
	public uint initialLockState { /* [XID] */ /* 0x0000000189AC2980-0x0000000189AC29A0 */ get => default; /* [XID] */ /* 0x0000000189AC9FE0-0x0000000189ACA000 */ protected set {} } // 0x00000001843AEC70-0x00000001843AED40 0x00000001843AF200-0x00000001843AF2E0

	// Constructors
	public ReliquaryExcelConfig() {} // 0x00000001843B1120-0x00000001843B1180

	// Methods
	// [IDTag] // 0x0000000189AD1790-0x0000000189AD17D0
	// [XID] // 0x0000000189AD1790-0x0000000189AD17D0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001843AC4F0-0x00000001843AD800
	// [IDTag] // 0x0000000189ADC5C0-0x0000000189ADC600
	// [XID] // 0x0000000189ADC5C0-0x0000000189ADC600
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843AD800-0x00000001843AEBA0
	// [XID] // 0x0000000189AE6FB0-0x0000000189AE6FD0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2DF0 */, bool useObjectPool = false /* Metadata: 0x00AF2DF4 */) => default; // 0x00000001843AF650-0x00000001843B0970
	[BlackList] // 0x0000000189AEEAE0-0x0000000189AEEB20
	// [XID] // 0x0000000189AEEAE0-0x0000000189AEEB20
	public override void AutoAllocTypeFields() {} // 0x00000001843ABC60-0x00000001843ABD00
	[BlackList] // 0x0000000189AF9210-0x0000000189AF9250
	// [XID] // 0x0000000189AF9210-0x0000000189AF9250
	public override void AutoRecycleTypeFields() {} // 0x00000001843ABD00-0x00000001843ABEA0
	[BlackList] // 0x0000000189B034D0-0x0000000189B03510
	// [XID] // 0x0000000189B034D0-0x0000000189B03510
	public override void ReturnToObjectPool() {} // 0x00000001843B1080-0x00000001843B1120
}


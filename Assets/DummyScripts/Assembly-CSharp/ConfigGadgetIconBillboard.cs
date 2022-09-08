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
public class ConfigGadgetIconBillboard : ConfigBillboard, IAutoAllocRecycle // TypeDefIndex: 17718
{
	// Fields
	private string _iconName; // 0x40
	private string _title; // 0x48

	// Properties
	public string iconName { /* [XID] */ /* 0x0000000189ACD900-0x0000000189ACD920 */ get => default; /* [XID] */ /* 0x0000000189A3AE40-0x0000000189A3AE60 */ private set {} } // 0x00000001817E1A80-0x00000001817E1B20 0x00000001817E1EC0-0x00000001817E1F70
	public string title { /* [XID] */ /* 0x0000000189A42750-0x0000000189A42770 */ get => default; /* [XID] */ /* 0x0000000189A49CA0-0x0000000189A49CC0 */ private set {} } // 0x00000001817E1630-0x00000001817E16D0 0x00000001817E0E10-0x00000001817E0EC0

	// Constructors
	public ConfigGadgetIconBillboard() {} // 0x00000001817E2010-0x00000001817E2070

	// Methods
	// [XID] // 0x0000000189A516B0-0x0000000189A516D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817E1DB0-0x00000001817E1EC0
	// [XID] // 0x0000000189A58D80-0x0000000189A58DA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001817E1980-0x00000001817E1A80
	// [XID] // 0x0000000189A606E0-0x0000000189A60700
	public override ConfigBillboard Clone(bool useObjectPool = false /* Metadata: 0x00AF78CD */) => default; // 0x00000001817E14F0-0x00000001817E15D0
	// [XID] // 0x0000000189A684F0-0x0000000189A68510
	public override int GetHashNum() => default; // 0x00000001817E02C0-0x00000001817E0390
	// [XID] // 0x0000000189A6F840-0x0000000189A6F860
	public override void InitEmpty() {} // 0x00000001817E0F30-0x00000001817E1020
	[BlackList] // 0x0000000189A76FB0-0x0000000189A76FF0
	// [XID] // 0x0000000189A76FB0-0x0000000189A76FF0
	public override bool FromJson(JSONNode node) => default; // 0x00000001817E0870-0x00000001817E0BF0
	// [XID] // 0x0000000189A819F0-0x0000000189A81A10
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001817DFA70-0x00000001817DFD80
	[BlackList] // 0x0000000189A89510-0x0000000189A89550
	// [XID] // 0x0000000189A89510-0x0000000189A89550
	public static new ConfigGadgetIconBillboard ParseFromJson(JSONNode node) => default; // 0x00000001817E16D0-0x00000001817E1920
	// [XID] // 0x0000000189A93870-0x0000000189A93890
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78CE */, bool useObjectPool = false /* Metadata: 0x00AF78D2 */) => default; // 0x00000001817E11F0-0x00000001817E14F0
	// [XID] // 0x0000000189A9B480-0x0000000189A9B4A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78D3 */, bool useObjectPool = false /* Metadata: 0x00AF78D7 */) => default; // 0x00000001817E0470-0x00000001817E0770
	// [XID] // 0x0000000189AA27A0-0x0000000189AA27C0
	public static new ConfigGadgetIconBillboard ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78D8 */, bool useObjectPool = false /* Metadata: 0x00AF78DC */) => default; // 0x00000001817E0BF0-0x00000001817E0E10
	[BlackList] // 0x0000000189AA9D00-0x0000000189AA9D40
	// [XID] // 0x0000000189AA9D00-0x0000000189AA9D40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001817DFD80-0x00000001817E0050
	// [XID] // 0x0000000189AB4890-0x0000000189AB48B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817E1B20-0x00000001817E1DB0
	[BlackList] // 0x0000000189ABC5E0-0x0000000189ABC620
	// [XID] // 0x0000000189ABC5E0-0x0000000189ABC620
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001817E1100-0x00000001817E11F0
	[BlackList] // 0x0000000189AC6CA0-0x0000000189AC6CE0
	// [XID] // 0x0000000189AC6CA0-0x0000000189AC6CE0
	public override void AutoAllocTypeFields() {} // 0x00000001817E0050-0x00000001817E00F0
	[BlackList] // 0x0000000189AD14B0-0x0000000189AD14F0
	// [XID] // 0x0000000189AD14B0-0x0000000189AD14F0
	public override void AutoRecycleTypeFields() {} // 0x00000001817E00F0-0x00000001817E01A0
	[BlackList] // 0x0000000189ADC180-0x0000000189ADC1C0
	// [XID] // 0x0000000189ADC180-0x0000000189ADC1C0
	public override void ReturnToObjectPool() {} // 0x00000001817E1F70-0x00000001817E2010
}


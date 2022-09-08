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
public class ChestLevelSetConfig : IAutoAllocRecycle // TypeDefIndex: 15511
{
	// Fields
	protected SimpleSafeUInt32 zoneMinLevelRawNum; // 0x10
	protected SimpleSafeUInt32 chestLevelRawNum; // 0x14

	// Properties
	public uint zoneMinLevel { /* [XID] */ /* 0x000000018991DC10-0x000000018991DC30 */ get => default; /* [XID] */ /* 0x00000001899253C0-0x00000001899253E0 */ protected set {} } // 0x00000001833FE2B0-0x00000001833FE380 0x00000001833FE810-0x00000001833FE8F0
	public uint chestLevel { /* [XID] */ /* 0x000000018992C960-0x000000018992C980 */ get => default; /* [XID] */ /* 0x0000000189933F80-0x0000000189933FA0 */ protected set {} } // 0x00000001833FEC50-0x00000001833FED20 0x00000001833FED20-0x00000001833FEE00

	// Constructors
	public ChestLevelSetConfig() {} // 0x00000001833FEFE0-0x00000001833FF040

	// Methods
	// [IDTag] // 0x000000018993BB90-0x000000018993BBD0
	// [XID] // 0x000000018993BB90-0x000000018993BBD0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001833FE5A0-0x00000001833FE810
	// [IDTag] // 0x0000000189946060-0x00000001899460A0
	// [XID] // 0x0000000189946060-0x00000001899460A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001833FE380-0x00000001833FE5A0
	// [XID] // 0x0000000189950870-0x0000000189950890
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1CAC */, bool useObjectPool = false /* Metadata: 0x00AF1CB0 */) => default; // 0x00000001833FE8F0-0x00000001833FEC50
	[BlackList] // 0x0000000189957E80-0x0000000189957EC0
	// [XID] // 0x0000000189957E80-0x0000000189957EC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001833FE130-0x00000001833FE1D0
	[BlackList] // 0x00000001899628F0-0x0000000189962930
	// [XID] // 0x00000001899628F0-0x0000000189962930
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833FE1D0-0x00000001833FE2B0
	[BlackList] // 0x000000018996CD90-0x000000018996CDD0
	// [XID] // 0x000000018996CD90-0x000000018996CDD0
	public virtual void ReturnToObjectPool() {} // 0x00000001833FEF40-0x00000001833FEFE0
	[BlackList] // 0x00000001899778A0-0x00000001899778E0
	// [XID] // 0x00000001899778A0-0x00000001899778E0
	public virtual void OnPoolAllocated() {} // 0x00000001833FEEA0-0x00000001833FEF40
	[BlackList] // 0x0000000189982160-0x00000001899821A0
	// [XID] // 0x0000000189982160-0x00000001899821A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833FEE00-0x00000001833FEEA0
}


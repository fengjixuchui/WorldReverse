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
public class ExhibitionScoreExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15591
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected ExhibitionScoreType _scoreType; // 0x14
	protected SimpleSafeUInt32 scoreRawNum; // 0x18
	protected uint _descTextMapHash; // 0x1C

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898CAAC0-0x00000001898CAAE0 */ get => default; /* [XID] */ /* 0x00000001898D2170-0x00000001898D2190 */ protected set {} } // 0x00000001843CA920-0x00000001843CA9F0 0x00000001843CA100-0x00000001843CA1E0
	public ExhibitionScoreType scoreType { /* [XID] */ /* 0x00000001898D99F0-0x00000001898D9A10 */ get => default; /* [XID] */ /* 0x00000001898E16B0-0x00000001898E16D0 */ protected set {} } // 0x00000001843C9E10-0x00000001843C9EB0 0x00000001843CA730-0x00000001843CA7E0
	public uint score { /* [XID] */ /* 0x00000001898E91C0-0x00000001898E91E0 */ get => default; /* [XID] */ /* 0x00000001898F0960-0x00000001898F0980 */ protected set {} } // 0x00000001843CA030-0x00000001843CA100 0x00000001843C9450-0x00000001843C9530
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001898F8290-0x00000001898F82B0 */ get => default; /* [XID] */ /* 0x00000001898FF950-0x00000001898FF970 */ protected set {} } // 0x00000001843CA690-0x00000001843CA730 0x00000001843C96C0-0x00000001843C9770
	public string desc { /* [XID] */ /* 0x00000001899071D0-0x00000001899071F0 */ get => default; } // 0x00000001843C9EB0-0x00000001843CA030 

	// Constructors
	public ExhibitionScoreExcelConfig() {} // 0x00000001843CAA90-0x00000001843CAAF0

	// Methods
	// [IDTag] // 0x000000018990EB30-0x000000018990EB70
	// [XID] // 0x000000018990EB30-0x000000018990EB70
	public virtual bool ParseFromLine(string line) => default; // 0x00000001843C9770-0x00000001843C9AE0
	// [IDTag] // 0x0000000189919460-0x00000001899194A0
	// [XID] // 0x0000000189919460-0x00000001899194A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843C9AE0-0x00000001843C9E10
	// [XID] // 0x0000000189923E00-0x0000000189923E20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1FFA */, bool useObjectPool = false /* Metadata: 0x00AF1FFE */) => default; // 0x00000001843CA1E0-0x00000001843CA690
	[BlackList] // 0x000000018992B400-0x000000018992B440
	// [XID] // 0x000000018992B400-0x000000018992B440
	public virtual void AutoAllocTypeFields() {} // 0x00000001843C9530-0x00000001843C95D0
	[BlackList] // 0x00000001899356B0-0x00000001899356F0
	// [XID] // 0x00000001899356B0-0x00000001899356F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843C95D0-0x00000001843C96C0
	[BlackList] // 0x0000000189940040-0x0000000189940080
	// [XID] // 0x0000000189940040-0x0000000189940080
	public virtual void ReturnToObjectPool() {} // 0x00000001843CA9F0-0x00000001843CAA90
	[BlackList] // 0x000000018994A520-0x000000018994A560
	// [XID] // 0x000000018994A520-0x000000018994A560
	public virtual void OnPoolAllocated() {} // 0x00000001843CA880-0x00000001843CA920
	[BlackList] // 0x0000000189954C40-0x0000000189954C80
	// [XID] // 0x0000000189954C40-0x0000000189954C80
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843CA7E0-0x00000001843CA880
}


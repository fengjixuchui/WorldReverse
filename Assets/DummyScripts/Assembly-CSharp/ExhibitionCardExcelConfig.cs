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
public class ExhibitionCardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15589
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _titleTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected uint _styleTextMapHash; // 0x1C
	protected SimpleSafeUInt32 priorityRawNum; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x000000018977F020-0x000000018977F040 */ get => default; /* [XID] */ /* 0x0000000189786A00-0x0000000189786A20 */ protected set {} } // 0x0000000185527BD0-0x0000000185527CA0 0x0000000185526F50-0x0000000185527030
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x000000018978E0B0-0x000000018978E0D0 */ get => default; /* [XID] */ /* 0x00000001897957E0-0x0000000189795800 */ protected set {} } // 0x0000000185526380-0x0000000185526420 0x00000001855264D0-0x0000000185526580
	public string title { /* [XID] */ /* 0x000000018979DC30-0x000000018979DC50 */ get => default; } // 0x0000000185527790-0x0000000185527910 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001897A4F70-0x00000001897A4F90 */ get => default; /* [XID] */ /* 0x00000001897AC500-0x00000001897AC520 */ protected set {} } // 0x00000001855276F0-0x0000000185527790 0x0000000185526420-0x00000001855264D0
	public string desc { /* [XID] */ /* 0x00000001897B4490-0x00000001897B44B0 */ get => default; } // 0x0000000185526DD0-0x0000000185526F50 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint styleTextMapHash { /* [XID] */ /* 0x00000001897BC230-0x00000001897BC250 */ get => default; /* [XID] */ /* 0x00000001897C38F0-0x00000001897C3910 */ protected set {} } // 0x0000000185527580-0x0000000185527620 0x00000001855262D0-0x0000000185526380
	public string style { /* [XID] */ /* 0x00000001897CB030-0x00000001897CB050 */ get => default; } // 0x0000000185527910-0x0000000185527A90 
	public uint priority { /* [XID] */ /* 0x00000001897D2730-0x00000001897D2750 */ get => default; /* [XID] */ /* 0x00000001897DA470-0x00000001897DA490 */ protected set {} } // 0x0000000185527620-0x00000001855276F0 0x0000000185526CF0-0x0000000185526DD0

	// Constructors
	public ExhibitionCardExcelConfig() {} // 0x0000000185527D40-0x0000000185527DA0

	// Methods
	// [IDTag] // 0x00000001897E18E0-0x00000001897E1920
	// [XID] // 0x00000001897E18E0-0x00000001897E1920
	public virtual bool ParseFromLine(string line) => default; // 0x0000000185526580-0x0000000185526950
	// [IDTag] // 0x00000001897EC400-0x00000001897EC440
	// [XID] // 0x00000001897EC400-0x00000001897EC440
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185526950-0x0000000185526CF0
	// [XID] // 0x00000001897F69E0-0x00000001897F6A00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1FEB */, bool useObjectPool = false /* Metadata: 0x00AF1FEF */) => default; // 0x0000000185527030-0x0000000185527580
	[BlackList] // 0x00000001897FE020-0x00000001897FE060
	// [XID] // 0x00000001897FE020-0x00000001897FE060
	public virtual void AutoAllocTypeFields() {} // 0x0000000185526140-0x00000001855261E0
	[BlackList] // 0x00000001898087C0-0x0000000189808800
	// [XID] // 0x00000001898087C0-0x0000000189808800
	public virtual void AutoRecycleTypeFields() {} // 0x00000001855261E0-0x00000001855262D0
	[BlackList] // 0x0000000189812F60-0x0000000189812FA0
	// [XID] // 0x0000000189812F60-0x0000000189812FA0
	public virtual void ReturnToObjectPool() {} // 0x0000000185527CA0-0x0000000185527D40
	[BlackList] // 0x000000018981DA30-0x000000018981DA70
	// [XID] // 0x000000018981DA30-0x000000018981DA70
	public virtual void OnPoolAllocated() {} // 0x0000000185527B30-0x0000000185527BD0
	[BlackList] // 0x00000001898282A0-0x00000001898282E0
	// [XID] // 0x00000001898282A0-0x00000001898282E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185527A90-0x0000000185527B30
}


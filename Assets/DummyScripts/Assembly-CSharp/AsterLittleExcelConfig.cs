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
public class AsterLittleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15013
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 stage_idRawNum; // 0x10
	protected SimpleSafeUInt32[] _next_stage_id_vec; // 0x18
	protected SimpleSafeUInt32 open_dayRawNum; // 0x20
	protected SimpleSafeUInt32[] _mission_vec; // 0x28
	protected SimpleSafeUInt32[] _watcher_id_vec; // 0x30
	protected uint _titleTextMapHash; // 0x38
	protected uint _descTextMapHash; // 0x3C

	// Properties
	public uint stage_id { /* [XID] */ /* 0x0000000189947680-0x00000001899476A0 */ get => default; /* [XID] */ /* 0x000000018994EEA0-0x000000018994EEC0 */ protected set {} } // 0x0000000184B4EC60-0x0000000184B4ED30 0x0000000184B4DDC0-0x0000000184B4DEA0
	public SimpleSafeUInt32[] next_stage_id_vec { /* [XID] */ /* 0x0000000189956500-0x0000000189956520 */ get => default; /* [XID] */ /* 0x000000018995DED0-0x000000018995DEF0 */ protected set {} } // 0x0000000184B4C6B0-0x0000000184B4C750 0x0000000184B4EA30-0x0000000184B4EAE0
	public uint open_day { /* [XID] */ /* 0x0000000189965710-0x0000000189965730 */ get => default; /* [XID] */ /* 0x000000018996CED0-0x000000018996CEF0 */ protected set {} } // 0x0000000184B4EAE0-0x0000000184B4EBB0 0x0000000184B4EF10-0x0000000184B4EFF0
	public SimpleSafeUInt32[] mission_vec { /* [XID] */ /* 0x0000000189974730-0x0000000189974750 */ get => default; /* [XID] */ /* 0x000000018997BD00-0x000000018997BD20 */ protected set {} } // 0x0000000184B4E0D0-0x0000000184B4E170 0x0000000184B4DEA0-0x0000000184B4DF50
	public SimpleSafeUInt32[] watcher_id_vec { /* [XID] */ /* 0x00000001899838B0-0x00000001899838D0 */ get => default; /* [XID] */ /* 0x000000018998B120-0x000000018998B140 */ protected set {} } // 0x0000000184B4EE70-0x0000000184B4EF10 0x0000000184B4EBB0-0x0000000184B4EC60
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189992C70-0x0000000189992C90 */ get => default; /* [XID] */ /* 0x000000018999A810-0x000000018999A830 */ protected set {} } // 0x0000000184B4C750-0x0000000184B4C7F0 0x0000000184B4C8A0-0x0000000184B4C950
	public string title { /* [XID] */ /* 0x00000001899A1F70-0x00000001899A1F90 */ get => default; } // 0x0000000184B4E8B0-0x0000000184B4EA30 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001899A9840-0x00000001899A9860 */ get => default; /* [XID] */ /* 0x00000001899B1270-0x00000001899B1290 */ protected set {} } // 0x0000000184B4E810-0x0000000184B4E8B0 0x0000000184B4C7F0-0x0000000184B4C8A0
	public string desc { /* [XID] */ /* 0x00000001899B8530-0x00000001899B8550 */ get => default; } // 0x0000000184B4DF50-0x0000000184B4E0D0 

	// Constructors
	public AsterLittleExcelConfig() {} // 0x0000000184B4F090-0x0000000184B4F0F0

	// Methods
	// [IDTag] // 0x00000001899BFFD0-0x00000001899C0010
	// [XID] // 0x00000001899BFFD0-0x00000001899C0010
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184B4D390-0x0000000184B4DDC0
	// [IDTag] // 0x00000001899CA700-0x00000001899CA740
	// [XID] // 0x00000001899CA700-0x00000001899CA740
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B4C950-0x0000000184B4D390
	// [XID] // 0x00000001899D4CD0-0x00000001899D4CF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE76 */, bool useObjectPool = false /* Metadata: 0x00AEFE7A */) => default; // 0x0000000184B4E170-0x0000000184B4E810
	[BlackList] // 0x00000001899DC3B0-0x00000001899DC3F0
	// [XID] // 0x00000001899DC3B0-0x00000001899DC3F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B4C520-0x0000000184B4C5C0
	[BlackList] // 0x00000001899E6E30-0x00000001899E6E70
	// [XID] // 0x00000001899E6E30-0x00000001899E6E70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B4C5C0-0x0000000184B4C6B0
	[BlackList] // 0x00000001899F11F0-0x00000001899F1230
	// [XID] // 0x00000001899F11F0-0x00000001899F1230
	public virtual void ReturnToObjectPool() {} // 0x0000000184B4EFF0-0x0000000184B4F090
	[BlackList] // 0x00000001899FBD50-0x00000001899FBD90
	// [XID] // 0x00000001899FBD50-0x00000001899FBD90
	public virtual void OnPoolAllocated() {} // 0x0000000184B4EDD0-0x0000000184B4EE70
	[BlackList] // 0x0000000189A06310-0x0000000189A06350
	// [XID] // 0x0000000189A06310-0x0000000189A06350
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B4ED30-0x0000000184B4EDD0
}


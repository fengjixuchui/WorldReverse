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
public class PS4GroupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14997
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected string _iconPath; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189678070-0x0000000189678090 */ get => default; /* [XID] */ /* 0x000000018967F820-0x000000018967F840 */ protected set {} } // 0x0000000184AF8240-0x0000000184AF8310 0x0000000184AF78D0-0x0000000184AF79B0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189686FF0-0x0000000189687010 */ get => default; /* [XID] */ /* 0x000000018968EDF0-0x000000018968EE10 */ protected set {} } // 0x0000000184AF6FA0-0x0000000184AF7040 0x0000000184AF7FA0-0x0000000184AF8050
	public string name { /* [XID] */ /* 0x0000000189696770-0x0000000189696790 */ get => default; } // 0x0000000184AF8310-0x0000000184AF8490 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018969DE10-0x000000018969DE30 */ get => default; /* [XID] */ /* 0x00000001896A4E00-0x00000001896A4E20 */ protected set {} } // 0x0000000184AF7F00-0x0000000184AF7FA0 0x0000000184AF7040-0x0000000184AF70F0
	public string desc { /* [XID] */ /* 0x00000001896AC6B0-0x00000001896AC6D0 */ get => default; } // 0x0000000184AF7750-0x0000000184AF78D0 
	public string iconPath { /* [XID] */ /* 0x00000001896B3930-0x00000001896B3950 */ get => default; /* [XID] */ /* 0x00000001896BB030-0x00000001896BB050 */ protected set {} } // 0x0000000184AF7E60-0x0000000184AF7F00 0x0000000184AF8050-0x0000000184AF8100

	// Constructors
	public PS4GroupExcelConfig() {} // 0x0000000184AF8530-0x0000000184AF8590

	// Methods
	// [IDTag] // 0x00000001896C21C0-0x00000001896C2200
	// [XID] // 0x00000001896C21C0-0x00000001896C2200
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184AF70F0-0x0000000184AF7440
	// [IDTag] // 0x00000001896CC8D0-0x00000001896CC910
	// [XID] // 0x00000001896CC8D0-0x00000001896CC910
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184AF7440-0x0000000184AF7750
	// [XID] // 0x00000001896D6E00-0x00000001896D6E20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDFD */, bool useObjectPool = false /* Metadata: 0x00AEFE01 */) => default; // 0x0000000184AF79B0-0x0000000184AF7E60
	[BlackList] // 0x00000001896DE5A0-0x00000001896DE5E0
	// [XID] // 0x00000001896DE5A0-0x00000001896DE5E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184AF6E20-0x0000000184AF6EC0
	[BlackList] // 0x00000001896E8A40-0x00000001896E8A80
	// [XID] // 0x00000001896E8A40-0x00000001896E8A80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184AF6EC0-0x0000000184AF6FA0
	[BlackList] // 0x00000001896F2FD0-0x00000001896F3010
	// [XID] // 0x00000001896F2FD0-0x00000001896F3010
	public virtual void ReturnToObjectPool() {} // 0x0000000184AF8490-0x0000000184AF8530
	[BlackList] // 0x00000001896FD950-0x00000001896FD990
	// [XID] // 0x00000001896FD950-0x00000001896FD990
	public virtual void OnPoolAllocated() {} // 0x0000000184AF81A0-0x0000000184AF8240
	[BlackList] // 0x0000000189707D30-0x0000000189707D70
	// [XID] // 0x0000000189707D30-0x0000000189707D70
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184AF8100-0x0000000184AF81A0
}


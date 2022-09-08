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
public class AsterTeamBuffExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15026
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected uint _nameTextMapHash; // 0x18
	protected uint _descTextMapHash; // 0x1C
	protected string _icon; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001895EB110-0x00000001895EB130 */ get => default; /* [XID] */ /* 0x00000001895F2590-0x00000001895F25B0 */ protected set {} } // 0x0000000181C81580-0x0000000181C81650 0x0000000181C80B40-0x0000000181C80C20
	public uint activityId { /* [XID] */ /* 0x00000001895FA020-0x00000001895FA040 */ get => default; /* [XID] */ /* 0x0000000189601740-0x0000000189601760 */ protected set {} } // 0x0000000181C812C0-0x0000000181C81390 0x0000000181C80A60-0x0000000181C80B40
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189608FF0-0x0000000189609010 */ get => default; /* [XID] */ /* 0x0000000189610830-0x0000000189610850 */ protected set {} } // 0x0000000181C80040-0x0000000181C800E0 0x0000000181C81210-0x0000000181C812C0
	public string name { /* [XID] */ /* 0x0000000189617AF0-0x0000000189617B10 */ get => default; } // 0x0000000181C81650-0x0000000181C817D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018961F7E0-0x000000018961F800 */ get => default; /* [XID] */ /* 0x0000000189626B40-0x0000000189626B60 */ protected set {} } // 0x0000000181C81170-0x0000000181C81210 0x0000000181C800E0-0x0000000181C80190
	public string desc { /* [XID] */ /* 0x000000018962E430-0x000000018962E450 */ get => default; } // 0x0000000181C808E0-0x0000000181C80A60 
	public string icon { /* [XID] */ /* 0x0000000189636030-0x0000000189636050 */ get => default; /* [XID] */ /* 0x000000018963D710-0x000000018963D730 */ protected set {} } // 0x0000000181C7FE10-0x0000000181C7FEB0 0x0000000181C81390-0x0000000181C81440

	// Constructors
	public AsterTeamBuffExcelConfig() {} // 0x0000000181C81870-0x0000000181C818D0

	// Methods
	// [IDTag] // 0x0000000189644C70-0x0000000189644CB0
	// [XID] // 0x0000000189644C70-0x0000000189644CB0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C80520-0x0000000181C808E0
	// [IDTag] // 0x000000018964F2E0-0x000000018964F320
	// [XID] // 0x000000018964F2E0-0x000000018964F320
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C80190-0x0000000181C80520
	// [XID] // 0x0000000189659B10-0x0000000189659B30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFED0 */, bool useObjectPool = false /* Metadata: 0x00AEFED4 */) => default; // 0x0000000181C80C20-0x0000000181C81170
	[BlackList] // 0x00000001896612B0-0x00000001896612F0
	// [XID] // 0x00000001896612B0-0x00000001896612F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C7FEB0-0x0000000181C7FF50
	[BlackList] // 0x000000018966B880-0x000000018966B8C0
	// [XID] // 0x000000018966B880-0x000000018966B8C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C7FF50-0x0000000181C80040
	[BlackList] // 0x0000000189676680-0x00000001896766C0
	// [XID] // 0x0000000189676680-0x00000001896766C0
	public virtual void ReturnToObjectPool() {} // 0x0000000181C817D0-0x0000000181C81870
	[BlackList] // 0x00000001896810A0-0x00000001896810E0
	// [XID] // 0x00000001896810A0-0x00000001896810E0
	public virtual void OnPoolAllocated() {} // 0x0000000181C814E0-0x0000000181C81580
	[BlackList] // 0x000000018968BAB0-0x000000018968BAF0
	// [XID] // 0x000000018968BAB0-0x000000018968BAF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C81440-0x0000000181C814E0
}


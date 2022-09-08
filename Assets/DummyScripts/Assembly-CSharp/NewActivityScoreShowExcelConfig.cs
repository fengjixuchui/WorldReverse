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
public class NewActivityScoreShowExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15905
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _descTextMapHash; // 0x14
	protected SimpleSafeUInt32 scoreRawNum; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A74350-0x0000000189A74370 */ get => default; /* [XID] */ /* 0x0000000189A7BD40-0x0000000189A7BD60 */ protected set {} } // 0x000000018294F850-0x000000018294F920 0x000000018294F180-0x000000018294F260
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A83720-0x0000000189A83740 */ get => default; /* [XID] */ /* 0x0000000189A8AF80-0x0000000189A8AFA0 */ protected set {} } // 0x000000018294F670-0x000000018294F710 0x000000018294E900-0x000000018294E9B0
	public string desc { /* [XID] */ /* 0x0000000189A92750-0x0000000189A92770 */ get => default; } // 0x000000018294EF30-0x000000018294F0B0 
	public uint score { /* [XID] */ /* 0x0000000189A9A1A0-0x0000000189A9A1C0 */ get => default; /* [XID] */ /* 0x0000000189AA1180-0x0000000189AA11A0 */ protected set {} } // 0x000000018294F0B0-0x000000018294F180 0x000000018294E690-0x000000018294E770

	// Constructors
	public NewActivityScoreShowExcelConfig() {} // 0x000000018294F9C0-0x000000018294FA20

	// Methods
	// [IDTag] // 0x0000000189AA88C0-0x0000000189AA8900
	// [XID] // 0x0000000189AA88C0-0x0000000189AA8900
	public virtual bool ParseFromLine(string line) => default; // 0x000000018294EC50-0x000000018294EF30
	// [IDTag] // 0x0000000189AB3480-0x0000000189AB34C0
	// [XID] // 0x0000000189AB3480-0x0000000189AB34C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018294E9B0-0x000000018294EC50
	// [XID] // 0x0000000189ABDF70-0x0000000189ABDF90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AC8 */, bool useObjectPool = false /* Metadata: 0x00AF2ACC */) => default; // 0x000000018294F260-0x000000018294F670
	[BlackList] // 0x0000000189AC5A90-0x0000000189AC5AD0
	// [XID] // 0x0000000189AC5A90-0x0000000189AC5AD0
	public virtual void AutoAllocTypeFields() {} // 0x000000018294E770-0x000000018294E810
	[BlackList] // 0x0000000189ACFEB0-0x0000000189ACFEF0
	// [XID] // 0x0000000189ACFEB0-0x0000000189ACFEF0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018294E810-0x000000018294E900
	[BlackList] // 0x0000000189ADAC00-0x0000000189ADAC40
	// [XID] // 0x0000000189ADAC00-0x0000000189ADAC40
	public virtual void ReturnToObjectPool() {} // 0x000000018294F920-0x000000018294F9C0
	[BlackList] // 0x0000000189AE5940-0x0000000189AE5980
	// [XID] // 0x0000000189AE5940-0x0000000189AE5980
	public virtual void OnPoolAllocated() {} // 0x000000018294F7B0-0x000000018294F850
	[BlackList] // 0x0000000189AF0430-0x0000000189AF0470
	// [XID] // 0x0000000189AF0430-0x0000000189AF0470
	public virtual void OnBeforePoolRecycled() {} // 0x000000018294F710-0x000000018294F7B0
}


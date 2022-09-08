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
public class ReputationFunctionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16050
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 functionIdRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected uint _shopDescTextMapHash; // 0x1C

	// Properties
	public uint functionId { /* [XID] */ /* 0x00000001897EC2C0-0x00000001897EC2E0 */ get => default; /* [XID] */ /* 0x00000001897F3C10-0x00000001897F3C30 */ protected set {} } // 0x0000000183D8B7B0-0x0000000183D8B880 0x0000000183D8BA00-0x0000000183D8BAE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001897FB630-0x00000001897FB650 */ get => default; /* [XID] */ /* 0x0000000189802A80-0x0000000189802AA0 */ protected set {} } // 0x0000000183D8AEA0-0x0000000183D8AF40 0x0000000183D8C030-0x0000000183D8C0E0
	public string name { /* [XID] */ /* 0x000000018980A050-0x000000018980A070 */ get => default; } // 0x0000000183D8C3A0-0x0000000183D8C520 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189811700-0x0000000189811720 */ get => default; /* [XID] */ /* 0x0000000189819350-0x0000000189819370 */ protected set {} } // 0x0000000183D8BF90-0x0000000183D8C030 0x0000000183D8AF40-0x0000000183D8AFF0
	public string desc { /* [XID] */ /* 0x0000000189820B30-0x0000000189820B50 */ get => default; } // 0x0000000183D8B880-0x0000000183D8BA00 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint shopDescTextMapHash { /* [XID] */ /* 0x0000000189828060-0x0000000189828080 */ get => default; /* [XID] */ /* 0x000000018982F2E0-0x000000018982F300 */ protected set {} } // 0x0000000183D8B660-0x0000000183D8B700 0x0000000183D8B700-0x0000000183D8B7B0
	public string shopDesc { /* [XID] */ /* 0x0000000189836BD0-0x0000000189836BF0 */ get => default; } // 0x0000000183D8C0E0-0x0000000183D8C260 

	// Constructors
	public ReputationFunctionExcelConfig() {} // 0x0000000183D8C5C0-0x0000000183D8C620

	// Methods
	// [IDTag] // 0x000000018983DFE0-0x000000018983E020
	// [XID] // 0x000000018983DFE0-0x000000018983E020
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183D8B310-0x0000000183D8B660
	// [IDTag] // 0x00000001898483A0-0x00000001898483E0
	// [XID] // 0x00000001898483A0-0x00000001898483E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183D8AFF0-0x0000000183D8B310
	// [XID] // 0x0000000189852740-0x0000000189852760
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2EEC */, bool useObjectPool = false /* Metadata: 0x00AF2EF0 */) => default; // 0x0000000183D8BAE0-0x0000000183D8BF90
	[BlackList] // 0x000000018985A1D0-0x000000018985A210
	// [XID] // 0x000000018985A1D0-0x000000018985A210
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D8AD20-0x0000000183D8ADC0
	[BlackList] // 0x00000001898645B0-0x00000001898645F0
	// [XID] // 0x00000001898645B0-0x00000001898645F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D8ADC0-0x0000000183D8AEA0
	[BlackList] // 0x000000018986EAB0-0x000000018986EAF0
	// [XID] // 0x000000018986EAB0-0x000000018986EAF0
	public virtual void ReturnToObjectPool() {} // 0x0000000183D8C520-0x0000000183D8C5C0
	[BlackList] // 0x0000000189878FF0-0x0000000189879030
	// [XID] // 0x0000000189878FF0-0x0000000189879030
	public virtual void OnPoolAllocated() {} // 0x0000000183D8C300-0x0000000183D8C3A0
	[BlackList] // 0x0000000189883150-0x0000000189883190
	// [XID] // 0x0000000189883150-0x0000000189883190
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D8C260-0x0000000183D8C300
}


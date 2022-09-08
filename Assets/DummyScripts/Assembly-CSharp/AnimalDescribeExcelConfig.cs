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
public class AnimalDescribeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15848
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected string _icon; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x000000018965E1F0-0x000000018965E210 */ get => default; /* [XID] */ /* 0x00000001896658D0-0x00000001896658F0 */ protected set {} } // 0x0000000183673A30-0x0000000183673B00 0x00000001836732A0-0x0000000183673380
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x000000018966CFC0-0x000000018966CFE0 */ get => default; /* [XID] */ /* 0x0000000189674EB0-0x0000000189674ED0 */ protected set {} } // 0x0000000183672C80-0x0000000183672D20 0x0000000183673790-0x0000000183673840
	public string name { /* [XID] */ /* 0x000000018967C720-0x000000018967C740 */ get => default; } // 0x0000000183673B00-0x0000000183673C80 
	public string icon { /* [XID] */ /* 0x0000000189683DD0-0x0000000189683DF0 */ get => default; /* [XID] */ /* 0x000000018968B9B0-0x000000018968B9D0 */ protected set {} } // 0x0000000183672A60-0x0000000183672B00 0x0000000183673840-0x00000001836738F0

	// Constructors
	public AnimalDescribeExcelConfig() {} // 0x0000000183673D20-0x0000000183673D80

	// Methods
	// [IDTag] // 0x00000001896935C0-0x0000000189693600
	// [XID] // 0x00000001896935C0-0x0000000189693600
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183672D20-0x0000000183673000
	// [IDTag] // 0x000000018969DBF0-0x000000018969DC30
	// [XID] // 0x000000018969DBF0-0x000000018969DC30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183673000-0x00000001836732A0
	// [XID] // 0x00000001896A7D60-0x00000001896A7D80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2845 */, bool useObjectPool = false /* Metadata: 0x00AF2849 */) => default; // 0x0000000183673380-0x0000000183673790
	[BlackList] // 0x00000001896AF1B0-0x00000001896AF1F0
	// [XID] // 0x00000001896AF1B0-0x00000001896AF1F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183672B00-0x0000000183672BA0
	[BlackList] // 0x00000001896B95F0-0x00000001896B9630
	// [XID] // 0x00000001896B95F0-0x00000001896B9630
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183672BA0-0x0000000183672C80
	[BlackList] // 0x00000001896C39A0-0x00000001896C39E0
	// [XID] // 0x00000001896C39A0-0x00000001896C39E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183673C80-0x0000000183673D20
	[BlackList] // 0x00000001896CE0D0-0x00000001896CE110
	// [XID] // 0x00000001896CE0D0-0x00000001896CE110
	public virtual void OnPoolAllocated() {} // 0x0000000183673990-0x0000000183673A30
	[BlackList] // 0x00000001896D84B0-0x00000001896D84F0
	// [XID] // 0x00000001896D84B0-0x00000001896D84F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836738F0-0x0000000183673990
}


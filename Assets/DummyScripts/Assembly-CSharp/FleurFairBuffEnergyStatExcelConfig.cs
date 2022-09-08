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
public class FleurFairBuffEnergyStatExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15109
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 galleryIdRawNum; // 0x14
	protected string _statParam; // 0x18
	protected SimpleSafeUInt32 priorityRawNum; // 0x20
	protected uint _titleTextMapHash; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x000000018966A480-0x000000018966A4A0 */ get => default; /* [XID] */ /* 0x00000001896720E0-0x0000000189672100 */ protected set {} } // 0x000000018312E930-0x000000018312EA00 0x000000018312DE90-0x000000018312DF70
	public uint galleryId { /* [XID] */ /* 0x00000001896799B0-0x00000001896799D0 */ get => default; /* [XID] */ /* 0x0000000189681080-0x00000001896810A0 */ protected set {} } // 0x000000018312EA00-0x000000018312EAD0 0x000000018312E710-0x000000018312E7F0
	public string statParam { /* [XID] */ /* 0x0000000189688B60-0x0000000189688B80 */ get => default; /* [XID] */ /* 0x00000001896905E0-0x0000000189690600 */ protected set {} } // 0x000000018312D450-0x000000018312D4F0 0x000000018312DDE0-0x000000018312DE90
	public uint priority { /* [XID] */ /* 0x0000000189697E80-0x0000000189697EA0 */ get => default; /* [XID] */ /* 0x000000018969F110-0x000000018969F130 */ protected set {} } // 0x000000018312E4C0-0x000000018312E590 0x000000018312DD00-0x000000018312DDE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001896A65B0-0x00000001896A65D0 */ get => default; /* [XID] */ /* 0x00000001896ADAF0-0x00000001896ADB10 */ protected set {} } // 0x000000018312D3B0-0x000000018312D450 0x000000018312D4F0-0x000000018312D5A0
	public string title { /* [XID] */ /* 0x00000001896B5310-0x00000001896B5330 */ get => default; } // 0x000000018312E590-0x000000018312E710 

	// Constructors
	public FleurFairBuffEnergyStatExcelConfig() {} // 0x000000018312EB70-0x000000018312EBD0

	// Methods
	// [IDTag] // 0x00000001896BC4E0-0x00000001896BC520
	// [XID] // 0x00000001896BC4E0-0x00000001896BC520
	public virtual bool ParseFromLine(string line) => default; // 0x000000018312D940-0x000000018312DD00
	// [IDTag] // 0x00000001896C6AD0-0x00000001896C6B10
	// [XID] // 0x00000001896C6AD0-0x00000001896C6B10
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018312D5A0-0x000000018312D940
	// [XID] // 0x00000001896D0EA0-0x00000001896D0EC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0111 */, bool useObjectPool = false /* Metadata: 0x00AF0115 */) => default; // 0x000000018312DF70-0x000000018312E4C0
	[BlackList] // 0x00000001896D85F0-0x00000001896D8630
	// [XID] // 0x00000001896D85F0-0x00000001896D8630
	public virtual void AutoAllocTypeFields() {} // 0x000000018312D210-0x000000018312D2B0
	[BlackList] // 0x00000001896E2D00-0x00000001896E2D40
	// [XID] // 0x00000001896E2D00-0x00000001896E2D40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018312D2B0-0x000000018312D3B0
	[BlackList] // 0x00000001896ECF60-0x00000001896ECFA0
	// [XID] // 0x00000001896ECF60-0x00000001896ECFA0
	public virtual void ReturnToObjectPool() {} // 0x000000018312EAD0-0x000000018312EB70
	[BlackList] // 0x00000001896F7790-0x00000001896F77D0
	// [XID] // 0x00000001896F7790-0x00000001896F77D0
	public virtual void OnPoolAllocated() {} // 0x000000018312E890-0x000000018312E930
	[BlackList] // 0x0000000189701E00-0x0000000189701E40
	// [XID] // 0x0000000189701E00-0x0000000189701E40
	public virtual void OnBeforePoolRecycled() {} // 0x000000018312E7F0-0x000000018312E890
}


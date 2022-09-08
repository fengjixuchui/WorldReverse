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
public class DocumentExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15824
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _titleTextMapHash; // 0x14
	protected SimpleSafeUInt32 contentLocalizedIdRawNum; // 0x18
	protected string _previewPath; // 0x20
	protected DocumentType _documentType; // 0x28
	protected string _videoPath; // 0x30
	protected SimpleSafeUInt32 subtitleIDRawNum; // 0x38

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896B0610-0x00000001896B0630 */ get => default; /* [XID] */ /* 0x00000001896B8070-0x00000001896B8090 */ protected set {} } // 0x00000001853AC790-0x00000001853AC860 0x00000001853ABBE0-0x00000001853ABCC0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001896BF110-0x00000001896BF130 */ get => default; /* [XID] */ /* 0x00000001896C69F0-0x00000001896C6A10 */ protected set {} } // 0x00000001853AAD60-0x00000001853AAE00 0x00000001853AAE00-0x00000001853AAEB0
	public string title { /* [XID] */ /* 0x00000001896CE110-0x00000001896CE130 */ get => default; } // 0x00000001853AC400-0x00000001853AC580 
	public uint contentLocalizedId { /* [XID] */ /* 0x00000001896D5640-0x00000001896D5660 */ get => default; /* [XID] */ /* 0x00000001896DCB00-0x00000001896DCB20 */ protected set {} } // 0x00000001853AC580-0x00000001853AC650 0x00000001853AB980-0x00000001853ABA60
	public string previewPath { /* [XID] */ /* 0x00000001896E4470-0x00000001896E4490 */ get => default; /* [XID] */ /* 0x00000001896EB8A0-0x00000001896EB8C0 */ protected set {} } // 0x00000001853AC360-0x00000001853AC400 0x00000001853AB800-0x00000001853AB8B0
	public DocumentType documentType { /* [XID] */ /* 0x00000001896F2D10-0x00000001896F2D30 */ get => default; /* [XID] */ /* 0x00000001896FA630-0x00000001896FA650 */ protected set {} } // 0x00000001853AAA70-0x00000001853AAB10 0x00000001853AC860-0x00000001853AC910
	public string videoPath { /* [XID] */ /* 0x0000000189701CA0-0x0000000189701CC0 */ get => default; /* [XID] */ /* 0x00000001897095A0-0x00000001897095C0 */ protected set {} } // 0x00000001853ABB40-0x00000001853ABBE0 0x00000001853AAB10-0x00000001853AABC0
	public uint subtitleID { /* [XID] */ /* 0x0000000189710E30-0x0000000189710E50 */ get => default; /* [XID] */ /* 0x0000000189718190-0x00000001897181B0 */ protected set {} } // 0x00000001853AB8B0-0x00000001853AB980 0x00000001853ABA60-0x00000001853ABB40

	// Constructors
	public DocumentExcelConfig() {} // 0x00000001853AC9B0-0x00000001853ACA10

	// Methods
	// [IDTag] // 0x000000018971FB30-0x000000018971FB70
	// [XID] // 0x000000018971FB30-0x000000018971FB70
	public virtual bool ParseFromLine(string line) => default; // 0x00000001853AB350-0x00000001853AB800
	// [IDTag] // 0x0000000189729F00-0x0000000189729F40
	// [XID] // 0x0000000189729F00-0x0000000189729F40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001853AAEB0-0x00000001853AB350
	// [XID] // 0x0000000189734670-0x0000000189734690
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF277C */, bool useObjectPool = false /* Metadata: 0x00AF2780 */) => default; // 0x00000001853ABCC0-0x00000001853AC360
	[BlackList] // 0x000000018973C040-0x000000018973C080
	// [XID] // 0x000000018973C040-0x000000018973C080
	public virtual void AutoAllocTypeFields() {} // 0x00000001853AABC0-0x00000001853AAC60
	[BlackList] // 0x00000001897468A0-0x00000001897468E0
	// [XID] // 0x00000001897468A0-0x00000001897468E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001853AAC60-0x00000001853AAD60
	[BlackList] // 0x0000000189750F40-0x0000000189750F80
	// [XID] // 0x0000000189750F40-0x0000000189750F80
	public virtual void ReturnToObjectPool() {} // 0x00000001853AC910-0x00000001853AC9B0
	[BlackList] // 0x000000018975B360-0x000000018975B3A0
	// [XID] // 0x000000018975B360-0x000000018975B3A0
	public virtual void OnPoolAllocated() {} // 0x00000001853AC6F0-0x00000001853AC790
	[BlackList] // 0x0000000189765BB0-0x0000000189765BF0
	// [XID] // 0x0000000189765BB0-0x0000000189765BF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001853AC650-0x00000001853AC6F0
}


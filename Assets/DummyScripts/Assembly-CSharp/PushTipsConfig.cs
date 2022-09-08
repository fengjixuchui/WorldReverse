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
public class PushTipsConfig : IAutoAllocRecycle // TypeDefIndex: 16264
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 pushTipsIdRawNum; // 0x10
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x14
	protected uint _titleTextMapHash; // 0x18
	protected uint _subtitleTextMapHash; // 0x1C
	protected PushTipsType _pushTipsType; // 0x20
	protected string _showIcon; // 0x28
	protected string _tabIcon; // 0x30
	protected SimpleSafeUInt32 tutorialIdRawNum; // 0x38
	protected PushTipsCodexType _codexType; // 0x3C
	protected SimpleSafeUInt32 groupIdRawNum; // 0x40
	protected bool _showImmediately; // 0x44

	// Properties
	public uint pushTipsId { /* [XID] */ /* 0x0000000189A36D50-0x0000000189A36D70 */ get => default; /* [XID] */ /* 0x0000000189A3E350-0x0000000189A3E370 */ protected set {} } // 0x000000018508B1B0-0x000000018508B280 0x000000018508C430-0x000000018508C510
	public uint rewardId { /* [XID] */ /* 0x0000000189A459E0-0x0000000189A45A00 */ get => default; /* [XID] */ /* 0x0000000189A4D0C0-0x0000000189A4D0E0 */ protected set {} } // 0x000000018508D100-0x000000018508D1D0 0x000000018508AE60-0x000000018508AF40
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189A54870-0x0000000189A54890 */ get => default; /* [XID] */ /* 0x0000000189A5C300-0x0000000189A5C320 */ protected set {} } // 0x000000018508B280-0x000000018508B320 0x000000018508B540-0x000000018508B5F0
	public string title { /* [XID] */ /* 0x0000000189A63CF0-0x0000000189A63D10 */ get => default; } // 0x000000018508D280-0x000000018508D400 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint subtitleTextMapHash { /* [XID] */ /* 0x0000000189A6B510-0x0000000189A6B530 */ get => default; /* [XID] */ /* 0x0000000189A72D00-0x0000000189A72D20 */ protected set {} } // 0x000000018508D060-0x000000018508D100 0x000000018508C2E0-0x000000018508C390
	public string subtitle { /* [XID] */ /* 0x0000000189A7A870-0x0000000189A7A890 */ get => default; } // 0x000000018508B320-0x000000018508B4A0 
	public PushTipsType pushTipsType { /* [XID] */ /* 0x0000000189A81D10-0x0000000189A81D30 */ get => default; /* [XID] */ /* 0x0000000189A89830-0x0000000189A89850 */ protected set {} } // 0x000000018508D690-0x000000018508D730 0x000000018508C510-0x000000018508C5C0
	public string showIcon { /* [XID] */ /* 0x0000000189A90F10-0x0000000189A90F30 */ get => default; /* [XID] */ /* 0x0000000189A987A0-0x0000000189A987C0 */ protected set {} } // 0x000000018508B4A0-0x000000018508B540 0x000000018508C690-0x000000018508C740
	public string tabIcon { /* [XID] */ /* 0x0000000189A9FC50-0x0000000189A9FC70 */ get => default; /* [XID] */ /* 0x0000000189AA7360-0x0000000189AA7380 */ protected set {} } // 0x000000018508C390-0x000000018508C430 0x000000018508D1D0-0x000000018508D280
	public uint tutorialId { /* [XID] */ /* 0x0000000189AAEAA0-0x0000000189AAEAC0 */ get => default; /* [XID] */ /* 0x0000000189AB63A0-0x0000000189AB63C0 */ protected set {} } // 0x000000018508C5C0-0x000000018508C690 0x000000018508D400-0x000000018508D4E0
	public PushTipsCodexType codexType { /* [XID] */ /* 0x0000000189ABDE70-0x0000000189ABDE90 */ get => default; /* [XID] */ /* 0x0000000189AC59B0-0x0000000189AC59D0 */ protected set {} } // 0x000000018508D7D0-0x000000018508D870 0x000000018508D870-0x000000018508D920
	public uint groupId { /* [XID] */ /* 0x0000000189ACCF20-0x0000000189ACCF40 */ get => default; /* [XID] */ /* 0x0000000189AD4BE0-0x0000000189AD4C00 */ protected set {} } // 0x000000018508D4E0-0x000000018508D5B0 0x000000018508D5B0-0x000000018508D690
	public bool showImmediately { /* [XID] */ /* 0x0000000189ADC560-0x0000000189ADC580 */ get => default; /* [XID] */ /* 0x0000000189AE3EF0-0x0000000189AE3F10 */ protected set {} } // 0x000000018508D730-0x000000018508D7D0 0x000000018508AF40-0x000000018508AFF0

	// Constructors
	public PushTipsConfig() {} // 0x000000018508DB00-0x000000018508DB60

	// Methods
	// [IDTag] // 0x0000000189AEB770-0x0000000189AEB7B0
	// [XID] // 0x0000000189AEB770-0x0000000189AEB7B0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018508B5F0-0x000000018508BC60
	// [IDTag] // 0x0000000189AF6030-0x0000000189AF6070
	// [XID] // 0x0000000189AF6030-0x0000000189AF6070
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018508BC60-0x000000018508C2E0
	// [XID] // 0x0000000189B006B0-0x0000000189B006D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF35ED */, bool useObjectPool = false /* Metadata: 0x00AF35F1 */) => default; // 0x000000018508C740-0x000000018508D060
	[BlackList] // 0x0000000189B07C50-0x0000000189B07C90
	// [XID] // 0x0000000189B07C50-0x0000000189B07C90
	public virtual void AutoAllocTypeFields() {} // 0x000000018508AFF0-0x000000018508B090
	[BlackList] // 0x0000000189B124A0-0x0000000189B124E0
	// [XID] // 0x0000000189B124A0-0x0000000189B124E0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018508B090-0x000000018508B1B0
	[BlackList] // 0x0000000189B1CB50-0x0000000189B1CB90
	// [XID] // 0x0000000189B1CB50-0x0000000189B1CB90
	public virtual void ReturnToObjectPool() {} // 0x000000018508DA60-0x000000018508DB00
	[BlackList] // 0x0000000189B270C0-0x0000000189B27100
	// [XID] // 0x0000000189B270C0-0x0000000189B27100
	public virtual void OnPoolAllocated() {} // 0x000000018508D9C0-0x000000018508DA60
	[BlackList] // 0x0000000189B313F0-0x0000000189B31430
	// [XID] // 0x0000000189B313F0-0x0000000189B31430
	public virtual void OnBeforePoolRecycled() {} // 0x000000018508D920-0x000000018508D9C0
}


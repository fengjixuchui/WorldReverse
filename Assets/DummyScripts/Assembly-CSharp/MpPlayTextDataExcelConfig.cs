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
public class MpPlayTextDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15873
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 mpPlayIdRawNum; // 0x10
	protected uint _questTextMapHash; // 0x14
	protected uint _rewardTextMapHash; // 0x18
	protected uint _inviteTextMapHash; // 0x1C
	protected uint _invitedescTextMapHash; // 0x20
	protected uint _invitedeschostTextMapHash; // 0x24
	protected uint _startTextMapHash; // 0x28
	protected uint _starttipTextMapHash; // 0x2C
	protected uint _victoryTextMapHash; // 0x30
	protected uint _failTextMapHash; // 0x34
	protected uint _riviveTextMapHash; // 0x38
	protected uint _timespendTextMapHash; // 0x3C
	protected uint _upAvatarTextTextMapHash; // 0x40

	// Properties
	public uint mpPlayId { /* [XID] */ /* 0x0000000189699360-0x0000000189699380 */ get => default; /* [XID] */ /* 0x00000001896A07D0-0x00000001896A07F0 */ protected set {} } // 0x000000018134B340-0x000000018134B410 0x0000000181348300-0x00000001813483E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint questTextMapHash { /* [XID] */ /* 0x00000001896A7D20-0x00000001896A7D40 */ get => default; /* [XID] */ /* 0x00000001896AF170-0x00000001896AF190 */ protected set {} } // 0x000000018134B8E0-0x000000018134B980 0x000000018134A1D0-0x000000018134A280
	public string quest { /* [XID] */ /* 0x00000001896B6700-0x00000001896B6720 */ get => default; } // 0x000000018134A480-0x000000018134A600 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint rewardTextMapHash { /* [XID] */ /* 0x00000001896BD9E0-0x00000001896BDA00 */ get => default; /* [XID] */ /* 0x00000001896C5190-0x00000001896C51B0 */ protected set {} } // 0x000000018134BED0-0x000000018134BF70 0x000000018134BAC0-0x000000018134BB70
	public string reward { /* [XID] */ /* 0x00000001896CC750-0x00000001896CC770 */ get => default; } // 0x0000000181349E20-0x0000000181349FA0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint inviteTextMapHash { /* [XID] */ /* 0x00000001896D3A40-0x00000001896D3A60 */ get => default; /* [XID] */ /* 0x00000001896DB480-0x00000001896DB4A0 */ protected set {} } // 0x000000018134A3E0-0x000000018134A480 0x0000000181348910-0x00000001813489C0
	public string invite { /* [XID] */ /* 0x00000001896E2C20-0x00000001896E2C40 */ get => default; } // 0x000000018134A050-0x000000018134A1D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint invitedescTextMapHash { /* [XID] */ /* 0x00000001896EA260-0x00000001896EA280 */ get => default; /* [XID] */ /* 0x00000001896F1220-0x00000001896F1240 */ protected set {} } // 0x0000000181349C00-0x0000000181349CA0 0x000000018134B830-0x000000018134B8E0
	public string invitedesc { /* [XID] */ /* 0x00000001896F8BA0-0x00000001896F8BC0 */ get => default; } // 0x0000000181349CA0-0x0000000181349E20 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint invitedeschostTextMapHash { /* [XID] */ /* 0x0000000189700380-0x00000001897003A0 */ get => default; /* [XID] */ /* 0x0000000189707B50-0x0000000189707B70 */ protected set {} } // 0x000000018134B570-0x000000018134B610 0x000000018134A600-0x000000018134A6B0
	public string invitedeschost { /* [XID] */ /* 0x000000018970F640-0x000000018970F660 */ get => default; } // 0x000000018134BF70-0x000000018134C0F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint startTextMapHash { /* [XID] */ /* 0x0000000189716960-0x0000000189716980 */ get => default; /* [XID] */ /* 0x000000018971E3A0-0x000000018971E3C0 */ protected set {} } // 0x000000018134B610-0x000000018134B6B0 0x000000018134B290-0x000000018134B340
	public string start { /* [XID] */ /* 0x0000000189725940-0x0000000189725960 */ get => default; } // 0x000000018134C0F0-0x000000018134C270 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint starttipTextMapHash { /* [XID] */ /* 0x000000018972CE80-0x000000018972CEA0 */ get => default; /* [XID] */ /* 0x0000000189734630-0x0000000189734650 */ protected set {} } // 0x000000018134BA20-0x000000018134BAC0 0x000000018134A280-0x000000018134A330
	public string starttip { /* [XID] */ /* 0x000000018973C000-0x000000018973C020 */ get => default; } // 0x0000000181348790-0x0000000181348910 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint victoryTextMapHash { /* [XID] */ /* 0x00000001897437F0-0x0000000189743810 */ get => default; /* [XID] */ /* 0x000000018974B400-0x000000018974B420 */ protected set {} } // 0x0000000181348A70-0x0000000181348B10 0x0000000181349FA0-0x000000018134A050
	public string victory { /* [XID] */ /* 0x00000001897525B0-0x00000001897525D0 */ get => default; } // 0x000000018134B110-0x000000018134B290 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint failTextMapHash { /* [XID] */ /* 0x0000000189759B20-0x0000000189759B40 */ get => default; /* [XID] */ /* 0x0000000189761790-0x00000001897617B0 */ protected set {} } // 0x00000001813486F0-0x0000000181348790 0x000000018134A330-0x000000018134A3E0
	public string fail { /* [XID] */ /* 0x0000000189768B60-0x0000000189768B80 */ get => default; } // 0x000000018134B6B0-0x000000018134B830 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint riviveTextMapHash { /* [XID] */ /* 0x0000000189770250-0x0000000189770270 */ get => default; /* [XID] */ /* 0x0000000189777910-0x0000000189777930 */ protected set {} } // 0x0000000181348C90-0x0000000181348D30 0x000000018134B4C0-0x000000018134B570
	public string rivive { /* [XID] */ /* 0x000000018977EF80-0x000000018977EFA0 */ get => default; } // 0x000000018134BD50-0x000000018134BED0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint timespendTextMapHash { /* [XID] */ /* 0x0000000189786980-0x00000001897869A0 */ get => default; /* [XID] */ /* 0x000000018978E030-0x000000018978E050 */ protected set {} } // 0x000000018134BCB0-0x000000018134BD50 0x000000018134B410-0x000000018134B4C0
	public string timespend { /* [XID] */ /* 0x0000000189795720-0x0000000189795740 */ get => default; } // 0x0000000181348B10-0x0000000181348C90 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint upAvatarTextTextMapHash { /* [XID] */ /* 0x000000018979DB70-0x000000018979DB90 */ get => default; /* [XID] */ /* 0x00000001897A4EB0-0x00000001897A4ED0 */ protected set {} } // 0x000000018134B980-0x000000018134BA20 0x00000001813489C0-0x0000000181348A70
	public string upAvatarText { /* [XID] */ /* 0x00000001897AC480-0x00000001897AC4A0 */ get => default; } // 0x0000000181348570-0x00000001813486F0 

	// Constructors
	public MpPlayTextDataExcelConfig() {} // 0x000000018134C310-0x000000018134C370

	// Methods
	// [IDTag] // 0x00000001897B43B0-0x00000001897B43F0
	// [XID] // 0x00000001897B43B0-0x00000001897B43F0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001813494A0-0x0000000181349C00
	// [IDTag] // 0x00000001897BF330-0x00000001897BF370
	// [XID] // 0x00000001897BF330-0x00000001897BF370
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181348D30-0x00000001813494A0
	// [XID] // 0x00000001897C98C0-0x00000001897C98E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF290A */, bool useObjectPool = false /* Metadata: 0x00AF290E */) => default; // 0x000000018134A6B0-0x000000018134B110
	[BlackList] // 0x00000001897D0EF0-0x00000001897D0F30
	// [XID] // 0x00000001897D0EF0-0x00000001897D0F30
	public virtual void AutoAllocTypeFields() {} // 0x00000001813483E0-0x0000000181348480
	[BlackList] // 0x00000001897DB850-0x00000001897DB890
	// [XID] // 0x00000001897DB850-0x00000001897DB890
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181348480-0x0000000181348570
	[BlackList] // 0x00000001897E6170-0x00000001897E61B0
	// [XID] // 0x00000001897E6170-0x00000001897E61B0
	public virtual void ReturnToObjectPool() {} // 0x000000018134C270-0x000000018134C310
	[BlackList] // 0x00000001897F0CE0-0x00000001897F0D20
	// [XID] // 0x00000001897F0CE0-0x00000001897F0D20
	public virtual void OnPoolAllocated() {} // 0x000000018134BC10-0x000000018134BCB0
	[BlackList] // 0x00000001897FB690-0x00000001897FB6D0
	// [XID] // 0x00000001897FB690-0x00000001897FB6D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018134BB70-0x000000018134BC10
}


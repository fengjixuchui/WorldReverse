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
public class AnimalCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15313
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected AnimalCodexType _type; // 0x14
	protected SimpleSafeUInt32 describeIdRawNum; // 0x18
	protected bool _isSeenActive; // 0x1C
	protected SimpleSafeUInt32 SortOrderRawNum; // 0x20
	protected bool _isDisuse; // 0x24
	protected bool _showOnlyUnlocked; // 0x25
	protected AnimalCodexSubType _subType; // 0x28
	protected uint _descTextMapHash; // 0x2C
	protected string _modelPath; // 0x30
	protected SimpleSafeUInt32 pushTipsCodexIdRawNum; // 0x38

	// Properties
	public uint Id { /* [XID] */ /* 0x00000001897D4020-0x00000001897D4040 */ get => default; /* [XID] */ /* 0x00000001897DB930-0x00000001897DB950 */ protected set {} } // 0x0000000181C8BC80-0x0000000181C8BD50 0x0000000181C8CBE0-0x0000000181C8CCC0
	public AnimalCodexType type { /* [XID] */ /* 0x00000001897E31C0-0x00000001897E31E0 */ get => default; /* [XID] */ /* 0x00000001897EA920-0x00000001897EA940 */ protected set {} } // 0x0000000181C8D250-0x0000000181C8D2F0 0x0000000181C8CD90-0x0000000181C8CE40
	public uint describeId { /* [XID] */ /* 0x00000001897F26F0-0x00000001897F2710 */ get => default; /* [XID] */ /* 0x00000001897F9EE0-0x00000001897F9F00 */ protected set {} } // 0x0000000181C8D040-0x0000000181C8D110 0x0000000181C8BD50-0x0000000181C8BE30
	public bool isSeenActive { /* [XID] */ /* 0x0000000189801460-0x0000000189801480 */ get => default; /* [XID] */ /* 0x0000000189808880-0x00000001898088A0 */ protected set {} } // 0x0000000181C8BBE0-0x0000000181C8BC80 0x0000000181C8BF00-0x0000000181C8BFB0
	public uint SortOrder { /* [XID] */ /* 0x0000000189810270-0x0000000189810290 */ get => default; /* [XID] */ /* 0x0000000189817900-0x0000000189817920 */ protected set {} } // 0x0000000181C8BE30-0x0000000181C8BF00 0x0000000181C8BB00-0x0000000181C8BBE0
	public bool isDisuse { /* [XID] */ /* 0x000000018981F280-0x000000018981F2A0 */ get => default; /* [XID] */ /* 0x0000000189826770-0x0000000189826790 */ protected set {} } // 0x0000000181C8CE40-0x0000000181C8CEE0 0x0000000181C8CF90-0x0000000181C8D040
	public bool showOnlyUnlocked { /* [XID] */ /* 0x000000018982DE00-0x000000018982DE20 */ get => default; /* [XID] */ /* 0x0000000189835490-0x00000001898354B0 */ protected set {} } // 0x0000000181C8ABC0-0x0000000181C8AC60 0x0000000181C8AC60-0x0000000181C8AD10
	public AnimalCodexSubType subType { /* [XID] */ /* 0x000000018983CC70-0x000000018983CC90 */ get => default; /* [XID] */ /* 0x0000000189844340-0x0000000189844360 */ protected set {} } // 0x0000000181C8A9D0-0x0000000181C8AA70 0x0000000181C8CEE0-0x0000000181C8CF90
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018984B7B0-0x000000018984B7D0 */ get => default; /* [XID] */ /* 0x0000000189852800-0x0000000189852820 */ protected set {} } // 0x0000000181C8CA60-0x0000000181C8CB00 0x0000000181C8AB10-0x0000000181C8ABC0
	public string desc { /* [XID] */ /* 0x000000018985A2D0-0x000000018985A2F0 */ get => default; } // 0x0000000181C8BFB0-0x0000000181C8C130 
	public string modelPath { /* [XID] */ /* 0x00000001898614D0-0x00000001898614F0 */ get => default; /* [XID] */ /* 0x0000000189868C70-0x0000000189868C90 */ protected set {} } // 0x0000000181C8AA70-0x0000000181C8AB10 0x0000000181C8BA50-0x0000000181C8BB00
	public uint pushTipsCodexId { /* [XID] */ /* 0x00000001898700C0-0x00000001898700E0 */ get => default; /* [XID] */ /* 0x0000000189877730-0x0000000189877750 */ protected set {} } // 0x0000000181C8CCC0-0x0000000181C8CD90 0x0000000181C8CB00-0x0000000181C8CBE0

	// Constructors
	public AnimalCodexExcelConfig() {} // 0x0000000181C8D390-0x0000000181C8D3F0

	// Methods
	// [IDTag] // 0x000000018987EFA0-0x000000018987EFE0
	// [XID] // 0x000000018987EFA0-0x000000018987EFE0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C8B3B0-0x0000000181C8BA50
	// [IDTag] // 0x0000000189889400-0x0000000189889440
	// [XID] // 0x0000000189889400-0x0000000189889440
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C8AD10-0x0000000181C8B3B0
	// [XID] // 0x00000001898937D0-0x00000001898937F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0740 */, bool useObjectPool = false /* Metadata: 0x00AF0744 */) => default; // 0x0000000181C8C130-0x0000000181C8CA60
	[BlackList] // 0x000000018989AEF0-0x000000018989AF30
	// [XID] // 0x000000018989AEF0-0x000000018989AF30
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C8A810-0x0000000181C8A8B0
	[BlackList] // 0x00000001898A5560-0x00000001898A55A0
	// [XID] // 0x00000001898A5560-0x00000001898A55A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C8A8B0-0x0000000181C8A9D0
	[BlackList] // 0x00000001898AFB90-0x00000001898AFBD0
	// [XID] // 0x00000001898AFB90-0x00000001898AFBD0
	public virtual void ReturnToObjectPool() {} // 0x0000000181C8D2F0-0x0000000181C8D390
	[BlackList] // 0x00000001898BA680-0x00000001898BA6C0
	// [XID] // 0x00000001898BA680-0x00000001898BA6C0
	public virtual void OnPoolAllocated() {} // 0x0000000181C8D1B0-0x0000000181C8D250
	[BlackList] // 0x00000001898C4B40-0x00000001898C4B80
	// [XID] // 0x00000001898C4B40-0x00000001898C4B80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C8D110-0x0000000181C8D1B0
}


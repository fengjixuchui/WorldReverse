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
public class MpPlayMatchExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15863
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected MpPlayType _playType; // 0x14
	protected uint _playNameTextMapHash; // 0x18
	protected uint _playDescTextMapHash; // 0x1C
	protected bool _isAutoMatch; // 0x20
	protected SimpleSafeUInt32 minPlayersRawNum; // 0x24
	protected SimpleSafeUInt32 maxPlayersRawNum; // 0x28
	protected bool _isAllowInAnyTime; // 0x2C
	protected bool _isMatchNecessary; // 0x2D
	protected SimpleSafeUInt32[] _buffList; // 0x30
	protected SimpleSafeUInt32 pushTipsIdRawNum; // 0x38
	protected string _bgImage; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A6E4E0-0x0000000189A6E500 */ get => default; /* [XID] */ /* 0x0000000189A75BD0-0x0000000189A75BF0 */ protected set {} } // 0x0000000183054040-0x0000000183054110 0x0000000183053020-0x0000000183053100
	public MpPlayType playType { /* [XID] */ /* 0x0000000189A7D7D0-0x0000000189A7D7F0 */ get => default; /* [XID] */ /* 0x0000000189A84F60-0x0000000189A84F80 */ protected set {} } // 0x0000000183054110-0x00000001830541B0 0x0000000183051400-0x00000001830514B0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint playNameTextMapHash { /* [XID] */ /* 0x0000000189A8C890-0x0000000189A8C8B0 */ get => default; /* [XID] */ /* 0x0000000189A93C30-0x0000000189A93C50 */ protected set {} } // 0x0000000183051630-0x00000001830516D0 0x0000000183051010-0x00000001830510C0
	public string playName { /* [XID] */ /* 0x0000000189A9B700-0x0000000189A9B720 */ get => default; } // 0x0000000183052EA0-0x0000000183053020 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint playDescTextMapHash { /* [XID] */ /* 0x0000000189AA2A80-0x0000000189AA2AA0 */ get => default; /* [XID] */ /* 0x0000000189AAA140-0x0000000189AAA160 */ protected set {} } // 0x0000000183053AD0-0x0000000183053B70 0x00000001830541B0-0x0000000183054260
	public string playDesc { /* [XID] */ /* 0x0000000189AB1EE0-0x0000000189AB1F00 */ get => default; } // 0x00000001830510C0-0x0000000183051240 
	public bool isAutoMatch { /* [XID] */ /* 0x0000000189AB9190-0x0000000189AB91B0 */ get => default; /* [XID] */ /* 0x0000000189AC0D70-0x0000000189AC0D90 */ protected set {} } // 0x0000000183053C40-0x0000000183053CE0 0x00000001830514B0-0x0000000183051560
	public uint minPlayers { /* [XID] */ /* 0x0000000189AC8770-0x0000000189AC8790 */ get => default; /* [XID] */ /* 0x0000000189ACFEF0-0x0000000189ACFF10 */ protected set {} } // 0x0000000183053B70-0x0000000183053C40 0x0000000183052D10-0x0000000183052DF0
	public uint maxPlayers { /* [XID] */ /* 0x0000000189AD7D00-0x0000000189AD7D20 */ get => default; /* [XID] */ /* 0x0000000189ADF870-0x0000000189ADF890 */ protected set {} } // 0x0000000183052B60-0x0000000183052C30 0x0000000183053D80-0x0000000183053E60
	public bool isAllowInAnyTime { /* [XID] */ /* 0x0000000189AE7010-0x0000000189AE7030 */ get => default; /* [XID] */ /* 0x0000000189AEEB20-0x0000000189AEEB40 */ protected set {} } // 0x0000000183053E60-0x0000000183053F00 0x0000000183051780-0x0000000183051830
	public bool isMatchNecessary { /* [XID] */ /* 0x0000000189AF60F0-0x0000000189AF6110 */ get => default; /* [XID] */ /* 0x0000000189AFD6B0-0x0000000189AFD6D0 */ protected set {} } // 0x0000000183051830-0x00000001830518D0 0x00000001830516D0-0x0000000183051780
	public SimpleSafeUInt32[] buffList { /* [XID] */ /* 0x0000000189B04DC0-0x0000000189B04DE0 */ get => default; /* [XID] */ /* 0x0000000189B0C5F0-0x0000000189B0C610 */ protected set {} } // 0x0000000183050F70-0x0000000183051010 0x0000000183052DF0-0x0000000183052EA0
	public uint pushTipsId { /* [XID] */ /* 0x0000000189B13AF0-0x0000000189B13B10 */ get => default; /* [XID] */ /* 0x0000000189B1B1C0-0x0000000189B1B1E0 */ protected set {} } // 0x0000000183051560-0x0000000183051630 0x0000000183052C30-0x0000000183052D10
	public string bgImage { /* [XID] */ /* 0x0000000189B22950-0x0000000189B22970 */ get => default; /* [XID] */ /* 0x0000000189B29EA0-0x0000000189B29EC0 */ protected set {} } // 0x0000000183053CE0-0x0000000183053D80 0x0000000183052AB0-0x0000000183052B60

	// Constructors
	public MpPlayMatchExcelConfig() {} // 0x0000000183054300-0x0000000183054360

	// Methods
	// [IDTag] // 0x0000000189B31570-0x0000000189B315B0
	// [XID] // 0x0000000189B31570-0x0000000189B315B0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001830521D0-0x0000000183052AB0
	// [IDTag] // 0x0000000189B3BAF0-0x0000000189B3BB30
	// [XID] // 0x0000000189B3BAF0-0x0000000189B3BB30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001830518D0-0x00000001830521D0
	// [XID] // 0x0000000189B465E0-0x0000000189B46600
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28BF */, bool useObjectPool = false /* Metadata: 0x00AF28C3 */) => default; // 0x0000000183053100-0x0000000183053AD0
	[BlackList] // 0x0000000189B4DB80-0x0000000189B4DBC0
	// [XID] // 0x0000000189B4DB80-0x0000000189B4DBC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183051240-0x00000001830512E0
	[BlackList] // 0x0000000189B585F0-0x0000000189B58630
	// [XID] // 0x0000000189B585F0-0x0000000189B58630
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830512E0-0x0000000183051400
	[BlackList] // 0x0000000189B62940-0x0000000189B62980
	// [XID] // 0x0000000189B62940-0x0000000189B62980
	public virtual void ReturnToObjectPool() {} // 0x0000000183054260-0x0000000183054300
	[BlackList] // 0x0000000189B6D220-0x0000000189B6D260
	// [XID] // 0x0000000189B6D220-0x0000000189B6D260
	public virtual void OnPoolAllocated() {} // 0x0000000183053FA0-0x0000000183054040
	[BlackList] // 0x0000000189B777D0-0x0000000189B77810
	// [XID] // 0x0000000189B777D0-0x0000000189B77810
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183053F00-0x0000000183053FA0
}


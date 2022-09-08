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
public class ChatExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15299
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 channelRawNum; // 0x14
	protected SimpleSafeFloat priorityRawNum; // 0x18
	protected uint _tabShownNameTextMapHash; // 0x1C
	protected string _chatChannelIcon; // 0x20
	protected uint _TagOtherTextMapHash; // 0x28
	protected uint _TagSelfTextMapHash; // 0x2C
	protected uint _EnterTextMapHash; // 0x30
	protected uint _LeaveTextMapHash; // 0x34

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898459F0-0x0000000189845A10 */ get => default; /* [XID] */ /* 0x000000018984CFE0-0x000000018984D000 */ protected set {} } // 0x0000000182BA08C0-0x0000000182BA0990 0x0000000182B9F6F0-0x0000000182B9F7D0
	public uint channel { /* [XID] */ /* 0x00000001898540C0-0x00000001898540E0 */ get => default; /* [XID] */ /* 0x000000018985BAB0-0x000000018985BAD0 */ protected set {} } // 0x0000000182B9F070-0x0000000182B9F140 0x0000000182B9DF00-0x0000000182B9DFE0
	public float priority { /* [XID] */ /* 0x0000000189863050-0x0000000189863070 */ get => default; /* [XID] */ /* 0x000000018986A4C0-0x000000018986A4E0 */ protected set {} } // 0x0000000182BA01A0-0x0000000182BA0280 0x0000000182B9F140-0x0000000182B9F220
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint tabShownNameTextMapHash { /* [XID] */ /* 0x0000000189871990-0x00000001898719B0 */ get => default; /* [XID] */ /* 0x0000000189879210-0x0000000189879230 */ protected set {} } // 0x0000000182B9E330-0x0000000182B9E3D0 0x0000000182BA04A0-0x0000000182BA0550
	public string tabShownName { /* [XID] */ /* 0x00000001898807A0-0x00000001898807C0 */ get => default; } // 0x0000000182BA0550-0x0000000182BA06D0 
	public string chatChannelIcon { /* [XID] */ /* 0x0000000189887D00-0x0000000189887D20 */ get => default; /* [XID] */ /* 0x000000018988F0C0-0x000000018988F0E0 */ protected set {} } // 0x0000000182B9F880-0x0000000182B9F920 0x0000000182B9F640-0x0000000182B9F6F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint TagOtherTextMapHash { /* [XID] */ /* 0x00000001898965E0-0x0000000189896600 */ get => default; /* [XID] */ /* 0x000000018989DBC0-0x000000018989DBE0 */ protected set {} } // 0x0000000182B9F2D0-0x0000000182B9F370 0x0000000182BA06D0-0x0000000182BA0780
	public string TagOther { /* [XID] */ /* 0x00000001898A55A0-0x00000001898A55C0 */ get => default; } // 0x0000000182B9EEF0-0x0000000182B9F070 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint TagSelfTextMapHash { /* [XID] */ /* 0x00000001898ACAE0-0x00000001898ACB00 */ get => default; /* [XID] */ /* 0x00000001898B3F60-0x00000001898B3F80 */ protected set {} } // 0x0000000182B9F370-0x0000000182B9F410 0x0000000182B9F220-0x0000000182B9F2D0
	public string TagSelf { /* [XID] */ /* 0x00000001898BBC30-0x00000001898BBC50 */ get => default; } // 0x0000000182B9F410-0x0000000182B9F590 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint EnterTextMapHash { /* [XID] */ /* 0x00000001898C3140-0x00000001898C3160 */ get => default; /* [XID] */ /* 0x00000001898CAB20-0x00000001898CAB40 */ protected set {} } // 0x0000000182B9F920-0x0000000182B9F9C0 0x0000000182B9F7D0-0x0000000182B9F880
	public string Enter { /* [XID] */ /* 0x00000001898D21F0-0x00000001898D2210 */ get => default; } // 0x0000000182B9E1B0-0x0000000182B9E330 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint LeaveTextMapHash { /* [XID] */ /* 0x00000001898D9A30-0x00000001898D9A50 */ get => default; /* [XID] */ /* 0x00000001898E1710-0x00000001898E1730 */ protected set {} } // 0x0000000182BA0400-0x0000000182BA04A0 0x0000000182B9F590-0x0000000182B9F640
	public string Leave { /* [XID] */ /* 0x00000001898E91E0-0x00000001898E9200 */ get => default; } // 0x0000000182BA0280-0x0000000182BA0400 

	// Constructors
	public ChatExcelConfig() {} // 0x0000000182BA0A30-0x0000000182BA0A90

	// Methods
	// [IDTag] // 0x00000001898F09C0-0x00000001898F0A00
	// [XID] // 0x00000001898F09C0-0x00000001898F0A00
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182B9E3D0-0x0000000182B9E960
	// [IDTag] // 0x00000001898FAF60-0x00000001898FAFA0
	// [XID] // 0x00000001898FAF60-0x00000001898FAFA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182B9E960-0x0000000182B9EEF0
	// [XID] // 0x0000000189905A40-0x0000000189905A60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF06BC */, bool useObjectPool = false /* Metadata: 0x00AF06C0 */) => default; // 0x0000000182B9F9C0-0x0000000182BA01A0
	[BlackList] // 0x000000018990D2D0-0x000000018990D310
	// [XID] // 0x000000018990D2D0-0x000000018990D310
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B9DFE0-0x0000000182B9E080
	[BlackList] // 0x0000000189917CA0-0x0000000189917CE0
	// [XID] // 0x0000000189917CA0-0x0000000189917CE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B9E080-0x0000000182B9E1B0
	[BlackList] // 0x0000000189922460-0x00000001899224A0
	// [XID] // 0x0000000189922460-0x00000001899224A0
	public virtual void ReturnToObjectPool() {} // 0x0000000182BA0990-0x0000000182BA0A30
	[BlackList] // 0x000000018992C9C0-0x000000018992CA00
	// [XID] // 0x000000018992C9C0-0x000000018992CA00
	public virtual void OnPoolAllocated() {} // 0x0000000182BA0820-0x0000000182BA08C0
	[BlackList] // 0x0000000189936E90-0x0000000189936ED0
	// [XID] // 0x0000000189936E90-0x0000000189936ED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182BA0780-0x0000000182BA0820
}


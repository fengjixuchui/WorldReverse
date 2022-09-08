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
public class ChannellerSlabLoopDungeonPreviewExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15047
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected uint _titleTextMapHash; // 0x18
	protected uint _entryDescTextMapHash; // 0x1C
	protected uint _descTextMapHash; // 0x20
	protected SimpleSafeUInt32 openDayRawNum; // 0x24
	protected SimpleSafeUInt32 pointIDRawNum; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899E8640-0x00000001899E8660 */ get => default; /* [XID] */ /* 0x00000001899EFCB0-0x00000001899EFCD0 */ protected set {} } // 0x0000000183356840-0x0000000183356910 0x0000000183355B20-0x0000000183355C00
	public uint activityId { /* [XID] */ /* 0x00000001899F7330-0x00000001899F7350 */ get => default; /* [XID] */ /* 0x00000001899FEAB0-0x00000001899FEAD0 */ protected set {} } // 0x0000000183356560-0x0000000183356630 0x0000000183355A40-0x0000000183355B20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189A062D0-0x0000000189A062F0 */ get => default; /* [XID] */ /* 0x0000000189A0D7C0-0x0000000189A0D7E0 */ protected set {} } // 0x00000001833549B0-0x0000000183354A50 0x0000000183354BA0-0x0000000183354C50
	public string title { /* [XID] */ /* 0x0000000189A14F00-0x0000000189A14F20 */ get => default; } // 0x00000001833563E0-0x0000000183356560 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint entryDescTextMapHash { /* [XID] */ /* 0x0000000189A1C050-0x0000000189A1C070 */ get => default; /* [XID] */ /* 0x0000000189A23920-0x0000000189A23940 */ protected set {} } // 0x0000000183354B00-0x0000000183354BA0 0x0000000183356290-0x0000000183356340
	public string entryDesc { /* [XID] */ /* 0x0000000189A2AD60-0x0000000189A2AD80 */ get => default; } // 0x00000001833558C0-0x0000000183355A40 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A322A0-0x0000000189A322C0 */ get => default; /* [XID] */ /* 0x0000000189A39D30-0x0000000189A39D50 */ protected set {} } // 0x0000000183356340-0x00000001833563E0 0x0000000183354A50-0x0000000183354B00
	public string desc { /* [XID] */ /* 0x0000000189A41570-0x0000000189A41590 */ get => default; } // 0x0000000183355740-0x00000001833558C0 
	public uint openDay { /* [XID] */ /* 0x0000000189A48C30-0x0000000189A48C50 */ get => default; /* [XID] */ /* 0x0000000189A50340-0x0000000189A50360 */ protected set {} } // 0x0000000183356630-0x0000000183356700 0x0000000183354720-0x0000000183354800
	public uint pointID { /* [XID] */ /* 0x0000000189A57910-0x0000000189A57930 */ get => default; /* [XID] */ /* 0x0000000189A5F550-0x0000000189A5F570 */ protected set {} } // 0x0000000183355590-0x0000000183355660 0x0000000183355660-0x0000000183355740

	// Constructors
	public ChannellerSlabLoopDungeonPreviewExcelConfig() {} // 0x00000001833569B0-0x0000000183356A10

	// Methods
	// [IDTag] // 0x0000000189A66E60-0x0000000189A66EA0
	// [XID] // 0x0000000189A66E60-0x0000000189A66EA0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001833550E0-0x0000000183355590
	// [IDTag] // 0x0000000189A713A0-0x0000000189A713E0
	// [XID] // 0x0000000189A713A0-0x0000000189A713E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183354C50-0x00000001833550E0
	// [XID] // 0x0000000189A7BEC0-0x0000000189A7BEE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF5A */, bool useObjectPool = false /* Metadata: 0x00AEFF5E */) => default; // 0x0000000183355C00-0x0000000183356290
	[BlackList] // 0x0000000189A83920-0x0000000189A83960
	// [XID] // 0x0000000189A83920-0x0000000189A83960
	public virtual void AutoAllocTypeFields() {} // 0x0000000183354800-0x00000001833548A0
	[BlackList] // 0x0000000189A8E1B0-0x0000000189A8E1F0
	// [XID] // 0x0000000189A8E1B0-0x0000000189A8E1F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833548A0-0x00000001833549B0
	[BlackList] // 0x0000000189A98A80-0x0000000189A98AC0
	// [XID] // 0x0000000189A98A80-0x0000000189A98AC0
	public virtual void ReturnToObjectPool() {} // 0x0000000183356910-0x00000001833569B0
	[BlackList] // 0x0000000189AA2C20-0x0000000189AA2C60
	// [XID] // 0x0000000189AA2C20-0x0000000189AA2C60
	public virtual void OnPoolAllocated() {} // 0x00000001833567A0-0x0000000183356840
	[BlackList] // 0x0000000189AAD420-0x0000000189AAD460
	// [XID] // 0x0000000189AAD420-0x0000000189AAD460
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183356700-0x00000001833567A0
}


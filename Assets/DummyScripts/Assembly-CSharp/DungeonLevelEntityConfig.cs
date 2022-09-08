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
public class DungeonLevelEntityConfig : IAutoAllocRecycle // TypeDefIndex: 15555
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 clientIdRawNum; // 0x10
	protected SimpleSafeUInt32 idRawNum; // 0x14
	protected bool _show; // 0x18
	protected string _levelConfigName; // 0x20
	protected uint _descTextMapHash; // 0x28

	// Properties
	public uint clientId { /* [XID] */ /* 0x00000001896F2E30-0x00000001896F2E50 */ get => default; /* [XID] */ /* 0x00000001896FA710-0x00000001896FA730 */ protected set {} } // 0x0000000183E17BD0-0x0000000183E17CA0 0x0000000183E186E0-0x0000000183E187C0
	public uint id { /* [XID] */ /* 0x0000000189701DA0-0x0000000189701DC0 */ get => default; /* [XID] */ /* 0x0000000189709640-0x0000000189709660 */ protected set {} } // 0x0000000183E18900-0x0000000183E189D0 0x0000000183E17F60-0x0000000183E18040
	public bool show { /* [XID] */ /* 0x0000000189710EF0-0x0000000189710F10 */ get => default; /* [XID] */ /* 0x0000000189718290-0x00000001897182B0 */ protected set {} } // 0x0000000183E17CA0-0x0000000183E17D40 0x0000000183E18630-0x0000000183E186E0
	public string levelConfigName { /* [XID] */ /* 0x000000018971FC30-0x000000018971FC50 */ get => default; /* [XID] */ /* 0x0000000189727300-0x0000000189727320 */ protected set {} } // 0x0000000183E17D40-0x0000000183E17DE0 0x0000000183E17310-0x0000000183E173C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018972E890-0x000000018972E8B0 */ get => default; /* [XID] */ /* 0x0000000189735FE0-0x0000000189736000 */ protected set {} } // 0x0000000183E18590-0x0000000183E18630 0x0000000183E173C0-0x0000000183E17470
	public string desc { /* [XID] */ /* 0x000000018973DCB0-0x000000018973DCD0 */ get => default; } // 0x0000000183E17DE0-0x0000000183E17F60 

	// Constructors
	public DungeonLevelEntityConfig() {} // 0x0000000183E18A70-0x0000000183E18AD0

	// Methods
	// [IDTag] // 0x0000000189745050-0x0000000189745090
	// [XID] // 0x0000000189745050-0x0000000189745090
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183E17810-0x0000000183E17BD0
	// [IDTag] // 0x000000018974FA10-0x000000018974FA50
	// [XID] // 0x000000018974FA10-0x000000018974FA50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183E17470-0x0000000183E17810
	// [XID] // 0x0000000189759BA0-0x0000000189759BC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1EF8 */, bool useObjectPool = false /* Metadata: 0x00AF1EFC */) => default; // 0x0000000183E18040-0x0000000183E18590
	[BlackList] // 0x00000001897617D0-0x0000000189761810
	// [XID] // 0x00000001897617D0-0x0000000189761810
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E17180-0x0000000183E17220
	[BlackList] // 0x000000018976BDC0-0x000000018976BE00
	// [XID] // 0x000000018976BDC0-0x000000018976BE00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E17220-0x0000000183E17310
	[BlackList] // 0x0000000189776520-0x0000000189776560
	// [XID] // 0x0000000189776520-0x0000000189776560
	public virtual void ReturnToObjectPool() {} // 0x0000000183E189D0-0x0000000183E18A70
	[BlackList] // 0x0000000189780C40-0x0000000189780C80
	// [XID] // 0x0000000189780C40-0x0000000189780C80
	public virtual void OnPoolAllocated() {} // 0x0000000183E18860-0x0000000183E18900
	[BlackList] // 0x000000018978B420-0x000000018978B460
	// [XID] // 0x000000018978B420-0x000000018978B460
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E187C0-0x0000000183E18860
}


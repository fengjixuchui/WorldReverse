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
public class MusicInfoConfig : IAutoAllocRecycle // TypeDefIndex: 15147
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 musicIDRawNum; // 0x10
	protected SimpleSafeUInt32 musicTimeRawNum; // 0x14
	protected SimpleSafeUInt32[] _levelId; // 0x18
	protected uint _musicNameTextMapHash; // 0x20
	protected uint _musicDescTextMapHash; // 0x24

	// Properties
	public uint musicID { /* [XID] */ /* 0x00000001897A0650-0x00000001897A0670 */ get => default; /* [XID] */ /* 0x00000001897A7CA0-0x00000001897A7CC0 */ protected set {} } // 0x0000000183165960-0x0000000183165A30 0x0000000183164E50-0x0000000183164F30
	public uint musicTime { /* [XID] */ /* 0x00000001897AF710-0x00000001897AF730 */ get => default; /* [XID] */ /* 0x00000001897B75F0-0x00000001897B7610 */ protected set {} } // 0x0000000183165A30-0x0000000183165B00 0x00000001831664B0-0x0000000183166590
	public SimpleSafeUInt32[] levelId { /* [XID] */ /* 0x00000001897BF470-0x00000001897BF490 */ get => default; /* [XID] */ /* 0x00000001897C6B80-0x00000001897C6BA0 */ protected set {} } // 0x0000000183164B70-0x0000000183164C10 0x0000000183165B00-0x0000000183165BB0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint musicNameTextMapHash { /* [XID] */ /* 0x00000001897CE320-0x00000001897CE340 */ get => default; /* [XID] */ /* 0x00000001897D58B0-0x00000001897D58D0 */ protected set {} } // 0x0000000183166590-0x0000000183166630 0x0000000183164C10-0x0000000183164CC0
	public string musicName { /* [XID] */ /* 0x00000001897DCF90-0x00000001897DCFB0 */ get => default; } // 0x0000000183165BB0-0x0000000183165D30 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint musicDescTextMapHash { /* [XID] */ /* 0x00000001897E4870-0x00000001897E4890 */ get => default; /* [XID] */ /* 0x00000001897EC500-0x00000001897EC520 */ protected set {} } // 0x00000001831658C0-0x0000000183165960 0x0000000183166400-0x00000001831664B0
	public string musicDesc { /* [XID] */ /* 0x00000001897F3E30-0x00000001897F3E50 */ get => default; } // 0x0000000183166280-0x0000000183166400 

	// Constructors
	public MusicInfoConfig() {} // 0x0000000183166810-0x0000000183166870

	// Methods
	// [IDTag] // 0x00000001897FB770-0x00000001897FB7B0
	// [XID] // 0x00000001897FB770-0x00000001897FB7B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183164F30-0x0000000183165420
	// [IDTag] // 0x0000000189805810-0x0000000189805850
	// [XID] // 0x0000000189805810-0x0000000189805850
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183165420-0x00000001831658C0
	// [XID] // 0x0000000189810310-0x0000000189810330
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF022B */, bool useObjectPool = false /* Metadata: 0x00AF022F */) => default; // 0x0000000183165D30-0x0000000183166280
	[BlackList] // 0x0000000189817980-0x00000001898179C0
	// [XID] // 0x0000000189817980-0x00000001898179C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183164CC0-0x0000000183164D60
	[BlackList] // 0x00000001898222D0-0x0000000189822310
	// [XID] // 0x00000001898222D0-0x0000000189822310
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183164D60-0x0000000183164E50
	[BlackList] // 0x000000018982C930-0x000000018982C970
	// [XID] // 0x000000018982C930-0x000000018982C970
	public virtual void ReturnToObjectPool() {} // 0x0000000183166770-0x0000000183166810
	[BlackList] // 0x0000000189836E30-0x0000000189836E70
	// [XID] // 0x0000000189836E30-0x0000000189836E70
	public virtual void OnPoolAllocated() {} // 0x00000001831666D0-0x0000000183166770
	[BlackList] // 0x0000000189841060-0x00000001898410A0
	// [XID] // 0x0000000189841060-0x00000001898410A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183166630-0x00000001831666D0
}


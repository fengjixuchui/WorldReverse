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
public class MpPlayWatcherConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 15867
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 MpPlayIdRawNum; // 0x28
	protected SimpleSafeUInt32 priorityRawNum; // 0x2C
	protected bool _isStore; // 0x30
	protected uint _challengeDescTextMapHash; // 0x34
	protected uint _challengeTitleTextMapHash; // 0x38

	// Properties
	public uint MpPlayId { /* [XID] */ /* 0x00000001898964A0-0x00000001898964C0 */ get => default; /* [XID] */ /* 0x000000018989DAA0-0x000000018989DAC0 */ protected set {} } // 0x0000000184BC5570-0x0000000184BC5640 0x0000000184BC48A0-0x0000000184BC4980
	public uint priority { /* [XID] */ /* 0x00000001898A5380-0x00000001898A53A0 */ get => default; /* [XID] */ /* 0x00000001898AC980-0x00000001898AC9A0 */ protected set {} } // 0x0000000184BC61E0-0x0000000184BC62B0 0x0000000184BC5490-0x0000000184BC5570
	public bool isStore { /* [XID] */ /* 0x00000001898B3E40-0x00000001898B3E60 */ get => default; /* [XID] */ /* 0x00000001898BBAD0-0x00000001898BBAF0 */ protected set {} } // 0x0000000184BC5870-0x0000000184BC5910 0x0000000184BC57C0-0x0000000184BC5870
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint challengeDescTextMapHash { /* [XID] */ /* 0x00000001898C3020-0x00000001898C3040 */ get => default; /* [XID] */ /* 0x00000001898CAA00-0x00000001898CAA20 */ protected set {} } // 0x0000000184BC6540-0x0000000184BC65E0 0x0000000184BC44C0-0x0000000184BC4570
	public string challengeDesc { /* [XID] */ /* 0x00000001898D2070-0x00000001898D2090 */ get => default; } // 0x0000000184BC63C0-0x0000000184BC6540 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint challengeTitleTextMapHash { /* [XID] */ /* 0x00000001898D9950-0x00000001898D9970 */ get => default; /* [XID] */ /* 0x00000001898E1690-0x00000001898E16B0 */ protected set {} } // 0x0000000184BC4800-0x0000000184BC48A0 0x0000000184BC62B0-0x0000000184BC6360
	public string challengeTitle { /* [XID] */ /* 0x00000001898E9160-0x00000001898E9180 */ get => default; } // 0x0000000184BC5640-0x0000000184BC57C0 

	// Constructors
	public MpPlayWatcherConfig() {} // 0x0000000184BC6680-0x0000000184BC66E0

	// Methods
	// [IDTag] // 0x00000001898F0920-0x00000001898F0960
	// [XID] // 0x00000001898F0920-0x00000001898F0960
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184BC4980-0x0000000184BC4F50
	// [IDTag] // 0x00000001898FAEA0-0x00000001898FAEE0
	// [XID] // 0x00000001898FAEA0-0x00000001898FAEE0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184BC4F50-0x0000000184BC5490
	// [XID] // 0x00000001899058E0-0x0000000189905900
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28DD */, bool useObjectPool = false /* Metadata: 0x00AF28E1 */) => default; // 0x0000000184BC5A00-0x0000000184BC61E0
	[BlackList] // 0x000000018990D210-0x000000018990D250
	// [XID] // 0x000000018990D210-0x000000018990D250
	public override void AutoAllocTypeFields() {} // 0x0000000184BC4570-0x0000000184BC4610
	[BlackList] // 0x0000000189917BE0-0x0000000189917C20
	// [XID] // 0x0000000189917BE0-0x0000000189917C20
	public override void AutoRecycleTypeFields() {} // 0x0000000184BC4610-0x0000000184BC4700
	[BlackList] // 0x0000000189922400-0x0000000189922440
	// [XID] // 0x0000000189922400-0x0000000189922440
	public override void ReturnToObjectPool() {} // 0x0000000184BC65E0-0x0000000184BC6680
}


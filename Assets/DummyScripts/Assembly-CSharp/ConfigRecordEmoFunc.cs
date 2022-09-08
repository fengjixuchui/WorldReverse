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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigRecordEmoFunc : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18878
{
	// Fields
	private EmoRecordTypeEnum _type; // 0x10
	private bool _recordBool; // 0x14
	private SimpleSafeFloat recordFloatRawNum; // 0x18
	private string[] _stringArrays; // 0x20
	private ulong[] _ulongs; // 0x28

	// Properties
	public EmoRecordTypeEnum type { /* [XID] */ /* 0x0000000189B62370-0x0000000189B62390 */ get => default; /* [XID] */ /* 0x0000000189B6A010-0x0000000189B6A030 */ private set {} } // 0x000000018319D0E0-0x000000018319D180 0x000000018319C810-0x000000018319C8C0
	public bool recordBool { /* [XID] */ /* 0x0000000189B71650-0x0000000189B71670 */ get => default; /* [XID] */ /* 0x0000000189B78BE0-0x0000000189B78C00 */ private set {} } // 0x000000018319C080-0x000000018319C120 0x000000018319C760-0x000000018319C810
	public float recordFloat { /* [XID] */ /* 0x0000000189B80030-0x0000000189B80050 */ get => default; /* [XID] */ /* 0x0000000189B87B20-0x0000000189B87B40 */ private set {} } // 0x000000018319BC20-0x000000018319BD00 0x000000018319C680-0x000000018319C760
	public string[] stringArrays { /* [XID] */ /* 0x0000000189B8ED10-0x0000000189B8ED30 */ get => default; /* [XID] */ /* 0x0000000189B96120-0x0000000189B96140 */ private set {} } // 0x000000018319CDA0-0x000000018319CE40 0x000000018319C120-0x000000018319C1D0
	public ulong[] ulongs { /* [XID] */ /* 0x0000000189B9D700-0x0000000189B9D720 */ get => default; /* [XID] */ /* 0x0000000189BA5190-0x0000000189BA51B0 */ private set {} } // 0x000000018319C5E0-0x000000018319C680 0x000000018319CCF0-0x000000018319CDA0

	// Constructors
	public ConfigRecordEmoFunc() {} // 0x000000018319D220-0x000000018319D280

	// Methods
	// [XID] // 0x0000000189BAC270-0x0000000189BAC290
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018319CE40-0x000000018319CFA0
	// [XID] // 0x0000000189BB3B10-0x0000000189BB3B30
	public void InitEmpty() {} // 0x000000018319C1D0-0x000000018319C2E0
	[BlackList] // 0x0000000189BBB0D0-0x0000000189BBB110
	// [XID] // 0x0000000189BBB0D0-0x0000000189BBB110
	public bool FromJson(JSONNode node) => default; // 0x000000018319BD00-0x000000018319C080
	// [XID] // 0x0000000189BC5C60-0x0000000189BC5C80
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018319AE00-0x000000018319B380
	// [XID] // 0x0000000189BCD6E0-0x0000000189BCD700
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB22D */, bool useObjectPool = false /* Metadata: 0x00AFB231 */) => default; // 0x000000018319C2E0-0x000000018319C5E0
	// [XID] // 0x0000000189BD4C90-0x0000000189BD4CB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB232 */, bool useObjectPool = false /* Metadata: 0x00AFB236 */) => default; // 0x000000018319B7D0-0x000000018319BC20
	[BlackList] // 0x0000000189BDC680-0x0000000189BDC6C0
	// [XID] // 0x0000000189BDC680-0x0000000189BDC6C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018319B380-0x000000018319B650
	// [XID] // 0x00000001895EC1D0-0x00000001895EC1F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018319C8C0-0x000000018319CCF0
	[BlackList] // 0x00000001895F3690-0x00000001895F36D0
	// [XID] // 0x00000001895F3690-0x00000001895F36D0
	public virtual void AutoAllocTypeFields() {} // 0x000000018319B650-0x000000018319B6F0
	[BlackList] // 0x00000001895FDD80-0x00000001895FDDC0
	// [XID] // 0x00000001895FDD80-0x00000001895FDDC0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018319B6F0-0x000000018319B7D0
	[BlackList] // 0x00000001896089B0-0x00000001896089F0
	// [XID] // 0x00000001896089B0-0x00000001896089F0
	public virtual void ReturnToObjectPool() {} // 0x000000018319D180-0x000000018319D220
	[BlackList] // 0x0000000189612F80-0x0000000189612FC0
	// [XID] // 0x0000000189612F80-0x0000000189612FC0
	public virtual void OnPoolAllocated() {} // 0x000000018319D040-0x000000018319D0E0
	[BlackList] // 0x000000018961D770-0x000000018961D7B0
	// [XID] // 0x000000018961D770-0x000000018961D7B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018319CFA0-0x000000018319D040
}


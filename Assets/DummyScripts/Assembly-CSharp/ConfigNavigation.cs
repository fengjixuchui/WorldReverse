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
public class ConfigNavigation : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18782
{
	// Fields
	private NavType _type; // 0x10
	private SimpleSafeFloat sizeXRawNum; // 0x14
	private SimpleSafeFloat sizeYRawNum; // 0x18
	private SimpleSafeFloat sizeZRawNum; // 0x1C

	// Properties
	public NavType type { /* [XID] */ /* 0x0000000189BA3950-0x0000000189BA3970 */ get => default; /* [XID] */ /* 0x0000000189BAADA0-0x0000000189BAADC0 */ private set {} } // 0x0000000185B41080-0x0000000185B41120 0x0000000185B40910-0x0000000185B409C0
	public float sizeX { /* [XID] */ /* 0x0000000189BB2370-0x0000000189BB2390 */ get => default; /* [XID] */ /* 0x0000000189BB97E0-0x0000000189BB9800 */ private set {} } // 0x0000000185B40830-0x0000000185B40910 0x0000000185B400C0-0x0000000185B401A0
	public float sizeY { /* [XID] */ /* 0x0000000189BC16E0-0x0000000189BC1700 */ get => default; /* [XID] */ /* 0x0000000189BC8D40-0x0000000189BC8D60 */ private set {} } // 0x0000000185B40590-0x0000000185B40670 0x0000000185B40FA0-0x0000000185B41080
	public float sizeZ { /* [XID] */ /* 0x0000000189BD0570-0x0000000189BD0590 */ get => default; /* [XID] */ /* 0x0000000189BD7AD0-0x0000000189BD7AF0 */ private set {} } // 0x0000000185B40750-0x0000000185B40830 0x0000000185B40670-0x0000000185B40750

	// Constructors
	public ConfigNavigation() {} // 0x0000000185B411C0-0x0000000185B41230

	// Methods
	// [XID] // 0x0000000189BDF780-0x0000000189BDF7A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185B40D20-0x0000000185B40E60
	// [XID] // 0x00000001895EC1F0-0x00000001895EC210
	public void InitEmpty() {} // 0x0000000185B401A0-0x0000000185B40290
	[BlackList] // 0x00000001895F36D0-0x00000001895F3710
	// [XID] // 0x00000001895F36D0-0x00000001895F3710
	public bool FromJson(JSONNode node) => default; // 0x0000000185B3FD40-0x0000000185B400C0
	// [XID] // 0x00000001895FDDC0-0x00000001895FDDE0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185B3EFB0-0x0000000185B3F500
	// [XID] // 0x00000001896055F0-0x0000000189605610
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC0F */, bool useObjectPool = false /* Metadata: 0x00AFAC13 */) => default; // 0x0000000185B40290-0x0000000185B40590
	// [XID] // 0x000000018960CFE0-0x000000018960D000
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC14 */, bool useObjectPool = false /* Metadata: 0x00AFAC18 */) => default; // 0x0000000185B3F970-0x0000000185B3FD40
	[BlackList] // 0x0000000189614640-0x0000000189614680
	// [XID] // 0x0000000189614640-0x0000000189614680
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185B3F500-0x0000000185B3F7D0
	// [XID] // 0x000000018961F020-0x000000018961F040
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185B409C0-0x0000000185B40D20
	[BlackList] // 0x0000000189626440-0x0000000189626480
	// [XID] // 0x0000000189626440-0x0000000189626480
	public virtual void AutoAllocTypeFields() {} // 0x0000000185B3F7D0-0x0000000185B3F870
	[BlackList] // 0x0000000189630F40-0x0000000189630F80
	// [XID] // 0x0000000189630F40-0x0000000189630F80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185B3F870-0x0000000185B3F970
	[BlackList] // 0x000000018963B700-0x000000018963B740
	// [XID] // 0x000000018963B700-0x000000018963B740
	public virtual void ReturnToObjectPool() {} // 0x0000000185B41120-0x0000000185B411C0
	[BlackList] // 0x0000000189645D80-0x0000000189645DC0
	// [XID] // 0x0000000189645D80-0x0000000189645DC0
	public virtual void OnPoolAllocated() {} // 0x0000000185B40F00-0x0000000185B40FA0
	[BlackList] // 0x0000000189650410-0x0000000189650450
	// [XID] // 0x0000000189650410-0x0000000189650450
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185B40E60-0x0000000185B40F00
}


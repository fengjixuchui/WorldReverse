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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class WatcherConfig : IAutoAllocRecycle // TypeDefIndex: 15408
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected WatcherTriggerConfig _triggerConfig; // 0x18
	protected SimpleSafeUInt32 progressRawNum; // 0x20
	protected bool _isDisuse; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x000000018963BE60-0x000000018963BE80 */ get => default; /* [XID] */ /* 0x0000000189643520-0x0000000189643540 */ protected set {} } // 0x0000000181C7DFC0-0x0000000181C7E090 0x0000000181C7D540-0x0000000181C7D620
	public WatcherTriggerConfig triggerConfig { /* [XID] */ /* 0x000000018964AB20-0x000000018964AB40 */ get => default; /* [XID] */ /* 0x0000000189652300-0x0000000189652320 */ protected set {} } // 0x0000000181C7E090-0x0000000181C7E130 0x0000000181C7DBB0-0x0000000181C7DC60
	public uint progress { /* [XID] */ /* 0x00000001896599F0-0x0000000189659A10 */ get => default; /* [XID] */ /* 0x0000000189661130-0x0000000189661150 */ protected set {} } // 0x0000000181C7DD00-0x0000000181C7DDD0 0x0000000181C7DAD0-0x0000000181C7DBB0
	public bool isDisuse { /* [XID] */ /* 0x0000000189668BE0-0x0000000189668C00 */ get => default; /* [XID] */ /* 0x0000000189670750-0x0000000189670770 */ protected set {} } // 0x0000000181C7DC60-0x0000000181C7DD00 0x0000000181C7DDD0-0x0000000181C7DE80

	// Constructors
	public WatcherConfig() {} // 0x0000000181C7E1D0-0x0000000181C7E230

	// Methods
	// [XID] // 0x0000000189677F50-0x0000000189677F70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C7D270-0x0000000181C7D540
	// [XID] // 0x000000018967F660-0x000000018967F680
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1456 */, bool useObjectPool = false /* Metadata: 0x00AF145A */) => default; // 0x0000000181C7D620-0x0000000181C7DAD0
	[BlackList] // 0x0000000189686ED0-0x0000000189686F10
	// [XID] // 0x0000000189686ED0-0x0000000189686F10
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C7D0E0-0x0000000181C7D180
	[BlackList] // 0x0000000189691EB0-0x0000000189691EF0
	// [XID] // 0x0000000189691EB0-0x0000000189691EF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C7D180-0x0000000181C7D270
	[BlackList] // 0x000000018969C300-0x000000018969C340
	// [XID] // 0x000000018969C300-0x000000018969C340
	public virtual void ReturnToObjectPool() {} // 0x0000000181C7E130-0x0000000181C7E1D0
	[BlackList] // 0x00000001896A6510-0x00000001896A6550
	// [XID] // 0x00000001896A6510-0x00000001896A6550
	public virtual void OnPoolAllocated() {} // 0x0000000181C7DF20-0x0000000181C7DFC0
	[BlackList] // 0x00000001896B06F0-0x00000001896B0730
	// [XID] // 0x00000001896B06F0-0x00000001896B0730
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C7DE80-0x0000000181C7DF20
}


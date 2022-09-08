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
public class BowDrawTime : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18065
{
	// Fields
	private SimpleSafeFloat bowDrawStartNormTimeRawNum; // 0x10
	private SimpleSafeFloat bowDrawEndNormTimeRawNum; // 0x14

	// Properties
	public float bowDrawStartNormTime { /* [XID] */ /* 0x0000000189BAF3C0-0x0000000189BAF3E0 */ get => default; /* [XID] */ /* 0x0000000189BB6A50-0x0000000189BB6A70 */ private set {} } // 0x0000000182E1D9B0-0x0000000182E1DA90 0x0000000182E1D220-0x0000000182E1D300
	public float bowDrawEndNormTime { /* [XID] */ /* 0x0000000189BBE0B0-0x0000000189BBE0D0 */ get => default; /* [XID] */ /* 0x0000000189BC5D80-0x0000000189BC5DA0 */ private set {} } // 0x0000000182E1D300-0x0000000182E1D3E0 0x0000000182E1DE70-0x0000000182E1DF50

	// Constructors
	public BowDrawTime() {} // 0x0000000182E1E480-0x0000000182E1E530

	// Methods
	// [XID] // 0x0000000189BCD820-0x0000000189BCD840
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E1E190-0x0000000182E1E2A0
	// [XID] // 0x0000000189BD4D30-0x0000000189BD4D50
	public void InitEmpty() {} // 0x0000000182E1DA90-0x0000000182E1DB70
	[BlackList] // 0x0000000189BDC860-0x0000000189BDC8A0
	// [XID] // 0x0000000189BDC860-0x0000000189BDC8A0
	public bool FromJson(JSONNode node) => default; // 0x0000000182E1D630-0x0000000182E1D9B0
	// [XID] // 0x00000001895EC350-0x00000001895EC370
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182E1CAC0-0x0000000182E1CDD0
	// [XID] // 0x00000001895F3810-0x00000001895F3830
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89BD */, bool useObjectPool = false /* Metadata: 0x00AF89C1 */) => default; // 0x0000000182E1DB70-0x0000000182E1DE70
	// [XID] // 0x00000001895FB0F0-0x00000001895FB110
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89C2 */, bool useObjectPool = false /* Metadata: 0x00AF89C6 */) => default; // 0x0000000182E1D3E0-0x0000000182E1D630
	[BlackList] // 0x0000000189602850-0x0000000189602890
	// [XID] // 0x0000000189602850-0x0000000189602890
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E1CDD0-0x0000000182E1D0A0
	// [XID] // 0x000000018960D140-0x000000018960D160
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E1DF50-0x0000000182E1E190
	[BlackList] // 0x00000001896147C0-0x0000000189614800
	// [XID] // 0x00000001896147C0-0x0000000189614800
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E1D0A0-0x0000000182E1D140
	[BlackList] // 0x000000018961F0C0-0x000000018961F100
	// [XID] // 0x000000018961F0C0-0x000000018961F100
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E1D140-0x0000000182E1D220
	[BlackList] // 0x0000000189629810-0x0000000189629850
	// [XID] // 0x0000000189629810-0x0000000189629850
	public virtual void ReturnToObjectPool() {} // 0x0000000182E1E3E0-0x0000000182E1E480
	[BlackList] // 0x0000000189634030-0x0000000189634070
	// [XID] // 0x0000000189634030-0x0000000189634070
	public virtual void OnPoolAllocated() {} // 0x0000000182E1E340-0x0000000182E1E3E0
	[BlackList] // 0x000000018963E760-0x000000018963E7A0
	// [XID] // 0x000000018963E760-0x000000018963E7A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E1E2A0-0x0000000182E1E340
}


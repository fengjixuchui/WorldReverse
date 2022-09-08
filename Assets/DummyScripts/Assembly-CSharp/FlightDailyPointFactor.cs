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
public class FlightDailyPointFactor : IAutoAllocRecycle // TypeDefIndex: 15111
{
	// Fields
	protected SimpleSafeUInt32 time_factorRawNum; // 0x10
	protected SimpleSafeUInt32 gold_factorRawNum; // 0x14

	// Properties
	public uint time_factor { /* [XID] */ /* 0x0000000189797050-0x0000000189797070 */ get => default; /* [XID] */ /* 0x000000018979F090-0x000000018979F0B0 */ protected set {} } // 0x0000000182CF5E00-0x0000000182CF5ED0 0x0000000182CF59C0-0x0000000182CF5AA0
	public uint gold_factor { /* [XID] */ /* 0x00000001897A66E0-0x00000001897A6700 */ get => default; /* [XID] */ /* 0x00000001897ADD10-0x00000001897ADD30 */ protected set {} } // 0x0000000182CF58F0-0x0000000182CF59C0 0x0000000182CF6010-0x0000000182CF60F0

	// Constructors
	public FlightDailyPointFactor() {} // 0x0000000182CF6190-0x0000000182CF61F0

	// Methods
	// [XID] // 0x00000001897B5E30-0x00000001897B5E50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182CF56D0-0x0000000182CF58F0
	// [XID] // 0x00000001897BDC20-0x00000001897BDC40
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0120 */, bool useObjectPool = false /* Metadata: 0x00AF0124 */) => default; // 0x0000000182CF5AA0-0x0000000182CF5E00
	[BlackList] // 0x00000001897C4FE0-0x00000001897C5020
	// [XID] // 0x00000001897C4FE0-0x00000001897C5020
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CF5550-0x0000000182CF55F0
	[BlackList] // 0x00000001897CF890-0x00000001897CF8D0
	// [XID] // 0x00000001897CF890-0x00000001897CF8D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CF55F0-0x0000000182CF56D0
	[BlackList] // 0x00000001897DA4F0-0x00000001897DA530
	// [XID] // 0x00000001897DA4F0-0x00000001897DA530
	public virtual void ReturnToObjectPool() {} // 0x0000000182CF60F0-0x0000000182CF6190
	[BlackList] // 0x00000001897E4890-0x00000001897E48D0
	// [XID] // 0x00000001897E4890-0x00000001897E48D0
	public virtual void OnPoolAllocated() {} // 0x0000000182CF5F70-0x0000000182CF6010
	[BlackList] // 0x00000001897EF410-0x00000001897EF450
	// [XID] // 0x00000001897EF410-0x00000001897EF450
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CF5ED0-0x0000000182CF5F70
}


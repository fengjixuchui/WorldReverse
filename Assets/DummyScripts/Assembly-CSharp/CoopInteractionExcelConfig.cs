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
public class CoopInteractionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15458
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 npcIdRawNum; // 0x14
	protected SimpleSafeUInt32 mainQuestIdRawNum; // 0x18
	protected SimpleSafeUInt32 priorityRawNum; // 0x1C
	protected bool _isAuto; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x000000018965E2B0-0x000000018965E2D0 */ get => default; /* [XID] */ /* 0x0000000189665A30-0x0000000189665A50 */ protected set {} } // 0x00000001834ED330-0x00000001834ED400 0x00000001834EC8A0-0x00000001834EC980
	public uint npcId { /* [XID] */ /* 0x000000018966D0E0-0x000000018966D100 */ get => default; /* [XID] */ /* 0x0000000189675010-0x0000000189675030 */ protected set {} } // 0x00000001834EC6F0-0x00000001834EC7C0 0x00000001834ECED0-0x00000001834ECFB0
	public uint mainQuestId { /* [XID] */ /* 0x000000018967C800-0x000000018967C820 */ get => default; /* [XID] */ /* 0x0000000189683E90-0x0000000189683EB0 */ protected set {} } // 0x00000001834ED120-0x00000001834ED1F0 0x00000001834EBEA0-0x00000001834EBF80
	public uint priority { /* [XID] */ /* 0x00000001896FDF20-0x00000001896FDF40 */ get => default; /* [XID] */ /* 0x0000000189693680-0x00000001896936A0 */ protected set {} } // 0x00000001834ECFB0-0x00000001834ED080 0x00000001834EC7C0-0x00000001834EC8A0
	public bool isAuto { /* [XID] */ /* 0x000000018969A970-0x000000018969A990 */ get => default; /* [XID] */ /* 0x00000001896A2400-0x00000001896A2420 */ protected set {} } // 0x00000001834ED080-0x00000001834ED120 0x00000001834EBC40-0x00000001834EBCF0

	// Constructors
	public CoopInteractionExcelConfig() {} // 0x00000001834ED4A0-0x00000001834ED500

	// Methods
	// [IDTag] // 0x00000001896A95C0-0x00000001896A9600
	// [XID] // 0x00000001896A95C0-0x00000001896A9600
	public virtual bool ParseFromLine(string line) => default; // 0x00000001834EBF80-0x00000001834EC350
	// [IDTag] // 0x00000001896B37D0-0x00000001896B3810
	// [XID] // 0x00000001896B37D0-0x00000001896B3810
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001834EC350-0x00000001834EC6F0
	// [XID] // 0x00000001896BDA60-0x00000001896BDA80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B13 */, bool useObjectPool = false /* Metadata: 0x00AF1B17 */) => default; // 0x00000001834EC980-0x00000001834ECED0
	[BlackList] // 0x00000001896C5250-0x00000001896C5290
	// [XID] // 0x00000001896C5250-0x00000001896C5290
	public virtual void AutoAllocTypeFields() {} // 0x00000001834EBCF0-0x00000001834EBD90
	[BlackList] // 0x00000001896CFA70-0x00000001896CFAB0
	// [XID] // 0x00000001896CFA70-0x00000001896CFAB0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001834EBD90-0x00000001834EBEA0
	[BlackList] // 0x00000001896D9F90-0x00000001896D9FD0
	// [XID] // 0x00000001896D9F90-0x00000001896D9FD0
	public virtual void ReturnToObjectPool() {} // 0x00000001834ED400-0x00000001834ED4A0
	[BlackList] // 0x00000001896E4510-0x00000001896E4550
	// [XID] // 0x00000001896E4510-0x00000001896E4550
	public virtual void OnPoolAllocated() {} // 0x00000001834ED290-0x00000001834ED330
	[BlackList] // 0x00000001896EE770-0x00000001896EE7B0
	// [XID] // 0x00000001896EE770-0x00000001896EE7B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001834ED1F0-0x00000001834ED290
}


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
public class ElementCoeffExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15561
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected SimpleSafeFloat crashCoRawNum; // 0x14
	protected SimpleSafeFloat elementLevelCoRawNum; // 0x18
	protected SimpleSafeFloat playerElementLevelCoRawNum; // 0x1C
	protected SimpleSafeFloat playerShieldLevelCoRawNum; // 0x20

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189A266A0-0x0000000189A266C0 */ get => default; /* [XID] */ /* 0x0000000189A2D9D0-0x0000000189A2D9F0 */ protected set {} } // 0x000000018348C080-0x000000018348C150 0x000000018348BFA0-0x000000018348C080
	public float crashCo { /* [XID] */ /* 0x0000000189A355B0-0x0000000189A355D0 */ get => default; /* [XID] */ /* 0x0000000189A3CA40-0x0000000189A3CA60 */ protected set {} } // 0x000000018348AD60-0x000000018348AE40 0x000000018348AE40-0x000000018348AF20
	public float elementLevelCo { /* [XID] */ /* 0x0000000189A44490-0x0000000189A444B0 */ get => default; /* [XID] */ /* 0x0000000189A4BA60-0x0000000189A4BA80 */ protected set {} } // 0x000000018348C310-0x000000018348C3F0 0x000000018348C3F0-0x000000018348C4D0
	public float playerElementLevelCo { /* [XID] */ /* 0x0000000189A53140-0x0000000189A53160 */ get => default; /* [XID] */ /* 0x0000000189A5A8F0-0x0000000189A5A910 */ protected set {} } // 0x000000018348B950-0x000000018348BA30 0x000000018348C230-0x000000018348C310
	public float playerShieldLevelCo { /* [XID] */ /* 0x0000000189A620D0-0x0000000189A620F0 */ get => default; /* [XID] */ /* 0x0000000189A69FB0-0x0000000189A69FD0 */ protected set {} } // 0x000000018348C150-0x000000018348C230 0x000000018348B870-0x000000018348B950

	// Constructors
	public ElementCoeffExcelConfig() {} // 0x000000018348C6B0-0x000000018348C710

	// Methods
	// [IDTag] // 0x0000000189A71260-0x0000000189A712A0
	// [XID] // 0x0000000189A71260-0x0000000189A712A0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018348B4A0-0x000000018348B870
	// [IDTag] // 0x0000000189A7BDA0-0x0000000189A7BDE0
	// [XID] // 0x0000000189A7BDA0-0x0000000189A7BDE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018348B100-0x000000018348B4A0
	// [XID] // 0x0000000189A86550-0x0000000189A86570
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F20 */, bool useObjectPool = false /* Metadata: 0x00AF1F24 */) => default; // 0x000000018348BA30-0x000000018348BFA0
	[BlackList] // 0x0000000189A8E0F0-0x0000000189A8E130
	// [XID] // 0x0000000189A8E0F0-0x0000000189A8E130
	public virtual void AutoAllocTypeFields() {} // 0x000000018348AF20-0x000000018348AFC0
	[BlackList] // 0x0000000189A989C0-0x0000000189A98A00
	// [XID] // 0x0000000189A989C0-0x0000000189A98A00
	public virtual void AutoRecycleTypeFields() {} // 0x000000018348AFC0-0x000000018348B100
	[BlackList] // 0x0000000189AA2B20-0x0000000189AA2B60
	// [XID] // 0x0000000189AA2B20-0x0000000189AA2B60
	public virtual void ReturnToObjectPool() {} // 0x000000018348C610-0x000000018348C6B0
	[BlackList] // 0x0000000189AAD320-0x0000000189AAD360
	// [XID] // 0x0000000189AAD320-0x0000000189AAD360
	public virtual void OnPoolAllocated() {} // 0x000000018348C570-0x000000018348C610
	[BlackList] // 0x0000000189AB7BC0-0x0000000189AB7C00
	// [XID] // 0x0000000189AB7BC0-0x0000000189AB7C00
	public virtual void OnBeforePoolRecycled() {} // 0x000000018348C4D0-0x000000018348C570
}


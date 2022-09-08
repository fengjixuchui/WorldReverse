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
public class CoopCondConfig : IAutoAllocRecycle // TypeDefIndex: 15455
{
	// Fields
	protected CoopTaskCondType _condType; // 0x10
	protected SimpleSafeUInt32[] _args; // 0x18

	// Properties
	public CoopTaskCondType condType { /* [XID] */ /* 0x0000000189AF0490-0x0000000189AF04B0 */ get => default; /* [XID] */ /* 0x0000000189AF79C0-0x0000000189AF79E0 */ protected set {} } // 0x00000001835B3F70-0x00000001835B4010 0x00000001835B3570-0x00000001835B3620
	public SimpleSafeUInt32[] args { /* [XID] */ /* 0x0000000189AFEF10-0x0000000189AFEF30 */ get => default; /* [XID] */ /* 0x0000000189B067E0-0x0000000189B06800 */ protected set {} } // 0x00000001835B3760-0x00000001835B3800 0x00000001835B3B50-0x00000001835B3C00

	// Constructors
	public CoopCondConfig() {} // 0x00000001835B41F0-0x00000001835B4250

	// Methods
	// [XID] // 0x0000000189B0DED0-0x0000000189B0DEF0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001835B3800-0x00000001835B3B50
	// [XID] // 0x0000000189B15250-0x0000000189B15270
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1AFF */, bool useObjectPool = false /* Metadata: 0x00AF1B03 */) => default; // 0x00000001835B3C00-0x00000001835B3F70
	[BlackList] // 0x0000000189B1CCD0-0x0000000189B1CD10
	// [XID] // 0x0000000189B1CCD0-0x0000000189B1CD10
	public virtual void AutoAllocTypeFields() {} // 0x00000001835B3620-0x00000001835B36C0
	[BlackList] // 0x0000000189B27200-0x0000000189B27240
	// [XID] // 0x0000000189B27200-0x0000000189B27240
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835B36C0-0x00000001835B3760
	[BlackList] // 0x0000000189B31630-0x0000000189B31670
	// [XID] // 0x0000000189B31630-0x0000000189B31670
	public virtual void ReturnToObjectPool() {} // 0x00000001835B4150-0x00000001835B41F0
	[BlackList] // 0x0000000189B3BC10-0x0000000189B3BC50
	// [XID] // 0x0000000189B3BC10-0x0000000189B3BC50
	public virtual void OnPoolAllocated() {} // 0x00000001835B40B0-0x00000001835B4150
	[BlackList] // 0x0000000189B46740-0x0000000189B46780
	// [XID] // 0x0000000189B46740-0x0000000189B46780
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835B4010-0x00000001835B40B0
}


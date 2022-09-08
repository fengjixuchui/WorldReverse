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
public class AvatarCurveExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15675
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected GrowCurveInfo[] _curveInfos; // 0x18

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189AB7B80-0x0000000189AB7BA0 */ get => default; /* [XID] */ /* 0x0000000189ABF670-0x0000000189ABF690 */ protected set {} } // 0x000000018517B840-0x000000018517B910 0x000000018517B760-0x000000018517B840
	public GrowCurveInfo[] curveInfos { /* [XID] */ /* 0x0000000189AC70A0-0x0000000189AC70C0 */ get => default; /* [XID] */ /* 0x0000000189ACE7D0-0x0000000189ACE7F0 */ protected set {} } // 0x000000018517B350-0x000000018517B3F0 0x000000018517B910-0x000000018517B9C0

	// Constructors
	public AvatarCurveExcelConfig() {} // 0x000000018517BBA0-0x000000018517BC00

	// Methods
	// [IDTag] // 0x0000000189AD6680-0x0000000189AD66C0
	// [XID] // 0x0000000189AD6680-0x0000000189AD66C0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018517AFF0-0x000000018517B350
	// [IDTag] // 0x0000000189AE1080-0x0000000189AE10C0
	// [XID] // 0x0000000189AE1080-0x0000000189AE10C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018517AD10-0x000000018517AFF0
	// [XID] // 0x0000000189AEB910-0x0000000189AEB930
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22AB */, bool useObjectPool = false /* Metadata: 0x00AF22AF */) => default; // 0x000000018517B3F0-0x000000018517B760
	[BlackList] // 0x0000000189AF3270-0x0000000189AF32B0
	// [XID] // 0x0000000189AF3270-0x0000000189AF32B0
	public virtual void AutoAllocTypeFields() {} // 0x000000018517AB90-0x000000018517AC30
	[BlackList] // 0x0000000189AFD730-0x0000000189AFD770
	// [XID] // 0x0000000189AFD730-0x0000000189AFD770
	public virtual void AutoRecycleTypeFields() {} // 0x000000018517AC30-0x000000018517AD10
	[BlackList] // 0x0000000189B07DF0-0x0000000189B07E30
	// [XID] // 0x0000000189B07DF0-0x0000000189B07E30
	public virtual void ReturnToObjectPool() {} // 0x000000018517BB00-0x000000018517BBA0
	[BlackList] // 0x0000000189B12600-0x0000000189B12640
	// [XID] // 0x0000000189B12600-0x0000000189B12640
	public virtual void OnPoolAllocated() {} // 0x000000018517BA60-0x000000018517BB00
	[BlackList] // 0x0000000189B1CC50-0x0000000189B1CC90
	// [XID] // 0x0000000189B1CC50-0x0000000189B1CC90
	public virtual void OnBeforePoolRecycled() {} // 0x000000018517B9C0-0x000000018517BA60
}


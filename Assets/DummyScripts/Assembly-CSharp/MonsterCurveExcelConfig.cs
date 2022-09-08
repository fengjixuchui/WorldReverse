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
public class MonsterCurveExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15677
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected GrowCurveInfo[] _curveInfos; // 0x18

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189BA9CA0-0x0000000189BA9CC0 */ get => default; /* [XID] */ /* 0x0000000189BB15B0-0x0000000189BB15D0 */ protected set {} } // 0x0000000184778FE0-0x00000001847790B0 0x0000000184778F00-0x0000000184778FE0
	public GrowCurveInfo[] curveInfos { /* [XID] */ /* 0x00000001896BDFC0-0x00000001896BDFE0 */ get => default; /* [XID] */ /* 0x0000000189BBFE70-0x0000000189BBFE90 */ protected set {} } // 0x0000000184778AF0-0x0000000184778B90 0x00000001847790B0-0x0000000184779160

	// Constructors
	public MonsterCurveExcelConfig() {} // 0x0000000184779340-0x00000001847793A0

	// Methods
	// [IDTag] // 0x0000000189BC7880-0x0000000189BC78C0
	// [XID] // 0x0000000189BC7880-0x0000000189BC78C0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184778790-0x0000000184778AF0
	// [IDTag] // 0x0000000189BD2420-0x0000000189BD2460
	// [XID] // 0x0000000189BD2420-0x0000000189BD2460
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001847784B0-0x0000000184778790
	// [XID] // 0x0000000189BDCDC0-0x0000000189BDCDE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22BA */, bool useObjectPool = false /* Metadata: 0x00AF22BE */) => default; // 0x0000000184778B90-0x0000000184778F00
	[BlackList] // 0x00000001895E9610-0x00000001895E9650
	// [XID] // 0x00000001895E9610-0x00000001895E9650
	public virtual void AutoAllocTypeFields() {} // 0x0000000184778330-0x00000001847783D0
	[BlackList] // 0x00000001895F3D30-0x00000001895F3D70
	// [XID] // 0x00000001895F3D30-0x00000001895F3D70
	public virtual void AutoRecycleTypeFields() {} // 0x00000001847783D0-0x00000001847784B0
	[BlackList] // 0x00000001895FE440-0x00000001895FE480
	// [XID] // 0x00000001895FE440-0x00000001895FE480
	public virtual void ReturnToObjectPool() {} // 0x00000001847792A0-0x0000000184779340
	[BlackList] // 0x0000000189608F30-0x0000000189608F70
	// [XID] // 0x0000000189608F30-0x0000000189608F70
	public virtual void OnPoolAllocated() {} // 0x0000000184779200-0x00000001847792A0
	[BlackList] // 0x0000000189613460-0x00000001896134A0
	// [XID] // 0x0000000189613460-0x00000001896134A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184779160-0x0000000184779200
}


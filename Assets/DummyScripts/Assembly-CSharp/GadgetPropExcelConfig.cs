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
public class GadgetPropExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15639
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeFloat hpRawNum; // 0x14
	protected GrowCurveType _hpCurve; // 0x18
	protected SimpleSafeFloat attackRawNum; // 0x1C
	protected GrowCurveType _attackCurve; // 0x20
	protected SimpleSafeFloat defenseRawNum; // 0x24
	protected GrowCurveType _defenseCurve; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B00790-0x0000000189B007B0 */ get => default; /* [XID] */ /* 0x0000000189B07E30-0x0000000189B07E50 */ protected set {} } // 0x00000001823314A0-0x0000000182331570 0x00000001823309B0-0x0000000182330A90
	public float hp { /* [XID] */ /* 0x0000000189B0F5F0-0x0000000189B0F610 */ get => default; /* [XID] */ /* 0x0000000189B16930-0x0000000189B16950 */ protected set {} } // 0x0000000182330A90-0x0000000182330B70 0x0000000182330660-0x0000000182330740
	public GrowCurveType hpCurve { /* [XID] */ /* 0x0000000189B1DFD0-0x0000000189B1DFF0 */ get => default; /* [XID] */ /* 0x0000000189B258A0-0x0000000189B258C0 */ protected set {} } // 0x000000018232FAB0-0x000000018232FB50 0x000000018232FB50-0x000000018232FC00
	public float attack { /* [XID] */ /* 0x0000000189B2CD30-0x0000000189B2CD50 */ get => default; /* [XID] */ /* 0x0000000189B341A0-0x0000000189B341C0 */ protected set {} } // 0x00000001823307F0-0x00000001823308D0 0x0000000182331570-0x0000000182331650
	public GrowCurveType attackCurve { /* [XID] */ /* 0x00000001896C58B0-0x00000001896C58D0 */ get => default; /* [XID] */ /* 0x0000000189B43570-0x0000000189B43590 */ protected set {} } // 0x00000001823312C0-0x0000000182331360 0x0000000182331210-0x00000001823312C0
	public float defense { /* [XID] */ /* 0x0000000189B4AD70-0x0000000189B4AD90 */ get => default; /* [XID] */ /* 0x0000000189B52380-0x0000000189B523A0 */ protected set {} } // 0x00000001823308D0-0x00000001823309B0 0x000000018232F9D0-0x000000018232FAB0
	public GrowCurveType defenseCurve { /* [XID] */ /* 0x00000001897634A0-0x00000001897634C0 */ get => default; /* [XID] */ /* 0x0000000189B61470-0x0000000189B61490 */ protected set {} } // 0x000000018232FC00-0x000000018232FCA0 0x0000000182330740-0x00000001823307F0

	// Constructors
	public GadgetPropExcelConfig() {} // 0x00000001823316F0-0x0000000182331750

	// Methods
	// [IDTag] // 0x0000000189B68F20-0x0000000189B68F60
	// [XID] // 0x0000000189B68F20-0x0000000189B68F60
	public virtual bool ParseFromLine(string line) => default; // 0x000000018232FCA0-0x0000000182330190
	// [IDTag] // 0x0000000189B732B0-0x0000000189B732F0
	// [XID] // 0x0000000189B732B0-0x0000000189B732F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182330190-0x0000000182330660
	// [XID] // 0x0000000189B7D760-0x0000000189B7D780
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2161 */, bool useObjectPool = false /* Metadata: 0x00AF2165 */) => default; // 0x0000000182330B70-0x0000000182331210
	[BlackList] // 0x0000000189B854D0-0x0000000189B85510
	// [XID] // 0x0000000189B854D0-0x0000000189B85510
	public virtual void AutoAllocTypeFields() {} // 0x000000018232F7F0-0x000000018232F890
	[BlackList] // 0x0000000189B8F330-0x0000000189B8F370
	// [XID] // 0x0000000189B8F330-0x0000000189B8F370
	public virtual void AutoRecycleTypeFields() {} // 0x000000018232F890-0x000000018232F9D0
	[BlackList] // 0x0000000189B99780-0x0000000189B997C0
	// [XID] // 0x0000000189B99780-0x0000000189B997C0
	public virtual void ReturnToObjectPool() {} // 0x0000000182331650-0x00000001823316F0
	[BlackList] // 0x0000000189BA3DF0-0x0000000189BA3E30
	// [XID] // 0x0000000189BA3DF0-0x0000000189BA3E30
	public virtual void OnPoolAllocated() {} // 0x0000000182331400-0x00000001823314A0
	[BlackList] // 0x0000000189BADEA0-0x0000000189BADEE0
	// [XID] // 0x0000000189BADEA0-0x0000000189BADEE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182331360-0x0000000182331400
}


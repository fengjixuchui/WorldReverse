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
public class AbilityPropExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14986
{
	// Fields
	protected string _propName; // 0x10
	protected SimpleSafeFloat overallMinRawNum; // 0x18
	protected SimpleSafeFloat overallMaxRawNum; // 0x1C
	protected SimpleSafeFloat limitTagMinRawNum; // 0x20
	protected SimpleSafeFloat limitTagMaxRawNum; // 0x24
	protected bool _succeedOwner; // 0x28

	// Properties
	public string propName { /* [XID] */ /* 0x0000000189890880-0x00000001898908A0 */ get => default; /* [XID] */ /* 0x0000000189897E20-0x0000000189897E40 */ protected set {} } // 0x00000001817DDEC0-0x00000001817DDF60 0x00000001817DC7E0-0x00000001817DC890
	public float overallMin { /* [XID] */ /* 0x000000018989F1C0-0x000000018989F1E0 */ get => default; /* [XID] */ /* 0x00000001898A6D60-0x00000001898A6D80 */ protected set {} } // 0x00000001817DCDC0-0x00000001817DCEA0 0x00000001817DD6F0-0x00000001817DD7D0
	public float overallMax { /* [XID] */ /* 0x00000001898AE570-0x00000001898AE590 */ get => default; /* [XID] */ /* 0x00000001898B5A50-0x00000001898B5A70 */ protected set {} } // 0x00000001817DCB20-0x00000001817DCC00 0x00000001817DCC00-0x00000001817DCCE0
	public float limitTagMin { /* [XID] */ /* 0x00000001898BD4A0-0x00000001898BD4C0 */ get => default; /* [XID] */ /* 0x00000001898C4C40-0x00000001898C4C60 */ protected set {} } // 0x00000001817DE140-0x00000001817DE220 0x00000001817DCCE0-0x00000001817DCDC0
	public float limitTagMax { /* [XID] */ /* 0x00000001898CC030-0x00000001898CC050 */ get => default; /* [XID] */ /* 0x00000001898D38D0-0x00000001898D38F0 */ protected set {} } // 0x00000001817DC890-0x00000001817DC970 0x00000001817DD7D0-0x00000001817DD8B0
	public bool succeedOwner { /* [XID] */ /* 0x00000001898DB0E0-0x00000001898DB100 */ get => default; /* [XID] */ /* 0x00000001898E2E40-0x00000001898E2E60 */ protected set {} } // 0x00000001817DDF60-0x00000001817DE000 0x00000001817DE220-0x00000001817DE2D0

	// Constructors
	public AbilityPropExcelConfig() {} // 0x00000001817DE370-0x00000001817DE3D0

	// Methods
	// [IDTag] // 0x00000001898EAAF0-0x00000001898EAB30
	// [XID] // 0x00000001898EAAF0-0x00000001898EAB30
	public virtual bool ParseFromLine(string line) => default; // 0x00000001817DD2C0-0x00000001817DD6F0
	// [IDTag] // 0x00000001898F5200-0x00000001898F5240
	// [XID] // 0x00000001898F5200-0x00000001898F5240
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001817DCEA0-0x00000001817DD2C0
	// [XID] // 0x00000001898FFA90-0x00000001898FFAB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDBC */, bool useObjectPool = false /* Metadata: 0x00AEFDC0 */) => default; // 0x00000001817DD8B0-0x00000001817DDEC0
	[BlackList] // 0x00000001899072D0-0x0000000189907310
	// [XID] // 0x00000001899072D0-0x0000000189907310
	public virtual void AutoAllocTypeFields() {} // 0x00000001817DC970-0x00000001817DCA10
	[BlackList] // 0x0000000189911AA0-0x0000000189911AE0
	// [XID] // 0x0000000189911AA0-0x0000000189911AE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817DCA10-0x00000001817DCB20
	[BlackList] // 0x000000018991C7C0-0x000000018991C800
	// [XID] // 0x000000018991C7C0-0x000000018991C800
	public virtual void ReturnToObjectPool() {} // 0x00000001817DE2D0-0x00000001817DE370
	[BlackList] // 0x0000000189926E80-0x0000000189926EC0
	// [XID] // 0x0000000189926E80-0x0000000189926EC0
	public virtual void OnPoolAllocated() {} // 0x00000001817DE0A0-0x00000001817DE140
	[BlackList] // 0x0000000189931300-0x0000000189931340
	// [XID] // 0x0000000189931300-0x0000000189931340
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817DE000-0x00000001817DE0A0
}


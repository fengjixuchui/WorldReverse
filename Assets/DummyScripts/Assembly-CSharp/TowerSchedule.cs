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
public class TowerSchedule : IAutoAllocRecycle // TypeDefIndex: 16191
{
	// Fields
	protected SimpleSafeUInt32[] _floorList; // 0x10
	protected string _openTime; // 0x18

	// Properties
	public SimpleSafeUInt32[] floorList { /* [XID] */ /* 0x000000018978B2C0-0x000000018978B2E0 */ get => default; /* [XID] */ /* 0x00000001897927E0-0x0000000189792800 */ protected set {} } // 0x000000018274B700-0x000000018274B7A0 0x000000018274B2E0-0x000000018274B390
	public string openTime { /* [XID] */ /* 0x0000000189799D30-0x0000000189799D50 */ get => default; /* [XID] */ /* 0x00000001897A1C20-0x00000001897A1C40 */ protected set {} } // 0x000000018274AC50-0x000000018274ACF0 0x000000018274B230-0x000000018274B2E0

	// Constructors
	public TowerSchedule() {} // 0x000000018274B980-0x000000018274B9E0

	// Methods
	// [XID] // 0x00000001897A9480-0x00000001897A94A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018274AE30-0x000000018274B230
	// [XID] // 0x00000001897B0BC0-0x00000001897B0BE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33C5 */, bool useObjectPool = false /* Metadata: 0x00AF33C9 */) => default; // 0x000000018274B390-0x000000018274B700
	[BlackList] // 0x00000001897B8940-0x00000001897B8980
	// [XID] // 0x00000001897B8940-0x00000001897B8980
	public virtual void AutoAllocTypeFields() {} // 0x000000018274ACF0-0x000000018274AD90
	[BlackList] // 0x00000001897C3770-0x00000001897C37B0
	// [XID] // 0x00000001897C3770-0x00000001897C37B0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018274AD90-0x000000018274AE30
	[BlackList] // 0x00000001897CE080-0x00000001897CE0C0
	// [XID] // 0x00000001897CE080-0x00000001897CE0C0
	public virtual void ReturnToObjectPool() {} // 0x000000018274B8E0-0x000000018274B980
	[BlackList] // 0x00000001897D8CF0-0x00000001897D8D30
	// [XID] // 0x00000001897D8CF0-0x00000001897D8D30
	public virtual void OnPoolAllocated() {} // 0x000000018274B840-0x000000018274B8E0
	[BlackList] // 0x00000001897E2F60-0x00000001897E2FA0
	// [XID] // 0x00000001897E2F60-0x00000001897E2FA0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018274B7A0-0x000000018274B840
}


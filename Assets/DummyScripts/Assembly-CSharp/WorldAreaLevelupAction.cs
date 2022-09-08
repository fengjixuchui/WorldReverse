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
public class WorldAreaLevelupAction : IAutoAllocRecycle // TypeDefIndex: 16299
{
	// Fields
	protected WorldAreaLevelupActionType _type; // 0x10
	protected SimpleSafeUInt32[] _param1_vec; // 0x18
	protected SimpleSafeUInt32[] _param2_vec; // 0x20

	// Properties
	public WorldAreaLevelupActionType type { /* [XID] */ /* 0x0000000189770170-0x0000000189770190 */ get => default; /* [XID] */ /* 0x0000000189777850-0x0000000189777870 */ protected set {} } // 0x00000001835FE610-0x00000001835FE6B0 0x00000001835FE380-0x00000001835FE430
	public SimpleSafeUInt32[] param1_vec { /* [XID] */ /* 0x000000018977EEC0-0x000000018977EEE0 */ get => default; /* [XID] */ /* 0x00000001897868C0-0x00000001897868E0 */ protected set {} } // 0x00000001835FE2E0-0x00000001835FE380 0x00000001835FD7B0-0x00000001835FD860
	public SimpleSafeUInt32[] param2_vec { /* [XID] */ /* 0x000000018978DED0-0x000000018978DEF0 */ get => default; /* [XID] */ /* 0x0000000189795640-0x0000000189795660 */ protected set {} } // 0x00000001835FE570-0x00000001835FE610 0x00000001835FE6B0-0x00000001835FE760

	// Constructors
	public WorldAreaLevelupAction() {} // 0x00000001835FE800-0x00000001835FE860

	// Methods
	// [XID] // 0x000000018979DAB0-0x000000018979DAD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001835FD860-0x00000001835FDED0
	// [XID] // 0x00000001897A4DD0-0x00000001897A4DF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF36F7 */, bool useObjectPool = false /* Metadata: 0x00AF36FB */) => default; // 0x00000001835FDED0-0x00000001835FE2E0
	[BlackList] // 0x00000001897AC320-0x00000001897AC360
	// [XID] // 0x00000001897AC320-0x00000001897AC360
	public virtual void AutoAllocTypeFields() {} // 0x00000001835FD660-0x00000001835FD700
	[BlackList] // 0x00000001897B7410-0x00000001897B7450
	// [XID] // 0x00000001897B7410-0x00000001897B7450
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835FD700-0x00000001835FD7B0
	[BlackList] // 0x00000001897C1F70-0x00000001897C1FB0
	// [XID] // 0x00000001897C1F70-0x00000001897C1FB0
	public virtual void ReturnToObjectPool() {} // 0x00000001835FE760-0x00000001835FE800
	[BlackList] // 0x00000001897CC5D0-0x00000001897CC610
	// [XID] // 0x00000001897CC5D0-0x00000001897CC610
	public virtual void OnPoolAllocated() {} // 0x00000001835FE4D0-0x00000001835FE570
	[BlackList] // 0x00000001897D6F00-0x00000001897D6F40
	// [XID] // 0x00000001897D6F00-0x00000001897D6F40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835FE430-0x00000001835FE4D0
}


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
public class WorldLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16096
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected SimpleSafeUInt32 monsterLevelRawNum; // 0x14

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189944780-0x00000001899447A0 */ get => default; /* [XID] */ /* 0x000000018994BDA0-0x000000018994BDC0 */ protected set {} } // 0x000000018417CBA0-0x000000018417CC70 0x000000018417CAC0-0x000000018417CBA0
	public uint monsterLevel { /* [XID] */ /* 0x00000001898C0890-0x00000001898C08B0 */ get => default; /* [XID] */ /* 0x000000018995AC90-0x000000018995ACB0 */ protected set {} } // 0x000000018417CD50-0x000000018417CE20 0x000000018417CC70-0x000000018417CD50

	// Constructors
	public WorldLevelExcelConfig() {} // 0x000000018417D000-0x000000018417D060

	// Methods
	// [IDTag] // 0x0000000189962830-0x0000000189962870
	// [XID] // 0x0000000189962830-0x0000000189962870
	public virtual bool ParseFromLine(string line) => default; // 0x000000018417C4F0-0x000000018417C760
	// [IDTag] // 0x000000018996CC50-0x000000018996CC90
	// [XID] // 0x000000018996CC50-0x000000018996CC90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018417C2D0-0x000000018417C4F0
	// [XID] // 0x0000000189977760-0x0000000189977780
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3027 */, bool useObjectPool = false /* Metadata: 0x00AF302B */) => default; // 0x000000018417C760-0x000000018417CAC0
	[BlackList] // 0x000000018997E9C0-0x000000018997EA00
	// [XID] // 0x000000018997E9C0-0x000000018997EA00
	public virtual void AutoAllocTypeFields() {} // 0x000000018417C150-0x000000018417C1F0
	[BlackList] // 0x0000000189989880-0x00000001899898C0
	// [XID] // 0x0000000189989880-0x00000001899898C0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018417C1F0-0x000000018417C2D0
	[BlackList] // 0x00000001899943B0-0x00000001899943F0
	// [XID] // 0x00000001899943B0-0x00000001899943F0
	public virtual void ReturnToObjectPool() {} // 0x000000018417CF60-0x000000018417D000
	[BlackList] // 0x000000018999ED70-0x000000018999EDB0
	// [XID] // 0x000000018999ED70-0x000000018999EDB0
	public virtual void OnPoolAllocated() {} // 0x000000018417CEC0-0x000000018417CF60
	[BlackList] // 0x00000001899A9620-0x00000001899A9660
	// [XID] // 0x00000001899A9620-0x00000001899A9660
	public virtual void OnBeforePoolRecycled() {} // 0x000000018417CE20-0x000000018417CEC0
}


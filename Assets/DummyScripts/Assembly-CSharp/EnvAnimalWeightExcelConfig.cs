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
public class EnvAnimalWeightExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15574
{
	// Fields
	protected EnvironmentType _envType; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected EnvironmentWeightType[] _weightVec; // 0x18

	// Properties
	public EnvironmentType envType { /* [XID] */ /* 0x0000000189BC61C0-0x0000000189BC61E0 */ get => default; /* [XID] */ /* 0x0000000189BCDDA0-0x0000000189BCDDC0 */ protected set {} } // 0x000000018397B420-0x000000018397B4C0 0x000000018397B230-0x000000018397B2E0
	public EnvironmentWeightType[] weightVec { /* [XID] */ /* 0x0000000189BD5290-0x0000000189BD52B0 */ get => default; /* [XID] */ /* 0x0000000189BDCE00-0x0000000189BDCE20 */ protected set {} } // 0x000000018397B190-0x000000018397B230 0x000000018397A570-0x000000018397A620

	// Constructors
	public EnvAnimalWeightExcelConfig() {} // 0x000000018397B560-0x000000018397B5C0

	// Methods
	// [IDTag] // 0x00000001895E9670-0x00000001895E96B0
	// [XID] // 0x00000001895E9670-0x00000001895E96B0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018397AA80-0x000000018397AE20
	// [IDTag] // 0x00000001895F3D90-0x00000001895F3DD0
	// [XID] // 0x00000001895F3D90-0x00000001895F3DD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018397A770-0x000000018397AA80
	// [XID] // 0x00000001895FE480-0x00000001895FE4A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F7F */, bool useObjectPool = false /* Metadata: 0x00AF1F83 */) => default; // 0x000000018397AE20-0x000000018397B190
	[BlackList] // 0x0000000189605DF0-0x0000000189605E30
	// [XID] // 0x0000000189605DF0-0x0000000189605E30
	public virtual void AutoAllocTypeFields() {} // 0x000000018397A620-0x000000018397A6C0
	[BlackList] // 0x0000000189610710-0x0000000189610750
	// [XID] // 0x0000000189610710-0x0000000189610750
	public virtual void AutoRecycleTypeFields() {} // 0x000000018397A6C0-0x000000018397A770
	[BlackList] // 0x000000018961ACE0-0x000000018961AD20
	// [XID] // 0x000000018961ACE0-0x000000018961AD20
	public virtual void ReturnToObjectPool() {} // 0x000000018397B4C0-0x000000018397B560
	[BlackList] // 0x0000000189625110-0x0000000189625150
	// [XID] // 0x0000000189625110-0x0000000189625150
	public virtual void OnPoolAllocated() {} // 0x000000018397B380-0x000000018397B420
	[BlackList] // 0x000000018962FB20-0x000000018962FB60
	// [XID] // 0x000000018962FB20-0x000000018962FB60
	public virtual void OnBeforePoolRecycled() {} // 0x000000018397B2E0-0x000000018397B380
}


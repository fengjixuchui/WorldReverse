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
public class SourceJumpConfig : IAutoAllocRecycle // TypeDefIndex: 15826
{
	// Fields
	protected SourceJumpType _jumpType; // 0x10
	protected SimpleSafeUInt32 jumpParamRawNum; // 0x14

	// Properties
	public SourceJumpType jumpType { /* [XID] */ /* 0x00000001897FCC60-0x00000001897FCC80 */ get => default; /* [XID] */ /* 0x0000000189804270-0x0000000189804290 */ protected set {} } // 0x000000018364D7D0-0x000000018364D870 0x000000018364D870-0x000000018364D920
	public uint jumpParam { /* [XID] */ /* 0x000000018980B700-0x000000018980B720 */ get => default; /* [XID] */ /* 0x0000000189812E80-0x0000000189812EA0 */ protected set {} } // 0x000000018364D920-0x000000018364D9F0 0x000000018364D9F0-0x000000018364DAD0

	// Constructors
	public SourceJumpConfig() {} // 0x000000018364DCB0-0x000000018364DD10

	// Methods
	// [XID] // 0x000000018981AA00-0x000000018981AA20
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018364D230-0x000000018364D470
	// [XID] // 0x0000000189822210-0x0000000189822230
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF278B */, bool useObjectPool = false /* Metadata: 0x00AF278F */) => default; // 0x000000018364D470-0x000000018364D7D0
	[BlackList] // 0x0000000189829790-0x00000001898297D0
	// [XID] // 0x0000000189829790-0x00000001898297D0
	public virtual void AutoAllocTypeFields() {} // 0x000000018364D0C0-0x000000018364D160
	[BlackList] // 0x0000000189833D40-0x0000000189833D80
	// [XID] // 0x0000000189833D40-0x0000000189833D80
	public virtual void AutoRecycleTypeFields() {} // 0x000000018364D160-0x000000018364D230
	[BlackList] // 0x000000018983E120-0x000000018983E160
	// [XID] // 0x000000018983E120-0x000000018983E160
	public virtual void ReturnToObjectPool() {} // 0x000000018364DC10-0x000000018364DCB0
	[BlackList] // 0x0000000189848420-0x0000000189848460
	// [XID] // 0x0000000189848420-0x0000000189848460
	public virtual void OnPoolAllocated() {} // 0x000000018364DB70-0x000000018364DC10
	[BlackList] // 0x0000000189852780-0x00000001898527C0
	// [XID] // 0x0000000189852780-0x00000001898527C0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018364DAD0-0x000000018364DB70
}


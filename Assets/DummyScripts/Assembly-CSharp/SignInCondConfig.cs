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
public class SignInCondConfig : IAutoAllocRecycle // TypeDefIndex: 16157
{
	// Fields
	protected SignInCondType _type; // 0x10
	protected SimpleSafeInt32[] _paramList; // 0x18

	// Properties
	public SignInCondType type { /* [XID] */ /* 0x00000001897E17C0-0x00000001897E17E0 */ get => default; /* [XID] */ /* 0x00000001897E9050-0x00000001897E9070 */ protected set {} } // 0x00000001836D2160-0x00000001836D2200 0x00000001836D1F70-0x00000001836D2020
	public SimpleSafeInt32[] paramList { /* [XID] */ /* 0x00000001897F0C40-0x00000001897F0C60 */ get => default; /* [XID] */ /* 0x00000001897F8420-0x00000001897F8440 */ protected set {} } // 0x00000001836D1760-0x00000001836D1800 0x00000001836D1B50-0x00000001836D1C00

	// Constructors
	public SignInCondConfig() {} // 0x00000001836D22A0-0x00000001836D2300

	// Methods
	// [XID] // 0x00000001897FFB50-0x00000001897FFB70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001836D1800-0x00000001836D1B50
	// [XID] // 0x00000001898071D0-0x00000001898071F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF32D1 */, bool useObjectPool = false /* Metadata: 0x00AF32D5 */) => default; // 0x00000001836D1C00-0x00000001836D1F70
	[BlackList] // 0x000000018980E7D0-0x000000018980E810
	// [XID] // 0x000000018980E7D0-0x000000018980E810
	public virtual void AutoAllocTypeFields() {} // 0x00000001836D1620-0x00000001836D16C0
	[BlackList] // 0x00000001898192D0-0x0000000189819310
	// [XID] // 0x00000001898192D0-0x0000000189819310
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836D16C0-0x00000001836D1760
	[BlackList] // 0x0000000189823490-0x00000001898234D0
	// [XID] // 0x0000000189823490-0x00000001898234D0
	public virtual void ReturnToObjectPool() {} // 0x00000001836D2200-0x00000001836D22A0
	[BlackList] // 0x000000018982DD00-0x000000018982DD40
	// [XID] // 0x000000018982DD00-0x000000018982DD40
	public virtual void OnPoolAllocated() {} // 0x00000001836D20C0-0x00000001836D2160
	[BlackList] // 0x00000001898383A0-0x00000001898383E0
	// [XID] // 0x00000001898383A0-0x00000001898383E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836D2020-0x00000001836D20C0
}


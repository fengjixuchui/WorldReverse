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
public class DragonSpineMissionFinishConfig : IAutoAllocRecycle // TypeDefIndex: 15067
{
	// Fields
	protected DragonSpineMissionFinishExecType _type; // 0x10
	protected string[] _param; // 0x18

	// Properties
	public DragonSpineMissionFinishExecType type { /* [XID] */ /* 0x000000018984A010-0x000000018984A030 */ get => default; /* [XID] */ /* 0x0000000189851610-0x0000000189851630 */ protected set {} } // 0x00000001827FEE90-0x00000001827FEF30 0x00000001827FECA0-0x00000001827FED50
	public string[] param { /* [XID] */ /* 0x0000000189858BC0-0x0000000189858BE0 */ get => default; /* [XID] */ /* 0x000000018985FD90-0x000000018985FDB0 */ protected set {} } // 0x00000001827FEFE0-0x00000001827FF080 0x00000001827FEF30-0x00000001827FEFE0

	// Constructors
	public DragonSpineMissionFinishConfig() {} // 0x00000001827FF120-0x00000001827FF180

	// Methods
	// [XID] // 0x0000000189867470-0x0000000189867490
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001827FE600-0x00000001827FE930
	// [XID] // 0x000000018986EC10-0x000000018986EC30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFFE3 */, bool useObjectPool = false /* Metadata: 0x00AEFFE7 */) => default; // 0x00000001827FE930-0x00000001827FECA0
	[BlackList] // 0x00000001898760E0-0x0000000189876120
	// [XID] // 0x00000001898760E0-0x0000000189876120
	public virtual void AutoAllocTypeFields() {} // 0x00000001827FE4C0-0x00000001827FE560
	[BlackList] // 0x00000001898807E0-0x0000000189880820
	// [XID] // 0x00000001898807E0-0x0000000189880820
	public virtual void AutoRecycleTypeFields() {} // 0x00000001827FE560-0x00000001827FE600
	[BlackList] // 0x000000018988AA90-0x000000018988AAD0
	// [XID] // 0x000000018988AA90-0x000000018988AAD0
	public virtual void ReturnToObjectPool() {} // 0x00000001827FF080-0x00000001827FF120
	[BlackList] // 0x0000000189894EF0-0x0000000189894F30
	// [XID] // 0x0000000189894EF0-0x0000000189894F30
	public virtual void OnPoolAllocated() {} // 0x00000001827FEDF0-0x00000001827FEE90
	[BlackList] // 0x000000018989F140-0x000000018989F180
	// [XID] // 0x000000018989F140-0x000000018989F180
	public virtual void OnBeforePoolRecycled() {} // 0x00000001827FED50-0x00000001827FEDF0
}


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
public class HitLevelTemplateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15329
{
	// Fields
	protected string _type; // 0x10
	protected string _hitLevel; // 0x18
	protected SimpleSafeFloat hitImpulseXRawNum; // 0x20
	protected SimpleSafeFloat hitImpulseYRawNum; // 0x24

	// Properties
	public string type { /* [XID] */ /* 0x0000000189BB15F0-0x0000000189BB1610 */ get => default; /* [XID] */ /* 0x0000000189BB8560-0x0000000189BB8580 */ protected set {} } // 0x00000001841B4870-0x00000001841B4910 0x00000001841B4680-0x00000001841B4730
	public string hitLevel { /* [XID] */ /* 0x0000000189BBFEF0-0x0000000189BBFF10 */ get => default; /* [XID] */ /* 0x0000000189BC7900-0x0000000189BC7920 */ protected set {} } // 0x00000001841B45E0-0x00000001841B4680 0x00000001841B37B0-0x00000001841B3860
	public float hitImpulseX { /* [XID] */ /* 0x0000000189676D50-0x0000000189676D70 */ get => default; /* [XID] */ /* 0x0000000189BD6840-0x0000000189BD6860 */ protected set {} } // 0x00000001841B3F60-0x00000001841B4040 0x00000001841B36D0-0x00000001841B37B0
	public float hitImpulseY { /* [XID] */ /* 0x0000000189BDE560-0x0000000189BDE580 */ get => default; /* [XID] */ /* 0x00000001895EB070-0x00000001895EB090 */ protected set {} } // 0x00000001841B3860-0x00000001841B3940 0x00000001841B4500-0x00000001841B45E0

	// Constructors
	public HitLevelTemplateExcelConfig() {} // 0x00000001841B49B0-0x00000001841B4A10

	// Methods
	// [IDTag] // 0x00000001895F24D0-0x00000001895F2510
	// [XID] // 0x00000001895F24D0-0x00000001895F2510
	public virtual bool ParseFromLine(string line) => default; // 0x00000001841B3940-0x00000001841B3C60
	// [IDTag] // 0x00000001895FCC90-0x00000001895FCCD0
	// [XID] // 0x00000001895FCC90-0x00000001895FCCD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001841B3C60-0x00000001841B3F60
	// [XID] // 0x0000000189607440-0x0000000189607460
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07B8 */, bool useObjectPool = false /* Metadata: 0x00AF07BC */) => default; // 0x00000001841B4040-0x00000001841B4500
	[BlackList] // 0x000000018960EE80-0x000000018960EEC0
	// [XID] // 0x000000018960EE80-0x000000018960EEC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001841B3540-0x00000001841B35E0
	[BlackList] // 0x0000000189619740-0x0000000189619780
	// [XID] // 0x0000000189619740-0x0000000189619780
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841B35E0-0x00000001841B36D0
	[BlackList] // 0x0000000189623B00-0x0000000189623B40
	// [XID] // 0x0000000189623B00-0x0000000189623B40
	public virtual void ReturnToObjectPool() {} // 0x00000001841B4910-0x00000001841B49B0
	[BlackList] // 0x000000018962E3B0-0x000000018962E3F0
	// [XID] // 0x000000018962E3B0-0x000000018962E3F0
	public virtual void OnPoolAllocated() {} // 0x00000001841B47D0-0x00000001841B4870
	[BlackList] // 0x0000000189638F50-0x0000000189638F90
	// [XID] // 0x0000000189638F50-0x0000000189638F90
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841B4730-0x00000001841B47D0
}


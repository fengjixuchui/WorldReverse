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
public class DungeonElementChallengeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15513
{
	// Fields
	protected SimpleSafeUInt32 dungeonIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _trialAvatarId; // 0x18
	protected SimpleSafeUInt32 tutorialIdRawNum; // 0x20

	// Properties
	public uint dungeonId { /* [XID] */ /* 0x0000000189A08EB0-0x0000000189A08ED0 */ get => default; /* [XID] */ /* 0x0000000189A103F0-0x0000000189A10410 */ protected set {} } // 0x00000001843809E0-0x0000000184380AB0 0x0000000184380E20-0x0000000184380F00
	public SimpleSafeUInt32[] trialAvatarId { /* [XID] */ /* 0x0000000189A179B0-0x0000000189A179D0 */ get => default; /* [XID] */ /* 0x0000000189A1F0D0-0x0000000189A1F0F0 */ protected set {} } // 0x0000000184380AB0-0x0000000184380B50 0x0000000184380C30-0x0000000184380CE0
	public uint tutorialId { /* [XID] */ /* 0x0000000189A266C0-0x0000000189A266E0 */ get => default; /* [XID] */ /* 0x0000000189A2D9F0-0x0000000189A2DA10 */ protected set {} } // 0x0000000184380500-0x00000001843805D0 0x0000000184380B50-0x0000000184380C30

	// Constructors
	public DungeonElementChallengeExcelConfig() {} // 0x0000000184380FA0-0x0000000184381000

	// Methods
	// [IDTag] // 0x0000000189A355D0-0x0000000189A35610
	// [XID] // 0x0000000189A355D0-0x0000000189A35610
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184380040-0x0000000184380500
	// [IDTag] // 0x0000000189A3FC80-0x0000000189A3FCC0
	// [XID] // 0x0000000189A3FC80-0x0000000189A3FCC0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018437FBC0-0x0000000184380040
	// [XID] // 0x0000000189A4A180-0x0000000189A4A1A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1CBB */, bool useObjectPool = false /* Metadata: 0x00AF1CBF */) => default; // 0x00000001843805D0-0x00000001843809E0
	[BlackList] // 0x0000000189A51B30-0x0000000189A51B70
	// [XID] // 0x0000000189A51B30-0x0000000189A51B70
	public virtual void AutoAllocTypeFields() {} // 0x000000018437FA30-0x000000018437FAD0
	[BlackList] // 0x0000000189A5C560-0x0000000189A5C5A0
	// [XID] // 0x0000000189A5C560-0x0000000189A5C5A0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018437FAD0-0x000000018437FBC0
	[BlackList] // 0x0000000189A66CA0-0x0000000189A66CE0
	// [XID] // 0x0000000189A66CA0-0x0000000189A66CE0
	public virtual void ReturnToObjectPool() {} // 0x0000000184380F00-0x0000000184380FA0
	[BlackList] // 0x0000000189A712A0-0x0000000189A712E0
	// [XID] // 0x0000000189A712A0-0x0000000189A712E0
	public virtual void OnPoolAllocated() {} // 0x0000000184380D80-0x0000000184380E20
	[BlackList] // 0x0000000189A7BE00-0x0000000189A7BE40
	// [XID] // 0x0000000189A7BE00-0x0000000189A7BE40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184380CE0-0x0000000184380D80
}


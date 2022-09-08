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
public class AIProfilingKnowledge : IAutoAllocRecycle // TypeDefIndex: 19969
{
	// Fields
	public ConfigAIProfilingSetting config; // 0x10
	public int moveCullingLevel; // 0x18

	// Constructors
	public AIProfilingKnowledge() {} // 0x000000018315DAD0-0x000000018315DB30

	// Methods
	[BlackList] // 0x00000001895FF610-0x00000001895FF650
	// [XID] // 0x00000001895FF610-0x00000001895FF650
	public virtual void AutoAllocTypeFields() {} // 0x000000018315D5B0-0x000000018315D650
	[BlackList] // 0x000000018960A070-0x000000018960A0B0
	// [XID] // 0x000000018960A070-0x000000018960A0B0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018315D650-0x000000018315D6F0
	[BlackList] // 0x0000000189614450-0x0000000189614490
	// [XID] // 0x0000000189614450-0x0000000189614490
	public virtual void ReturnToObjectPool() {} // 0x000000018315DA30-0x000000018315DAD0
	[BlackList] // 0x000000018961EF80-0x000000018961EFC0
	// [XID] // 0x000000018961EF80-0x000000018961EFC0
	public virtual void OnPoolAllocated() {} // 0x000000018315D990-0x000000018315DA30
	[BlackList] // 0x0000000189629490-0x00000001896294D0
	// [XID] // 0x0000000189629490-0x00000001896294D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018315D8F0-0x000000018315D990
	// [XID] // 0x0000000189B70A60-0x0000000189B70A80
	public void InitProfiling(ConfigAIProfilingSetting profilingSetting) {} // 0x000000018315D820-0x000000018315D8F0
	// [XID] // 0x0000000189A04D80-0x0000000189A04DA0
	public bool IsInStaticPose(int poseID) => default; // 0x000000018315D6F0-0x000000018315D820
}


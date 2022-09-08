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
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class QuestGuide : IAutoAllocRecycle // TypeDefIndex: 14896
{
	// Fields
	protected QuestGuideType _type; // 0x10
	protected QuestGuideAuto _autoGuide; // 0x14
	protected string[] _param; // 0x18
	protected SimpleSafeUInt32 guideSceneRawNum; // 0x20
	protected QuestGuideStyle _guideStyle; // 0x24
	protected QuestGuideLayer _guideLayer; // 0x28

	// Properties
	public QuestGuideType type { /* [XID] */ /* 0x0000000189A6A150-0x0000000189A6A170 */ get => default; /* [XID] */ /* 0x0000000189A71460-0x0000000189A71480 */ set {} } // 0x00000001856A0590-0x00000001856A0630 0x00000001856A0220-0x00000001856A02D0
	public QuestGuideAuto autoGuide { /* [XID] */ /* 0x0000000189A79020-0x0000000189A79040 */ get => default; /* [XID] */ /* 0x0000000189A804C0-0x0000000189A804E0 */ set {} } // 0x000000018569F240-0x000000018569F2E0 0x000000018569F980-0x000000018569FA30
	public string[] param { /* [XID] */ /* 0x0000000189A881E0-0x0000000189A88200 */ get => default; /* [XID] */ /* 0x0000000189A8FAD0-0x0000000189A8FAF0 */ set {} } // 0x00000001856A06E0-0x00000001856A0780 0x00000001856A0630-0x00000001856A06E0
	public uint guideScene { /* [XID] */ /* 0x0000000189A97100-0x0000000189A97120 */ get => default; /* [XID] */ /* 0x0000000189A9E4B0-0x0000000189A9E4D0 */ set {} } // 0x000000018569F170-0x000000018569F240 0x00000001856A02D0-0x00000001856A03B0
	public QuestGuideStyle guideStyle { /* [XID] */ /* 0x0000000189AA5DE0-0x0000000189AA5E00 */ get => default; /* [XID] */ /* 0x0000000189AAD4E0-0x0000000189AAD500 */ set {} } // 0x00000001856A03B0-0x00000001856A0450 0x00000001856A0170-0x00000001856A0220
	public QuestGuideLayer guideLayer { /* [XID] */ /* 0x0000000189AB4DD0-0x0000000189AB4DF0 */ get => default; /* [XID] */ /* 0x0000000189ABCA60-0x0000000189ABCA80 */ set {} } // 0x000000018569F8E0-0x000000018569F980 0x000000018569F830-0x000000018569F8E0

	// Constructors
	public QuestGuide() {} // 0x00000001856A0820-0x00000001856A0880

	// Methods
	// [XID] // 0x0000000189A621F0-0x0000000189A62210
	public QuestGuideEx ToEx() => default; // 0x00000001856A0020-0x00000001856A0170
	// [XID] // 0x0000000189AC43C0-0x0000000189AC43E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018569F2E0-0x000000018569F830
	// [XID] // 0x0000000189ACB930-0x0000000189ACB950
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF93B */, bool useObjectPool = false /* Metadata: 0x00AEF93F */) => default; // 0x000000018569FA30-0x00000001856A0020
	[BlackList] // 0x0000000189AD33E0-0x0000000189AD3420
	// [XID] // 0x0000000189AD33E0-0x0000000189AD3420
	public virtual void AutoAllocTypeFields() {} // 0x000000018569EFF0-0x000000018569F090
	[BlackList] // 0x0000000189ADE0E0-0x0000000189ADE120
	// [XID] // 0x0000000189ADE0E0-0x0000000189ADE120
	public virtual void AutoRecycleTypeFields() {} // 0x000000018569F090-0x000000018569F170
	[BlackList] // 0x0000000189AE86D0-0x0000000189AE8710
	// [XID] // 0x0000000189AE86D0-0x0000000189AE8710
	public virtual void ReturnToObjectPool() {} // 0x00000001856A0780-0x00000001856A0820
	[BlackList] // 0x0000000189AF3470-0x0000000189AF34B0
	// [XID] // 0x0000000189AF3470-0x0000000189AF34B0
	public virtual void OnPoolAllocated() {} // 0x00000001856A04F0-0x00000001856A0590
	[BlackList] // 0x0000000189AFD8D0-0x0000000189AFD910
	// [XID] // 0x0000000189AFD8D0-0x0000000189AFD910
	public virtual void OnBeforePoolRecycled() {} // 0x00000001856A0450-0x00000001856A04F0
}


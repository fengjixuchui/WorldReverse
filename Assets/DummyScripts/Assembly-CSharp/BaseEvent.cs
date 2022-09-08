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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public abstract class BaseEvent : IAutoAllocRecycle, IDispatchableEvent // TypeDefIndex: 20024
{
	// Fields
	public EventID eventID; // 0x10
	public uint targetID; // 0x14
	public bool canBeHandledImmediately; // 0x18
	public bool canBeHandledByLogic; // 0x19
	public bool canBeHandledByVisual; // 0x1A
	public bool canBeHandledByLogicResolved; // 0x1B
	public bool canBeHandledByDispatcher; // 0x1C
	public bool canBeHandledOnlyByListeners; // 0x1D
	public bool canBeHandledIfDie; // 0x1E
	public bool fromEventCache; // 0x1F
	public bool warnIfEntityMiss; // 0x20
	public EventRemoteState remoteState; // 0x24
	public ForwardType forwardType; // 0x28
	public uint fromPeerID; // 0x2C

	// Constructors
	protected BaseEvent() {} // 0x0000000181F946A0-0x0000000181F94710

	// Methods
	[BlackList] // 0x00000001898816A0-0x00000001898816E0
	// [XID] // 0x00000001898816A0-0x00000001898816E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181F93BB0-0x0000000181F93C50
	[BlackList] // 0x000000018988BAC0-0x000000018988BB00
	// [XID] // 0x000000018988BAC0-0x000000018988BB00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181F93C50-0x0000000181F93D10
	[BlackList] // 0x0000000189895D00-0x0000000189895D40
	// [XID] // 0x0000000189895D00-0x0000000189895D40
	public virtual void ReturnToObjectPool() {} // 0x0000000181F94600-0x0000000181F946A0
	// [XID] // 0x000000018963C340-0x000000018963C360
	public virtual void Init(uint targetID) {} // 0x0000000181F93FD0-0x0000000181F94080
	// [XID] // 0x00000001898A7970-0x00000001898A7990
	public bool IsPredict() => default; // 0x0000000181F93D10-0x0000000181F93E00
	// [XID] // 0x00000001898AF450-0x00000001898AF470
	public bool IsLocal() => default; // 0x0000000181F93E00-0x0000000181F93EC0
	// [XID] // 0x0000000189961580-0x00000001899615A0
	public bool IsReconcile() => default; // 0x0000000181F94250-0x0000000181F94340
	// [XID] // 0x00000001898BE0C0-0x00000001898BE0E0
	public bool IsRemote() => default; // 0x0000000181F94520-0x0000000181F94600
	// [XID] // 0x00000001898C5930-0x00000001898C5950
	public virtual void CopyFrom(BaseEvent evt) {} // 0x0000000181F93EC0-0x0000000181F93FD0
	[BlackList] // 0x00000001898CD0A0-0x00000001898CD0E0
	// [XID] // 0x00000001898CD0A0-0x00000001898CD0E0
	public virtual void OnPoolAllocated() {} // 0x0000000181F94480-0x0000000181F94520
	[BlackList] // 0x00000001898D7B40-0x00000001898D7B80
	// [XID] // 0x00000001898D7B40-0x00000001898D7B80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181F943E0-0x0000000181F94480
	// [XID] // 0x00000001898E2800-0x00000001898E2820
	protected string GetDebugName(uint entityRuntimeID) => default; // 0x0000000181F94130-0x0000000181F94250
	// [XID] // 0x0000000189B30210-0x0000000189B30230
	public virtual void PreHandle() {} // 0x0000000181F94340-0x0000000181F943E0
	// [XID] // 0x00000001897FE830-0x00000001897FE850
	public virtual void Clear() {} // 0x0000000181F94080-0x0000000181F94130
}


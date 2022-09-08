/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ComputeThreadTaskBase : IThreadTask // TypeDefIndex: 21338
{
	// Fields
	protected bool _alive; // 0x10
	protected EThreadTaskPriority _priority; // 0x14

	// Properties
	public bool Alive { /* [XID] */ /* 0x0000000189B931B0-0x0000000189B931D0 */ get; } // 0x0000000182C78070-0x0000000182C78120 
	public EThreadTaskPriority priority { /* [XID] */ /* 0x0000000189B9A700-0x0000000189B9A720 */ get; /* [XID] */ /* 0x0000000189BA1EF0-0x0000000189BA1F10 */ set; } // 0x0000000182C78310-0x0000000182C783B0 0x0000000182C78120-0x0000000182C781D0

	// Constructors
	protected ComputeThreadTaskBase() {} // 0x0000000182C783B0-0x0000000182C78410

	// Methods
	public static T CreateTask<T>(EThreadTaskPriority inPriority)
		where T : ComputeThreadTaskBase => default;
	// [XID] // 0x0000000189BA92E0-0x0000000189BA9300
	public virtual void Init() {} // 0x0000000182C781D0-0x0000000182C78270
	// [XID] // 0x0000000189BB0A70-0x0000000189BB0A90
	public virtual void PreApplyCollectPendingChangeFromUnityThread() {} // 0x0000000182C77E90-0x0000000182C77F30
	// [XID] // 0x0000000189BB7D80-0x0000000189BB7DA0
	public virtual void CollectPendingChangeFromUnityThread() {} // 0x0000000182C77FD0-0x0000000182C78070
	public abstract void Tick(float dt, float updateTime);
	// [XID] // 0x0000000189BBF450-0x0000000189BBF470
	public virtual void TickBuffer(int front) {} // 0x0000000182C77D40-0x0000000182C77DF0
	// [XID] // 0x0000000189BC7010-0x0000000189BC7030
	public virtual void ApplyCalculateResultInUnityThread() {} // 0x0000000182C77DF0-0x0000000182C77E90
	// [XID] // 0x0000000189BCED40-0x0000000189BCED60
	public virtual void OnDestoriedUnityThread() {} // 0x0000000182C78270-0x0000000182C78310
	// [XID] // 0x0000000189BD60A0-0x0000000189BD60C0
	public void Destroy() {} // 0x0000000182C77F30-0x0000000182C77FD0
}


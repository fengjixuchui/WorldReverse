/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BrainModuleBase // TypeDefIndex: 20411
{
	// Fields
	protected AIKnowledge _aiKnowledge; // 0x10
	protected AILODManager.BrainModuleType? _lodModuleType; // 0x18
	protected Switchable _requiredData; // 0x20
	protected float _nextTick; // 0x28

	// Constructors
	protected BrainModuleBase() {} // Dummy constructor
	public BrainModuleBase(AIKnowledge knowledge, AILODManager.BrainModuleType? lodModuleType = default, Switchable requiredData = null) {} // 0x000000018156FC70-0x000000018156FD30

	// Methods
	// [XID] // 0x0000000189A58900-0x0000000189A58920
	private bool IsTickValid() => default; // 0x000000018156FA30-0x000000018156FB00
	// [XID] // 0x0000000189627010-0x0000000189627030
	protected virtual void UpdateMainThreadInternal(float deltaTime) {} // 0x000000018156F7B0-0x000000018156F860
	// [XID] // 0x0000000189BB2FA0-0x0000000189BB2FC0
	public void UpdateMainThread(float deltaTime) {} // 0x000000018156F860-0x000000018156F970
	// [XID] // 0x0000000189A6F3E0-0x0000000189A6F400
	protected virtual void UpdateComputeThreadInternal(float deltaTime) {} // 0x000000018156F650-0x000000018156F700
	// [XID] // 0x0000000189791740-0x0000000189791760
	public void UpdateComputeThread(float deltaTime) {} // 0x000000018156F540-0x000000018156F650
	// [XID] // 0x0000000189A7E5E0-0x0000000189A7E600
	public void UpdateNextInterval() {} // 0x000000018156FB00-0x000000018156FC70
	// [XID] // 0x00000001898F0F40-0x00000001898F0F60
	public void Clear(BaseEntity.ClearReason reason) {} // 0x000000018156F970-0x000000018156FA30
	// [XID] // 0x0000000189A8D790-0x0000000189A8D7B0
	protected virtual void ClearInternal(BaseEntity.ClearReason reason) {} // 0x000000018156F700-0x000000018156F7B0
}


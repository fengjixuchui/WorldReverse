/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FollowMoveTask : LocoBaseTask // TypeDefIndex: 20484
{
	// Fields
	private BaseEntity _anchor; // 0x68
	private bool _useMeleeSlot; // 0x70
	private float _stopDistance; // 0x74
	private float _targetAngle; // 0x78

	// Constructors
	public FollowMoveTask() {} // 0x000000018295F550-0x000000018295F5D0

	// Methods
	// [XID] // 0x0000000189720B30-0x0000000189720B50
	public override void Deallocate() {} // 0x000000018295EEB0-0x000000018295EF50
	// [XID] // 0x0000000189728190-0x00000001897281B0
	public void Init(AIKnowledge knowledge, AILocomotionHandler.ParamFollowMove param) {} // 0x000000018295F3D0-0x000000018295F550
	// [XID] // 0x000000018972F870-0x000000018972F890
	public override void UpdateLoco(AILocomotionHandler handler, AITransform currentTransform, ref LocoTaskState state, float deltaTime) {} // 0x000000018295EF50-0x000000018295F3D0
}


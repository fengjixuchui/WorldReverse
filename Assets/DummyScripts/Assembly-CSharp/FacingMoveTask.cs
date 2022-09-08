/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FacingMoveTask : LocoBaseTask // TypeDefIndex: 20485
{
	// Fields
	private FacingMoveTaskState _innerState; // 0x68
	private BaseEntity _anchor; // 0x70
	private VCMoveData.MotionDirection _movingDirection; // 0x78
	private float _duration; // 0x7C
	private float _finishTick; // 0x80

	// Nested types
	private enum FacingMoveTaskState // TypeDefIndex: 20486
	{
		Start = 0,
		Moving = 1
	}

	// Constructors
	public FacingMoveTask() {} // 0x0000000182E935E0-0x0000000182E93660

	// Methods
	// [XID] // 0x00000001897372A0-0x00000001897372C0
	public override void Deallocate() {} // 0x0000000182E93180-0x0000000182E93220
	// [XID] // 0x000000018973EDA0-0x000000018973EDC0
	public void Init(AIKnowledge knowledge, AILocomotionHandler.ParamFacingMove param) {} // 0x0000000182E934E0-0x0000000182E935E0
	// [XID] // 0x0000000189746020-0x0000000189746040
	public override void UpdateLoco(AILocomotionHandler handler, AITransform currentTransform, ref LocoTaskState state, float deltaTime) {} // 0x0000000182E93220-0x0000000182E934E0
}


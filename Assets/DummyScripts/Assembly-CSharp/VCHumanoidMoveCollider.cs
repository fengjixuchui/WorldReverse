/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCHumanoidMoveCollider : VCMoveCollider // TypeDefIndex: 32183
{
	// Fields
	private Collider _airDummyMoveCol; // 0x38
	private Collider _airDummyPushCol; // 0x40
	private Collider _airDummyPushColExtra; // 0x48

	// Properties
	public override Collider airDummyMoveCol { /* [XID] */ /* 0x0000000189A7B120-0x0000000189A7B140 */ get => default; } // 0x0000000182643160-0x0000000182643200 

	// Constructors
	public VCHumanoidMoveCollider() {} // Dummy constructor
	public VCHumanoidMoveCollider(Collider[] moveCols, Collider[] pushCols, Collider[] pushColsExtra, Collider airDummyMoveCol, Collider airDummyPushCol, Collider airDummyPushColExtra, float height, float radius, VCHumanoidMove moveComponent) {} // 0x0000000182643570-0x00000001826438C0

	// Methods
	// [XID] // 0x0000000189A82770-0x0000000189A82790
	public override void SetPassThroughCharacter(bool passThrough) {} // 0x0000000182643280-0x0000000182643370
	// [XID] // 0x0000000189A8A210-0x0000000189A8A230
	public override void SetAirColEnable(bool enabled) {} // 0x0000000182643460-0x0000000182643570
}


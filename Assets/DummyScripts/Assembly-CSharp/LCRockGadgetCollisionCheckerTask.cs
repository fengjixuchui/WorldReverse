/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCRockGadgetCollisionCheckerTask : ThreadGroupTask<LCRockGadgetCollisionCheckerData> // TypeDefIndex: 26605
{
	// Fields
	private const string _taskName = "LCRockGadgetCollisionCheckerTask"; // Metadata: 0x00B0C664
	private LevelMoveScenePropPlugin _scenePropPlugin; // 0x38
	private int _layerMask; // 0x40
	private Collider[] overlapColliders; // 0x48
	private Vector3 _curCenterPosition; // 0x50
	private Dictionary<Transform, VCScenePropAccurateMoveBase> _moveScenePropColliderDict; // 0x60

	// Properties
	public override string taskName { /* [XID] */ /* 0x0000000189668100-0x0000000189668120 */ get => default; } // 0x0000000181A925D0-0x0000000181A92680 

	// Constructors
	public LCRockGadgetCollisionCheckerTask() {} // 0x0000000181A92540-0x0000000181A925D0

	// Methods
	// [XID] // 0x000000018966FC00-0x000000018966FC20
	protected override void PreCollect() {} // 0x0000000181A92400-0x0000000181A924A0
	// [XID] // 0x0000000189677460-0x0000000189677480
	protected override void CollectInternal(int index) {} // 0x0000000181A8FE40-0x0000000181A90150
	// [XID] // 0x000000018967E9F0-0x000000018967EA10
	protected override void PreExecute() {} // 0x0000000181A924A0-0x0000000181A92540
	// [XID] // 0x0000000189686280-0x00000001896862A0
	protected override void ExecuteInternal(int index) {} // 0x0000000181A90230-0x0000000181A903F0
	// [XID] // 0x000000018968E130-0x000000018968E150
	private void CheckOverlapIsSummon(ref LCRockGadgetCollisionCheckerData data) {} // 0x0000000181A906A0-0x0000000181A914E0
	// [XID] // 0x0000000189695A00-0x0000000189695A20
	private void CheckOverlapTick(ref LCRockGadgetCollisionCheckerData data) {} // 0x0000000181A915B0-0x0000000181A923A0
	// [XID] // 0x000000018969D0F0-0x000000018969D110
	protected override void FlushInternal(int index) {} // 0x0000000181A903F0-0x0000000181A906A0
}


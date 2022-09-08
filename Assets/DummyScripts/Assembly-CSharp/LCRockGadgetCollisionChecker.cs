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

public sealed class LCRockGadgetCollisionChecker : LCBase // TypeDefIndex: 11759
{
	// Fields
	private LCRockGadgetCollisionCheckerData _data; // 0x130
	private const int CONNECT_TRIGGER_MAX_NUMBER = 5; // Metadata: 0x00AEA79F
	private bool _firstTick; // 0x1D8
	private int _tickCount; // 0x1DC
	private int _layerMask; // 0x1E0
	private int _detectLayerMask; // 0x1E4
	private int _layerMaskWithCharacterCombine; // 0x1E8
	private LevelMoveScenePropPlugin _scenePropPlugin; // 0x1F0
	private VCScenePropAccurateMoveBase _move; // 0x1F8
	private bool _canBeCreatedOnPlatform; // 0x200
	private Collider[] overlapColliders; // 0x208
	private Vector3 _curCenterPosition; // 0x210

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B6EE70-0x0000000189B6EE90 */ get => default; } // 0x00000001819E7540-0x00000001819E75E0 

	// Constructors
	public LCRockGadgetCollisionChecker() {} // 0x00000001819E7340-0x00000001819E7540

	// Methods
	// [XID] // 0x0000000189B12BB0-0x0000000189B12BD0
	private void PrepareData() {} // 0x00000001819E1CE0-0x00000001819E3890
	// [XID] // 0x0000000189B7DC00-0x0000000189B7DC20
	public override void Init() {} // 0x00000001819E3A80-0x00000001819E3B20
	// [XID] // 0x0000000189AED510-0x0000000189AED530
	public void DoSuicide() {} // 0x00000001819E5C80-0x00000001819E5F20
	// [XID] // 0x00000001896169B0-0x00000001896169D0
	public override void Destroy() {} // 0x00000001819E3910-0x00000001819E3A80
	// [XID] // 0x00000001896422D0-0x00000001896422F0
	protected override void LateTick(float inDeltaTime) {} // 0x00000001819E5F80-0x00000001819E61D0
	// [XID] // 0x0000000189B9B5D0-0x0000000189B9B5F0
	private void CheckOverlapIsSummon(ref LCRockGadgetCollisionCheckerData data) {} // 0x00000001819E4B80-0x00000001819E5C80
	// [XID] // 0x0000000189BA2D30-0x0000000189BA2D50
	private void DetectTick(ref LCRockGadgetCollisionCheckerData data) {} // 0x00000001819E3B20-0x00000001819E4B80
	// [XID] // 0x0000000189BAA160-0x0000000189BAA180
	private void CheckOverlapTick(ref LCRockGadgetCollisionCheckerData data) {} // 0x00000001819E6240-0x00000001819E7340
}


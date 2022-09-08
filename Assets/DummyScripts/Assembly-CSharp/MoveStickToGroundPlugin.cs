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

public sealed class MoveStickToGroundPlugin : BaseComponentPlugin // TypeDefIndex: 12138
{
	// Fields
	private float _maxStepHeight; // 0x58
	private float _maxSlopeAngle; // 0x5C
	private float _heightToGround; // 0x60
	private float _flexibleRange; // 0x64
	private int _layerMask; // 0x68
	private UnstickAction _unstickWhenDownSlide; // 0x6C
	private UnstickAction _unstickWhenUpSlide; // 0x70
	private BaseEntity _entity; // 0x78
	private const float MinDetectDistance = 1f; // Metadata: 0x00AEB54C
	private const float SquareRootOfTwo = 1.42f; // Metadata: 0x00AEB550
	private const int DownHitMaxCount = 3; // Metadata: 0x00AEB554
	private bool _forwardHitted; // 0x81
	private int _downHitCount; // 0x84
	private float _downHitDistanceSum; // 0x88
	private bool _continousUpWhenDownHits; // 0x8C
	private bool _continousDownWhenDownHits; // 0x8D
	private RaycastHit _forwardHit; // 0x90
	private RaycastHit[] _downHit; // 0xD0
	private RaycastHit _forwardDownHit; // 0xD8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899C1C40-0x00000001899C1C60 */ get => default; } // 0x0000000182324B90-0x0000000182324C30 
	public bool destroyWhenUnSticking { /* [XID] */ /* 0x00000001899C9040-0x00000001899C9080 */ get; /* [XID] */ /* 0x00000001899D39E0-0x00000001899D3A20 */ private set; } // 0x0000000182324990-0x00000001823249F0 0x0000000182324770-0x00000001823247E0

	// Constructors
	public MoveStickToGroundPlugin() {} // Dummy constructor
	public MoveStickToGroundPlugin(ConfigMoveStickToGround config, BaseEntity entity) {} // 0x00000001823249F0-0x0000000182324B90

	// Methods
	// [XID] // 0x00000001899DDE30-0x00000001899DDE50
	public override void Init() {} // 0x0000000182324630-0x0000000182324710
	// [XID] // 0x00000001899E5BF0-0x00000001899E5C10
	public override void Destroy() {} // 0x00000001823231F0-0x00000001823232D0
	// [XID] // 0x00000001899ECC80-0x00000001899ECCA0
	public void GetStickedVelocity(ref Vector3 velocity, out bool returnToLast) {
		returnToLast = default;
	} // 0x00000001823232D0-0x0000000182324630
	// [XID] // 0x00000001899F49C0-0x00000001899F49E0
	private bool RaycastHitByRelativePos(Vector3 relativePos, Vector3 dir, float dist, out RaycastHit hit) {
		hit = default;
		return default;
	} // 0x0000000182323080-0x00000001823231F0
	// [XID] // 0x00000001899FC000-0x00000001899FC020
	private void DoUnstickAction(UnstickAction unstickAction, ref Vector3 velocity, out bool returnToLast) {
		returnToLast = default;
	} // 0x00000001823247E0-0x0000000182324920
}


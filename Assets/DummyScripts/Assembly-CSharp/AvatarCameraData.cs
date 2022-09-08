/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AvatarCameraData // TypeDefIndex: 32138
{
	// Fields
	public const double AVATAR_HEIGHT_RATIO_TO_LOOKATPOINT = 0.7129999995231628; // Metadata: 0x00B140F8
	public const double AVATAR_HEIGHT_RATIO_TO_LOOKATPOINT_CLIMB_TO_MOVE = 1; // Metadata: 0x00B14100
	public const double AVATAR_HEIGHT_RATIO_TO_LOOKATPOINT_MOVE_TO_CLIMB = 0.8700000047683716; // Metadata: 0x00B14108
	public double _avatar_height_ratio_to_lookatpoint_move_to_climb; // 0x10
	public Vector3d LookAtPointPosition; // 0x18
	public Vector3d LookAtPointPositionBeforeAdjust; // 0x30
	public Vector3d FilterLookAtPosition; // 0x48
	public Vector3d TransformLookAtPosition; // 0x60
	public Vector3d SmoothTransformUp; // 0x78
	public Vector3d BlendFaceDirection; // 0x90
	public Vector3d SmoothFaceDirection; // 0xA8
	public BaseEntity entity; // 0xC0
	public BaseEntity heroEntity; // 0xC8
	public VCBaseMove baseMove; // 0xD0
	public VCBaseSetDitherValue vCBaseSetDitherValue; // 0xD8
	public VCBaseModel baseModel; // 0xE0
	public VCCharacterCombat charactorCombat; // 0xE8
	public LCBaseCombat lcBaseCombat; // 0xF0
	public Transform cameraLookTrans; // 0xF8
	public AnimatorController animController; // 0x100
	public Animator anim; // 0x108
	public double AvatarHeight; // 0x110
	public double CameraLookHeight; // 0x118
	public Vector3d CameraLookDeltaXZ; // 0x120

	// Properties
	public Vector3d MoveLookAtPosition { /* [XID] */ /* 0x000000018999C5B0-0x000000018999C5D0 */ get => default; } // 0x00000001845490E0-0x0000000184549300 
	public Vector3d ClimbLookAtPosition { /* [XID] */ /* 0x00000001899A4040-0x00000001899A4060 */ get => default; } // 0x0000000184548EC0-0x00000001845490E0 
	public Vector3d FaceDirection { /* [XID] */ /* 0x00000001899ABA10-0x00000001899ABA30 */ get => default; } // 0x0000000184548D70-0x0000000184548EC0 
	public Vector3d UpDirection { /* [XID] */ /* 0x00000001899B33D0-0x00000001899B33F0 */ get => default; } // 0x0000000184549300-0x0000000184549450 

	// Constructors
	public AvatarCameraData() {} // 0x0000000184549450-0x00000001845496B0
}


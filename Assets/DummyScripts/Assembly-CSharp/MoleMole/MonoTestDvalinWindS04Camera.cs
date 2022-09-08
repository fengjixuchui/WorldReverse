/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTestDvalinWindS04Camera : MonoBehaviour // TypeDefIndex: 27796
	{
		// Fields
		private DvalinCameraState _camState; // 0x18
		private DvalinCameraLerpState _camLerpState; // 0x1C
		public float _CAM_LERP_SPEED; // 0x20
		private MonsterEntity _dvalin; // 0x28
		private Transform _camNode; // 0x30
		private Transform _lookAtPivot; // 0x38
		private Transform _lookAtRocker; // 0x40
		private Transform _lookAtNode; // 0x48
		private Transform _lookAtOffset; // 0x50
		public float _CAM_LERP_POS_SPEED; // 0x58
		public float _CAM_LRTP_ANGLE_SPEED; // 0x5C
		public Vector3 _CAM_OFFSET_HIGH; // 0x60
		public Vector3 _CAM_OFFSET_NORMAL; // 0x6C
		public float _CAM_OFFSET_ANGLE_HIGH; // 0x78
		public float _CAM_OFFSET_ANGLE_NORMAL; // 0x7C
		private Transform _weakCamPivot; // 0x80
		private Transform _weakCamPivot2; // 0x88
		private Transform _weakCamRocker; // 0x90
		private Transform _weakCamNode; // 0x98
		private WeakCamState _weakCamState; // 0xA0
		private Vector3 _weakCamTargetPivot; // 0xA4
		public float _WEAKCAM_ENTER_DIS; // 0xB0
		public float _WEAKCAM_PIVOT_SPEED; // 0xB4
		public Vector3 _WEAKCAM_PIVOT_LEFT; // 0xB8
		public Vector3 _WEAKCAM_PIVOT_RIGHT; // 0xC4
		public Vector3 _WEAKCAM_PIVOT_NECK; // 0xD0
		public Vector3 _WEAKCAM_PIVOT_FAR; // 0xDC
		public float _WEAKCAM_ROCKER_LEN; // 0xE8
		public float _WEAKCAM_MID_OFFSET; // 0xEC
		public float _WEAKCAM_NECK_HEIGHT; // 0xF0
		private Transform _cameraLook; // 0xF8
		private Transform _poseRoot; // 0x100
		private Vector3 _lastPoseRoot; // 0x108
		private Transform _seal; // 0x118
		public float _CAM_PIVOT_ANGLE; // 0x120
		public float _POSEROOT_SPEED; // 0x124
	
		// Nested types
		private enum DvalinCameraState // TypeDefIndex: 27797
		{
			None = 0,
			NormalCamera = 1,
			WeakCamera = 2
		}
	
		private enum DvalinCameraLerpState // TypeDefIndex: 27798
		{
			Normal = 0,
			Lerping = 1
		}
	
		private enum WeakCamState // TypeDefIndex: 27799
		{
			BS = 0,
			LeftSide = 1,
			RightSide = 2,
			OnNeck = 3
		}
	
		// Constructors
		public MonoTestDvalinWindS04Camera() {} // 0x0000000183B68930-0x0000000183B68BA0
	
		// Methods
		// [XID] // 0x0000000189AAFA90-0x0000000189AAFAB0
		private void Start() {} // 0x0000000183B66960-0x0000000183B66BF0
		// [XID] // 0x0000000189AB7250-0x0000000189AB7270
		private void UpdateCameraNode() {} // 0x0000000183B66300-0x0000000183B66960
		// [XID] // 0x0000000189ABEC60-0x0000000189ABEC80
		private void Update() {} // 0x0000000183B66BF0-0x0000000183B68930
	}
}

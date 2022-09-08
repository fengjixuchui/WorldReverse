/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class EyeKey : MonoBehaviour, IEmoTickable // TypeDefIndex: 8488
	{
		// Fields
		public EyeKeyController currentController; // 0x18
		private const string LEFT_EYE_BONE_NAME = "+EyeBone L A01"; // Metadata: 0x00ADF948
		private const string RIGHT_EYE_BONE_NAME = "+EyeBone R A01"; // Metadata: 0x00ADF95A
		private const string LEFT_EYE_BALL_NAME = "+EyeBone L A02"; // Metadata: 0x00ADF96C
		private const string RIGHT_EYE_BALL_NAME = "+EyeBone R A02"; // Metadata: 0x00ADF97E
		public const string TEETH_UP_NAME = "+ToothBone U A01"; // Metadata: 0x00ADF990
		public const string TEETH_DOWN_NAME = "+ToothBone D A01"; // Metadata: 0x00ADF9A4
		public Transform leftEyeBone; // 0x20
		public Transform rightEyeBone; // 0x28
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Transform leftEyeBallBone; // 0x30
		public Transform rightEyeBallBone; // 0x38
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Vector3 leftEyeRot; // 0x40
		public Vector3 rightEyeRot; // 0x4C
		private bool _isTickable; // 0x59
		private Vector3 _leftEyeRotTarget; // 0x5C
		private Vector3 _rightEyeRotTarget; // 0x68
		private float _rotTargetCurrtime; // 0x74
		private float _rotDuration; // 0x78
		public bool ControlledByInteractionManager; // 0x7C
		public bool enableApply; // 0x7D
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Vector3 leftEyeBallScale; // 0x80
		public Vector3 rightEyeBallScale; // 0x8C
		private Vector3 _leftEyeBallScaleTarget; // 0x98
		private Vector3 _rightEyeBallScaleTarget; // 0xA4
		private float _scaleTargetCurrtime; // 0xB0
		private float _scaleDuration; // 0xB4
		private Vector3 leftEyeScale; // 0xB8
		private Vector3 rightEyeScale; // 0xC4
		private Vector3 leftEyeBallRot; // 0xD0
		private Vector3 rightEyeBallRot; // 0xDC
		public Transform teethUpBone; // 0xE8
		public Transform teethDownBone; // 0xF0
		public Vector3 teethUpRot; // 0xF8
		public Vector3 teethDownRot; // 0x104
		public Vector3 teethUpScale; // 0x110
		public Vector3 teethDownScale; // 0x11C
		public Vector3 teethDownPos; // 0x128
		private int _leftEyeBoneHash; // 0x134
		private int _rightEyeBoneHash; // 0x138
		private int _leftEyeBallBoneHash; // 0x13C
		private int _rightEyeBallBoneHash; // 0x140
		private int _teethUpHash; // 0x144
		private int _teethDownHash; // 0x148
		private Vector3 _originLeftEyeRot; // 0x14C
		private Vector3 _originRightEyeRot; // 0x158
		private Vector3 _originLeftEyeScale; // 0x164
		private Vector3 _originRightEyeScale; // 0x170
		private Vector3 _originLeftEyeBallRot; // 0x17C
		private Vector3 _originRightEyeBallRot; // 0x188
		private Vector3 _originLeftEyeBallScale; // 0x194
		private Vector3 _originRightEyeBallScale; // 0x1A0
		private Vector3 _originUpTeethRot; // 0x1AC
		private Vector3 _originDownTeethRot; // 0x1B8
		private Vector3 _originUpTeethScale; // 0x1C4
		private Vector3 _originDownTeethScale; // 0x1D0
		private Vector3 _originDownTeethPos; // 0x1DC
	
		// Properties
		public bool previewMode { get; set; } // 0x0000000187254DF0-0x0000000187254E50 0x0000000187254EF0-0x0000000187254F50
		public bool tickable { /* [XID] */ /* 0x0000000189903D10-0x0000000189903D30 */ get => default; /* [XID] */ /* 0x00000001899A3CE0-0x00000001899A3D00 */ set {} } // 0x0000000187254E50-0x0000000187254EF0 0x0000000187254F50-0x0000000187255000
	
		// Nested types
		public enum EyeKeyController // TypeDefIndex: 8489
		{
			EmoSync = 0,
			LookAtEyeCtrl = 1
		}
	
		// Constructors
		public EyeKey() {} // 0x0000000187254AC0-0x0000000187254DF0
	
		// Methods
		// [XID] // 0x00000001899AB910-0x00000001899AB930
		public void SetTargetRot(float duration, Vector3 leftRot, Vector3 rightRot) {} // 0x0000000187254250-0x00000001872543E0
		// [XID] // 0x0000000189B0A890-0x0000000189B0A8B0
		private void TickTargetRot() {} // 0x0000000187254630-0x0000000187254850
		// [XID] // 0x0000000189AF4290-0x0000000189AF42B0
		public void SetTargetScale(float duration, Vector3 leftScale, Vector3 rightScale) {} // 0x00000001872543E0-0x0000000187254590
		// [XID] // 0x00000001899C1F50-0x00000001899C1F70
		private void TickTargetScale() {} // 0x0000000187254850-0x0000000187254AC0
		// [XID] // 0x0000000189A1A2F0-0x0000000189A1A310
		private void Start() {} // 0x0000000187254590-0x0000000187254630
		// [XID] // 0x00000001899D0E90-0x00000001899D0EB0
		private void Init() {} // 0x0000000187253C10-0x0000000187253DD0
		// [IDTag] // 0x00000001899D8310-0x00000001899D8350
		// [XID] // 0x00000001899D8310-0x00000001899D8350
		private void CheckInit(Transform bone, ref int hash, ref Vector3 originRot, ref Vector3 originScale) {} // 0x00000001872535D0-0x0000000187253770
		// [IDTag] // 0x00000001899E29B0-0x00000001899E29F0
		// [XID] // 0x00000001899E29B0-0x00000001899E29F0
		private void CheckInit(Transform bone, ref int hash, ref Vector3 originPos, ref Vector3 originRot, ref Vector3 originScale) {} // 0x0000000187253770-0x0000000187253950
		// [XID] // 0x00000001899ECFC0-0x00000001899ECFE0
		private void LateUpdate() {} // 0x0000000187253DD0-0x0000000187254070
		// [XID] // 0x00000001899BC7B0-0x00000001899BC7D0
		public void Reset() {} // 0x0000000187254070-0x0000000187254250
		// [XID] // 0x00000001899FC2C0-0x00000001899FC2E0
		private void CheckReset(ref Transform bone, int hash, Vector3 rot) {} // 0x0000000187253950-0x0000000187253AC0
		// [IDTag] // 0x0000000189A037F0-0x0000000189A03830
		// [XID] // 0x0000000189A037F0-0x0000000189A03830
		private void Apply(Transform bone, Vector3 originPos, Vector3 originRot, Vector3 originScale, ref Vector3 deltaPos, ref Vector3 deltaRot, ref Vector3 deltaScale) {} // 0x0000000187253310-0x00000001872535D0
		// [IDTag] // 0x0000000189A0DEA0-0x0000000189A0DEE0
		// [XID] // 0x0000000189A0DEA0-0x0000000189A0DEE0
		private void Apply(Transform bone, ref Vector3 originRot, ref Vector3 originScale, ref Vector3 deltaRot, ref Vector3 deltaScale) {} // 0x0000000187253110-0x0000000187253310
		// [XID] // 0x00000001899F6CB0-0x00000001899F6CD0
		public void Clear() {} // 0x0000000187253AC0-0x0000000187253C10
	}
}

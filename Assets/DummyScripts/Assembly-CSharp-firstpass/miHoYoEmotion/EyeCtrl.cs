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
	public class EyeCtrl : EmoMgrUser // TypeDefIndex: 8487
	{
		// Fields
		public bool autoBlinkingEnabled; // 0x38
		public BaseShape defaultBlinkShape; // 0x40
		public float minimumBlinkGap; // 0x48
		public float maximumBlinkGap; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _leftEyeLookAtBone; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rightEyeLookAtBone; // 0x58
		public Vector2 eyeRotationRangeX; // 0x60
		public Vector2 eyeRotationRangeY; // 0x68
		public bool targetEnabled; // 0x70
		public Transform viewTarget; // 0x78
		public Transform headTransform; // 0x80
		private float blinkTimer; // 0x88
		private bool blinking; // 0x8C
		private Vector3 leftEuler; // 0x90
		private Vector3 rightEuler; // 0x9C
		private Transform target; // 0xA8
		public Vector3 targetPosition; // 0xB0
		public Action blinkCb; // 0xC0
		private bool _isLookatWaiting; // 0xC8
		private float _lookatWaitingTime; // 0xCC
		public EyeKey eyeKey; // 0xD0
	
		// Properties
		public Transform LeftEyeLookAtBone { /* [XID] */ /* 0x000000018975DD30-0x000000018975DD50 */ get => default; /* [XID] */ /* 0x0000000189933A00-0x0000000189933A20 */ set {} } // 0x00000001873317C0-0x0000000187331860 0x0000000187331900-0x00000001873319F0
		public Transform RightEyeLookAtBone { /* [XID] */ /* 0x00000001898D7210-0x00000001898D7230 */ get => default; /* [XID] */ /* 0x00000001898DEFB0-0x00000001898DEFD0 */ set {} } // 0x0000000187331860-0x0000000187331900 0x00000001873319F0-0x0000000187331AE0
	
		// Constructors
		public EyeCtrl() {} // 0x0000000187331660-0x00000001873317C0
	
		// Methods
		// [XID] // 0x00000001898E6580-0x00000001898E65A0
		protected override void Start() {} // 0x00000001873307B0-0x0000000187330A90
		// [XID] // 0x00000001898EDF30-0x00000001898EDF50
		public void InitEyeLookAtBone(Transform left, Transform right) {} // 0x00000001873302C0-0x00000001873304F0
		// [XID] // 0x0000000189897640-0x0000000189897660
		protected override void OnEnable() {} // 0x0000000187330710-0x00000001873307B0
		// [XID] // 0x000000018989EC00-0x000000018989EC20
		private void OnDestroy() {} // 0x0000000187330600-0x0000000187330710
		// [XID] // 0x00000001899048C0-0x00000001899048E0
		private void LateUpdate() {} // 0x00000001873304F0-0x0000000187330600
		// [XID] // 0x000000018990C130-0x000000018990C150
		private void UpdateBlink() {} // 0x0000000187330C30-0x0000000187330D50
		// [XID] // 0x0000000189890120-0x0000000189890140
		public void ToggleBlink(bool toggle) {} // 0x0000000187330A90-0x0000000187330B70
		// [XID] // 0x000000018991B490-0x000000018991B4B0
		public void Blink() {} // 0x000000018732FE90-0x0000000187330000
		// [XID] // 0x00000001899229B0-0x00000001899229D0
		private void BlinkFinish() {} // 0x000000018732FDC0-0x000000018732FE90
		// [XID] // 0x000000018992A220-0x000000018992A240
		public void ForceUpdateLookTarget(float duration) {} // 0x00000001873301F0-0x00000001873302C0
		// [XID] // 0x0000000189931810-0x0000000189931830
		public void ClearLookat() {} // 0x0000000187330140-0x00000001873301F0
		// [XID] // 0x000000018992C400-0x000000018992C420
		private void UpdateLookTarget(float duration = 0f /* Metadata: 0x00ADF940 */) {} // 0x00000001873310A0-0x0000000187331660
		// [XID] // 0x00000001899406F0-0x0000000189940710
		private void UpdateEyeTarget(Vector3 targetPosition, Transform eyeBone, Vector3 originEuler, out Vector3 deltaEulerRot) {
			deltaEulerRot = default;
		} // 0x0000000187330D50-0x00000001873310A0
		// [IDTag] // 0x0000000189947EB0-0x0000000189947EF0
		// [XID] // 0x0000000189947EB0-0x0000000189947EF0
		private void ApplyEyeTarget(Transform leftEyeBone, Transform rightEyeBone, Vector3 leftOriginEuler, Vector3 rightOriginEuler, Vector3 leftDeltaRot, Vector3 rightDeltaRot) {} // 0x000000018732FBA0-0x000000018732FDC0
		// [IDTag] // 0x0000000189952700-0x0000000189952740
		// [XID] // 0x0000000189952700-0x0000000189952740
		private void ApplyEyeTarget(EyeKey eyeKey, Vector3 leftDeltaRot, Vector3 rightDeltaRot, float duration = 0f /* Metadata: 0x00ADF944 */) {} // 0x000000018732F9E0-0x000000018732FBA0
		// [XID] // 0x000000018995CC40-0x000000018995CC60
		private void CheckMinAngle(ref Vector3 euler) {} // 0x0000000187330000-0x0000000187330140
	}
}

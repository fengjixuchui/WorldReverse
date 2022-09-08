/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelClockPage : MonoUIProxy // TypeDefIndex: 29738
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoActionBtn _hourHand; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _hourHandRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _closeButton; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _areaCloseButton; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _nowTimeHand; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _nowTimeText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _toTimeText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _fill; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _minChangeTime; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tips; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _timeImg; // 0x90
		private static int _patternRotator; // 0x00
		private MonoElementSwitch _elementSwitch; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _easyTouchUICompatibily; // 0xA0
		private float _toWorldTime; // 0xA4
		private float _fillValue; // 0xA8
		private Vector2 _lastTouchPos; // 0xAC
		private bool _hasGetlastTouchPos; // 0xB4
		public bool lastShowOkBtn; // 0xB5
		public bool canUseClock; // 0xB6
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float transDuration; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float transLerpRatio; // 0xBC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float transDistance; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public StoryCameraLerpPattern lerpPattern; // 0xC4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float moveVelocity; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float moveLerpRatio; // 0xCC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float minHeight; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float minAdditionHeight; // 0xD4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public uint pointerMoveAudioID; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public uint cameraMoveAudioID; // 0xDC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public uint backPointerMoveAudioID; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public uint pointerDegreeToSound; // 0xE4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public uint backPointerDegreeToSound; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _clockAnimSpeedMax; // 0xEC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _clockAnimSpeedNormal; // 0xF0
		private float _lastPointerAngle; // 0xF4
		private float _lastBackPointerAngle; // 0xF8
	
		// Properties
		public MonoUIContainer closeButton { /* [XID] */ /* 0x000000018977CE50-0x000000018977CE70 */ get => default; } // 0x0000000184707310-0x00000001847073B0 
		public Button areaCloseButton { /* [XID] */ /* 0x0000000189784890-0x00000001897848B0 */ get => default; } // 0x0000000184707270-0x0000000184707310 
		public MonoUIContainer okButton { /* [XID] */ /* 0x000000018978BE80-0x000000018978BEA0 */ get => default; } // 0x0000000184707460-0x00000001847075F0 
		public float toWorldTime { /* [XID] */ /* 0x00000001897932B0-0x00000001897932D0 */ get => default; } // 0x00000001847076A0-0x0000000184707750 
		public float minChangeTime { /* [XID] */ /* 0x000000018979B540-0x000000018979B560 */ get => default; } // 0x00000001847073B0-0x0000000184707460 
		public UnityEngine.UI.Text tips { /* [XID] */ /* 0x00000001897A29E0-0x00000001897A2A00 */ get => default; } // 0x00000001847075F0-0x00000001847076A0 
	
		// Constructors
		public MonoInLevelClockPage() {} // 0x0000000184707110-0x0000000184707270
		static MonoInLevelClockPage() {} // 0x00000001847070A0-0x0000000184707110
	
		// Methods
		// [XID] // 0x00000001897A9F80-0x00000001897A9FA0
		public virtual void OnEnable() {} // 0x0000000184705B80-0x0000000184705C50
		// [XID] // 0x00000001897B1990-0x00000001897B19B0
		public virtual void OnDisable() {} // 0x0000000184705AE0-0x0000000184705B80
		// [XID] // 0x00000001897B9390-0x00000001897B93B0
		protected override void OnDestroy() {} // 0x0000000184705A30-0x0000000184705AE0
		// [XID] // 0x00000001897C1420-0x00000001897C1440
		public void SubscribeEvent() {} // 0x0000000184706E30-0x0000000184706F80
		// [XID] // 0x00000001897C8EA0-0x00000001897C8EC0
		public void UnsubscribeEvent() {} // 0x0000000184706F80-0x00000001847070A0
		// [XID] // 0x00000001897D0500-0x00000001897D0520
		private void On_TouchDown(Gesture gesture) {} // 0x0000000184704AE0-0x0000000184704CE0
		// [XID] // 0x00000001897D8220-0x00000001897D8240
		private void OnHourHandTouchUp() {} // 0x0000000184705280-0x0000000184705330
		// [XID] // 0x00000001897DF2E0-0x00000001897DF300
		public void SetTargetTime(Vector2 hourHandDir) {} // 0x0000000184706710-0x0000000184706D70
		// [XID] // 0x00000001897E6BA0-0x00000001897E6BC0
		private void On_TouchDownWithoutCheck(Gesture gesture) {} // 0x0000000184705C50-0x0000000184706160
		// [XID] // 0x00000001897EE710-0x00000001897EE730
		private void SetHourHandAngle(float angle) {} // 0x00000001847057A0-0x00000001847058C0
		// [XID] // 0x00000001897F5F80-0x00000001897F5FA0
		public void SetToTimeText(string toTime) {} // 0x0000000184706D70-0x0000000184706E30
		// [XID] // 0x00000001897FD6A0-0x00000001897FD6C0
		public void InitNowTimeHandAngle(float angle, float nowTime) {} // 0x0000000184705600-0x00000001847057A0
		// [XID] // 0x0000000189804CE0-0x0000000189804D00
		public void SetNowTimeHandAngle(float angle, float nowTime) {} // 0x0000000184706280-0x0000000184706650
		// [XID] // 0x000000018980C290-0x000000018980C2B0
		public void SetNowTimeText(string nowTime) {} // 0x0000000184706650-0x0000000184706710
		// [XID] // 0x0000000189813A40-0x0000000189813A60
		public void SetNowTimeFillMaterial(float angle) {} // 0x0000000184706160-0x0000000184706280
		// [XID] // 0x000000018981B570-0x000000018981B590
		private float CalcFillValue() => default; // 0x0000000184704CE0-0x0000000184704FD0
		// [XID] // 0x0000000189822BE0-0x0000000189822C00
		private void CheckPointerAudio(float angle) {} // 0x00000001847058C0-0x0000000184705A30
		// [XID] // 0x000000018982A510-0x000000018982A530
		private void CheckBackPointerAudio(float angle) {} // 0x0000000184704FD0-0x0000000184705150
		// [XID] // 0x0000000189831860-0x0000000189831880
		private void CheckOkBtnActive() {} // 0x00000001847048E0-0x0000000184704AE0
		// [XID] // 0x0000000189838F40-0x0000000189838F60
		private void SetNowTimeImg(float angle) {} // 0x0000000184705330-0x0000000184705600
		// [XID] // 0x00000001898405C0-0x00000001898405E0
		private void SetTimeImgsAlpha() {} // 0x0000000184704700-0x00000001847048E0
		// [XID] // 0x0000000189847B70-0x0000000189847B90
		private void SetClockAnimSpeed(float speed) {} // 0x00000001847051B0-0x0000000184705280
	}
}

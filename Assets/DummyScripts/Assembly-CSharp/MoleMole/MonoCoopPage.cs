/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCoopPage : MonoUIProxy // TypeDefIndex: 30219
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _coopPage; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSliderWithButton _slider; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _confidenceSlider; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _chapterTitle; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _locationBtn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _locationBtn_PS4; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _rewardBtn; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _albumBtn; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _pointName; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _ongoingTip; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _startPointOngoingTip; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpConfidenceValue; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpChapterStart; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _startPointName; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _startPointDes; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _chapterIcon; // 0xB8
		// [Range] // 0x0000000189B51A30-0x0000000189B51A70
		[SerializeField] // 0x0000000189B51A30-0x0000000189B51A70
		private float _zoomHidePointValue; // 0xC0
		// [Header] // 0x0000000189B5C380-0x0000000189B5C3D0
		[SerializeField] // 0x0000000189B5C380-0x0000000189B5C3D0
		private RectTransform _cursor; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _joypadMoveCameraSensitivity; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _joypadMoveCursorSensitivity; // 0xD4
		// [MinMax] // 0x00000001898EFAE0-0x00000001898EFB20
		[SerializeField] // 0x00000001898EFAE0-0x00000001898EFB20
		private Vector2 _xFocusRange; // 0xD8
		// [MinMax] // 0x0000000189B7FA50-0x0000000189B7FA90
		[SerializeField] // 0x0000000189B7FA50-0x0000000189B7FA90
		private Vector2 _yFocusRange; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _judgeAngle; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _camereFocusMoveTime; // 0xEC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _joypadCursorAnimator; // 0xF0
		// [Header] // 0x0000000189B9FFC0-0x0000000189BA0020
		// [Range] // 0x0000000189B9FFC0-0x0000000189BA0020
		[SerializeField] // 0x0000000189B9FFC0-0x0000000189BA0020
		private float _minReferenceMaxSwipeSpeed; // 0xF8
		// [Range] // 0x0000000189BAEB70-0x0000000189BAEBB0
		[SerializeField] // 0x0000000189BAEB70-0x0000000189BAEBB0
		private float _maxReferenceMaxSwipeSpeed; // 0xFC
		// [Range] // 0x0000000189BB9050-0x0000000189BB9090
		[SerializeField] // 0x0000000189BB9050-0x0000000189BB9090
		private float _minTouchSwipeRatioMultiplier; // 0x100
		// [Range] // 0x0000000189BB9050-0x0000000189BB9090
		[SerializeField] // 0x0000000189BB9050-0x0000000189BB9090
		private float _maxTouchSwipeRatioMultiplier; // 0x104
	
		// Properties
		public MonoSliderWithButton sliderWithButton { /* [XID] */ /* 0x0000000189BCE8A0-0x0000000189BCE8C0 */ get => default; } // 0x0000000183F34F80-0x0000000183F35020 
		public SmoothMask confidenceSlider { /* [XID] */ /* 0x0000000189BD5B60-0x0000000189BD5B80 */ get => default; } // 0x0000000183F344C0-0x0000000183F34560 
		public UnityEngine.UI.Text chapterTitle { /* [XID] */ /* 0x0000000189BDD810-0x0000000189BDD830 */ get => default; } // 0x0000000183F34420-0x0000000183F344C0 
		public Button locationBtn { /* [XID] */ /* 0x00000001895EA370-0x00000001895EA390 */ get => default; } // 0x0000000183F34A20-0x0000000183F34AC0 
		public GameObject locationBtn_PS4 { /* [XID] */ /* 0x00000001895F17F0-0x00000001895F1810 */ get => default; } // 0x0000000183F34980-0x0000000183F34A20 
		public MonoUIContainer rewardBtn { /* [XID] */ /* 0x00000001895F9290-0x00000001895F92B0 */ get => default; } // 0x0000000183F34EE0-0x0000000183F34F80 
		public MonoUIContainer albumBtn { /* [XID] */ /* 0x00000001896008C0-0x00000001896008E0 */ get => default; } // 0x0000000183F33CE0-0x0000000183F33D80 
		public UnityEngine.UI.Text pointName { /* [XID] */ /* 0x00000001896081E0-0x0000000189608200 */ get => default; } // 0x0000000183F34E30-0x0000000183F34EE0 
		public GameObject ongoingTip { /* [XID] */ /* 0x000000018960FB80-0x000000018960FBA0 */ get => default; } // 0x0000000183F34D80-0x0000000183F34E30 
		public GameObject startPointOngoingTip { /* [XID] */ /* 0x0000000189616E20-0x0000000189616E40 */ get => default; } // 0x0000000183F35180-0x0000000183F35230 
		public GameObject grpConfidenceValue { /* [XID] */ /* 0x000000018961E980-0x000000018961E9A0 */ get => default; } // 0x0000000183F346C0-0x0000000183F34770 
		public GameObject grpChapterStart { /* [XID] */ /* 0x0000000189625DA0-0x0000000189625DC0 */ get => default; } // 0x0000000183F34610-0x0000000183F346C0 
		public Image chapterIcon { /* [XID] */ /* 0x000000018962D6C0-0x000000018962D6E0 */ get => default; } // 0x0000000183F34370-0x0000000183F34420 
		public UnityEngine.UI.Text startPointName { /* [XID] */ /* 0x0000000189635280-0x00000001896352A0 */ get => default; } // 0x0000000183F350D0-0x0000000183F35180 
		public UnityEngine.UI.Text startPointDes { /* [XID] */ /* 0x000000018963C920-0x000000018963C940 */ get => default; } // 0x0000000183F35020-0x0000000183F350D0 
		public float zoomHidePointValue { /* [XID] */ /* 0x0000000189644020-0x0000000189644040 */ get => default; } // 0x0000000183F35390-0x0000000183F35440 
		public float minReferenceMaxSwipeSpeed { /* [XID] */ /* 0x000000018964B7D0-0x000000018964B7F0 */ get => default; } // 0x0000000183F34C20-0x0000000183F34CD0 
		public float maxReferenceMaxSwipeSpeed { /* [XID] */ /* 0x0000000189652F40-0x0000000189652F60 */ get => default; } // 0x0000000183F34AC0-0x0000000183F34B70 
		public float minTouchSwipeRatioMultiplier { /* [XID] */ /* 0x000000018965A620-0x000000018965A640 */ get => default; } // 0x0000000183F34CD0-0x0000000183F34D80 
		public float maxTouchSwipeRatioMultiplier { /* [XID] */ /* 0x0000000189661C70-0x0000000189661C90 */ get => default; } // 0x0000000183F34B70-0x0000000183F34C20 
		public MonoUIContainer btnReturn { /* [XID] */ /* 0x0000000189669830-0x0000000189669850 */ get => default; } // 0x0000000183F33FC0-0x0000000183F34080 
		public MonoUIContainer btnStartPoint { /* [XID] */ /* 0x0000000189671320-0x0000000189671340 */ get => default; } // 0x0000000183F34080-0x0000000183F34140 
		public MonoUIContainer btnPointInfo { /* [XID] */ /* 0x0000000189678BE0-0x0000000189678C00 */ get => default; } // 0x0000000183F33F00-0x0000000183F33FC0 
		public MonoUIContainer btnCheckCG { /* [XID] */ /* 0x0000000189680270-0x0000000189680290 */ get => default; } // 0x0000000183F33E40-0x0000000183F33F00 
		public MonoUIContainer btnBeginChapter { /* [XID] */ /* 0x0000000189687E30-0x0000000189687E50 */ get => default; } // 0x0000000183F33D80-0x0000000183F33E40 
		public MonoUIContainer btnZoomNear { /* [XID] */ /* 0x000000018968F890-0x000000018968F8B0 */ get => default; } // 0x0000000183F34200-0x0000000183F342C0 
		public MonoUIContainer btnZoomFar { /* [XID] */ /* 0x0000000189697270-0x0000000189697290 */ get => default; } // 0x0000000183F34140-0x0000000183F34200 
		public float joypadMoveCursorSensitiviy { /* [XID] */ /* 0x000000018969E800-0x000000018969E820 */ get => default; } // 0x0000000183F34820-0x0000000183F348D0 
		public float joypadMoveCameraSensitivity { /* [XID] */ /* 0x00000001896A57F0-0x00000001896A5810 */ get => default; } // 0x0000000183F34770-0x0000000183F34820 
		public RectTransform cursor { /* [XID] */ /* 0x00000001896AD010-0x00000001896AD030 */ get => default; } // 0x0000000183F34560-0x0000000183F34610 
		public Vector2 xFocusRange { /* [XID] */ /* 0x00000001896B4680-0x00000001896B46A0 */ get => default; } // 0x0000000183F35230-0x0000000183F352E0 
		public Vector2 yFocusRange { /* [XID] */ /* 0x00000001896BB8B0-0x00000001896BB8D0 */ get => default; } // 0x0000000183F352E0-0x0000000183F35390 
		public float judgeAngle { /* [XID] */ /* 0x00000001896C2D00-0x00000001896C2D20 */ get => default; } // 0x0000000183F348D0-0x0000000183F34980 
		public float camereFocusMoveTime { /* [XID] */ /* 0x00000001896CA220-0x00000001896CA240 */ get => default; } // 0x0000000183F342C0-0x0000000183F34370 
	
		// Constructors
		public MonoCoopPage() {} // 0x0000000183F33B50-0x0000000183F33CE0
	
		// Methods
		// [XID] // 0x00000001896D18F0-0x00000001896D1910
		public void EnableJoypadCursor(bool enable) {} // 0x0000000183F339B0-0x0000000183F33B50
	}
}

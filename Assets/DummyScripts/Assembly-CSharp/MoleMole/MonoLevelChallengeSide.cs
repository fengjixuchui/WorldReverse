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
	public class MonoLevelChallengeSide : MonoBehaviour // TypeDefIndex: 31242
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _hintProgress; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _hintSubProgress; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _descList; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _resetBtnSwitch; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _resetBtnOtherSwitch; // 0x40
		private AnimatorStateInfo? _animatorState; // 0x48
		private bool _completeTriggerValue; // 0x70
		private bool _startTriggerValue; // 0x71
		private bool _failTriggerValue; // 0x72
		private bool _canShowProgress; // 0x73
		private bool _hideProgress; // 0x74
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _extendTrans; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _mechanicusAnimator; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _currBuildingPoints; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _diffBuildingPoints; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _buildingPointsIcon; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _buildingNumTrans; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _buildingNum; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _buildingNumIcon; // 0xB0
	
		// Properties
		public string hintSubProgress { /* [XID] */ /* 0x0000000189AA0650-0x0000000189AA0670 */ set {} } // 0x0000000183F98CF0-0x0000000183F98DD0
		public string hintProgress { /* [XID] */ /* 0x0000000189AA7BF0-0x0000000189AA7C10 */ set {} } // 0x0000000183F98C20-0x0000000183F98CF0
		public MonoReusableList subChallengeList { /* [XID] */ /* 0x0000000189AB6ED0-0x0000000189AB6EF0 */ get => default; } // 0x0000000183F98B80-0x0000000183F98C20 
		public bool showHintSubProgress { /* [XID] */ /* 0x0000000189ABE920-0x0000000189ABE940 */ set {} } // 0x0000000183F98EB0-0x0000000183F98F80
		public MonoUIContainer resetBtnContainer { /* [XID] */ /* 0x0000000189AC64C0-0x0000000189AC64E0 */ get => default; } // 0x0000000183F98A00-0x0000000183F98AC0 
		public bool showResetBtn { /* [XID] */ /* 0x0000000189ACDBC0-0x0000000189ACDBE0 */ set {} } // 0x0000000183F99060-0x0000000183F99140
		public MonoUIContainer resetBtnOtherContainer { /* [XID] */ /* 0x0000000189ADD3B0-0x0000000189ADD3D0 */ get => default; } // 0x0000000183F98AC0-0x0000000183F98B80 
		public bool showResetBtnOther { /* [XID] */ /* 0x0000000189AE4B40-0x0000000189AE4B60 */ set {} } // 0x0000000183F98F80-0x0000000183F99060
		public MonoControlElement otherResetKeyElement { /* [XID] */ /* 0x0000000189AF3C30-0x0000000189AF3C50 */ get => default; } // 0x0000000183F98830-0x0000000183F98960 
		public MonoControlElement keyElement { /* [XID] */ /* 0x0000000189AFB320-0x0000000189AFB340 */ get => default; } // 0x0000000183F98650-0x0000000183F98780 
		public Animator panelAnimator { /* [XID] */ /* 0x0000000189B18C80-0x0000000189B18CA0 */ get => default; } // 0x0000000183F98960-0x0000000183F98A00 
		public bool showDescList { /* [XID] */ /* 0x0000000189B27950-0x0000000189B27970 */ set {} } // 0x0000000183F98DD0-0x0000000183F98EB0
		public RectTransform extendTrans { /* [XID] */ /* 0x0000000189B2EC30-0x0000000189B2EC50 */ get => default; } // 0x0000000183F985B0-0x0000000183F98650 
		public Animator mechanicusAnimator { /* [XID] */ /* 0x0000000189B364D0-0x0000000189B364F0 */ get => default; } // 0x0000000183F98780-0x0000000183F98830 
		public UnityEngine.UI.Text currBuildingPoints { /* [XID] */ /* 0x0000000189B3DCB0-0x0000000189B3DCD0 */ get => default; } // 0x0000000183F98450-0x0000000183F98500 
		public UnityEngine.UI.Text diffBuildingPoints { /* [XID] */ /* 0x0000000189B45A30-0x0000000189B45A50 */ get => default; } // 0x0000000183F98500-0x0000000183F985B0 
		public Image buildingPointsIcon { /* [XID] */ /* 0x0000000189B4CEB0-0x0000000189B4CED0 */ get => default; } // 0x0000000183F983A0-0x0000000183F98450 
		public Transform buildingNumTrans { /* [XID] */ /* 0x0000000189B545D0-0x0000000189B545F0 */ get => default; } // 0x0000000183F98240-0x0000000183F982F0 
		public UnityEngine.UI.Text buildingNum { /* [XID] */ /* 0x0000000189B5C1A0-0x0000000189B5C1C0 */ get => default; } // 0x0000000183F982F0-0x0000000183F983A0 
		public Image buildingNumIcon { /* [XID] */ /* 0x0000000189B637A0-0x0000000189B637C0 */ get => default; } // 0x0000000183F98190-0x0000000183F98240 
	
		// Constructors
		public MonoLevelChallengeSide() {} // 0x0000000183F980A0-0x0000000183F98190
	
		// Methods
		// [XID] // 0x0000000189A994F0-0x0000000189A99510
		private void OnEnable() {} // 0x0000000183F979E0-0x0000000183F97CD0
		// [XID] // 0x0000000189AAF680-0x0000000189AAF6A0
		public void TriggerProgressUpdate() {} // 0x0000000183F97FC0-0x0000000183F980A0
		// [XID] // 0x0000000189AD5930-0x0000000189AD5950
		public bool CanResetBtnClick() => default; // 0x0000000183F97660-0x0000000183F97730
		// [XID] // 0x0000000189AEC1D0-0x0000000189AEC1F0
		public bool CanResetBtnOtherClick() => default; // 0x0000000183F97730-0x0000000183F97800
		// [XID] // 0x0000000189B02A00-0x0000000189B02A20
		public void SavaAnimatorState() {} // 0x0000000183F97CD0-0x0000000183F97EF0
		// [XID] // 0x0000000189B0A230-0x0000000189B0A250
		public void HideProgress() {} // 0x0000000183F978F0-0x0000000183F979E0
		// [XID] // 0x0000000189B11950-0x0000000189B11970
		public void CancelHideProgress() {} // 0x0000000183F97800-0x0000000183F978F0
		// [XID] // 0x0000000189B20350-0x0000000189B20370
		public void SetValid(bool value) {} // 0x0000000183F97EF0-0x0000000183F97FC0
	}
}

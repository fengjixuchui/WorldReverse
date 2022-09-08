/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTargetIndicator : MonoBehaviour // TypeDefIndex: 31271
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private SimpleText _distanceText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _arrowTrans; // 0x20
		// [Header] // 0x0000000189907CF0-0x0000000189907D30
		[SerializeField] // 0x0000000189907CF0-0x0000000189907D30
		private Animator _animator; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _fadeOutDuration; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgIcon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _focusIcon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _countDownRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _smoothMark; // 0x50
		private LinkedListNode<MutableString> _msForTexts; // 0x58
		private int _lastDistance; // 0x60
		private uint _countDownTime; // 0x64
		private float _curLeftTime; // 0x68
		private bool _flash; // 0x6C
	
		// Properties
		public SimpleText distanceText { /* [XID] */ /* 0x00000001899394E0-0x0000000189939500 */ get => default; } // 0x00000001850145F0-0x0000000185014690 
		public Transform arrowTrans { /* [XID] */ /* 0x00000001899407D0-0x00000001899407F0 */ get => default; } // 0x00000001850144B0-0x0000000185014550 
		public Image bgIcon { /* [XID] */ /* 0x0000000189975080-0x00000001899750A0 */ get => default; } // 0x0000000185014550-0x00000001850145F0 
		public Image focusIcon { /* [XID] */ /* 0x000000018997C260-0x000000018997C280 */ get => default; } // 0x0000000185014690-0x0000000185014730 
	
		// Constructors
		public MonoTargetIndicator() {} // 0x0000000185014410-0x00000001850144B0
	
		// Methods
		// [XID] // 0x0000000189948070-0x0000000189948090
		public void ShowDistanceText(bool show) {} // 0x00000001850141B0-0x0000000185014290
		// [XID] // 0x000000018994F830-0x000000018994F850
		public void ShowArrowTrans(bool show) {} // 0x00000001850140D0-0x00000001850141B0
		// [XID] // 0x0000000189956DD0-0x0000000189956DF0
		public float FadeOut() => default; // 0x0000000185013830-0x0000000185013970
		// [XID] // 0x000000018995E920-0x000000018995E940
		public void SetDistanceText(int distance) {} // 0x0000000185013F90-0x00000001850140D0
		// [XID] // 0x0000000189966020-0x0000000189966040
		public void PlayEnableAnimation() {} // 0x0000000185013BE0-0x0000000185013CD0
		// [XID] // 0x000000018996D4C0-0x000000018996D4E0
		private void OnDestroy() {} // 0x0000000185013970-0x0000000185013A50
		// [XID] // 0x0000000189983F50-0x0000000189983F70
		public void OnEnable() {} // 0x0000000185013A50-0x0000000185013BE0
		// [XID] // 0x000000018998BB30-0x000000018998BB50
		public void SetCoolDownTime(uint targetId, uint countDownTime) {} // 0x0000000185013CD0-0x0000000185013F90
		// [XID] // 0x0000000189993690-0x00000001899936B0
		public void Update() {} // 0x0000000185014290-0x0000000185014410
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMultiClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler, IPointerClickHandler // TypeDefIndex: 30844
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float intervalSeconds; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MultiClickType _clickType; // 0x1C
		// [Header] // 0x0000000189BDD700-0x0000000189BDD740
		[SerializeField] // 0x0000000189BDD700-0x0000000189BDD740
		private bool _enableMultipleClick; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float multipleclickThresholdSeconds; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int multipleclickCount; // 0x28
		// [Header] // 0x00000001895FC020-0x00000001895FC060
		[SerializeField] // 0x00000001895FC020-0x00000001895FC060
		private float _startInterval; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _minInterval; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _accelerateSpeed; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _accelerateInterval; // 0x38
		private float _currInterval; // 0x3C
		private float _accelerateTimer; // 0x40
		private bool _isPressing; // 0x44
		private float _timer; // 0x48
		private Button _btn; // 0x50
		private Button.ButtonClickedEvent _onClick; // 0x58
		private UnityAction _onRelease; // 0x60
		private State _state; // 0x68
	
		// Properties
		public MultiClickType clickType { /* [XID] */ /* 0x000000018961E880-0x000000018961E8A0 */ set {} } // 0x0000000182F22C20-0x0000000182F22CD0
		public Button.ButtonClickedEvent onClick { /* [XID] */ /* 0x0000000189625CA0-0x0000000189625CC0 */ get => default; } // 0x0000000182F22AB0-0x0000000182F22B80 
		public UnityAction onClickCallback { /* [XID] */ /* 0x000000018962D5C0-0x000000018962D5E0 */ set {} } // 0x0000000182F22E30-0x0000000182F22F10
		public UnityAction onReleaseCallback { /* [XID] */ /* 0x0000000189635180-0x00000001896351A0 */ set {} } // 0x0000000182F22F10-0x0000000182F22FC0
		public State state { /* [XID] */ /* 0x000000018963C800-0x000000018963C820 */ get => default; } // 0x0000000182F22B80-0x0000000182F22C20 
		public bool enableMultipleClick { /* [XID] */ /* 0x0000000189661B70-0x0000000189661B90 */ set {} } // 0x0000000182F22CD0-0x0000000182F22D80
		public float thresholdSeconds { /* [XID] */ /* 0x0000000189680100-0x0000000189680120 */ set {} } // 0x0000000182F22FC0-0x0000000182F23070
		public float intervalTime { /* [XID] */ /* 0x0000000189687CF0-0x0000000189687D10 */ set {} } // 0x0000000182F22D80-0x0000000182F22E30
	
		// Nested types
		public enum MultiClickType // TypeDefIndex: 30845
		{
			Normal = 0,
			Accelerate = 1
		}
	
		public enum State // TypeDefIndex: 30846
		{
			NotPressed = 0,
			ShortPressing = 1,
			LongPressing = 2
		}
	
		// Constructors
		public MonoMultiClickButton() {} // 0x0000000182F229F0-0x0000000182F22AB0
	
		// Methods
		// [XID] // 0x0000000189643F20-0x0000000189643F40
		private void Awake() {} // 0x0000000182F220B0-0x0000000182F22170
		// [XID] // 0x000000018964B680-0x000000018964B6A0
		private void OnEnable() {} // 0x0000000182F22250-0x0000000182F222F0
		// [XID] // 0x0000000189652E20-0x0000000189652E40
		private void Update() {} // 0x0000000182F22760-0x0000000182F229F0
		// [XID] // 0x000000018965A520-0x000000018965A540
		private void InvokeClick() {} // 0x0000000182F22170-0x0000000182F22250
		// [XID] // 0x0000000189669710-0x0000000189669730
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000182F22410-0x0000000182F22530
		// [XID] // 0x0000000189671200-0x0000000189671220
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000182F22640-0x0000000182F22760
		// [XID] // 0x0000000189678AC0-0x0000000189678AE0
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000182F22530-0x0000000182F22640
		// [XID] // 0x000000018968F6F0-0x000000018968F710
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000182F222F0-0x0000000182F22410
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x0000000189A841F0-0x0000000189A84240
	public class MonoLongPressButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler // TypeDefIndex: 30820
	{
		// Fields
		public Action onLongPressBegin; // 0x18
		public Action onLongPressEnd; // 0x20
		public Action onLongPressClick; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _beginThresholdSeconds; // 0x30
		private float _beginThresholdSecondsTimer; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float intervalSeconds; // 0x38
		// [Header] // 0x0000000189A9EE00-0x0000000189A9EE50
		[SerializeField] // 0x0000000189A9EE00-0x0000000189A9EE50
		private bool _enableMultipleClick; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float multipleclickThresholdSeconds; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int multipleclickCount; // 0x44
		private bool _isPointDown; // 0x48
		private float _timer; // 0x4C
		private float _multipleclickTimer; // 0x50
		private Button _btn; // 0x58
		private bool _enableAutoClick; // 0x60
	
		// Properties
		public bool enableMultipleClick { /* [XID] */ /* 0x0000000189AD87C0-0x0000000189AD87E0 */ set {} } // 0x00000001842892A0-0x0000000184289350
		public float thresholdSeconds { /* [XID] */ /* 0x0000000189AFE0E0-0x0000000189AFE100 */ set {} } // 0x0000000184289400-0x00000001842894B0
		public float intervalTime { /* [XID] */ /* 0x0000000189B05970-0x0000000189B05990 */ set {} } // 0x0000000184289350-0x0000000184289400
	
		// Constructors
		public MonoLongPressButton() {} // 0x0000000184289200-0x00000001842892A0
	
		// Methods
		// [XID] // 0x0000000189ABA270-0x0000000189ABA290
		private void Awake() {} // 0x0000000184288A10-0x0000000184288AD0
		// [XID] // 0x0000000189AC1BA0-0x0000000189AC1BC0
		private void OnEnable() {} // 0x0000000184288C40-0x0000000184288CE0
		// [XID] // 0x0000000189AC9130-0x0000000189AC9150
		private void OnDestroy() {} // 0x0000000184288BA0-0x0000000184288C40
		// [XID] // 0x0000000189AD0B80-0x0000000189AD0BA0
		private void Update() {} // 0x0000000184289000-0x0000000184289200
		// [XID] // 0x0000000189AE03E0-0x0000000189AE0400
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000184288CE0-0x0000000184288DD0
		// [XID] // 0x0000000189AE7990-0x0000000189AE79B0
		private void LongPessedCheck() {} // 0x0000000184288AD0-0x0000000184288BA0
		// [XID] // 0x0000000189AEF690-0x0000000189AEF6B0
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000184288E90-0x0000000184288F50
		// [XID] // 0x0000000189AF6BB0-0x0000000189AF6BD0
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000184288DD0-0x0000000184288E90
		// [XID] // 0x0000000189B0D0C0-0x0000000189B0D0E0
		public void SetAutoClickEnable(bool active) {} // 0x0000000184288F50-0x0000000184289000
	}
}

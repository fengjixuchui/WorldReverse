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
	public class MonoChargeBar : MonoBehaviour // TypeDefIndex: 31187
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _iconCanvas; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _maxImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _addEffet; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _maxEffext; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _fill; // 0x40
		private bool _isActive; // 0x48
		private float _lastValue; // 0x4C
	
		// Properties
		public float fillValue { /* [XID] */ /* 0x0000000189A0E1E0-0x0000000189A0E200 */ set {} } // 0x0000000184B9C1F0-0x0000000184B9C2B0
	
		// Constructors
		public MonoChargeBar() {} // 0x0000000184B9C170-0x0000000184B9C1F0
	
		// Methods
		// [XID] // 0x0000000189A157A0-0x0000000189A157C0
		public void SetChargeBarValue(float value, bool isAdd) {} // 0x0000000184B9BE60-0x0000000184B9C170
		// [XID] // 0x0000000189A1CC80-0x0000000189A1CCA0
		private void FadeIn() {} // 0x0000000184B9BC10-0x0000000184B9BD60
		// [XID] // 0x0000000189A241E0-0x0000000189A24200
		private void FadeOut() {} // 0x0000000184B9B970-0x0000000184B9BAC0
		// [XID] // 0x0000000189A2B650-0x0000000189A2B670
		public void Hide() {} // 0x0000000184B9BAC0-0x0000000184B9BC10
		// [XID] // 0x0000000189A32CA0-0x0000000189A32CC0
		public void ResetChargeBar() {} // 0x0000000184B9BD60-0x0000000184B9BE60
	}
}

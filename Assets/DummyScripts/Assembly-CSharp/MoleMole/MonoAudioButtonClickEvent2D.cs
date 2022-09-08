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
	public class MonoAudioButtonClickEvent2D : MonoAudioEvent2D, IPointerClickHandler // TypeDefIndex: 31628
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Event[] _eventsWhenEnabled; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Event[] _eventsWhenDisabled; // 0x20
		private Button _button; // 0x28
		private bool _wasInteractableLastFrame; // 0x30
	
		// Constructors
		public MonoAudioButtonClickEvent2D() {} // 0x0000000184C9BEC0-0x0000000184C9BF20
	
		// Methods
		// [XID] // 0x00000001896DD590-0x00000001896DD5B0
		private void Awake() {} // 0x0000000184C9B9B0-0x0000000184C9BA60
		// [XID] // 0x00000001896E4C80-0x00000001896E4CA0
		private void OnEnable() {} // 0x0000000184C9BD00-0x0000000184C9BE00
		// [XID] // 0x00000001896EC1E0-0x00000001896EC200
		private void OnDisable() {} // 0x0000000184C9BC60-0x0000000184C9BD00
		// [XID] // 0x00000001896F3930-0x00000001896F3950
		private void LateUpdate() {} // 0x0000000184C9BA60-0x0000000184C9BB60
		// [XID] // 0x00000001896FB010-0x00000001896FB030
		protected virtual void OnPointerClick() {} // 0x0000000184C9BB60-0x0000000184C9BC60
		// [XID] // 0x0000000189702740-0x0000000189702760
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {} // 0x0000000184C9BE00-0x0000000184C9BEC0
	}
}

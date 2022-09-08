/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 9787
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x18
		private const int logLength = 10; // Metadata: 0x00AE62B2
		private List<string> log; // 0x20
	
		// Constructors
		public PlayerPointerEventHandlerExample() {} // 0x000000018655C050-0x000000018655C0E0
	
		// Methods
		// [XID] // 0x000000018973F6C0-0x000000018973F6E0
		private void Log(string o) {} // 0x0000000186559690-0x0000000186559790
		// [XID] // 0x000000018977AA60-0x000000018977AA80
		private void Update() {} // 0x000000018655BE00-0x000000018655C050
		// [XID] // 0x000000018971DAC0-0x000000018971DAE0
		public void OnPointerEnter(PointerEventData eventData) {} // 0x000000018655AE10-0x000000018655B1E0
		// [XID] // 0x00000001897F4380-0x00000001897F43A0
		public void OnPointerExit(PointerEventData eventData) {} // 0x000000018655B1E0-0x000000018655B5B0
		// [XID] // 0x0000000189895AA0-0x0000000189895AC0
		public void OnPointerUp(PointerEventData eventData) {} // 0x000000018655B5B0-0x000000018655BA30
		// [XID] // 0x0000000189878750-0x0000000189878770
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018655A990-0x000000018655AE10
		// [XID] // 0x000000018980A7D0-0x000000018980A7F0
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018655A510-0x000000018655A990
		// [XID] // 0x00000001896D06A0-0x00000001896D06C0
		public void OnScroll(PointerEventData eventData) {} // 0x000000018655BA30-0x000000018655BE00
		// [XID] // 0x0000000189819B10-0x0000000189819B30
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000186559790-0x0000000186559C10
		// [XID] // 0x00000001897301C0-0x00000001897301E0
		public void OnDrag(PointerEventData eventData) {} // 0x0000000186559C10-0x000000018655A090
		// [XID] // 0x00000001896B9830-0x00000001896B9850
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018655A090-0x000000018655A510
		// [XID] // 0x0000000189985B30-0x0000000189985B50
		private static string GetSourceName(PlayerPointerEventData playerEventData) => default; // 0x00000001865594C0-0x0000000186559690
	}
}

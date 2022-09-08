/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001898F1200-0x00000001898F1210
	public sealed class TouchRegion : TouchInteractable // TypeDefIndex: 3595
	{
		// Fields
		[CustomObfuscation] // 0x000000018994ADD0-0x000000018994AE30
		[SerializeField] // 0x000000018994ADD0-0x000000018994AE30
		// [Tooltip] // 0x000000018994ADD0-0x000000018994AE30
		private bool _hideAtRuntime; // 0x110
		private FYrowiwJIqsXZLMJavSNFYDKaOU _onPointerDown; // 0x118
		private IhafZOHoJAtmqlsDiIYdGJOhkbs _onPointerUp; // 0x120
		private jAjhXFIGhbeXtAhlTLAKBHcbBdQW _onPointerEnter; // 0x128
		private PxLBTabdgKFEjTiuOpPVIyMTjjny _onPointerExit; // 0x130
		private IXRfaaiCWPujdcUAcQQojenUYPJv _onBeginDrag; // 0x138
		private kVFpLoqnDpUmrjHHDdFBbEPQyGmf _onDrag; // 0x140
		private dZhpBWGuxrpdRZmgVBAEaiYenZc _onEndDrag; // 0x148
	
		// Properties
		public bool hideAtRuntime { get => default; set {} } // 0x0000000186A1E8E0-0x0000000186A1E940 0x0000000186A1ED30-0x0000000186A1EDC0
	
		// Events
		public event UnityAction<PointerEventData> PointerDownEvent;
		public event UnityAction<PointerEventData> PointerUpEvent;
		public event UnityAction<PointerEventData> PointerEnterEvent;
		public event UnityAction<PointerEventData> PointerExitEvent;
		public event UnityAction<PointerEventData> BeginDragEvent;
		public event UnityAction<PointerEventData> DragEvent;
		public event UnityAction<PointerEventData> EndDragEvent;
	
		// Nested types
		[Serializable]
		private class FYrowiwJIqsXZLMJavSNFYDKaOU : UnityEvent<PointerEventData> // TypeDefIndex: 3596
		{
			// Constructors
			public FYrowiwJIqsXZLMJavSNFYDKaOU() {} // 0x0000000185E8A1F0-0x0000000185E8A260
		}
	
		[Serializable]
		private class IhafZOHoJAtmqlsDiIYdGJOhkbs : UnityEvent<PointerEventData> // TypeDefIndex: 3597
		{
			// Constructors
			public IhafZOHoJAtmqlsDiIYdGJOhkbs() {} // 0x0000000185E8B320-0x0000000185E8B390
		}
	
		[Serializable]
		private class jAjhXFIGhbeXtAhlTLAKBHcbBdQW : UnityEvent<PointerEventData> // TypeDefIndex: 3598
		{
			// Constructors
			public jAjhXFIGhbeXtAhlTLAKBHcbBdQW() {} // 0x0000000185E95390-0x0000000185E95400
		}
	
		[Serializable]
		private class PxLBTabdgKFEjTiuOpPVIyMTjjny : UnityEvent<PointerEventData> // TypeDefIndex: 3599
		{
			// Constructors
			public PxLBTabdgKFEjTiuOpPVIyMTjjny() {} // 0x0000000185E91A40-0x0000000185E91AB0
		}
	
		[Serializable]
		private class IXRfaaiCWPujdcUAcQQojenUYPJv : UnityEvent<PointerEventData> // TypeDefIndex: 3600
		{
			// Constructors
			public IXRfaaiCWPujdcUAcQQojenUYPJv() {} // 0x0000000185E8B2B0-0x0000000185E8B320
		}
	
		[Serializable]
		private class kVFpLoqnDpUmrjHHDdFBbEPQyGmf : UnityEvent<PointerEventData> // TypeDefIndex: 3601
		{
			// Constructors
			public kVFpLoqnDpUmrjHHDdFBbEPQyGmf() {} // 0x0000000185E95530-0x0000000185E955A0
		}
	
		[Serializable]
		private class dZhpBWGuxrpdRZmgVBAEaiYenZc : UnityEvent<PointerEventData> // TypeDefIndex: 3602
		{
			// Constructors
			public dZhpBWGuxrpdRZmgVBAEaiYenZc() {} // 0x0000000185E94AA0-0x0000000185E94B10
		}
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private TouchRegion() {} // 0x0000000186A1E380-0x0000000186A1E4F0
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void Awake() {} // 0x0000000186A1D400-0x0000000186A1D4B0
		public override void ClearValue() {} // 0x0000000186A1D4B0-0x0000000186A1D500
		internal override void OnCustomControllerUpdate() {} // 0x0000000186A1D6D0-0x0000000186A1D720
		internal override void OnPointerDown(PointerEventData eventData) {} // 0x0000000186A1DB30-0x0000000186A1DCF0
		internal override void OnPointerUp(PointerEventData eventData) {} // 0x0000000186A1E120-0x0000000186A1E380
		internal override void OnPointerEnter(PointerEventData eventData) {} // 0x0000000186A1DCF0-0x0000000186A1DF60
		internal override void OnPointerExit(PointerEventData eventData) {} // 0x0000000186A1DF60-0x0000000186A1E120
		internal override void OnBeginDrag(PointerEventData eventData) {} // 0x0000000186A1D500-0x0000000186A1D6D0
		internal override void OnDrag(PointerEventData eventData) {} // 0x0000000186A1D720-0x0000000186A1D8E0
		internal override void OnEndDrag(PointerEventData eventData) {} // 0x0000000186A1D8E0-0x0000000186A1DB30
	}
}

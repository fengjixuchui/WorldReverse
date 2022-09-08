/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x0000000189837350-0x00000001898373D0
	// [RequireComponent] // 0x0000000189837350-0x00000001898373D0
	public sealed class UIPointer : UIBehaviour // TypeDefIndex: 9788
	{
		// Fields
		[SerializeField] // 0x0000000189845F40-0x0000000189845F90
		// [Tooltip] // 0x0000000189845F40-0x0000000189845F90
		private bool _hideHardwarePointer; // 0x18
		[SerializeField] // 0x0000000189850400-0x0000000189850450
		// [Tooltip] // 0x0000000189850400-0x0000000189850450
		private bool _autoSort; // 0x19
		[NonSerialized]
		private RectTransform _canvasRectTransform; // 0x20
	
		// Properties
		public bool autoSort { /* [XID] */ /* 0x00000001898F1990-0x00000001898F19B0 */ get => default; /* [XID] */ /* 0x00000001898D47D0-0x00000001898D47F0 */ set {} } // 0x00000001865652E0-0x0000000186565380 0x0000000186565380-0x0000000186565520
	
		// Constructors
		public UIPointer() {} // 0x0000000186565270-0x00000001865652E0
	
		// Methods
		// [XID] // 0x0000000189A15BC0-0x0000000189A15BE0
		protected override void Awake() {} // 0x0000000186564910-0x0000000186564A80
		// [XID] // 0x0000000189A06EA0-0x0000000189A06EC0
		private void Update() {} // 0x0000000186565140-0x0000000186565270
		// [XID] // 0x0000000189A0E570-0x0000000189A0E590
		protected override void OnTransformParentChanged() {} // 0x0000000186564F70-0x0000000186565020
		// [XID] // 0x0000000189937D00-0x0000000189937D20
		protected override void OnCanvasGroupChanged() {} // 0x0000000186564BD0-0x0000000186564C80
		// [XID] // 0x0000000189A5BB20-0x0000000189A5BB40
		public void OnScreenPositionChanged(Vector2 screenPosition) {} // 0x0000000186564C80-0x0000000186564F70
		// [XID] // 0x00000001899FF680-0x00000001899FF6A0
		private void GetDependencies() {} // 0x0000000186564A80-0x0000000186564BD0
	}
}

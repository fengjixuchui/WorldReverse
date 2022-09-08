/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls;
using Rewired.UI;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.UI;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent] // 0x0000000189750080-0x00000001897500F0
	[ExecuteInEditMode] // 0x0000000189750080-0x00000001897500F0
	// [RequireComponent] // 0x0000000189750080-0x00000001897500F0
	public sealed class TouchInteractableTransitioner : MonoBehaviour, IVisibilityChangedHandler, TouchInteractable.IInteractionStateTransitionHandler // TypeDefIndex: 3558
	{
		// Fields
		[CustomObfuscation] // 0x0000000189761FC0-0x0000000189762020
		[SerializeField] // 0x0000000189761FC0-0x0000000189762020
		// [Tooltip] // 0x0000000189761FC0-0x0000000189762020
		private bool _visible; // 0x18
		// [Bitmask] // 0x000000018976F1A0-0x000000018976F240
		[CustomObfuscation] // 0x000000018976F1A0-0x000000018976F240
		[SerializeField] // 0x000000018976F1A0-0x000000018976F240
		// [Tooltip] // 0x000000018976F1A0-0x000000018976F240
		private TouchInteractable.TransitionTypeFlags _transitionType; // 0x1C
		[CustomObfuscation] // 0x0000000189784460-0x00000001897844C0
		[SerializeField] // 0x0000000189784460-0x00000001897844C0
		// [Tooltip] // 0x0000000189784460-0x00000001897844C0
		private ColorBlock _transitionColorTint; // 0x20
		[CustomObfuscation] // 0x00000001897918F0-0x0000000189791950
		[SerializeField] // 0x00000001897918F0-0x0000000189791950
		// [Tooltip] // 0x00000001897918F0-0x0000000189791950
		private SpriteState _transitionSpriteState; // 0x68
		[CustomObfuscation] // 0x000000018979F810-0x000000018979F870
		[SerializeField] // 0x000000018979F810-0x000000018979F870
		// [Tooltip] // 0x000000018979F810-0x000000018979F870
		private AnimationTriggers _transitionAnimationTriggers; // 0x80
		[CustomObfuscation] // 0x00000001897ACE70-0x00000001897ACED0
		[SerializeField] // 0x00000001897ACE70-0x00000001897ACED0
		// [Tooltip] // 0x00000001897ACE70-0x00000001897ACED0
		private Graphic _targetGraphic; // 0x88
		[CustomObfuscation] // 0x00000001897BAB40-0x00000001897BABA0
		[SerializeField] // 0x00000001897BAB40-0x00000001897BABA0
		// [Tooltip] // 0x00000001897BAB40-0x00000001897BABA0
		private bool _syncFadeDurationWithTransitionEvent; // 0x90
		[CustomObfuscation] // 0x00000001897C9EE0-0x00000001897C9F40
		[SerializeField] // 0x00000001897C9EE0-0x00000001897C9F40
		// [Tooltip] // 0x00000001897C9EE0-0x00000001897C9F40
		private bool _syncColorTintWithTransitionEvent; // 0x91
		private TouchInteractable.InteractionState ehPgFVBdmCKlKrAFnEhGfpCHlUZG; // 0x94
	
		// Properties
		public bool visible { get => default; set {} } // 0x0000000185AAB080-0x0000000185AAB0E0 0x0000000185AAB9B0-0x0000000185AABB20
		public TouchInteractable.TransitionTypeFlags transitionType { get => default; set {} } // 0x0000000185AAB020-0x0000000185AAB080 0x0000000185AAB8F0-0x0000000185AAB9B0
		public ColorBlock transitionColorTint { get => default; set {} } // 0x0000000185AAAF20-0x0000000185AAAFB0 0x0000000185AAB730-0x0000000185AAB810
		public SpriteState transitionSpriteState { get => default; set {} } // 0x0000000185AAAFB0-0x0000000185AAB020 0x0000000185AAB810-0x0000000185AAB8F0
		public AnimationTriggers transitionAnimationTriggers { get => default; set {} } // 0x0000000185AAAEC0-0x0000000185AAAF20 0x0000000185AAB680-0x0000000185AAB730
		public Graphic targetGraphic { get => default; set {} } // 0x0000000185AAAE60-0x0000000185AAAEC0 0x0000000185AAB590-0x0000000185AAB680
		public bool syncFadeDurationWithTransitionEvent { get => default; set {} } // 0x0000000185AAAE00-0x0000000185AAAE60 0x0000000185AAB4D0-0x0000000185AAB590
		public bool syncColorTintWithTransitionEvent { get => default; set {} } // 0x0000000185AAADA0-0x0000000185AAAE00 0x0000000185AAB3F0-0x0000000185AAB4D0
		public Image image { get => default; set {} } // 0x0000000185AAAD00-0x0000000185AAADA0 0x0000000185AAB300-0x0000000185AAB3F0
		public Animator animator { get => default; } // 0x0000000185AAAC70-0x0000000185AAAD00 
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private TouchInteractableTransitioner() {} // 0x0000000185AAAA90-0x0000000185AAAC70
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Awake() {} // 0x0000000185AA92E0-0x0000000185AA9460
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnEnable() {} // 0x0000000185AA9B20-0x0000000185AA9C40
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnDisable() {} // 0x0000000185AA9AC0-0x0000000185AA9B20
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnValidate() {} // 0x0000000185AA9E70-0x0000000185AAA270
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Reset() {} // 0x0000000185AAA2F0-0x0000000185AAA380
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnCanvasGroupWasChanged() {} // 0x0000000185AA9A60-0x0000000185AA9AC0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnAnimationPropertiesWereApplied() {} // 0x0000000185AA9A00-0x0000000185AA9A60
		private void wQiEPKGVkSYAiCZoyTUamohUIKKd() {} // 0x0000000185AABB20-0x0000000185AABB80
		private void NVWqZPEZaDhGVdcEuqvABdsUKUL() {} // 0x0000000185AA9950-0x0000000185AA9A00
		private void lPSCJgLLeQzAoKcuIadJZzmnIqP(bool param_00007e02) {} // 0x0000000185AAB280-0x0000000185AAB300
		private void SWnzUAEKhgDxxwxmMhpFBvKnnQNm(bool param_00007e03, bool param_00007e04) {} // 0x0000000185AAA380-0x0000000185AAA420
		private bool hisTrhNjyiXPMPtamRiivLoWhbo() => default; // 0x0000000185AAB0E0-0x0000000185AAB170
		private void jAQGAmQgKbqKrhUPStwqorlTNHK() {} // 0x0000000185AAB170-0x0000000185AAB280
		private void SuHWIDfTNsChRxehzCBEFxUUSSd(TouchInteractable.InteractionState param_00007e05, bool param_00007e06) {} // 0x0000000185AAA420-0x0000000185AAA980
		private void GeMaoYWkSWdVuATkrycOOKBsivlD(Color param_00007e07, bool param_00007e08) {} // 0x0000000185AA9830-0x0000000185AA9950
		private void XTdwPHoIYAeXdtxcHVtlnrtFtNI(Sprite param_00007e09) {} // 0x0000000185AAA980-0x0000000185AAAA90
		private void CnDPxkPDbLAJqkImsyyrmtwSUPMg(string param_00007e0a) {} // 0x0000000185AA9460-0x0000000185AA9830
		public void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args) {} // 0x0000000185AA9C40-0x0000000185AA9E70
		public void OnVisibilityChanged(bool state) {} // 0x0000000185AAA270-0x0000000185AAA2F0
	}
}

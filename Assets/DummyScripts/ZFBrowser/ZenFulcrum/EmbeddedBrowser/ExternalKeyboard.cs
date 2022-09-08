/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	// [RequireComponent] // 0x00000001898B2F40-0x00000001898B2FC0
	// [RequireComponent] // 0x00000001898B2F40-0x00000001898B2FC0
	public class ExternalKeyboard : MonoBehaviour // TypeDefIndex: 6088
	{
		// Fields
		// [Tooltip] // 0x00000001898C2070-0x00000001898C20A0
		public bool automaticFocus; // 0x18
		// [Tooltip] // 0x00000001898CB220-0x00000001898CB250
		public Browser initialBrowser; // 0x20
		// [Tooltip] // 0x00000001898D4140-0x00000001898D4170
		public bool hideWhenUnneeded; // 0x28
		protected PointerUIBase activeBrowserUI; // 0x30
		protected Browser keyboardBrowser; // 0x38
		protected bool forcingFocus; // 0x40
		protected Browser _activeBrowser; // 0x48
	
		// Properties
		protected virtual Browser ActiveBrowser { get => default; set {} } // 0x00000001856ACB00-0x00000001856ACB60 0x00000001856ACC30-0x00000001856ACCB0
	
		// Events
		public event Action<Browser, bool> onFocusChange;
	
		// Constructors
		public ExternalKeyboard() {} // 0x00000001856AC950-0x00000001856ACA30
	
		// Methods
		protected void _SetActiveBrowser(Browser browser) {} // 0x00000001856AC7A0-0x00000001856AC950
		public void Awake() {} // 0x00000001856AB3F0-0x00000001856AB620
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		protected IEnumerator FindAndListenForBrowsers() => default; // 0x00000001856AC090-0x00000001856AC160
		protected void ObserveBrowser(Browser browser) {} // 0x00000001856AC160-0x00000001856AC320
		protected void DoFocus(Browser browser) {} // 0x00000001856ABF40-0x00000001856AC090
		protected void SetVisible(bool visible) {} // 0x00000001856AC4A0-0x00000001856AC5D0
		protected void OnBrowserFocus(bool mouseFocused, bool kbFocused) {} // 0x00000001856AC320-0x00000001856AC4A0
		protected void CommandEntered(JSONNode args) {} // 0x00000001856AB620-0x00000001856ABF40
		protected void TextTyped(JSONNode args) {} // 0x00000001856AC5D0-0x00000001856AC750
	}
}

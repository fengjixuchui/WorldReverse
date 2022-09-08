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
	// [RequireComponent] // 0x0000000189A80ED0-0x0000000189A80F20
	public abstract class CursorRendererBase : MonoBehaviour // TypeDefIndex: 6057
	{
		// Fields
		protected BrowserCursor cursor; // 0x18
	
		// Constructors
		protected CursorRendererBase() {} // 0x00000001856A6F70-0x00000001856A6FD0
	
		// Methods
		public virtual void OnEnable() {} // 0x00000001856A6E30-0x00000001856A6EA0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator Setup() => default; // 0x00000001856A6EA0-0x00000001856A6F70
		protected abstract void CursorChange();
	}
}

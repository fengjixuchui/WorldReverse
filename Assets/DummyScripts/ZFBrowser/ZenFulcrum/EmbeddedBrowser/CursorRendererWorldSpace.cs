/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class CursorRendererWorldSpace : CursorRendererBase // TypeDefIndex: 6061
	{
		// Fields
		// [Tooltip] // 0x0000000189AD39A0-0x0000000189AD39D0
		public float zOffset; // 0x20
		// [Tooltip] // 0x0000000189ADD1A0-0x0000000189ADD1D0
		public float size; // 0x24
		private GameObject cursorHolder; // 0x28
		private GameObject cursorImage; // 0x30
		private PointerUIBase pointerUI; // 0x38
		private bool cursorVisible; // 0x40
	
		// Constructors
		public CursorRendererWorldSpace() {} // 0x00000001856A7EF0-0x00000001856A8010
	
		// Methods
		public void Awake() {} // 0x00000001856A75B0-0x00000001856A7920
		protected override void CursorChange() {} // 0x00000001856A7920-0x00000001856A7BE0
		public void LateUpdate() {} // 0x00000001856A7BE0-0x00000001856A7E50
		public void OnDestroy() {} // 0x00000001856A7E50-0x00000001856A7EF0
	}
}

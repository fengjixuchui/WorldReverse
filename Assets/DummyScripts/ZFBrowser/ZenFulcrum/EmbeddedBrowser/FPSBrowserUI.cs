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
	[Obsolete] // 0x0000000189BAE900-0x0000000189BAE9A0
	// [RequireComponent] // 0x0000000189BAE900-0x0000000189BAE9A0
	// [RequireComponent] // 0x0000000189BAE900-0x0000000189BAE9A0
	public class FPSBrowserUI : ClickMeshBrowserUI // TypeDefIndex: 6067
	{
		// Fields
		protected Transform worldPointer; // 0x68
		protected FPSCursorRenderer cursorRenderer; // 0x70
	
		// Properties
		protected override Ray LookRay { get => default; } // 0x00000001856AD0B0-0x00000001856AD1C0 
	
		// Constructors
		public FPSBrowserUI() {} // 0x00000001856AD030-0x00000001856AD0B0
	
		// Methods
		public void Start() {} // 0x00000001856ACF90-0x00000001856AD030
		public static FPSBrowserUI Create(MeshCollider meshCollider, Transform worldPointer, FPSCursorRenderer cursorRenderer) => default; // 0x00000001856ACCB0-0x00000001856ACDE0
		protected override void SetCursor(BrowserCursor newCursor) {} // 0x00000001856ACEC0-0x00000001856ACF90
		public override void InputUpdate() {} // 0x00000001856ACDE0-0x00000001856ACEC0
	}
}

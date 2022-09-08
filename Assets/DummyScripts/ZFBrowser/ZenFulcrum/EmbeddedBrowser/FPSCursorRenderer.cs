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
	[Obsolete] // 0x0000000189BC06A0-0x0000000189BC06D0
	public class FPSCursorRenderer : MonoBehaviour // TypeDefIndex: 6068
	{
		// Fields
		private static FPSCursorRenderer _instance; // 0x00
		// [Tooltip] // 0x0000000189BC9BB0-0x0000000189BC9BE0
		public float scale; // 0x18
		// [Tooltip] // 0x0000000189BD1340-0x0000000189BD1370
		public float maxDistance; // 0x1C
		// [Tooltip] // 0x0000000189BDA0B0-0x0000000189BDA0E0
		public Transform pointer; // 0x20
		protected BrowserCursor baseCursor; // 0x30
		protected BrowserCursor currentCursor; // 0x38
	
		// Properties
		public static FPSCursorRenderer Instance { get => default; } // 0x00000001856AD7D0-0x00000001856AD930 
		public bool EnableInput { get; set; } // 0x00000001856AD770-0x00000001856AD7D0 0x00000001856AD930-0x00000001856AD990
	
		// Constructors
		public FPSCursorRenderer() {} // 0x00000001856AD700-0x00000001856AD770
	
		// Methods
		public static void SetUpBrowserInput(Browser browser, MeshCollider mesh) {} // 0x00000001856AD4E0-0x00000001856AD620
		public void Start() {} // 0x00000001856AD620-0x00000001856AD700
		public void OnGUI() {} // 0x00000001856AD1C0-0x00000001856AD480
		public void SetCursor(BrowserCursor newCursor, FPSBrowserUI ui) {} // 0x00000001856AD480-0x00000001856AD4E0
	}
}

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
	// [RequireComponent] // 0x0000000189874E50-0x0000000189874EA0
	public class DialogHandler : MonoBehaviour // TypeDefIndex: 6080
	{
		// Fields
		protected static string dialogPage; // 0x00
		protected Browser parentBrowser; // 0x18
		protected Browser dialogBrowser; // 0x20
		protected DialogCallback dialogCallback; // 0x28
		protected MenuCallback contextCallback; // 0x30
	
		// Nested types
		public delegate void DialogCallback(bool affirm, string text1, string text2); // TypeDefIndex: 6081; 0x00000001856A8140-0x00000001856A8320
	
		public delegate void MenuCallback(int commandId); // TypeDefIndex: 6082; 0x00000001856B4C80-0x00000001856B4E10
	
		// Constructors
		public DialogHandler() {} // 0x00000001856A9020-0x00000001856A9080
	
		// Methods
		public static DialogHandler Create(Browser parent, DialogCallback dialogCallback, MenuCallback contextCallback) => default; // 0x00000001856A83A0-0x00000001856A86F0
		public void HandleDialog(BrowserNative.DialogType type, string text, string promptDefault = null) {} // 0x00000001856A88F0-0x00000001856A8E30
		public void Show() {} // 0x00000001856A8F60-0x00000001856A9020
		public void Hide() {} // 0x00000001856A8E30-0x00000001856A8F60
		public void HandleContextMenu(string menuJSON, int x, int y) {} // 0x00000001856A86F0-0x00000001856A88F0
	}
}

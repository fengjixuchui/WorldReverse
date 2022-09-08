/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Platforms;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	public class RuntimeData : ScriptableObject // TypeDefIndex: 3946
	{
		// Fields
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Platform platform; // 0x18
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public WebplayerPlatform webplayerPlatform; // 0x1C
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public EditorPlatform editorPlatform; // 0x20
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public List<TextAsset> libraries; // 0x28
	
		// Constructors
		public RuntimeData() {} // 0x00000001851064C0-0x0000000185106520
	
		// Methods
		public void SetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries) {} // 0x0000000185106430-0x00000001851064C0
	}
}

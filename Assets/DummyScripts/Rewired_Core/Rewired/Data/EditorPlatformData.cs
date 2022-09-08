/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class EditorPlatformData : ScriptableObject // TypeDefIndex: 3947
	{
		// Fields
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Platform windowsStandalone; // 0x18
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Platform windowsStore; // 0x20
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Platform osxStandalone; // 0x28
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Platform linuxStandalone; // 0x30
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Platform webplayer; // 0x38
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Platform fallback; // 0x40
	
		// Nested types
		[Serializable]
		public class Platform // TypeDefIndex: 3948
		{
			// Fields
			public TextAsset[] libraries; // 0x10
	
			// Constructors
			public Platform() {} // 0x0000000185D6B600-0x0000000185D6B660
		}
	
		// Constructors
		public EditorPlatformData() {} // 0x0000000185D6A820-0x0000000185D6A880
	
		// Methods
		public TextAsset[] GetLibraries(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform) => default; // 0x0000000185D6A670-0x0000000185D6A720
		public Platform GetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform) => default; // 0x0000000185D6A720-0x0000000185D6A820
	}
}

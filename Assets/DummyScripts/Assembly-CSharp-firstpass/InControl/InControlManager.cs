/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.SceneManagement;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class InControlManager : SingletonMonoBehavior<InControl.InControlManager> // TypeDefIndex: 7617
	{
		// Fields
		public bool logDebugInfo; // 0x18
		public bool invertYAxis; // 0x19
		public bool useFixedUpdate; // 0x1A
		public bool dontDestroyOnLoad; // 0x1B
		public bool suspendInBackground; // 0x1C
		public bool enableICade; // 0x1D
		public bool enableXInput; // 0x1E
		public bool xInputOverrideUpdateRate; // 0x1F
		public int xInputUpdateRate; // 0x20
		public bool xInputOverrideBufferSize; // 0x24
		public int xInputBufferSize; // 0x28
		public bool enableNativeInput; // 0x2C
		public bool nativeInputEnableXInput; // 0x2D
		public bool nativeInputPreventSleep; // 0x2E
		public bool nativeInputOverrideUpdateRate; // 0x2F
		public int nativeInputUpdateRate; // 0x30
		public List<string> customProfiles; // 0x38
		public BindingConfig bindingConfig; // 0x40
	
		// Constructors
		public InControlManager() {} // 0x00000001870C9770-0x00000001870C9850
	
		// Methods
		// [XID] // 0x0000000189684220-0x0000000189684240
		private void OnEnable() {} // 0x00000001870C8F30-0x00000001870C9550
		// [XID] // 0x0000000189818040-0x0000000189818060
		private void OnDisable() {} // 0x00000001870C8E10-0x00000001870C8F30
		// [XID] // 0x000000018981FA10-0x000000018981FA30
		private void Update() {} // 0x00000001870C9640-0x00000001870C9770
		// [XID] // 0x00000001898270A0-0x00000001898270C0
		private void FixedUpdate() {} // 0x00000001870C8930-0x00000001870C8A10
		// [XID] // 0x000000018982E530-0x000000018982E550
		private void OnApplicationFocus(bool focusState) {} // 0x00000001870C8B60-0x00000001870C8C50
		// [XID] // 0x0000000189835D70-0x0000000189835D90
		private void OnApplicationPause(bool pauseState) {} // 0x00000001870C8C50-0x00000001870C8D40
		// [XID] // 0x000000018983D2D0-0x000000018983D2F0
		private void OnApplicationQuit() {} // 0x00000001870C8D40-0x00000001870C8E10
		// [XID] // 0x0000000189844BB0-0x0000000189844BD0
		private void OnSceneWasLoaded(Scene scene, LoadSceneMode loadSceneMode) {} // 0x00000001870C9550-0x00000001870C9640
		// [XID] // 0x000000018993C0D0-0x000000018993C0F0
		private static void LogMessage(LogMessage logMessage) {} // 0x00000001870C8A10-0x00000001870C8B60
	}
}

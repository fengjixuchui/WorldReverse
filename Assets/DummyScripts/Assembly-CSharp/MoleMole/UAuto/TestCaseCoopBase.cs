/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class TestCaseCoopBase : TestCaseBase // TypeDefIndex: 28206
	{
		// Constructors
		public TestCaseCoopBase() {} // 0x0000000184F91E40-0x0000000184F91EC0
	
		// Methods
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SelectCoopDialog(string content = "" /* Metadata: 0x00B0D4A0 */) => default; // 0x0000000184F91C50-0x0000000184F91D30
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitCutScene(uint checkCoopId = 0 /* Metadata: 0x00B0D4A4 */, string breakSelectWord = null, int timeout = 120 /* Metadata: 0x00B0D4A8 */, int afterTime = 5 /* Metadata: 0x00B0D4AC */, bool skipError = false /* Metadata: 0x00B0D4B0 */) => default; // 0x0000000184F91D30-0x0000000184F91E40
		public uint GetCurrentCoopId() => default; // 0x0000000184F91BA0-0x0000000184F91C50
		public void CheckCurrentCoopId(uint coopId) {} // 0x0000000184F91A80-0x0000000184F91BA0
	}
}

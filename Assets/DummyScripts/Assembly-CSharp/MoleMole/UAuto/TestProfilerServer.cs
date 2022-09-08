/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Newtonsoft.Json.Linq;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class TestProfilerServer : MonoBehaviour // TypeDefIndex: 28332
	{
		// Fields
		public uint dialogId; // 0x18
		private TestCasePerfBase tp; // 0x20
		private float budget_frameTime; // 0x28
		private float budget_gameTime; // 0x2C
		private float budget_physicsTime; // 0x30
		private float budget_renderTime; // 0x34
		private int memory_count; // 0x38
	
		// Constructors
		public TestProfilerServer() {} // 0x0000000182193EA0-0x0000000182193F10
	
		// Methods
		private void Start() {} // 0x0000000182193CE0-0x0000000182193E30
		private void ParseBudget(JToken budget) {} // 0x0000000182193540-0x0000000182193B70
		// [ContextMenu] // 0x0000000189B1EF00-0x0000000189B1EF30
		private void StartConnect() {} // 0x0000000182193C60-0x0000000182193CE0
		// [ContextMenu] // 0x0000000189B27BD0-0x0000000189B27C00
		private void PlayVoiceDialog() {} // 0x0000000182193B70-0x0000000182193BF0
		// [ContextMenu] // 0x0000000189B30810-0x0000000189B30840
		private void SendNameTransText() {} // 0x0000000182193BF0-0x0000000182193C60
		// [ContextMenu] // 0x0000000189B398C0-0x0000000189B398F0
		private void StopConnect() {} // 0x0000000182193E30-0x0000000182193EA0
		// [ContextMenu] // 0x0000000189B429B0-0x0000000189B429E0
		private void DumpServerCPU() {} // 0x0000000182193370-0x00000001821933F0
		// [ContextMenu] // 0x0000000189B4BB40-0x0000000189B4BB70
		private void Dump() {} // 0x00000001821933F0-0x00000001821934D0
		// [ContextMenu] // 0x0000000189B549D0-0x0000000189B54A00
		private void BeginSample() {} // 0x0000000182193290-0x0000000182193370
		// [ContextMenu] // 0x0000000189B5DB80-0x0000000189B5DBB0
		private void EndSample() {} // 0x00000001821934D0-0x0000000182193540
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public sealed class PostProcessDebug : MonoBehaviour // TypeDefIndex: 9570
	{
		// Fields
		public PostProcessLayer postProcessLayer; // 0x18
		private PostProcessLayer m_PreviousPostProcessLayer; // 0x20
		public bool lightMeter; // 0x28
		public bool histogram; // 0x29
		public bool waveform; // 0x2A
		public bool vectorscope; // 0x2B
		public DebugOverlay debugOverlay; // 0x2C
		private Camera m_CurrentCamera; // 0x30
		private CommandBuffer m_CmdAfterEverything; // 0x38
	
		// Constructors
		public PostProcessDebug() {} // 0x0000000185C01F20-0x0000000185C01F90
	
		// Methods
		// [XID] // 0x00000001897D4650-0x00000001897D4670
		private void OnEnable() {} // 0x0000000185C014F0-0x0000000185C015D0
		// [XID] // 0x0000000189928D00-0x0000000189928D20
		private void OnDisable() {} // 0x0000000185C013F0-0x0000000185C014F0
		// [XID] // 0x00000001899215A0-0x00000001899215C0
		private void Update() {} // 0x0000000185C01E80-0x0000000185C01F20
		// [XID] // 0x00000001897EAFD0-0x00000001897EAFF0
		private void Reset() {} // 0x0000000185C01AB0-0x0000000185C01B60
		// [XID] // 0x00000001898C0B50-0x00000001898C0B70
		private void UpdateStates() {} // 0x0000000185C01B60-0x0000000185C01E80
		// [XID] // 0x00000001898CFE40-0x00000001898CFE60
		private void OnPostRender() {} // 0x0000000185C017A0-0x0000000185C01AB0
		// [XID] // 0x0000000189912440-0x0000000189912460
		private void OnGUI() {} // 0x0000000185C015D0-0x0000000185C017A0
		// [XID] // 0x0000000189808F70-0x0000000189808F90
		private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) {} // 0x0000000185C01170-0x0000000185C013F0
	}
}

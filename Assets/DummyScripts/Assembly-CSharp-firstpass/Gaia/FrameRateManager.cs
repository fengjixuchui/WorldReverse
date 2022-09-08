/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class FrameRateManager : MonoBehaviour // TypeDefIndex: 9346
	{
		// Fields
		public bool m_showFPS; // 0x18
		public bool m_showGUI; // 0x19
		public bool m_autoQualityManagement; // 0x1A
		public float m_autoCheckInterval; // 0x1C
		public int m_targetFrameRate; // 0x20
		public int m_fontSize; // 0x24
		private float m_autoCheckTimeLeft; // 0x28
		private int m_currentQuality; // 0x2C
		private int m_maxQuality; // 0x30
		private string[] m_qualityNames; // 0x38
		private float m_fpsUpdateInterval; // 0x40
		private float m_fpsAccum; // 0x44
		private int m_fpsFrames; // 0x48
		private float m_fpsTimeLeft; // 0x4C
		private float m_fpsValue; // 0x50
		private string m_fpsValueStr; // 0x58
		private GUIStyle m_fpsStyle; // 0x60
		private GUIStyle m_fpsShadowStyle; // 0x68
		private Rect m_fpsLocation; // 0x70
		private Rect m_fpsShadowLocation; // 0x80
	
		// Constructors
		public FrameRateManager() {} // 0x0000000186B3F4C0-0x0000000186B3F680
	
		// Methods
		// [XID] // 0x00000001897A6C20-0x00000001897A6C40
		private void Start() {} // 0x0000000186B3E4C0-0x0000000186B3E750
		// [XID] // 0x00000001897AE470-0x00000001897AE490
		private void OnGUI() {} // 0x0000000186B3E2B0-0x0000000186B3E4C0
		// [XID] // 0x00000001897B6530-0x00000001897B6550
		private void Update() {} // 0x0000000186B3F170-0x0000000186B3F4C0
		// [XID] // 0x00000001897BE280-0x00000001897BE2A0
		private void UpdateQuality() {} // 0x0000000186B3E750-0x0000000186B3F170
		// [XID] // 0x00000001897C5980-0x00000001897C59A0
		private bool IncreaseQuality() => default; // 0x0000000186B3E1F0-0x0000000186B3E2B0
		// [XID] // 0x00000001897CD060-0x00000001897CD080
		private bool DecreaseQuality() => default; // 0x0000000186B3E130-0x0000000186B3E1F0
	}
}

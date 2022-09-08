/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CTS
{
	public class CTSFps : MonoBehaviour // TypeDefIndex: 9123
	{
		// Fields
		private const string cFormat = "FPS {0}"; // Metadata: 0x00AE5463
		private const float cMeasurePeriod = 0.5f; // Metadata: 0x00AE546E
		private int m_currentFps; // 0x18
		private int m_fpsAccumulator; // 0x1C
		private float m_fpsNextPeriod; // 0x20
		public string m_CTSVersion; // 0x28
		public string m_OS; // 0x30
		public string m_deviceName; // 0x38
		public string m_deviceType; // 0x40
		public string m_deviceModel; // 0x48
		public string m_platform; // 0x50
		public string m_processor; // 0x58
		public string m_ram; // 0x60
		public string m_gpu; // 0x68
		public string m_gpuDevice; // 0x70
		public string m_gpuVendor; // 0x78
		public string m_gpuSpec; // 0x80
		public string m_gpuRam; // 0x88
		public string m_gpuCapabilities; // 0x90
		public string m_screenInfo; // 0x98
		public string m_quality; // 0xA0
		public UnityEngine.UI.Text m_fpsText; // 0xA8
		public UnityEngine.UI.Text m_CTSVersionText; // 0xB0
		public UnityEngine.UI.Text m_OSText; // 0xB8
		public UnityEngine.UI.Text m_deviceText; // 0xC0
		public UnityEngine.UI.Text m_systemText; // 0xC8
		public UnityEngine.UI.Text m_gpuText; // 0xD0
		public UnityEngine.UI.Text m_gpuCapabilitiesText; // 0xD8
		public UnityEngine.UI.Text m_screenInfoText; // 0xE0
	
		// Properties
		public int FPS { /* [XID] */ /* 0x00000001898853F0-0x0000000189885410 */ get => default; } // 0x0000000186425D50-0x0000000186425DF0 
	
		// Constructors
		public CTSFps() {} // 0x0000000186425CE0-0x0000000186425D50
	
		// Methods
		// [XID] // 0x000000018988C970-0x000000018988C990
		private void Start() {} // 0x0000000186423EF0-0x0000000186425B40
		// [XID] // 0x0000000189893E20-0x0000000189893E40
		private void Update() {} // 0x0000000186425B40-0x0000000186425CE0
	}
}

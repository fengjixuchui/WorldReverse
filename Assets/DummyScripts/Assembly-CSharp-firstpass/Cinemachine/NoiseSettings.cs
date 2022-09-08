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

namespace Cinemachine
{
	// [DocumentationSorting] // 0x00000001897BFB90-0x00000001897BFBB0
	public sealed class NoiseSettings : ScriptableObject // TypeDefIndex: 6855
	{
		// Fields
		[SerializeField] // 0x00000001897C7350-0x00000001897C73A0
		// [Tooltip] // 0x00000001897C7350-0x00000001897C73A0
		private TransformNoiseParams[] m_Position; // 0x18
		[SerializeField] // 0x00000001897D2FC0-0x00000001897D3010
		// [Tooltip] // 0x00000001897D2FC0-0x00000001897D3010
		private TransformNoiseParams[] m_Orientation; // 0x20
	
		// Properties
		public TransformNoiseParams[] PositionNoise { /* [XID] */ /* 0x00000001898C7F20-0x00000001898C7F40 */ get => default; } // 0x00000001866A66E0-0x00000001866A6780 
		public TransformNoiseParams[] OrientationNoise { /* [XID] */ /* 0x000000018962B7F0-0x000000018962B810 */ get => default; } // 0x00000001866A6640-0x00000001866A66E0 
	
		// Nested types
		[Serializable]
		// [DocumentationSorting] // 0x00000001897F5A90-0x00000001897F5AB0
		public struct NoiseParams // TypeDefIndex: 6856
		{
			// Fields
			// [Tooltip] // 0x00000001897FD2E0-0x00000001897FD310
			public float Amplitude; // 0x00
			// [Tooltip] // 0x0000000189805F80-0x0000000189805FB0
			public float Frequency; // 0x04
		}
	
		[Serializable]
		// [DocumentationSorting] // 0x000000018980F0F0-0x000000018980F110
		public struct TransformNoiseParams // TypeDefIndex: 6857
		{
			// Fields
			// [Tooltip] // 0x00000001898168A0-0x00000001898168D0
			public NoiseParams X; // 0x00
			// [Tooltip] // 0x000000018981FAB0-0x000000018981FAE0
			public NoiseParams Y; // 0x08
			// [Tooltip] // 0x0000000189828940-0x0000000189828970
			public NoiseParams Z; // 0x10
		}
	
		// Constructors
		public NoiseSettings() {} // 0x00000001866A6590-0x00000001866A6640
	
		// Methods
		// [XID] // 0x00000001897EE330-0x00000001897EE350
		public void CopyFrom(NoiseSettings other) {} // 0x00000001866A6420-0x00000001866A6590
	}
}

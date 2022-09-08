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
	[Serializable]
	// [DocumentationSorting] // 0x000000018999F3E0-0x000000018999F400
	public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 6827
	{
		// Fields
		// [Tooltip] // 0x00000001899A6E60-0x00000001899A6E90
		public CustomBlend[] m_CustomBlends; // 0x18
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; // Metadata: 0x00ADDF0A
	
		// Nested types
		[Serializable]
		// [DocumentationSorting] // 0x00000001899B7360-0x00000001899B7380
		public struct CustomBlend // TypeDefIndex: 6828
		{
			// Fields
			// [Tooltip] // 0x00000001899BEDE0-0x00000001899BEE10
			public string m_From; // 0x00
			// [Tooltip] // 0x00000001899C7DF0-0x00000001899C7E20
			public string m_To; // 0x08
			// [Tooltip] // 0x00000001899D0F10-0x00000001899D0F40
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		// Constructors
		public CinemachineBlenderSettings() {} // 0x0000000186EE05E0-0x0000000186EE0650
	
		// Methods
		// [XID] // 0x0000000189BDBAF0-0x0000000189BDBB10
		public AnimationCurve GetBlendCurveForVirtualCameras(string fromCameraName, string toCameraName, AnimationCurve defaultCurve, out CinemachineBlendDefinition def) {
			def = default;
			return default;
		} // 0x0000000186EE0190-0x0000000186EE05E0
	}
}

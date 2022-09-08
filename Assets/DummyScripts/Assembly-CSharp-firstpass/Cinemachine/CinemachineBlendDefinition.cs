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
	// [DocumentationSorting] // 0x0000000189976510-0x0000000189976530
	public struct CinemachineBlendDefinition // TypeDefIndex: 6825
	{
		// Fields
		// [Tooltip] // 0x000000018997D870-0x000000018997D8A0
		public Style m_Style; // 0x00
		// [Tooltip] // 0x0000000189986C80-0x0000000189986CB0
		public float m_Time; // 0x04
		public AnimationCurve m_BlendCurve; // 0x08
	
		// Properties
		public AnimationCurve BlendCurve { /* [XID] */ /* 0x000000018998FFB0-0x000000018998FFD0 */ get => default; } // 0x0000000186EDC0D0-0x0000000186EDC170 
	
		// Nested types
		// [DocumentationSorting] // 0x00000001899978F0-0x0000000189997910
		public enum Style // TypeDefIndex: 6826
		{
			Cut = 0,
			EaseInOut = 1,
			EaseIn = 2,
			EaseOut = 3,
			HardIn = 4,
			HardOut = 5,
			Linear = 6,
			Spherical_Linear = 7
		}
	
		// Constructors
		public CinemachineBlendDefinition(Style style, float time, AnimationCurve blendCurve) : this() {
			m_Style = default;
			m_Time = default;
			m_BlendCurve = default;
		} // 0x0000000186EDBCF0-0x0000000186EDC0D0
	}
}

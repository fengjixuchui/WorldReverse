/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	public struct CameraState // TypeDefIndex: 6820
	{
		// Fields
		public static Vector3 kNoPoint; // 0x00
		private CustomBlendable mCustom0; // 0x80
		private CustomBlendable mCustom1; // 0x90
		private CustomBlendable mCustom2; // 0xA0
		private CustomBlendable mCustom3; // 0xB0
		private List<CustomBlendable> m_CustomOverflow; // 0xC0
	
		// Properties
		public LensSettings Lens { /* [XID] */ /* 0x00000001897636B0-0x00000001897636F0 */ get; /* [XID] */ /* 0x000000018976DBE0-0x000000018976DC20 */ set; } // 0x0000000186ED9EB0-0x0000000186ED9FA0 0x0000000186EDA760-0x0000000186EDA860
		public Vector3 ReferenceUp { /* [XID] */ /* 0x00000001897783B0-0x00000001897783F0 */ get; /* [XID] */ /* 0x0000000189782CF0-0x0000000189782D30 */ set; } // 0x0000000186EDA580-0x0000000186EDA670 0x0000000186EDAEA0-0x0000000186EDAF90
		public Vector3 ReferenceLookAt { /* [XID] */ /* 0x00000001897F11E0-0x00000001897F1220 */ get; /* [XID] */ /* 0x0000000189797900-0x0000000189797940 */ set; } // 0x0000000186EDA490-0x0000000186EDA580 0x0000000186EDADB0-0x0000000186EDAEA0
		public bool HasLookAt { /* [XID] */ /* 0x00000001897A25E0-0x00000001897A2600 */ get => default; } // 0x0000000186ED9E20-0x0000000186ED9EB0 
		public Vector3 RawPosition { /* [XID] */ /* 0x00000001897A9C30-0x00000001897A9C70 */ get; /* [XID] */ /* 0x00000001897B4AD0-0x00000001897B4B10 */ set; } // 0x0000000186EDA3A0-0x0000000186EDA490 0x0000000186EDACC0-0x0000000186EDADB0
		public Quaternion RawOrientation { /* [XID] */ /* 0x00000001897BFBB0-0x00000001897BFBF0 */ get; /* [XID] */ /* 0x00000001897C9EA0-0x00000001897C9EE0 */ set; } // 0x0000000186EDA2C0-0x0000000186EDA3A0 0x0000000186EDABF0-0x0000000186EDACC0
		internal Vector3 PositionDampingBypass { /* [XID] */ /* 0x00000001897D4790-0x00000001897D47D0 */ get; /* [XID] */ /* 0x000000018979F590-0x000000018979F5D0 */ set; } // 0x0000000186EDA1D0-0x0000000186EDA2C0 0x0000000186EDAB00-0x0000000186EDABF0
		public float ShotQuality { /* [XID] */ /* 0x00000001897E9940-0x00000001897E9980 */ get; /* [XID] */ /* 0x00000001897F44E0-0x00000001897F4520 */ set; } // 0x0000000186EDA670-0x0000000186EDA760 0x0000000186EDAF90-0x0000000186EDB020
		public Vector3 PositionCorrection { /* [XID] */ /* 0x00000001897FE8B0-0x00000001897FE8F0 */ get; /* [XID] */ /* 0x0000000189809090-0x00000001898090D0 */ set; } // 0x0000000186EDA150-0x0000000186EDA1D0 0x0000000186EDAA10-0x0000000186EDAB00
		public Quaternion OrientationCorrection { /* [XID] */ /* 0x00000001898136A0-0x00000001898136E0 */ get; /* [XID] */ /* 0x000000018981E1A0-0x000000018981E1E0 */ set; } // 0x0000000186EDA070-0x0000000186EDA150 0x0000000186EDA940-0x0000000186EDAA10
		public Vector3 CorrectedPosition { /* [XID] */ /* 0x0000000189828970-0x0000000189828990 */ get => default; } // 0x0000000186ED91C0-0x0000000186ED91F0 
		public Quaternion CorrectedOrientation { /* [XID] */ /* 0x000000018982FC90-0x000000018982FCB0 */ get => default; } // 0x0000000186ED8FD0-0x0000000186ED91C0 
		public Vector3 FinalPosition { /* [XID] */ /* 0x00000001898374D0-0x00000001898374F0 */ get => default; } // 0x0000000186ED9C60-0x0000000186ED9E20 
		public Quaternion FinalOrientation { /* [XID] */ /* 0x00000001897A9A00-0x00000001897A9A20 */ get => default; } // 0x0000000186ED9A70-0x0000000186ED9C60 
		public static CameraState Default { /* [XID] */ /* 0x0000000189846160-0x0000000189846180 */ get => default; } // 0x0000000186ED91F0-0x0000000186ED9A70 
		public int NumCustomBlendables { /* [XID] */ /* 0x000000018984D730-0x000000018984D770 */ get; /* [XID] */ /* 0x00000001898577D0-0x0000000189857810 */ private set; } // 0x0000000186ED9FA0-0x0000000186EDA070 0x0000000186EDA860-0x0000000186EDA940
	
		// Nested types
		public struct CustomBlendable // TypeDefIndex: 6821
		{
			// Fields
			public UnityEngine.Object m_Custom; // 0x00
			public float m_Weight; // 0x08
	
			// Constructors
			public CustomBlendable(UnityEngine.Object custom, float weight) {
				m_Custom = default;
				m_Weight = default;
			} // 0x0000000186EF0BB0-0x0000000186EF0CD0
		}
	
		// Constructors
		static CameraState() {
			kNoPoint = default;
		} // 0x0000000186ED8D80-0x0000000186ED8FD0
	
		// Methods
		// [XID] // 0x000000018969CC50-0x000000018969CC70
		public CustomBlendable GetCustomBlendable(int index) => default; // 0x0000000186ED5630-0x0000000186ED5910
		// [XID] // 0x0000000189869480-0x00000001898694A0
		private int FindCustomBlendable(UnityEngine.Object custom) => default; // 0x0000000186ED5430-0x0000000186ED5630
		// [XID] // 0x000000018966F180-0x000000018966F1A0
		public void AddCustomBlendable(CustomBlendable b) {} // 0x0000000186ED5180-0x0000000186ED5430
		// [XID] // 0x0000000189877F50-0x0000000189877F70
		public static CameraState Slerp(CameraState stateA, CameraState stateB, float t) => default; // 0x0000000186ED75D0-0x0000000186ED8D80
		// [XID] // 0x0000000189664770-0x0000000189664790
		public static CameraState Lerp(CameraState stateA, CameraState stateB, float t) => default; // 0x0000000186ED5920-0x0000000186ED75D0
		// [XID] // 0x0000000189886DA0-0x0000000189886DC0
		private float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t) => default; // 0x0000000186ED5910-0x0000000186ED5920
	}
}

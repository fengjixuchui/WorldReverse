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

namespace Cinemachine.Utility
{
	internal class PositionPredictor // TypeDefIndex: 6858
	{
		// Fields
		private Vector3 m_Position; // 0x10
		private const float kSmoothingDefault = 10f; // Metadata: 0x00ADDF68
		private float mSmoothing; // 0x1C
		private GaussianWindow1D_Vector3 m_Velocity; // 0x20
		private GaussianWindow1D_Vector3 m_Accel; // 0x28
	
		// Properties
		public float Smoothing { /* [XID] */ /* 0x00000001899C03D0-0x00000001899C03F0 */ get => default; /* [XID] */ /* 0x0000000189803210-0x0000000189803230 */ set {} } // 0x00000001866A7680-0x00000001866A7730 0x00000001866A7730-0x00000001866A78A0
		public bool IsEmpty { /* [XID] */ /* 0x0000000189840120-0x0000000189840140 */ get => default; } // 0x00000001866A75C0-0x00000001866A7680 
	
		// Constructors
		public PositionPredictor() {} // 0x00000001866A7470-0x00000001866A75C0
	
		// Methods
		// [XID] // 0x000000018982FAD0-0x000000018982FAF0
		public void Reset() {} // 0x00000001866A73A0-0x00000001866A7470
		// [XID] // 0x000000018984EFB0-0x000000018984EFD0
		public void AddPosition(Vector3 pos) {} // 0x00000001866A6CD0-0x00000001866A6F70
		// [XID] // 0x0000000189819A70-0x0000000189819A90
		public Vector3 PredictPosition(float lookaheadTime) => default; // 0x00000001866A6F70-0x00000001866A73A0
	}
}

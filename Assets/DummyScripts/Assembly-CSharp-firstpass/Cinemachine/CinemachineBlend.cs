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
	public class CinemachineBlend // TypeDefIndex: 6824
	{
		// Fields
		public static readonly CinemachineBlendDefinition DefaultBlendDef; // 0x00
	
		// Properties
		public ICinemachineCamera CamA { /* [XID] */ /* 0x00000001898CC560-0x00000001898CC5A0 */ get; /* [XID] */ /* 0x00000001898D7270-0x00000001898D72B0 */ set; } // 0x0000000186EDEE90-0x0000000186EDEEF0 0x0000000186EDFF80-0x0000000186EDFFE0
		public ICinemachineCamera CamB { /* [XID] */ /* 0x00000001898E1EB0-0x00000001898E1EF0 */ get; /* [XID] */ /* 0x00000001898EC740-0x00000001898EC780 */ set; } // 0x0000000186EDEEF0-0x0000000186EDEF50 0x0000000186EDFFE0-0x0000000186EE0040
		public AnimationCurve BlendCurve { /* [XID] */ /* 0x00000001898F7210-0x00000001898F7250 */ get; set; } // 0x0000000186EDECD0-0x0000000186EDED30 0x0000000186EDFF20-0x0000000186EDFF80
		public float TimeInBlend { /* [XID] */ /* 0x0000000189909040-0x0000000189909080 */ get; /* [XID] */ /* 0x0000000189B5BD20-0x0000000189B5BD60 */ set; } // 0x0000000186EDFEB0-0x0000000186EDFF20 0x0000000186EE0120-0x0000000186EE0190
		public float BlendWeight { /* [XID] */ /* 0x000000018991E320-0x000000018991E340 */ get => default; } // 0x0000000186EDED30-0x0000000186EDEE90 
		public bool IsValid { /* [XID] */ /* 0x0000000189925C30-0x0000000189925C50 */ get => default; } // 0x0000000186EDF460-0x0000000186EDF590 
		public float Duration { /* [XID] */ /* 0x000000018992D040-0x000000018992D080 */ get; set; } // 0x0000000186EDF2C0-0x0000000186EDF330 0x0000000186EE00B0-0x0000000186EE0120
		public bool IsComplete { /* [XID] */ /* 0x000000018993F0A0-0x000000018993F0C0 */ get => default; } // 0x0000000186EDF330-0x0000000186EDF460 
		public CinemachineBlendDefinition Def { /* [XID] */ /* 0x0000000189946700-0x0000000189946740 */ get; set; } // 0x0000000186EDEF50-0x0000000186EDEFC0 0x0000000186EE0040-0x0000000186EE00B0
		public string Description { /* [XID] */ /* 0x00000001899587C0-0x00000001899587E0 */ get => default; } // 0x0000000186EDEFC0-0x0000000186EDF2C0 
		public CameraState State { /* [XID] */ /* 0x000000018996E9B0-0x000000018996E9D0 */ get => default; } // 0x0000000186EDF590-0x0000000186EDFEB0 
	
		// Constructors
		public CinemachineBlend() {} // Dummy constructor
		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t, CinemachineBlendDefinition def) {} // 0x0000000186EDEB60-0x0000000186EDECD0
		static CinemachineBlend() {} // 0x0000000186EDEAF0-0x0000000186EDEB60
	
		// Methods
		// [XID] // 0x000000018995FDF0-0x000000018995FE10
		public bool Uses(ICinemachineCamera cam) => default; // 0x0000000186EDE920-0x0000000186EDEAF0
		// [XID] // 0x0000000189967700-0x0000000189967720
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186EDE710-0x0000000186EDE920
	}
}

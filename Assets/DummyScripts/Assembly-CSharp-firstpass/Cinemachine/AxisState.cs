/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	[Serializable]
	// [DocumentationSorting] // 0x000000018968AA20-0x000000018968AA40
	public struct AxisState // TypeDefIndex: 6818
	{
		// Fields
		[NoSaveDuringPlay] // 0x0000000189692760-0x00000001896927B0
		// [Tooltip] // 0x0000000189692760-0x00000001896927B0
		public float Value; // 0x00
		// [Tooltip] // 0x000000018969E3E0-0x000000018969E410
		public float m_MaxSpeed; // 0x04
		// [Tooltip] // 0x00000001896A6C50-0x00000001896A6C80
		public float m_AccelTime; // 0x08
		// [Tooltip] // 0x00000001896AF7B0-0x00000001896AF7E0
		public float m_DecelTime; // 0x0C
		// [FormerlySerializedAs] // 0x00000001896B8850-0x00000001896B88B0
		// [Tooltip] // 0x00000001896B8850-0x00000001896B88B0
		public string m_InputAxisName; // 0x10
		[NoSaveDuringPlay] // 0x00000001896C5A10-0x00000001896C5A60
		// [Tooltip] // 0x00000001896C5A10-0x00000001896C5A60
		public float m_InputAxisValue; // 0x18
		[NoSaveDuringPlay] // 0x00000001896D1620-0x00000001896D1660
		// [Tooltip] // 0x00000001896D1620-0x00000001896D1660
		public bool m_InvertAxis; // 0x1C
		private float mCurrentSpeed; // 0x20
		private float mMinValue; // 0x24
		private float mMaxValue; // 0x28
		private bool mWrapAround; // 0x2C
		private const float Epsilon = 0.0001f; // Metadata: 0x00ADDEC9
	
		// Constructors
		public AxisState(float maxSpeed, float accelTime, float decelTime, float val, string name, bool invert) {
			Value = default;
			m_MaxSpeed = default;
			m_AccelTime = default;
			m_DecelTime = default;
			m_InputAxisName = default;
			m_InputAxisValue = default;
			m_InvertAxis = default;
			mCurrentSpeed = default;
			mMinValue = default;
			mMaxValue = default;
			mWrapAround = default;
		} // 0x0000000186ED3AE0-0x0000000186ED3BE0
	
		// Methods
		// [XID] // 0x0000000189B46B80-0x0000000189B46BA0
		public void Validate() {} // 0x0000000186ED3A10-0x0000000186ED3AE0
		// [XID] // 0x00000001896E4B10-0x00000001896E4B30
		public void SetThresholds(float minValue, float maxValue, bool wrapAround) {} // 0x0000000186ED3350-0x0000000186ED38F0
		// [XID] // 0x00000001896EC0D0-0x00000001896EC0F0
		public bool Update(float deltaTime) => default; // 0x0000000186ED38F0-0x0000000186ED3A10
		// [XID] // 0x00000001896F3800-0x00000001896F3820
		private float GetMaxSpeed() => default; // 0x0000000186ED3260-0x0000000186ED3350
	}
}

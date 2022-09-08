/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Internal
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000189658AB0-0x0000000189658B00
	[CustomObfuscation] // 0x0000000189658AB0-0x0000000189658B00
	internal sealed class StandaloneAxis2D // TypeDefIndex: 4071
	{
		// Fields
		[CustomObfuscation] // 0x0000000189986D00-0x0000000189986D60
		[SerializeField] // 0x0000000189986D00-0x0000000189986D60
		// [Tooltip] // 0x0000000189986D00-0x0000000189986D60
		private Axis2DCalibration _calibration; // 0x10
		[CustomObfuscation] // 0x00000001899962B0-0x0000000189996310
		[SerializeField] // 0x00000001899962B0-0x0000000189996310
		// [Tooltip] // 0x00000001899962B0-0x0000000189996310
		private StandaloneAxis _xAxis; // 0x18
		[CustomObfuscation] // 0x00000001899A56C0-0x00000001899A5720
		[SerializeField] // 0x00000001899A56C0-0x00000001899A5720
		// [Tooltip] // 0x00000001899A56C0-0x00000001899A5720
		private StandaloneAxis _yAxis; // 0x20
		private bool _allowEvents; // 0x28
		private ValueChangedEventHandler _ValueChangedEvent; // 0x30
		private ValueChangedEventHandler _RawValueChangedEvent; // 0x38
	
		// Properties
		public Axis2DCalibration calibration { get => default; } // 0x000000018530BB60-0x000000018530BBC0 
		public StandaloneAxis xAxis { get => default; } // 0x000000018530C0A0-0x000000018530C100 
		public StandaloneAxis yAxis { get => default; } // 0x000000018530C100-0x000000018530C160 
		public Vector2 value { get => default; } // 0x000000018530C020-0x000000018530C0A0 
		public Vector2 valuePrev { get => default; } // 0x000000018530BFA0-0x000000018530C020 
		public Vector2 valueDelta { get => default; } // 0x000000018530BED0-0x000000018530BFA0 
		public Vector2 rawValue { get => default; } // 0x000000018530BD50-0x000000018530BE10 
		public Vector2 rawValuePrev { get => default; } // 0x000000018530BC90-0x000000018530BD50 
		public Vector2 rawValueDelta { get => default; } // 0x000000018530BBC0-0x000000018530BC90 
		internal Vector2 rawZero { get => default; } // 0x000000018530BE10-0x000000018530BED0 
	
		// Events
		private event ValueChangedEventHandler _ValueChangedEvent;
		public event ValueChangedEventHandler ValueChangedEvent;
	
		// Nested types
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public delegate void ValueChangedEventHandler(Vector2 value); // TypeDefIndex: 4072; 0x000000018530F350-0x000000018530F4D0
	
		// Constructors
		internal StandaloneAxis2D() {} // 0x000000018530B940-0x000000018530BA10
		internal StandaloneAxis2D(StandaloneAxis xAxis, StandaloneAxis yAxis) {} // 0x000000018530B860-0x000000018530B940
	
		// Methods
		public void SetRawValue(float x, float y) {} // 0x000000018530B130-0x000000018530B220
		public void SetRawValue(Vector2 value) {} // 0x000000018530B220-0x000000018530B2A0
		public void Clear() {} // 0x000000018530A390-0x000000018530A550
		internal void Initialize() {} // 0x000000018530AEF0-0x000000018530AF50
		internal void Deinitialize() {} // 0x000000018530A6F0-0x000000018530A750
		private void EvalAndSendValueChangeEvents() {} // 0x000000018530A750-0x000000018530A980
		private void Subscribe() {} // 0x000000018530B2A0-0x000000018530B540
		private void Unsubscribe() {} // 0x000000018530B540-0x000000018530B860
		private Vector2 GetCalibratedValue(StandaloneAxis xAxis, StandaloneAxis yAxis) => default; // 0x000000018530AC30-0x000000018530AEF0
		private Vector2 GetCalibratedValuePrev(StandaloneAxis xAxis, StandaloneAxis yAxis) => default; // 0x000000018530A980-0x000000018530AC30
		private void OnAxisValueChanged(float value) {} // 0x000000018530B010-0x000000018530B130
		private void OnAxisRawValueChanged(float value) {} // 0x000000018530AF50-0x000000018530B010
		internal static StandaloneAxis2D CreateRelative() => default; // 0x000000018530A550-0x000000018530A6F0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal class HIDGyroscope : HIDControllerElementWithDataSet // TypeDefIndex: 4041
	{
		// Fields
		public float timestamp; // 0x28
		public readonly float[] lastRawValue; // 0x30
		public readonly int valueLength; // 0x38
		private readonly byte[] gFAMGFphEQAPPIsOqIUOiYImMxyK; // 0x40
		private readonly float[] IJjPuvOIjgmvDENEKDmDhxVRAcS; // 0x48
		private readonly int bzosNyaAYkqqmjdsmYcZCYXPqkG; // 0x50
		private readonly int bKUWnIefrIOAGALIeelSjbpyaaDm; // 0x54
		private readonly Action<byte[], float[]> LpQqRQdQRXwpWRSAKJEFyQEozHE; // 0x58
		private readonly Func<float> SOpquRMJTuWZmiTUkbEfgdAUwjh; // 0x60
	
		// Properties
		public float[] rawValue { get => default; } // 0x000000018582D950-0x000000018582DA40 
	
		// Nested types
		internal class xBEEwMAwEXppBpQeDlfzeIoXvSP : HIDControllerElementWithDataSet.VxUwUEwsHpyhUrKaCKjiygOVwov // TypeDefIndex: 4042
		{
			// Fields
			private int axtedEoAkHzHHPKjMAlUhOpganvb; // 0x40
			private int eMUIfimpYMekCJfYwZaTsIbAXxsf; // 0x44
	
			// Properties
			public float[] mgdDrIvxATYlYDqhWbLUTOsrlhk { get => default; } // 0x0000000185846440-0x0000000185846530 
	
			// Constructors
			public xBEEwMAwEXppBpQeDlfzeIoXvSP() {} // Dummy constructor
			public xBEEwMAwEXppBpQeDlfzeIoXvSP(UpdateLoopSetting updateLoopSetting, int valueLength, int eventCapacity) {} // 0x0000000185846300-0x0000000185846440
	
			// Methods
			public override void Update(UpdateLoopType param_00008688) {} // 0x00000001858460A0-0x00000001858461A0
			public void UwtFnoJFfhpphgNJcULdzGmVVVd(float[] param_00008689, float param_0000868a) {} // 0x00000001858461A0-0x0000000185846300
			private HIDControllerElementWithDataSet.rBYVXUVToIgLLonOpRikzkiCPOx nHzkRQoJbhAUbYwgjOSPkUsYGBB(UpdateLoopType param_0000868b) => default; // 0x0000000185846530-0x00000001858465D0
		}
	
		internal class UHvFZMekCfSOGNSnqtquqJkGHSX : HIDControllerElementWithDataSet.rBYVXUVToIgLLonOpRikzkiCPOx // TypeDefIndex: 4043
		{
			// Fields
			private float[] NXFNbbjiyOxgeezDxqRQSZAImSn; // 0x18
			public float[] mgdDrIvxATYlYDqhWbLUTOsrlhk; // 0x20
			public ExpandableArray_DataContainer<KGLRdXPUfwSsizYSSfUaLfurGQ> GWfTyFXAiMBoDJEBdCWqJsHJsXZI; // 0x28
			private ExpandableArray_DataContainer<KGLRdXPUfwSsizYSSfUaLfurGQ> gmnZwcNKKJepixOcbuDfeGLWDZm; // 0x30
	
			// Constructors
			public UHvFZMekCfSOGNSnqtquqJkGHSX() {} // Dummy constructor
			public UHvFZMekCfSOGNSnqtquqJkGHSX(UpdateLoopType updateLoop, int valueLength, int eventCapacity) {} // 0x0000000185841F20-0x00000001858420E0
	
			// Methods
			public void UZSQFwoMfSAzsmmSKmseCCiJWWD() {} // 0x0000000185841CA0-0x0000000185841F20
			public void HMVGTeKrlsarQgYKYiDrPYtbbSAa(float[] param_0000868f, float param_00008690) {} // 0x0000000185841B00-0x0000000185841CA0
		}
	
		public class KGLRdXPUfwSsizYSSfUaLfurGQ : ExpandableArray_DataContainer<KGLRdXPUfwSsizYSSfUaLfurGQ> // TypeDefIndex: 4044
		{
			// Fields
			public Vector3 mgdDrIvxATYlYDqhWbLUTOsrlhk; // 0x10
			public float FeeKHQjHmaGhpevLgnOQQqEXhVFc; // 0x1C
	
			// Constructors
			public KGLRdXPUfwSsizYSSfUaLfurGQ() {} // 0x000000018583CDD0-0x000000018583CE30
	
			// Methods
			public void fuLKaTfKQpOpktgPzRLpUDfEjf(float[] param_00008691, float param_00008692) {} // 0x000000018583CE30-0x000000018583CF70
			public void Set(KGLRdXPUfwSsizYSSfUaLfurGQ param_00008693) {} // 0x000000018583CD40-0x000000018583CDD0
			public bool Equals(KGLRdXPUfwSsizYSSfUaLfurGQ param_00008694) => default; // 0x000000018583CC40-0x000000018583CD40
			public void Clear() {} // 0x000000018583CB90-0x000000018583CBF0
			public int CompareTo(KGLRdXPUfwSsizYSSfUaLfurGQ other) => default; // 0x000000018583CBF0-0x000000018583CC40
		}
	
		// Constructors
		public HIDGyroscope() {} // Dummy constructor
		public HIDGyroscope(UpdateLoopSetting updateLoopSetting, byte reportId, HIDInfo hidInfo, int valueLength, int startingEventCapacity, Action<byte[], float[]> calcValueDelegate, Func<float> getSensorDeltaTimeDelegate) {} // 0x000000018582D750-0x000000018582D950
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamps) {} // 0x000000018582D4C0-0x000000018582D750
	}
}

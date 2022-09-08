/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_Accelerometer : CustomCalculation // TypeDefIndex: 3764
	{
		// Fields
		public CalculationType _calculationType; // 0x50
		public InputType _inputType; // 0x54
		public OutputType _outputType; // 0x58
	
		// Properties
		internal override TypeWrapper.DataType ResultType { get => default; } // 0x00000001869B7940-0x00000001869B7990 
	
		// Nested types
		public enum CalculationType // TypeDefIndex: 3765
		{
			Pitch = 0,
			Roll = 1
		}
	
		public enum OutputType // TypeDefIndex: 3766
		{
			Axis = 0,
			Angle = 1
		}
	
		public enum InputType // TypeDefIndex: 3767
		{
			Acceleration = 0,
			UserAcceleration = 1,
			Gravity = 2
		}
	
		// Constructors
		public CustomCalculation_Accelerometer() {} // 0x00000001869B7620-0x00000001869B76C0
	
		// Methods
		internal override bool Process() => default; // 0x00000001869B7520-0x00000001869B7620
		private float HpIfovKhtbECklIRPNKyBklFrojc() => default; // 0x00000001869B71E0-0x00000001869B7480
		private float fTQfeHTsGqvxMhCRDbQKJiuDqXxD() => default; // 0x00000001869B76C0-0x00000001869B7940
		private float HxlvOMXteqLxjFpVEdQPqFKmSHo(float param_0000822d) => default; // 0x00000001869B7480-0x00000001869B7520
	}
}

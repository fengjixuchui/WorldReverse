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
using Rewired.Drivers.Interfaces;
using Rewired.HID;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal abstract class HIDDeviceDriver : IDisposable, IControllerDriver // TypeDefIndex: 4034
	{
		// Fields
		public HIDAxis[] axes; // 0x10
		public HIDButton[] buttons; // 0x18
		public HIDHat[] hats; // 0x20
		public HIDAccelerometer[] accelerometers; // 0x28
		public HIDGyroscope[] gyroscopes; // 0x30
		public HIDTouchpad[] touchpads; // 0x38
		public HIDVibrationMotor[] vibrationMotors; // 0x40
		public HIDLight[] lights; // 0x48
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0x50
	
		// Properties
		public int AxisCount { get; } // 0x000000018582D1C0-0x000000018582D230 
		public int ButtonCount { get; } // 0x000000018582D230-0x000000018582D2A0 
		public int HatCount { get; } // 0x000000018582D310-0x000000018582D380 
		public int AccelerometerCount { get; } // 0x000000018582D150-0x000000018582D1C0 
		public int GyroscopeCount { get; } // 0x000000018582D2A0-0x000000018582D310 
		public int TouchpadCount { get; } // 0x000000018582D380-0x000000018582D3F0 
		public int VibrationMotorCount { get; } // 0x000000018582D3F0-0x000000018582D460 
		protected bool disposed { get; } // 0x000000018582D460-0x000000018582D4C0 
	
		// Nested types
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		internal class InitArgs // TypeDefIndex: 4035
		{
			// Fields
			public UpdateLoopSetting updateLoopSetting; // 0x10
			public DeviceConnectionType connectionType; // 0x14
			public int minAxisValue; // 0x18
			public int maxAxisValue; // 0x1C
			public int hatZeroValue; // 0x20
			public int hatSpan; // 0x24
			public int inputReportLength; // 0x28
			public int outputReportLength; // 0x2C
			public Func<OutputReport, bool> synchronousWriteOutputReportDelegate; // 0x30
			public Action<OutputReport> asynchronousWriteOutputReportDelegate; // 0x38
	
			// Constructors
			public InitArgs() {} // Dummy constructor
			public InitArgs(UpdateLoopSetting updateLoopSetting, DeviceConnectionType connectionType, int minAxisValue, int maxAxisValue, int hatZeroValue, int hatSpan, int inputReportLength, int outputReportLength, Func<OutputReport, bool> synchronousWriteOutputReportDelegate, Action<OutputReport> asynchronousWriteOutputReportDelegate) {} // 0x0000000185832EA0-0x0000000185832F70
		}
	
		// Constructors
		public HIDDeviceDriver() {} // 0x000000018582D0F0-0x000000018582D150
	
		// Methods
		public abstract void Update(UpdateLoopType updateLoop);
		public abstract bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp);
		public abstract Controller.Extension CreateControllerExtension();
		public static HIDDeviceDriver GetDriver(int driverId, InitArgs hidDriverInitArgs) => default; // 0x000000018582CFE0-0x000000018582D0F0
		public static int FindDriverId(int vendorId, int productId) => default; // 0x000000018582CF00-0x000000018582CFE0
		public void Dispose() {} // 0x000000018582CDD0-0x000000018582CE50
		~HIDDeviceDriver() {} // 0x000000018582CE50-0x000000018582CF00
		protected virtual void Dispose(bool disposing) {} // 0x000000018582CD70-0x000000018582CDD0
	}
}

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

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal abstract class HIDControllerElementWithDataSet : HIDControllerElement // TypeDefIndex: 4031
	{
		// Fields
		internal VxUwUEwsHpyhUrKaCKjiygOVwov dataSet; // 0x20
	
		// Nested types
		internal abstract class VxUwUEwsHpyhUrKaCKjiygOVwov // TypeDefIndex: 4032
		{
			// Fields
			private int QdTdferWUIGCEcDqtckseuZfSkeF; // 0x10
			private int[] xcSjpzzrNYXAIxAxYcwPczRgjNT; // 0x18
			protected rBYVXUVToIgLLonOpRikzkiCPOx[] gRSZlsGnOMePzdfqhIobycvdjXwm; // 0x20
			public rBYVXUVToIgLLonOpRikzkiCPOx xbRrcEKKIAKiQkVzQCekOswVHrJ; // 0x28
			private int RMmuzLwPyyqjZzFkavzjXDLDVyZ; // 0x30
			private int ZMZbecCGBpEGMhMVXcfFEAvXLKW; // 0x34
			private bool WktzUSAcjulBYRNUcifkLEmijRhD; // 0x38
	
			// Properties
			public UpdateLoopType uZqPISCyPgGPOetNKiFUKtuJqjV { get; set; } // 0x00000001858427B0-0x0000000185842880
	
			// Constructors
			public VxUwUEwsHpyhUrKaCKjiygOVwov() {} // 0x0000000185842740-0x00000001858427B0
	
			// Methods
			public void AhzGMQRtWGSyIzEkOTUIlpjMwgy(UpdateLoopSetting param_00008624, Func<UpdateLoopType, rBYVXUVToIgLLonOpRikzkiCPOx> param_00008625) {} // 0x0000000185842380-0x00000001858426A0
			public virtual void Update(UpdateLoopType param_00008626) {} // 0x00000001858426A0-0x0000000185842740
		}
	
		internal abstract class rBYVXUVToIgLLonOpRikzkiCPOx // TypeDefIndex: 4033
		{
			// Fields
			public readonly UpdateLoopType uZqPISCyPgGPOetNKiFUKtuJqjV; // 0x10
	
			// Constructors
			protected rBYVXUVToIgLLonOpRikzkiCPOx() {} // Dummy constructor
			public rBYVXUVToIgLLonOpRikzkiCPOx(UpdateLoopType updateLoop) {} // 0x0000000185846030-0x00000001858460A0
		}
	
		// Constructors
		protected HIDControllerElementWithDataSet() {} // Dummy constructor
		public HIDControllerElementWithDataSet(VxUwUEwsHpyhUrKaCKjiygOVwov dataSet, byte reportId, HIDInfo hidInfo) {} // 0x000000018582CC50-0x000000018582CCE0
	
		// Methods
		public virtual void Update(UpdateLoopType updateLoop) {} // 0x000000018582CBA0-0x000000018582CC50
	}
}

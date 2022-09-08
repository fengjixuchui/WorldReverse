/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Drivers.Interfaces;
using Rewired.HID;
using Rewired.Utils.Classes.Data;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal class RailDriverDriver : HIDDeviceDriver, IDisposable, IDriver_RailDriver // TypeDefIndex: 4038
	{
		// Fields
		private readonly NativeBuffer kBUmUcAyFhoFeddZhyvELUyrNQP; // 0x58
		private readonly NativeBuffer xQtqlAYhQUqbOGYibktAZaYeTPW; // 0x60
		private byte[] qSfSBFqpCLXbbvukjZgsNRuNsrC; // 0x68
		private readonly OutputReport wDqsBPZBSKtSLRDQNHWwaHOApvg; // 0x70
		private readonly Func<OutputReport, bool> KoLbpdtSgwWZhTuekQfZVolIbnZ; // 0x90
		private readonly Action<OutputReport> beVWMbKDuyboNeDypPMnahQkenTj; // 0x98
	
		// Constructors
		public RailDriverDriver() {} // Dummy constructor
		public RailDriverDriver(InitArgs initArgs) {} // 0x000000018583F930-0x0000000185840100
	
		// Methods
		public override void Update(UpdateLoopType updateLoop) {} // 0x000000018583F8E0-0x000000018583F930
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp) => default; // 0x000000018583F690-0x000000018583F7E0
		public override Controller.Extension CreateControllerExtension() => default; // 0x000000018583F380-0x000000018583F400
		private void bWqXMuWKIQJCfsxGeWCQkichWXy(NativeBuffer param_00008674, float param_00008675) {} // 0x0000000185840100-0x0000000185840710
		private void TncRWDNnjIHJtHMNjIvXiptqHAB(HIDControllerElement[] param_00008676, NativeBuffer param_00008677, float param_00008678) {} // 0x000000018583F7E0-0x000000018583F8E0
		~RailDriverDriver() {} // 0x000000018583F560-0x000000018583F610
		protected override void Dispose(bool disposing) {} // 0x000000018583F400-0x000000018583F560
		public static bool Matches(int vid, int pid) => default; // 0x000000018583F610-0x000000018583F690
	}
}

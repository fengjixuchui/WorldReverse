/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoTools
{
	public class DeviceMemory // TypeDefIndex: 8460
	{
		// Fields
		private static DeviceMemory _instance; // 0x00
		private Thread _workThread; // 0x10
		private int _observerCount; // 0x18
		private readonly object _lock; // 0x20
		private int _memoryInKB; // 0x28
	
		// Properties
		public static DeviceMemory instance { /* [XID] */ /* 0x00000001898EF660-0x00000001898EF680 */ get => default; } // 0x00000001853FE4B0-0x00000001853FE5F0 
	
		// Constructors
		private DeviceMemory() {} // 0x00000001853FE3C0-0x00000001853FE4B0
		static DeviceMemory() {} // 0x00000001853FE360-0x00000001853FE3C0
	
		// Methods
		// [XID] // 0x0000000189933040-0x0000000189933060
		public void IncreaseObserver() {} // 0x00000001853FE010-0x00000001853FE130
		// [XID] // 0x0000000189950D30-0x0000000189950D50
		public void DecreaseObserver() {} // 0x00000001853FDC50-0x00000001853FDDA0
		// [XID] // 0x00000001899D68B0-0x00000001899D68D0
		private void ThreadEntry() {} // 0x00000001853FE1D0-0x00000001853FE360
		// [XID] // 0x0000000189787230-0x0000000189787250
		private void SetupDeviceMemoryTool() {} // 0x00000001853FE130-0x00000001853FE1D0
		// [XID] // 0x000000018978E800-0x000000018978E820
		public int GetAppMemory(bool bForce = false /* Metadata: 0x00ADF793 */) => default; // 0x00000001853FDE60-0x00000001853FDF30
		private static extern int GetMemoryUsageForProcessKB(); // 0x00000001853FDF30-0x00000001853FE010
		// [XID] // 0x000000018999C150-0x000000018999C170
		private int GetAppMemoryInKB() => default; // 0x00000001853FDDA0-0x00000001853FDE60
	}
}

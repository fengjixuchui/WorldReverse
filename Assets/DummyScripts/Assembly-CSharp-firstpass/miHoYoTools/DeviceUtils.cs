/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoTools
{
	public static class DeviceUtils // TypeDefIndex: 8454
	{
		// Fields
		public const int BATTERY_LEVEL_MAX = 100; // Metadata: 0x00ADF73B
		public static readonly string MESSAGE_OBJECT_NAME; // 0x00
		public static readonly string MESSAGE_BETTERY_CHANGED; // 0x08
		public static readonly string MESSAGE_WIFI_STATE_CHANGED; // 0x10
		public static readonly string MESSAGE_WIFI_RSSI_CHANGED; // 0x18
	
		// Nested types
		public enum BatteryStatus // TypeDefIndex: 8455
		{
			Unknown = 0,
			Charging = 1,
			DisCharging = 2,
			NotCharging = 3,
			Full = 4
		}
	
		public enum NetworkType // TypeDefIndex: 8456
		{
			Unknown = 0,
			Cellular = 1,
			Wifi = 2,
			Bluetooth = 3,
			Ethernet = 4,
			Vpn = 5,
			WifiAware = 6
		}
	
		public enum WifiState // TypeDefIndex: 8457
		{
			Disabling = 0,
			Disabled = 1,
			Enabling = 2,
			Enabled = 3,
			Unknown = 4
		}
	
		// Constructors
		static DeviceUtils() {} // 0x00000001853FEA00-0x00000001853FEAB0
	
		// Methods
		// [XID] // 0x0000000189ABE540-0x0000000189ABE560
		public static string FormatSize(long i) => default; // 0x00000001853FE7D0-0x00000001853FEA00
		// [XID] // 0x000000018986D5B0-0x000000018986D5D0
		public static string FormatPower(double power) => default; // 0x00000001853FE5F0-0x00000001853FE7D0
	}
}

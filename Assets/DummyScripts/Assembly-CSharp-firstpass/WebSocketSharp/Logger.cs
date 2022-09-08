/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	public class Logger // TypeDefIndex: 10234
	{
		// Fields
		private string _file; // 0x10
		private LogLevel _level; // 0x18
		private Action<LogData, string> _output; // 0x20
		private object _sync; // 0x28
	
		// Properties
		public string File { /* [XID] */ /* 0x000000018968A680-0x000000018968A6A0 */ get => default; /* [XID] */ /* 0x0000000189B8E1A0-0x0000000189B8E1C0 */ set {} } // 0x0000000186714320-0x00000001867143D0 0x00000001867147B0-0x0000000186714920
		public LogLevel Level { /* [XID] */ /* 0x0000000189B956A0-0x0000000189B956C0 */ get => default; /* [XID] */ /* 0x00000001896E3100-0x00000001896E3120 */ set {} } // 0x00000001867143D0-0x0000000186714470 0x0000000186714920-0x0000000186714AA0
		public Action<LogData, string> Output { /* [XID] */ /* 0x0000000189ACEB50-0x0000000189ACEB70 */ get => default; /* [XID] */ /* 0x0000000189AC7590-0x0000000189AC75B0 */ set {} } // 0x0000000186714470-0x0000000186714510 0x0000000186714AA0-0x0000000186714C40
	
		// Constructors
		public Logger() {} // 0x0000000186714180-0x0000000186714200
		public Logger(LogLevel level) {} // 0x0000000186713FF0-0x0000000186714070
		public Logger(LogLevel level, string file, Action<LogData, string> output) {} // 0x0000000186714070-0x0000000186714180
	
		// Methods
		// [XID] // 0x0000000189BB2E90-0x0000000189BB2EB0
		private static void defaultOutput(LogData data, string path) {} // 0x0000000186714200-0x0000000186714320
		// [XID] // 0x0000000189BBA420-0x0000000189BBA440
		private void output(string message, LogLevel level) {} // 0x0000000186714510-0x00000001867147B0
		// [XID] // 0x0000000189BC2400-0x0000000189BC2420
		private static void writeToFile(string value, string path) {} // 0x0000000186714C40-0x0000000186714E20
		// [XID] // 0x0000000189BC9A10-0x0000000189BC9A30
		public void Debug(string message) {} // 0x0000000186713B20-0x0000000186713BF0
		// [XID] // 0x0000000189BD1150-0x0000000189BD1170
		public void Error(string message) {} // 0x0000000186713BF0-0x0000000186713CC0
		// [XID] // 0x00000001896AF560-0x00000001896AF580
		public void Fatal(string message) {} // 0x0000000186713CC0-0x0000000186713D80
		// [XID] // 0x0000000189BDFF60-0x0000000189BDFF80
		public void Info(string message) {} // 0x0000000186713D80-0x0000000186713E50
		// [XID] // 0x00000001895ECDA0-0x00000001895ECDC0
		public void Trace(string message) {} // 0x0000000186713E50-0x0000000186713F20
		// [XID] // 0x0000000189BA7330-0x0000000189BA7350
		public void Warn(string message) {} // 0x0000000186713F20-0x0000000186713FF0
	}
}

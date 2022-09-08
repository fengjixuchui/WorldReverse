/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace XInputDotNetPure
{
	internal class Imports // TypeDefIndex: 8011
	{
		// Constructors
		public Imports() {} // 0x000000018948D630-0x000000018948D690
	
		// Methods
		public static extern uint XInputGamePadGetState32(uint playerIndex, IntPtr state); // 0x000000018948D050-0x000000018948D150
		public static extern void XInputGamePadSetState32(uint playerIndex, float leftMotor, float rightMotor); // 0x000000018948D320-0x000000018948D430
		public static extern uint XInputGamePadGetState64(uint playerIndex, IntPtr state); // 0x000000018948D150-0x000000018948D250
		public static extern void XInputGamePadSetState64(uint playerIndex, float leftMotor, float rightMotor); // 0x000000018948D430-0x000000018948D540
		// [XID] // 0x00000001898A2AE0-0x00000001898A2B00
		public static uint XInputGamePadGetState(uint playerIndex, IntPtr state) => default; // 0x000000018948D250-0x000000018948D320
		// [XID] // 0x00000001898A9FE0-0x00000001898AA000
		public static void XInputGamePadSetState(uint playerIndex, float leftMotor, float rightMotor) {} // 0x000000018948D540-0x000000018948D630
	}
}

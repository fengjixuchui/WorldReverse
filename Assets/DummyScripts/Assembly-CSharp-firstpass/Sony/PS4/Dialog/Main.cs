/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Sony.PS4.Dialog
{
	public class Main // TypeDefIndex: 9747
	{
		// Properties
		public static float DisplaySafeAreaRatio { /* [XID] */ /* 0x000000018975B8B0-0x000000018975B8D0 */ get => default; } // 0x0000000186F1E160-0x0000000186F1E210 
	
		// Events
		public static event Messages.EventHandler OnLog;
		public static event Messages.EventHandler OnLogWarning;
		public static event Messages.EventHandler OnLogError;
	
		// Constructors
		public Main() {} // 0x0000000186F1DDA0-0x0000000186F1DE00
	
		// Methods
		private static extern int PrxCommonDialogInitialise(); // 0x0000000186F1D840-0x0000000186F1D920
		private static extern int PrxCommonDialogUpdate(); // 0x0000000186F1D920-0x0000000186F1DA00
		// [XID] // 0x00000001897364D0-0x00000001897364F0
		public static void Initialise() {} // 0x0000000186F1D7A0-0x0000000186F1D840
		// [XID] // 0x0000000189A180D0-0x0000000189A180F0
		public static void Update() {} // 0x0000000186F1DD00-0x0000000186F1DDA0
		// [XID] // 0x0000000189A1F790-0x0000000189A1F7B0
		private static void PumpMessages() {} // 0x0000000186F1DAE0-0x0000000186F1DD00
		private static extern float PrxGetDisplaySafeAreaRatio(); // 0x0000000186F1DA00-0x0000000186F1DAE0
	}
}

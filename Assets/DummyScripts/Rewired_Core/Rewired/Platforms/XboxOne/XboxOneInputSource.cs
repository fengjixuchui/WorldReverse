/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Platforms.Custom;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Platforms.XboxOne
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource // TypeDefIndex: 4426
	{
		// Fields
		private readonly bool WktzUSAcjulBYRNUcifkLEmijRhD; // 0x48
		private Queue<bXmcTMfGwFwLLQZrIAsdJeUcWzy> QIJLkgXNPkoJsuNWoVMxvdgKYGZ; // 0x50
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0x58
	
		// Properties
		public override bool isReady { get => default; } // 0x0000000185BECA90-0x0000000185BECAF0 
	
		// Nested types
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private enum BadConnectionReason // TypeDefIndex: 4427
		{
			None = 0,
			GamepadNotActive = 1,
			InvalidName = 2
		}
	
		private struct bXmcTMfGwFwLLQZrIAsdJeUcWzy // TypeDefIndex: 4428
		{
			// Fields
			public uint aYpumKHzXlKGeinaYggEyjZraQSC; // 0x00
			public uint PfEGJlZJLohXMpnrEXVDellLDPS; // 0x04
	
			// Constructors
			public bXmcTMfGwFwLLQZrIAsdJeUcWzy(uint unityJoystickId, uint connectedFrame) {
				aYpumKHzXlKGeinaYggEyjZraQSC = default;
				PfEGJlZJLohXMpnrEXVDellLDPS = default;
			} // 0x0000000185BED0E0-0x0000000185BED150
		}
	
		private class VrjTyZoECUUIfnXhabttsAzpAeW : CustomInputSource.Joystick // TypeDefIndex: 4429
		{
			// Fields
			private readonly IXboxOneInputSource CpNbHtCijSICCnUFhUdnSnuZaCd; // 0x70
			private int NwgZCoPcMAFocejfaTMgksjuPEtb; // 0x78
			private ulong CoCeZQIEtDRCWBcWzqXXxFMtlTL; // 0x80
			private string[] vvUGppAcYXonOEueXDnXKzJafXN; // 0x88
	
			// Constructors
			public VrjTyZoECUUIfnXhabttsAzpAeW() {} // Dummy constructor
			public VrjTyZoECUUIfnXhabttsAzpAeW(IXboxOneInputSource inputSource, ulong xboxControllerId, int unityJoystickId, bool isConnected) {} // 0x0000000185BE9CA0-0x0000000185BE9E80
	
			// Methods
			public override void Update() {} // 0x0000000185BE8BF0-0x0000000185BE9A80
			public void YJaAHaimrHWIfKrgfWxeihnqrcza(ulong param_00009350) {} // 0x0000000185BE9A80-0x0000000185BE9CA0
			private void vrtROXlgaeUcHBHqSIqBsWVBhQv() {} // 0x0000000185BE9F20-0x0000000185BEA050
			private bool lvyTpewEByrJQaPpHiuasLSeNzw(int param_00009351) => default; // 0x0000000185BE9E80-0x0000000185BE9F20
			private void QAPCoPutXwDtlfjJrcwThAGgZLjR() {} // 0x0000000185BE87F0-0x0000000185BE8BF0
		}
	
		// Constructors
		public XboxOneInputSource() {} // 0x0000000185BEC870-0x0000000185BECA90
	
		// Methods
		public override void Update() {} // 0x0000000185BEC6F0-0x0000000185BEC870
		private void MQeqppLmuFFClKfqjGZhidlIQAb(uint param_00009340, bool param_00009341) {} // 0x0000000185BEC450-0x0000000185BEC5F0
		private void uliOsomhfgBbVCFjbEfSohVOtdIo(uint param_00009342, bool param_00009343) {} // 0x0000000185BECE10-0x0000000185BED0D0
		private void BDTeFhyViIWATqfkJBdOawJNAxbB() {} // 0x0000000185BEBFB0-0x0000000185BEC1D0
		private bool kWzBpAIAakIesbuGsYFjMIGuGdq(uint param_00009344, bool param_00009345, out BadConnectionReason param_00009346) {
			param_00009346 = default;
			return default;
		} // 0x0000000185BECAF0-0x0000000185BECE10
		public bool SetXboxOneVibration(ulong xboxOneJoystickId, lSVDqDVnIqWqaQvJeLzQNKaiGHr vibration) => default; // 0x0000000185BEC5F0-0x0000000185BEC6F0
		public override void Dispose() {} // 0x0000000185BEC310-0x0000000185BEC3A0
		~XboxOneInputSource() {} // 0x0000000185BEC3A0-0x0000000185BEC450
		protected override void Dispose(bool disposing) {} // 0x0000000185BEC1D0-0x0000000185BEC310
	}
}

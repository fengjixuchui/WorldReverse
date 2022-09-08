/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class CVRExtendedDisplay // TypeDefIndex: 6465
	{
		// Fields
		private IVRExtendedDisplay FnTable; // 0x10
	
		// Constructors
		public CVRExtendedDisplay() {} // Dummy constructor
		internal CVRExtendedDisplay(IntPtr pInterface) {} // 0x000000018646AFC0-0x000000018646B0E0
	
		// Methods
		public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight) {} // 0x000000018646AF10-0x000000018646AFC0
		public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight) {} // 0x000000018646AE50-0x000000018646AF10
		public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex) {} // 0x000000018646ADB0-0x000000018646AE50
	}
}

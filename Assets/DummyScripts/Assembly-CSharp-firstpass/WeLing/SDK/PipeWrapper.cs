/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using AOT;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WeLing.SDK
{
	public class PipeWrapper // TypeDefIndex: 8921
	{
		// Fields
		public static Action<string> OnReceiveDataEvent; // 0x00
	
		// Nested types
		public delegate void OnReceiveData(IntPtr data, ref int size); // TypeDefIndex: 8922; 0x000000018948D7E0-0x000000018948D9A0
	
		// Constructors
		public PipeWrapper() {} // 0x000000018948E0B0-0x000000018948E230
	
		// Methods
		private static extern bool Init(OnReceiveData cb); // 0x000000018948DB30-0x000000018948DC30
		private static extern bool SendData(byte[] data, int size); // 0x000000018948DDF0-0x000000018948DF00
		// [MonoPInvokeCallback] // 0x0000000189772290-0x0000000189772300
		// [XID] // 0x0000000189772290-0x0000000189772300
		private static void SimpleCallBackImp(IntPtr data, ref int size) {} // 0x000000018948DF00-0x000000018948E0B0
		// [XID] // 0x0000000189781430-0x0000000189781450
		public static bool InitPipe() => default; // 0x000000018948DA20-0x000000018948DB30
		// [XID] // 0x00000001897888C0-0x00000001897888E0
		public static bool SendDataToPipe(byte[] data, int size) => default; // 0x000000018948DD30-0x000000018948DDF0
		// [XID] // 0x0000000189790070-0x0000000189790090
		public static bool SendDataString(string dataString) => default; // 0x000000018948DC30-0x000000018948DD30
	}
}

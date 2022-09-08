/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal struct PidVid : IEquatable<Rewired.PidVid> // TypeDefIndex: 3516
	{
		// Fields
		public ushort productId; // 0x00
		public ushort vendorId; // 0x02
	
		// Constructors
		public PidVid(ushort productId, ushort vendorId) {
			this.productId = default;
			this.vendorId = default;
		} // 0x0000000185306CF0-0x0000000185306D70
		public PidVid(string pidVid) {
			productId = default;
			vendorId = default;
		} // 0x0000000185306C60-0x0000000185306CF0
		public PidVid(Guid productGuid) {
			productId = default;
			vendorId = default;
		} // 0x0000000185306AA0-0x0000000185306C60
	
		// Methods
		public bool Equals(string pidVid) => default; // 0x0000000185306650-0x00000001853066F0
		public Guid ToProductGuid() => default; // 0x0000000185306900-0x00000001853069F0
		private bool LIBrvMAFIoYaOKMYzZpjAtmhGuE(string param_00007d42) => default; // 0x0000000185306830-0x0000000185306900
		public override bool Equals(object obj) => default; // 0x00000001853065B0-0x0000000185306650
		public override int GetHashCode() => default; // 0x00000001853066F0-0x0000000185306830
		public bool Equals(PidVid other) => default; // 0x00000001853064D0-0x00000001853065B0
		public override string ToString() => default; // 0x00000001853069F0-0x0000000185306AA0
		public static bool ArrayContains(string[] pidVids, ref PidVid vidPid) => default; // 0x00000001853062D0-0x00000001853064D0
		private static string cIbBJXbDSIhuTcRzfCbOcwGNsZgC(string param_00007d47) => default; // 0x0000000185306D70-0x0000000185306F20
	}
}

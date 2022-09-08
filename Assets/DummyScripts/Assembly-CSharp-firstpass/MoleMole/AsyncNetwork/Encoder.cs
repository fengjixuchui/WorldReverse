/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole.AsyncNetwork
{
	public class Encoder // TypeDefIndex: 10671
	{
		// Fields
		private static readonly uint[] crcSet; // 0x00
		private int _encodeIndex; // 0x10
		private int _decodeIndex; // 0x14
		private uint _encodeKey; // 0x18
		private uint _decodeKey; // 0x1C
	
		// Constructors
		public Encoder() {} // 0x00000001869028D0-0x0000000186902940
		static Encoder() {} // 0x0000000186902830-0x00000001869028D0
	
		// Methods
		// [XID] // 0x00000001896ACE00-0x00000001896ACE20
		public void Reset() {} // 0x00000001869024B0-0x0000000186902560
		// [XID] // 0x0000000189658790-0x00000001896587B0
		public void SetEncodeIndex(byte value) {} // 0x0000000186902610-0x00000001869026C0
		// [XID] // 0x0000000189BBBD70-0x0000000189BBBD90
		public void SetDecodeIndex(byte value) {} // 0x0000000186902560-0x0000000186902610
		// [XID] // 0x0000000189BC3C10-0x0000000189BC3C30
		public void UpdateKey() {} // 0x00000001869026C0-0x0000000186902830
		// [XID] // 0x0000000189BCB3C0-0x0000000189BCB3E0
		public void Encode(byte[] data) {} // 0x0000000186902330-0x00000001869024B0
		// [XID] // 0x0000000189A217B0-0x0000000189A217D0
		public void Decode(byte[] data) {} // 0x0000000186902190-0x0000000186902330
	}
}

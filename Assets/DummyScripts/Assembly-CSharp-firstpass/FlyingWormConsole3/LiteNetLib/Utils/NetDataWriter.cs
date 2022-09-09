﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	public class NetDataWriter // TypeDefIndex: 6904
	{
		// Fields
		protected byte[] _data; // 0x10
		protected int _position; // 0x18
		private int _maxLength; // 0x1C
		private readonly bool _autoResize; // 0x20
	
		// Properties
		public byte[] Data { /* [XID] */ /* 0x0000000189B2A4E0-0x0000000189B2A500 */ get => default; } // 0x0000000186B44960-0x0000000186B44A00 
		public int Length { /* [XID] */ /* 0x0000000189B31AA0-0x0000000189B31AC0 */ get => default; } // 0x0000000186B44A00-0x0000000186B44AA0 
	
		// Constructors
		public NetDataWriter() {} // 0x0000000186B44810-0x0000000186B448B0
		public NetDataWriter(bool autoResize) {} // 0x0000000186B448B0-0x0000000186B44960
		public NetDataWriter(bool autoResize, int initialSize) {} // 0x0000000186B44760-0x0000000186B44810
	
		// Methods
		// [XID] // 0x0000000189B22E90-0x0000000189B22EB0
		public void ResizeIfNeed(int newSize) {} // 0x0000000186B44690-0x0000000186B44760
		// [IDTag] // 0x000000018989B610-0x000000018989B650
		// [XID] // 0x000000018989B610-0x000000018989B650
		public void Reset(int size) {} // 0x0000000186B445D0-0x0000000186B44690
		// [IDTag] // 0x00000001898A5CD0-0x00000001898A5D10
		// [XID] // 0x00000001898A5CD0-0x00000001898A5D10
		public void Reset() {} // 0x0000000186B44530-0x0000000186B445D0
		// [XID] // 0x00000001898B0380-0x00000001898B03A0
		public byte[] CopyData() => default; // 0x0000000186B42370-0x0000000186B42460
		// [IDTag] // 0x00000001898C68D0-0x00000001898C6910
		// [XID] // 0x00000001898C68D0-0x00000001898C6910
		public void Put(float value) {} // 0x0000000186B43630-0x0000000186B43710
		// [IDTag] // 0x00000001898D1120-0x00000001898D1160
		// [XID] // 0x00000001898D1120-0x00000001898D1160
		public void Put(double value) {} // 0x0000000186B43AE0-0x0000000186B43BC0
		// [IDTag] // 0x00000001898DB8B0-0x00000001898DB8F0
		// [XID] // 0x00000001898DB8B0-0x00000001898DB8F0
		public void Put(long value) {} // 0x0000000186B44450-0x0000000186B44530
		// [IDTag] // 0x00000001898E66C0-0x00000001898E6700
		// [XID] // 0x00000001898E66C0-0x00000001898E6700
		public void Put(ulong value) {} // 0x0000000186B44370-0x0000000186B44450
		// [IDTag] // 0x00000001898F1100-0x00000001898F1140
		// [XID] // 0x00000001898F1100-0x00000001898F1140
		public void Put(int value) {} // 0x0000000186B43900-0x0000000186B439E0
		// [IDTag] // 0x00000001898FB540-0x00000001898FB580
		// [XID] // 0x00000001898FB540-0x00000001898FB580
		public void Put(uint value) {} // 0x0000000186B441B0-0x0000000186B44290
		// [IDTag] // 0x0000000189906050-0x0000000189906090
		// [XID] // 0x0000000189906050-0x0000000189906090
		public void Put(ushort value) {} // 0x0000000186B44290-0x0000000186B44370
		// [IDTag] // 0x0000000189910670-0x00000001899106B0
		// [XID] // 0x0000000189910670-0x00000001899106B0
		public void Put(short value) {} // 0x0000000186B43CB0-0x0000000186B43D90
		// [IDTag] // 0x000000018991B550-0x000000018991B590
		// [XID] // 0x000000018991B550-0x000000018991B590
		public void Put(sbyte value) {} // 0x0000000186B43BC0-0x0000000186B43CB0
		// [IDTag] // 0x0000000189925BF0-0x0000000189925C30
		// [XID] // 0x0000000189925BF0-0x0000000189925C30
		public void Put(byte value) {} // 0x0000000186B43EA0-0x0000000186B43F90
		// [IDTag] // 0x0000000189930110-0x0000000189930150
		// [XID] // 0x0000000189930110-0x0000000189930150
		public void Put(byte[] data, int offset, int length) {} // 0x0000000186B43D90-0x0000000186B43EA0
		// [IDTag] // 0x000000018993ABF0-0x000000018993AC30
		// [XID] // 0x000000018993ABF0-0x000000018993AC30
		public void Put(byte[] data) {} // 0x0000000186B437F0-0x0000000186B43900
		// [IDTag] // 0x0000000189944ED0-0x0000000189944F10
		// [XID] // 0x0000000189944ED0-0x0000000189944F10
		public void PutBytesWithLength(byte[] data, int offset, int length) {} // 0x0000000186B431F0-0x0000000186B43310
		// [IDTag] // 0x000000018994F570-0x000000018994F5B0
		// [XID] // 0x000000018994F570-0x000000018994F5B0
		public void PutBytesWithLength(byte[] data) {} // 0x0000000186B43310-0x0000000186B43430
		// [IDTag] // 0x0000000189959CD0-0x0000000189959D10
		// [XID] // 0x0000000189959CD0-0x0000000189959D10
		public void Put(bool value) {} // 0x0000000186B439E0-0x0000000186B43AE0
		// [IDTag] // 0x00000001899644D0-0x0000000189964510
		// [XID] // 0x00000001899644D0-0x0000000189964510
		public void PutArray(float[] value) {} // 0x0000000186B42960-0x0000000186B42AA0
		// [IDTag] // 0x000000018996E930-0x000000018996E970
		// [XID] // 0x000000018996E930-0x000000018996E970
		public void PutArray(double[] value) {} // 0x0000000186B42F70-0x0000000186B430B0
		// [IDTag] // 0x00000001899799C0-0x0000000189979A00
		// [XID] // 0x00000001899799C0-0x0000000189979A00
		public void PutArray(long[] value) {} // 0x0000000186B425A0-0x0000000186B426E0
		// [IDTag] // 0x0000000189983E10-0x0000000189983E50
		// [XID] // 0x0000000189983E10-0x0000000189983E50
		public void PutArray(ulong[] value) {} // 0x0000000186B42CF0-0x0000000186B42E30
		// [IDTag] // 0x000000018998E6F0-0x000000018998E730
		// [XID] // 0x000000018998E6F0-0x000000018998E730
		public void PutArray(int[] value) {} // 0x0000000186B426E0-0x0000000186B42820
		// [IDTag] // 0x0000000189999490-0x00000001899994D0
		// [XID] // 0x0000000189999490-0x00000001899994D0
		public void PutArray(uint[] value) {} // 0x0000000186B42BB0-0x0000000186B42CF0
		// [IDTag] // 0x00000001899A3E00-0x00000001899A3E40
		// [XID] // 0x00000001899A3E00-0x00000001899A3E40
		public void PutArray(ushort[] value) {} // 0x0000000186B42820-0x0000000186B42960
		// [IDTag] // 0x00000001899AE600-0x00000001899AE640
		// [XID] // 0x00000001899AE600-0x00000001899AE640
		public void PutArray(short[] value) {} // 0x0000000186B42460-0x0000000186B425A0
		// [IDTag] // 0x00000001899B8CB0-0x00000001899B8CF0
		// [XID] // 0x00000001899B8CB0-0x00000001899B8CF0
		public void PutArray(bool[] value) {} // 0x0000000186B430B0-0x0000000186B431F0
		// [IDTag] // 0x00000001899C38E0-0x00000001899C3920
		// [XID] // 0x00000001899C38E0-0x00000001899C3920
		public void PutArray(string[] value) {} // 0x0000000186B42AA0-0x0000000186B42BB0
		// [IDTag] // 0x00000001899CDDF0-0x00000001899CDE30
		// [XID] // 0x00000001899CDDF0-0x00000001899CDE30
		public void PutArray(string[] value, int maxLength) {} // 0x0000000186B42E30-0x0000000186B42F70
		// [IDTag] // 0x00000001899D83D0-0x00000001899D8410
		// [XID] // 0x00000001899D83D0-0x00000001899D8410
		public void Put(NetEndPoint endPoint) {} // 0x0000000186B43710-0x0000000186B437F0
		// [IDTag] // 0x00000001899E2A60-0x00000001899E2AA0
		// [XID] // 0x00000001899E2A60-0x00000001899E2AA0
		public void Put(string value) {} // 0x0000000186B43430-0x0000000186B43630
		// [IDTag] // 0x00000001899ED0C0-0x00000001899ED100
		// [XID] // 0x00000001899ED0C0-0x00000001899ED100
		public void Put(string value, int maxLength) {} // 0x0000000186B43F90-0x0000000186B441B0
	}
}
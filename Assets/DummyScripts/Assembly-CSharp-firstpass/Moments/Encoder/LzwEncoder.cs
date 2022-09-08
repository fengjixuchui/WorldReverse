/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Moments.Encoder
{
	public class LzwEncoder // TypeDefIndex: 7561
	{
		// Fields
		private static readonly int EOF; // 0x00
		private byte[] pixAry; // 0x10
		private int initCodeSize; // 0x18
		private int curPixel; // 0x1C
		private static readonly int BITS; // 0x04
		private static readonly int HSIZE; // 0x08
		private int n_bits; // 0x20
		private int maxbits; // 0x24
		private int maxcode; // 0x28
		private int maxmaxcode; // 0x2C
		private int[] htab; // 0x30
		private int[] codetab; // 0x38
		private int hsize; // 0x40
		private int free_ent; // 0x44
		private bool clear_flg; // 0x48
		private int g_init_bits; // 0x4C
		private int ClearCode; // 0x50
		private int EOFCode; // 0x54
		private int cur_accum; // 0x58
		private int cur_bits; // 0x5C
		private int[] masks; // 0x60
		private int a_count; // 0x68
		private byte[] accum; // 0x70
	
		// Constructors
		public LzwEncoder() {} // Dummy constructor
		public LzwEncoder(int width, int height, byte[] pixels, int color_depth) {} // 0x0000000186081FA0-0x0000000186082150
		static LzwEncoder() {} // 0x0000000186081F10-0x0000000186081FA0
	
		// Methods
		// [XID] // 0x000000018964FA30-0x000000018964FA50
		private void Add(byte c, Stream outs) {} // 0x0000000186081230-0x0000000186081340
		// [XID] // 0x0000000189657340-0x0000000189657360
		private void ClearTable(Stream outs) {} // 0x0000000186081340-0x0000000186081410
		// [XID] // 0x000000018965E9B0-0x000000018965E9D0
		private void ResetCodeTable(int hsize) {} // 0x0000000186081E20-0x0000000186081F10
		// [XID] // 0x00000001898C4F40-0x00000001898C4F60
		private void Compress(int init_bits, Stream outs) {} // 0x0000000186081410-0x00000001860817E0
		// [XID] // 0x000000018966D810-0x000000018966D830
		public void Encode(Stream os) {} // 0x00000001860817E0-0x0000000186081920
		// [XID] // 0x0000000189675710-0x0000000189675730
		private void Flush(Stream outs) {} // 0x0000000186081920-0x0000000186081A60
		// [XID] // 0x000000018967CE80-0x000000018967CEA0
		private int MaxCode(int n_bits) => default; // 0x0000000186081A60-0x0000000186081B20
		// [XID] // 0x00000001895F9A80-0x00000001895F9AA0
		private int NextPixel() => default; // 0x0000000186081B20-0x0000000186081C40
		// [XID] // 0x000000018968C0C0-0x000000018968C0E0
		private void Output(int code, Stream outs) {} // 0x0000000186081C40-0x0000000186081E20
	}
}

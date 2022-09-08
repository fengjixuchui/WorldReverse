/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Moments.Encoder
{
	public class NeuQuant // TypeDefIndex: 7562
	{
		// Fields
		protected static readonly int netsize; // 0x00
		protected static readonly int prime1; // 0x04
		protected static readonly int prime2; // 0x08
		protected static readonly int prime3; // 0x0C
		protected static readonly int prime4; // 0x10
		protected static readonly int minpicturebytes; // 0x14
		protected static readonly int maxnetpos; // 0x18
		protected static readonly int netbiasshift; // 0x1C
		protected static readonly int ncycles; // 0x20
		protected static readonly int intbiasshift; // 0x24
		protected static readonly int intbias; // 0x28
		protected static readonly int gammashift; // 0x2C
		protected static readonly int gamma; // 0x30
		protected static readonly int betashift; // 0x34
		protected static readonly int beta; // 0x38
		protected static readonly int betagamma; // 0x3C
		protected static readonly int initrad; // 0x40
		protected static readonly int radiusbiasshift; // 0x44
		protected static readonly int radiusbias; // 0x48
		protected static readonly int initradius; // 0x4C
		protected static readonly int radiusdec; // 0x50
		protected static readonly int alphabiasshift; // 0x54
		protected static readonly int initalpha; // 0x58
		protected int alphadec; // 0x10
		protected static readonly int radbiasshift; // 0x5C
		protected static readonly int radbias; // 0x60
		protected static readonly int alpharadbshift; // 0x64
		protected static readonly int alpharadbias; // 0x68
		protected byte[] thepicture; // 0x18
		protected int lengthcount; // 0x20
		protected int samplefac; // 0x24
		protected int[][] network; // 0x28
		protected int[] netindex; // 0x30
		protected int[] bias; // 0x38
		protected int[] freq; // 0x40
		protected int[] radpower; // 0x48
	
		// Constructors
		public NeuQuant() {} // Dummy constructor
		public NeuQuant(byte[] thepic, int len, int sample) {} // 0x00000001860858E0-0x0000000186085C80
		static NeuQuant() {} // 0x0000000186085610-0x00000001860858E0
	
		// Methods
		// [XID] // 0x0000000189693B90-0x0000000189693BB0
		public byte[] ColorMap() => default; // 0x0000000186083B10-0x0000000186083EF0
		// [XID] // 0x000000018989F500-0x000000018989F520
		public void Inxbuild() {} // 0x0000000186084310-0x0000000186084840
		// [XID] // 0x00000001896A2A20-0x00000001896A2A40
		public void Learn() {} // 0x0000000186084840-0x0000000186084ED0
		// [XID] // 0x00000001896A9D90-0x00000001896A9DB0
		public int Map(int b, int g, int r) => default; // 0x0000000186084ED0-0x00000001860852A0
		// [XID] // 0x00000001896B0BC0-0x00000001896B0BE0
		public byte[] Process() => default; // 0x00000001860852A0-0x0000000186085370
		// [XID] // 0x00000001896B8810-0x00000001896B8830
		public void Unbiasnet() {} // 0x0000000186085370-0x0000000186085610
		// [XID] // 0x00000001896BF890-0x00000001896BF8B0
		protected void Alterneigh(int rad, int i, int b, int g, int r) {} // 0x00000001860834F0-0x0000000186083920
		// [XID] // 0x00000001896C7370-0x00000001896C7390
		protected void Altersingle(int alpha, int i, int b, int g, int r) {} // 0x0000000186083920-0x0000000186083B10
		// [XID] // 0x00000001896CE960-0x00000001896CE980
		protected int Contest(int b, int g, int r) => default; // 0x0000000186083EF0-0x0000000186084310
	}
}

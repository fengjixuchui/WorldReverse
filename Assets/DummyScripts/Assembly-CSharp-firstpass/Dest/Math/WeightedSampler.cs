/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Dest.Math
{
	public class WeightedSampler // TypeDefIndex: 8183
	{
		// Fields
		protected float[] _accum; // 0x10
		protected float _total; // 0x18
		protected Rand _rand; // 0x20
	
		// Constructors
		public WeightedSampler() {} // Dummy constructor
		protected WeightedSampler(Rand rand) {} // 0x00000001874C1E90-0x00000001874C1F00
		public WeightedSampler(float[] weights) {} // 0x00000001874C1F00-0x00000001874C1FC0
		public WeightedSampler(float[] weights, Rand rand) {} // 0x00000001874C1FC0-0x00000001874C2300
	
		// Methods
		// [XID] // 0x0000000189B2AF20-0x0000000189B2AF40
		protected static int BinarySearch(float[] array, float value) => default; // 0x00000001874C1AA0-0x00000001874C1BB0
		// [XID] // 0x0000000189A80D50-0x0000000189A80D70
		protected void Init(float[] weights) {} // 0x00000001874C1BB0-0x00000001874C1DB0
		// [XID] // 0x000000018969D610-0x000000018969D630
		public int SampleIndex() => default; // 0x00000001874C1DB0-0x00000001874C1E90
	}
}

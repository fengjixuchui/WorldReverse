/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	internal class RandomGenerator // TypeDefIndex: 27414
	{
		// Fields
		private static RandomGenerator Instance; // 0x00
		private uint m_seed; // 0x10
	
		// Constructors
		public RandomGenerator() {} // Dummy constructor
		protected RandomGenerator(uint seed) {} // 0x0000000186DF1040-0x0000000186DF10B0
		static RandomGenerator() {} // 0x0000000186DF0FE0-0x0000000186DF1040
	
		// Methods
		public static RandomGenerator GetInstance() => default; // 0x0000000186DF0D20-0x0000000186DF0E70
		public float GetRandom() => default; // 0x0000000186DF0E70-0x0000000186DF0EF0
		public float InRange(float low, float high) => default; // 0x0000000186DF0EF0-0x0000000186DF0F80
		public void SetSeed(uint seed) {} // 0x0000000186DF0F80-0x0000000186DF0FE0
	}
}

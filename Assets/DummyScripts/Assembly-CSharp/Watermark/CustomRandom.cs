/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace Watermark
{
	[Serializable]
	public class CustomRandom : Random // TypeDefIndex: 32207
	{
		// Fields
		public const int MAX = 1000000000; // Metadata: 0x00B142B1
		private int[] _state; // 0x20
		private int _pos; // 0x28
	
		// Constructors
		public CustomRandom() {} // 0x000000018648BB20-0x000000018648BB90
		public CustomRandom(int seed) {} // 0x000000018648BB90-0x000000018648BE40
	
		// Methods
		public override int Next() => default; // 0x000000018648BA30-0x000000018648BAA0
		public override int Next(int minValue, int maxValue) => default; // 0x000000018648B920-0x000000018648BA30
		public override void NextBytes(byte[] buffer) {} // 0x000000018648B830-0x000000018648B920
		protected override double Sample() => default; // 0x000000018648BAA0-0x000000018648BB20
		private int Mod(int n) => default; // 0x000000018648B790-0x000000018648B830
		private int InternalSample() => default; // 0x000000018648B630-0x000000018648B790
	}
}

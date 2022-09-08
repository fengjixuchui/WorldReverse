/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Math;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Math.Prime.Generator
{
	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 1039
	{
		// Constructors
		public SequentialSearchPrimeGeneratorBase() {} // 0x00000001873C57A0-0x00000001873C5840
	
		// Methods
		protected virtual BigInteger GenerateSearchBase(int bits, object context) => default; // 0x00000001873C56B0-0x00000001873C5750
		public override BigInteger GenerateNewPrime(int bits) => default; // 0x00000001873C5630-0x00000001873C56B0
		public virtual BigInteger GenerateNewPrime(int bits, object context) => default; // 0x00000001873C52E0-0x00000001873C5630
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) => default; // 0x00000001873C5750-0x00000001873C57A0
	}
}

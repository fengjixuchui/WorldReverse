/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Math;
using Mono.Math.Prime;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Math.Prime.Generator
{
	public abstract class PrimeGeneratorBase // TypeDefIndex: 1038
	{
		// Properties
		public virtual ConfidenceFactor Confidence { get; } // 0x00000001873C13C0-0x00000001873C1410 
		public virtual PrimalityTest PrimalityTest { get; } // 0x00000001873C1410-0x00000001873C14D0 
		public virtual int TrialDivisionBounds { get; } // 0x00000001873C14D0-0x00000001873C1520 
	
		// Constructors
		protected PrimeGeneratorBase() {} // 0x00000001873C1360-0x00000001873C13C0
	
		// Methods
		public abstract BigInteger GenerateNewPrime(int bits);
	}
}

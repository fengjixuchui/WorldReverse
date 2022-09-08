/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AkShortIdGenerator // TypeDefIndex: 32213
{
	// Fields
	private const uint PRIME_32 = 16777619; // Metadata: 0x00B142B6
	private const uint OFFSET_BASIS_32 = 2166136261; // Metadata: 0x00B142BA
	private const ulong PRIME_64 = 1099511628211; // Metadata: 0x00B142BE
	private const ulong OFFSET_BASIS_64 = 14695981039346656037; // Metadata: 0x00B142C6
	private const int INIT_BUFFER_SIZE = 1024; // Metadata: 0x00B142CE
	private static byte _hashSize32; // 0x00
	private static uint _mask32; // 0x04
	private static byte _hashSize64; // 0x08
	private static ulong _mask64; // 0x10

	// Properties
	public static byte HashSize32 { get; set; } // 0x0000000185959320-0x00000001859593B0 0x00000001859594F0-0x00000001859595A0
	public static byte HashSize64 { get; set; } // 0x00000001859593B0-0x0000000185959440 0x00000001859595A0-0x0000000185959650
	public static uint InvalidId32 { get; } // 0x0000000185959440-0x0000000185959490 
	public static ulong InvalidId64 { get; } // 0x0000000185959490-0x00000001859594F0 

	// Constructors
	static AkShortIdGenerator() {} // 0x00000001859592C0-0x0000000185959320

	// Methods
	public static uint Compute(string text) => default; // 0x0000000185959190-0x00000001859592C0
	public static ulong Compute64(string text) => default; // 0x0000000185959040-0x0000000185959190
	public static unsafe ulong Compute64(char* pText, int charCount) => default; // 0x0000000185958F00-0x0000000185959040
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CriMana
{
	public class MovieInfo // TypeDefIndex: 7151
	{
		// Fields
		private uint _reserved1; // 0x10
		private uint _hasAlpha; // 0x14
		public uint width; // 0x18
		public uint height; // 0x1C
		public uint dispWidth; // 0x20
		public uint dispHeight; // 0x24
		public uint framerateN; // 0x28
		public uint framerateD; // 0x2C
		public uint totalFrames; // 0x30
		private uint _codecType; // 0x34
		private uint _alphaCodecType; // 0x38
		public uint numAudioStreams; // 0x3C
		public AudioInfo[] audioPrm; // 0x40
		public uint numSubtitleChannels; // 0x48
		public uint maxSubtitleSize; // 0x4C
		public uint maxChunkSize; // 0x50
	
		// Properties
		public bool hasAlpha { /* [XID] */ /* 0x000000018961B4A0-0x000000018961B4C0 */ get => default; /* [XID] */ /* 0x0000000189622B00-0x0000000189622B20 */ set {} } // 0x0000000187A3AC10-0x0000000187A3ACC0 0x0000000187A3AE20-0x0000000187A3B150
		public CodecType codecType { /* [XID] */ /* 0x000000018962A360-0x000000018962A380 */ get => default; /* [XID] */ /* 0x0000000189631AE0-0x0000000189631B00 */ set {} } // 0x0000000187A3AB70-0x0000000187A3AC10 0x0000000187A3AD70-0x0000000187A3AE20
		public CodecType alphaCodecType { /* [XID] */ /* 0x0000000189639630-0x0000000189639650 */ get => default; /* [XID] */ /* 0x00000001899C3730-0x00000001899C3750 */ set {} } // 0x0000000187A3AAD0-0x0000000187A3AB70 0x0000000187A3ACC0-0x0000000187A3AD70
	
		// Constructors
		public MovieInfo() {} // 0x0000000187A3AA70-0x0000000187A3AAD0
	}
}

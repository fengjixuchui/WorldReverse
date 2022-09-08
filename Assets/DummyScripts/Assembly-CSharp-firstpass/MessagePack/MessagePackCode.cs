/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack
{
	public static class MessagePackCode // TypeDefIndex: 8425
	{
		// Fields
		public const byte MinFixInt = 0; // Metadata: 0x00ADF6F2
		public const byte MaxFixInt = 127; // Metadata: 0x00ADF6F3
		public const byte MinFixMap = 128; // Metadata: 0x00ADF6F4
		public const byte MaxFixMap = 143; // Metadata: 0x00ADF6F5
		public const byte MinFixArray = 144; // Metadata: 0x00ADF6F6
		public const byte MaxFixArray = 159; // Metadata: 0x00ADF6F7
		public const byte MinFixStr = 160; // Metadata: 0x00ADF6F8
		public const byte MaxFixStr = 191; // Metadata: 0x00ADF6F9
		public const byte Nil = 192; // Metadata: 0x00ADF6FA
		public const byte NeverUsed = 193; // Metadata: 0x00ADF6FB
		public const byte False = 194; // Metadata: 0x00ADF6FC
		public const byte True = 195; // Metadata: 0x00ADF6FD
		public const byte Bin8 = 196; // Metadata: 0x00ADF6FE
		public const byte Bin16 = 197; // Metadata: 0x00ADF6FF
		public const byte Bin32 = 198; // Metadata: 0x00ADF700
		public const byte Ext8 = 199; // Metadata: 0x00ADF701
		public const byte Ext16 = 200; // Metadata: 0x00ADF702
		public const byte Ext32 = 201; // Metadata: 0x00ADF703
		public const byte Float32 = 202; // Metadata: 0x00ADF704
		public const byte Float64 = 203; // Metadata: 0x00ADF705
		public const byte UInt8 = 204; // Metadata: 0x00ADF706
		public const byte UInt16 = 205; // Metadata: 0x00ADF707
		public const byte UInt32 = 206; // Metadata: 0x00ADF708
		public const byte UInt64 = 207; // Metadata: 0x00ADF709
		public const byte Int8 = 208; // Metadata: 0x00ADF70A
		public const byte Int16 = 209; // Metadata: 0x00ADF70B
		public const byte Int32 = 210; // Metadata: 0x00ADF70C
		public const byte Int64 = 211; // Metadata: 0x00ADF70D
		public const byte FixExt1 = 212; // Metadata: 0x00ADF70E
		public const byte FixExt2 = 213; // Metadata: 0x00ADF70F
		public const byte FixExt4 = 214; // Metadata: 0x00ADF710
		public const byte FixExt8 = 215; // Metadata: 0x00ADF711
		public const byte FixExt16 = 216; // Metadata: 0x00ADF712
		public const byte Str8 = 217; // Metadata: 0x00ADF713
		public const byte Str16 = 218; // Metadata: 0x00ADF714
		public const byte Str32 = 219; // Metadata: 0x00ADF715
		public const byte Array16 = 220; // Metadata: 0x00ADF716
		public const byte Array32 = 221; // Metadata: 0x00ADF717
		public const byte Map16 = 222; // Metadata: 0x00ADF718
		public const byte Map32 = 223; // Metadata: 0x00ADF719
		public const byte MinNegativeFixInt = 224; // Metadata: 0x00ADF71A
		public const byte MaxNegativeFixInt = 255; // Metadata: 0x00ADF71B
		private static readonly MessagePackType[] typeLookupTable; // 0x00
		private static readonly string[] formatNameTable; // 0x08
	
		// Constructors
		static MessagePackCode() {} // 0x00000001859E1370-0x00000001859E2F30
	
		// Methods
		// [XID] // 0x000000018969A110-0x000000018969A130
		public static MessagePackType ToMessagePackType(byte code) => default; // 0x00000001859E1270-0x00000001859E1370
		// [XID] // 0x0000000189854F30-0x0000000189854F50
		public static string ToFormatName(byte code) => default; // 0x00000001859E1170-0x00000001859E1270
	}
}

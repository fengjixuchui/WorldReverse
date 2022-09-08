/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole.AsyncNetwork
{
	public class StreamException : Exception // TypeDefIndex: 10675
	{
		// Constructors
		public StreamException() {} // 0x0000000186905970-0x00000001869059D0
	
		// Methods
		// [XID] // 0x0000000189A37E30-0x0000000189A37E50
		public static StreamException InvalidStream() => default; // 0x00000001869054C0-0x00000001869055B0
		// [XID] // 0x0000000189661620-0x0000000189661640
		public static StreamException TruncatedMessage() => default; // 0x0000000186905880-0x0000000186905970
		// [XID] // 0x0000000189A46B90-0x0000000189A46BB0
		internal static StreamException NegativeSize() => default; // 0x00000001869056A0-0x0000000186905790
		// [XID] // 0x0000000189670BE0-0x0000000189670C00
		internal static StreamException InvalidSize() => default; // 0x00000001869053D0-0x00000001869054C0
		// [XID] // 0x0000000189678430-0x0000000189678450
		public static StreamException MalformedVarint() => default; // 0x00000001869055B0-0x00000001869056A0
		// [XID] // 0x0000000189A5D3E0-0x0000000189A5D400
		public static StreamException RecursionLimitExceeded() => default; // 0x0000000186905790-0x0000000186905880
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing.Common;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Aztec.Internal
{
	public sealed class HighLevelEncoder // TypeDefIndex: 4666
	{
		// Fields
		internal static string[] MODE_NAMES; // 0x00
		internal static readonly int[][] LATCH_TABLE; // 0x08
		internal static readonly int[][] CHAR_MAP; // 0x10
		internal static readonly int[][] SHIFT_TABLE; // 0x18
		private readonly byte[] text; // 0x10
	
		// Constructors
		public HighLevelEncoder() {} // Dummy constructor
		static HighLevelEncoder() {} // 0x0000000186AF7AB0-0x0000000186AF8EB0
		public HighLevelEncoder(byte[] text) {} // 0x0000000186AF8EB0-0x0000000186AF8F20
	
		// Methods
		public BitArray encode() => default; // 0x0000000186AF9A90-0x0000000186AF9E70
		private ICollection<State> updateStateListForChar(IEnumerable<State> states, int index) => default; // 0x0000000186AFBE90-0x0000000186AFC100
		private void updateStateForChar(State state, int index, ICollection<State> result) {} // 0x0000000186AFB770-0x0000000186AFBC50
		private static ICollection<State> updateStateListForPair(IEnumerable<State> states, int index, int pairCode) => default; // 0x0000000186AFC100-0x0000000186AFC2D0
		private static void updateStateForPair(State state, int index, int pairCode, ICollection<State> result) {} // 0x0000000186AFBC50-0x0000000186AFBE90
		private static ICollection<State> simplifyStates(IEnumerable<State> states) => default; // 0x0000000186AFB350-0x0000000186AFB770
	}
}

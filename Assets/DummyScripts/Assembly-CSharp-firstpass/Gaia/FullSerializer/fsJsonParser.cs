/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public class fsJsonParser // TypeDefIndex: 9254
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		public fsJsonParser() {} // Dummy constructor
		private fsJsonParser(string input) {} // 0x0000000186B54030-0x0000000186B540E0
	
		// Methods
		// [XID] // 0x00000001895ECC80-0x00000001895ECCA0
		private fsResult MakeFailure(string message) => default; // 0x0000000186B513F0-0x0000000186B51760
		// [XID] // 0x00000001895EEE00-0x00000001895EEE20
		private bool TryMoveNext() => default; // 0x0000000186B52250-0x0000000186B52320
		// [IDTag] // 0x000000018965BBD0-0x000000018965BC10
		// [XID] // 0x000000018965BBD0-0x000000018965BC10
		private bool HasValue() => default; // 0x0000000186B51070-0x0000000186B51120
		// [IDTag] // 0x0000000189666000-0x0000000189666040
		// [XID] // 0x0000000189666000-0x0000000189666040
		private bool HasValue(int offset) => default; // 0x0000000186B51120-0x0000000186B51210
		// [IDTag] // 0x0000000189670E50-0x0000000189670E90
		// [XID] // 0x0000000189670E50-0x0000000189670E90
		private char Character() => default; // 0x0000000186B50EF0-0x0000000186B50FA0
		// [IDTag] // 0x000000018967B520-0x000000018967B560
		// [XID] // 0x000000018967B520-0x000000018967B560
		private char Character(int offset) => default; // 0x0000000186B50FA0-0x0000000186B51070
		// [XID] // 0x0000000189685CB0-0x0000000189685CD0
		private void SkipSpace() {} // 0x0000000186B51FB0-0x0000000186B52250
		// [XID] // 0x000000018968D650-0x000000018968D670
		private bool IsHex(char c) => default; // 0x0000000186B51210-0x0000000186B512F0
		// [XID] // 0x00000001897A7520-0x00000001897A7540
		private uint ParseSingleChar(char c1, uint multipliyer) => default; // 0x0000000186B51760-0x0000000186B51870
		// [XID] // 0x000000018969C8D0-0x000000018969C8F0
		private uint ParseUnicode(char c1, char c2, char c3, char c4) => default; // 0x0000000186B51870-0x0000000186B519B0
		// [XID] // 0x00000001898FFFC0-0x00000001898FFFE0
		private fsResult TryUnescapeChar(out char escaped) {
			escaped = default;
			return default;
		} // 0x0000000186B53A40-0x0000000186B54030
		// [XID] // 0x00000001896AB200-0x00000001896AB220
		private fsResult TryParseExact(string content) => default; // 0x0000000186B525F0-0x0000000186B52810
		// [XID] // 0x00000001898B82E0-0x00000001898B8300
		private fsResult TryParseTrue(out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B53830-0x0000000186B53A40
		// [XID] // 0x00000001896B9CE0-0x00000001896B9D00
		private fsResult TryParseFalse(out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B52810-0x0000000186B52A20
		// [XID] // 0x0000000189B9D5A0-0x0000000189B9D5C0
		private fsResult TryParseNull(out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B52A20-0x0000000186B52C20
		// [XID] // 0x00000001896C8640-0x00000001896C8660
		private bool IsSeparator(char c) => default; // 0x0000000186B512F0-0x0000000186B513F0
		// [XID] // 0x00000001896D0030-0x00000001896D0050
		private fsResult TryParseNumber(out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B52C20-0x0000000186B53070
		// [XID] // 0x00000001896D7440-0x00000001896D7460
		private fsResult TryParseString(out string str) {
			str = default;
			return default;
		} // 0x0000000186B534B0-0x0000000186B53830
		// [XID] // 0x00000001896DEDC0-0x00000001896DEDE0
		private fsResult TryParseArray(out fsData arr) {
			arr = default;
			return default;
		} // 0x0000000186B52320-0x0000000186B525F0
		// [XID] // 0x0000000189A02830-0x0000000189A02850
		private fsResult TryParseObject(out fsData obj) {
			obj = default;
			return default;
		} // 0x0000000186B53070-0x0000000186B534B0
		// [XID] // 0x0000000189A45450-0x0000000189A45470
		private fsResult RunParse(out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B51C50-0x0000000186B51FB0
		// [IDTag] // 0x00000001896F4EA0-0x00000001896F4EE0
		// [XID] // 0x00000001896F4EA0-0x00000001896F4EE0
		public static fsResult Parse(string input, out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B51AB0-0x0000000186B51C50
		// [IDTag] // 0x00000001896FF6B0-0x00000001896FF6F0
		// [XID] // 0x00000001896FF6B0-0x00000001896FF6F0
		public static fsData Parse(string input) => default; // 0x0000000186B519B0-0x0000000186B51AB0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	[Serializable]
	public sealed class Cookie // TypeDefIndex: 10246
	{
		// Fields
		private string _comment; // 0x10
		private Uri _commentUri; // 0x18
		private bool _discard; // 0x20
		private string _domain; // 0x28
		private static readonly int[] _emptyPorts; // 0x00
		private DateTime _expires; // 0x30
		private bool _httpOnly; // 0x40
		private string _name; // 0x48
		private string _path; // 0x50
		private string _port; // 0x58
		private int[] _ports; // 0x60
		private static readonly char[] _reservedCharsForValue; // 0x08
		private string _sameSite; // 0x68
		private bool _secure; // 0x70
		private DateTime _timeStamp; // 0x78
		private string _value; // 0x88
		private int _version; // 0x90
	
		// Properties
		internal bool ExactDomain { /* [XID] */ /* 0x000000018987E310-0x000000018987E330 */ get => default; } // 0x0000000186702260-0x0000000186702340 
		internal int MaxAge { /* [XID] */ /* 0x0000000189885310-0x0000000189885330 */ get => default; /* [XID] */ /* 0x000000018995B130-0x000000018995B150 */ set {} } // 0x0000000186702620-0x0000000186702820 0x0000000186703640-0x0000000186703790
		internal int[] Ports { /* [XID] */ /* 0x0000000189893CF0-0x0000000189893D10 */ get => default; } // 0x0000000186702A00-0x0000000186702AE0 
		internal string SameSite { /* [XID] */ /* 0x000000018989B490-0x000000018989B4B0 */ get => default; /* [XID] */ /* 0x00000001899A0A50-0x00000001899A0A70 */ set {} } // 0x0000000186702AE0-0x0000000186702B80 0x0000000186703B70-0x0000000186703C20
		public string Comment { /* [XID] */ /* 0x0000000189708CC0-0x0000000189708CE0 */ get => default; /* [XID] */ /* 0x00000001898B1870-0x00000001898B1890 */ internal set {} } // 0x0000000186702080-0x0000000186702120 0x0000000186703160-0x0000000186703210
		public Uri CommentUri { /* [XID] */ /* 0x00000001898B9320-0x00000001898B9340 */ get => default; /* [XID] */ /* 0x00000001897F2B10-0x00000001897F2B30 */ internal set {} } // 0x0000000186701FE0-0x0000000186702080 0x00000001867030B0-0x0000000186703160
		public bool Discard { /* [XID] */ /* 0x00000001899D00D0-0x00000001899D00F0 */ get => default; /* [XID] */ /* 0x00000001898CF740-0x00000001898CF760 */ internal set {} } // 0x0000000186702120-0x00000001867021C0 0x0000000186703210-0x00000001867032C0
		public string Domain { /* [XID] */ /* 0x00000001898D70D0-0x00000001898D70F0 */ get => default; /* [XID] */ /* 0x0000000189A04C40-0x0000000189A04C60 */ set {} } // 0x00000001867021C0-0x0000000186702260 0x00000001867032C0-0x00000001867033B0
		public bool Expired { /* [XID] */ /* 0x00000001898E6450-0x00000001898E6470 */ get => default; /* [XID] */ /* 0x00000001898EDE30-0x00000001898EDE50 */ set {} } // 0x0000000186702340-0x00000001867024B0 0x00000001867033B0-0x00000001867034D0
		public DateTime Expires { /* [XID] */ /* 0x000000018994C260-0x000000018994C280 */ get => default; /* [XID] */ /* 0x00000001898FCE00-0x00000001898FCE20 */ set {} } // 0x00000001867024B0-0x0000000186702580 0x00000001867034D0-0x0000000186703590
		public bool HttpOnly { /* [XID] */ /* 0x00000001899FEE40-0x00000001899FEE60 */ get => default; /* [XID] */ /* 0x000000018990C020-0x000000018990C040 */ set {} } // 0x0000000186702580-0x0000000186702620 0x0000000186703590-0x0000000186703640
		public string Name { /* [XID] */ /* 0x0000000189913920-0x0000000189913940 */ get => default; /* [XID] */ /* 0x000000018991B390-0x000000018991B3B0 */ set {} } // 0x0000000186702820-0x00000001867028C0 0x0000000186703790-0x0000000186703990
		public string Path { /* [XID] */ /* 0x00000001899228B0-0x00000001899228D0 */ get => default; /* [XID] */ /* 0x0000000189962E10-0x0000000189962E30 */ set {} } // 0x00000001867028C0-0x0000000186702960 0x0000000186703990-0x0000000186703A80
		public string Port { /* [XID] */ /* 0x0000000189635BF0-0x0000000189635C10 */ get => default; /* [XID] */ /* 0x000000018992E8B0-0x000000018992E8D0 */ internal set {} } // 0x0000000186702960-0x0000000186702A00 0x0000000186703A80-0x0000000186703B70
		public bool Secure { /* [XID] */ /* 0x0000000189940650-0x0000000189940670 */ get => default; /* [XID] */ /* 0x0000000189947D10-0x0000000189947D30 */ set {} } // 0x0000000186702B80-0x0000000186702C20 0x0000000186703C20-0x0000000186703CD0
		public DateTime TimeStamp { /* [XID] */ /* 0x000000018994F350-0x000000018994F370 */ get => default; } // 0x0000000186702C20-0x0000000186702CF0 
		public string Value { /* [XID] */ /* 0x0000000189956900-0x0000000189956920 */ get => default; /* [XID] */ /* 0x000000018995E450-0x000000018995E470 */ set {} } // 0x0000000186702CF0-0x0000000186702DA0 0x0000000186703CD0-0x0000000186703EA0
		public int Version { /* [XID] */ /* 0x0000000189630050-0x0000000189630070 */ get => default; /* [XID] */ /* 0x0000000189944C70-0x0000000189944C90 */ internal set {} } // 0x0000000186702DA0-0x0000000186702E40 0x0000000186703EA0-0x0000000186703F50
	
		// Constructors
		static Cookie() {} // 0x0000000186701940-0x0000000186701A40
		internal Cookie() {} // 0x0000000186701F30-0x0000000186701FE0
		public Cookie(string name, string value) {} // 0x0000000186701B00-0x0000000186701BC0
		public Cookie(string name, string value, string path) {} // 0x0000000186701A40-0x0000000186701B00
		public Cookie(string name, string value, string path, string domain) {} // 0x0000000186701BC0-0x0000000186701F30
	
		// Methods
		// [XID] // 0x0000000189859010-0x0000000189859030
		private static int hash(int i, int j, int k, int l, int m) => default; // 0x0000000186702E40-0x0000000186702F60
		// [XID] // 0x00000001898601F0-0x0000000189860210
		private void init(string name, string value, string path, string domain) {} // 0x0000000186702F60-0x00000001867030B0
		// [XID] // 0x0000000189983CF0-0x0000000189983D10
		private string toResponseStringVersion0() => default; // 0x0000000186703F50-0x0000000186704270
		// [XID] // 0x000000018998B6E0-0x000000018998B700
		private string toResponseStringVersion1() => default; // 0x0000000186704270-0x00000001867046A0
		// [XID] // 0x00000001899EE590-0x00000001899EE5B0
		private static bool tryCreatePorts(string value, out int[] result) {
			result = default;
			return default;
		} // 0x00000001867046A0-0x0000000186704960
		// [XID] // 0x0000000189935B40-0x0000000189935B60
		internal bool EqualsWithoutValue(Cookie cookie) => default; // 0x0000000186700C70-0x0000000186700DB0
		// [XID] // 0x00000001898678D0-0x00000001898678F0
		internal bool EqualsWithoutValueAndVersion(Cookie cookie) => default; // 0x0000000186700B40-0x0000000186700C70
		// [XID] // 0x000000018986EFE0-0x000000018986F000
		internal string ToRequestString(Uri uri) => default; // 0x0000000186701120-0x0000000186701510
		// [XID] // 0x0000000189B52020-0x0000000189B52040
		internal string ToResponseString() => default; // 0x0000000186701510-0x0000000186701620
		// [XID] // 0x00000001899B8B20-0x00000001899B8B40
		internal static bool TryCreate(string name, string value, out Cookie result) {
			result = default;
			return default;
		} // 0x00000001867016D0-0x00000001867017E0
		// [XID] // 0x00000001899C0430-0x00000001899C0450
		public override bool Equals(object comparand) => default; // 0x0000000186700DB0-0x0000000186700F40
		// [XID] // 0x00000001899C7CF0-0x00000001899C7D10
		public override int GetHashCode() => default; // 0x0000000186700F40-0x0000000186701120
		// [XID] // 0x00000001899CF550-0x00000001899CF570
		public override string ToString() => default; // 0x0000000186701620-0x00000001867016D0
	}
}

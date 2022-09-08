/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	public class HttpListenerPrefixCollection : ICollection<string> // TypeDefIndex: 10262
	{
		// Fields
		private HttpListener _listener; // 0x10
		private List<string> _prefixes; // 0x18
	
		// Properties
		public int Count { /* [XID] */ /* 0x00000001899E72D0-0x00000001899E72F0 */ get => default; } // 0x0000000187170040-0x0000000187170100 
		public bool IsReadOnly { /* [XID] */ /* 0x00000001899EE730-0x00000001899EE750 */ get => default; } // 0x0000000187170100-0x00000001871701A0 
		public bool IsSynchronized { /* [XID] */ /* 0x00000001899F5F20-0x00000001899F5F40 */ get => default; } // 0x00000001871701A0-0x0000000187170240 
	
		// Constructors
		public HttpListenerPrefixCollection() {} // Dummy constructor
		internal HttpListenerPrefixCollection(HttpListener listener) {} // 0x000000018716FFA0-0x0000000187170040
	
		// Methods
		// [XID] // 0x00000001899FD650-0x00000001899FD670
		public void Add(string uriPrefix) {} // 0x000000018716F690-0x000000018716F800
		// [XID] // 0x000000018996FF80-0x000000018996FFA0
		public void Clear() {} // 0x000000018716F800-0x000000018716F910
		// [XID] // 0x0000000189A0C370-0x0000000189A0C390
		public bool Contains(string uriPrefix) => default; // 0x000000018716F910-0x000000018716FA30
		// [IDTag] // 0x0000000189A13CD0-0x0000000189A13D10
		// [XID] // 0x0000000189A13CD0-0x0000000189A13D10
		public void CopyTo(Array array, int offset) {} // 0x000000018716FA30-0x000000018716FB30
		// [IDTag] // 0x0000000189A1DDA0-0x0000000189A1DDE0
		// [XID] // 0x0000000189A1DDA0-0x0000000189A1DDE0
		public void CopyTo(string[] array, int offset) {} // 0x000000018716FB30-0x000000018716FC30
		// [XID] // 0x0000000189B10850-0x0000000189B10870
		public IEnumerator<string> GetEnumerator() => default; // 0x000000018716FC30-0x000000018716FD20
		// [XID] // 0x0000000189A2FA50-0x0000000189A2FA70
		public bool Remove(string uriPrefix) => default; // 0x000000018716FD20-0x000000018716FEB0
		// [XID] // 0x0000000189A37420-0x0000000189A37440
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018716FEB0-0x000000018716FFA0
	}
}

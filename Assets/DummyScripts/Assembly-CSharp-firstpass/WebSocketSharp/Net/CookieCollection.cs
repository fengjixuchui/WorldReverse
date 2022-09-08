/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	[Serializable]
	public class CookieCollection : ICollection<WebSocketSharp.Net.Cookie> // TypeDefIndex: 10247
	{
		// Fields
		private List<Cookie> _list; // 0x10
		private bool _readOnly; // 0x18
		private object _sync; // 0x20
	
		// Properties
		internal IList<Cookie> List { /* [XID] */ /* 0x00000001899ECE80-0x00000001899ECEA0 */ get => default; } // 0x00000001866FED80-0x00000001866FEE20 
		internal IEnumerable<Cookie> Sorted { /* [XID] */ /* 0x00000001899F4BE0-0x00000001899F4C00 */ get => default; } // 0x00000001866FEE20-0x00000001866FEF90 
		public int Count { /* [XID] */ /* 0x00000001899FC200-0x00000001899FC220 */ get => default; } // 0x00000001866FE820-0x00000001866FE8E0 
		public bool IsReadOnly { /* [XID] */ /* 0x0000000189A03680-0x0000000189A036A0 */ get => default; /* [XID] */ /* 0x0000000189A0AC30-0x0000000189A0AC50 */ internal set {} } // 0x00000001866FE8E0-0x00000001866FE980 0x00000001867004C0-0x0000000186700570
		public bool IsSynchronized { /* [XID] */ /* 0x0000000189A124A0-0x0000000189A124C0 */ get => default; } // 0x00000001866FE980-0x00000001866FEA20 
		public Cookie this[int index] { /* [IDTag] */ /* 0x0000000189A19890-0x0000000189A198D0 */ /* [XID] */ /* 0x0000000189A19890-0x0000000189A198D0 */ get => default; } // 0x00000001866FEC50-0x00000001866FED80 
		public Cookie this[string name] { /* [XID] */ /* 0x0000000189A23ED0-0x0000000189A23F10 */ /* [IDTag] */ /* 0x0000000189A23ED0-0x0000000189A23F10 */ get => default; } // 0x00000001866FEA20-0x00000001866FEC50 
		public object SyncRoot { /* [XID] */ /* 0x0000000189A2E180-0x0000000189A2E1A0 */ get => default; } // 0x00000001866FEF90-0x00000001866FF030 
	
		// Constructors
		public CookieCollection() {} // 0x00000001866FE390-0x00000001866FE440
	
		// Methods
		// [XID] // 0x0000000189B5B0D0-0x0000000189B5B0F0
		private void add(Cookie cookie) {} // 0x00000001866FE440-0x00000001866FE540
		// [XID] // 0x0000000189A3D070-0x0000000189A3D090
		private static int compareForSort(Cookie x, Cookie y) => default; // 0x00000001866FE540-0x00000001866FE6B0
		// [XID] // 0x0000000189A44950-0x0000000189A44970
		private static int compareForSorted(Cookie x, Cookie y) => default; // 0x00000001866FE6B0-0x00000001866FE820
		// [XID] // 0x0000000189A4C050-0x0000000189A4C070
		private static CookieCollection parseRequest(string value) => default; // 0x00000001866FF030-0x00000001866FF6F0
		// [XID] // 0x0000000189A53790-0x0000000189A537B0
		private static CookieCollection parseResponse(string value) => default; // 0x00000001866FF6F0-0x00000001867003A0
		// [XID] // 0x0000000189B6A130-0x0000000189B6A150
		private int search(Cookie cookie) => default; // 0x00000001867003A0-0x00000001867004C0
		// [XID] // 0x0000000189A0C270-0x0000000189A0C290
		private static string urlDecode(string s, Encoding encoding) => default; // 0x0000000186700570-0x00000001867006F0
		// [XID] // 0x0000000189A6A500-0x0000000189A6A520
		internal static CookieCollection Parse(string value, bool response) => default; // 0x00000001866FDBD0-0x00000001866FDCE0
		// [IDTag] // 0x0000000189A718F0-0x0000000189A71930
		// [XID] // 0x0000000189A718F0-0x0000000189A71930
		internal void SetOrRemove(Cookie cookie) {} // 0x00000001866FDFE0-0x00000001866FE140
		// [IDTag] // 0x0000000189A7C400-0x0000000189A7C440
		// [XID] // 0x0000000189A7C400-0x0000000189A7C440
		internal void SetOrRemove(CookieCollection cookies) {} // 0x00000001866FDE40-0x00000001866FDFE0
		// [XID] // 0x0000000189A86B40-0x0000000189A86B60
		internal void Sort() {} // 0x00000001866FE140-0x00000001866FE2A0
		// [IDTag] // 0x0000000189A8E710-0x0000000189A8E750
		// [XID] // 0x0000000189A8E710-0x0000000189A8E750
		public void Add(Cookie cookie) {} // 0x00000001866FD5F0-0x00000001866FD720
		// [IDTag] // 0x0000000189A19690-0x0000000189A196D0
		// [XID] // 0x0000000189A19690-0x0000000189A196D0
		public void Add(CookieCollection cookies) {} // 0x00000001866FD3E0-0x00000001866FD5F0
		// [XID] // 0x0000000189AA31C0-0x0000000189AA31E0
		public void Clear() {} // 0x00000001866FD720-0x00000001866FD820
		// [XID] // 0x0000000189AAA6B0-0x0000000189AAA6D0
		public bool Contains(Cookie cookie) => default; // 0x00000001866FD820-0x00000001866FD920
		// [XID] // 0x0000000189AB2530-0x0000000189AB2550
		public void CopyTo(Cookie[] array, int index) {} // 0x00000001866FD920-0x00000001866FDAE0
		// [XID] // 0x0000000189AB99A0-0x0000000189AB99C0
		public IEnumerator<Cookie> GetEnumerator() => default; // 0x00000001866FDAE0-0x00000001866FDBD0
		// [XID] // 0x0000000189AC15D0-0x0000000189AC15F0
		public bool Remove(Cookie cookie) => default; // 0x00000001866FDCE0-0x00000001866FDE40
		// [XID] // 0x0000000189AC8DE0-0x0000000189AC8E00
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001866FE2A0-0x00000001866FE390
	}
}

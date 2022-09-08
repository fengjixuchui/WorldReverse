/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class Cookie // TypeDefIndex: 6076
	{
		// Fields
		private CookieManager cookies; // 0x10
		private BrowserNative.NativeCookie original; // 0x18
		public string name; // 0x20
		public string value; // 0x28
		public string domain; // 0x30
		public string path; // 0x38
		public DateTime creation; // 0x40
		public DateTime lastAccess; // 0x50
		public DateTime? expires; // 0x60
		public bool secure; // 0x78
		public bool httpOnly; // 0x79
		private static readonly Regex dateRegex; // 0x00
	
		// Constructors
		public Cookie() {} // Dummy constructor
		public Cookie(CookieManager cookies) {} // 0x00000001856A6D90-0x00000001856A6E30
		internal Cookie(CookieManager cookies, BrowserNative.NativeCookie cookie) {} // 0x00000001856A6CB0-0x00000001856A6D90
		static Cookie() {} // 0x00000001856A6C20-0x00000001856A6CB0
	
		// Methods
		public static void Init() {} // 0x00000001856A6640-0x00000001856A6690
		public void Delete() {} // 0x00000001856A6550-0x00000001856A6640
		public void Update() {} // 0x00000001856A6AE0-0x00000001856A6C20
		public static void Copy(BrowserNative.NativeCookie src, Cookie dest) {} // 0x00000001856A6310-0x00000001856A6550
		public static void Copy(Cookie src, BrowserNative.NativeCookie dest) {} // 0x00000001856A60B0-0x00000001856A6310
	}
}

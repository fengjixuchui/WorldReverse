/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class CookieManager // TypeDefIndex: 6077
	{
		// Fields
		internal readonly Browser browser; // 0x10
		private static CookieFetch currentFetch; // 0x00
	
		// Nested types
		private class CookieFetch // TypeDefIndex: 6078
		{
			// Fields
			public BrowserNative.GetCookieFunc nativeCB; // 0x10
			public Promise<List<Cookie>> promise; // 0x18
			public CookieManager manager; // 0x20
			public List<Cookie> result; // 0x28
	
			// Constructors
			public CookieFetch() {} // 0x00000001856A59D0-0x00000001856A5A30
		}
	
		// Constructors
		public CookieManager() {} // Dummy constructor
		public CookieManager(Browser browser) {} // 0x00000001856A6040-0x00000001856A60B0
	
		// Methods
		public IPromise<List<Cookie>> GetCookies() => default; // 0x00000001856A5D90-0x00000001856A6040
		// [MonoPInvokeCallback] // 0x0000000189861BB0-0x0000000189861C00
		private static void CB_GetCookieFunc(BrowserNative.NativeCookie cookie) {} // 0x00000001856A5A30-0x00000001856A5C80
		public void ClearAll() {} // 0x00000001856A5C80-0x00000001856A5D90
	}
}

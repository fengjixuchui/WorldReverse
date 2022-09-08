/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal sealed class EndPointManager // TypeDefIndex: 10250
	{
		// Fields
		private static readonly Dictionary<IPEndPoint, EndPointListener> _endpoints; // 0x00
	
		// Constructors
		static EndPointManager() {} // 0x0000000186707E70-0x0000000186707F00
		private EndPointManager() {} // 0x0000000186707F00-0x0000000186707F60
	
		// Methods
		// [XID] // 0x0000000189A10920-0x0000000189A10940
		private static void addPrefix(string uriPrefix, HttpListener listener) {} // 0x0000000186707F60-0x00000001867084A0
		// [XID] // 0x0000000189A8FE10-0x0000000189A8FE30
		private static IPAddress convertToIPAddress(string hostname) => default; // 0x00000001867084A0-0x0000000186708610
		// [XID] // 0x0000000189B83FE0-0x0000000189B84000
		private static void removePrefix(string uriPrefix, HttpListener listener) {} // 0x0000000186708610-0x0000000186708900
		// [XID] // 0x0000000189B8AFE0-0x0000000189B8B000
		internal static bool RemoveEndPoint(IPEndPoint endpoint) => default; // 0x0000000186707800-0x0000000186707A70
		// [XID] // 0x0000000189B92780-0x0000000189B927A0
		public static void AddListener(HttpListener listener) {} // 0x0000000186707280-0x0000000186707660
		// [XID] // 0x0000000189620540-0x0000000189620560
		public static void AddPrefix(string uriPrefix, HttpListener listener) {} // 0x0000000186707660-0x0000000186707800
		// [XID] // 0x00000001896279D0-0x00000001896279F0
		public static void RemoveListener(HttpListener listener) {} // 0x0000000186707A70-0x0000000186707CD0
		// [XID] // 0x0000000189A2E060-0x0000000189A2E080
		public static void RemovePrefix(string uriPrefix, HttpListener listener) {} // 0x0000000186707CD0-0x0000000186707E70
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKHTTPResponse // TypeDefIndex: 8661
	{
		// Properties
		public HTTPStatusCode StatusCode { /* [XID] */ /* 0x000000018969E340-0x000000018969E380 */ get; /* [XID] */ /* 0x00000001896A83D0-0x00000001896A8410 */ set; } // 0x0000000184DFC0A0-0x0000000184DFC100 0x0000000184DFC1C0-0x0000000184DFC220
		public Dictionary<HTTPHeaderField, string> Headers { /* [XID] */ /* 0x00000001896B24D0-0x00000001896B2510 */ get; set; } // 0x0000000184DFBF40-0x0000000184DFBFA0 0x0000000184DFC160-0x0000000184DFC1C0
		public string ContentFilePath { /* [XID] */ /* 0x00000001896C4140-0x00000001896C4180 */ get; /* [XID] */ /* 0x00000001896CE900-0x00000001896CE940 */ set; } // 0x0000000184DFBDE0-0x0000000184DFBE40 0x0000000184DFC100-0x0000000184DFC160
		public static MiHoYoSDKHTTPResponse BadRequest { /* [XID] */ /* 0x000000018999F190-0x000000018999F1B0 */ get => default; } // 0x0000000184DFBCE0-0x0000000184DFBDE0 
		public static MiHoYoSDKHTTPResponse MethodNotAllowed { /* [XID] */ /* 0x00000001899A6B90-0x00000001899A6BB0 */ get => default; } // 0x0000000184DFBFA0-0x0000000184DFC0A0 
		public static MiHoYoSDKHTTPResponse Forbidden { /* [XID] */ /* 0x00000001899AE430-0x00000001899AE450 */ get => default; } // 0x0000000184DFBE40-0x0000000184DFBF40 
	
		// Constructors
		public MiHoYoSDKHTTPResponse() {} // 0x0000000184DFBBE0-0x0000000184DFBCE0
	
		// Methods
		// [XID] // 0x00000001896D8CF0-0x00000001896D8D10
		public void SendTo(Stream stream) {} // 0x0000000184DFB270-0x0000000184DFBBE0
	}
}

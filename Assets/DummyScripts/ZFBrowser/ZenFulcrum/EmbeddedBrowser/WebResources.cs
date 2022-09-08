/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public abstract class WebResources // TypeDefIndex: 6603
	{
		// Fields
		public static readonly Dictionary<string, string> extensionMimeTypes; // 0x00
		public static readonly Dictionary<int, string> statusTexts; // 0x08
	
		// Nested types
		public class ResponsePreamble // TypeDefIndex: 6604
		{
			// Fields
			public int statusCode; // 0x10
			public string statusText; // 0x18
			public string mimeType; // 0x20
			public int length; // 0x28
			public Dictionary<string, string> headers; // 0x30
	
			// Constructors
			public ResponsePreamble() {} // 0x00000001856BCEA0-0x00000001856BD010
		}
	
		// Constructors
		protected WebResources() {} // 0x00000001856C4E90-0x00000001856C4F90
		static WebResources() {} // 0x00000001856C4780-0x00000001856C4E90
	
		// Methods
		public abstract void HandleRequest(int id, string url);
		protected virtual void SendResponse(int id, byte[] data, string mimeType = "application/octet-stream" /* Metadata: 0x00ADD279 */) {} // 0x00000001856C4670-0x00000001856C4780
		protected virtual void SendResponse(int id, string text, string mimeType = "text/html; charset=UTF-8" /* Metadata: 0x00ADD295 */) {} // 0x00000001856C4520-0x00000001856C4670
		protected virtual void SendError(int id, string html, int errorCode = 500 /* Metadata: 0x00ADD2B1 */) {} // 0x00000001856C3DA0-0x00000001856C3EF0
		protected virtual void SendFile(int id, FileInfo file, bool forceDownload = false /* Metadata: 0x00ADD2B5 */) {} // 0x00000001856C3EF0-0x00000001856C4040
		protected void SendPreamble(int id, ResponsePreamble pre) {} // 0x00000001856C4040-0x00000001856C4520
		protected void SendData(int id, byte[] data, int length = -1 /* Metadata: 0x00ADD2B6 */) {} // 0x00000001856C3A60-0x00000001856C3C50
		protected void SendEnd(int id) {} // 0x00000001856C3C50-0x00000001856C3DA0
	}
}

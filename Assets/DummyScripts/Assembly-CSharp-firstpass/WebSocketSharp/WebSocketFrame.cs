/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	internal class WebSocketFrame : IEnumerable<byte> // TypeDefIndex: 10323
	{
		// Fields
		private byte[] _extPayloadLength; // 0x10
		private Fin _fin; // 0x18
		private Mask _mask; // 0x19
		private byte[] _maskingKey; // 0x20
		private Opcode _opcode; // 0x28
		private PayloadData _payloadData; // 0x30
		private byte _payloadLength; // 0x38
		private Rsv _rsv1; // 0x39
		private Rsv _rsv2; // 0x3A
		private Rsv _rsv3; // 0x3B
		internal static readonly byte[] EmptyPingBytes; // 0x00
	
		// Properties
		internal ulong ExactPayloadLength { /* [XID] */ /* 0x0000000189682AC0-0x0000000189682AE0 */ get => default; } // 0x0000000189492B30-0x0000000189492C40 
		internal int ExtendedPayloadLengthWidth { /* [XID] */ /* 0x00000001897FA4B0-0x00000001897FA4D0 */ get => default; } // 0x0000000189492C40-0x0000000189492D00 
		public byte[] ExtendedPayloadLength { /* [XID] */ /* 0x0000000189801A50-0x0000000189801A70 */ get => default; } // 0x0000000189492D00-0x0000000189492DA0 
		public Fin Fin { /* [XID] */ /* 0x0000000189949D60-0x0000000189949D80 */ get => default; } // 0x0000000189492DA0-0x0000000189492E40 
		public bool IsBinary { /* [XID] */ /* 0x0000000189810790-0x00000001898107B0 */ get => default; } // 0x0000000189492E40-0x0000000189492EF0 
		public bool IsClose { /* [XID] */ /* 0x0000000189817DA0-0x0000000189817DC0 */ get => default; } // 0x0000000189492EF0-0x0000000189492FA0 
		public bool IsCompressed { /* [XID] */ /* 0x000000018981F790-0x000000018981F7B0 */ get => default; } // 0x0000000189492FA0-0x0000000189493050 
		public bool IsContinuation { /* [XID] */ /* 0x0000000189604330-0x0000000189604350 */ get => default; } // 0x0000000189493050-0x00000001894930F0 
		public bool IsControl { /* [XID] */ /* 0x000000018982E440-0x000000018982E460 */ get => default; } // 0x00000001894930F0-0x00000001894931A0 
		public bool IsData { /* [XID] */ /* 0x0000000189835B70-0x0000000189835B90 */ get => default; } // 0x00000001894931A0-0x0000000189493250 
		public bool IsFinal { /* [XID] */ /* 0x000000018983D1C0-0x000000018983D1E0 */ get => default; } // 0x0000000189493250-0x0000000189493300 
		public bool IsFragment { /* [XID] */ /* 0x00000001897EF820-0x00000001897EF840 */ get => default; } // 0x0000000189493300-0x00000001894933B0 
		public bool IsMasked { /* [XID] */ /* 0x000000018979F4B0-0x000000018979F4D0 */ get => default; } // 0x00000001894933B0-0x0000000189493460 
		public bool IsPing { /* [XID] */ /* 0x0000000189852C50-0x0000000189852C70 */ get => default; } // 0x0000000189493460-0x0000000189493510 
		public bool IsPong { /* [XID] */ /* 0x0000000189808D50-0x0000000189808D70 */ get => default; } // 0x0000000189493510-0x00000001894935C0 
		public bool IsText { /* [XID] */ /* 0x00000001898619B0-0x00000001898619D0 */ get => default; } // 0x00000001894935C0-0x0000000189493670 
		public ulong Length { /* [XID] */ /* 0x00000001898692B0-0x00000001898692D0 */ get => default; } // 0x0000000189493670-0x0000000189493770 
		public Mask Mask { /* [XID] */ /* 0x0000000189870570-0x0000000189870590 */ get => default; } // 0x0000000189493770-0x0000000189493810 
		public byte[] MaskingKey { /* [XID] */ /* 0x0000000189877C80-0x0000000189877CA0 */ get => default; } // 0x0000000189493810-0x00000001894938B0 
		public Opcode Opcode { /* [XID] */ /* 0x000000018987F510-0x000000018987F530 */ get => default; } // 0x00000001894938B0-0x0000000189493950 
		public PayloadData PayloadData { /* [XID] */ /* 0x0000000189886B20-0x0000000189886B40 */ get => default; } // 0x0000000189493950-0x00000001894939F0 
		public byte PayloadLength { /* [XID] */ /* 0x00000001899A3A40-0x00000001899A3A60 */ get => default; } // 0x00000001894939F0-0x0000000189493A90 
		public Rsv Rsv1 { /* [XID] */ /* 0x00000001899AB510-0x00000001899AB530 */ get => default; } // 0x0000000189493A90-0x0000000189493B30 
		public Rsv Rsv2 { /* [XID] */ /* 0x000000018989CAC0-0x000000018989CAE0 */ get => default; } // 0x0000000189493B30-0x0000000189493BD0 
		public Rsv Rsv3 { /* [XID] */ /* 0x00000001897D4400-0x00000001897D4420 */ get => default; } // 0x0000000189493BD0-0x0000000189493C70 
	
		// Constructors
		static WebSocketFrame() {} // 0x0000000189491DB0-0x0000000189491E40
		private WebSocketFrame() {} // 0x0000000189491EF0-0x0000000189491F50
		internal WebSocketFrame(Opcode opcode, PayloadData payloadData, bool mask) {} // 0x0000000189491E40-0x0000000189491EF0
		internal WebSocketFrame(Fin fin, Opcode opcode, byte[] data, bool compressed, bool mask) {} // 0x0000000189491F50-0x0000000189492030
		internal WebSocketFrame(Fin fin, Opcode opcode, PayloadData payloadData, bool compressed, bool mask) {} // 0x0000000189492030-0x0000000189492270
	
		// Methods
		// [XID] // 0x00000001898AB4E0-0x00000001898AB500
		private static byte[] createMaskingKey() => default; // 0x0000000189492270-0x0000000189492380
		// [XID] // 0x00000001898B2D60-0x00000001898B2D80
		private static string dump(WebSocketFrame frame) => default; // 0x0000000189492380-0x0000000189492B30
		// [XID] // 0x00000001898BAC00-0x00000001898BAC20
		private static string print(WebSocketFrame frame) => default; // 0x0000000189493C70-0x00000001894942A0
		// [XID] // 0x0000000189BBF890-0x0000000189BBF8B0
		private static WebSocketFrame processHeader(byte[] header) => default; // 0x00000001894942A0-0x00000001894945D0
		// [XID] // 0x00000001899BA150-0x00000001899BA170
		private static WebSocketFrame readExtendedPayloadLength(Stream stream, WebSocketFrame frame) => default; // 0x0000000189494820-0x00000001894949B0
		// [XID] // 0x00000001898B2CC0-0x00000001898B2CE0
		private static void readExtendedPayloadLengthAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error) {} // 0x00000001894945D0-0x0000000189494820
		// [XID] // 0x00000001899FD4F0-0x00000001899FD510
		private static WebSocketFrame readHeader(Stream stream) => default; // 0x0000000189494B60-0x0000000189494C60
		// [XID] // 0x00000001899243F0-0x0000000189924410
		private static void readHeaderAsync(Stream stream, Action<WebSocketFrame> completed, Action<Exception> error) {} // 0x00000001894949B0-0x0000000189494B60
		// [XID] // 0x00000001899C1CC0-0x00000001899C1CE0
		private static WebSocketFrame readMaskingKey(Stream stream, WebSocketFrame frame) => default; // 0x0000000189494EB0-0x0000000189495040
		// [XID] // 0x00000001898EF710-0x00000001898EF730
		private static void readMaskingKeyAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error) {} // 0x0000000189494C60-0x0000000189494EB0
		// [XID] // 0x00000001899D0C00-0x00000001899D0C20
		private static WebSocketFrame readPayloadData(Stream stream, WebSocketFrame frame) => default; // 0x0000000189495370-0x00000001894955F0
		// [XID] // 0x00000001898FE7A0-0x00000001898FE7C0
		private static void readPayloadDataAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error) {} // 0x0000000189495040-0x0000000189495370
		// [XID] // 0x0000000189ACD560-0x0000000189ACD580
		private static string utf8Decode(byte[] bytes) => default; // 0x00000001894955F0-0x00000001894956E0
		// [XID] // 0x000000018990D8C0-0x000000018990D8E0
		internal static WebSocketFrame CreateCloseFrame(PayloadData payloadData, bool mask) => default; // 0x0000000189490D60-0x0000000189490E50
		// [IDTag] // 0x0000000189914FB0-0x0000000189914FF0
		// [XID] // 0x0000000189914FB0-0x0000000189914FF0
		internal static WebSocketFrame CreatePingFrame(bool mask) => default; // 0x0000000189490F60-0x0000000189491080
		// [IDTag] // 0x000000018991F770-0x000000018991F7B0
		// [XID] // 0x000000018991F770-0x000000018991F7B0
		internal static WebSocketFrame CreatePingFrame(byte[] data, bool mask) => default; // 0x0000000189490E50-0x0000000189490F60
		// [XID] // 0x0000000189BCF850-0x0000000189BCF870
		internal static WebSocketFrame CreatePongFrame(PayloadData payloadData, bool mask) => default; // 0x0000000189491080-0x0000000189491170
		// [XID] // 0x0000000189931720-0x0000000189931740
		internal static WebSocketFrame ReadFrame(Stream stream, bool unmask) => default; // 0x0000000189491680-0x00000001894917B0
		// [XID] // 0x0000000189938DE0-0x0000000189938E00
		internal static void ReadFrameAsync(Stream stream, bool unmask, Action<WebSocketFrame> completed, Action<Exception> error) {} // 0x00000001894914C0-0x0000000189491680
		// [XID] // 0x0000000189940630-0x0000000189940650
		internal void Unmask() {} // 0x0000000189491CC0-0x0000000189491DB0
		[DebuggerHidden] // 0x0000000189947CD0-0x0000000189947D10
		// [XID] // 0x0000000189947CD0-0x0000000189947D10
		public IEnumerator<byte> GetEnumerator() => default; // 0x0000000189491170-0x0000000189491280
		// [XID] // 0x0000000189A4EF90-0x0000000189A4EFB0
		public void Print(bool dumped) {} // 0x0000000189491390-0x00000001894914C0
		// [XID] // 0x0000000189959AB0-0x0000000189959AD0
		public string PrintToString(bool dumped) => default; // 0x0000000189491280-0x0000000189491390
		// [XID] // 0x0000000189961410-0x0000000189961430
		public byte[] ToArray() => default; // 0x0000000189491860-0x0000000189491B70
		// [XID] // 0x0000000189AB0A30-0x0000000189AB0A50
		public override string ToString() => default; // 0x0000000189491B70-0x0000000189491C50
		// [XID] // 0x0000000189A8B610-0x0000000189A8B630
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001894917B0-0x0000000189491860
	}
}

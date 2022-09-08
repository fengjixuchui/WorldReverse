/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Sony.PS4.Dialog
{
	public class Messages // TypeDefIndex: 9748
	{
		// Nested types
		public enum MessageType // TypeDefIndex: 9749
		{
			kDialog_NotSet = 0,
			kDialog_Log = 1,
			kDialog_LogWarning = 2,
			kDialog_LogError = 3,
			kDialog_GotDialogResult = 4,
			kDialog_GotIMEDialogResult = 5
		}
	
		public delegate void EventHandler(PluginMessage msg); // TypeDefIndex: 9750; 0x0000000186F1B030-0x0000000186F1B230
	
		public struct PluginMessage // TypeDefIndex: 9751
		{
			// Fields
			public MessageType type; // 0x00
			public int dataSize; // 0x04
			public IntPtr data; // 0x08
	
			// Properties
			public string Text { /* [XID] */ /* 0x0000000189777FD0-0x0000000189777FF0 */ get => default; } // 0x0000000186F1EC20-0x0000000186F1EC30 
			public int Int { /* [XID] */ /* 0x000000018977F4E0-0x000000018977F500 */ get => default; } // 0x0000000186F1EB30-0x0000000186F1EC20 
		}
	
		// Constructors
		public Messages() {} // 0x0000000186F1EA10-0x0000000186F1EB30
	
		// Methods
		private static extern bool PrxCommonDialogHasMessage(); // 0x0000000186F1E7B0-0x0000000186F1E890
		private static extern bool PrxCommonDialogGetFirstMessage(out PluginMessage msg); // 0x0000000186F1E6B0-0x0000000186F1E7B0
		private static extern bool PrxCommonDialogRemoveFirstMessage(); // 0x0000000186F1E890-0x0000000186F1E970
		// [XID] // 0x0000000189A2E290-0x0000000189A2E2B0
		public static bool HasMessage() => default; // 0x0000000186F1E610-0x0000000186F1E6B0
		// [XID] // 0x0000000189754690-0x00000001897546B0
		public static void RemoveFirstMessage() {} // 0x0000000186F1E970-0x0000000186F1EA10
		// [XID] // 0x0000000189A3D170-0x0000000189A3D190
		public static void GetFirstMessage(out PluginMessage msg) {
			msg = default;
		} // 0x0000000186F1E570-0x0000000186F1E610
	}
}

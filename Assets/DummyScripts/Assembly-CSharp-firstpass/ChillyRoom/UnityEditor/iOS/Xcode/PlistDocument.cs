/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode
{
	public class PlistDocument // TypeDefIndex: 10429
	{
		// Fields
		public PlistElementDict root; // 0x10
		public string version; // 0x18
	
		// Constructors
		public PlistDocument() {} // 0x0000000186EF2E80-0x0000000186EF2F20
	
		// Methods
		// [XID] // 0x00000001898F25C0-0x00000001898F25E0
		internal static XDocument ParseXmlNoDtd(string text) => default; // 0x0000000186EF18E0-0x0000000186EF1A10
		// [XID] // 0x00000001898F9D20-0x00000001898F9D40
		internal static string CleanDtdToString(XDocument doc) => default; // 0x0000000186EF0ED0-0x0000000186EF1680
		// [XID] // 0x00000001897EAE80-0x00000001897EAEA0
		private static string GetText(XElement xml) => default; // 0x0000000186EF1730-0x0000000186EF18E0
		// [XID] // 0x0000000189A61C30-0x0000000189A61C50
		private static PlistElement ReadElement(XElement xml) => default; // 0x0000000186EF1A10-0x0000000186EF2040
		// [XID] // 0x00000001897FA470-0x00000001897FA490
		public void Create() {} // 0x0000000186EF1680-0x0000000186EF1730
		// [XID] // 0x00000001898019F0-0x0000000189801A10
		public void ReadFromFile(string path) {} // 0x0000000186EF2040-0x0000000186EF2100
		// [XID] // 0x0000000189808E50-0x0000000189808E70
		public void ReadFromStream(TextReader tr) {} // 0x0000000186EF2100-0x0000000186EF21E0
		// [XID] // 0x0000000189810770-0x0000000189810790
		public void ReadFromString(string text) {} // 0x0000000186EF21E0-0x0000000186EF2400
		// [XID] // 0x0000000189817E60-0x0000000189817E80
		private static XElement WriteElement(PlistElement el) => default; // 0x0000000186EF2480-0x0000000186EF2AF0
		// [XID] // 0x000000018981F730-0x000000018981F750
		public void WriteToFile(string path) {} // 0x0000000186EF2AF0-0x0000000186EF2BE0
		// [XID] // 0x0000000189826D50-0x0000000189826D70
		public void WriteToStream(TextWriter tw) {} // 0x0000000186EF2BE0-0x0000000186EF2CC0
		// [XID] // 0x000000018982E400-0x000000018982E420
		public string WriteToString() => default; // 0x0000000186EF2CC0-0x0000000186EF2E80
	}
}

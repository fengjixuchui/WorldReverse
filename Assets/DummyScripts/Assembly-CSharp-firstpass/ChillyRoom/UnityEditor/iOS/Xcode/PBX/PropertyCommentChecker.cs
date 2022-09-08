/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class PropertyCommentChecker // TypeDefIndex: 10403
	{
		// Fields
		private int m_Level; // 0x10
		private bool m_All; // 0x14
		private List<List<string>> m_Props; // 0x18
	
		// Constructors
		protected PropertyCommentChecker(int level, List<List<string>> props) {} // 0x0000000186D42700-0x0000000186D42790
		public PropertyCommentChecker() {} // 0x0000000186D42790-0x0000000186D42830
		public PropertyCommentChecker(IEnumerable<string> props) {} // 0x0000000186D42830-0x0000000186D42B00
	
		// Methods
		// [XID] // 0x00000001896FDBD0-0x00000001896FDBF0
		private bool CheckContained(string prop) => default; // 0x0000000186D41CB0-0x0000000186D41F70
		// [XID] // 0x00000001897A9960-0x00000001897A9980
		public bool CheckStringValueInArray(string value) => default; // 0x0000000186D42030-0x0000000186D420F0
		// [XID] // 0x0000000189B31AC0-0x0000000189B31AE0
		public bool CheckKeyInDict(string key) => default; // 0x0000000186D41F70-0x0000000186D42030
		// [XID] // 0x00000001897B11C0-0x00000001897B11E0
		public bool CheckStringValueInDict(string key, string value) => default; // 0x0000000186D420F0-0x0000000186D42420
		// [XID] // 0x000000018970C6E0-0x000000018970C700
		public PropertyCommentChecker NextLevel(string prop) => default; // 0x0000000186D42420-0x0000000186D42700
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoTools
{
	public static class CloudInput // TypeDefIndex: 6872
	{
		// Fields
		private static HashSet<InputField> _inputFieldSet; // 0x00
		private static List<InputField> _removeList; // 0x08
		private static List<ICloudInput> _cloudInputSet; // 0x10
		private static bool _show; // 0x18
		private static int _currentInputID; // 0x1C
		private static bool _enable; // 0x20
	
		// Constructors
		static CloudInput() {} // 0x00000001853FC290-0x00000001853FC4B0
	
		// Methods
		// [XID] // 0x00000001899E0F10-0x00000001899E0F30
		public static void RegisterCloudInput(ICloudInput input) {} // 0x00000001853FBCD0-0x00000001853FBDE0
		// [XID] // 0x0000000189A73480-0x0000000189A734A0
		public static void AddInputField(InputField input) {} // 0x00000001853FB160-0x00000001853FB2B0
		// [XID] // 0x0000000189A7B090-0x0000000189A7B0B0
		public static void RemoveInputField(InputField input) {} // 0x00000001853FBDE0-0x00000001853FBF30
		// [XID] // 0x00000001899F7830-0x00000001899F7850
		public static void SetInputField(string str) {} // 0x00000001853FBF30-0x00000001853FC110
		// [XID] // 0x0000000189A89FA0-0x0000000189A89FC0
		public static void CheckInput() {} // 0x00000001853FB2B0-0x00000001853FBB70
		// [XID] // 0x00000001899FEEC0-0x00000001899FEEE0
		private static void Show(string value, bool password) {} // 0x00000001853FC110-0x00000001853FC290
		// [XID] // 0x0000000189A067C0-0x0000000189A067E0
		private static void Close() {} // 0x00000001853FBB70-0x00000001853FBCD0
	}
}

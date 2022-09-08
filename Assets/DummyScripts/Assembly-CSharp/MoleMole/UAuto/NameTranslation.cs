/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class NameTranslation // TypeDefIndex: 28327
	{
		// Fields
		private static readonly char[] translationSeparator; // 0x00
		private static readonly char[] translationSeparatorWithString; // 0x08
		private static readonly HashSet<char> translationSeparatorSet; // 0x10
		private static readonly HashSet<char> translationSeparatorSetWithString; // 0x18
		private const int obfuscateElementCount = 6; // Metadata: 0x00B0D612
		private static string _nameTranslationPath; // 0x20
		private static IDictionary<string, string> nameTranslationSet; // 0x28
		private static IDictionary<string, string> nameObfuscateSet; // 0x30
		private static IDictionary<string, string> nameTranslationResultSet; // 0x38
		private static IDictionary<string, string> nameObfuscateResultSet; // 0x40
		public static Action EventNameTranslationChanged; // 0x48
		private static bool _isValid; // 0x50
	
		// Properties
		public static string nameTranslationPath { get => default; set {} } // 0x00000001810615F0-0x0000000181061680 0x0000000181061680-0x00000001810617D0
		public static bool isValid { get => default; } // 0x0000000181061560-0x00000001810615F0 
	
		// Constructors
		public NameTranslation() {} // 0x0000000181061500-0x0000000181061560
		static NameTranslation() {} // 0x0000000181061290-0x0000000181061500
	
		// Methods
		public static string NameTranslate(string name, bool includeString = false /* Metadata: 0x00B0D60F */) => default; // 0x0000000181060DC0-0x0000000181061200
		public static string NameObfuscate(string name, bool includeString = false /* Metadata: 0x00B0D610 */) => default; // 0x0000000181060620-0x0000000181060B90
		private static string[] NameSplit(string name, bool includeString = false /* Metadata: 0x00B0D611 */) => default; // 0x0000000181060B90-0x0000000181060DC0
		private static bool LoadNameTranslation() => default; // 0x00000001810603C0-0x0000000181060620
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x000000018995BE00-0x000000018995BE40
	public class FontConfig : ScriptableObject // TypeDefIndex: 19638
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<LanguageFontInfo> fontInfoList; // 0x18
	
		// Constructors
		public FontConfig() {} // 0x0000000181F7D2C0-0x0000000181F7D330
	
		// Methods
		// [XID] // 0x000000018996C570-0x000000018996C590
		public string GetDefaultLanguageFontName(TextFontType textType, LanguageType lanType) => default; // 0x0000000181F7D050-0x0000000181F7D2C0
	}
}

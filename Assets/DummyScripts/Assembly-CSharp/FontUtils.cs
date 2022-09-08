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

public static class FontUtils // TypeDefIndex: 31543
{
	// Fields
	private const string FONT_ASSET_FOLDER_PATH = "ART/UI/Fonts/"; // Metadata: 0x00B128E8
	private const string EMBEDED_FONT_ASSET_FOLDER_PATH = "EmbededRes/ART/UI/Font/"; // Metadata: 0x00B128F9
	private const string DEFAULT_FONT_NAME = "Default_SC"; // Metadata: 0x00B12914
	private static Dictionary<string, Font> _textFontDic; // 0x00
	private static Font _defaultFont; // 0x08
	private static Font _builtinArialFont; // 0x10

	// Properties
	private static Font builtinArialFont { /* [XID] */ /* 0x00000001898B7A90-0x00000001898B7AB0 */ get; } // 0x0000000182DF1A70-0x0000000182DF1BF0 
	private static Font defaultFont { /* [XID] */ /* 0x00000001898BF050-0x00000001898BF070 */ get; } // 0x0000000182DF1BF0-0x0000000182DF1D90 

	// Constructors
	static FontUtils() {} // 0x0000000182DF1D90-0x0000000182DF1E40

	// Methods
	// [XID] // 0x00000001898C69E0-0x00000001898C6A00
	public static Font GetFontByName(string fontName) => default; // 0x0000000182DF1450-0x0000000182DF1780
	// [XID] // 0x00000001898CDFD0-0x00000001898CDFF0
	public static Font GetEmbededFontByName(string fontName) => default; // 0x0000000182DF11B0-0x0000000182DF1450
	// [XID] // 0x00000001898D5A80-0x00000001898D5AA0
	public static void UnloadFontAsset() {} // 0x0000000182DF1780-0x0000000182DF1A70
}


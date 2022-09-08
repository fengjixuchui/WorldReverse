/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class LevelBaseData<Page> // TypeDefIndex: 19514
	where Page : BlockDataPage, new()
{
	// Fields
	protected static Dictionary<ulong, Page> _blockPages;

	// Constructors
	protected LevelBaseData() {}
	static LevelBaseData() {}

	// Methods
	public static void LoadConfig(ulong path) {}
	public static void LoadConfigAsync(ulong path) {}
	public static void UnloadConfig(ulong path) {}
	public static void ClearConfig() {}
}


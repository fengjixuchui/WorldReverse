/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;
using XLua.LuaDLL;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua.TemplateEngine
{
	public class LuaTemplate // TypeDefIndex: 32445
	{
		// Fields
		private static lua_CSFunction templateCompileFunction; // 0x00
		private static lua_CSFunction templateExecuteFunction; // 0x08
	
		// Constructors
		public LuaTemplate() {} // 0x00000001866B0CB0-0x00000001866B0D70
		static LuaTemplate() {} // 0x00000001866B0B80-0x00000001866B0CB0
	
		// Methods
		// [XID] // 0x0000000189961800-0x0000000189961820
		public static string ComposeCode(List<Chunk> chunks) => default; // 0x00000001866B02B0-0x00000001866B0640
		// [IDTag] // 0x0000000189968C90-0x0000000189968CD0
		// [XID] // 0x0000000189968C90-0x0000000189968CD0
		public static LuaFunction Compile(LuaEnv luaenv, string snippet) => default; // 0x00000001866B0180-0x00000001866B02B0
		// [IDTag] // 0x00000001899737C0-0x0000000189973800
		// [XID] // 0x00000001899737C0-0x0000000189973800
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters) => default; // 0x00000001866B0880-0x00000001866B09D0
		// [IDTag] // 0x000000018997D9B0-0x000000018997D9F0
		// [XID] // 0x000000018997D9B0-0x000000018997D9F0
		public static string Execute(LuaFunction compiledTemplate) => default; // 0x00000001866B0640-0x00000001866B0770
		// [IDTag] // 0x00000001899888F0-0x0000000189988970
		// [MonoPInvokeCallback] // 0x00000001899888F0-0x0000000189988970
		// [XID] // 0x00000001899888F0-0x0000000189988970
		public static int Compile(IntPtr L) => default; // 0x00000001866AFFB0-0x00000001866B0180
		// [IDTag] // 0x000000018999AEC0-0x000000018999AF40
		// [MonoPInvokeCallback] // 0x000000018999AEC0-0x000000018999AF40
		// [XID] // 0x000000018999AEC0-0x000000018999AF40
		public static int Execute(IntPtr L) => default; // 0x00000001866B0770-0x00000001866B0880
		// [XID] // 0x00000001899AD010-0x00000001899AD030
		public static void OpenLib(IntPtr L) {} // 0x00000001866B09D0-0x00000001866B0B80
	}
}

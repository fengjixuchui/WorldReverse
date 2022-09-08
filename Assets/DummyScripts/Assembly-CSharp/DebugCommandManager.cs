/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DebugCommandManager // TypeDefIndex: 27700
{
	// Fields
	private static DebugCommand _debugCommand; // 0x00

	// Properties
	public static DebugCommand debugCommand { /* [XID] */ /* 0x000000018987E7F0-0x000000018987E810 */ get => default; } // 0x000000018318ED00-0x000000018318EDD0 

	// Constructors
	static DebugCommandManager() {} // 0x000000018318F760-0x000000018318F7F0
	public DebugCommandManager() {} // 0x000000018318F7F0-0x000000018318F850

	// Methods
	// [XID] // 0x0000000189885C10-0x0000000189885C30
	public static void LoadPatch(string patch) {} // 0x000000018318EAE0-0x000000018318ED00
	// [IDTag] // 0x000000018988CF40-0x000000018988CF80
	// [XID] // 0x000000018988CF40-0x000000018988CF80
	public static void AddCommand(string command, Func<string> callback, string description) {} // 0x000000018318E9D0-0x000000018318EAE0
	// [IDTag] // 0x0000000189897200-0x0000000189897240
	// [XID] // 0x0000000189897200-0x0000000189897240
	public static void AddCommand(string command, Func<string, string> callback, string description) {} // 0x000000018318E590-0x000000018318E6A0
	// [IDTag] // 0x00000001898A1790-0x00000001898A17D0
	// [XID] // 0x00000001898A1790-0x00000001898A17D0
	public static void AddCommand(string command, Func<string, string, string> callback, string description) {} // 0x000000018318E8C0-0x000000018318E9D0
	// [IDTag] // 0x00000001898ABE20-0x00000001898ABE60
	// [XID] // 0x00000001898ABE20-0x00000001898ABE60
	public static void AddCommand(string command, Func<string[], string> callback, string description) {} // 0x000000018318E7B0-0x000000018318E8C0
	// [IDTag] // 0x00000001898B65A0-0x00000001898B65E0
	// [XID] // 0x00000001898B65A0-0x00000001898B65E0
	public static void AddCommand(string command, DebugCommand.CommandDelegate callback, string description) {} // 0x000000018318E6A0-0x000000018318E7B0
	// [XID] // 0x00000001898C0F70-0x00000001898C0F90
	public static void Command(string command) {} // 0x000000018318F010-0x000000018318F260
	// [XID] // 0x00000001898C8930-0x00000001898C8950
	public static void Notify(string log) {} // 0x000000018318F570-0x000000018318F760
	// [XID] // 0x00000001898D0240-0x00000001898D0260
	private static void Initialize() {} // 0x000000018318F260-0x000000018318F570
	// [XID] // 0x00000001898D78B0-0x00000001898D78D0
	private static string TextureStreaming(params /* 0x000000018989F6F0-0x000000018989F700 */ string[] commands) => default; // 0x000000018318EDD0-0x000000018318F010
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ConsoleCommandExecuter // TypeDefIndex: 27578
{
	// Fields
	private int _categoryOffset; // 0x10
	private Dictionary<int, Dictionary<string, Func<string[], bool>>> _argCategoryExecutorStubs; // 0x18
	private Dictionary<int, Dictionary<string, Func<string[], object, bool>>> _argWithObjValueCategoryExecutorStubs; // 0x20

	// Constructors
	public ConsoleCommandExecuter() {} // Dummy constructor
	public ConsoleCommandExecuter(int categoryOffset) {} // 0x0000000183C0CCA0-0x0000000183C0CD60

	// Methods
	// [IDTag] // 0x0000000189AAB070-0x0000000189AAB0B0
	// [XID] // 0x0000000189AAB070-0x0000000189AAB0B0
	public void RegisterExecuterStub(int argCount, string category, Func<string[], bool> inExecuteStub) {} // 0x0000000183C0C5B0-0x0000000183C0C740
	// [XID] // 0x0000000189AB5AB0-0x0000000189AB5AD0
	public string ExtractCategory(string[] args) => default; // 0x0000000183C0CBB0-0x0000000183C0CCA0
	// [IDTag] // 0x0000000189ABD4D0-0x0000000189ABD510
	// [XID] // 0x0000000189ABD4D0-0x0000000189ABD510
	public bool ExecuteCommand(string[] args) => default; // 0x0000000183C0C740-0x0000000183C0C980
	// [IDTag] // 0x0000000189AC7EA0-0x0000000189AC7EE0
	// [XID] // 0x0000000189AC7EA0-0x0000000189AC7EE0
	public void RegisterExecuterStub(int argCount, string category, Func<string[], object, bool> inExecuteStub) {} // 0x0000000183C0C430-0x0000000183C0C5B0
	// [IDTag] // 0x0000000189AD2960-0x0000000189AD29A0
	// [XID] // 0x0000000189AD2960-0x0000000189AD29A0
	public bool ExecuteCommand(string[] args, object objValue) => default; // 0x0000000183C0C980-0x0000000183C0CBB0
}


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

public class DebugCommand // TypeDefIndex: 27697
{
	// Fields
	private readonly Dictionary<string, Data> _commandSet; // 0x10

	// Properties
	public string[] CommandSet { /* [XID] */ /* 0x00000001897A1350-0x00000001897A1370 */ get => default; } // 0x00000001828CDC20-0x00000001828CDD50 

	// Nested types
	public delegate string CommandDelegate(params /* 0x000000018989F6F0-0x000000018989F700 */ string[] commands); // TypeDefIndex: 27698; 0x00000001828E4590-0x00000001828E47F0

	private struct Data // TypeDefIndex: 27699
	{
		// Fields
		public string Command; // 0x00
		public string Description; // 0x08
		public Delegate Action; // 0x10

		// Constructors
		public Data(string command, Delegate action, string description) {
			Command = default;
			Description = default;
			Action = default;
		} // 0x00000001828BE000-0x00000001828BE120
	}

	// Constructors
	public DebugCommand() {} // 0x00000001828CDD50-0x00000001828CDE60

	// Methods
	// [IDTag] // 0x00000001897A8920-0x00000001897A8960
	// [XID] // 0x00000001897A8920-0x00000001897A8960
	public bool Add(string command, Action action, string description = "" /* Metadata: 0x00B0CACC */) => default; // 0x00000001828CD500-0x00000001828CD5F0
	// [IDTag] // 0x00000001897B3610-0x00000001897B3650
	// [XID] // 0x00000001897B3610-0x00000001897B3650
	public bool Add(string command, Action<string> action, string description = "" /* Metadata: 0x00B0CAD0 */) => default; // 0x00000001828CDB30-0x00000001828CDC20
	// [IDTag] // 0x00000001897BE930-0x00000001897BE970
	// [XID] // 0x00000001897BE930-0x00000001897BE970
	public bool Add(string command, Func<string> action, string description = "" /* Metadata: 0x00B0CAD4 */) => default; // 0x00000001828CD950-0x00000001828CDA40
	// [IDTag] // 0x00000001897C8F80-0x00000001897C8FC0
	// [XID] // 0x00000001897C8F80-0x00000001897C8FC0
	public bool Add(string command, Func<string, string> action, string description = "" /* Metadata: 0x00B0CAD8 */) => default; // 0x00000001828CD320-0x00000001828CD410
	// [IDTag] // 0x00000001897D3530-0x00000001897D3570
	// [XID] // 0x00000001897D3530-0x00000001897D3570
	public bool Add(string command, Func<string, string, string> action, string description = "" /* Metadata: 0x00B0CADC */) => default; // 0x00000001828CD410-0x00000001828CD500
	// [IDTag] // 0x00000001897DDC60-0x00000001897DDCA0
	// [XID] // 0x00000001897DDC60-0x00000001897DDCA0
	public bool Add(string command, Func<string[], string> action, string description = "" /* Metadata: 0x00B0CAE0 */) => default; // 0x00000001828CDA40-0x00000001828CDB30
	// [IDTag] // 0x00000001897E8410-0x00000001897E8450
	// [XID] // 0x00000001897E8410-0x00000001897E8450
	public bool Add(string command, CommandDelegate action, string description = "" /* Metadata: 0x00B0CAE4 */) => default; // 0x00000001828CD5F0-0x00000001828CD6E0
	// [XID] // 0x00000001897F33C0-0x00000001897F33E0
	public bool Contains(string command) => default; // 0x00000001828CD1F0-0x00000001828CD320
	// [XID] // 0x00000001897FAC10-0x00000001897FAC30
	public bool Remove(string command) => default; // 0x00000001828CC320-0x00000001828CC450
	// [IDTag] // 0x0000000189802220-0x0000000189802260
	// [XID] // 0x0000000189802220-0x0000000189802260
	public bool Invoke(out object result, string command, object state, string arg) {
		result = default;
		return default;
	} // 0x00000001828CC450-0x00000001828CC690
	// [IDTag] // 0x000000018980C3B0-0x000000018980C3F0
	// [XID] // 0x000000018980C3B0-0x000000018980C3F0
	public bool Invoke(out object result, string command, string arg) {
		result = default;
		return default;
	} // 0x00000001828CC9F0-0x00000001828CCBF0
	// [IDTag] // 0x0000000189816E80-0x0000000189816EC0
	// [XID] // 0x0000000189816E80-0x0000000189816EC0
	public bool Invoke(out object result, string value, object state) {
		result = default;
		return default;
	} // 0x00000001828CC840-0x00000001828CC9F0
	// [IDTag] // 0x00000001898217A0-0x00000001898217E0
	// [XID] // 0x00000001898217A0-0x00000001898217E0
	public bool Invoke(out object result, string value) {
		result = default;
		return default;
	} // 0x00000001828CC690-0x00000001828CC840
	// [IDTag] // 0x000000018982BE00-0x000000018982BE40
	// [XID] // 0x000000018982BE00-0x000000018982BE40
	public bool InvokeArgs(out object result, string command, object state, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] args) {
		result = default;
		return default;
	} // 0x00000001828CBAF0-0x00000001828CBDA0
	// [IDTag] // 0x000000018983D7D0-0x000000018983D810
	// [XID] // 0x000000018983D7D0-0x000000018983D810
	private bool Add(string command, Delegate action, string description = "" /* Metadata: 0x00B0CAE8 */) => default; // 0x00000001828CD6E0-0x00000001828CD950
	// [IDTag] // 0x0000000189847BD0-0x0000000189847C10
	// [XID] // 0x0000000189847BD0-0x0000000189847C10
	private bool InvokeArgs(out object result, string command, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {
		result = default;
		return default;
	} // 0x00000001828CBDA0-0x00000001828CC320
	// [XID] // 0x0000000189859960-0x0000000189859980
	private string Help(string arg) => default; // 0x00000001828CCBF0-0x00000001828CD1F0
}


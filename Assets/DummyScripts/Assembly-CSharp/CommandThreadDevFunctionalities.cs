/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadDevFunctionalities : CommandThreadFunctionalities<SharedDevFunctionalities> // TypeDefIndex: 11269
{
	// Fields
	private const uint MAX_MESSAGE_ALLOWED = 100; // Metadata: 0x00AE954C
	private const string COUNTER_STOP_MESSAGE = "Maximum of {0} messages have been printed. Future messages will be ignored."; // Metadata: 0x00AE9550
	private const string EVENT_NOT_FOUND_REGEX = "Event ID not found: (\\d+)"; // Metadata: 0x00AE959F
	private readonly string _counterStopMessage; // 0x20
	private readonly Regex _eventNotFoundRegex; // 0x28
	private uint _numPrintedMessage; // 0x30
	private bool _hasPrintedCounterStopMessage; // 0x34

	// Constructors
	public CommandThreadDevFunctionalities() {} // Dummy constructor
	public CommandThreadDevFunctionalities(CommandThreadContext context, SharedDevFunctionalities shared) {} // 0x0000000182E98860-0x0000000182E98960

	// Methods
	// [XID] // 0x0000000189A35D20-0x0000000189A35D40
	public override void Init() {} // 0x0000000182E97E60-0x0000000182E97F00
	// [XID] // 0x000000018995B190-0x000000018995B1B0
	public override void Tick(float deltaTime) {} // 0x0000000182E97F00-0x0000000182E97FD0
	// [XID] // 0x000000018980D730-0x000000018980D750
	public override void EnterHomeWorld(bool firstTime) {} // 0x0000000182E98070-0x0000000182E98120
	// [XID] // 0x0000000189857770-0x0000000189857790
	public override void ExitHomeWorld() {} // 0x0000000182E981C0-0x0000000182E98260
	// [XID] // 0x0000000189971F10-0x0000000189971F30
	public override void ExitGameWorld() {} // 0x0000000182E98120-0x0000000182E981C0
	// [XID] // 0x0000000189A3D330-0x0000000189A3D350
	public override void CreateLevel() {} // 0x0000000182E97C80-0x0000000182E97D20
	// [XID] // 0x0000000189980980-0x00000001899809A0
	public override void EnterLevel() {} // 0x0000000182E97FD0-0x0000000182E98070
	// [XID] // 0x00000001897B4A90-0x00000001897B4AB0
	public override void ExitLevel() {} // 0x0000000182E97DC0-0x0000000182E97E60
	// [XID] // 0x00000001897BC9E0-0x00000001897BCA00
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x0000000182E98260-0x0000000182E98310
	// [XID] // 0x0000000189997670-0x0000000189997690
	public override void Destroy() {} // 0x0000000182E97D20-0x0000000182E97DC0
	// [XID] // 0x000000018999F1B0-0x000000018999F1D0
	public void PrintMonitorMessage(MonitorMessage monitorMessage) {} // 0x0000000182E98310-0x0000000182E98860
}


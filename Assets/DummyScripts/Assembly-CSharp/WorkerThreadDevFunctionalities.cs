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

public sealed class WorkerThreadDevFunctionalities : WorkerThreadFunctionalities<SharedDevFunctionalities> // TypeDefIndex: 11273
{
	// Fields
	private readonly MonitorMessageHandler _monitorMessageHandler; // 0x20

	// Nested types
	private class MonitorMessageHandler : IMmoronMonitorMessageHandler // TypeDefIndex: 11274
	{
		// Fields
		private readonly List<MonitorMessage> _messages; // 0x10

		// Properties
		public List<MonitorMessage> messages { /* [XID] */ /* 0x0000000189A6A4C0-0x0000000189A6A4E0 */ get => default; } // 0x0000000185133060-0x0000000185133100 

		// Constructors
		public MonitorMessageHandler() {} // 0x0000000185133100-0x0000000185133190

		// Methods
		// [XID] // 0x00000001899FF050-0x00000001899FF070
		public void HandleMessage(AkMonitorErrorCode errorCode, AkMonitorErrorLevel errorLevel, string error, uint playingId, ulong gameObjectId) {} // 0x0000000185132EB0-0x0000000185133060
	}

	// Constructors
	public WorkerThreadDevFunctionalities() {} // Dummy constructor
	public WorkerThreadDevFunctionalities(WorkerThreadContext context, SharedDevFunctionalities shared) {} // 0x0000000185128360-0x0000000185128410

	// Methods
	// [XID] // 0x0000000189A53730-0x0000000189A53750
	public override void Init() {} // 0x00000001851280A0-0x0000000185128180
	// [XID] // 0x00000001898EC720-0x00000001898EC740
	public override void Tick(TimeSpan deltaTime) {} // 0x0000000185128180-0x0000000185128360
	// [XID] // 0x00000001899F79B0-0x00000001899F79D0
	public override void Destroy() {} // 0x0000000185128000-0x00000001851280A0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientReportNotify : MessageBase, IMessage<ClientReportNotify> // TypeDefIndex: 23989
{
	// Fields
	private static readonly MessageParser<ClientReportNotify> _parser; // 0x00
	public const int ReportTypeFieldNumber = 1; // Metadata: 0x00B054B3
	private string reportType_; // 0x18
	public const int ReportValueFieldNumber = 2; // Metadata: 0x00B054B7
	private string reportValue_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientReportNotify> Parser { get => default; } // 0x0000000181D22B50-0x0000000181D22BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D228E0-0x0000000181D22970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D224D0-0x0000000181D22550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D21DD0-0x0000000181D21E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D22F10-0x0000000181D23000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D22D10-0x0000000181D22D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D22970-0x0000000181D22A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D22EC0-0x0000000181D22F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D226A0-0x0000000181D22790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ReportType { get => default; set {} } // 0x0000000181D23000-0x0000000181D230A0 0x0000000181D22060-0x0000000181D22110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ReportValue { get => default; set {} } // 0x0000000181D21D30-0x0000000181D21DD0 0x0000000181D22550-0x0000000181D22600

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23990
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23991
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 15
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientReportNotify() {} // 0x0000000181D23320-0x0000000181D233A0
	static ClientReportNotify() {} // 0x0000000181D23260-0x0000000181D23320

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientReportNotify Clone() => default; // 0x0000000181D22A60-0x0000000181D22B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientReportNotify ShallowCopy() => default; // 0x0000000181D22600-0x0000000181D226A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D21F90-0x0000000181D21FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D22C70-0x0000000181D22CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D22CC0-0x0000000181D22D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D21FE0-0x0000000181D22060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D222A0-0x0000000181D22370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientReportNotify other) => default; // 0x0000000181D22110-0x0000000181D222A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D22790-0x0000000181D228E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D230A0-0x0000000181D23260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D22D70-0x0000000181D22EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D22370-0x0000000181D224D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientReportNotify other) {} // 0x0000000181D21E30-0x0000000181D21F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D21C30-0x0000000181D21D30
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServerLogNotify : MessageBase, IMessage<ServerLogNotify> // TypeDefIndex: 23980
{
	// Fields
	private static readonly MessageParser<ServerLogNotify> _parser; // 0x00
	public const int LogTypeFieldNumber = 1; // Metadata: 0x00B0546F
	private ServerLogType logType_; // 0x18
	public const int LogLevelFieldNumber = 2; // Metadata: 0x00B05473
	private ServerLogLevel logLevel_; // 0x1C
	public const int ServerLogFieldNumber = 3; // Metadata: 0x00B05477
	private string serverLog_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServerLogNotify> Parser { get => default; } // 0x0000000183388A10-0x0000000183388AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833885B0-0x0000000183388640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833881D0-0x0000000183388250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183387A90-0x0000000183387AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183388E90-0x0000000183388F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183388C70-0x0000000183388CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183388790-0x0000000183388880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183388E40-0x0000000183388E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833882F0-0x00000001833883E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerLogType LogType { get => default; set {} } // 0x0000000183388970-0x0000000183388A10 0x0000000183388B80-0x0000000183388C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerLogLevel LogLevel { get => default; set {} } // 0x0000000183388640-0x00000001833886E0 0x0000000183388F80-0x0000000183389020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ServerLog { get => default; set {} } // 0x0000000183387AF0-0x0000000183387B90 0x00000001833886E0-0x0000000183388790

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23981
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23982
		{
			None = 0,
			EnetChannelId = 1,
			EnetIsReliable = 1,
			CmdId = 11
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerLogNotify() {} // 0x0000000183389350-0x00000001833893D0
	static ServerLogNotify() {} // 0x0000000183389290-0x0000000183389350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerLogNotify Clone() => default; // 0x0000000183388880-0x0000000183388970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerLogNotify ShallowCopy() => default; // 0x0000000183388250-0x00000001833882F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183387D10-0x0000000183387D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183388B30-0x0000000183388B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183388C20-0x0000000183388C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183387D60-0x0000000183387DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183387DF0-0x0000000183387EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServerLogNotify other) => default; // 0x0000000183387EC0-0x0000000183388030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833883E0-0x00000001833885B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183389020-0x0000000183389290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183388CD0-0x0000000183388E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183388030-0x00000001833881D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServerLogNotify other) {} // 0x0000000183387B90-0x0000000183387D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183387990-0x0000000183387A90
}


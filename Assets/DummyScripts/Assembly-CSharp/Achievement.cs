/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Achievement : MessageBase, IMessage<Achievement> // TypeDefIndex: 21828
{
	// Fields
	private static readonly MessageParser<Achievement> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B00163
	private uint id_; // 0x18
	public const int StatusFieldNumber = 2; // Metadata: 0x00B00167
	private Types.Status status_; // 0x1C
	public const int CurProgressFieldNumber = 3; // Metadata: 0x00B0016B
	private uint curProgress_; // 0x20
	public const int TotalProgressFieldNumber = 4; // Metadata: 0x00B0016F
	private uint totalProgress_; // 0x24
	public const int FinishTimestampFieldNumber = 5; // Metadata: 0x00B00173
	private uint finishTimestamp_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Achievement> Parser { get => default; } // 0x000000018340DA90-0x000000018340DB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018340D5A0-0x000000018340D630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018340D070-0x000000018340D0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018340C880-0x000000018340C8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018340E020-0x000000018340E110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018340DCF0-0x000000018340DD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018340D770-0x000000018340D860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018340DFD0-0x000000018340E020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018340D230-0x000000018340D320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x000000018340CFD0-0x000000018340D070 0x000000018340DB20-0x000000018340DBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Status Status { get => default; set {} } // 0x000000018340D190-0x000000018340D230 0x000000018340D500-0x000000018340D5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurProgress { get => default; set {} } // 0x000000018340D950-0x000000018340D9F0 0x000000018340D9F0-0x000000018340DA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalProgress { get => default; set {} } // 0x000000018340DF30-0x000000018340DFD0 0x000000018340C7E0-0x000000018340C880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishTimestamp { get => default; set {} } // 0x000000018340D630-0x000000018340D6D0 0x000000018340D6D0-0x000000018340D770

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21829
	{
		// Nested types
		public enum Status // TypeDefIndex: 21830
		{
			Invalid = 0,
			Unfinished = 1,
			Finished = 2,
			RewardTaken = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Achievement() {} // 0x000000018340E570-0x000000018340E5E0
	static Achievement() {} // 0x000000018340E4B0-0x000000018340E570

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Achievement Clone() => default; // 0x000000018340D860-0x000000018340D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Achievement ShallowCopy() => default; // 0x000000018340D0F0-0x000000018340D190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018340CA90-0x000000018340CAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018340DC50-0x000000018340DCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018340DCA0-0x000000018340DCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018340CAE0-0x000000018340CB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018340CCF0-0x000000018340CDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Achievement other) => default; // 0x000000018340CB80-0x000000018340CCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018340D320-0x000000018340D500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018340E110-0x000000018340E4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018340DD50-0x000000018340DF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018340CDC0-0x000000018340CFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Achievement other) {} // 0x000000018340C8E0-0x000000018340CA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018340C690-0x000000018340C7E0
}


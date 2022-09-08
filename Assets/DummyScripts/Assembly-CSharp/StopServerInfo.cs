/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StopServerInfo : MessageBase, IMessage<StopServerInfo> // TypeDefIndex: 25966
{
	// Fields
	private static readonly MessageParser<StopServerInfo> _parser; // 0x00
	public const int StopBeginTimeFieldNumber = 1; // Metadata: 0x00B0A7AF
	private uint stopBeginTime_; // 0x18
	public const int StopEndTimeFieldNumber = 2; // Metadata: 0x00B0A7B3
	private uint stopEndTime_; // 0x1C
	public const int UrlFieldNumber = 3; // Metadata: 0x00B0A7B7
	private string url_; // 0x20
	public const int ContentMsgFieldNumber = 4; // Metadata: 0x00B0A7BB
	private string contentMsg_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StopServerInfo> Parser { get => default; } // 0x000000018362C870-0x000000018362C900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018362C560-0x000000018362C5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018362C100-0x000000018362C180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018362B6D0-0x000000018362B730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018362CDF0-0x000000018362CEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018362CB70-0x000000018362CBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018362C5F0-0x000000018362C6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018362CDA0-0x000000018362CDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018362C220-0x000000018362C310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StopBeginTime { get => default; set {} } // 0x000000018362BBD0-0x000000018362BC70 0x000000018362C990-0x000000018362CA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StopEndTime { get => default; set {} } // 0x000000018362C4C0-0x000000018362C560 0x000000018362B990-0x000000018362BA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Url { get => default; set {} } // 0x000000018362CAD0-0x000000018362CB70 0x000000018362BA80-0x000000018362BB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ContentMsg { get => default; set {} } // 0x000000018362C7D0-0x000000018362C870 0x000000018362B730-0x000000018362B7E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StopServerInfo() {} // 0x000000018362D280-0x000000018362D300
	static StopServerInfo() {} // 0x000000018362D1C0-0x000000018362D280

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StopServerInfo Clone() => default; // 0x000000018362C6E0-0x000000018362C7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StopServerInfo ShallowCopy() => default; // 0x000000018362C180-0x000000018362C220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018362BA30-0x000000018362BA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018362CA30-0x000000018362CA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018362CA80-0x000000018362CAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018362BB30-0x000000018362BBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018362BE30-0x000000018362BF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StopServerInfo other) => default; // 0x000000018362BC70-0x000000018362BE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018362C310-0x000000018362C4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018362CEE0-0x000000018362D1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018362CBD0-0x000000018362CDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018362BF00-0x000000018362C100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StopServerInfo other) {} // 0x000000018362B7E0-0x000000018362B990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018362B5A0-0x000000018362B6D0
}


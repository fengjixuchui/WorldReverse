/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReportTrackingIOInfoNotify : MessageBase, IMessage<ReportTrackingIOInfoNotify> // TypeDefIndex: 24713
{
	// Fields
	private static readonly MessageParser<ReportTrackingIOInfoNotify> _parser; // 0x00
	public const int AppidFieldNumber = 1; // Metadata: 0x00B070EF
	private string appid_; // 0x18
	public const int DeviceidFieldNumber = 2; // Metadata: 0x00B070F3
	private string deviceid_; // 0x20
	public const int MacFieldNumber = 3; // Metadata: 0x00B070F7
	private string mac_; // 0x28
	public const int RydevicetypeFieldNumber = 4; // Metadata: 0x00B070FB
	private string rydevicetype_; // 0x30
	public const int ClientTzFieldNumber = 5; // Metadata: 0x00B070FF
	private string clientTz_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReportTrackingIOInfoNotify> Parser { get => default; } // 0x00000001825614E0-0x0000000182561570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182560DE0-0x0000000182560E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182560820-0x00000001825608A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018255FEB0-0x000000018255FF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182561A50-0x0000000182561B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182561740-0x00000001825617A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182560FC0-0x00000001825610B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182561A00-0x0000000182561A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182560940-0x0000000182560A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Appid { get => default; set {} } // 0x0000000182560E70-0x0000000182560F10 0x0000000182561160-0x0000000182561210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Deviceid { get => default; set {} } // 0x00000001825613A0-0x0000000182561440 0x0000000182560F10-0x0000000182560FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Mac { get => default; set {} } // 0x00000001825616A0-0x0000000182561740 0x0000000182560D30-0x0000000182560DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Rydevicetype { get => default; set {} } // 0x0000000182561300-0x00000001825613A0 0x0000000182560C80-0x0000000182560D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientTz { get => default; set {} } // 0x0000000182561440-0x00000001825614E0 0x00000001825610B0-0x0000000182561160

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24714
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24715
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4107
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReportTrackingIOInfoNotify() {} // 0x0000000182561F20-0x0000000182561FC0
	static ReportTrackingIOInfoNotify() {} // 0x0000000182561E60-0x0000000182561F20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReportTrackingIOInfoNotify Clone() => default; // 0x0000000182561210-0x0000000182561300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReportTrackingIOInfoNotify ShallowCopy() => default; // 0x00000001825608A0-0x0000000182560940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182560130-0x0000000182560180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182561600-0x0000000182561650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182561650-0x00000001825616A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182560180-0x0000000182560230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182560230-0x0000000182560300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReportTrackingIOInfoNotify other) => default; // 0x0000000182560300-0x0000000182560580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182560A30-0x0000000182560C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182561B40-0x0000000182561E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825617A0-0x0000000182561A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182560580-0x0000000182560820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReportTrackingIOInfoNotify other) {} // 0x000000018255FF10-0x0000000182560130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018255FD50-0x000000018255FEB0
}


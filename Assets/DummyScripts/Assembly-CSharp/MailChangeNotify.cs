/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MailChangeNotify : MessageBase, IMessage<MailChangeNotify> // TypeDefIndex: 23789
{
	// Fields
	private static readonly MessageParser<MailChangeNotify> _parser; // 0x00
	public const int MailListFieldNumber = 1; // Metadata: 0x00B04D43
	private static readonly FieldCodec<MailData> _repeated_mailList_codec; // 0x08
	private readonly RepeatedMessageField<MailData> mailList_; // 0x18
	public const int DelMailIdListFieldNumber = 2; // Metadata: 0x00B04D47
	private static readonly FieldCodec<uint> _repeated_delMailIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> delMailIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MailChangeNotify> Parser { get => default; } // 0x00000001838E0E40-0x00000001838E0ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838E0BD0-0x00000001838E0C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838E08D0-0x00000001838E0950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838E01B0-0x00000001838E0210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838E1260-0x00000001838E1350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838E1080-0x00000001838E10E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838E0C60-0x00000001838E0D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838E1210-0x00000001838E1260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838E09F0-0x00000001838E0AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MailData> MailList { get => default; } // 0x00000001838E0810-0x00000001838E0870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> DelMailIdList { get => default; } // 0x00000001838E0870-0x00000001838E08D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23790
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23791
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1402
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailChangeNotify() {} // 0x00000001838E1640-0x00000001838E16F0
	static MailChangeNotify() {} // 0x00000001838E1510-0x00000001838E1640

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailChangeNotify Clone() => default; // 0x00000001838E0D50-0x00000001838E0E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailChangeNotify ShallowCopy() => default; // 0x00000001838E0950-0x00000001838E09F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838E0370-0x00000001838E03C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838E0F60-0x00000001838E0FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838E0FF0-0x00000001838E1080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838E03C0-0x00000001838E04F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838E0620-0x00000001838E06F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MailChangeNotify other) => default; // 0x00000001838E04F0-0x00000001838E0620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838E0AE0-0x00000001838E0BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838E1350-0x00000001838E1510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838E10E0-0x00000001838E1210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838E06F0-0x00000001838E0810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MailChangeNotify other) {} // 0x00000001838E0210-0x00000001838E0370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838E0000-0x00000001838E01B0
}


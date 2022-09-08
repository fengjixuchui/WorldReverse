/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientCollectorDataNotify : MessageBase, IMessage<ClientCollectorDataNotify> // TypeDefIndex: 25850
{
	// Fields
	private static readonly MessageParser<ClientCollectorDataNotify> _parser; // 0x00
	public const int ClientCollectorDataListFieldNumber = 1; // Metadata: 0x00B09B6B
	private static readonly FieldCodec<ClientCollectorData> _repeated_clientCollectorDataList_codec; // 0x08
	private readonly RepeatedMessageField<ClientCollectorData> clientCollectorDataList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientCollectorDataNotify> Parser { get => default; } // 0x000000018191E2C0-0x000000018191E350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018191E050-0x000000018191E0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018191DD80-0x000000018191DE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018191D7A0-0x000000018191D800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018191E6B0-0x000000018191E7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018191E500-0x000000018191E560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018191E0E0-0x000000018191E1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018191E660-0x000000018191E6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018191DEA0-0x000000018191DF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ClientCollectorData> ClientCollectorDataList { get => default; } // 0x000000018191DD20-0x000000018191DD80 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25851
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25852
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4265
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientCollectorDataNotify() {} // 0x000000018191EA00-0x000000018191EA90
	static ClientCollectorDataNotify() {} // 0x000000018191E8F0-0x000000018191EA00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientCollectorDataNotify Clone() => default; // 0x000000018191E1D0-0x000000018191E2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientCollectorDataNotify ShallowCopy() => default; // 0x000000018191DE00-0x000000018191DEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018191D930-0x000000018191D980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018191E3E0-0x000000018191E470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018191E470-0x000000018191E500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018191D980-0x000000018191DA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018191DB60-0x000000018191DC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientCollectorDataNotify other) => default; // 0x000000018191DA50-0x000000018191DB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018191DF90-0x000000018191E050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018191E7A0-0x000000018191E8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018191E560-0x000000018191E660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018191DC30-0x000000018191DD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientCollectorDataNotify other) {} // 0x000000018191D800-0x000000018191D930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018191D670-0x000000018191D7A0
}


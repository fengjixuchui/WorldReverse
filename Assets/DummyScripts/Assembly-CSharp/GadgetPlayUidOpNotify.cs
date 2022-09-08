/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetPlayUidOpNotify : MessageBase, IMessage<GadgetPlayUidOpNotify> // TypeDefIndex: 23210
{
	// Fields
	private static readonly MessageParser<GadgetPlayUidOpNotify> _parser; // 0x00
	public const int PlayTypeFieldNumber = 1; // Metadata: 0x00B037DF
	private uint playType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B037E3
	private uint entityId_; // 0x1C
	public const int UidListFieldNumber = 3; // Metadata: 0x00B037E7
	private static readonly FieldCodec<uint> _repeated_uidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> uidList_; // 0x20
	public const int OpFieldNumber = 4; // Metadata: 0x00B037EB
	private uint op_; // 0x28
	public const int ParamStrFieldNumber = 5; // Metadata: 0x00B037EF
	private string paramStr_; // 0x30
	public const int ParamListFieldNumber = 6; // Metadata: 0x00B037F3
	private static readonly FieldCodec<uint> _repeated_paramList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> paramList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetPlayUidOpNotify> Parser { get => default; } // 0x0000000182437860-0x00000001824378F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001824374B0-0x0000000182437540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182436F80-0x0000000182437000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001824365B0-0x0000000182436610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182437F40-0x0000000182438030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182437AC0-0x0000000182437B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182437680-0x0000000182437770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182437E90-0x0000000182437EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182437150-0x0000000182437240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x0000000182437B20-0x0000000182437BC0 0x00000001824369A0-0x0000000182436A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182437A20-0x0000000182437AC0 0x0000000182438030-0x00000001824380D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UidList { get => default; } // 0x0000000182437EE0-0x0000000182437F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Op { get => default; set {} } // 0x00000001824375E0-0x0000000182437680 0x0000000182437410-0x00000001824374B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ParamStr { get => default; set {} } // 0x0000000182437540-0x00000001824375E0 0x00000001824370A0-0x0000000182437150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamList { get => default; } // 0x0000000182437BC0-0x0000000182437C20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23211
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23212
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 812
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayUidOpNotify() {} // 0x00000001824385B0-0x0000000182438670
	static GadgetPlayUidOpNotify() {} // 0x00000001824384B0-0x00000001824385B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayUidOpNotify Clone() => default; // 0x0000000182437770-0x0000000182437860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayUidOpNotify ShallowCopy() => default; // 0x0000000182437000-0x00000001824370A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001824367F0-0x0000000182436840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182437980-0x00000001824379D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824379D0-0x0000000182437A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182436840-0x00000001824369A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182436C20-0x0000000182436CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetPlayUidOpNotify other) => default; // 0x0000000182436A40-0x0000000182436C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182437240-0x0000000182437410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001824380D0-0x00000001824384B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182437C20-0x0000000182437E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182436CF0-0x0000000182436F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetPlayUidOpNotify other) {} // 0x0000000182436610-0x00000001824367F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182436370-0x00000001824365B0
}


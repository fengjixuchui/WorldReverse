/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SaveMainCoopRsp : MessageBase, IMessage<SaveMainCoopRsp> // TypeDefIndex: 22686
{
	// Fields
	private static readonly MessageParser<SaveMainCoopRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02263
	private int retcode_; // 0x18
	public const int IdFieldNumber = 2; // Metadata: 0x00B02267
	private uint id_; // 0x1C
	public const int SavePointIdListFieldNumber = 3; // Metadata: 0x00B0226B
	private static readonly FieldCodec<uint> _repeated_savePointIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> savePointIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SaveMainCoopRsp> Parser { get => default; } // 0x000000018545D620-0x000000018545D6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018545D3B0-0x000000018545D440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018545D070-0x000000018545D0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018545C810-0x000000018545C870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018545DB00-0x000000018545DBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018545D8E0-0x000000018545D940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018545D440-0x000000018545D530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018545DAB0-0x000000018545DB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018545D190-0x000000018545D280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018545CF30-0x000000018545CFD0 0x000000018545CAF0-0x000000018545CB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x000000018545CFD0-0x000000018545D070 0x000000018545D6B0-0x000000018545D750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> SavePointIdList { get => default; } // 0x000000018545D880-0x000000018545D8E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22687
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22688
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1954
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveMainCoopRsp() {} // 0x000000018545DF40-0x000000018545DFD0
	static SaveMainCoopRsp() {} // 0x000000018545DE60-0x000000018545DF40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveMainCoopRsp Clone() => default; // 0x000000018545D530-0x000000018545D620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveMainCoopRsp ShallowCopy() => default; // 0x000000018545D0F0-0x000000018545D190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018545C9D0-0x000000018545CA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018545D7E0-0x000000018545D830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018545D830-0x000000018545D880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018545CA20-0x000000018545CAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018545CB90-0x000000018545CC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SaveMainCoopRsp other) => default; // 0x000000018545CC60-0x000000018545CDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018545D280-0x000000018545D3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018545DBF0-0x000000018545DE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018545D940-0x000000018545DAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018545CDA0-0x000000018545CF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SaveMainCoopRsp other) {} // 0x000000018545C870-0x000000018545C9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018545C690-0x000000018545C810
}


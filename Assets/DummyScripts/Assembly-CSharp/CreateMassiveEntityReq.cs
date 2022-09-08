/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CreateMassiveEntityReq : MessageBase, IMessage<CreateMassiveEntityReq> // TypeDefIndex: 23104
{
	// Fields
	private static readonly MessageParser<CreateMassiveEntityReq> _parser; // 0x00
	public const int MassiveEntityListFieldNumber = 1; // Metadata: 0x00B0334B
	private static readonly FieldCodec<ClientMassiveEntity> _repeated_massiveEntityList_codec; // 0x08
	private readonly RepeatedMessageField<ClientMassiveEntity> massiveEntityList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CreateMassiveEntityReq> Parser { get => default; } // 0x0000000181A0E450-0x0000000181A0E4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A0E1E0-0x0000000181A0E270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A0DF10-0x0000000181A0DF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A0D930-0x0000000181A0D990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A0E840-0x0000000181A0E930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A0E690-0x0000000181A0E6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A0E270-0x0000000181A0E360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A0E7F0-0x0000000181A0E840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A0E030-0x0000000181A0E120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ClientMassiveEntity> MassiveEntityList { get => default; } // 0x0000000181A0D990-0x0000000181A0D9F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23105
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23106
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 343
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateMassiveEntityReq() {} // 0x0000000181A0EB90-0x0000000181A0EC20
	static CreateMassiveEntityReq() {} // 0x0000000181A0EA80-0x0000000181A0EB90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateMassiveEntityReq Clone() => default; // 0x0000000181A0E360-0x0000000181A0E450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateMassiveEntityReq ShallowCopy() => default; // 0x0000000181A0DF90-0x0000000181A0E030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A0DB20-0x0000000181A0DB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A0E570-0x0000000181A0E600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A0E600-0x0000000181A0E690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A0DB70-0x0000000181A0DC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A0DC40-0x0000000181A0DD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CreateMassiveEntityReq other) => default; // 0x0000000181A0DD10-0x0000000181A0DE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A0E120-0x0000000181A0E1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A0E930-0x0000000181A0EA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A0E6F0-0x0000000181A0E7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A0DE20-0x0000000181A0DF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CreateMassiveEntityReq other) {} // 0x0000000181A0D9F0-0x0000000181A0DB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A0D800-0x0000000181A0D930
}


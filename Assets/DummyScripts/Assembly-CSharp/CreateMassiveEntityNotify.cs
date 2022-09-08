/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CreateMassiveEntityNotify : MessageBase, IMessage<CreateMassiveEntityNotify> // TypeDefIndex: 23110
{
	// Fields
	private static readonly MessageParser<CreateMassiveEntityNotify> _parser; // 0x00
	public const int MassiveEntityListFieldNumber = 1; // Metadata: 0x00B03377
	private static readonly FieldCodec<ServerMassiveEntity> _repeated_massiveEntityList_codec; // 0x08
	private readonly RepeatedMessageField<ServerMassiveEntity> massiveEntityList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CreateMassiveEntityNotify> Parser { get => default; } // 0x00000001847A3530-0x00000001847A35C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001847A32C0-0x00000001847A3350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001847A2FF0-0x00000001847A3070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001847A2A10-0x00000001847A2A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001847A3920-0x00000001847A3A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001847A3770-0x00000001847A37D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001847A3350-0x00000001847A3440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001847A38D0-0x00000001847A3920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001847A3110-0x00000001847A3200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ServerMassiveEntity> MassiveEntityList { get => default; } // 0x00000001847A2A70-0x00000001847A2AD0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23111
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23112
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 345
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateMassiveEntityNotify() {} // 0x00000001847A3C70-0x00000001847A3D00
	static CreateMassiveEntityNotify() {} // 0x00000001847A3B60-0x00000001847A3C70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateMassiveEntityNotify Clone() => default; // 0x00000001847A3440-0x00000001847A3530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateMassiveEntityNotify ShallowCopy() => default; // 0x00000001847A3070-0x00000001847A3110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001847A2C00-0x00000001847A2C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001847A3650-0x00000001847A36E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001847A36E0-0x00000001847A3770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001847A2C50-0x00000001847A2D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001847A2E30-0x00000001847A2F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CreateMassiveEntityNotify other) => default; // 0x00000001847A2D20-0x00000001847A2E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001847A3200-0x00000001847A32C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001847A3A10-0x00000001847A3B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001847A37D0-0x00000001847A38D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001847A2F00-0x00000001847A2FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CreateMassiveEntityNotify other) {} // 0x00000001847A2AD0-0x00000001847A2C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001847A28E0-0x00000001847A2A10
}


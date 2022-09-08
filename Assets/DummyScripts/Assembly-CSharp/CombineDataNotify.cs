/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CombineDataNotify : MessageBase, IMessage<CombineDataNotify> // TypeDefIndex: 23776
{
	// Fields
	private static readonly MessageParser<CombineDataNotify> _parser; // 0x00
	public const int CombineIdListFieldNumber = 1; // Metadata: 0x00B04CD7
	private static readonly FieldCodec<uint> _repeated_combineIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> combineIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CombineDataNotify> Parser { get => default; } // 0x00000001819B3470-0x00000001819B3500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001819B3200-0x00000001819B3290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001819B2F30-0x00000001819B2FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001819B2990-0x00000001819B29F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001819B37E0-0x00000001819B38D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001819B3630-0x00000001819B3690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001819B3290-0x00000001819B3380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001819B3790-0x00000001819B37E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001819B3050-0x00000001819B3140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CombineIdList { get => default; } // 0x00000001819B2ED0-0x00000001819B2F30 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23777
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23778
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 665
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineDataNotify() {} // 0x00000001819B3B00-0x00000001819B3B90
	static CombineDataNotify() {} // 0x00000001819B3A20-0x00000001819B3B00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineDataNotify Clone() => default; // 0x00000001819B3380-0x00000001819B3470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineDataNotify ShallowCopy() => default; // 0x00000001819B2FB0-0x00000001819B3050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001819B2B00-0x00000001819B2B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819B3590-0x00000001819B35E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819B35E0-0x00000001819B3630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001819B2B50-0x00000001819B2C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001819B2C10-0x00000001819B2CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CombineDataNotify other) => default; // 0x00000001819B2CE0-0x00000001819B2DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001819B3140-0x00000001819B3200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001819B38D0-0x00000001819B3A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001819B3690-0x00000001819B3790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001819B2DE0-0x00000001819B2ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CombineDataNotify other) {} // 0x00000001819B29F0-0x00000001819B2B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001819B2850-0x00000001819B2990
}


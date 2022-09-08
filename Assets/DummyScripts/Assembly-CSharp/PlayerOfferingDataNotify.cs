/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerOfferingDataNotify : MessageBase, IMessage<PlayerOfferingDataNotify> // TypeDefIndex: 24223
{
	// Fields
	private static readonly MessageParser<PlayerOfferingDataNotify> _parser; // 0x00
	public const int OfferingDataListFieldNumber = 1; // Metadata: 0x00B05E27
	private static readonly FieldCodec<PlayerOfferingData> _repeated_offeringDataList_codec; // 0x08
	private readonly RepeatedMessageField<PlayerOfferingData> offeringDataList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerOfferingDataNotify> Parser { get => default; } // 0x0000000182081130-0x00000001820811C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182080EC0-0x0000000182080F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182080BF0-0x0000000182080C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182080670-0x00000001820806D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182081520-0x0000000182081610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182081370-0x00000001820813D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182080F50-0x0000000182081040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820814D0-0x0000000182081520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182080D10-0x0000000182080E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PlayerOfferingData> OfferingDataList { get => default; } // 0x0000000182080610-0x0000000182080670 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24224
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24225
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2901
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerOfferingDataNotify() {} // 0x0000000182081870-0x0000000182081900
	static PlayerOfferingDataNotify() {} // 0x0000000182081760-0x0000000182081870

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerOfferingDataNotify Clone() => default; // 0x0000000182081040-0x0000000182081130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerOfferingDataNotify ShallowCopy() => default; // 0x0000000182080C70-0x0000000182080D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182080800-0x0000000182080850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182081250-0x00000001820812E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820812E0-0x0000000182081370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182080850-0x0000000182080920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182080920-0x00000001820809F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerOfferingDataNotify other) => default; // 0x00000001820809F0-0x0000000182080B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182080E00-0x0000000182080EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182081610-0x0000000182081760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820813D0-0x00000001820814D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182080B00-0x0000000182080BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerOfferingDataNotify other) {} // 0x00000001820806D0-0x0000000182080800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820804E0-0x0000000182080610
}


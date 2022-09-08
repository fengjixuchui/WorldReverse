/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSatiationDataNotify : MessageBase, IMessage<AvatarSatiationDataNotify> // TypeDefIndex: 22503
{
	// Fields
	private static readonly MessageParser<AvatarSatiationDataNotify> _parser; // 0x00
	public const int SatiationDataListFieldNumber = 1; // Metadata: 0x00B01BAF
	private static readonly FieldCodec<AvatarSatiationData> _repeated_satiationDataList_codec; // 0x08
	private readonly RepeatedMessageField<AvatarSatiationData> satiationDataList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarSatiationDataNotify> Parser { get => default; } // 0x000000018134D1E0-0x000000018134D270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018134CF70-0x000000018134D000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018134CCA0-0x000000018134CD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018134C6C0-0x000000018134C720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018134D5D0-0x000000018134D6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018134D420-0x000000018134D480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018134D000-0x000000018134D0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018134D580-0x000000018134D5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018134CDC0-0x000000018134CEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AvatarSatiationData> SatiationDataList { get => default; } // 0x000000018134C720-0x000000018134C780 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22504
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22505
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1742
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSatiationDataNotify() {} // 0x000000018134D920-0x000000018134D9B0
	static AvatarSatiationDataNotify() {} // 0x000000018134D810-0x000000018134D920

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSatiationDataNotify Clone() => default; // 0x000000018134D0F0-0x000000018134D1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSatiationDataNotify ShallowCopy() => default; // 0x000000018134CD20-0x000000018134CDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018134C8B0-0x000000018134C900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018134D300-0x000000018134D390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018134D390-0x000000018134D420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018134C900-0x000000018134C9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018134CAE0-0x000000018134CBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarSatiationDataNotify other) => default; // 0x000000018134C9D0-0x000000018134CAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018134CEB0-0x000000018134CF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018134D6C0-0x000000018134D810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018134D480-0x000000018134D580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018134CBB0-0x000000018134CCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarSatiationDataNotify other) {} // 0x000000018134C780-0x000000018134C8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018134C590-0x000000018134C6C0
}


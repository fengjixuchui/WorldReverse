/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BossChestActivateNotify : MessageBase, IMessage<BossChestActivateNotify> // TypeDefIndex: 23194
{
	// Fields
	private static readonly MessageParser<BossChestActivateNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B03737
	private uint entityId_; // 0x18
	public const int QualifyUidListFieldNumber = 2; // Metadata: 0x00B0373B
	private static readonly FieldCodec<uint> _repeated_qualifyUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> qualifyUidList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BossChestActivateNotify> Parser { get => default; } // 0x00000001846682A0-0x0000000184668330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184667FD0-0x0000000184668060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184667CC0-0x0000000184667D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001846676E0-0x0000000184667740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846686F0-0x00000001846687E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184668500-0x0000000184668560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001846680C0-0x00000001846681B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001846686A0-0x00000001846686F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184667DE0-0x0000000184667ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184668460-0x0000000184668500 0x00000001846687E0-0x0000000184668880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> QualifyUidList { get => default; } // 0x0000000184668060-0x00000001846680C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23195
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23196
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 807
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BossChestActivateNotify() {} // 0x0000000184668B40-0x0000000184668BD0
	static BossChestActivateNotify() {} // 0x0000000184668A60-0x0000000184668B40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BossChestActivateNotify Clone() => default; // 0x00000001846681B0-0x00000001846682A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BossChestActivateNotify ShallowCopy() => default; // 0x0000000184667D40-0x0000000184667DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184667870-0x00000001846678C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846683C0-0x0000000184668410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184668410-0x0000000184668460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001846678C0-0x0000000184667980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184667AB0-0x0000000184667B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BossChestActivateNotify other) => default; // 0x0000000184667980-0x0000000184667AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184667ED0-0x0000000184667FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184668880-0x0000000184668A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184668560-0x00000001846686A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184667B80-0x0000000184667CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BossChestActivateNotify other) {} // 0x0000000184667740-0x0000000184667870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184667570-0x00000001846676E0
}


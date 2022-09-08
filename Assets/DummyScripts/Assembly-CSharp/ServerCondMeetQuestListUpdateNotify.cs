/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServerCondMeetQuestListUpdateNotify : MessageBase, IMessage<ServerCondMeetQuestListUpdateNotify> // TypeDefIndex: 24654
{
	// Fields
	private static readonly MessageParser<ServerCondMeetQuestListUpdateNotify> _parser; // 0x00
	public const int AddQuestIdListFieldNumber = 1; // Metadata: 0x00B06EDF
	private static readonly FieldCodec<uint> _repeated_addQuestIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> addQuestIdList_; // 0x18
	public const int DelQuestIdListFieldNumber = 2; // Metadata: 0x00B06EE3
	private static readonly FieldCodec<uint> _repeated_delQuestIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> delQuestIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServerCondMeetQuestListUpdateNotify> Parser { get => default; } // 0x0000000181C796B0-0x0000000181C79740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181C79380-0x0000000181C79410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181C79080-0x0000000181C79100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181C78A70-0x0000000181C78AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181C79A50-0x0000000181C79B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181C79870-0x0000000181C798D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181C79470-0x0000000181C79560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181C79A00-0x0000000181C79A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181C791A0-0x0000000181C79290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AddQuestIdList { get => default; } // 0x0000000181C79410-0x0000000181C79470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> DelQuestIdList { get => default; } // 0x0000000181C79650-0x0000000181C796B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24655
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24656
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 431
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerCondMeetQuestListUpdateNotify() {} // 0x0000000181C79E00-0x0000000181C79EB0
	static ServerCondMeetQuestListUpdateNotify() {} // 0x0000000181C79D00-0x0000000181C79E00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerCondMeetQuestListUpdateNotify Clone() => default; // 0x0000000181C79560-0x0000000181C79650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerCondMeetQuestListUpdateNotify ShallowCopy() => default; // 0x0000000181C79100-0x0000000181C791A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181C78C00-0x0000000181C78C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C797D0-0x0000000181C79820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C79820-0x0000000181C79870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181C78C50-0x0000000181C78D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181C78D70-0x0000000181C78E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServerCondMeetQuestListUpdateNotify other) => default; // 0x0000000181C78E40-0x0000000181C78F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181C79290-0x0000000181C79380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181C79B40-0x0000000181C79D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181C798D0-0x0000000181C79A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181C78F60-0x0000000181C79080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServerCondMeetQuestListUpdateNotify other) {} // 0x0000000181C78AD0-0x0000000181C78C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181C788B0-0x0000000181C78A70
}


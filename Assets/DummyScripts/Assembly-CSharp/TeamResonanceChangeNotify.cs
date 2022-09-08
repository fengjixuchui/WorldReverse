/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TeamResonanceChangeNotify : MessageBase, IMessage<TeamResonanceChangeNotify> // TypeDefIndex: 25526
{
	// Fields
	private static readonly MessageParser<TeamResonanceChangeNotify> _parser; // 0x00
	public const int InfoListFieldNumber = 1; // Metadata: 0x00B08F7F
	private static readonly FieldCodec<AvatarTeamResonanceInfo> _repeated_infoList_codec; // 0x08
	private readonly RepeatedMessageField<AvatarTeamResonanceInfo> infoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TeamResonanceChangeNotify> Parser { get => default; } // 0x0000000183683640-0x00000001836836D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836833D0-0x0000000183683460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183683100-0x0000000183683180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183682B20-0x0000000183682B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183683A30-0x0000000183683B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183683880-0x00000001836838E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183683460-0x0000000183683550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836839E0-0x0000000183683A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183683220-0x0000000183683310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AvatarTeamResonanceInfo> InfoList { get => default; } // 0x0000000183682DD0-0x0000000183682E30 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25527
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25528
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1017
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamResonanceChangeNotify() {} // 0x0000000183683D80-0x0000000183683E10
	static TeamResonanceChangeNotify() {} // 0x0000000183683C70-0x0000000183683D80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamResonanceChangeNotify Clone() => default; // 0x0000000183683550-0x0000000183683640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamResonanceChangeNotify ShallowCopy() => default; // 0x0000000183683180-0x0000000183683220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183682CB0-0x0000000183682D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183683760-0x00000001836837F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836837F0-0x0000000183683880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183682D00-0x0000000183682DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183682E30-0x0000000183682F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TeamResonanceChangeNotify other) => default; // 0x0000000183682F00-0x0000000183683010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183683310-0x00000001836833D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183683B20-0x0000000183683C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836838E0-0x00000001836839E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183683010-0x0000000183683100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TeamResonanceChangeNotify other) {} // 0x0000000183682B80-0x0000000183682CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836829F0-0x0000000183682B20
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAiSyncSkillCdNotify : MessageBase, IMessage<EvtAiSyncSkillCdNotify> // TypeDefIndex: 23092
{
	// Fields
	private static readonly MessageParser<EvtAiSyncSkillCdNotify> _parser; // 0x00
	public const int AiCdMapFieldNumber = 1; // Metadata: 0x00B032D3
	private static readonly MapField<uint, AiSkillCdInfo> _map_aiCdMap_codec; // 0x08
	private readonly MapField<uint, AiSkillCdInfo> aiCdMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtAiSyncSkillCdNotify> Parser { get => default; } // 0x0000000182414780-0x0000000182414810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182414510-0x00000001824145A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182414210-0x0000000182414290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182413C60-0x0000000182413CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182414B50-0x0000000182414C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182414940-0x00000001824149A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824145A0-0x0000000182414690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182414B00-0x0000000182414B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182414330-0x0000000182414420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, AiSkillCdInfo> AiCdMap { get => default; } // 0x0000000182414AA0-0x0000000182414B00 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23093
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23094
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 336
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAiSyncSkillCdNotify() {} // 0x0000000182414EF0-0x0000000182414F80
	static EvtAiSyncSkillCdNotify() {} // 0x0000000182414D90-0x0000000182414EF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAiSyncSkillCdNotify Clone() => default; // 0x0000000182414690-0x0000000182414780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAiSyncSkillCdNotify ShallowCopy() => default; // 0x0000000182414290-0x0000000182414330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182413DD0-0x0000000182413E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824148A0-0x00000001824148F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824148F0-0x0000000182414940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182413E20-0x0000000182413ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182413ED0-0x0000000182413FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtAiSyncSkillCdNotify other) => default; // 0x0000000182413FA0-0x0000000182414120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182414420-0x0000000182414510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182414C40-0x0000000182414D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824149A0-0x0000000182414AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182414120-0x0000000182414210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtAiSyncSkillCdNotify other) {} // 0x0000000182413CC0-0x0000000182413DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182413B30-0x0000000182413C60
}


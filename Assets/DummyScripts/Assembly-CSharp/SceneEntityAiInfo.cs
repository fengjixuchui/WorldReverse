/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntityAiInfo : MessageBase, IMessage<SceneEntityAiInfo> // TypeDefIndex: 26046
{
	// Fields
	private static readonly MessageParser<SceneEntityAiInfo> _parser; // 0x00
	public const int IsAiOpenFieldNumber = 1; // Metadata: 0x00B0ADFB
	private bool isAiOpen_; // 0x18
	public const int BornPosFieldNumber = 2; // Metadata: 0x00B0ADFF
	private Vector bornPos_; // 0x20
	public const int SkillCdMapFieldNumber = 3; // Metadata: 0x00B0AE03
	private static readonly MapField<uint, uint> _map_skillCdMap_codec; // 0x08
	private readonly MapField<uint, uint> skillCdMap_; // 0x28
	public const int ServantInfoFieldNumber = 4; // Metadata: 0x00B0AE07
	private ServantInfo servantInfo_; // 0x30
	public const int AiThreatMapFieldNumber = 5; // Metadata: 0x00B0AE0B
	private static readonly MapField<uint, uint> _map_aiThreatMap_codec; // 0x10
	private readonly MapField<uint, uint> aiThreatMap_; // 0x38
	public const int SkillGroupCdMapFieldNumber = 6; // Metadata: 0x00B0AE0F
	private static readonly MapField<uint, uint> _map_skillGroupCdMap_codec; // 0x18
	private readonly MapField<uint, uint> skillGroupCdMap_; // 0x40
	public const int CurTacticFieldNumber = 7; // Metadata: 0x00B0AE13
	private uint curTactic_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntityAiInfo> Parser { get => default; } // 0x000000018172E900-0x000000018172E990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018172E590-0x000000018172E620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018172DED0-0x000000018172DF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018172D100-0x000000018172D160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018172F0F0-0x000000018172F1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018172ED20-0x000000018172ED80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018172E680-0x000000018172E770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018172F0A0-0x000000018172F0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018172E090-0x000000018172E180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAiOpen { get => default; set {} } // 0x000000018172E860-0x000000018172E900 0x000000018172F000-0x000000018172F0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector BornPos { get => default; set {} } // 0x000000018172EAC0-0x000000018172EB60 0x000000018172EC80-0x000000018172ED20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkillCdMap { get => default; } // 0x000000018172E620-0x000000018172E680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServantInfo ServantInfo { get => default; set {} } // 0x000000018172E990-0x000000018172EA30 0x000000018172E4F0-0x000000018172E590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> AiThreatMap { get => default; } // 0x000000018172D0A0-0x000000018172D100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkillGroupCdMap { get => default; } // 0x000000018172D160-0x000000018172D1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurTactic { get => default; set {} } // 0x000000018172D7E0-0x000000018172D880 0x000000018172DF50-0x000000018172DFF0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityAiInfo() {} // 0x000000018172F810-0x000000018172F8E0
	static SceneEntityAiInfo() {} // 0x000000018172F620-0x000000018172F810

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityAiInfo Clone() => default; // 0x000000018172E770-0x000000018172E860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityAiInfo ShallowCopy() => default; // 0x000000018172DFF0-0x000000018172E090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018172D450-0x000000018172D4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018172EB60-0x000000018172EBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018172EBF0-0x000000018172EC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018172D4E0-0x000000018172D7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018172D880-0x000000018172D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntityAiInfo other) => default; // 0x000000018172D950-0x000000018172DB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018172E180-0x000000018172E4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018172F1E0-0x000000018172F620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018172ED80-0x000000018172F000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018172DB90-0x000000018172DED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntityAiInfo other) {} // 0x000000018172D1C0-0x000000018172D450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018172CDC0-0x000000018172D0A0
}


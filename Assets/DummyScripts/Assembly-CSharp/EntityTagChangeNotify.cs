/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityTagChangeNotify : MessageBase, IMessage<EntityTagChangeNotify> // TypeDefIndex: 25358
{
	// Fields
	private static readonly MessageParser<EntityTagChangeNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B088AB
	private uint entityId_; // 0x18
	public const int IsAddFieldNumber = 2; // Metadata: 0x00B088AF
	private bool isAdd_; // 0x1C
	public const int TagFieldNumber = 3; // Metadata: 0x00B088B3
	private string tag_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityTagChangeNotify> Parser { get => default; } // 0x00000001856886C0-0x0000000185688750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185688450-0x00000001856884E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001856880E0-0x0000000185688160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001856879E0-0x0000000185687A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185688CA0-0x0000000185688D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185688A70-0x0000000185688AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001856884E0-0x00000001856885D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185688C50-0x0000000185688CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185688200-0x00000001856882F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001856889D0-0x0000000185688A70 0x0000000185688D90-0x0000000185688E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAdd { get => default; set {} } // 0x0000000185687940-0x00000001856879E0 0x00000001856887E0-0x0000000185688880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Tag { get => default; set {} } // 0x0000000185687A40-0x0000000185687AE0 0x0000000185688920-0x00000001856889D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25359
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25360
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3067
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityTagChangeNotify() {} // 0x0000000185689160-0x00000001856891D0
	static EntityTagChangeNotify() {} // 0x00000001856890A0-0x0000000185689160

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityTagChangeNotify Clone() => default; // 0x00000001856885D0-0x00000001856886C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityTagChangeNotify ShallowCopy() => default; // 0x0000000185688160-0x0000000185688200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185687C60-0x0000000185687CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185688880-0x00000001856888D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001856888D0-0x0000000185688920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185687CB0-0x0000000185687D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185687EB0-0x0000000185687F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityTagChangeNotify other) => default; // 0x0000000185687D40-0x0000000185687EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001856882F0-0x0000000185688450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185688E30-0x00000001856890A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185688AD0-0x0000000185688C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185687F80-0x00000001856880E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityTagChangeNotify other) {} // 0x0000000185687AE0-0x0000000185687C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185687830-0x0000000185687940
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShowCommonTipsNotify : MessageBase, IMessage<ShowCommonTipsNotify> // TypeDefIndex: 25296
{
	// Fields
	private static readonly MessageParser<ShowCommonTipsNotify> _parser; // 0x00
	public const int TitleFieldNumber = 1; // Metadata: 0x00B08667
	private string title_; // 0x18
	public const int ContentFieldNumber = 2; // Metadata: 0x00B0866B
	private string content_; // 0x20
	public const int CloseTimeFieldNumber = 3; // Metadata: 0x00B0866F
	private uint closeTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShowCommonTipsNotify> Parser { get => default; } // 0x0000000181219CE0-0x0000000181219D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001812199C0-0x0000000181219A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181219580-0x0000000181219600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181218D40-0x0000000181218DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018121A220-0x000000018121A310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181219FE0-0x000000018121A040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181219A50-0x0000000181219B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018121A1D0-0x000000018121A220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001812196A0-0x0000000181219790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Title { get => default; set {} } // 0x0000000181218DA0-0x0000000181218E40 0x0000000181219910-0x00000001812199C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Content { get => default; set {} } // 0x0000000181219E00-0x0000000181219EA0 0x0000000181219C30-0x0000000181219CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CloseTime { get => default; set {} } // 0x0000000181219F40-0x0000000181219FE0 0x0000000181218E40-0x0000000181218EE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25297
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25298
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3047
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowCommonTipsNotify() {} // 0x000000018121A630-0x000000018121A6B0
	static ShowCommonTipsNotify() {} // 0x000000018121A570-0x000000018121A630

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowCommonTipsNotify Clone() => default; // 0x0000000181219B40-0x0000000181219C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowCommonTipsNotify ShallowCopy() => default; // 0x0000000181219600-0x00000001812196A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181219070-0x00000001812190C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181219EA0-0x0000000181219EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181219EF0-0x0000000181219F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001812190C0-0x0000000181219150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001812192F0-0x00000001812193C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShowCommonTipsNotify other) => default; // 0x0000000181219150-0x00000001812192F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181219790-0x0000000181219910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018121A310-0x000000018121A570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018121A040-0x000000018121A1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001812193C0-0x0000000181219580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShowCommonTipsNotify other) {} // 0x0000000181218EE0-0x0000000181219070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181218C30-0x0000000181218D40
}


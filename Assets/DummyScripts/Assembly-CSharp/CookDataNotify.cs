/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CookDataNotify : MessageBase, IMessage<CookDataNotify> // TypeDefIndex: 24388
{
	// Fields
	private static readonly MessageParser<CookDataNotify> _parser; // 0x00
	public const int GradeFieldNumber = 1; // Metadata: 0x00B0654B
	private uint grade_; // 0x18
	public const int RecipeDataListFieldNumber = 2; // Metadata: 0x00B0654F
	private static readonly FieldCodec<CookRecipeData> _repeated_recipeDataList_codec; // 0x08
	private readonly RepeatedMessageField<CookRecipeData> recipeDataList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CookDataNotify> Parser { get => default; } // 0x00000001813E8BF0-0x00000001813E8C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001813E8920-0x00000001813E89B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001813E8570-0x00000001813E85F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001813E7F40-0x00000001813E7FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001813E90C0-0x00000001813E91B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001813E8ED0-0x00000001813E8F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001813E8A10-0x00000001813E8B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001813E9070-0x00000001813E90C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001813E8730-0x00000001813E8820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Grade { get => default; set {} } // 0x00000001813E8DA0-0x00000001813E8E40 0x00000001813E85F0-0x00000001813E8690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CookRecipeData> RecipeDataList { get => default; } // 0x00000001813E89B0-0x00000001813E8A10 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24389
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24390
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 130
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookDataNotify() {} // 0x00000001813E94A0-0x00000001813E9530
	static CookDataNotify() {} // 0x00000001813E9390-0x00000001813E94A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookDataNotify Clone() => default; // 0x00000001813E8B00-0x00000001813E8BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookDataNotify ShallowCopy() => default; // 0x00000001813E8690-0x00000001813E8730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001813E8100-0x00000001813E8150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813E8D10-0x00000001813E8DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813E8E40-0x00000001813E8ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001813E8150-0x00000001813E8230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001813E8230-0x00000001813E8300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CookDataNotify other) => default; // 0x00000001813E8300-0x00000001813E8430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001813E8820-0x00000001813E8920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001813E91B0-0x00000001813E9390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001813E8F30-0x00000001813E9070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001813E8430-0x00000001813E8570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CookDataNotify other) {} // 0x00000001813E7FA0-0x00000001813E8100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813E7DE0-0x00000001813E7F40
}


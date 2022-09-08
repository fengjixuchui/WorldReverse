/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CookRecipeData : MessageBase, IMessage<CookRecipeData> // TypeDefIndex: 24387
{
	// Fields
	private static readonly MessageParser<CookRecipeData> _parser; // 0x00
	public const int RecipeIdFieldNumber = 1; // Metadata: 0x00B06543
	private uint recipeId_; // 0x18
	public const int ProficiencyFieldNumber = 2; // Metadata: 0x00B06547
	private uint proficiency_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CookRecipeData> Parser { get => default; } // 0x0000000182D41C90-0x0000000182D41D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D41980-0x0000000182D41A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D415D0-0x0000000182D41650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D41060-0x0000000182D410C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D42160-0x0000000182D42250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D41F90-0x0000000182D41FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D41A10-0x0000000182D41B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D42110-0x0000000182D42160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D416F0-0x0000000182D417E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RecipeId { get => default; set {} } // 0x0000000182D41BF0-0x0000000182D41C90 0x0000000182D41EF0-0x0000000182D41F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Proficiency { get => default; set {} } // 0x0000000182D41E00-0x0000000182D41EA0 0x0000000182D418E0-0x0000000182D41980

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookRecipeData() {} // 0x0000000182D42510-0x0000000182D42570
	static CookRecipeData() {} // 0x0000000182D42450-0x0000000182D42510

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookRecipeData Clone() => default; // 0x0000000182D41B00-0x0000000182D41BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookRecipeData ShallowCopy() => default; // 0x0000000182D41650-0x0000000182D416F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D411F0-0x0000000182D41240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D41DB0-0x0000000182D41E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D41EA0-0x0000000182D41EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D41240-0x0000000182D412B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D413D0-0x0000000182D414A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CookRecipeData other) => default; // 0x0000000182D412B0-0x0000000182D413D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D417E0-0x0000000182D418E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D42250-0x0000000182D42450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D41FF0-0x0000000182D42110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D414A0-0x0000000182D415D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CookRecipeData other) {} // 0x0000000182D410C0-0x0000000182D411F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D40F60-0x0000000182D41060
}


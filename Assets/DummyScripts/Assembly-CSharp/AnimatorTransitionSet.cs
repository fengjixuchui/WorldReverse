/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AnimatorTransitionSet // TypeDefIndex: 32192
{
	// Fields
	public static AnimatorTransitionSet EMPTY; // 0x00
	[NonSerialized]
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public AnimatorTransitionEntry[] Transitions; // 0x10
	[NonSerialized]
	public int[] PossibleFromHashes; // 0x18
	[NonSerialized]
	public int[] PossibleToHashes; // 0x20
	[NonSerialized]
	public int[] PossibleFromTagHashes; // 0x28
	[NonSerialized]
	public int[] PossibleToTagHashes; // 0x30
	private static AnimatorTransitionEntry _temp_match_entry; // 0x08

	// Constructors
	public AnimatorTransitionSet() {} // 0x000000018111D340-0x000000018111D450
	static AnimatorTransitionSet() {} // 0x000000018111D2C0-0x000000018111D340

	// Methods
	// [XID] // 0x0000000189673F60-0x0000000189673F80
	public void OnLevelLoaded() {} // 0x000000018111CAA0-0x000000018111D120
	// [IDTag] // 0x000000018967B7C0-0x000000018967B800
	// [XID] // 0x000000018967B7C0-0x000000018967B800
	public bool IsMatch(int fromHash, int toHash) => default; // 0x000000018111C990-0x000000018111CAA0
	// [IDTag] // 0x0000000189685D90-0x0000000189685DD0
	// [XID] // 0x0000000189685D90-0x0000000189685DD0
	public bool IsMatch(int fromHash, int toHash, out AnimatorTransitionEntry matchedEntry) {
		matchedEntry = default;
		return default;
	} // 0x000000018111C360-0x000000018111C540
	// [IDTag] // 0x0000000189690F20-0x0000000189690F60
	// [XID] // 0x0000000189690F20-0x0000000189690F60
	public bool IsMatch(int fromHash, int fromTagHash, int toHash, int toTagHash) => default; // 0x000000018111C850-0x000000018111C990
	// [IDTag] // 0x000000018969B310-0x000000018969B350
	// [XID] // 0x000000018969B310-0x000000018969B350
	public bool IsMatch(int fromHash, int fromTagHash, int toHash, int toTagHash, out AnimatorTransitionEntry matchedEntry) {
		matchedEntry = default;
		return default;
	} // 0x000000018111C540-0x000000018111C850
	// [XID] // 0x00000001896A54F0-0x00000001896A5510
	public override string ToString() => default; // 0x000000018111D120-0x000000018111D2C0
}


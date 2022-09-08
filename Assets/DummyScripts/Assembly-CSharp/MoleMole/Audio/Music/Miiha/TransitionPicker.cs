/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Music.Miiha
{
	public abstract class TransitionPicker // TypeDefIndex: 11377
	{
		// Constructors
		protected TransitionPicker() {} // 0x0000000182DDC4B0-0x0000000182DDC510
	
		// Methods
		// [XID] // 0x0000000189811D80-0x0000000189811DA0
		protected static int PickShifter(GameParamStorage gameParamStorage, ConfigMusicTransitions localTransitions, ConfigMusicTransitions globalTransitions, TransitionProposer proposer) => default; // 0x0000000182DDC330-0x0000000182DDC4B0
		// [XID] // 0x0000000189819A10-0x0000000189819A30
		protected static bool IsValidTransitionConfig(ConfigMusicTransitions config) => default; // 0x0000000182DDC0F0-0x0000000182DDC1C0
		// [XID] // 0x00000001898211E0-0x0000000189821200
		protected static int PickShifterFromTransitions(GameParamStorage gameParamStorage, ConfigMusicTransitions transitions, ConditionLookup conditionLookup) => default; // 0x0000000182DDC1C0-0x0000000182DDC330
	}
}

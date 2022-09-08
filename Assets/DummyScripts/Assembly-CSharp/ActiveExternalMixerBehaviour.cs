/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActiveExternalMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26122
{
	// Fields
	private GameObject _trackObj; // 0x10
	private static ulong _preFrameId; // 0x00
	private static Dictionary<int, bool> _frameActiveDic; // 0x08

	// Constructors
	public ActiveExternalMixerBehaviour() {} // 0x0000000182DE2680-0x0000000182DE26F0
	static ActiveExternalMixerBehaviour() {} // 0x0000000182DE25E0-0x0000000182DE2680

	// Methods
	// [XID] // 0x00000001896472C0-0x00000001896472E0
	public static void Add(int instId) {} // 0x0000000182DE1DF0-0x0000000182DE1F80
	// [XID] // 0x000000018964E9B0-0x000000018964E9D0
	public static bool Has(int instId) => default; // 0x0000000182DE1F80-0x0000000182DE2070
	// [XID] // 0x0000000189656250-0x0000000189656270
	private bool GetTrackBinding(object playerData) => default; // 0x0000000182DE1BE0-0x0000000182DE1D20
	// [XID] // 0x000000018965D940-0x000000018965D960
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000182DE2070-0x0000000182DE25E0
}


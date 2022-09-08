/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugHideShowObjDialogContext : BaseDialogContext // TypeDefIndex: 28614
{
	// Fields
	private MonoInLevelDebugHideShowObjDialog _pageMono; // 0x178
	private const string EFFECT_POOL_NAME = "Eff_Pool"; // Metadata: 0x00B0DA2B
	private UnityEngine.ShadowQuality _cacheShadowQuality; // 0x180

	// Nested types
	[Serializable]
	public class HideShowObjData // TypeDefIndex: 28615
	{
		// Fields
		public DebugHideObjType objType; // 0x10
		public string[] shaderPaths; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool onShow; // 0x20
		private int[] _shaderHashes; // 0x28
		public List<GameObject> hideObjs; // 0x30

		// Constructors
		public HideShowObjData() {} // 0x00000001829F4770-0x00000001829F4800

		// Methods
		// [XID] // 0x00000001899DCDF0-0x00000001899DCE10
		public void InitData() {} // 0x00000001829F45E0-0x00000001829F4770
		// [XID] // 0x00000001899E49D0-0x00000001899E49F0
		public int[] GetShaderHashArr() => default; // 0x00000001829F4540-0x00000001829F45E0
	}

	// Constructors
	public InLevelDebugHideShowObjDialogContext() {} // 0x0000000182A116E0-0x0000000182A117A0

	// Methods
	// [XID] // 0x000000018998A570-0x000000018998A590
	public override void SetupView() {} // 0x0000000182A11340-0x0000000182A116E0
	// [XID] // 0x0000000189991EA0-0x0000000189991EC0
	public void SetDebugHideObject(DebugHideObjType type, bool show) {} // 0x0000000182A0FD50-0x0000000182A0FE90
	// [XID] // 0x0000000189999BB0-0x0000000189999BD0
	public void ToggleDebugHideObject(DebugHideObjType type) {} // 0x0000000182A101F0-0x0000000182A109D0
	// [XID] // 0x00000001899A12C0-0x00000001899A12E0
	public void OnButtonClicked(DebugHideObjType objType) {} // 0x0000000182A10DB0-0x0000000182A10E80
	// [XID] // 0x00000001899A8D10-0x00000001899A8D30
	public static void SetTerrainEnable(bool enable) {} // 0x0000000182A109D0-0x0000000182A10BC0
	// [XID] // 0x00000001899B0690-0x00000001899B06B0
	private void SetEffectEnable(bool enable) {} // 0x0000000182A0FE90-0x0000000182A10050
	// [XID] // 0x00000001899B79C0-0x00000001899B79E0
	private void SetReflectionProbeEnable(bool enable) {} // 0x0000000182A10E80-0x0000000182A11080
	// [XID] // 0x00000001899BF360-0x00000001899BF380
	private void SetShadowEnable(bool enable) {} // 0x0000000182A10BC0-0x0000000182A10D50
	// [XID] // 0x00000001899C6D50-0x00000001899C6D70
	public static void SetGrassEnable(bool enable) {} // 0x0000000182A10050-0x0000000182A101F0
	// [XID] // 0x00000001899CE280-0x00000001899CE2A0
	private void PrintAllShader(HideShowObjData configData) {} // 0x0000000182A11080-0x0000000182A11340
}


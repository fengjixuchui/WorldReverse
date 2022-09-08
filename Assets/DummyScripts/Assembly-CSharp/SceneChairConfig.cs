/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public sealed class SceneChairConfig : ScenePropBaseConfig // TypeDefIndex: 31851
{
	// Fields
	public int sitDownPerformID; // 0x18
	public int sitUpPerformID; // 0x1C
	public int sitDownFreeStyleType; // 0x20
	public int sitUpFreeStyleType; // 0x24
	private SitAnimPattern sitAnimPattern; // 0x28
	public SitDownPoint[] sitDownPoints; // 0x30
	public int[] sitSlotMap; // 0x38
	public float inteeDistance; // 0x40
	public static Dictionary<SitDirection, SitAnimParams> SitAnims; // 0x00

	// Nested types
	public enum SitDirection // TypeDefIndex: 31852
	{
		LeftOfChair = -1,
		FrontOfChair = 0,
		RightOfChair = 1
	}

	[Serializable]
	public class SitDownPoint // TypeDefIndex: 31853
	{
		// Fields
		public Vector3 sitDownPointOffset; // 0x10
		public float SitRotationYaw; // 0x1C
		public SitDirection[] enterSitDirections; // 0x20
		public SitDirection[] hideStandDirections; // 0x28
		public int sitSlotIndex; // 0x30

		// Constructors
		public SitDownPoint() {} // 0x0000000181B5E930-0x0000000181B5E990
	}

	public struct SitDownData // TypeDefIndex: 31854
	{
		// Fields
		public int sitPointIndex; // 0x00
		public int slotIndex; // 0x04
		public SitDirection enterDirection; // 0x08

		// Constructors
		public SitDownData(int index, int slotIndex, SitDirection direction) {
			sitPointIndex = default;
			this.slotIndex = default;
			enterDirection = default;
		} // 0x0000000181B5E920-0x0000000181B5E930
	}

	[Serializable]
	public class SitAnimPattern // TypeDefIndex: 31855
	{
		// Fields
		public int sitDownPerformID; // 0x10
		public SitAnimParams LeftOfChair; // 0x14
		public SitAnimParams FrontOfChair; // 0x24
		public SitAnimParams RightOfChair; // 0x34

		// Constructors
		public SitAnimPattern() {} // Dummy constructor
		public SitAnimPattern(int sitPerformID) {} // 0x0000000181B5E490-0x0000000181B5E920
	}

	[Serializable]
	public struct SitAnimParams // TypeDefIndex: 31856
	{
		// Fields
		public Vector3 offset; // 0x00
		public float angle; // 0x0C

		// Constructors
		public SitAnimParams(Vector3 offset, float angle) {
			this.offset = default;
			this.angle = default;
		} // 0x0000000181B5E400-0x0000000181B5E490
	}

	// Constructors
	public SceneChairConfig() {} // 0x0000000181B5CC00-0x0000000181B5CCD0
	static SceneChairConfig() {} // 0x0000000181B5C940-0x0000000181B5CC00

	// Methods
	public void SetSitAnimPattern(SitAnimPattern pattern) {} // 0x0000000181B5C8E0-0x0000000181B5C940
	public SitAnimParams GetSitAnimParam(SitDirection direction) => default; // 0x0000000181B5C780-0x0000000181B5C8E0
}


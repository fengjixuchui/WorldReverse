/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ResourceDebugMonitor // TypeDefIndex: 27768
{
	// Nested types
	private class ObjectInfo // TypeDefIndex: 27769
	{
		// Fields
		public string name; // 0x10
		public int instanceid; // 0x18
		public Vector3 position; // 0x1C
		public int size; // 0x28
		public bool isActive; // 0x2C
		public bool isVisable; // 0x2D

		// Constructors
		public ObjectInfo() {} // 0x000000018128D2E0-0x000000018128D340
	}

	private class ObjectSet // TypeDefIndex: 27770
	{
		// Fields
		public int count; // 0x10
		public long size; // 0x18
		public ObjectInfo[] infoSet; // 0x20

		// Constructors
		public ObjectSet() {} // 0x000000018128D270-0x000000018128D2E0
	}

	private class RenderInfo : ObjectInfo // TypeDefIndex: 27771
	{
		// Fields
		public bool isRendering; // 0x30

		// Constructors
		public RenderInfo() {} // 0x000000018128CC10-0x000000018128CD30
	}

	private class AnimatorInfo : ObjectInfo // TypeDefIndex: 27772
	{
		// Fields
		public int cullingMode; // 0x30

		// Constructors
		public AnimatorInfo() {} // 0x000000018128CDC0-0x000000018128CE60
	}

	private class ParticleInfo : ObjectInfo // TypeDefIndex: 27773
	{
		// Fields
		public bool isAlive; // 0x30
		public bool isUpdate; // 0x31
		public bool isEmitting; // 0x32
		public bool isPlaying; // 0x33
		public bool isPaused; // 0x34
		public bool isStopped; // 0x35

		// Constructors
		public ParticleInfo() {} // 0x000000018128D1D0-0x000000018128D270
	}

	private class GameObjectInfo : ObjectInfo // TypeDefIndex: 27774
	{
		// Constructors
		public GameObjectInfo() {} // 0x00000001812B85E0-0x00000001812B8780
	}

	// Constructors
	public ResourceDebugMonitor() {} // 0x000000018129DE70-0x000000018129DED0

	// Methods
	// [XID] // 0x0000000189A73A20-0x0000000189A73A40
	public static void GetRenderDetail() {} // 0x000000018129C8E0-0x000000018129CAF0
	// [XID] // 0x0000000189A7B4E0-0x0000000189A7B500
	public static void GetAnimatorDetail() {} // 0x000000018129C4C0-0x000000018129C6D0
	// [XID] // 0x0000000189A82BA0-0x0000000189A82BC0
	public static void GetParticleDetail() {} // 0x000000018129B3C0-0x000000018129B5D0
	// [XID] // 0x0000000189A8A5F0-0x0000000189A8A610
	public static void GetResourceSet() {} // 0x000000018129CE00-0x000000018129D010
	// [XID] // 0x0000000189A91DD0-0x0000000189A91DF0
	public static void GetStartResourceSet() {} // 0x000000018129C6D0-0x000000018129C8E0
	// [XID] // 0x0000000189A99820-0x0000000189A99840
	public static void GetGameObjectDetail() {} // 0x000000018129B1B0-0x000000018129B3C0
	// [XID] // 0x0000000189AA08B0-0x0000000189AA08D0
	public static void AddResourceSet(StringBuilder buffer) {} // 0x000000018129AA80-0x000000018129AE80
	// [XID] // 0x0000000189AA7EB0-0x0000000189AA7ED0
	public static void AddStartResourceSet(StringBuilder buffer) {} // 0x000000018129BB50-0x000000018129BF50
	// [XID] // 0x0000000189AAFAB0-0x0000000189AAFAD0
	public static void AddRenderDetail(StringBuilder buffer) {} // 0x000000018129DB70-0x000000018129DE70
	// [XID] // 0x0000000189AB7270-0x0000000189AB7290
	public static void AddAnimatorDetail(StringBuilder buffer) {} // 0x000000018129B5D0-0x000000018129B8D0
	// [XID] // 0x0000000189ABEC80-0x0000000189ABECA0
	public static void AddParticleDetail(StringBuilder buffer) {} // 0x000000018129D7D0-0x000000018129DB70
	// [XID] // 0x0000000189AC67D0-0x0000000189AC67F0
	public static void AddGameObjectDetail(StringBuilder buffer) {} // 0x000000018129C1F0-0x000000018129C4C0
	// [XID] // 0x0000000189ACDEE0-0x0000000189ACDF00
	private static void AddObjectInfo(ObjectInfo info, StringBuilder buffer) {} // 0x000000018129D610-0x000000018129D7D0
	// [XID] // 0x0000000189AD5C40-0x0000000189AD5C60
	private static ObjectSet GetRenderSet() => default; // 0x000000018129D2E0-0x000000018129D610
	// [XID] // 0x0000000189ADD640-0x0000000189ADD660
	private static ObjectSet GetAnimatorSet() => default; // 0x000000018129CAF0-0x000000018129CE00
	// [XID] // 0x0000000189AE4D70-0x0000000189AE4D90
	private static ObjectSet GetParticleSet() => default; // 0x000000018129AE80-0x000000018129B1B0
	// [XID] // 0x0000000189AEC490-0x0000000189AEC4B0
	private static ObjectSet GetGameObjectSet() => default; // 0x000000018129D010-0x000000018129D2E0
	// [IDTag] // 0x0000000189AF3EB0-0x0000000189AF3EF0
	// [XID] // 0x0000000189AF3EB0-0x0000000189AF3EF0
	private static void GetObjectInfo(ObjectInfo info, Component component) {} // 0x000000018129C0A0-0x000000018129C1F0
	// [IDTag] // 0x0000000189AFE4C0-0x0000000189AFE500
	// [XID] // 0x0000000189AFE4C0-0x0000000189AFE500
	private static void GetObjectInfo(ObjectInfo info, GameObject gameObject) {} // 0x000000018129BF50-0x000000018129C0A0
	// [XID] // 0x0000000189B08B40-0x0000000189B08B60
	private static string GetPathName(Transform transform, int depth = 100 /* Metadata: 0x00B0CDC4 */) => default; // 0x000000018129B8D0-0x000000018129BB50
}


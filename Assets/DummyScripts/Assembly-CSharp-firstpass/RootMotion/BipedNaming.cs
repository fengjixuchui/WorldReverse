/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion
{
	public static class BipedNaming // TypeDefIndex: 9936
	{
		// Fields
		public static string[] typeLeft; // 0x00
		public static string[] typeRight; // 0x08
		public static string[] typeSpine; // 0x10
		public static string[] typeHead; // 0x18
		public static string[] typeArm; // 0x20
		public static string[] typeLeg; // 0x28
		public static string[] typeTail; // 0x30
		public static string[] typeEye; // 0x38
		public static string[] typeExclude; // 0x40
		public static string[] typeExcludeSpine; // 0x48
		public static string[] typeExcludeHead; // 0x50
		public static string[] typeExcludeArm; // 0x58
		public static string[] typeExcludeLeg; // 0x60
		public static string[] typeExcludeTail; // 0x68
		public static string[] typeExcludeEye; // 0x70
		public static string[] pelvis; // 0x78
		public static string[] hand; // 0x80
		public static string[] foot; // 0x88
	
		// Nested types
		[Serializable]
		public enum BoneType // TypeDefIndex: 9937
		{
			Unassigned = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Leg = 4,
			Tail = 5,
			Eye = 6
		}
	
		[Serializable]
		public enum BoneSide // TypeDefIndex: 9938
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming() {} // 0x00000001873388A0-0x000000018733B430
	
		// Methods
		// [XID] // 0x00000001899F0180-0x00000001899F01A0
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones) => default; // 0x0000000187338290-0x00000001873384C0
		// [XID] // 0x0000000189B2E860-0x0000000189B2E880
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones) => default; // 0x0000000187337F60-0x0000000187338190
		// [XID] // 0x0000000189B67B50-0x0000000189B67B70
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) => default; // 0x0000000187338190-0x0000000187338290
		// [XID] // 0x0000000189B93FB0-0x0000000189B93FD0
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) => default; // 0x00000001873384C0-0x00000001873385D0
		// [XID] // 0x0000000189928A50-0x0000000189928A70
		public static Transform GetNamingMatch(Transform[] transforms, params /* 0x000000018989F6F0-0x000000018989F700 */ string[][] namings) => default; // 0x00000001873385D0-0x0000000187338790
		// [XID] // 0x0000000189937410-0x0000000189937430
		public static BoneType GetBoneType(string boneName) => default; // 0x0000000187337C50-0x0000000187337E40
		// [XID] // 0x0000000189B35F30-0x0000000189B35F50
		public static BoneSide GetBoneSide(string boneName) => default; // 0x0000000187337B50-0x0000000187337C50
		// [XID] // 0x000000018992C0C0-0x000000018992C0E0
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x00AE6D14 */, params /* 0x000000018989F6F0-0x000000018989F700 */ string[][] namings) => default; // 0x0000000187337E40-0x0000000187337F60
		// [XID] // 0x0000000189B3D600-0x0000000189B3D620
		private static bool isLeft(string boneName) => default; // 0x000000018733B9A0-0x000000018733BB70
		// [XID] // 0x000000018995CAE0-0x000000018995CB00
		private static bool isRight(string boneName) => default; // 0x000000018733BCA0-0x000000018733BE70
		// [XID] // 0x0000000189964370-0x0000000189964390
		private static bool isSpine(string boneName) => default; // 0x000000018733BE70-0x000000018733BFA0
		// [XID] // 0x0000000189AA2FE0-0x0000000189AA3000
		private static bool isHead(string boneName) => default; // 0x000000018733B870-0x000000018733B9A0
		// [XID] // 0x00000001899735A0-0x00000001899735C0
		private static bool isArm(string boneName) => default; // 0x000000018733B610-0x000000018733B740
		// [XID] // 0x0000000189AC1350-0x0000000189AC1370
		private static bool isLeg(string boneName) => default; // 0x000000018733BB70-0x000000018733BCA0
		// [XID] // 0x0000000189AC8C80-0x0000000189AC8CA0
		private static bool isTail(string boneName) => default; // 0x000000018733BFA0-0x000000018733C0D0
		// [XID] // 0x0000000189989F30-0x0000000189989F50
		private static bool isEye(string boneName) => default; // 0x000000018733B740-0x000000018733B870
		// [XID] // 0x0000000189B85800-0x0000000189B85820
		private static bool isTypeExclude(string boneName) => default; // 0x000000018733C0D0-0x000000018733C1B0
		// [XID] // 0x00000001899993A0-0x00000001899993C0
		private static bool matchesNaming(string boneName, string[] namingConvention) => default; // 0x000000018733C3C0-0x000000018733C520
		// [XID] // 0x0000000189A9BB20-0x0000000189A9BB40
		private static bool excludesNaming(string boneName, string[] namingConvention) => default; // 0x000000018733B430-0x000000018733B540
		// [XID] // 0x0000000189B9B570-0x0000000189B9B590
		private static bool matchesLastLetter(string boneName, string[] namingConvention) => default; // 0x000000018733C290-0x000000018733C3C0
		// [XID] // 0x00000001899AFDF0-0x00000001899AFE10
		private static bool LastLetterIs(string boneName, string letter) => default; // 0x0000000187338790-0x00000001873388A0
		// [XID] // 0x000000018981D320-0x000000018981D340
		private static string firstLetter(string boneName) => default; // 0x000000018733B540-0x000000018733B610
		// [XID] // 0x00000001899BECE0-0x00000001899BED00
		private static string lastLetter(string boneName) => default; // 0x000000018733C1B0-0x000000018733C290
	}
}

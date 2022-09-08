/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class ComponentMetaTypeIDGenerator // TypeDefIndex: 7429
	{
		// Fields
		public const int derivedTypeIDMask = 4095; // Metadata: 0x00ADE9C0
		public const int baseTypeIDRightShift = 12; // Metadata: 0x00ADE9C4
		public const int baseTypeIDMask = 16773120; // Metadata: 0x00ADE9C8
		public const int fullTypeIDMask = 16777215; // Metadata: 0x00ADE9CC
		public const int otherThanTypeIDMask = -16777216; // Metadata: 0x00ADE9D0
		public const int lcvcTagRighShift = 24; // Metadata: 0x00ADE9D4
		public const int setIsLCFlag = 16777216; // Metadata: 0x00ADE9D8
		public const int clearIsLCFlag = -16777217; // Metadata: 0x00ADE9DC
		public const int typeCategoryComponent = 0; // Metadata: 0x00ADE9E0
		public const int typeCategoryPlugin = 1; // Metadata: 0x00ADE9E4
		public const int typeCategoryRightShift = 28; // Metadata: 0x00ADE9E8
		public const int otherThanTypeCategoryMask = 268435455; // Metadata: 0x00ADE9EC
		public const int typeCategoryMask = -268435456; // Metadata: 0x00ADE9F0
	
		// Methods
		// [XID] // 0x00000001896FC770-0x00000001896FC790
		public static int GetFullTypeID(int inMetaTypeID) => default; // 0x00000001858F5310-0x00000001858F53B0
		// [XID] // 0x0000000189A13C70-0x0000000189A13C90
		public static int GetDerivedTypeID(int inMetaTypeID) => default; // 0x00000001858F5270-0x00000001858F5310
		// [XID] // 0x000000018970B510-0x000000018970B530
		public static int GetBaseTypeID(int inMetaTypeID) => default; // 0x00000001858F51D0-0x00000001858F5270
		// [XID] // 0x0000000189A550F0-0x0000000189A55110
		public static bool IsSameCacheType(int metaTypeID1, int metaTypeID2) => default; // 0x00000001858F54F0-0x00000001858F55B0
		// [XID] // 0x000000018971A640-0x000000018971A660
		public static int SetTypeID(int inMetaTypeID, int baseTypeID, int derivedTypeID) => default; // 0x00000001858F5730-0x00000001858F5800
		// [XID] // 0x0000000189721880-0x00000001897218A0
		public static bool IsLC(int inMetaTypeID) => default; // 0x00000001858F5450-0x00000001858F54F0
		// [XID] // 0x0000000189728EC0-0x0000000189728EE0
		public static int SetIsLC(int inMetaTypeID, bool isLC) => default; // 0x00000001858F55B0-0x00000001858F5670
		// [XID] // 0x0000000189730890-0x00000001897308B0
		public static int GetTypeCategory(int inMetaTypeID) => default; // 0x00000001858F53B0-0x00000001858F5450
		// [XID] // 0x0000000189738140-0x0000000189738160
		public static int SetTypeCategory(int inMetaTypeID, int inTypeCategory) => default; // 0x00000001858F5670-0x00000001858F5730
		// [XID] // 0x000000018973FDC0-0x000000018973FDE0
		public static int GenerateMetaTypeID(bool isLC, int baseTypeID, int derivedTypeID) => default; // 0x00000001858F50E0-0x00000001858F51D0
	}
}

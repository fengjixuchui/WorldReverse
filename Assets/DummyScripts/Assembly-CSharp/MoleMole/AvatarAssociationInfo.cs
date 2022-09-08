/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189669D80-0x0000000189669DC0
	public class AvatarAssociationInfo : ScriptableObject // TypeDefIndex: 19598
	{
		// Fields
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public AssocInfo none; // 0x18
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public AssocInfo Mondstadt; // 0x20
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public AssocInfo Liyue; // 0x28
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public AssocInfo MainCharacter; // 0x30
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public AssocInfo Fatui; // 0x38
	
		// Nested types
		[Serializable]
		public class AssocInfo // TypeDefIndex: 19599
		{
			// Fields
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong pendantBgPathHash; // 0x10
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong nonePendantIconPathHash; // 0x18
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong firePendantIconPathHash; // 0x20
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong waterPendantIconPathHash; // 0x28
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong grassPendantIconPathHash; // 0x30
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong electricPendantIconPathHash; // 0x38
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong windPendantIconPathHash; // 0x40
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong icePendantIconPathHash; // 0x48
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong rockPendantIconPathHash; // 0x50
	
			// Constructors
			public AssocInfo() {} // 0x0000000182DBDC20-0x0000000182DBDC80
	
			// Methods
			// [XID] // 0x00000001896E2720-0x00000001896E2740
			public ulong GetPendantIconPathHashByElementType(ElementType elementType) => default; // 0x0000000182DBDB00-0x0000000182DBDC20
		}
	
		// Constructors
		public AvatarAssociationInfo() {} // 0x0000000182DBF8B0-0x0000000182DBF910
	
		// Methods
		// [XID] // 0x0000000189698D60-0x0000000189698D80
		public AssocInfo GetAssocInfo(AssocType assocType) => default; // 0x0000000182DBF7C0-0x0000000182DBF8B0
	}
}

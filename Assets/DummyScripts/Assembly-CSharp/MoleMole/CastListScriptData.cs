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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189BBAF80-0x0000000189BBAFD0
	public class CastListScriptData : ScriptableObject // TypeDefIndex: 19583
	{
		// Fields
		public const string ROLE_MAIN_CAMERA = "MainCamera"; // Metadata: 0x00AFCB4C
		public const string ROLE_MAIN_CAMERA_AUDIO = "MainCameraAudio"; // Metadata: 0x00AFCB5A
		public const string ROLE_LOCAL_AVATAR = "LocalAvatar"; // Metadata: 0x00AFCB6D
		public const string ROLE_OWNER_ACTOR = "OwnerActor"; // Metadata: 0x00AFCB7C
		public const string ROLE_LOCAL_OTHER = "LocalOther"; // Metadata: 0x00AFCB8A
		public const string ROLE_POST_STAND_IN = "_STAND_IN"; // Metadata: 0x00AFCB98
		private static readonly Dictionary<int, string> _bodyRoleLocalDic; // 0x00
		private static readonly Dictionary<int, string> _bodyRoleStandInDic; // 0x08
		private static readonly Dictionary<int, string> _bodyOtherStandInDic; // 0x10
		public bool bindMainCamera; // 0x18
		public bool bindMainCharactor; // 0x19
		// [Header] // 0x0000000189BC43C0-0x0000000189BC4420
		[SerializeField] // 0x0000000189BC43C0-0x0000000189BC4420
		[Space] // 0x0000000189BC43C0-0x0000000189BC4420
		public NpcRolePair[] npcCastList; // 0x20
		// [Header] // 0x0000000189BD3330-0x0000000189BD3390
		[SerializeField] // 0x0000000189BD3330-0x0000000189BD3390
		[Space] // 0x0000000189BD3330-0x0000000189BD3390
		public MapRolePair[] mapCastList; // 0x28
	
		// Properties
		public static Dictionary<int, string> bodyRoleLocalDic { /* [XID] */ /* 0x00000001895E75F0-0x00000001895E7610 */ get => default; } // 0x0000000181ADB440-0x0000000181ADB510 
		public static Dictionary<int, string> bodyRoleStandInDic { /* [XID] */ /* 0x00000001895F6900-0x00000001895F6920 */ get => default; } // 0x0000000181ADB510-0x0000000181ADB5E0 
		public static Dictionary<int, string> bodyOtherStandInDic { /* [XID] */ /* 0x00000001896054B0-0x00000001896054D0 */ get => default; } // 0x0000000181ADB370-0x0000000181ADB440 
	
		// Nested types
		[Serializable]
		public class BaseRolePair // TypeDefIndex: 19584
		{
			// Fields
			public string RoleName; // 0x10
	
			// Constructors
			public BaseRolePair() {} // 0x0000000181ACDC30-0x0000000181ACDCA0
		}
	
		[Serializable]
		public class NpcRolePair : BaseRolePair // TypeDefIndex: 19585
		{
			// Fields
			public uint npcConfigID; // 0x18
	
			// Constructors
			public NpcRolePair() {} // 0x0000000181AEC1F0-0x0000000181AEC2A0
		}
	
		[Serializable]
		public class MapRolePair : BaseRolePair // TypeDefIndex: 19586
		{
			// Fields
			public GroupEntityType groupEntityType; // 0x18
			public uint groupId; // 0x1C
			public uint mapInstId; // 0x20
	
			// Constructors
			public MapRolePair() {} // 0x0000000181AEC140-0x0000000181AEC1F0
		}
	
		// Constructors
		public CastListScriptData() {} // 0x0000000181ADB300-0x0000000181ADB370
		static CastListScriptData() {} // 0x0000000181ADAA10-0x0000000181ADB300
	
		// Methods
		// [XID] // 0x00000001895EEEC0-0x00000001895EEEE0
		public static string BODY2ROLE_LOCAL_AVATAR(BodyType bodyType) => default; // 0x0000000181ADA830-0x0000000181ADA920
		// [XID] // 0x00000001895FDCC0-0x00000001895FDCE0
		public static string BODY2ROLE_STAND_IN_AVATAR(BodyType bodyType) => default; // 0x0000000181ADA920-0x0000000181ADAA10
		// [XID] // 0x000000018960CEA0-0x000000018960CEC0
		public static string BODY2ROLE_STAND_IN_OTHER(BodyType bodyType) => default; // 0x0000000181ADA740-0x0000000181ADA830
	}
}

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
	public class MonoDamageTextContainer : MonoBehaviour // TypeDefIndex: 29708
	{
		// Fields
		private const string DAMAGE_TEXT_PATH = "ART/UI/Menus/Widget/InLevel/DamageText"; // Metadata: 0x00B0FCD3
		private const string REACTION_TEXT_PATH = "ART/UI/Menus/Widget/InLevel/DamageText_ElementReaction"; // Metadata: 0x00B0FCFD
		private LinkedList<MonoDamageText> _damageTextPool; // 0x18
		private LinkedList<MonoReactionText> _reactionTextPool; // 0x20
		private const float ShowIntervalTime = 2f; // Metadata: 0x00B0FD37
		private Dictionary<ElementReactionType, Dictionary<uint, float>> _reactionIntervalDict; // 0x28
		private static readonly ElementReactionType[] _elementReactionValues; // 0x00
	
		// Constructors
		static MonoDamageTextContainer() {} // 0x0000000183F3E560-0x0000000183F3E660
		public MonoDamageTextContainer() {} // 0x0000000183F3E660-0x0000000183F3E6D0
	
		// Methods
		// [XID] // 0x0000000189B9D170-0x0000000189B9D190
		private void Awake() {} // 0x0000000183F3CBB0-0x0000000183F3CDD0
		// [XID] // 0x0000000189BA4AD0-0x0000000189BA4AF0
		public void ShowCureText(BaseEntity target, float addHP) {} // 0x0000000183F3D6F0-0x0000000183F3D920
		// [IDTag] // 0x0000000189BABE30-0x0000000189BABE70
		// [XID] // 0x0000000189BABE30-0x0000000189BABE70
		public void ShowDamageText(AttackResult attackResult, BaseEntity attackee) {} // 0x0000000183F3D920-0x0000000183F3DB30
		// [IDTag] // 0x0000000189BB6360-0x0000000189BB63A0
		// [XID] // 0x0000000189BB6360-0x0000000189BB63A0
		public void ShowDamageText(ElementType elementType, Vector3 position, float damage, string showText, BaseEntity attackee) {} // 0x0000000183F3DB30-0x0000000183F3DC90
		// [XID] // 0x0000000189BC0F20-0x0000000189BC0F40
		public void ShowReactionText(ElementReactionType reaction, ElementType elemType1, ElementType elemType2, BaseEntity attackee) {} // 0x0000000183F3E460-0x0000000183F3E560
		// [XID] // 0x0000000189BC8670-0x0000000189BC8690
		public void ShowOneDamageText(ElementType type, MonoDamageText.DamageType damageType, MonoDamageText.DamageShowType showType, float damage, string showText, Vector3 worldPos, BaseEntity attackee) {} // 0x0000000183F3DC90-0x0000000183F3DFB0
		// [XID] // 0x0000000189BCFED0-0x0000000189BCFEF0
		public void ShowOneReactionText(ElementReactionType reaction, ElementType elemType1, ElementType elemType2, BaseEntity attackee) {} // 0x0000000183F3DFB0-0x0000000183F3E460
		// [XID] // 0x0000000189BD74D0-0x0000000189BD74F0
		public void ClearGameObjectCache() {} // 0x0000000183F3CDD0-0x0000000183F3CE80
		// [XID] // 0x0000000189BDF010-0x0000000189BDF030
		private void ClearDamageGameObjectCache() {} // 0x0000000183F3CE80-0x0000000183F3D030
		// [XID] // 0x00000001895EBC80-0x00000001895EBCA0
		private void ClearReactionGameObjectCache() {} // 0x0000000183F3D540-0x0000000183F3D6F0
		// [XID] // 0x00000001895F3020-0x00000001895F3040
		public Vector3 GetRandomDeltaDistance() => default; // 0x0000000183F3D1F0-0x0000000183F3D380
		// [XID] // 0x00000001895FA860-0x00000001895FA880
		private MonoDamageText FindAvailableInstanceFromCache() => default; // 0x0000000183F3D030-0x0000000183F3D1F0
		// [XID] // 0x0000000189602250-0x0000000189602270
		private MonoReactionText FindReactionInstanceFromCache() => default; // 0x0000000183F3D380-0x0000000183F3D540
	}
}

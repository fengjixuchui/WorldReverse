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
	public class MonoParticleDamageTextContainer : MonoBehaviour // TypeDefIndex: 29770
	{
		// Fields
		public ParticleSystem psNormal; // 0x18
		public ParticleSystem psCrit; // 0x20
		public ParticleSystem psSelfNormal; // 0x28
		public ParticleSystem psSelfCrit; // 0x30
		public List<Color> listTextColor; // 0x38
		public List<Color> listOutLineColor; // 0x40
		public ElementReactionType[] reactionTypeList; // 0x48
		public Color[] reactionTextColor; // 0x50
		public Color[] reactionOutLineColor; // 0x58
		private ParticleSystem.EmitParams param; // 0x60
		private const string CURE_TEXT_ATTACH_POINT = "MoveHead"; // Metadata: 0x00B0FEAA
		private Transform _attachPoint; // 0xE8
		private Vector3 _beginPosition; // 0xF0
		public float fontSizeDamage; // 0xFC
		public float fontSizeReaction; // 0x100
		public float fontSizeCritical; // 0x104
		public Vector3 velocity; // 0x108
		public int velocityPositiveMax; // 0x114
		public Vector3[] positionArr; // 0x118
		private int _reactionShowIndex; // 0x120
		private float _lastShowElementReactionTime; // 0x124
		public int greyIndex; // 0x128
		public int selfIndex; // 0x12C
		private Dictionary<ElementReactionType, string> _reactionTextDict; // 0x130
		private static ElementReactionType[] _elementReactionValues; // 0x00
		private ElementType[] _elementType; // 0x138
		private string _immuneText; // 0x140
		public string text; // 0x148
		private Dictionary<ElementReactionType, Dictionary<uint, float>> _reactionIntervalDict; // 0x150
		private Dictionary<ElementType, Dictionary<uint, float>> _elementImmuneIntervalDict; // 0x158
		private const float ShowIntervalTime = 1f; // Metadata: 0x00B0FEB6
		private const float ShowIntervalTimeImmune = 0.5f; // Metadata: 0x00B0FEBA
		public float textLifetime; // 0x160
		public float textLifetimeReaction; // 0x164
		public float randomMagitude; // 0x168
	
		// Nested types
		public enum PSDamageShowType // TypeDefIndex: 29771
		{
			Normal = 0,
			Resist = 1,
			Self = 2
		}
	
		// Constructors
		public MonoParticleDamageTextContainer() {} // 0x000000018371AF40-0x000000018371B230
	
		// Methods
		// [XID] // 0x0000000189910A40-0x0000000189910A60
		public void Init(Camera camera, Canvas canvas) {} // 0x0000000183718F10-0x00000001837194B0
		// [XID] // 0x0000000189918660-0x0000000189918680
		public void Clear() {} // 0x00000001837183B0-0x00000001837185B0
		// [XID] // 0x000000018991FE60-0x000000018991FE80
		private void InitParticel(ParticleSystem ps, Camera camera, Canvas canvas) {} // 0x0000000183718A50-0x0000000183718CB0
		// [XID] // 0x00000001899276C0-0x00000001899276E0
		public void ShowCureText(BaseEntity target, float addHP) {} // 0x00000001837196E0-0x0000000183719BF0
		// [IDTag] // 0x000000018992EE20-0x000000018992EE60
		// [XID] // 0x000000018992EE20-0x000000018992EE60
		public void ShowDamageText(AttackResult attackResult, BaseEntity attackee) {} // 0x0000000183719D50-0x0000000183719F90
		// [XID] // 0x0000000189939700-0x0000000189939720
		private void ShowImmuneText(ElementType type, BaseEntity attackee) {} // 0x00000001837185B0-0x0000000183718A50
		// [IDTag] // 0x0000000189940990-0x00000001899409D0
		// [XID] // 0x0000000189940990-0x00000001899409D0
		public void ShowDamageText(ElementType elementType, Vector3 position, float damage, string showText, BaseEntity attackee) {} // 0x0000000183719BF0-0x0000000183719D50
		// [XID] // 0x000000018994B190-0x000000018994B1B0
		public void ShowOneDamageText(ElementType type, MonoDamageText.DamageType damageType, MonoDamageText.DamageShowType showType, float damage, string showText, Vector3 worldPos, BaseEntity attackee, ElementReactionType elementReactionType = ElementReactionType.None /* Metadata: 0x00B0FEA6 */) {} // 0x0000000183719F90-0x000000018371A5D0
		// [XID] // 0x0000000189952BC0-0x0000000189952BE0
		public void ShowReactionText(ElementReactionType reaction, ElementType elemType1, ElementType elemType2, BaseEntity attackee, int hitIndex) {} // 0x000000018371A5D0-0x000000018371AC00
		// [XID] // 0x000000018995A150-0x000000018995A170
		public void ShowScoreText(int score, Vector3 worldPos) {} // 0x000000018371AC00-0x000000018371AF40
		// [XID] // 0x0000000189961B60-0x0000000189961B80
		private Vector3 posAdjust(Vector3 oriPos, float magnitude) => default; // 0x00000001837194B0-0x00000001837196E0
		// [XID] // 0x00000001899691F0-0x0000000189969210
		private Vector3 posAdjustReaction(Vector3 oriPos, int index) => default; // 0x0000000183718CB0-0x0000000183718F10
		// [XID] // 0x0000000189970C90-0x0000000189970CB0
		private Vector3 velocityAdjust() => default; // 0x0000000183718270-0x00000001837183B0
	}
}

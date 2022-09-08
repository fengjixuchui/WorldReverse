/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAvatarSkillItem : MonoSpriteProxy // TypeDefIndex: 30445
	{
		// Fields
		private const string SKILL_ICON_PATH = "ART/UI/Menus/Widget/CharacterPage/Btn_SkillIcon"; // Metadata: 0x00B10FD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillLevel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconRoot; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _highlightImg; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _clickBtn; // 0x40
		private MonoAvatarSkillIcon _skillIcon; // 0x48
	
		// Properties
		public Button clickBtn { /* [XID] */ /* 0x0000000189B88B10-0x0000000189B88B30 */ get => default; } // 0x0000000184228A40-0x0000000184228AE0 
		public MonoAvatarSkillIcon skillIcon { /* [XID] */ /* 0x0000000189B8FFE0-0x0000000189B90000 */ get => default; } // 0x0000000184228AE0-0x0000000184228CD0 
		public bool selected { /* [XID] */ /* 0x0000000189B97400-0x0000000189B97420 */ set {} } // 0x0000000184228CD0-0x0000000184228DF0
	
		// Constructors
		public MonoAvatarSkillItem() {} // 0x00000001842289C0-0x0000000184228A40
	
		// Methods
		// [XID] // 0x0000000189B9E8A0-0x0000000189B9E8C0
		public void SetSkillItem(CharacterPageContext.SkillBaseStruct skillStruct, bool isPreview, uint level, ElementType elemType) {} // 0x0000000184228390-0x00000001842289C0
		// [XID] // 0x0000000189BA6250-0x0000000189BA6270
		protected override void OnDestroy() {} // 0x0000000184228270-0x0000000184228390
	}
}

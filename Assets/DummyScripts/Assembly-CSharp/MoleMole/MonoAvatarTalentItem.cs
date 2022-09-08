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
	public class MonoAvatarTalentItem : MonoSpriteProxy // TypeDefIndex: 30450
	{
		// Fields
		private const string SMALL_TALENT_ICON_PATH = "ART/UI/Menus/Widget/CharacterPage/Btn_SmallTalent"; // Metadata: 0x00B1108C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _talentName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconRoot; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _clickBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _highlightImg; // 0x38
		private MonoAvatarTalentIcon _talentIcon; // 0x40
	
		// Properties
		public Button clickBtn { /* [XID] */ /* 0x00000001899A1000-0x00000001899A1020 */ get => default; } // 0x0000000184230CC0-0x0000000184230D60 
		public MonoAvatarTalentIcon talentIcon { /* [XID] */ /* 0x00000001899A8AD0-0x00000001899A8AF0 */ get => default; } // 0x0000000184230D60-0x0000000184230F50 
		public bool selected { /* [XID] */ /* 0x00000001899B0410-0x00000001899B0430 */ set {} } // 0x0000000184230F50-0x0000000184231070
	
		// Constructors
		public MonoAvatarTalentItem() {} // 0x0000000184230C40-0x0000000184230CC0
	
		// Methods
		// [XID] // 0x00000001899B7720-0x00000001899B7740
		public void SetTalentItem(uint talentId, ElementType elemType, bool isUnlock, bool isPreview, bool canUpgrade) {} // 0x000000018422FF50-0x0000000184230C40
		// [XID] // 0x00000001899BF100-0x00000001899BF120
		protected override void OnDestroy() {} // 0x000000018422FE30-0x000000018422FF50
	}
}

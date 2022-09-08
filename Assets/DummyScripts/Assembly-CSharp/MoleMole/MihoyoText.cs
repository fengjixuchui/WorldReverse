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
	public class MihoyoText : MonoBehaviour // TypeDefIndex: 30288
	{
		// Fields
		public bool useMutiFont; // 0x18
		public TextFontType textFontType; // 0x1C
		private LanguageType _currLanType; // 0x20
		private MaskableGraphic _textComponent; // 0x28
		private float _transMaxWidth; // 0x30
		private bool _checkThaiFlag; // 0x34
		private string _savedStr; // 0x38
	
		// Constructors
		public MihoyoText() {} // 0x000000018114D830-0x000000018114D8B0
	
		// Methods
		// [XID] // 0x0000000189A29FC0-0x0000000189A29FE0
		private void Awake() {} // 0x000000018114C540-0x000000018114C5E0
		// [XID] // 0x0000000189A314C0-0x0000000189A314E0
		private void Start() {} // 0x000000018114D6D0-0x000000018114D830
		// [XID] // 0x0000000189A38F70-0x0000000189A38F90
		private void OnDestroy() {} // 0x000000018114D4C0-0x000000018114D620
		// [XID] // 0x0000000189A406F0-0x0000000189A40710
		private void OnEnable() {} // 0x000000018114D620-0x000000018114D6D0
		// [XID] // 0x0000000189A47E10-0x0000000189A47E30
		private void CheckTextFont() {} // 0x000000018114C5E0-0x000000018114C6D0
		// [XID] // 0x0000000189A4F590-0x0000000189A4F5B0
		public void CheckTextFontByLanType(TextFontType fontType, LanguageType lanType) {} // 0x000000018114CC70-0x000000018114CF90
		// [XID] // 0x0000000189A56CB0-0x0000000189A56CD0
		public void CheckTextComponent() {} // 0x000000018114CB00-0x000000018114CC70
		// [XID] // 0x0000000189A5E800-0x0000000189A5E820
		private void CheckThaiWrapShell(bool force = false /* Metadata: 0x00B10970 */) {} // 0x000000018114C850-0x000000018114CB00
		// [XID] // 0x0000000189A65F80-0x0000000189A65FA0
		private void CheckThaiWrapShellCallBack() {} // 0x000000018114CF90-0x000000018114D030
		// [XID] // 0x0000000189A6D610-0x0000000189A6D630
		private void RebuildAllParentTrans(RectTransform _trans) {} // 0x000000018114C6D0-0x000000018114C850
		// [XID] // 0x0000000189A74D90-0x0000000189A74DB0
		private void CheckThaiWrap() {} // 0x000000018114D030-0x000000018114D4C0
	}
}
